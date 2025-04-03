namespace WindowsFormHomework
{
    partial class WindowsFormHomework
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
            markaTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            bilgilerGoster = new Button();
            label6 = new Label();
            yakıtTextBox = new TextBox();
            pencereTextBox = new TextBox();
            label5 = new Label();
            kapıTextBox = new TextBox();
            label4 = new Label();
            renkTextBox = new TextBox();
            label3 = new Label();
            modelTextBox = new TextBox();
            label2 = new Label();
            formLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // markaTextBox
            // 
            markaTextBox.Location = new Point(18, 65);
            markaTextBox.Name = "markaTextBox";
            markaTextBox.Size = new Size(125, 27);
            markaTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Marka";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(bilgilerGoster);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(yakıtTextBox);
            panel1.Controls.Add(pencereTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(kapıTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(renkTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(modelTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(markaTextBox);
            panel1.Location = new Point(12, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 308);
            panel1.TabIndex = 2;
            // 
            // bilgilerGoster
            // 
            bilgilerGoster.BackColor = Color.Red;
            bilgilerGoster.ForeColor = SystemColors.ControlLightLight;
            bilgilerGoster.Location = new Point(383, 156);
            bilgilerGoster.Name = "bilgilerGoster";
            bilgilerGoster.Size = new Size(156, 51);
            bilgilerGoster.TabIndex = 4;
            bilgilerGoster.Text = "Bilgileri Göster";
            bilgilerGoster.UseVisualStyleBackColor = false;
            bilgilerGoster.Click += bilgilerGoster_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(791, 28);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 11;
            label6.Text = "Yaktığı Yakıt";
            // 
            // yakıtTextBox
            // 
            yakıtTextBox.Location = new Point(780, 65);
            yakıtTextBox.Name = "yakıtTextBox";
            yakıtTextBox.Size = new Size(124, 27);
            yakıtTextBox.TabIndex = 10;
            // 
            // pencereTextBox
            // 
            pencereTextBox.Location = new Point(617, 65);
            pencereTextBox.Name = "pencereTextBox";
            pencereTextBox.Size = new Size(124, 27);
            pencereTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(628, 28);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Pencere Sayısı";
            // 
            // kapıTextBox
            // 
            kapıTextBox.Location = new Point(463, 65);
            kapıTextBox.Name = "kapıTextBox";
            kapıTextBox.Size = new Size(125, 27);
            kapıTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 28);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Kapı Sayısı";
            label4.Click += label4_Click;
            // 
            // renkTextBox
            // 
            renkTextBox.Location = new Point(317, 65);
            renkTextBox.Name = "renkTextBox";
            renkTextBox.Size = new Size(125, 27);
            renkTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 28);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Renk";
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(171, 65);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(125, 27);
            modelTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 28);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formLabel.ForeColor = SystemColors.Highlight;
            formLabel.Location = new Point(368, 21);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(205, 33);
            formLabel.TabIndex = 3;
            formLabel.Text = "Araba Bilgileri";
            // 
            // WindowsFormHomework
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(973, 450);
            Controls.Add(formLabel);
            Controls.Add(panel1);
            Name = "WindowsFormHomework";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowsFormHomework";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox markaTextBox;
        private Label label1;
        private Panel panel1;
        private Label formLabel;
        private TextBox kapıTextBox;
        private Label label4;
        private TextBox renkTextBox;
        private Label label3;
        private TextBox modelTextBox;
        private Label label2;
        private Label label6;
        private TextBox yakıtTextBox;
        private TextBox pencereTextBox;
        private Label label5;
        private Button bilgilerGoster;
    }
}
