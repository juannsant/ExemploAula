﻿namespace ExemploAula
{
    partial class frmtellog
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
            lblsenha = new Label();
            txtusu = new TextBox();
            txtsenha = new TextBox();
            btnlogar = new Button();
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
            lblusu.Location = new Point(249, 147);
            lblusu.Name = "lblusu";
            lblusu.Size = new Size(81, 28);
            lblusu.TabIndex = 1;
            lblusu.Text = "Usuário";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(249, 219);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(68, 28);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // txtusu
            // 
            txtusu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusu.Location = new Point(373, 150);
            txtusu.Name = "txtusu";
            txtusu.Size = new Size(142, 25);
            txtusu.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsenha.Location = new Point(373, 225);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(142, 25);
            txtsenha.TabIndex = 4;
            // 
            // btnlogar
            // 
            btnlogar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogar.Location = new Point(320, 320);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(119, 54);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // frmtellog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogar);
            Controls.Add(txtsenha);
            Controls.Add(txtusu);
            Controls.Add(lblsenha);
            Controls.Add(lblusu);
            Controls.Add(lbllog);
            Name = "frmtellog";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllog;
        private Label lblusu;
        private Label lblsenha;
        private TextBox txtusu;
        private TextBox txtsenha;
        private Button btnlogar;
    }
}
