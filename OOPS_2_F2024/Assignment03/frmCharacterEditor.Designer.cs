namespace Assignment03
{
    partial class frmCharacterEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharacterEditor));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_EnterCharacterDetails = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.cbo_Class = new System.Windows.Forms.ComboBox();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.nud_Strength = new System.Windows.Forms.NumericUpDown();
            this.lbl_Race = new System.Windows.Forms.Label();
            this.cbo_Race = new System.Windows.Forms.ComboBox();
            this.lbl_Alignment = new System.Windows.Forms.Label();
            this.cbo_Alignment = new System.Windows.Forms.ComboBox();
            this.lbl_Strength = new System.Windows.Forms.Label();
            this.nud_Level = new System.Windows.Forms.NumericUpDown();
            this.lbl_Dexterity = new System.Windows.Forms.Label();
            this.nud_Dexterity = new System.Windows.Forms.NumericUpDown();
            this.lbl_Constitution = new System.Windows.Forms.Label();
            this.lbl_Intelligence = new System.Windows.Forms.Label();
            this.lbl_Wisdom = new System.Windows.Forms.Label();
            this.lbl_Charisma = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Initiative = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.lbl_HitPoints = new System.Windows.Forms.Label();
            this.nud_Constitution = new System.Windows.Forms.NumericUpDown();
            this.nud_Intelligence = new System.Windows.Forms.NumericUpDown();
            this.nud_Wisdom = new System.Windows.Forms.NumericUpDown();
            this.nud_Charisma = new System.Windows.Forms.NumericUpDown();
            this.nud_Initiative = new System.Windows.Forms.NumericUpDown();
            this.nud_Speed = new System.Windows.Forms.NumericUpDown();
            this.nud_HitPoints = new System.Windows.Forms.NumericUpDown();
            this.cbo_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.nud_AttributePoints = new System.Windows.Forms.NumericUpDown();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gbx_BasicInformation = new System.Windows.Forms.GroupBox();
            this.gbx_Attributes = new System.Windows.Forms.GroupBox();
            this.btn_SaveAttributeChanges = new System.Windows.Forms.Button();
            this.lbl_Armor = new System.Windows.Forms.Label();
            this.nud_Armor = new System.Windows.Forms.NumericUpDown();
            this.gbx_CharacterStats = new System.Windows.Forms.GroupBox();
            this.lbl_XP = new System.Windows.Forms.Label();
            this.nud_XP = new System.Windows.Forms.NumericUpDown();
            this.pbx_CharacterImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Constitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Intelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Wisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Charisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Initiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HitPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AttributePoints)).BeginInit();
            this.gbx_BasicInformation.SuspendLayout();
            this.gbx_Attributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Armor)).BeginInit();
            this.gbx_CharacterStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_XP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CharacterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(37, 45);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(78, 29);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(233, 42);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(393, 34);
            this.tbx_Name.TabIndex = 1;
            // 
            // lbl_EnterCharacterDetails
            // 
            this.lbl_EnterCharacterDetails.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_EnterCharacterDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_EnterCharacterDetails.Font = new System.Drawing.Font("Stencil", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterCharacterDetails.ForeColor = System.Drawing.Color.White;
            this.lbl_EnterCharacterDetails.Location = new System.Drawing.Point(0, 0);
            this.lbl_EnterCharacterDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_EnterCharacterDetails.Name = "lbl_EnterCharacterDetails";
            this.lbl_EnterCharacterDetails.Size = new System.Drawing.Size(1467, 67);
            this.lbl_EnterCharacterDetails.TabIndex = 2;
            this.lbl_EnterCharacterDetails.Text = "Enter Character Details";
            this.lbl_EnterCharacterDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Class.Location = new System.Drawing.Point(37, 96);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(73, 29);
            this.lbl_Class.TabIndex = 3;
            this.lbl_Class.Text = "Class";
            // 
            // cbo_Class
            // 
            this.cbo_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Class.FormattingEnabled = true;
            this.cbo_Class.Items.AddRange(new object[] {
            "Barbarian",
            "Cleric",
            "Druid",
            "Bard",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.cbo_Class.Location = new System.Drawing.Point(233, 93);
            this.cbo_Class.Name = "cbo_Class";
            this.cbo_Class.Size = new System.Drawing.Size(393, 37);
            this.cbo_Class.TabIndex = 4;
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Level.Location = new System.Drawing.Point(41, 105);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(71, 29);
            this.lbl_Level.TabIndex = 5;
            this.lbl_Level.Text = "Level";
            // 
            // nud_Strength
            // 
            this.nud_Strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Strength.Location = new System.Drawing.Point(233, 84);
            this.nud_Strength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Strength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_Strength.Name = "nud_Strength";
            this.nud_Strength.Size = new System.Drawing.Size(120, 34);
            this.nud_Strength.TabIndex = 6;
            this.nud_Strength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_Race
            // 
            this.lbl_Race.AutoSize = true;
            this.lbl_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Race.Location = new System.Drawing.Point(37, 147);
            this.lbl_Race.Name = "lbl_Race";
            this.lbl_Race.Size = new System.Drawing.Size(69, 29);
            this.lbl_Race.TabIndex = 7;
            this.lbl_Race.Text = "Race";
            // 
            // cbo_Race
            // 
            this.cbo_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Race.FormattingEnabled = true;
            this.cbo_Race.Items.AddRange(new object[] {
            "Dwarf",
            "Elf (High)",
            "Elf (Wood)",
            "Halfling",
            "Human",
            "Dragonborn",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Tiefling",
            "Githyanki"});
            this.cbo_Race.Location = new System.Drawing.Point(233, 144);
            this.cbo_Race.Name = "cbo_Race";
            this.cbo_Race.Size = new System.Drawing.Size(393, 37);
            this.cbo_Race.TabIndex = 8;
            // 
            // lbl_Alignment
            // 
            this.lbl_Alignment.AutoSize = true;
            this.lbl_Alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alignment.Location = new System.Drawing.Point(37, 198);
            this.lbl_Alignment.Name = "lbl_Alignment";
            this.lbl_Alignment.Size = new System.Drawing.Size(120, 29);
            this.lbl_Alignment.TabIndex = 9;
            this.lbl_Alignment.Text = "Alignment";
            // 
            // cbo_Alignment
            // 
            this.cbo_Alignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Alignment.FormattingEnabled = true;
            this.cbo_Alignment.Items.AddRange(new object[] {
            "LawfulGood",
            "NeutralGood",
            "ChaoticGood",
            "LawfulNeutral",
            "Neutral",
            "ChaoticNeutral",
            "LawfulEvil",
            "NeutralEvil",
            "ChaoticEvil"});
            this.cbo_Alignment.Location = new System.Drawing.Point(233, 195);
            this.cbo_Alignment.Name = "cbo_Alignment";
            this.cbo_Alignment.Size = new System.Drawing.Size(393, 37);
            this.cbo_Alignment.TabIndex = 10;
            // 
            // lbl_Strength
            // 
            this.lbl_Strength.AutoSize = true;
            this.lbl_Strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Strength.Location = new System.Drawing.Point(37, 91);
            this.lbl_Strength.Name = "lbl_Strength";
            this.lbl_Strength.Size = new System.Drawing.Size(103, 29);
            this.lbl_Strength.TabIndex = 11;
            this.lbl_Strength.Text = "Strength";
            // 
            // nud_Level
            // 
            this.nud_Level.Enabled = false;
            this.nud_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Level.Location = new System.Drawing.Point(237, 98);
            this.nud_Level.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Level.Name = "nud_Level";
            this.nud_Level.Size = new System.Drawing.Size(120, 34);
            this.nud_Level.TabIndex = 12;
            this.nud_Level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Dexterity
            // 
            this.lbl_Dexterity.AutoSize = true;
            this.lbl_Dexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dexterity.Location = new System.Drawing.Point(37, 141);
            this.lbl_Dexterity.Name = "lbl_Dexterity";
            this.lbl_Dexterity.Size = new System.Drawing.Size(106, 29);
            this.lbl_Dexterity.TabIndex = 13;
            this.lbl_Dexterity.Text = "Dexterity";
            // 
            // nud_Dexterity
            // 
            this.nud_Dexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Dexterity.Location = new System.Drawing.Point(233, 134);
            this.nud_Dexterity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Dexterity.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_Dexterity.Name = "nud_Dexterity";
            this.nud_Dexterity.Size = new System.Drawing.Size(120, 34);
            this.nud_Dexterity.TabIndex = 14;
            this.nud_Dexterity.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_Constitution
            // 
            this.lbl_Constitution.AutoSize = true;
            this.lbl_Constitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Constitution.Location = new System.Drawing.Point(37, 191);
            this.lbl_Constitution.Name = "lbl_Constitution";
            this.lbl_Constitution.Size = new System.Drawing.Size(139, 29);
            this.lbl_Constitution.TabIndex = 15;
            this.lbl_Constitution.Text = "Constitution";
            // 
            // lbl_Intelligence
            // 
            this.lbl_Intelligence.AutoSize = true;
            this.lbl_Intelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intelligence.Location = new System.Drawing.Point(37, 241);
            this.lbl_Intelligence.Name = "lbl_Intelligence";
            this.lbl_Intelligence.Size = new System.Drawing.Size(137, 29);
            this.lbl_Intelligence.TabIndex = 16;
            this.lbl_Intelligence.Text = "Intelligence";
            // 
            // lbl_Wisdom
            // 
            this.lbl_Wisdom.AutoSize = true;
            this.lbl_Wisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wisdom.Location = new System.Drawing.Point(37, 291);
            this.lbl_Wisdom.Name = "lbl_Wisdom";
            this.lbl_Wisdom.Size = new System.Drawing.Size(101, 29);
            this.lbl_Wisdom.TabIndex = 17;
            this.lbl_Wisdom.Text = "Wisdom";
            // 
            // lbl_Charisma
            // 
            this.lbl_Charisma.AutoSize = true;
            this.lbl_Charisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Charisma.Location = new System.Drawing.Point(37, 341);
            this.lbl_Charisma.Name = "lbl_Charisma";
            this.lbl_Charisma.Size = new System.Drawing.Size(115, 29);
            this.lbl_Charisma.TabIndex = 18;
            this.lbl_Charisma.Text = "Charisma";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(37, 249);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(94, 29);
            this.lbl_Gender.TabIndex = 19;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Initiative
            // 
            this.lbl_Initiative.AutoSize = true;
            this.lbl_Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Initiative.Location = new System.Drawing.Point(41, 205);
            this.lbl_Initiative.Name = "lbl_Initiative";
            this.lbl_Initiative.Size = new System.Drawing.Size(100, 29);
            this.lbl_Initiative.TabIndex = 20;
            this.lbl_Initiative.Text = "Initiative";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Speed.Location = new System.Drawing.Point(41, 255);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(85, 29);
            this.lbl_Speed.TabIndex = 21;
            this.lbl_Speed.Text = "Speed";
            // 
            // lbl_HitPoints
            // 
            this.lbl_HitPoints.AutoSize = true;
            this.lbl_HitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HitPoints.Location = new System.Drawing.Point(41, 305);
            this.lbl_HitPoints.Name = "lbl_HitPoints";
            this.lbl_HitPoints.Size = new System.Drawing.Size(115, 29);
            this.lbl_HitPoints.TabIndex = 22;
            this.lbl_HitPoints.Text = "Hit Points";
            // 
            // nud_Constitution
            // 
            this.nud_Constitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Constitution.Location = new System.Drawing.Point(233, 184);
            this.nud_Constitution.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Constitution.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_Constitution.Name = "nud_Constitution";
            this.nud_Constitution.Size = new System.Drawing.Size(120, 34);
            this.nud_Constitution.TabIndex = 23;
            this.nud_Constitution.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nud_Intelligence
            // 
            this.nud_Intelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Intelligence.Location = new System.Drawing.Point(233, 234);
            this.nud_Intelligence.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Intelligence.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_Intelligence.Name = "nud_Intelligence";
            this.nud_Intelligence.Size = new System.Drawing.Size(120, 34);
            this.nud_Intelligence.TabIndex = 24;
            this.nud_Intelligence.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nud_Wisdom
            // 
            this.nud_Wisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Wisdom.Location = new System.Drawing.Point(233, 284);
            this.nud_Wisdom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Wisdom.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_Wisdom.Name = "nud_Wisdom";
            this.nud_Wisdom.Size = new System.Drawing.Size(120, 34);
            this.nud_Wisdom.TabIndex = 25;
            this.nud_Wisdom.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nud_Charisma
            // 
            this.nud_Charisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Charisma.Location = new System.Drawing.Point(233, 334);
            this.nud_Charisma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_Charisma.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_Charisma.Name = "nud_Charisma";
            this.nud_Charisma.Size = new System.Drawing.Size(120, 34);
            this.nud_Charisma.TabIndex = 26;
            this.nud_Charisma.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nud_Initiative
            // 
            this.nud_Initiative.Enabled = false;
            this.nud_Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Initiative.Location = new System.Drawing.Point(237, 198);
            this.nud_Initiative.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_Initiative.Name = "nud_Initiative";
            this.nud_Initiative.Size = new System.Drawing.Size(120, 34);
            this.nud_Initiative.TabIndex = 27;
            // 
            // nud_Speed
            // 
            this.nud_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Speed.Location = new System.Drawing.Point(237, 248);
            this.nud_Speed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Speed.Name = "nud_Speed";
            this.nud_Speed.Size = new System.Drawing.Size(120, 34);
            this.nud_Speed.TabIndex = 28;
            // 
            // nud_HitPoints
            // 
            this.nud_HitPoints.Enabled = false;
            this.nud_HitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_HitPoints.Location = new System.Drawing.Point(237, 298);
            this.nud_HitPoints.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_HitPoints.Name = "nud_HitPoints";
            this.nud_HitPoints.Size = new System.Drawing.Size(120, 34);
            this.nud_HitPoints.TabIndex = 29;
            // 
            // cbo_Gender
            // 
            this.cbo_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Gender.FormattingEnabled = true;
            this.cbo_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Gender-Diverse"});
            this.cbo_Gender.Location = new System.Drawing.Point(233, 246);
            this.cbo_Gender.Name = "cbo_Gender";
            this.cbo_Gender.Size = new System.Drawing.Size(393, 37);
            this.cbo_Gender.TabIndex = 30;
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Points.Location = new System.Drawing.Point(37, 39);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(184, 29);
            this.lbl_Points.TabIndex = 31;
            this.lbl_Points.Text = "Available Points";
            // 
            // nud_AttributePoints
            // 
            this.nud_AttributePoints.Enabled = false;
            this.nud_AttributePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_AttributePoints.Location = new System.Drawing.Point(233, 37);
            this.nud_AttributePoints.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.nud_AttributePoints.Name = "nud_AttributePoints";
            this.nud_AttributePoints.Size = new System.Drawing.Size(120, 34);
            this.nud_AttributePoints.TabIndex = 32;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(1244, 744);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(211, 74);
            this.btn_Back.TabIndex = 33;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1025, 744);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(211, 74);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gbx_BasicInformation
            // 
            this.gbx_BasicInformation.Controls.Add(this.lbl_Name);
            this.gbx_BasicInformation.Controls.Add(this.tbx_Name);
            this.gbx_BasicInformation.Controls.Add(this.lbl_Class);
            this.gbx_BasicInformation.Controls.Add(this.cbo_Class);
            this.gbx_BasicInformation.Controls.Add(this.lbl_Race);
            this.gbx_BasicInformation.Controls.Add(this.cbo_Gender);
            this.gbx_BasicInformation.Controls.Add(this.cbo_Race);
            this.gbx_BasicInformation.Controls.Add(this.lbl_Alignment);
            this.gbx_BasicInformation.Controls.Add(this.cbo_Alignment);
            this.gbx_BasicInformation.Controls.Add(this.lbl_Gender);
            this.gbx_BasicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_BasicInformation.Location = new System.Drawing.Point(8, 70);
            this.gbx_BasicInformation.Name = "gbx_BasicInformation";
            this.gbx_BasicInformation.Size = new System.Drawing.Size(818, 296);
            this.gbx_BasicInformation.TabIndex = 35;
            this.gbx_BasicInformation.TabStop = false;
            this.gbx_BasicInformation.Text = "Basic Information";
            // 
            // gbx_Attributes
            // 
            this.gbx_Attributes.Controls.Add(this.btn_SaveAttributeChanges);
            this.gbx_Attributes.Controls.Add(this.nud_Strength);
            this.gbx_Attributes.Controls.Add(this.lbl_Strength);
            this.gbx_Attributes.Controls.Add(this.lbl_Dexterity);
            this.gbx_Attributes.Controls.Add(this.nud_Dexterity);
            this.gbx_Attributes.Controls.Add(this.lbl_Constitution);
            this.gbx_Attributes.Controls.Add(this.lbl_Intelligence);
            this.gbx_Attributes.Controls.Add(this.lbl_Wisdom);
            this.gbx_Attributes.Controls.Add(this.lbl_Points);
            this.gbx_Attributes.Controls.Add(this.nud_Charisma);
            this.gbx_Attributes.Controls.Add(this.nud_AttributePoints);
            this.gbx_Attributes.Controls.Add(this.lbl_Charisma);
            this.gbx_Attributes.Controls.Add(this.nud_Wisdom);
            this.gbx_Attributes.Controls.Add(this.nud_Intelligence);
            this.gbx_Attributes.Controls.Add(this.nud_Constitution);
            this.gbx_Attributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Attributes.Location = new System.Drawing.Point(8, 372);
            this.gbx_Attributes.Name = "gbx_Attributes";
            this.gbx_Attributes.Size = new System.Drawing.Size(378, 447);
            this.gbx_Attributes.TabIndex = 36;
            this.gbx_Attributes.TabStop = false;
            this.gbx_Attributes.Text = "Attributes";
            // 
            // btn_SaveAttributeChanges
            // 
            this.btn_SaveAttributeChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAttributeChanges.BackColor = System.Drawing.Color.Firebrick;
            this.btn_SaveAttributeChanges.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SaveAttributeChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveAttributeChanges.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveAttributeChanges.ForeColor = System.Drawing.Color.White;
            this.btn_SaveAttributeChanges.Location = new System.Drawing.Point(7, 382);
            this.btn_SaveAttributeChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaveAttributeChanges.Name = "btn_SaveAttributeChanges";
            this.btn_SaveAttributeChanges.Size = new System.Drawing.Size(364, 58);
            this.btn_SaveAttributeChanges.TabIndex = 42;
            this.btn_SaveAttributeChanges.Text = "Save and Claim Bonus Points";
            this.btn_SaveAttributeChanges.UseVisualStyleBackColor = false;
            // 
            // lbl_Armor
            // 
            this.lbl_Armor.AutoSize = true;
            this.lbl_Armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Armor.Location = new System.Drawing.Point(41, 155);
            this.lbl_Armor.Name = "lbl_Armor";
            this.lbl_Armor.Size = new System.Drawing.Size(78, 29);
            this.lbl_Armor.TabIndex = 38;
            this.lbl_Armor.Text = "Armor";
            // 
            // nud_Armor
            // 
            this.nud_Armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Armor.Location = new System.Drawing.Point(237, 148);
            this.nud_Armor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Armor.Name = "nud_Armor";
            this.nud_Armor.Size = new System.Drawing.Size(120, 34);
            this.nud_Armor.TabIndex = 39;
            // 
            // gbx_CharacterStats
            // 
            this.gbx_CharacterStats.Controls.Add(this.lbl_XP);
            this.gbx_CharacterStats.Controls.Add(this.lbl_Armor);
            this.gbx_CharacterStats.Controls.Add(this.nud_XP);
            this.gbx_CharacterStats.Controls.Add(this.nud_Armor);
            this.gbx_CharacterStats.Controls.Add(this.lbl_Level);
            this.gbx_CharacterStats.Controls.Add(this.lbl_Speed);
            this.gbx_CharacterStats.Controls.Add(this.lbl_HitPoints);
            this.gbx_CharacterStats.Controls.Add(this.lbl_Initiative);
            this.gbx_CharacterStats.Controls.Add(this.nud_Level);
            this.gbx_CharacterStats.Controls.Add(this.nud_Initiative);
            this.gbx_CharacterStats.Controls.Add(this.nud_HitPoints);
            this.gbx_CharacterStats.Controls.Add(this.nud_Speed);
            this.gbx_CharacterStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_CharacterStats.Location = new System.Drawing.Point(392, 372);
            this.gbx_CharacterStats.Name = "gbx_CharacterStats";
            this.gbx_CharacterStats.Size = new System.Drawing.Size(434, 447);
            this.gbx_CharacterStats.TabIndex = 40;
            this.gbx_CharacterStats.TabStop = false;
            this.gbx_CharacterStats.Text = "Character Stats";
            // 
            // lbl_XP
            // 
            this.lbl_XP.AutoSize = true;
            this.lbl_XP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XP.Location = new System.Drawing.Point(41, 55);
            this.lbl_XP.Name = "lbl_XP";
            this.lbl_XP.Size = new System.Drawing.Size(46, 29);
            this.lbl_XP.TabIndex = 41;
            this.lbl_XP.Text = "XP";
            // 
            // nud_XP
            // 
            this.nud_XP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_XP.Location = new System.Drawing.Point(237, 48);
            this.nud_XP.Maximum = new decimal(new int[] {
            355000,
            0,
            0,
            0});
            this.nud_XP.Name = "nud_XP";
            this.nud_XP.Size = new System.Drawing.Size(120, 34);
            this.nud_XP.TabIndex = 42;
            // 
            // pbx_CharacterImage
            // 
            this.pbx_CharacterImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_CharacterImage.BackgroundImage = global::Assignment03.Properties.Resources.pngegg;
            this.pbx_CharacterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_CharacterImage.Location = new System.Drawing.Point(832, 86);
            this.pbx_CharacterImage.Name = "pbx_CharacterImage";
            this.pbx_CharacterImage.Size = new System.Drawing.Size(623, 651);
            this.pbx_CharacterImage.TabIndex = 41;
            this.pbx_CharacterImage.TabStop = false;
            // 
            // frmCharacterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.pbx_CharacterImage);
            this.Controls.Add(this.gbx_CharacterStats);
            this.Controls.Add(this.gbx_Attributes);
            this.Controls.Add(this.gbx_BasicInformation);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_EnterCharacterDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCharacterEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons and Dragons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCharacterEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Constitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Intelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Wisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Charisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Initiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HitPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AttributePoints)).EndInit();
            this.gbx_BasicInformation.ResumeLayout(false);
            this.gbx_BasicInformation.PerformLayout();
            this.gbx_Attributes.ResumeLayout(false);
            this.gbx_Attributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Armor)).EndInit();
            this.gbx_CharacterStats.ResumeLayout(false);
            this.gbx_CharacterStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_XP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CharacterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label lbl_EnterCharacterDetails;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.ComboBox cbo_Class;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.NumericUpDown nud_Strength;
        private System.Windows.Forms.Label lbl_Race;
        private System.Windows.Forms.ComboBox cbo_Race;
        private System.Windows.Forms.Label lbl_Alignment;
        private System.Windows.Forms.ComboBox cbo_Alignment;
        private System.Windows.Forms.Label lbl_Strength;
        private System.Windows.Forms.NumericUpDown nud_Level;
        private System.Windows.Forms.Label lbl_Dexterity;
        private System.Windows.Forms.NumericUpDown nud_Dexterity;
        private System.Windows.Forms.Label lbl_Constitution;
        private System.Windows.Forms.Label lbl_Intelligence;
        private System.Windows.Forms.Label lbl_Wisdom;
        private System.Windows.Forms.Label lbl_Charisma;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Initiative;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label lbl_HitPoints;
        private System.Windows.Forms.NumericUpDown nud_Constitution;
        private System.Windows.Forms.NumericUpDown nud_Intelligence;
        private System.Windows.Forms.NumericUpDown nud_Wisdom;
        private System.Windows.Forms.NumericUpDown nud_Charisma;
        private System.Windows.Forms.NumericUpDown nud_Initiative;
        private System.Windows.Forms.NumericUpDown nud_Speed;
        private System.Windows.Forms.NumericUpDown nud_HitPoints;
        private System.Windows.Forms.ComboBox cbo_Gender;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.NumericUpDown nud_AttributePoints;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gbx_BasicInformation;
        private System.Windows.Forms.GroupBox gbx_Attributes;
        private System.Windows.Forms.Label lbl_Armor;
        private System.Windows.Forms.NumericUpDown nud_Armor;
        private System.Windows.Forms.GroupBox gbx_CharacterStats;
        private System.Windows.Forms.Label lbl_XP;
        private System.Windows.Forms.NumericUpDown nud_XP;
        private System.Windows.Forms.PictureBox pbx_CharacterImage;
        private System.Windows.Forms.Button btn_SaveAttributeChanges;
    }
}