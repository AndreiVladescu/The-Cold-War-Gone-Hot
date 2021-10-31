
namespace Wargame.Forms
{
    partial class PlayForm
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
            this.BtnSimulate = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.PanelAtkAirComposition = new System.Windows.Forms.Panel();
            this.LblAtkAirStats = new System.Windows.Forms.Label();
            this.LblAtkTerStats = new System.Windows.Forms.Label();
            this.PanelAtkTerComposition = new System.Windows.Forms.Panel();
            this.PanelAtkStrategy = new System.Windows.Forms.Panel();
            this.PictureAtkCommander = new System.Windows.Forms.PictureBox();
            this.LblDoctrineAtk = new System.Windows.Forms.Label();
            this.PictureAtkDoctrine = new System.Windows.Forms.PictureBox();
            this.ChBoxAtkAir = new System.Windows.Forms.CheckBox();
            this.ChBoxAtkArmy = new System.Windows.Forms.CheckBox();
            this.LblAtkCommander = new System.Windows.Forms.Label();
            this.LblAtkCommanderStats = new System.Windows.Forms.Label();
            this.LblAtkTerStatsShow = new System.Windows.Forms.Label();
            this.LblDoctrineAtkShow = new System.Windows.Forms.Label();
            this.PanelAtkAirComposition.SuspendLayout();
            this.PanelAtkTerComposition.SuspendLayout();
            this.PanelAtkStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAtkCommander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAtkDoctrine)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSimulate
            // 
            this.BtnSimulate.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.BtnSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimulate.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSimulate.Location = new System.Drawing.Point(707, 36);
            this.BtnSimulate.Name = "BtnSimulate";
            this.BtnSimulate.Size = new System.Drawing.Size(126, 69);
            this.BtnSimulate.TabIndex = 0;
            this.BtnSimulate.Text = "Simulate Battle";
            this.BtnSimulate.UseVisualStyleBackColor = true;
            this.BtnSimulate.Click += new System.EventHandler(this.BtnSimulate_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.LblStatus.Image = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.LblStatus.Location = new System.Drawing.Point(715, 130);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(103, 24);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Undecided";
            // 
            // PanelAtkAirComposition
            // 
            this.PanelAtkAirComposition.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelAtkAirComposition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAtkAirComposition.Controls.Add(this.LblAtkAirStats);
            this.PanelAtkAirComposition.Location = new System.Drawing.Point(12, 12);
            this.PanelAtkAirComposition.Name = "PanelAtkAirComposition";
            this.PanelAtkAirComposition.Size = new System.Drawing.Size(344, 177);
            this.PanelAtkAirComposition.TabIndex = 4;
            // 
            // LblAtkAirStats
            // 
            this.LblAtkAirStats.AutoSize = true;
            this.LblAtkAirStats.BackColor = System.Drawing.Color.Transparent;
            this.LblAtkAirStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkAirStats.ForeColor = System.Drawing.Color.LightGray;
            this.LblAtkAirStats.Location = new System.Drawing.Point(22, 24);
            this.LblAtkAirStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAtkAirStats.Name = "LblAtkAirStats";
            this.LblAtkAirStats.Size = new System.Drawing.Size(125, 20);
            this.LblAtkAirStats.TabIndex = 4;
            this.LblAtkAirStats.Text = "Airforce Stats:";
            // 
            // LblAtkTerStats
            // 
            this.LblAtkTerStats.AutoSize = true;
            this.LblAtkTerStats.BackColor = System.Drawing.Color.Transparent;
            this.LblAtkTerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkTerStats.ForeColor = System.Drawing.Color.LightGray;
            this.LblAtkTerStats.Location = new System.Drawing.Point(13, 22);
            this.LblAtkTerStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAtkTerStats.Name = "LblAtkTerStats";
            this.LblAtkTerStats.Size = new System.Drawing.Size(167, 20);
            this.LblAtkTerStats.TabIndex = 5;
            this.LblAtkTerStats.Text = "Ground Army Stats:";
            // 
            // PanelAtkTerComposition
            // 
            this.PanelAtkTerComposition.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelAtkTerComposition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAtkTerComposition.Controls.Add(this.LblAtkTerStatsShow);
            this.PanelAtkTerComposition.Controls.Add(this.LblAtkTerStats);
            this.PanelAtkTerComposition.Location = new System.Drawing.Point(12, 224);
            this.PanelAtkTerComposition.Name = "PanelAtkTerComposition";
            this.PanelAtkTerComposition.Size = new System.Drawing.Size(344, 477);
            this.PanelAtkTerComposition.TabIndex = 5;
            // 
            // PanelAtkStrategy
            // 
            this.PanelAtkStrategy.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelAtkStrategy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAtkStrategy.Controls.Add(this.LblDoctrineAtkShow);
            this.PanelAtkStrategy.Controls.Add(this.LblAtkCommanderStats);
            this.PanelAtkStrategy.Controls.Add(this.LblAtkCommander);
            this.PanelAtkStrategy.Controls.Add(this.PictureAtkCommander);
            this.PanelAtkStrategy.Controls.Add(this.LblDoctrineAtk);
            this.PanelAtkStrategy.Controls.Add(this.PictureAtkDoctrine);
            this.PanelAtkStrategy.Controls.Add(this.ChBoxAtkAir);
            this.PanelAtkStrategy.Controls.Add(this.ChBoxAtkArmy);
            this.PanelAtkStrategy.Location = new System.Drawing.Point(12, 733);
            this.PanelAtkStrategy.Name = "PanelAtkStrategy";
            this.PanelAtkStrategy.Size = new System.Drawing.Size(456, 335);
            this.PanelAtkStrategy.TabIndex = 7;
            // 
            // PictureAtkCommander
            // 
            this.PictureAtkCommander.BackgroundImage = global::Wargame.Properties.Resources.zhukov;
            this.PictureAtkCommander.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureAtkCommander.Location = new System.Drawing.Point(17, 50);
            this.PictureAtkCommander.Name = "PictureAtkCommander";
            this.PictureAtkCommander.Size = new System.Drawing.Size(99, 128);
            this.PictureAtkCommander.TabIndex = 11;
            this.PictureAtkCommander.TabStop = false;
            // 
            // LblDoctrineAtk
            // 
            this.LblDoctrineAtk.AutoSize = true;
            this.LblDoctrineAtk.BackColor = System.Drawing.Color.Transparent;
            this.LblDoctrineAtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctrineAtk.ForeColor = System.Drawing.Color.LightGray;
            this.LblDoctrineAtk.Location = new System.Drawing.Point(13, 214);
            this.LblDoctrineAtk.Name = "LblDoctrineAtk";
            this.LblDoctrineAtk.Size = new System.Drawing.Size(143, 20);
            this.LblDoctrineAtk.TabIndex = 10;
            this.LblDoctrineAtk.Text = "Chosen Doctrine";
            // 
            // PictureAtkDoctrine
            // 
            this.PictureAtkDoctrine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureAtkDoctrine.Image = global::Wargame.Properties.Resources.breakthrough;
            this.PictureAtkDoctrine.Location = new System.Drawing.Point(26, 257);
            this.PictureAtkDoctrine.Name = "PictureAtkDoctrine";
            this.PictureAtkDoctrine.Size = new System.Drawing.Size(89, 47);
            this.PictureAtkDoctrine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureAtkDoctrine.TabIndex = 9;
            this.PictureAtkDoctrine.TabStop = false;
            this.PictureAtkDoctrine.Click += new System.EventHandler(this.PictureAtkDoctrine_Click);
            // 
            // ChBoxAtkAir
            // 
            this.ChBoxAtkAir.AutoSize = true;
            this.ChBoxAtkAir.BackColor = System.Drawing.Color.Transparent;
            this.ChBoxAtkAir.Checked = true;
            this.ChBoxAtkAir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBoxAtkAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBoxAtkAir.ForeColor = System.Drawing.Color.DarkGray;
            this.ChBoxAtkAir.Location = new System.Drawing.Point(258, 235);
            this.ChBoxAtkAir.Name = "ChBoxAtkAir";
            this.ChBoxAtkAir.Size = new System.Drawing.Size(143, 24);
            this.ChBoxAtkAir.TabIndex = 8;
            this.ChBoxAtkAir.Text = "Airforce Engage";
            this.ChBoxAtkAir.UseVisualStyleBackColor = false;
            this.ChBoxAtkAir.CheckedChanged += new System.EventHandler(this.ChBoxAtkAir_CheckedChanged);
            // 
            // ChBoxAtkArmy
            // 
            this.ChBoxAtkArmy.AutoSize = true;
            this.ChBoxAtkArmy.BackColor = System.Drawing.Color.Transparent;
            this.ChBoxAtkArmy.Checked = true;
            this.ChBoxAtkArmy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBoxAtkArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBoxAtkArmy.ForeColor = System.Drawing.Color.DarkGray;
            this.ChBoxAtkArmy.Location = new System.Drawing.Point(258, 280);
            this.ChBoxAtkArmy.Name = "ChBoxAtkArmy";
            this.ChBoxAtkArmy.Size = new System.Drawing.Size(188, 24);
            this.ChBoxAtkArmy.TabIndex = 7;
            this.ChBoxAtkArmy.Text = "Ground Army Advance";
            this.ChBoxAtkArmy.UseVisualStyleBackColor = false;
            this.ChBoxAtkArmy.CheckedChanged += new System.EventHandler(this.ChBoxAtkArmy_CheckedChanged);
            // 
            // LblAtkCommander
            // 
            this.LblAtkCommander.AutoSize = true;
            this.LblAtkCommander.BackColor = System.Drawing.Color.Transparent;
            this.LblAtkCommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkCommander.ForeColor = System.Drawing.Color.LightGray;
            this.LblAtkCommander.Location = new System.Drawing.Point(13, 18);
            this.LblAtkCommander.Name = "LblAtkCommander";
            this.LblAtkCommander.Size = new System.Drawing.Size(153, 20);
            this.LblAtkCommander.TabIndex = 12;
            this.LblAtkCommander.Text = "Front Commander";
            // 
            // LblAtkCommanderStats
            // 
            this.LblAtkCommanderStats.AutoSize = true;
            this.LblAtkCommanderStats.BackColor = System.Drawing.Color.Transparent;
            this.LblAtkCommanderStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkCommanderStats.ForeColor = System.Drawing.Color.LightGray;
            this.LblAtkCommanderStats.Location = new System.Drawing.Point(151, 50);
            this.LblAtkCommanderStats.Name = "LblAtkCommanderStats";
            this.LblAtkCommanderStats.Size = new System.Drawing.Size(172, 20);
            this.LblAtkCommanderStats.TabIndex = 13;
            this.LblAtkCommanderStats.Text = "Modifiers: +10% Attack";
            // 
            // LblAtkTerStatsShow
            // 
            this.LblAtkTerStatsShow.AutoSize = true;
            this.LblAtkTerStatsShow.BackColor = System.Drawing.Color.Transparent;
            this.LblAtkTerStatsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkTerStatsShow.ForeColor = System.Drawing.Color.LightGray;
            this.LblAtkTerStatsShow.Location = new System.Drawing.Point(13, 71);
            this.LblAtkTerStatsShow.Name = "LblAtkTerStatsShow";
            this.LblAtkTerStatsShow.Size = new System.Drawing.Size(0, 20);
            this.LblAtkTerStatsShow.TabIndex = 14;
            // 
            // LblDoctrineAtkShow
            // 
            this.LblDoctrineAtkShow.AutoSize = true;
            this.LblDoctrineAtkShow.BackColor = System.Drawing.Color.Transparent;
            this.LblDoctrineAtkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctrineAtkShow.ForeColor = System.Drawing.Color.LightGray;
            this.LblDoctrineAtkShow.Location = new System.Drawing.Point(22, 234);
            this.LblDoctrineAtkShow.Name = "LblDoctrineAtkShow";
            this.LblDoctrineAtkShow.Size = new System.Drawing.Size(106, 20);
            this.LblDoctrineAtkShow.TabIndex = 14;
            this.LblDoctrineAtkShow.Text = "Breakthrough";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wargame.Properties.Resources.play_form_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1570, 1080);
            this.Controls.Add(this.PanelAtkStrategy);
            this.Controls.Add(this.PanelAtkTerComposition);
            this.Controls.Add(this.PanelAtkAirComposition);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnSimulate);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.PanelAtkAirComposition.ResumeLayout(false);
            this.PanelAtkAirComposition.PerformLayout();
            this.PanelAtkTerComposition.ResumeLayout(false);
            this.PanelAtkTerComposition.PerformLayout();
            this.PanelAtkStrategy.ResumeLayout(false);
            this.PanelAtkStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAtkCommander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAtkDoctrine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSimulate;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Panel PanelAtkAirComposition;
        private System.Windows.Forms.Label LblAtkAirStats;
        private System.Windows.Forms.Label LblAtkTerStats;
        private System.Windows.Forms.Panel PanelAtkTerComposition;
        private System.Windows.Forms.Panel PanelAtkStrategy;
        private System.Windows.Forms.PictureBox PictureAtkDoctrine;
        private System.Windows.Forms.CheckBox ChBoxAtkAir;
        private System.Windows.Forms.CheckBox ChBoxAtkArmy;
        private System.Windows.Forms.Label LblDoctrineAtk;
        private System.Windows.Forms.PictureBox PictureAtkCommander;
        private System.Windows.Forms.Label LblAtkCommanderStats;
        private System.Windows.Forms.Label LblAtkCommander;
        private System.Windows.Forms.Label LblAtkTerStatsShow;
        private System.Windows.Forms.Label LblDoctrineAtkShow;
    }
}