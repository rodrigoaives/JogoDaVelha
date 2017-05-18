namespace JogoDaVelha
{
    partial class Temas
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
            this.picDarkMountain = new System.Windows.Forms.PictureBox();
            this.btnDarkMountain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkMountain)).BeginInit();
            this.SuspendLayout();
            // 
            // picDarkMountain
            // 
            this.picDarkMountain.Image = global::JogoDaVelha.Properties.Resources.darkMountain;
            this.picDarkMountain.Location = new System.Drawing.Point(41, 48);
            this.picDarkMountain.Name = "picDarkMountain";
            this.picDarkMountain.Size = new System.Drawing.Size(230, 150);
            this.picDarkMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDarkMountain.TabIndex = 0;
            this.picDarkMountain.TabStop = false;
            // 
            // btnDarkMountain
            // 
            this.btnDarkMountain.Location = new System.Drawing.Point(41, 204);
            this.btnDarkMountain.Name = "btnDarkMountain";
            this.btnDarkMountain.Size = new System.Drawing.Size(230, 28);
            this.btnDarkMountain.TabIndex = 1;
            this.btnDarkMountain.Text = "Montanha Escura";
            this.btnDarkMountain.UseVisualStyleBackColor = true;
            this.btnDarkMountain.Click += new System.EventHandler(this.btnDarkMountain_Click);
            // 
            // Temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.btnDarkMountain);
            this.Controls.Add(this.picDarkMountain);
            this.Name = "Temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha o tema! :)";
            ((System.ComponentModel.ISupportInitialize)(this.picDarkMountain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDarkMountain;
        private System.Windows.Forms.Button btnDarkMountain;
    }
}