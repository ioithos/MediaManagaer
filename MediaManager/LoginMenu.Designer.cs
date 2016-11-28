namespace MediaManager
{
    partial class LoginMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login1Lbl = new System.Windows.Forms.Label();
            this.login1Txt = new System.Windows.Forms.TextBox();
            this.login2Txt = new System.Windows.Forms.TextBox();
            this.login1Btn = new System.Windows.Forms.Button();
            this.login2Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login1Lbl
            // 
            this.login1Lbl.AutoSize = true;
            this.login1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1Lbl.Location = new System.Drawing.Point(12, 122);
            this.login1Lbl.Name = "login1Lbl";
            this.login1Lbl.Size = new System.Drawing.Size(113, 26);
            this.login1Lbl.TabIndex = 0;
            this.login1Lbl.Text = "Username";
            // 
            // login1Txt
            // 
            this.login1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1Txt.Location = new System.Drawing.Point(108, 122);
            this.login1Txt.Name = "login1Txt";
            this.login1Txt.Size = new System.Drawing.Size(97, 32);
            this.login1Txt.TabIndex = 1;
            // 
            // login2Txt
            // 
            this.login2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login2Txt.Location = new System.Drawing.Point(105, 180);
            this.login2Txt.Name = "login2Txt";
            this.login2Txt.PasswordChar = '*';
            this.login2Txt.Size = new System.Drawing.Size(100, 32);
            this.login2Txt.TabIndex = 2;
            // 
            // login1Btn
            // 
            this.login1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1Btn.Location = new System.Drawing.Point(120, 227);
            this.login1Btn.Name = "login1Btn";
            this.login1Btn.Size = new System.Drawing.Size(146, 59);
            this.login1Btn.TabIndex = 3;
            this.login1Btn.Text = "Login";
            this.login1Btn.UseVisualStyleBackColor = true;
            this.login1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // login2Lbl
            // 
            this.login2Lbl.AutoSize = true;
            this.login2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login2Lbl.Location = new System.Drawing.Point(12, 180);
            this.login2Lbl.Name = "login2Lbl";
            this.login2Lbl.Size = new System.Drawing.Size(108, 26);
            this.login2Lbl.TabIndex = 4;
            this.login2Lbl.Text = "Password";
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.login2Lbl);
            this.Controls.Add(this.login1Btn);
            this.Controls.Add(this.login2Txt);
            this.Controls.Add(this.login1Txt);
            this.Controls.Add(this.login1Lbl);
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginMenu_FormClosed);
            this.Resize += new System.EventHandler(this.LoginMenu_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login1Lbl;
        private System.Windows.Forms.TextBox login1Txt;
        private System.Windows.Forms.TextBox login2Txt;
        private System.Windows.Forms.Button login1Btn;
        private System.Windows.Forms.Label login2Lbl;
    }
}