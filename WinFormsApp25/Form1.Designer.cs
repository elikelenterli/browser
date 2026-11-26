namespace WinFormsApp25
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel2 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            button7 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            //
            // panel1
            //
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 50);
            panel1.TabIndex = 0;
            //
            // button1
            //
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(40, 30);
            button1.TabIndex = 0;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // button2
            //
            button2.Location = new Point(55, 10);
            button2.Name = "button2";
            button2.Size = new Size(40, 30);
            button2.TabIndex = 1;
            button2.Text = "→";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // button3
            //
            button3.Location = new Point(100, 10);
            button3.Name = "button3";
            button3.Size = new Size(40, 30);
            button3.TabIndex = 2;
            button3.Text = "⟳";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            //
            // button4
            //
            button4.Location = new Point(145, 10);
            button4.Name = "button4";
            button4.Size = new Size(40, 30);
            button4.TabIndex = 3;
            button4.Text = "⌂";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            //
            // textBox1
            //
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(195, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(590, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "https://www.example.com";
            textBox1.KeyDown += textBox1_KeyDown;
            //
            // button5
            //
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(200, 245, 214);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(795, 10);
            button5.Name = "button5";
            button5.Size = new Size(65, 30);
            button5.TabIndex = 5;
            button5.Text = "Get";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            //
            // button6
            //
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Location = new Point(868, 10);
            button6.Name = "button6";
            button6.Size = new Size(40, 30);
            button6.TabIndex = 6;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            //
            // tabControl1
            //
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 670);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            //
            // tabPage1
            //
            tabPage1.Controls.Add(webView21);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(912, 637);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tab 1";
            tabPage1.UseVisualStyleBackColor = true;
            //
            // webView21
            //
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(912, 637);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            //
            // panel2
            //
            panel2.BackColor = Color.FromArgb(245, 248, 252);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(button7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(920, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 720);
            panel2.TabIndex = 2;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.Text = "Seçilmişlər (ListBox)";
            //
            // listBox1
            //
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 144);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label2.Location = new Point(12, 200);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.Text = "Tarixçə (ListBox)";
            //
            // listBox2
            //
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(12, 228);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(234, 244);
            listBox2.TabIndex = 1;
            listBox2.DoubleClick += listBox2_DoubleClick;
            //
            // button7
            //
            button7.BackColor = Color.FromArgb(255, 250, 190);
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(12, 490);
            button7.Name = "button7";
            button7.Size = new Size(234, 36);
            button7.TabIndex = 2;
            button7.Text = "Seçilmişlərə əlavə et";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 720);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1 - Mini Brauzer (WinForms + WebView2)";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Panel panel2;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private Button button7;
    }
}