namespace form2
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
            Ok = new Button();
            EX = new Button();
            Dis = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Ok
            // 
            Ok.Location = new Point(60, 60);
            Ok.Name = "Ok";
            Ok.Size = new Size(50, 50);
            Ok.TabIndex = 0;
            Ok.Text = "ok";
            Ok.UseVisualStyleBackColor = true;
            // 
            // EX
            // 
            EX.Enabled = false;
            EX.Location = new Point(150, 60);
            EX.Name = "EX";
            EX.Size = new Size(50, 50);
            EX.TabIndex = 1;
            EX.Text = "sair";
            EX.UseVisualStyleBackColor = true;
            EX.Visible = false;
            // 
            // Dis
            // 
            Dis.Location = new Point(664, 334);
            Dis.Name = "Dis";
            Dis.Size = new Size(50, 50);
            Dis.TabIndex = 2;
            Dis.Text = "desativar";
            Dis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 74);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 3;
            label1.Text = "Bem-vindo ao projeto1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Dis);
            Controls.Add(EX);
            Controls.Add(Ok);
            ForeColor = Color.Red;
            MinimumSize = new Size(100, 100);
            Name = "Form1";
            Text = "worksheet1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ok;
        private Button EX;
        private Button Dis;
        private Label label1;
    }
}
