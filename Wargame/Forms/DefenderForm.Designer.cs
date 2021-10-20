
namespace Wargame.Forms
{
    partial class DefenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefenderForm));
            this.PictureFlagDefender = new System.Windows.Forms.PictureBox();
            this.PanelDefenderStats = new System.Windows.Forms.Panel();
            this.LblDefArmyStats = new System.Windows.Forms.Label();
            this.PanelLeg = new System.Windows.Forms.Panel();
            this.BtnPrevLeg = new System.Windows.Forms.Button();
            this.BtnNextLeg = new System.Windows.Forms.Button();
            this.LblLegStats3Values = new System.Windows.Forms.Label();
            this.LblLegStats3 = new System.Windows.Forms.Label();
            this.LblLegStats2Values = new System.Windows.Forms.Label();
            this.LblLegStats2 = new System.Windows.Forms.Label();
            this.LblLegStats1Values = new System.Windows.Forms.Label();
            this.LblLegStats1 = new System.Windows.Forms.Label();
            this.PictureLegGen = new System.Windows.Forms.PictureBox();
            this.LblLegCounter = new System.Windows.Forms.Label();
            this.BtnLegGen = new System.Windows.Forms.Button();
            this.BtnSubLeg = new System.Windows.Forms.Button();
            this.BtnAddLeg = new System.Windows.Forms.Button();
            this.PictureLeg = new System.Windows.Forms.PictureBox();
            this.PanelMob = new System.Windows.Forms.Panel();
            this.BtnPrevMob = new System.Windows.Forms.Button();
            this.BtnNextMob = new System.Windows.Forms.Button();
            this.LblMobStats3Values = new System.Windows.Forms.Label();
            this.LblMobStats3 = new System.Windows.Forms.Label();
            this.LblMobStats2Values = new System.Windows.Forms.Label();
            this.LblMobStats2 = new System.Windows.Forms.Label();
            this.LblMobStats1Values = new System.Windows.Forms.Label();
            this.LblMobStats1 = new System.Windows.Forms.Label();
            this.PictureMobGen = new System.Windows.Forms.PictureBox();
            this.LblMobCounter = new System.Windows.Forms.Label();
            this.BtnMobGen = new System.Windows.Forms.Button();
            this.BtnSubMob = new System.Windows.Forms.Button();
            this.BtnAddMob = new System.Windows.Forms.Button();
            this.PictureMob = new System.Windows.Forms.PictureBox();
            this.PanelAir = new System.Windows.Forms.Panel();
            this.LblAirExp = new System.Windows.Forms.Label();
            this.PictureAirExp = new System.Windows.Forms.PictureBox();
            this.BtnPrevAir = new System.Windows.Forms.Button();
            this.BtnNextAir = new System.Windows.Forms.Button();
            this.LblAirStats1Values = new System.Windows.Forms.Label();
            this.LblAirStats1 = new System.Windows.Forms.Label();
            this.PictureAirGen = new System.Windows.Forms.PictureBox();
            this.LblAirCounter = new System.Windows.Forms.Label();
            this.BtnAirGen = new System.Windows.Forms.Button();
            this.BtnSubAir = new System.Windows.Forms.Button();
            this.BtnAddAir = new System.Windows.Forms.Button();
            this.PictureAir = new System.Windows.Forms.PictureBox();
            this.PictureCommander = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureFlagDefender)).BeginInit();
            this.PanelDefenderStats.SuspendLayout();
            this.PanelLeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLegGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLeg)).BeginInit();
            this.PanelMob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMobGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMob)).BeginInit();
            this.PanelAir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAirExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAirGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCommander)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureFlagDefender
            // 
            this.PictureFlagDefender.BackColor = System.Drawing.Color.Transparent;
            this.PictureFlagDefender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureFlagDefender.Image = global::Wargame.Properties.Resources.USA_flag;
            this.PictureFlagDefender.Location = new System.Drawing.Point(12, 12);
            this.PictureFlagDefender.Name = "PictureFlagDefender";
            this.PictureFlagDefender.Size = new System.Drawing.Size(123, 82);
            this.PictureFlagDefender.TabIndex = 0;
            this.PictureFlagDefender.TabStop = false;
            this.PictureFlagDefender.Click += new System.EventHandler(this.PictureFlagDefender_Click);
            // 
            // PanelDefenderStats
            // 
            this.PanelDefenderStats.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelDefenderStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelDefenderStats.Controls.Add(this.LblDefArmyStats);
            this.PanelDefenderStats.Location = new System.Drawing.Point(165, 12);
            this.PanelDefenderStats.Name = "PanelDefenderStats";
            this.PanelDefenderStats.Size = new System.Drawing.Size(1127, 105);
            this.PanelDefenderStats.TabIndex = 1;
            // 
            // LblDefArmyStats
            // 
            this.LblDefArmyStats.AutoSize = true;
            this.LblDefArmyStats.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblDefArmyStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDefArmyStats.Location = new System.Drawing.Point(4, 4);
            this.LblDefArmyStats.Name = "LblDefArmyStats";
            this.LblDefArmyStats.Size = new System.Drawing.Size(136, 20);
            this.LblDefArmyStats.TabIndex = 0;
            this.LblDefArmyStats.Text = "USA Stat Screen:";
            // 
            // PanelLeg
            // 
            this.PanelLeg.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelLeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLeg.Controls.Add(this.BtnPrevLeg);
            this.PanelLeg.Controls.Add(this.BtnNextLeg);
            this.PanelLeg.Controls.Add(this.LblLegStats3Values);
            this.PanelLeg.Controls.Add(this.LblLegStats3);
            this.PanelLeg.Controls.Add(this.LblLegStats2Values);
            this.PanelLeg.Controls.Add(this.LblLegStats2);
            this.PanelLeg.Controls.Add(this.LblLegStats1Values);
            this.PanelLeg.Controls.Add(this.LblLegStats1);
            this.PanelLeg.Controls.Add(this.PictureLegGen);
            this.PanelLeg.Controls.Add(this.LblLegCounter);
            this.PanelLeg.Controls.Add(this.BtnLegGen);
            this.PanelLeg.Controls.Add(this.BtnSubLeg);
            this.PanelLeg.Controls.Add(this.BtnAddLeg);
            this.PanelLeg.Controls.Add(this.PictureLeg);
            this.PanelLeg.Location = new System.Drawing.Point(165, 179);
            this.PanelLeg.Name = "PanelLeg";
            this.PanelLeg.Size = new System.Drawing.Size(1127, 139);
            this.PanelLeg.TabIndex = 1;
            // 
            // BtnPrevLeg
            // 
            this.BtnPrevLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevLeg.Location = new System.Drawing.Point(1019, 13);
            this.BtnPrevLeg.Name = "BtnPrevLeg";
            this.BtnPrevLeg.Size = new System.Drawing.Size(42, 110);
            this.BtnPrevLeg.TabIndex = 13;
            this.BtnPrevLeg.Text = "<";
            this.BtnPrevLeg.UseVisualStyleBackColor = true;
            this.BtnPrevLeg.Click += new System.EventHandler(this.BtnPrevLeg_Click);
            // 
            // BtnNextLeg
            // 
            this.BtnNextLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextLeg.Location = new System.Drawing.Point(1067, 13);
            this.BtnNextLeg.Name = "BtnNextLeg";
            this.BtnNextLeg.Size = new System.Drawing.Size(42, 110);
            this.BtnNextLeg.TabIndex = 12;
            this.BtnNextLeg.Text = ">";
            this.BtnNextLeg.UseVisualStyleBackColor = true;
            this.BtnNextLeg.Click += new System.EventHandler(this.BtnNextLeg_Click);
            // 
            // LblLegStats3Values
            // 
            this.LblLegStats3Values.AutoSize = true;
            this.LblLegStats3Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegStats3Values.Location = new System.Drawing.Point(929, 13);
            this.LblLegStats3Values.Name = "LblLegStats3Values";
            this.LblLegStats3Values.Size = new System.Drawing.Size(27, 80);
            this.LblLegStats3Values.TabIndex = 11;
            this.LblLegStats3Values.Text = "40\r\n0\r\n15\r\n10";
            // 
            // LblLegStats3
            // 
            this.LblLegStats3.AutoSize = true;
            this.LblLegStats3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegStats3.Location = new System.Drawing.Point(799, 13);
            this.LblLegStats3.Name = "LblLegStats3";
            this.LblLegStats3.Size = new System.Drawing.Size(110, 80);
            this.LblLegStats3.TabIndex = 10;
            this.LblLegStats3.Text = "Combat Width\r\nHardness\r\nAir Attack\r\nPiercing";
            // 
            // LblLegStats2Values
            // 
            this.LblLegStats2Values.AutoSize = true;
            this.LblLegStats2Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegStats2Values.Location = new System.Drawing.Point(700, 13);
            this.LblLegStats2Values.Name = "LblLegStats2Values";
            this.LblLegStats2Values.Size = new System.Drawing.Size(36, 100);
            this.LblLegStats2Values.TabIndex = 9;
            this.LblLegStats2Values.Text = "100\r\n0\r\n100\r\n40\r\n20";
            // 
            // LblLegStats2
            // 
            this.LblLegStats2.AutoSize = true;
            this.LblLegStats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegStats2.Location = new System.Drawing.Point(547, 13);
            this.LblLegStats2.Name = "LblLegStats2";
            this.LblLegStats2.Size = new System.Drawing.Size(138, 100);
            this.LblLegStats2.TabIndex = 8;
            this.LblLegStats2.Text = "Breakthrough\r\nFuel Consumption\r\nReliability\r\nOrganization\r\nEntrenchment\r\n";
            // 
            // LblLegStats1Values
            // 
            this.LblLegStats1Values.AutoSize = true;
            this.LblLegStats1Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegStats1Values.Location = new System.Drawing.Point(458, 13);
            this.LblLegStats1Values.Name = "LblLegStats1Values";
            this.LblLegStats1Values.Size = new System.Drawing.Size(45, 100);
            this.LblLegStats1Values.TabIndex = 7;
            this.LblLegStats1Values.Text = "1000\r\n50\r\n20\r\n40\r\n0";
            // 
            // LblLegStats1
            // 
            this.LblLegStats1.AutoSize = true;
            this.LblLegStats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegStats1.Location = new System.Drawing.Point(338, 13);
            this.LblLegStats1.Name = "LblLegStats1";
            this.LblLegStats1.Size = new System.Drawing.Size(94, 100);
            this.LblLegStats1.TabIndex = 6;
            this.LblLegStats1.Text = "Manpower\r\nSoft Attack\r\nHard Attack\r\nDefence\r\nArmor";
            // 
            // PictureLegGen
            // 
            this.PictureLegGen.BackColor = System.Drawing.Color.Transparent;
            this.PictureLegGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureLegGen.BackgroundImage")));
            this.PictureLegGen.Location = new System.Drawing.Point(267, 16);
            this.PictureLegGen.Name = "PictureLegGen";
            this.PictureLegGen.Size = new System.Drawing.Size(35, 35);
            this.PictureLegGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureLegGen.TabIndex = 5;
            this.PictureLegGen.TabStop = false;
            // 
            // LblLegCounter
            // 
            this.LblLegCounter.AutoSize = true;
            this.LblLegCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegCounter.Location = new System.Drawing.Point(205, 69);
            this.LblLegCounter.Name = "LblLegCounter";
            this.LblLegCounter.Size = new System.Drawing.Size(71, 24);
            this.LblLegCounter.TabIndex = 4;
            this.LblLegCounter.Text = "Units: 0";
            // 
            // BtnLegGen
            // 
            this.BtnLegGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLegGen.Location = new System.Drawing.Point(203, 13);
            this.BtnLegGen.Name = "BtnLegGen";
            this.BtnLegGen.Size = new System.Drawing.Size(58, 38);
            this.BtnLegGen.TabIndex = 3;
            this.BtnLegGen.Text = "Gen";
            this.BtnLegGen.UseVisualStyleBackColor = true;
            this.BtnLegGen.Click += new System.EventHandler(this.BtnLegGen_Click);
            // 
            // BtnSubLeg
            // 
            this.BtnSubLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubLeg.Location = new System.Drawing.Point(114, 99);
            this.BtnSubLeg.Name = "BtnSubLeg";
            this.BtnSubLeg.Size = new System.Drawing.Size(57, 29);
            this.BtnSubLeg.TabIndex = 2;
            this.BtnSubLeg.Text = "-";
            this.BtnSubLeg.UseVisualStyleBackColor = true;
            this.BtnSubLeg.Click += new System.EventHandler(this.BtnSubLeg_Click);
            // 
            // BtnAddLeg
            // 
            this.BtnAddLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddLeg.Location = new System.Drawing.Point(27, 99);
            this.BtnAddLeg.Name = "BtnAddLeg";
            this.BtnAddLeg.Size = new System.Drawing.Size(57, 29);
            this.BtnAddLeg.TabIndex = 1;
            this.BtnAddLeg.Text = "+";
            this.BtnAddLeg.UseVisualStyleBackColor = true;
            this.BtnAddLeg.Click += new System.EventHandler(this.BtnAddLeg_Click);
            // 
            // PictureLeg
            // 
            this.PictureLeg.Image = ((System.Drawing.Image)(resources.GetObject("PictureLeg.Image")));
            this.PictureLeg.Location = new System.Drawing.Point(17, 13);
            this.PictureLeg.Name = "PictureLeg";
            this.PictureLeg.Size = new System.Drawing.Size(180, 80);
            this.PictureLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureLeg.TabIndex = 0;
            this.PictureLeg.TabStop = false;
            // 
            // PanelMob
            // 
            this.PanelMob.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelMob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMob.Controls.Add(this.BtnPrevMob);
            this.PanelMob.Controls.Add(this.BtnNextMob);
            this.PanelMob.Controls.Add(this.LblMobStats3Values);
            this.PanelMob.Controls.Add(this.LblMobStats3);
            this.PanelMob.Controls.Add(this.LblMobStats2Values);
            this.PanelMob.Controls.Add(this.LblMobStats2);
            this.PanelMob.Controls.Add(this.LblMobStats1Values);
            this.PanelMob.Controls.Add(this.LblMobStats1);
            this.PanelMob.Controls.Add(this.PictureMobGen);
            this.PanelMob.Controls.Add(this.LblMobCounter);
            this.PanelMob.Controls.Add(this.BtnMobGen);
            this.PanelMob.Controls.Add(this.BtnSubMob);
            this.PanelMob.Controls.Add(this.BtnAddMob);
            this.PanelMob.Controls.Add(this.PictureMob);
            this.PanelMob.Location = new System.Drawing.Point(165, 381);
            this.PanelMob.Name = "PanelMob";
            this.PanelMob.Size = new System.Drawing.Size(1127, 139);
            this.PanelMob.TabIndex = 14;
            // 
            // BtnPrevMob
            // 
            this.BtnPrevMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevMob.Location = new System.Drawing.Point(1019, 13);
            this.BtnPrevMob.Name = "BtnPrevMob";
            this.BtnPrevMob.Size = new System.Drawing.Size(42, 110);
            this.BtnPrevMob.TabIndex = 13;
            this.BtnPrevMob.Text = "<";
            this.BtnPrevMob.UseVisualStyleBackColor = true;
            this.BtnPrevMob.Click += new System.EventHandler(this.BtnPrevMob_Click);
            // 
            // BtnNextMob
            // 
            this.BtnNextMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextMob.Location = new System.Drawing.Point(1067, 13);
            this.BtnNextMob.Name = "BtnNextMob";
            this.BtnNextMob.Size = new System.Drawing.Size(42, 110);
            this.BtnNextMob.TabIndex = 12;
            this.BtnNextMob.Text = ">";
            this.BtnNextMob.UseVisualStyleBackColor = true;
            this.BtnNextMob.Click += new System.EventHandler(this.BtnNextMob_Click);
            // 
            // LblMobStats3Values
            // 
            this.LblMobStats3Values.AutoSize = true;
            this.LblMobStats3Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobStats3Values.Location = new System.Drawing.Point(929, 13);
            this.LblMobStats3Values.Name = "LblMobStats3Values";
            this.LblMobStats3Values.Size = new System.Drawing.Size(27, 80);
            this.LblMobStats3Values.TabIndex = 11;
            this.LblMobStats3Values.Text = "50\r\n5\r\n15\r\n10";
            // 
            // LblMobStats3
            // 
            this.LblMobStats3.AutoSize = true;
            this.LblMobStats3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobStats3.Location = new System.Drawing.Point(799, 13);
            this.LblMobStats3.Name = "LblMobStats3";
            this.LblMobStats3.Size = new System.Drawing.Size(110, 80);
            this.LblMobStats3.TabIndex = 10;
            this.LblMobStats3.Text = "Combat Width\r\nHardness\r\nAir Attack\r\nPiercing";
            // 
            // LblMobStats2Values
            // 
            this.LblMobStats2Values.AutoSize = true;
            this.LblMobStats2Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobStats2Values.Location = new System.Drawing.Point(700, 13);
            this.LblMobStats2Values.Name = "LblMobStats2Values";
            this.LblMobStats2Values.Size = new System.Drawing.Size(36, 100);
            this.LblMobStats2Values.TabIndex = 9;
            this.LblMobStats2Values.Text = "130\r\n35\r\n90\r\n45\r\n0";
            // 
            // LblMobStats2
            // 
            this.LblMobStats2.AutoSize = true;
            this.LblMobStats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobStats2.Location = new System.Drawing.Point(547, 13);
            this.LblMobStats2.Name = "LblMobStats2";
            this.LblMobStats2.Size = new System.Drawing.Size(138, 100);
            this.LblMobStats2.TabIndex = 8;
            this.LblMobStats2.Text = "Breakthrough\r\nFuel Consumption\r\nReliability\r\nOrganization\r\nEntrenchment\r\n";
            // 
            // LblMobStats1Values
            // 
            this.LblMobStats1Values.AutoSize = true;
            this.LblMobStats1Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobStats1Values.Location = new System.Drawing.Point(458, 13);
            this.LblMobStats1Values.Name = "LblMobStats1Values";
            this.LblMobStats1Values.Size = new System.Drawing.Size(36, 100);
            this.LblMobStats1Values.TabIndex = 7;
            this.LblMobStats1Values.Text = "800\r\n75\r\n25\r\n30\r\n5";
            // 
            // LblMobStats1
            // 
            this.LblMobStats1.AutoSize = true;
            this.LblMobStats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobStats1.Location = new System.Drawing.Point(338, 13);
            this.LblMobStats1.Name = "LblMobStats1";
            this.LblMobStats1.Size = new System.Drawing.Size(94, 100);
            this.LblMobStats1.TabIndex = 6;
            this.LblMobStats1.Text = "Manpower\r\nSoft Attack\r\nHard Attack\r\nDefence\r\nArmor";
            // 
            // PictureMobGen
            // 
            this.PictureMobGen.BackColor = System.Drawing.Color.Transparent;
            this.PictureMobGen.Image = global::Wargame.Properties.Resources.gen_1;
            this.PictureMobGen.Location = new System.Drawing.Point(267, 16);
            this.PictureMobGen.Name = "PictureMobGen";
            this.PictureMobGen.Size = new System.Drawing.Size(35, 35);
            this.PictureMobGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureMobGen.TabIndex = 5;
            this.PictureMobGen.TabStop = false;
            // 
            // LblMobCounter
            // 
            this.LblMobCounter.AutoSize = true;
            this.LblMobCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMobCounter.Location = new System.Drawing.Point(205, 69);
            this.LblMobCounter.Name = "LblMobCounter";
            this.LblMobCounter.Size = new System.Drawing.Size(71, 24);
            this.LblMobCounter.TabIndex = 4;
            this.LblMobCounter.Text = "Units: 0";
            // 
            // BtnMobGen
            // 
            this.BtnMobGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMobGen.Location = new System.Drawing.Point(203, 13);
            this.BtnMobGen.Name = "BtnMobGen";
            this.BtnMobGen.Size = new System.Drawing.Size(58, 38);
            this.BtnMobGen.TabIndex = 3;
            this.BtnMobGen.Text = "Gen";
            this.BtnMobGen.UseVisualStyleBackColor = true;
            this.BtnMobGen.Click += new System.EventHandler(this.BtnMobGen_Click);
            // 
            // BtnSubMob
            // 
            this.BtnSubMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubMob.Location = new System.Drawing.Point(114, 99);
            this.BtnSubMob.Name = "BtnSubMob";
            this.BtnSubMob.Size = new System.Drawing.Size(57, 29);
            this.BtnSubMob.TabIndex = 2;
            this.BtnSubMob.Text = "-";
            this.BtnSubMob.UseVisualStyleBackColor = true;
            this.BtnSubMob.Click += new System.EventHandler(this.BtnSubMob_Click);
            // 
            // BtnAddMob
            // 
            this.BtnAddMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMob.Location = new System.Drawing.Point(27, 99);
            this.BtnAddMob.Name = "BtnAddMob";
            this.BtnAddMob.Size = new System.Drawing.Size(57, 29);
            this.BtnAddMob.TabIndex = 1;
            this.BtnAddMob.Text = "+";
            this.BtnAddMob.UseVisualStyleBackColor = true;
            this.BtnAddMob.Click += new System.EventHandler(this.BtnAddMob_Click);
            // 
            // PictureMob
            // 
            this.PictureMob.Image = ((System.Drawing.Image)(resources.GetObject("PictureMob.Image")));
            this.PictureMob.Location = new System.Drawing.Point(17, 13);
            this.PictureMob.Name = "PictureMob";
            this.PictureMob.Size = new System.Drawing.Size(179, 80);
            this.PictureMob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureMob.TabIndex = 0;
            this.PictureMob.TabStop = false;
            // 
            // PanelAir
            // 
            this.PanelAir.BackgroundImage = global::Wargame.Properties.Resources.generic_bg_307x113;
            this.PanelAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAir.Controls.Add(this.LblAirExp);
            this.PanelAir.Controls.Add(this.PictureAirExp);
            this.PanelAir.Controls.Add(this.BtnPrevAir);
            this.PanelAir.Controls.Add(this.BtnNextAir);
            this.PanelAir.Controls.Add(this.LblAirStats1Values);
            this.PanelAir.Controls.Add(this.LblAirStats1);
            this.PanelAir.Controls.Add(this.PictureAirGen);
            this.PanelAir.Controls.Add(this.LblAirCounter);
            this.PanelAir.Controls.Add(this.BtnAirGen);
            this.PanelAir.Controls.Add(this.BtnSubAir);
            this.PanelAir.Controls.Add(this.BtnAddAir);
            this.PanelAir.Controls.Add(this.PictureAir);
            this.PanelAir.Location = new System.Drawing.Point(165, 587);
            this.PanelAir.Name = "PanelAir";
            this.PanelAir.Size = new System.Drawing.Size(1127, 139);
            this.PanelAir.TabIndex = 15;
            // 
            // LblAirExp
            // 
            this.LblAirExp.AutoSize = true;
            this.LblAirExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAirExp.Location = new System.Drawing.Point(263, 104);
            this.LblAirExp.Name = "LblAirExp";
            this.LblAirExp.Size = new System.Drawing.Size(65, 20);
            this.LblAirExp.TabIndex = 15;
            this.LblAirExp.Text = "Regular";
            // 
            // PictureAirExp
            // 
            this.PictureAirExp.Image = global::Wargame.Properties.Resources.unit_level_2;
            this.PictureAirExp.Location = new System.Drawing.Point(220, 104);
            this.PictureAirExp.Name = "PictureAirExp";
            this.PictureAirExp.Size = new System.Drawing.Size(17, 22);
            this.PictureAirExp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureAirExp.TabIndex = 14;
            this.PictureAirExp.TabStop = false;
            this.PictureAirExp.Click += new System.EventHandler(this.PictureAirExp_Click);
            // 
            // BtnPrevAir
            // 
            this.BtnPrevAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevAir.Location = new System.Drawing.Point(1019, 13);
            this.BtnPrevAir.Name = "BtnPrevAir";
            this.BtnPrevAir.Size = new System.Drawing.Size(42, 110);
            this.BtnPrevAir.TabIndex = 13;
            this.BtnPrevAir.Text = "<";
            this.BtnPrevAir.UseVisualStyleBackColor = true;
            this.BtnPrevAir.Click += new System.EventHandler(this.BtnPrevAir_Click);
            // 
            // BtnNextAir
            // 
            this.BtnNextAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextAir.Location = new System.Drawing.Point(1067, 13);
            this.BtnNextAir.Name = "BtnNextAir";
            this.BtnNextAir.Size = new System.Drawing.Size(42, 110);
            this.BtnNextAir.TabIndex = 12;
            this.BtnNextAir.Text = ">";
            this.BtnNextAir.UseVisualStyleBackColor = true;
            this.BtnNextAir.Click += new System.EventHandler(this.BtnNextAir_Click);
            // 
            // LblAirStats1Values
            // 
            this.LblAirStats1Values.AutoSize = true;
            this.LblAirStats1Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAirStats1Values.Location = new System.Drawing.Point(547, 13);
            this.LblAirStats1Values.Name = "LblAirStats1Values";
            this.LblAirStats1Values.Size = new System.Drawing.Size(27, 100);
            this.LblAirStats1Values.TabIndex = 7;
            this.LblAirStats1Values.Text = "80\r\n50\r\n20\r\n30\r\n5";
            // 
            // LblAirStats1
            // 
            this.LblAirStats1.AutoSize = true;
            this.LblAirStats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAirStats1.Location = new System.Drawing.Point(363, 13);
            this.LblAirStats1.Name = "LblAirStats1";
            this.LblAirStats1.Size = new System.Drawing.Size(140, 100);
            this.LblAirStats1.TabIndex = 6;
            this.LblAirStats1.Text = "Integrity\r\nAir Attack\r\nGround Attack\r\nAir Superiority\r\nStrategic Bombing";
            // 
            // PictureAirGen
            // 
            this.PictureAirGen.BackColor = System.Drawing.Color.Transparent;
            this.PictureAirGen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureAirGen.BackgroundImage")));
            this.PictureAirGen.Location = new System.Drawing.Point(267, 16);
            this.PictureAirGen.Name = "PictureAirGen";
            this.PictureAirGen.Size = new System.Drawing.Size(35, 35);
            this.PictureAirGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureAirGen.TabIndex = 5;
            this.PictureAirGen.TabStop = false;
            // 
            // LblAirCounter
            // 
            this.LblAirCounter.AutoSize = true;
            this.LblAirCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAirCounter.Location = new System.Drawing.Point(205, 69);
            this.LblAirCounter.Name = "LblAirCounter";
            this.LblAirCounter.Size = new System.Drawing.Size(71, 24);
            this.LblAirCounter.TabIndex = 4;
            this.LblAirCounter.Text = "Units: 0";
            // 
            // BtnAirGen
            // 
            this.BtnAirGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAirGen.Location = new System.Drawing.Point(203, 13);
            this.BtnAirGen.Name = "BtnAirGen";
            this.BtnAirGen.Size = new System.Drawing.Size(58, 38);
            this.BtnAirGen.TabIndex = 3;
            this.BtnAirGen.Text = "Gen";
            this.BtnAirGen.UseVisualStyleBackColor = true;
            this.BtnAirGen.Click += new System.EventHandler(this.BtnAirGen_Click);
            // 
            // BtnSubAir
            // 
            this.BtnSubAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubAir.Location = new System.Drawing.Point(114, 99);
            this.BtnSubAir.Name = "BtnSubAir";
            this.BtnSubAir.Size = new System.Drawing.Size(57, 29);
            this.BtnSubAir.TabIndex = 2;
            this.BtnSubAir.Text = "-";
            this.BtnSubAir.UseVisualStyleBackColor = true;
            this.BtnSubAir.Click += new System.EventHandler(this.BtnSubAir_Click);
            // 
            // BtnAddAir
            // 
            this.BtnAddAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAir.Location = new System.Drawing.Point(27, 99);
            this.BtnAddAir.Name = "BtnAddAir";
            this.BtnAddAir.Size = new System.Drawing.Size(57, 29);
            this.BtnAddAir.TabIndex = 1;
            this.BtnAddAir.Text = "+";
            this.BtnAddAir.UseVisualStyleBackColor = true;
            this.BtnAddAir.Click += new System.EventHandler(this.BtnAddAir_Click);
            // 
            // PictureAir
            // 
            this.PictureAir.Image = ((System.Drawing.Image)(resources.GetObject("PictureAir.Image")));
            this.PictureAir.Location = new System.Drawing.Point(17, 13);
            this.PictureAir.Name = "PictureAir";
            this.PictureAir.Size = new System.Drawing.Size(180, 80);
            this.PictureAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureAir.TabIndex = 0;
            this.PictureAir.TabStop = false;
            // 
            // PictureCommander
            // 
            this.PictureCommander.Image = global::Wargame.Properties.Resources.macarthur;
            this.PictureCommander.Location = new System.Drawing.Point(12, 136);
            this.PictureCommander.Name = "PictureCommander";
            this.PictureCommander.Size = new System.Drawing.Size(147, 182);
            this.PictureCommander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCommander.TabIndex = 16;
            this.PictureCommander.TabStop = false;
            // 
            // DefenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wargame.Properties.Resources.defender_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1554, 1041);
            this.Controls.Add(this.PictureCommander);
            this.Controls.Add(this.PanelAir);
            this.Controls.Add(this.PanelMob);
            this.Controls.Add(this.PanelLeg);
            this.Controls.Add(this.PanelDefenderStats);
            this.Controls.Add(this.PictureFlagDefender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefenderForm";
            this.Text = "DefenderForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureFlagDefender)).EndInit();
            this.PanelDefenderStats.ResumeLayout(false);
            this.PanelDefenderStats.PerformLayout();
            this.PanelLeg.ResumeLayout(false);
            this.PanelLeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLegGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLeg)).EndInit();
            this.PanelMob.ResumeLayout(false);
            this.PanelMob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMobGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMob)).EndInit();
            this.PanelAir.ResumeLayout(false);
            this.PanelAir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAirExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAirGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCommander)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureFlagDefender;
        private System.Windows.Forms.Panel PanelDefenderStats;
        private System.Windows.Forms.Label LblDefArmyStats;
        private System.Windows.Forms.Panel PanelLeg;
        private System.Windows.Forms.PictureBox PictureLeg;
        private System.Windows.Forms.PictureBox PictureLegGen;
        private System.Windows.Forms.Label LblLegCounter;
        private System.Windows.Forms.Button BtnLegGen;
        private System.Windows.Forms.Button BtnSubLeg;
        private System.Windows.Forms.Button BtnAddLeg;
        private System.Windows.Forms.Button BtnNextLeg;
        private System.Windows.Forms.Label LblLegStats3Values;
        private System.Windows.Forms.Label LblLegStats3;
        private System.Windows.Forms.Label LblLegStats2Values;
        private System.Windows.Forms.Label LblLegStats2;
        private System.Windows.Forms.Label LblLegStats1Values;
        private System.Windows.Forms.Label LblLegStats1;
        private System.Windows.Forms.Button BtnPrevLeg;
        private System.Windows.Forms.Panel PanelMob;
        private System.Windows.Forms.Button BtnPrevMob;
        private System.Windows.Forms.Button BtnNextMob;
        private System.Windows.Forms.Label LblMobStats3Values;
        private System.Windows.Forms.Label LblMobStats3;
        private System.Windows.Forms.Label LblMobStats2Values;
        private System.Windows.Forms.Label LblMobStats2;
        private System.Windows.Forms.Label LblMobStats1Values;
        private System.Windows.Forms.Label LblMobStats1;
        private System.Windows.Forms.PictureBox PictureMobGen;
        private System.Windows.Forms.Label LblMobCounter;
        private System.Windows.Forms.Button BtnMobGen;
        private System.Windows.Forms.Button BtnSubMob;
        private System.Windows.Forms.Button BtnAddMob;
        private System.Windows.Forms.PictureBox PictureMob;
        private System.Windows.Forms.Panel PanelAir;
        private System.Windows.Forms.Button BtnPrevAir;
        private System.Windows.Forms.Button BtnNextAir;
        private System.Windows.Forms.Label LblAirStats1Values;
        private System.Windows.Forms.Label LblAirStats1;
        private System.Windows.Forms.PictureBox PictureAirGen;
        private System.Windows.Forms.Label LblAirCounter;
        private System.Windows.Forms.Button BtnAirGen;
        private System.Windows.Forms.Button BtnSubAir;
        private System.Windows.Forms.Button BtnAddAir;
        private System.Windows.Forms.PictureBox PictureAir;
        private System.Windows.Forms.PictureBox PictureCommander;
        private System.Windows.Forms.Label LblAirExp;
        private System.Windows.Forms.PictureBox PictureAirExp;
    }
}