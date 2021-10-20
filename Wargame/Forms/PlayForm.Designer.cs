
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
            this.LblAtkManpower = new System.Windows.Forms.Label();
            this.LblDefManpower = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSimulate
            // 
            this.BtnSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimulate.Location = new System.Drawing.Point(718, 74);
            this.BtnSimulate.Name = "BtnSimulate";
            this.BtnSimulate.Size = new System.Drawing.Size(126, 69);
            this.BtnSimulate.TabIndex = 0;
            this.BtnSimulate.Text = "Simulate Battle";
            this.BtnSimulate.UseVisualStyleBackColor = true;
            this.BtnSimulate.Click += new System.EventHandler(this.BtnSimulate_Click);
            // 
            // LblAtkManpower
            // 
            this.LblAtkManpower.AutoSize = true;
            this.LblAtkManpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtkManpower.Location = new System.Drawing.Point(413, 225);
            this.LblAtkManpower.Name = "LblAtkManpower";
            this.LblAtkManpower.Size = new System.Drawing.Size(172, 24);
            this.LblAtkManpower.TabIndex = 1;
            this.LblAtkManpower.Text = "Attacker Manpower";
            // 
            // LblDefManpower
            // 
            this.LblDefManpower.AutoSize = true;
            this.LblDefManpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefManpower.Location = new System.Drawing.Point(928, 225);
            this.LblDefManpower.Name = "LblDefManpower";
            this.LblDefManpower.Size = new System.Drawing.Size(183, 24);
            this.LblDefManpower.TabIndex = 2;
            this.LblDefManpower.Text = "Defender Manpower";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(730, 225);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(103, 24);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Undecided";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wargame.Properties.Resources.play_form_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1570, 1080);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblDefManpower);
            this.Controls.Add(this.LblAtkManpower);
            this.Controls.Add(this.BtnSimulate);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSimulate;
        private System.Windows.Forms.Label LblAtkManpower;
        private System.Windows.Forms.Label LblDefManpower;
        private System.Windows.Forms.Label LblStatus;
    }
}