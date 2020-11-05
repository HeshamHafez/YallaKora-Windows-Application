namespace yallakora_App
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLeague = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.btnMatch);
            this.panelMenu.Controls.Add(this.btnPlayer);
            this.panelMenu.Controls.Add(this.btnTeam);
            this.panelMenu.Controls.Add(this.btnLeague);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnLeague
            // 
            this.btnLeague.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeague.FlatAppearance.BorderSize = 0;
            this.btnLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeague.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLeague.Location = new System.Drawing.Point(0, 80);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(220, 60);
            this.btnLeague.TabIndex = 1;
            this.btnLeague.Text = "Add League";
            this.btnLeague.UseVisualStyleBackColor = true;
            // 
            // btnTeam
            // 
            this.btnTeam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeam.FlatAppearance.BorderSize = 0;
            this.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeam.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeam.Location = new System.Drawing.Point(0, 140);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(220, 60);
            this.btnTeam.TabIndex = 2;
            this.btnTeam.Text = "Add Team";
            this.btnTeam.UseVisualStyleBackColor = true;
            // 
            // btnPlayer
            // 
            this.btnPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlayer.Location = new System.Drawing.Point(0, 200);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(220, 60);
            this.btnPlayer.TabIndex = 3;
            this.btnPlayer.Text = "Add Player";
            this.btnPlayer.UseVisualStyleBackColor = false;
            // 
            // btnMatch
            // 
            this.btnMatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMatch.Location = new System.Drawing.Point(0, 260);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(220, 60);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Add Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.Location = new System.Drawing.Point(0, 320);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(220, 60);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Add Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "HomeForm";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Panel panelLogo;
    }
}

