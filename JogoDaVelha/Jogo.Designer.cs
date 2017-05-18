namespace JogoDaVelha
{
    partial class DarkMountain
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
            this.components = new System.ComponentModel.Container();
            this.lblVez = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.timerGanhou = new System.Windows.Forms.Timer(this.components);
            this.Placar = new System.Windows.Forms.GroupBox();
            this.lblWins2 = new System.Windows.Forms.Label();
            this.lblWins1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.btnJogarNovamente = new System.Windows.Forms.Button();
            this.Placar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVez
            // 
            this.lblVez.BackColor = System.Drawing.Color.Transparent;
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVez.Location = new System.Drawing.Point(170, 23);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(318, 41);
            this.lblVez.TabIndex = 0;
            this.lblVez.Text = "Jogador 1 é sua Vez!";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn1.Location = new System.Drawing.Point(176, 99);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 66);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn2.Location = new System.Drawing.Point(278, 99);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 66);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn3.Location = new System.Drawing.Point(384, 99);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 66);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn6.Location = new System.Drawing.Point(384, 187);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 66);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn5.Location = new System.Drawing.Point(278, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 66);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn4.Location = new System.Drawing.Point(176, 187);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 66);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn9.Location = new System.Drawing.Point(384, 276);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 66);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn8.Location = new System.Drawing.Point(278, 276);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 66);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn7.Location = new System.Drawing.Point(176, 276);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 66);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // timerGanhou
            // 
            this.timerGanhou.Interval = 500;
            this.timerGanhou.Tick += new System.EventHandler(this.timerGanhou_Tick);
            // 
            // Placar
            // 
            this.Placar.Controls.Add(this.lblWins2);
            this.Placar.Controls.Add(this.lblWins1);
            this.Placar.Controls.Add(this.lblJogador2);
            this.Placar.Controls.Add(this.lblJogador1);
            this.Placar.Location = new System.Drawing.Point(73, 381);
            this.Placar.Name = "Placar";
            this.Placar.Size = new System.Drawing.Size(134, 87);
            this.Placar.TabIndex = 10;
            this.Placar.TabStop = false;
            this.Placar.Text = "Placar";
            // 
            // lblWins2
            // 
            this.lblWins2.AutoSize = true;
            this.lblWins2.Location = new System.Drawing.Point(69, 51);
            this.lblWins2.Name = "lblWins2";
            this.lblWins2.Size = new System.Drawing.Size(0, 13);
            this.lblWins2.TabIndex = 3;
            // 
            // lblWins1
            // 
            this.lblWins1.AutoSize = true;
            this.lblWins1.Location = new System.Drawing.Point(69, 26);
            this.lblWins1.Name = "lblWins1";
            this.lblWins1.Size = new System.Drawing.Size(0, 13);
            this.lblWins1.TabIndex = 2;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Location = new System.Drawing.Point(6, 51);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(57, 13);
            this.lblJogador2.TabIndex = 1;
            this.lblJogador2.Text = "Jogador 2:";
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Location = new System.Drawing.Point(6, 26);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(57, 13);
            this.lblJogador1.TabIndex = 0;
            this.lblJogador1.Text = "Jogador 1:";
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente.Location = new System.Drawing.Point(262, 381);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(114, 64);
            this.btnJogarNovamente.TabIndex = 11;
            this.btnJogarNovamente.Text = "Jogar novamente!";
            this.btnJogarNovamente.UseVisualStyleBackColor = true;
            this.btnJogarNovamente.Click += new System.EventHandler(this.btnJogarNovamente_Click);
            // 
            // DarkMountain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaVelha.Properties.Resources.darkMountain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 503);
            this.Controls.Add(this.btnJogarNovamente);
            this.Controls.Add(this.Placar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblVez);
            this.DoubleBuffered = true;
            this.Name = "DarkMountain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Placar.ResumeLayout(false);
            this.Placar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Timer timerGanhou;
        private System.Windows.Forms.GroupBox Placar;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblWins2;
        private System.Windows.Forms.Label lblWins1;
        private System.Windows.Forms.Button btnJogarNovamente;
    }
}

