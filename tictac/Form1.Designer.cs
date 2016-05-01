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
            this.A1 = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayturn = new System.Windows.Forms.Label();
            this.Player_X = new System.Windows.Forms.Label();
            this.Player_X_score = new System.Windows.Forms.Label();
            this.Draw_score = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.Player_O_score = new System.Windows.Forms.Label();
            this.Player_O = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.A1.Location = new System.Drawing.Point(13, 39);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.A2.Location = new System.Drawing.Point(94, 39);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.A3.Location = new System.Drawing.Point(175, 39);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.B1.Location = new System.Drawing.Point(12, 120);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.B2.Location = new System.Drawing.Point(93, 120);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.B3.Location = new System.Drawing.Point(175, 120);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.C1.Location = new System.Drawing.Point(13, 201);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.C2.Location = new System.Drawing.Point(94, 201);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.C3.Location = new System.Drawing.Point(175, 201);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 39);
            this.label1.MinimumSize = new System.Drawing.Size(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Turn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayturn
            // 
            this.displayturn.AutoSize = true;
            this.displayturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayturn.Location = new System.Drawing.Point(295, 69);
            this.displayturn.MinimumSize = new System.Drawing.Size(93, 30);
            this.displayturn.Name = "displayturn";
            this.displayturn.Size = new System.Drawing.Size(93, 30);
            this.displayturn.TabIndex = 11;
            this.displayturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_X
            // 
            this.Player_X.AutoSize = true;
            this.Player_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player_X.Location = new System.Drawing.Point(295, 131);
            this.Player_X.MinimumSize = new System.Drawing.Size(56, 40);
            this.Player_X.Name = "Player_X";
            this.Player_X.Size = new System.Drawing.Size(56, 40);
            this.Player_X.TabIndex = 12;
            this.Player_X.Text = "Player X ";
            this.Player_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_X_score
            // 
            this.Player_X_score.AutoSize = true;
            this.Player_X_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player_X_score.Location = new System.Drawing.Point(352, 131);
            this.Player_X_score.MinimumSize = new System.Drawing.Size(36, 40);
            this.Player_X_score.Name = "Player_X_score";
            this.Player_X_score.Size = new System.Drawing.Size(36, 40);
            this.Player_X_score.TabIndex = 16;
            this.Player_X_score.Text = "0";
            this.Player_X_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Draw_score
            // 
            this.Draw_score.AutoSize = true;
            this.Draw_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Draw_score.Location = new System.Drawing.Point(352, 171);
            this.Draw_score.MinimumSize = new System.Drawing.Size(36, 40);
            this.Draw_score.Name = "Draw_score";
            this.Draw_score.Size = new System.Drawing.Size(36, 40);
            this.Draw_score.TabIndex = 18;
            this.Draw_score.Text = "0";
            this.Draw_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Draw.Location = new System.Drawing.Point(295, 171);
            this.Draw.MinimumSize = new System.Drawing.Size(56, 40);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(56, 40);
            this.Draw.TabIndex = 17;
            this.Draw.Text = "Draw";
            this.Draw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_O_score
            // 
            this.Player_O_score.AutoSize = true;
            this.Player_O_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player_O_score.Location = new System.Drawing.Point(352, 211);
            this.Player_O_score.MinimumSize = new System.Drawing.Size(36, 40);
            this.Player_O_score.Name = "Player_O_score";
            this.Player_O_score.Size = new System.Drawing.Size(36, 40);
            this.Player_O_score.TabIndex = 20;
            this.Player_O_score.Text = "0";
            this.Player_O_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_O
            // 
            this.Player_O.AutoSize = true;
            this.Player_O.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player_O.Location = new System.Drawing.Point(295, 211);
            this.Player_O.MinimumSize = new System.Drawing.Size(56, 40);
            this.Player_O.Name = "Player_O";
            this.Player_O.Size = new System.Drawing.Size(56, 40);
            this.Player_O.TabIndex = 19;
            this.Player_O.Text = "Player O";
            this.Player_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 290);
            this.Controls.Add(this.Player_O_score);
            this.Controls.Add(this.Player_O);
            this.Controls.Add(this.Draw_score);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Player_X_score);
            this.Controls.Add(this.Player_X);
            this.Controls.Add(this.displayturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 328);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.MouseEnter += new System.EventHandler(this.display_enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayturn;
        private System.Windows.Forms.Label Player_X;
        private System.Windows.Forms.Label Player_X_score;
        private System.Windows.Forms.Label Draw_score;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label Player_O_score;
        private System.Windows.Forms.Label Player_O;

    }
}

