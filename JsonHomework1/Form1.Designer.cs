namespace JsonHomework1
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
            btnGoster = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnGoster
            // 
            btnGoster.BackColor = Color.Olive;
            btnGoster.ForeColor = SystemColors.Control;
            btnGoster.Location = new Point(298, 73);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(143, 54);
            btnGoster.TabIndex = 0;
            btnGoster.Text = "Verileri Oku";
            btnGoster.UseVisualStyleBackColor = false;
            btnGoster.Click += btnGoster_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(64, 64, 64);
            listBox1.ForeColor = SystemColors.InactiveBorder;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(48, 165);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(692, 224);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnGoster);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoster;
        private ListBox listBox1;
    }
}
