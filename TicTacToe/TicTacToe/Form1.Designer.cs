namespace TicTacToe
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player1Sign = new System.Windows.Forms.Label();
            this.player2Sign = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 63);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 63);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 63);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 63);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 63);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 63);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(25, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 63);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(114, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 63);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(206, 193);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 63);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player 1";
            // 
            // player1Sign
            // 
            this.player1Sign.AutoSize = true;
            this.player1Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1Sign.ForeColor = System.Drawing.Color.Red;
            this.player1Sign.Location = new System.Drawing.Point(413, 19);
            this.player1Sign.Name = "player1Sign";
            this.player1Sign.Size = new System.Drawing.Size(24, 24);
            this.player1Sign.TabIndex = 11;
            this.player1Sign.Text = "X";
            // 
            // player2Sign
            // 
            this.player2Sign.AutoSize = true;
            this.player2Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2Sign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.player2Sign.Location = new System.Drawing.Point(413, 53);
            this.player2Sign.Name = "player2Sign";
            this.player2Sign.Size = new System.Drawing.Size(25, 24);
            this.player2Sign.TabIndex = 13;
            this.player2Sign.Text = "O";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Player 2";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultText.Location = new System.Drawing.Point(110, 273);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 24);
            this.resultText.TabIndex = 14;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(365, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 63);
            this.button10.TabIndex = 15;
            this.button10.Text = "Start game";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 318);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.player2Sign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.player1Sign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player1Sign;
        private System.Windows.Forms.Label player2Sign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button button10;
    }
}

