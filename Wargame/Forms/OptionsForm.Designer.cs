
namespace Wargame.Forms
{
    partial class OptionsForm
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
            this.TrackBarVolume = new System.Windows.Forms.TrackBar();
            this.TrackBarSensitivity = new System.Windows.Forms.TrackBar();
            this.PictureOptions = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackBarVolume
            // 
            this.TrackBarVolume.AutoSize = false;
            this.TrackBarVolume.BackColor = System.Drawing.SystemColors.GrayText;
            this.TrackBarVolume.Location = new System.Drawing.Point(409, 493);
            this.TrackBarVolume.Maximum = 40;
            this.TrackBarVolume.Name = "TrackBarVolume";
            this.TrackBarVolume.Size = new System.Drawing.Size(776, 27);
            this.TrackBarVolume.TabIndex = 2;
            this.TrackBarVolume.Tag = "Mouse Sensitivity";
            this.TrackBarVolume.Value = 40;
            // 
            // TrackBarSensitivity
            // 
            this.TrackBarSensitivity.AccessibleDescription = "Description";
            this.TrackBarSensitivity.AccessibleName = "Mouse Sensitivity";
            this.TrackBarSensitivity.AutoSize = false;
            this.TrackBarSensitivity.BackColor = System.Drawing.SystemColors.GrayText;
            this.TrackBarSensitivity.Location = new System.Drawing.Point(409, 580);
            this.TrackBarSensitivity.Maximum = 20;
            this.TrackBarSensitivity.Minimum = 1;
            this.TrackBarSensitivity.Name = "TrackBarSensitivity";
            this.TrackBarSensitivity.Size = new System.Drawing.Size(776, 27);
            this.TrackBarSensitivity.TabIndex = 3;
            this.TrackBarSensitivity.Tag = "Volume";
            this.TrackBarSensitivity.Value = 10;
            this.TrackBarSensitivity.Scroll += new System.EventHandler(this.TrackBarSensitivity_Scroll);
            this.TrackBarSensitivity.MouseHover += new System.EventHandler(this.TrackBarSensitivity_MouseHover);
            // 
            // PictureOptions
            // 
            this.PictureOptions.BackColor = System.Drawing.Color.Transparent;
            this.PictureOptions.BackgroundImage = global::Wargame.Properties.Resources.options_button_icon;
            this.PictureOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureOptions.Location = new System.Drawing.Point(496, 12);
            this.PictureOptions.Name = "PictureOptions";
            this.PictureOptions.Size = new System.Drawing.Size(679, 212);
            this.PictureOptions.TabIndex = 1;
            this.PictureOptions.TabStop = false;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wargame.Properties.Resources.bg_options;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1554, 1041);
            this.Controls.Add(this.TrackBarSensitivity);
            this.Controls.Add(this.TrackBarVolume);
            this.Controls.Add(this.PictureOptions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(350, 0);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureOptions;
        private System.Windows.Forms.TrackBar TrackBarVolume;
        private System.Windows.Forms.TrackBar TrackBarSensitivity;
    }
}