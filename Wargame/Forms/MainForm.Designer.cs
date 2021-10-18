
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
            this.BtnDefConfig = new System.Windows.Forms.Button();
            this.BtnAtkConfig = new System.Windows.Forms.Button();
            this.PanelMiniDesktop = new System.Windows.Forms.Panel();
            this.BtnBattlefieldConfig = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PictureMainMenuWallpaper = new System.Windows.Forms.PictureBox();
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
            this.PanelDesktopPanel.Name = "PanelDesktopPanel";
            this.PanelDesktopPanel.Size = new System.Drawing.Size(1920, 1080);
            this.PanelDesktopPanel.TabIndex = 10;
            // 
            // PanelSideMainMenu
            // 
            this.PanelSideMainMenu.BackColor = System.Drawing.Color.LightGray;
            this.PanelSideMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSideMainMenu.Controls.Add(this.BtnDefConfig);
            this.PanelSideMainMenu.Controls.Add(this.BtnAtkConfig);
            this.PanelSideMainMenu.Controls.Add(this.BtnBattlefieldConfig);
            this.PanelSideMainMenu.Controls.Add(this.BtnPlay);
            this.PanelSideMainMenu.Controls.Add(this.BtnOptions);
            this.PanelSideMainMenu.Controls.Add(this.BtnClose);
            this.PanelSideMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelSideMainMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMainMenu.Name = "PanelSideMainMenu";
            this.PanelSideMainMenu.Size = new System.Drawing.Size(248, 1080);
            this.PanelSideMainMenu.TabIndex = 1;
            // 
            // BtnDefConfig
            // 
            this.BtnDefConfig.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.BtnDefConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDefConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDefConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefConfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDefConfig.Location = new System.Drawing.Point(3, 356);
            this.BtnDefConfig.Name = "BtnDefConfig";
            this.BtnDefConfig.Size = new System.Drawing.Size(242, 99);
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
            this.BtnAtkConfig.Location = new System.Drawing.Point(3, 196);
            this.BtnAtkConfig.Name = "BtnAtkConfig";
            this.BtnAtkConfig.Size = new System.Drawing.Size(242, 102);
            this.BtnAtkConfig.TabIndex = 4;
            this.BtnAtkConfig.Text = "Attacker Config";
            this.BtnAtkConfig.UseVisualStyleBackColor = true;
            this.BtnAtkConfig.Click += new System.EventHandler(this.BtnAtkConfig_Click);
            // 
            // PanelMiniDesktop
            // 
            this.PanelMiniDesktop.Controls.Add(this.PictureMainMenuWallpaper);
            this.PanelMiniDesktop.Location = new System.Drawing.Point(242, 0);
            this.PanelMiniDesktop.Name = "PanelMiniDesktop";
            this.PanelMiniDesktop.Size = new System.Drawing.Size(1783, 1102);
            this.PanelMiniDesktop.TabIndex = 2;
            // 
            // BtnBattlefieldConfig
            // 
            this.BtnBattlefieldConfig.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.BtnBattlefieldConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBattlefieldConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBattlefieldConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBattlefieldConfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnBattlefieldConfig.Location = new System.Drawing.Point(3, 36);
            this.BtnBattlefieldConfig.Name = "BtnBattlefieldConfig";
            this.BtnBattlefieldConfig.Size = new System.Drawing.Size(242, 102);
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
            this.BtnPlay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnPlay.Location = new System.Drawing.Point(0, 715);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(203, 90);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.UseVisualStyleBackColor = true;
            // 
            // BtnOptions
            // 
            this.BtnOptions.BackgroundImage = global::Wargame.Properties.Resources.options_button_icon1;
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.ForeColor = System.Drawing.Color.DimGray;
            this.BtnOptions.Location = new System.Drawing.Point(0, 844);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(247, 90);
            this.BtnOptions.TabIndex = 1;
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = global::Wargame.Properties.Resources.exit_button_icon2;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(0, 976);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(183, 78);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseApp);
            // 
            // PictureMainMenuWallpaper
            // 
            this.PictureMainMenuWallpaper.BackColor = System.Drawing.Color.Transparent;
            this.PictureMainMenuWallpaper.Image = ((System.Drawing.Image)(resources.GetObject("PictureMainMenuWallpaper.Image")));
            this.PictureMainMenuWallpaper.InitialImage = null;
            this.PictureMainMenuWallpaper.Location = new System.Drawing.Point(-3, 0);
            this.PictureMainMenuWallpaper.Name = "PictureMainMenuWallpaper";
            this.PictureMainMenuWallpaper.Size = new System.Drawing.Size(2174, 1080);
            this.PictureMainMenuWallpaper.TabIndex = 3;
            this.PictureMainMenuWallpaper.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.PanelDesktopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}

