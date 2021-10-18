
namespace Wargame.Forms
{
    partial class AttackerForm
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
            this.FlowPanelTer = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelAttackerStats = new System.Windows.Forms.Panel();
            this.LblAtkArmyStats = new System.Windows.Forms.Label();
            this.PictureFlagAttacker = new System.Windows.Forms.PictureBox();
            this.PanelAttackerStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFlagAttacker)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPanelTer
            // 
            this.FlowPanelTer.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x1132;
            this.FlowPanelTer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlowPanelTer.Location = new System.Drawing.Point(173, 170);
            this.FlowPanelTer.Name = "FlowPanelTer";
            this.FlowPanelTer.Size = new System.Drawing.Size(1119, 256);
            this.FlowPanelTer.TabIndex = 5;
            // 
            // PanelAttackerStats
            // 
            this.PanelAttackerStats.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x1132;
            this.PanelAttackerStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAttackerStats.Controls.Add(this.LblAtkArmyStats);
            this.PanelAttackerStats.Location = new System.Drawing.Point(165, 12);
            this.PanelAttackerStats.Name = "PanelAttackerStats";
            this.PanelAttackerStats.Size = new System.Drawing.Size(1127, 105);
            this.PanelAttackerStats.TabIndex = 4;
            // 
            // LblAtkArmyStats
            // 
            this.LblAtkArmyStats.AutoSize = true;
            this.LblAtkArmyStats.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblAtkArmyStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkArmyStats.Location = new System.Drawing.Point(4, 4);
            this.LblAtkArmyStats.Name = "LblAtkArmyStats";
            this.LblAtkArmyStats.Size = new System.Drawing.Size(148, 20);
            this.LblAtkArmyStats.TabIndex = 0;
            this.LblAtkArmyStats.Text = "USSR Stat Screen:";
            // 
            // PictureFlagAttacker
            // 
            this.PictureFlagAttacker.BackColor = System.Drawing.Color.Transparent;
            this.PictureFlagAttacker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureFlagAttacker.Image = global::Wargame.Properties.Resources.SOV_flag;
            this.PictureFlagAttacker.Location = new System.Drawing.Point(12, 12);
            this.PictureFlagAttacker.Name = "PictureFlagAttacker";
            this.PictureFlagAttacker.Size = new System.Drawing.Size(120, 81);
            this.PictureFlagAttacker.TabIndex = 3;
            this.PictureFlagAttacker.TabStop = false;
            this.PictureFlagAttacker.Click += new System.EventHandler(this.PictureFlagAttacker_Click);
            // 
            // AttackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wargame.Properties.Resources.attacker_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1554, 1041);
            this.Controls.Add(this.FlowPanelTer);
            this.Controls.Add(this.PanelAttackerStats);
            this.Controls.Add(this.PictureFlagAttacker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttackerForm";
            this.Text = "AttackerForm";
            this.PanelAttackerStats.ResumeLayout(false);
            this.PanelAttackerStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFlagAttacker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanelTer;
        private System.Windows.Forms.Panel PanelAttackerStats;
        private System.Windows.Forms.Label LblAtkArmyStats;
        private System.Windows.Forms.PictureBox PictureFlagAttacker;
    }
}