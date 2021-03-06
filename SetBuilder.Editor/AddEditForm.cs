﻿using SetBuilder.Library;
using SetBuilder.Library.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetBuilder.Editor
{
    public partial class AddEditForm : Form
    {
        private Item _item { get; set; }
        private string _filepath { get; set; }

        public AddEditForm(Item item)
        {
            InitializeComponent();

            cbCategory.SelectedIndex = (int)item.Category;
            tbLevel.Text = item.Level.ToString();
            tbName.Text= item.Name;

            if(item.Classes != null)
            {
                foreach (var cl in item.Classes)
                {                  
                          
                    dgvClass.Rows.Add(cbClass.Items[(int)cl]);
                }
            }

            if (item.Stats != null)
            {
                foreach (var stat in item.Stats)
                {
                    dgvStats.Rows.Add(cbStat.Items[(int)stat.Key], stat.Value);
                }
            }

            _filepath = item.ImagePath;
            pbPicture.Image = item.Image;
            pbPicture.BackColor = Color.Transparent;

            _item = item; 

            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }      

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            _item.Name = tbName.Text;
            int lvl = 0;
            int.TryParse(tbLevel.Text, out lvl);
            _item.Level = lvl;
            _item.Category = (Category)cbCategory.SelectedIndex;


            _item.Classes = new List<Class>();

            for (int i = 0; i < dgvClass.Rows.Count - 1; i++)
            {
                var row = dgvClass.Rows[i];
                var cl = (Class)cbClass.Items.IndexOf(row.Cells[0].Value.ToString());
                _item.Classes.Add(cl);
            }

            _item.ImagePath = _filepath ?? Application.StartupPath + @"\Photo\Default.png";

            _item.Stats = new List<MyKeyValuePair<Stat, int>>();

            for (int i = 0; i < dgvStats.Rows.Count - 1; i++)
            {
                var row = dgvStats.Rows[i];
                Stat stat = (Stat)cbStat.Items.IndexOf(row.Cells[0].Value.ToString());
                int val = int.Parse(row.Cells[1].Value.ToString());
                _item.Stats.Add(new MyKeyValuePair<Stat, int>(stat, val));
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bPictureBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.png|";
            ofd.InitialDirectory = Application.StartupPath + @"\Photo";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbPicture.BackColor = Color.Transparent;
                pbPicture.Image = Bitmap.FromFile(ofd.FileName);
                _filepath = ofd.FileName;
            }

        }

        #region sizing

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), Top);
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), Left);
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), Right);
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), Bottom);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int tickness = 5;

        Rectangle Top => new Rectangle(0, 0, this.ClientSize.Width, tickness);
        Rectangle Left => new Rectangle(0, 0, tickness, this.ClientSize.Height);
        Rectangle Bottom => new Rectangle(0, this.ClientSize.Height - tickness, this.ClientSize.Width, tickness);
        Rectangle Right => new Rectangle(this.ClientSize.Width - tickness, 0, tickness, this.ClientSize.Height);

        Rectangle TopLeft => new Rectangle(0, 0, tickness, tickness);
        Rectangle TopRight => new Rectangle(this.ClientSize.Width - tickness, 0, tickness, tickness);
        Rectangle BottomLeft => new Rectangle(0, this.ClientSize.Height - tickness, tickness, tickness);

        Rectangle BottomRight => new Rectangle(this.ClientSize.Width - tickness, this.ClientSize.Height - tickness, tickness, tickness);


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        #endregion

        #region move

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void msMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion 
    }
}
