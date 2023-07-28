using System.Windows.Forms;

namespace note_pad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Style == FontStyle.Bold)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);

            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);

            }

        }

        private void open_Click(object sender, EventArgs e)
        {
            var di = new OpenFileDialog();
            di.Filter = "Text Files|*.txt";
            di.FileName = "Txt" + ".txt";
            var res = di.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(di.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            var di = new SaveFileDialog();
            di.Filter = "Text Files|*.txt";
            di.FileName = "Txt" + ".txt";
            var res = di.ShowDialog();
            if (res == DialogResult.OK)
            {
                File.WriteAllText(di.FileName, richTextBox1.Text);
            }

        }

        private void cut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            catch { }

        }

        private void copy_click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.Text);

            }
            catch { }

        }

        private void paste_click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void italic_click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Style == FontStyle.Italic)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);

            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);

            }


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, new Point(100, 100));

        }

        private void font_Click(object sender, EventArgs e)
        {
            var difont = new FontDialog();
            var res = difont.ShowDialog();
            if (res == DialogResult.OK)
            {

                richTextBox1.Font = difont.Font;
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Style == FontStyle.Underline)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);

            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);

            }



        }

        private void left_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void right_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void center_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;


        }

        private void zoom_in_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 0.5f;
        }
        private void zoom_out_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor -= 0.5f;
        }

        private void font_color_Click(object sender, EventArgs e)
        {
            var font_color = new ColorDialog();
            var res = font_color.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.ForeColor = font_color.Color;
            }
        }

        private void back_color_Click(object sender, EventArgs e)
        {
            var back_color = new ColorDialog();
            var res = back_color.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.BackColor = back_color.Color;
            }
        }
    }
}