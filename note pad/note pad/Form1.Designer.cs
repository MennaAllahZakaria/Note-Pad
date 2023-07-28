namespace note_pad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            font = new Button();
            print = new Button();
            save = new Button();
            italic = new Button();
            cut = new Button();
            copy = new Button();
            paste = new Button();
            bold = new Button();
            center = new Button();
            right = new Button();
            underline = new Button();
            left = new Button();
            open = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            font_color = new Button();
            back_color = new Button();
            zoomin = new Button();
            zoomout = new Button();
            richTextBox1 = new RichTextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(font);
            panel1.Controls.Add(print);
            panel1.Controls.Add(save);
            panel1.Controls.Add(italic);
            panel1.Controls.Add(cut);
            panel1.Controls.Add(copy);
            panel1.Controls.Add(paste);
            panel1.Controls.Add(bold);
            panel1.Controls.Add(center);
            panel1.Controls.Add(right);
            panel1.Controls.Add(underline);
            panel1.Controls.Add(left);
            panel1.Controls.Add(open);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 97);
            panel1.TabIndex = 0;
            // 
            // font
            // 
            font.Anchor = AnchorStyles.Top;
            font.BackgroundImage = (Image)resources.GetObject("font.BackgroundImage");
            font.FlatAppearance.BorderSize = 0;
            font.FlatStyle = FlatStyle.Flat;
            font.Location = new Point(619, 2);
            font.Name = "font";
            font.Size = new Size(95, 97);
            font.TabIndex = 12;
            font.UseVisualStyleBackColor = true;
            font.Click += font_Click;
            // 
            // print
            // 
            print.Anchor = AnchorStyles.Top;
            print.BackgroundImage = (Image)resources.GetObject("print.BackgroundImage");
            print.FlatAppearance.BorderSize = 0;
            print.FlatStyle = FlatStyle.Flat;
            print.Location = new Point(268, 2);
            print.Name = "print";
            print.Size = new Size(103, 92);
            print.TabIndex = 11;
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Top;
            save.BackgroundImage = (Image)resources.GetObject("save.BackgroundImage");
            save.FlatAppearance.BorderSize = 0;
            save.FlatStyle = FlatStyle.Flat;
            save.Location = new Point(159, -1);
            save.Name = "save";
            save.Size = new Size(103, 92);
            save.TabIndex = 10;
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // italic
            // 
            italic.Anchor = AnchorStyles.Top;
            italic.BackgroundImage = (Image)resources.GetObject("italic.BackgroundImage");
            italic.FlatAppearance.BorderSize = 0;
            italic.FlatStyle = FlatStyle.Flat;
            italic.Location = new Point(811, 3);
            italic.Name = "italic";
            italic.Size = new Size(100, 101);
            italic.TabIndex = 9;
            italic.UseVisualStyleBackColor = true;
            italic.Click += italic_click;
            // 
            // cut
            // 
            cut.Anchor = AnchorStyles.Top;
            cut.BackgroundImage = (Image)resources.GetObject("cut.BackgroundImage");
            cut.FlatAppearance.BorderSize = 0;
            cut.FlatStyle = FlatStyle.Flat;
            cut.Location = new Point(449, 2);
            cut.Name = "cut";
            cut.Size = new Size(103, 92);
            cut.TabIndex = 8;
            cut.UseVisualStyleBackColor = true;
            cut.Click += cut_Click;
            // 
            // copy
            // 
            copy.Anchor = AnchorStyles.Top;
            copy.BackgroundImage = (Image)resources.GetObject("copy.BackgroundImage");
            copy.FlatAppearance.BorderSize = 0;
            copy.FlatStyle = FlatStyle.Flat;
            copy.Location = new Point(377, 19);
            copy.Name = "copy";
            copy.Size = new Size(66, 67);
            copy.TabIndex = 7;
            copy.UseVisualStyleBackColor = true;
            copy.Click += copy_click;
            // 
            // paste
            // 
            paste.Anchor = AnchorStyles.Top;
            paste.BackgroundImage = (Image)resources.GetObject("paste.BackgroundImage");
            paste.FlatAppearance.BorderSize = 0;
            paste.FlatStyle = FlatStyle.Flat;
            paste.Location = new Point(548, 19);
            paste.Name = "paste";
            paste.Size = new Size(60, 67);
            paste.TabIndex = 6;
            paste.UseVisualStyleBackColor = true;
            paste.Click += paste_click;
            // 
            // bold
            // 
            bold.Anchor = AnchorStyles.Top;
            bold.BackgroundImage = (Image)resources.GetObject("bold.BackgroundImage");
            bold.FlatAppearance.BorderSize = 0;
            bold.FlatStyle = FlatStyle.Flat;
            bold.Location = new Point(720, 4);
            bold.Name = "bold";
            bold.Size = new Size(95, 97);
            bold.TabIndex = 5;
            bold.UseVisualStyleBackColor = true;
            bold.Click += bold_Click;
            // 
            // center
            // 
            center.Anchor = AnchorStyles.Top;
            center.BackgroundImage = (Image)resources.GetObject("center.BackgroundImage");
            center.FlatAppearance.BorderSize = 0;
            center.FlatStyle = FlatStyle.Flat;
            center.Location = new Point(1078, 4);
            center.Name = "center";
            center.Size = new Size(91, 91);
            center.TabIndex = 4;
            center.UseVisualStyleBackColor = true;
            center.Click += center_Click;
            // 
            // right
            // 
            right.Anchor = AnchorStyles.Top;
            right.BackgroundImage = (Image)resources.GetObject("right.BackgroundImage");
            right.FlatAppearance.BorderSize = 0;
            right.FlatStyle = FlatStyle.Flat;
            right.Location = new Point(1163, 2);
            right.Name = "right";
            right.Size = new Size(100, 94);
            right.TabIndex = 3;
            right.UseVisualStyleBackColor = true;
            right.Click += right_Click;
            // 
            // underline
            // 
            underline.Anchor = AnchorStyles.Top;
            underline.BackgroundImage = (Image)resources.GetObject("underline.BackgroundImage");
            underline.FlatAppearance.BorderSize = 0;
            underline.FlatStyle = FlatStyle.Flat;
            underline.Location = new Point(897, 7);
            underline.Name = "underline";
            underline.Size = new Size(93, 92);
            underline.TabIndex = 2;
            underline.UseVisualStyleBackColor = true;
            underline.Click += underline_Click;
            // 
            // left
            // 
            left.Anchor = AnchorStyles.Top;
            left.BackgroundImage = (Image)resources.GetObject("left.BackgroundImage");
            left.FlatAppearance.BorderSize = 0;
            left.FlatStyle = FlatStyle.Flat;
            left.Location = new Point(982, 7);
            left.Name = "left";
            left.Size = new Size(103, 88);
            left.TabIndex = 1;
            left.UseVisualStyleBackColor = true;
            left.Click += left_Click;
            // 
            // open
            // 
            open.Anchor = AnchorStyles.Top;
            open.BackgroundImage = (Image)resources.GetObject("open.BackgroundImage");
            open.FlatAppearance.BorderSize = 0;
            open.FlatStyle = FlatStyle.Flat;
            open.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            open.Location = new Point(58, 3);
            open.Name = "open";
            open.Size = new Size(89, 87);
            open.TabIndex = 0;
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(font_color);
            panel2.Controls.Add(back_color);
            panel2.Controls.Add(zoomin);
            panel2.Controls.Add(zoomout);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(1266, 107);
            panel2.TabIndex = 1;
            // 
            // font_color
            // 
            font_color.Anchor = AnchorStyles.Top;
            font_color.BackgroundImage = (Image)resources.GetObject("font_color.BackgroundImage");
            font_color.FlatAppearance.BorderSize = 0;
            font_color.FlatStyle = FlatStyle.Flat;
            font_color.Location = new Point(415, 6);
            font_color.Name = "font_color";
            font_color.Size = new Size(103, 92);
            font_color.TabIndex = 14;
            font_color.UseVisualStyleBackColor = true;
            font_color.Click += font_color_Click;
            // 
            // back_color
            // 
            back_color.Anchor = AnchorStyles.Top;
            back_color.BackgroundImage = (Image)resources.GetObject("back_color.BackgroundImage");
            back_color.FlatAppearance.BorderSize = 0;
            back_color.FlatStyle = FlatStyle.Flat;
            back_color.Location = new Point(539, 6);
            back_color.Name = "back_color";
            back_color.Size = new Size(103, 92);
            back_color.TabIndex = 13;
            back_color.UseVisualStyleBackColor = true;
            back_color.Click += back_color_Click;
            // 
            // zoomin
            // 
            zoomin.Anchor = AnchorStyles.Top;
            zoomin.BackgroundImage = (Image)resources.GetObject("zoomin.BackgroundImage");
            zoomin.FlatAppearance.BorderSize = 0;
            zoomin.FlatStyle = FlatStyle.Flat;
            zoomin.Location = new Point(670, 2);
            zoomin.Name = "zoomin";
            zoomin.Size = new Size(101, 98);
            zoomin.TabIndex = 12;
            zoomin.UseVisualStyleBackColor = true;
            zoomin.Click += zoom_in_Click;
            // 
            // zoomout
            // 
            zoomout.Anchor = AnchorStyles.Top;
            zoomout.BackgroundImage = (Image)resources.GetObject("zoomout.BackgroundImage");
            zoomout.FlatAppearance.BorderSize = 0;
            zoomout.FlatStyle = FlatStyle.Flat;
            zoomout.Location = new Point(790, 2);
            zoomout.Name = "zoomout";
            zoomout.Size = new Size(101, 101);
            zoomout.TabIndex = 11;
            zoomout.UseVisualStyleBackColor = true;
            zoomout.Click += zoom_out_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(0, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1266, 341);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 545);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Note Pad";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button open;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Button italic;
        private Button cut;
        private Button copy;
        private Button paste;
        private Button bold;
        private Button center;
        private Button right;
        private Button underline;
        private Button left;
        private Button save;
        private Button print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button font;
        private Button zoomin;
        private Button zoomout;
        private Button font_color;
        private Button back_color;
    }
}