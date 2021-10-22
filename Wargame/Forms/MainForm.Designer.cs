
namespace Wargame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelDesktopPanel = new System.Windows.Forms.Panel();
            this.PanelSideMainMenu = new System.Windows.Forms.Panel();
            this.BtnCredits = new System.Windows.Forms.Button();
            this.PanelMiniDesktop = new System.Windows.Forms.Panel();
            this.BtnDefConfig = new System.Windows.Forms.Button();
            this.BtnAtkConfig = new System.Windows.Forms.Button();
            this.BtnBattlefieldConfig = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PictureMainMenuWallpaper = new System.Windows.Forms.PictureBox();
            this.BtnMusicPlayer = new System.Windows.Forms.Button();
            this.PanelDesktopPanel.SuspendLayout();
            this.PanelSideMainMenu.SuspendLayout();
            this.PanelMiniDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMainMenuWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDesktopPanel
            // 
            this.PanelDesktopPanel.BackColor = System.Drawing.Color.Gray;
            this.PanelDesktopPanel.Controls.Add(this.PanelSideMainMenu);
            this.PanelDesktopPanel.Controls.Add(this.PanelMiniDesktop);
            this.PanelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.PanelDesktopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelDesktopPanel.Name = "PanelDesktopPanel";
            this.PanelDesktopPanel.Size = new System.Drawing.Size(1942, 1088);
            this.PanelDesktopPanel.TabIndex = 10;
            // 
            // PanelSideMainMenu
            // 
            this.PanelSideMainMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanelSideMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSideMainMenu.Controls.Add(this.BtnMusicPlayer);
            this.PanelSideMainMenu.Controls.Add(this.BtnCredits);
            this.PanelSideMainMenu.Controls.Add(this.BtnDefConfig);
            this.PanelSideMainMenu.Controls.Add(this.BtnAtkConfig);
            this.PanelSideMainMenu.Controls.Add(this.BtnBattlefieldConfig);
            this.PanelSideMainMenu.Controls.Add(this.BtnPlay);
            this.PanelSideMainMenu.Controls.Add(this.BtnOptions);
            this.PanelSideMainMenu.Controls.Add(this.BtnClose);
            this.PanelSideMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelSideMainMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelSideMainMenu.Name = "PanelSideMainMenu";
            this.PanelSideMainMenu.Size = new System.Drawing.Size(331, 1329);
            this.PanelSideMainMenu.TabIndex = 1;
            // 
            // BtnCredits
            // 
            this.BtnCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCredits.ForeColor = System.Drawing.Color.White;
            this.BtnCredits.Location = new System.Drawing.Point(-3, 932);
            this.BtnCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCredits.Name = "BtnCredits";
            this.BtnCredits.Size = new System.Drawing.Size(329, 111);
            this.BtnCredits.TabIndex = 6;
            this.BtnCredits.Text = "Credits";
            this.BtnCredits.UseVisualStyleBackColor = true;
            this.BtnCredits.Click += new System.EventHandler(this.BtnCredits_Click);
            // 
            // PanelMiniDesktop
            // 
            this.PanelMiniDesktop.Controls.Add(this.PictureMainMenuWallpaper);
            this.PanelMiniDesktop.Location = new System.Drawing.Point(323, 0);
            this.PanelMiniDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelMiniDesktop.Name = "PanelMiniDesktop";
            this.PanelMiniDesktop.Size = new System.Drawing.Size(2377, 1356);
            this.PanelMiniDesktop.TabIndex = 2;
            // 
            // BtnDefConfig
            // 
            this.BtnDefConfig.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.BtnDefConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDefConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDefConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefConfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDefConfig.Location = new System.Drawing.Point(108, 459);
            this.BtnDefConfig.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDefConfig.Name = "BtnDefConfig";
            this.BtnDefConfig.Size = new System.Drawing.Size(207, 85);
            this.BtnDefConfig.TabIndex = 5;
            this.BtnDefConfig.Text = "Defender Config";
            this.BtnDefConfig.UseVisualStyleBackColor = true;
            this.BtnDefConfig.Click += new System.EventHandler(this.BtnDefConfig_Click);
            // 
            // BtnAtkConfig
            // 
            this.BtnAtkConfig.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.BtnAtkConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAtkConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtkConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtkConfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAtkConfig.Location = new System.Drawing.Point(108, 357);
            this.BtnAtkConfig.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAtkConfig.Name = "BtnAtkConfig";
            this.BtnAtkConfig.Size = new System.Drawing.Size(207, 79);
            this.BtnAtkConfig.TabIndex = 4;
            this.BtnAtkConfig.Text = "Attacker Config";
            this.BtnAtkConfig.UseVisualStyleBackColor = true;
            this.BtnAtkConfig.Click += new System.EventHandler(this.BtnAtkConfig_Click);
            // 
            // BtnBattlefieldConfig
            // 
            this.BtnBattlefieldConfig.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.BtnBattlefieldConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBattlefieldConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBattlefieldConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBattlefieldConfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnBattlefieldConfig.Location = new System.Drawing.Point(108, 249);
            this.BtnBattlefieldConfig.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBattlefieldConfig.Name = "BtnBattlefieldConfig";
            this.BtnBattlefieldConfig.Size = new System.Drawing.Size(207, 84);
            this.BtnBattlefieldConfig.TabIndex = 3;
            this.BtnBattlefieldConfig.Text = "Battlefield Config";
            this.BtnBattlefieldConfig.UseVisualStyleBackColor = true;
            this.BtnBattlefieldConfig.Click += new System.EventHandler(this.BtnBattlefieldConfig_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackgroundImage = global::Wargame.Properties.Resources.play_button_icon;
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPlay.Location = new System.Drawing.Point(28, 112);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(271, 111);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnOptions
            // 
            this.BtnOptions.BackgroundImage = global::Wargame.Properties.Resources.options_button_icon1;
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.ForeColor = System.Drawing.Color.Black;
            this.BtnOptions.Location = new System.Drawing.Point(0, 639);
            this.BtnOptions.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(329, 111);
            this.BtnOptions.TabIndex = 1;
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Black;
            this.BtnClose.BackgroundImage = global::Wargame.Properties.Resources.exit_button_icon2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(71, 1190);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(244, 96);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseApp);
            // 
            // PictureMainMenuWallpaper
            // 
            this.PictureMainMenuWallpaper.BackColor = System.Drawing.Color.Transparent;
            this.PictureMainMenuWallpaper.Image = ((System.Drawing.Image)(resources.GetObject("PictureMainMenuWallpaper.Image")));
            this.PictureMainMenuWallpaper.InitialImage = null;
            this.PictureMainMenuWallpaper.Location = new System.Drawing.Point(-4, 0);
            this.PictureMainMenuWallpaper.Margin = new System.Windows.Forms.Padding(4);
            this.PictureMainMenuWallpaper.Name = "PictureMainMenuWallpaper";
            this.PictureMainMenuWallpaper.Size = new System.Drawing.Size(2899, 1329);
            this.PictureMainMenuWallpaper.TabIndex = 3;
            this.PictureMainMenuWallpaper.TabStop = false;
            // 
            // BtnMusicPlayer
            // 
            this.BtnMusicPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMusicPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMusicPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusicPlayer.ForeColor = System.Drawing.Color.White;
            this.BtnMusicPlayer.Location = new System.Drawing.Point(108, 758);
            this.BtnMusicPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMusicPlayer.Name = "BtnMusicPlayer";
            this.BtnMusicPlayer.Size = new System.Drawing.Size(218, 99);
            this.BtnMusicPlayer.TabIndex = 7;
            this.BtnMusicPlayer.Text = "Music Player";
            this.BtnMusicPlayer.UseVisualStyleBackColor = true;
            this.BtnMusicPlayer.Click += new System.EventHandler(this.BtnMusicPlayer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1088);
            this.Controls.Add(this.PanelDesktopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Cold War Gone Hot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelDesktopPanel.ResumeLayout(false);
            this.PanelSideMainMenu.ResumeLayout(false);
            this.PanelMiniDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureMainMenuWallpaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelDesktopPanel;
        private System.Windows.Forms.Panel PanelSideMainMenu;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnOptions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PanelMiniDesktop;
        private System.Windows.Forms.PictureBox PictureMainMenuWallpaper;
        private System.Windows.Forms.Button BtnDefConfig;
        private System.Windows.Forms.Button BtnAtkConfig;
        private System.Windows.Forms.Button BtnBattlefieldConfig;
        private System.Windows.Forms.Button BtnCredits;
        private System.Windows.Forms.Button BtnMusicPlayer;
    }
}

