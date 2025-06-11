namespace ExemploAula
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
            lbllog = new Label();
            lblusu = new Label();
            SuspendLayout();
            // 
            // lbllog
            // 
            lbllog.AutoSize = true;
            lbllog.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllog.Location = new Point(320, 38);
            lbllog.Name = "lbllog";
            lbllog.Size = new Size(127, 54);
            lbllog.TabIndex = 0;
            lbllog.Text = "Login";
            // 
            // lblusu
            // 
            lblusu.AutoSize = true;
            lblusu.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusu.Location = new Point(185, 143);
            lblusu.Name = "lblusu";
            lblusu.Size = new Size(81, 28);
            lblusu.TabIndex = 1;
            lblusu.Text = "Usuário";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblusu);
            Controls.Add(lbllog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllog;
        private Label lblusu;
    }
}
