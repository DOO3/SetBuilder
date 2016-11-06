using SetBuilder.Library;
using SetBuilder.Library.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SetBuilder.Editor
{
    public partial class MainForm : Form
    {
        private ItemsSrorage _itemsSrorage { get; set; }

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            _itemsSrorage = new ItemsSrorage();
        }

        private void Update()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = _itemsSrorage.Items;
        }           

        private void sSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            Load();
            Update();
        }

        private void bClosePanel_Click(object sender, EventArgs e)
        {
            FormClose();
        }      

        private void bClose_Click(object sender, EventArgs e)
        {
            FormClose();
        }

        private void FormClose()
        {
            //TODO: Close message box
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var item = new Item();
            var form = new AddEditForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _itemsSrorage.Items.Add(item);
                Update();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
                return;

            var item = (Item)dgvItems.SelectedRows[0].DataBoundItem;
            var form = new AddEditForm(item);
            if (form.ShowDialog() == DialogResult.OK)
            {              
                Update();
            }
        }
        
        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
                return;

            _itemsSrorage.Items.Remove((Item)dgvItems.SelectedRows[0].DataBoundItem);
            Update();
        }

        private void Save() //save
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Items";
            sfd.Filter = "XML files(*.xml) | *.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ItemsSrorage));

                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(fs, _itemsSrorage);
                }
            }
        }

        private void Load () //load
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ItemsSrorage));

                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    _itemsSrorage = (ItemsSrorage)serializer.Deserialize(fs);
                }
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
