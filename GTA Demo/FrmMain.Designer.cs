namespace GTA_Demo
{
    partial class FrmMain
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkVecInvisble = new System.Windows.Forms.CheckBox();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExplode = new System.Windows.Forms.Button();
            this.btnNonDamage = new System.Windows.Forms.Button();
            this.btnBoost = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.cmbVehicles = new System.Windows.Forms.ComboBox();
            this.btnVehicleSpawn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSwapAimedPed = new System.Windows.Forms.CheckBox();
            this.btnRandomPed = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnSkyDive = new System.Windows.Forms.Button();
            this.chkPlayerInvisible = new System.Windows.Forms.CheckBox();
            this.chkNoCops = new System.Windows.Forms.CheckBox();
            this.chkSeeThrough = new System.Windows.Forms.CheckBox();
            this.chkNightVision = new System.Windows.Forms.CheckBox();
            this.chkRagdoll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.btnSetModel = new System.Windows.Forms.Button();
            this.chkGravity = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblLoction = new System.Windows.Forms.Label();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTeleportWayPoint = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetWeather = new System.Windows.Forms.Button();
            this.btnUnlockTrophies = new System.Windows.Forms.Button();
            this.cmbWeathers = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGiveWeapon = new System.Windows.Forms.Button();
            this.cmbWeapons = new System.Windows.Forms.ComboBox();
            this.chkInfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chkPauseTime = new System.Windows.Forms.CheckBox();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(20, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(179, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.btnAttach);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(20, 20);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(179, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "192.168.100.8";
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(20, 87);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(179, 23);
            this.btnAttach.TabIndex = 0;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkVecInvisble);
            this.groupBox2.Controls.Add(this.numSpeed);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnChangeColor);
            this.groupBox2.Controls.Add(this.btnExplode);
            this.groupBox2.Controls.Add(this.btnNonDamage);
            this.groupBox2.Controls.Add(this.btnBoost);
            this.groupBox2.Controls.Add(this.btnFix);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnUpgrade);
            this.groupBox2.Controls.Add(this.cmbVehicles);
            this.groupBox2.Controls.Add(this.btnVehicleSpawn);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle";
            // 
            // chkVecInvisble
            // 
            this.chkVecInvisble.AutoSize = true;
            this.chkVecInvisble.Location = new System.Drawing.Point(72, 88);
            this.chkVecInvisble.Name = "chkVecInvisble";
            this.chkVecInvisble.Size = new System.Drawing.Size(64, 17);
            this.chkVecInvisble.TabIndex = 15;
            this.chkVecInvisble.Text = "Invisible";
            this.chkVecInvisble.UseVisualStyleBackColor = true;
            this.chkVecInvisble.CheckedChanged += new System.EventHandler(this.chkVecInvisble_CheckedChanged);
            // 
            // numSpeed
            // 
            this.numSpeed.DecimalPlaces = 4;
            this.numSpeed.Location = new System.Drawing.Point(132, 173);
            this.numSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(67, 20);
            this.numSpeed.TabIndex = 5;
            this.numSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(20, 292);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(179, 25);
            this.btnChangeColor.TabIndex = 8;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExplode
            // 
            this.btnExplode.Location = new System.Drawing.Point(20, 261);
            this.btnExplode.Name = "btnExplode";
            this.btnExplode.Size = new System.Drawing.Size(179, 25);
            this.btnExplode.TabIndex = 7;
            this.btnExplode.Text = "Explode";
            this.btnExplode.UseVisualStyleBackColor = true;
            this.btnExplode.Click += new System.EventHandler(this.btnExplode_Click);
            // 
            // btnNonDamage
            // 
            this.btnNonDamage.Location = new System.Drawing.Point(20, 199);
            this.btnNonDamage.Name = "btnNonDamage";
            this.btnNonDamage.Size = new System.Drawing.Size(179, 25);
            this.btnNonDamage.TabIndex = 5;
            this.btnNonDamage.Text = "No Damage";
            this.btnNonDamage.UseVisualStyleBackColor = true;
            this.btnNonDamage.Click += new System.EventHandler(this.btnNonDamage_Click);
            // 
            // btnBoost
            // 
            this.btnBoost.Location = new System.Drawing.Point(20, 171);
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(106, 25);
            this.btnBoost.TabIndex = 4;
            this.btnBoost.Text = "Boost";
            this.btnBoost.UseVisualStyleBackColor = true;
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(20, 140);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(179, 25);
            this.btnFix.TabIndex = 4;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 1);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(20, 111);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(179, 23);
            this.btnUpgrade.TabIndex = 2;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // cmbVehicles
            // 
            this.cmbVehicles.FormattingEnabled = true;
            this.cmbVehicles.Items.AddRange(new object[] {
            "ADDER",
            "AIRBUS",
            "AIRTUG",
            "AKUMA",
            "ALPHA",
            "AMBULANCE",
            "ANNIHILATOR",
            "ARMYTANKER",
            "ARMYTRAILER",
            "ARMYTRAILER2",
            "ASEA",
            "ASEA2",
            "ASTEROPE",
            "BAGGER",
            "BALETRAILER",
            "BALLER",
            "BALLER2",
            "BANSHEE",
            "BARRACKS",
            "BARRACKS2",
            "BATI",
            "BATI2",
            "BENSON",
            "BESRA",
            "BFINJECTION",
            "BIFF",
            "BIFTA",
            "BISON",
            "BISON2",
            "BISON3",
            "BJXL",
            "BLADE",
            "BLAZER",
            "BLAZER2",
            "BLAZER3",
            "BLISTA",
            "BMX",
            "BOATTRAILER",
            "BOBCATXL",
            "BODHI2",
            "BOXVILLE",
            "BOXVILLE2",
            "BOXVILLE3",
            "BUCCANEER",
            "BUFFALO",
            "BUFFALO2",
            "BULLDOZER",
            "BULLET",
            "BURRITO",
            "BURRITO2",
            "BURRITO3",
            "BURRITO4",
            "BURRITO5",
            "BUS",
            "BUZZARD",
            "BUZZARD2",
            "CABLECAR",
            "CADDY",
            "CADDY2",
            "CAMPER",
            "CARBONIZZARE",
            "CARBONRS",
            "CARGOBOB",
            "CARGOBOB2",
            "CARGOBOB3",
            "CARGOPLANE",
            "CASCO",
            "CAVALCADE",
            "CAVALCADE2",
            "CHEETAH",
            "COACH",
            "COGCABRIO",
            "COMET2",
            "COQUETTE",
            "COQUETTE2",
            "CRUISER",
            "CRUSADER",
            "CUBAN800",
            "CUTTER",
            "DAEMON",
            "DILETTANTE",
            "DILETTANTE2",
            "DINGHY",
            "DINGHY2",
            "DLOADER",
            "DOCKTRAILER",
            "DOCKTUG",
            "DOMINATOR",
            "DOUBLE",
            "DUBE",
            "DUBSTA",
            "DUBSTA2",
            "DUBSTA3",
            "DUNE",
            "DUNE2",
            "DUSTER",
            "ELEGY2",
            "EMPEROR",
            "EMPEROR2",
            "EMPEROR3",
            "ENTITYXF",
            "EXEMPLAR",
            "F620",
            "FAGGIO2",
            "FBI",
            "FBI2",
            "FELON",
            "FELON2",
            "FELTZER2",
            "FIRETRUK",
            "FIXTER",
            "FLATBED",
            "FORKLIFT",
            "FQ2",
            "FREIGHT",
            "FREIGHTCAR",
            "FREIGHTCONT1",
            "FREIGHTCONT2",
            "FREIGHTGRAIN",
            "FREIGHTTRAILER",
            "FROGGER",
            "FROGGER2",
            "FUGITIVE",
            "FUROREGT",
            "FUSILADE",
            "FUTO",
            "GAUNTLET",
            "GBURRITO",
            "GLENDALE",
            "GRAINTRAILER",
            "GRANGER",
            "GRESLEY",
            "GUARDIAN",
            "HABANERO",
            "HANDLER",
            "HAULER",
            "HEXER",
            "HOTKNIFE",
            "HUNTLEY",
            "HYDRA",
            "INFERNUS",
            "INGOT",
            "INSURGENT",
            "INSURGENT2",
            "INTRUDER",
            "ISSI2",
            "JACKAL",
            "JB700",
            "JESTER",
            "JESTER2",
            "JET",
            "JETMAX",
            "JOURNEY",
            "KHAMELION",
            "KURUMA",
            "KURUMA2",
            "LANDSTALKER",
            "LAZER",
            "LECTRO",
            "LGUARD",
            "LUXOR",
            "LUXOR2",
            "MAMMATUS",
            "MANANA",
            "MARQUIS",
            "MASSACRO",
            "MASSACRO2",
            "MAVERICK",
            "MESA",
            "MESA2",
            "MESA3",
            "METROTRAIN",
            "MILJET",
            "MINIVAN",
            "MIXER",
            "MIXER2",
            "MONROE",
            "MOWER",
            "MULE",
            "MULE2",
            "NEMESIS",
            "NINEF",
            "NINEF2",
            "ORACLE",
            "ORACLE2",
            "OSIRIS",
            "PACKER",
            "PANTO",
            "PATRIOT",
            "PBUS",
            "PCJ",
            "PENUMBRA",
            "PEYOTE",
            "PHANTOM",
            "PHOENIX",
            "PICADOR",
            "PIGALLE",
            "POLICE",
            "POLICE2",
            "POLICE3",
            "POLICE4",
            "POLICEB",
            "POLICEOLD1",
            "POLICEOLD2",
            "POLICET",
            "POLMAV",
            "PONY",
            "PONY2",
            "POUNDER",
            "PRAIRIE",
            "PRANGER",
            "PREDATOR",
            "PREMIER",
            "PRIMO",
            "PROPTRAILER",
            "RADI",
            "RAKETRAILER",
            "RANCHERXL",
            "RANCHERXL2",
            "RAPIDGT",
            "RAPIDGT2",
            "RATLOADER",
            "REBEL",
            "REBEL2",
            "REGINA",
            "RENTALBUS",
            "RHAPSODY",
            "RHINO",
            "RIOT",
            "RIPLEY",
            "ROCOTO",
            "ROMERO",
            "RUBBLE",
            "RUFFIAN",
            "RUINER",
            "RUMPO",
            "RUMPO2",
            "SABREGT",
            "SADLER",
            "SADLER2",
            "SANCHEZ",
            "SANCHEZ2",
            "SANDKING",
            "SANDKING2",
            "SAVAGE",
            "SCHAFTER2",
            "SCHWARZER",
            "SCORCHER",
            "SEASHARK",
            "SEASHARK2",
            "SEMINOLE",
            "SENTINEL",
            "SENTINEL2",
            "SERRANO",
            "SHAMAL",
            "SHERIFF",
            "SHERIFF2",
            "SKYLIFT",
            "SLAMVAN",
            "SLAMVAN2",
            "SOVEREIGN",
            "SOVEREIGN",
            "SPEEDO",
            "SPEEDO2",
            "SQUALO",
            "STANIER",
            "STINGER",
            "STINGERGT",
            "STOCKADE",
            "STOCKADE3",
            "STRATUM",
            "STRETCH",
            "STUNT",
            "SUBMERSIBLE",
            "SULTAN",
            "SUPERD",
            "SURANO",
            "SURFER",
            "SURFER2",
            "SURGE",
            "SWIFT2",
            "TACO",
            "TAILGATER",
            "TANKER",
            "TANKERCAR",
            "TAXI",
            "TECHNICAL",
            "THRUST",
            "TIPTRUCK",
            "TIPTRUCK2",
            "TITAN",
            "TORNADO",
            "TORNADO2",
            "TORNADO3",
            "TORNADO4",
            "TOURBUS",
            "TOWTRUCK",
            "TOWTRUCK2",
            "TR2",
            "TR3",
            "TR4",
            "TRACTOR",
            "TRACTOR2",
            "TRACTOR3",
            "TRAILERLOGS",
            "TRAILERS",
            "TRAILERS2",
            "TRAILERS3",
            "TRAILERSMALL",
            "TRASH",
            "TRFLAT",
            "TRIBIKE",
            "TRIBIKE2",
            "TRIBIKE3",
            "TROPIC",
            "TURISMOR",
            "TVTRAILER",
            "UTILLITRUCK",
            "UTILLITRUCK2",
            "UTILLITRUCK3",
            "VACCA",
            "VADER",
            "VALKYRIE",
            "VELUM",
            "VESTRA",
            "VIGERO",
            "VIRGO",
            "VOLTIC",
            "VOODOO2",
            "WARRENER",
            "WASHINGTON",
            "WINDSOR",
            "YOUGA",
            "ZENTORNO",
            "ZION",
            "ZION2",
            "ZTYPE"});
            this.cmbVehicles.Location = new System.Drawing.Point(20, 20);
            this.cmbVehicles.Name = "cmbVehicles";
            this.cmbVehicles.Size = new System.Drawing.Size(179, 21);
            this.cmbVehicles.TabIndex = 1;
            // 
            // btnVehicleSpawn
            // 
            this.btnVehicleSpawn.Location = new System.Drawing.Point(20, 49);
            this.btnVehicleSpawn.Name = "btnVehicleSpawn";
            this.btnVehicleSpawn.Size = new System.Drawing.Size(179, 23);
            this.btnVehicleSpawn.TabIndex = 0;
            this.btnVehicleSpawn.Text = "Spawn";
            this.btnVehicleSpawn.UseVisualStyleBackColor = true;
            this.btnVehicleSpawn.Click += new System.EventHandler(this.btnVehicleSpawn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSwapAimedPed);
            this.groupBox3.Controls.Add(this.btnRandomPed);
            this.groupBox3.Controls.Add(this.btnClone);
            this.groupBox3.Controls.Add(this.btnSkyDive);
            this.groupBox3.Controls.Add(this.chkPlayerInvisible);
            this.groupBox3.Controls.Add(this.chkNoCops);
            this.groupBox3.Controls.Add(this.chkSeeThrough);
            this.groupBox3.Controls.Add(this.chkNightVision);
            this.groupBox3.Controls.Add(this.chkRagdoll);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbModels);
            this.groupBox3.Controls.Add(this.btnSetModel);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(255, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 330);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ped/Player";
            // 
            // chkSwapAimedPed
            // 
            this.chkSwapAimedPed.AutoSize = true;
            this.chkSwapAimedPed.Location = new System.Drawing.Point(54, 199);
            this.chkSwapAimedPed.Name = "chkSwapAimedPed";
            this.chkSwapAimedPed.Size = new System.Drawing.Size(123, 17);
            this.chkSwapAimedPed.TabIndex = 18;
            this.chkSwapAimedPed.Text = "Swap To Aimed Ped";
            this.chkSwapAimedPed.UseVisualStyleBackColor = true;
            this.chkSwapAimedPed.CheckedChanged += new System.EventHandler(this.chkSwapAimedPed_CheckedChanged);
            // 
            // btnRandomPed
            // 
            this.btnRandomPed.Location = new System.Drawing.Point(20, 230);
            this.btnRandomPed.Name = "btnRandomPed";
            this.btnRandomPed.Size = new System.Drawing.Size(179, 23);
            this.btnRandomPed.TabIndex = 17;
            this.btnRandomPed.Text = "Random Ped As Body Guard";
            this.btnRandomPed.UseVisualStyleBackColor = true;
            this.btnRandomPed.Click += new System.EventHandler(this.btnRandomPed_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(20, 292);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(179, 23);
            this.btnClone.TabIndex = 16;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnSkyDive
            // 
            this.btnSkyDive.Location = new System.Drawing.Point(20, 261);
            this.btnSkyDive.Name = "btnSkyDive";
            this.btnSkyDive.Size = new System.Drawing.Size(179, 23);
            this.btnSkyDive.TabIndex = 15;
            this.btnSkyDive.Text = "Sky Dive";
            this.btnSkyDive.UseVisualStyleBackColor = true;
            this.btnSkyDive.Click += new System.EventHandler(this.btnSkyDive_Click);
            // 
            // chkPlayerInvisible
            // 
            this.chkPlayerInvisible.AutoSize = true;
            this.chkPlayerInvisible.Location = new System.Drawing.Point(54, 176);
            this.chkPlayerInvisible.Name = "chkPlayerInvisible";
            this.chkPlayerInvisible.Size = new System.Drawing.Size(64, 17);
            this.chkPlayerInvisible.TabIndex = 14;
            this.chkPlayerInvisible.Text = "Invisible";
            this.chkPlayerInvisible.UseVisualStyleBackColor = true;
            this.chkPlayerInvisible.CheckedChanged += new System.EventHandler(this.chkInvisible_CheckedChanged);
            // 
            // chkNoCops
            // 
            this.chkNoCops.AutoSize = true;
            this.chkNoCops.Location = new System.Drawing.Point(54, 157);
            this.chkNoCops.Name = "chkNoCops";
            this.chkNoCops.Size = new System.Drawing.Size(67, 17);
            this.chkNoCops.TabIndex = 13;
            this.chkNoCops.Text = "No Cops";
            this.chkNoCops.UseVisualStyleBackColor = true;
            this.chkNoCops.CheckedChanged += new System.EventHandler(this.chkNoCops_CheckedChanged);
            // 
            // chkSeeThrough
            // 
            this.chkSeeThrough.AutoSize = true;
            this.chkSeeThrough.Location = new System.Drawing.Point(54, 134);
            this.chkSeeThrough.Name = "chkSeeThrough";
            this.chkSeeThrough.Size = new System.Drawing.Size(88, 17);
            this.chkSeeThrough.TabIndex = 12;
            this.chkSeeThrough.Text = "See Through";
            this.chkSeeThrough.UseVisualStyleBackColor = true;
            this.chkSeeThrough.CheckedChanged += new System.EventHandler(this.chkSeeThrough_CheckedChanged);
            // 
            // chkNightVision
            // 
            this.chkNightVision.AutoSize = true;
            this.chkNightVision.Location = new System.Drawing.Point(54, 111);
            this.chkNightVision.Name = "chkNightVision";
            this.chkNightVision.Size = new System.Drawing.Size(82, 17);
            this.chkNightVision.TabIndex = 11;
            this.chkNightVision.Text = "Night Vision";
            this.chkNightVision.UseVisualStyleBackColor = true;
            this.chkNightVision.CheckedChanged += new System.EventHandler(this.chkNightVision_CheckedChanged);
            // 
            // chkRagdoll
            // 
            this.chkRagdoll.AutoSize = true;
            this.chkRagdoll.Location = new System.Drawing.Point(54, 88);
            this.chkRagdoll.Name = "chkRagdoll";
            this.chkRagdoll.Size = new System.Drawing.Size(112, 17);
            this.chkRagdoll.TabIndex = 10;
            this.chkRagdoll.Text = "Ragdoll/Invincible";
            this.chkRagdoll.UseVisualStyleBackColor = true;
            this.chkRagdoll.CheckedChanged += new System.EventHandler(this.chkRagdoll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 1);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // cmbModels
            // 
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Items.AddRange(new object[] {
            "a_c_boar",
            "a_c_chickenhawk",
            "a_c_chimp",
            "a_c_chop",
            "a_c_cormorant",
            "a_c_cow",
            "a_c_coyote",
            "a_c_crow",
            "a_c_deer",
            "a_c_fish",
            "a_c_hen",
            "a_c_husky",
            "a_c_mtlion",
            "a_c_pig",
            "a_c_pigeon",
            "a_c_rat",
            "a_c_retriever",
            "a_c_rhesus",
            "a_c_rottweiler",
            "a_c_seagull",
            "a_c_sharktiger",
            "a_c_shepherda_m_m_acult_01",
            "a_m_m_afriamer_01",
            "a_m_m_beach_01",
            "a_m_m_beach_02",
            "a_m_m_bevhills_01",
            "a_m_m_bevhills_02",
            "a_m_m_business_01",
            "a_m_m_eastsa_01",
            "a_m_m_eastsa_02",
            "a_m_m_farmer_01",
            "a_m_m_fatlatin_01",
            "a_m_m_genfat_01",
            "a_m_m_genfat_02",
            "a_m_m_golfer_01",
            "a_m_m_hasjew_01",
            "a_m_m_hillbilly_01",
            "a_m_m_hillbilly_02",
            "a_m_m_indian_01",
            "a_m_m_ktown_01",
            "a_m_m_malibu_01",
            "a_m_m_mexcntry_01",
            "a_m_m_mexlabor_01",
            "a_m_m_og_boss_01",
            "a_m_m_paparazzi_01",
            "a_m_m_polynesian_01",
            "a_m_m_prolhost_01",
            "a_m_m_rurmeth_01",
            "a_m_m_salton_01",
            "a_m_m_salton_02",
            "a_m_m_salton_03",
            "a_m_m_salton_04",
            "a_m_m_skater_01",
            "a_m_m_skidrow_01",
            "a_m_m_socenlat_01",
            "a_m_m_soucent_01",
            "a_m_m_soucent_02",
            "a_m_m_soucent_03",
            "a_m_m_soucent_04",
            "a_m_m_stlat_02",
            "a_m_m_tennis_01",
            "a_m_m_tourist_01",
            "a_m_m_trampbeac_01",
            "a_m_m_tramp_01",
            "a_m_m_tranvest_01",
            "a_m_m_tranvest_02",
            "a_m_o_acult_01",
            "a_m_o_acult_02",
            "a_m_o_beach_01",
            "a_m_o_genstreet_01",
            "a_m_o_ktown_01",
            "a_m_o_salton_01",
            "a_m_o_soucent_01",
            "a_m_o_soucent_02",
            "a_m_o_soucent_03",
            "a_m_o_tramp_01",
            "a_m_y_acult_01",
            "a_m_y_acult_02",
            "a_m_y_beachvesp_01",
            "a_m_y_beachvesp_02",
            "a_m_y_beach_01",
            "a_m_y_beach_02",
            "a_m_y_beach_03",
            "a_m_y_bevhills_01",
            "a_m_y_bevhills_02",
            "a_m_y_breakdance_01",
            "a_m_y_busicas_01",
            "a_m_y_business_01",
            "a_m_y_business_02",
            "a_m_y_business_03",
            "a_m_y_cyclist_01",
            "a_m_y_dhill_01",
            "a_m_y_downtown_01",
            "a_m_y_eastsa_01",
            "a_m_y_eastsa_02",
            "a_m_y_epsilon_01",
            "a_m_y_epsilon_02",
            "a_m_y_gay_01",
            "a_m_y_gay_02",
            "a_m_y_genstreet_01",
            "a_m_y_genstreet_02",
            "a_m_y_golfer_01",
            "a_m_y_hasjew_01",
            "a_m_y_hiker_01",
            "a_m_y_hippy_01",
            "a_m_y_hipster_01",
            "a_m_y_hipster_02",
            "a_m_y_hipster_03",
            "a_m_y_indian_01",
            "a_m_y_jetski_01",
            "a_m_y_juggalo_01",
            "a_m_y_ktown_01",
            "a_m_y_ktown_02",
            "a_m_y_latino_01",
            "a_m_y_methhead_01",
            "a_m_y_mexthug_01",
            "a_m_y_motox_01",
            "a_m_y_motox_02",
            "a_m_y_musclbeac_01",
            "a_m_y_musclbeac_02",
            "a_m_y_polynesian_01",
            "a_m_y_roadcyc_01",
            "a_m_y_runner_01",
            "a_m_y_runner_02",
            "a_m_y_salton_01",
            "a_m_y_skater_01",
            "a_m_y_skater_02",
            "a_m_y_soucent_01",
            "a_m_y_soucent_02",
            "a_m_y_soucent_03",
            "a_m_y_soucent_04",
            "a_m_y_stbla_01",
            "a_m_y_stbla_02",
            "a_m_y_stlat_01",
            "a_m_y_stwhi_01",
            "a_m_y_stwhi_02",
            "a_m_y_sunbathe_01",
            "a_m_y_surfer_01",
            "a_m_y_vindouche_01",
            "a_m_y_vinewood_01",
            "a_m_y_vinewood_02",
            "a_m_y_vinewood_03",
            "a_m_y_vinewood_04",
            "a_m_y_yoga_01",
            "comp_peds_helmets_moped",
            "comp_peds_helmets_motox",
            "comp_peds_helmets_shorty",
            "comp_peds_helmets_sports",
            "comp_peds_marine",
            "csb_abigail",
            "csb_anita",
            "csb_anton",
            "csb_ballasog",
            "csb_bride",
            "csb_burgerdrug",
            "csb_car3guy1",
            "csb_car3guy2",
            "csb_chef",
            "csb_chin_goon",
            "csb_cletus",
            "csb_cop",
            "csb_customer",
            "csb_denise_friend",
            "csb_fos_rep",
            "csb_g",
            "csb_groom",
            "csb_grove_str_dlr",
            "csb_hao",
            "csb_hugh",
            "csb_imran",
            "csb_janitor",
            "csb_maude",
            "csb_mweather",
            "csb_ortega",
            "csb_oscar",
            "csb_porndudes",
            "csb_porndudes_p",
            "csb_prologuedriver",
            "csb_prolsec",
            "csb_ramp_gang",
            "csb_ramp_hic",
            "csb_ramp_hipster",
            "csb_ramp_marine",
            "csb_ramp_mex",
            "csb_reporter",
            "csb_roccopelosi",
            "csb_screen_writer",
            "csb_stripper_01",
            "csb_stripper_02",
            "csb_tonya",
            "csb_trafficwarden",
            "cs_amandatownley",
            "cs_andreas",
            "cs_ashley",
            "cs_bankman",
            "cs_barry",
            "cs_barry_p",
            "cs_beverly",
            "cs_beverly_p",
            "cs_brad",
            "cs_bradcadaver",
            "cs_carbuyer",
            "cs_casey",
            "cs_chengsr",
            "cs_chrisformage",
            "cs_clay",
            "cs_dale",
            "cs_davenorton",
            "cs_debra",
            "cs_denise",
            "cs_devin",
            "cs_dom",
            "cs_dreyfuss",
            "cs_drfriedlander",
            "cs_fabien",
            "cs_fbisuit_01",
            "cs_floyd",
            "cs_guadalope",
            "cs_gurk",
            "cs_hunter",
            "cs_janet",
            "cs_jewelass",
            "cs_jimmyboston",
            "cs_jimmydisanto",
            "cs_joeminuteman",
            "cs_johnnyklebitz",
            "cs_josef",
            "cs_josh",
            "cs_lamardavis",
            "cs_lazlow",
            "cs_lestercrest",
            "cs_lifeinvad_01",
            "cs_magenta",
            "cs_manuel",
            "cs_marnie",
            "cs_martinmadrazo",
            "cs_maryann",
            "cs_michelle",
            "cs_milton",
            "cs_molly",
            "cs_movpremf_01",
            "cs_movpremmale",
            "cs_mrk",
            "cs_mrsphillips",
            "cs_mrs_thornhill",
            "cs_natalia",
            "cs_nervousron",
            "cs_nigel",
            "cs_old_man1a",
            "cs_old_man2",
            "cs_omega",
            "cs_orleans",
            "cs_paper",
            "cs_paper_p",
            "cs_patricia",
            "cs_priest",
            "cs_prolsec_02",
            "cs_russiandrunk",
            "cs_siemonyetarian",
            "cs_solomon",
            "cs_stevehains",
            "cs_stretch",
            "cs_tanisha",
            "cs_taocheng",
            "cs_taostranslator",
            "cs_tenniscoach",
            "cs_terry",
            "cs_tom",
            "cs_tomepsilon",
            "cs_tracydisanto",
            "cs_wade",
            "cs_zimbor",
            "g_m_m_armboss_01",
            "g_m_m_armgoon_01",
            "g_m_m_armlieut_01",
            "g_m_m_chemwork_01",
            "g_m_m_chemwork_01_p",
            "g_m_m_chiboss_01",
            "g_m_m_chiboss_01_p",
            "g_m_m_chicold_01",
            "g_m_m_chicold_01_p",
            "g_m_m_chigoon_01",
            "g_m_m_chigoon_01_p",
            "g_m_m_chigoon_02",
            "g_m_m_korboss_01",
            "g_m_m_mexboss_01",
            "g_m_m_mexboss_02",
            "g_m_y_armgoon_02",
            "g_m_y_azteca_01",
            "g_m_y_ballaeast_01",
            "g_m_y_ballaorig_01",
            "g_m_y_ballasout_01",
            "g_m_y_famca_01",
            "g_m_y_famdnf_01",
            "g_m_y_famfor_01",
            "g_m_y_korean_01",
            "g_m_y_korean_02",
            "g_m_y_korlieut_01",
            "g_m_y_lost_01",
            "g_m_y_lost_02",
            "g_m_y_lost_03",
            "g_m_y_mexgang_01",
            "g_m_y_mexgoon_01",
            "g_m_y_mexgoon_02",
            "g_m_y_mexgoon_03",
            "g_m_y_mexgoon_03_p",
            "g_m_y_pologoon_01",
            "g_m_y_pologoon_01_p",
            "g_m_y_pologoon_02",
            "g_m_y_pologoon_02_p",
            "g_m_y_salvaboss_01",
            "g_m_y_salvagoon_01",
            "g_m_y_salvagoon_02",
            "g_m_y_salvagoon_03",
            "g_m_y_salvagoon_03_p",
            "g_m_y_strpunk_01",
            "g_m_y_strpunk_02",
            "hc_driver",
            "hc_gunman",
            "hc_hacker",
            "ig_abigail",
            "ig_amandatownley",
            "ig_andreas",
            "ig_ashley",
            "ig_ballasog",
            "ig_bankman",
            "ig_barry",
            "ig_barry_p",
            "ig_bestmen",
            "ig_beverly",
            "ig_beverly_p",
            "ig_brad",
            "ig_bride",
            "ig_car3guy1",
            "ig_car3guy2",
            "ig_casey",
            "ig_chef",
            "ig_chengsr",
            "ig_chrisformage",
            "ig_clay",
            "ig_claypain",
            "ig_cletus",
            "ig_dale",
            "ig_davenorton",
            "ig_denise",
            "ig_devin",
            "ig_dom",
            "ig_dreyfuss",
            "ig_drfriedlander",
            "ig_fabien",
            "ig_fbisuit_01",
            "ig_floyd",
            "ig_groom",
            "ig_hao",
            "ig_hunter",
            "ig_janet",
            "ig_jay_norris",
            "ig_jewelass",
            "ig_jimmyboston",
            "ig_jimmydisanto",
            "ig_joeminuteman",
            "ig_johnnyklebitz",
            "ig_josef",
            "ig_josh",
            "ig_kerrymcintosh",
            "ig_lamardavis",
            "ig_lazlow",
            "ig_lestercrest",
            "ig_lifeinvad_01",
            "ig_lifeinvad_02",
            "ig_magenta",
            "ig_manuel",
            "ig_marnie",
            "ig_maryann",
            "ig_maude",
            "ig_michelle",
            "ig_milton",
            "ig_molly",
            "ig_mrk",
            "ig_mrsphillips",
            "ig_mrs_thornhill",
            "ig_natalia",
            "ig_nervousron",
            "ig_nigel",
            "ig_old_man1a",
            "ig_old_man2",
            "ig_omega",
            "ig_oneil",
            "ig_orleans",
            "ig_ortega",
            "ig_paper",
            "ig_patricia",
            "ig_priest",
            "ig_prolsec_02",
            "ig_ramp_gang",
            "ig_ramp_hic",
            "ig_ramp_hipster",
            "ig_ramp_mex",
            "ig_roccopelosi",
            "ig_russiandrunk",
            "ig_screen_writer",
            "ig_siemonyetarian",
            "ig_solomon",
            "ig_stevehains",
            "ig_stretch",
            "ig_talina",
            "ig_tanisha",
            "ig_taocheng",
            "ig_taostranslator",
            "ig_taostranslator_p",
            "ig_tenniscoach",
            "ig_terry",
            "ig_tomepsilon",
            "ig_tonya",
            "ig_tracydisanto",
            "ig_trafficwarden",
            "ig_tylerdix",
            "ig_wade",
            "ig_zimbor",
            "mp_g_m_pros_01",
            "mp_headtargets",
            "mp_m_claude_01",
            "mp_m_exarmy_01",
            "mp_m_famdd_01",
            "mp_m_fibsec_01",
            "mp_m_freemode_01",
            "mp_m_marston_01",
            "mp_m_niko_01",
            "mp_m_shopkeep_01",
            "mp_s_m_armoured_01",
            "player_one",
            "player_two",
            "player_zero",
            "slod_human",
            "slod_large_quadped",
            "slod_small_quadped",
            "strm_peds_mpshare",
            "strm_peds_mptattrtss_m_m_ammucountry",
            "s_m_m_armoured_01",
            "s_m_m_armoured_02",
            "s_m_m_autoshop_01",
            "s_m_m_autoshop_02",
            "s_m_m_bouncer_01",
            "s_m_m_chemsec_01",
            "s_m_m_ciasec_01",
            "s_m_m_cntrybar_01",
            "s_m_m_dockwork_01",
            "s_m_m_doctor_01",
            "s_m_m_fiboffice_01",
            "s_m_m_fiboffice_02",
            "s_m_m_gaffer_01",
            "s_m_m_gardener_01",
            "s_m_m_gentransport",
            "s_m_m_hairdress_01",
            "s_m_m_highsec_01",
            "s_m_m_highsec_02",
            "s_m_m_janitor",
            "s_m_m_lathandy_01",
            "s_m_m_lifeinvad_01",
            "s_m_m_linecook",
            "s_m_m_lsmetro_01",
            "s_m_m_mariachi_01",
            "s_m_m_marine_01",
            "s_m_m_marine_02",
            "s_m_m_migrant_01",
            "s_m_m_movalien_01",
            "s_m_m_movprem_01",
            "s_m_m_movspace_01",
            "s_m_m_paramedic_01",
            "s_m_m_pilot_01",
            "s_m_m_pilot_02",
            "s_m_m_postal_01",
            "s_m_m_postal_02",
            "s_m_m_prisguard_01",
            "s_m_m_scientist_01",
            "s_m_m_security_01",
            "s_m_m_snowcop_01",
            "s_m_m_strperf_01",
            "s_m_m_strpreach_01",
            "s_m_m_strvend_01",
            "s_m_m_trucker_01",
            "s_m_m_ups_01",
            "s_m_m_ups_02",
            "s_m_o_busker_01",
            "s_m_y_airworker",
            "s_m_y_ammucity_01",
            "s_m_y_armymech_01",
            "s_m_y_autopsy_01",
            "s_m_y_barman_01",
            "s_m_y_baywatch_01",
            "s_m_y_blackops_01",
            "s_m_y_blackops_02",
            "s_m_y_busboy_01",
            "s_m_y_chef_01",
            "s_m_y_clown_01",
            "s_m_y_construct_01",
            "s_m_y_construct_02",
            "s_m_y_cop_01",
            "s_m_y_dealer_01",
            "s_m_y_devinsec_01",
            "s_m_y_dockwork_01",
            "s_m_y_doorman_01",
            "s_m_y_dwservice_01",
            "s_m_y_dwservice_02",
            "s_m_y_factory_01",
            "s_m_y_fireman_01",
            "s_m_y_garbage",
            "s_m_y_grip_01",
            "s_m_y_hwaycop_01",
            "s_m_y_marine_01",
            "s_m_y_marine_02",
            "s_m_y_marine_03",
            "s_m_y_mime",
            "s_m_y_pestcont_01",
            "s_m_y_pilot_01",
            "s_m_y_prismuscl_01",
            "s_m_y_prisoner_01",
            "s_m_y_ranger_01",
            "s_m_y_robber_01",
            "s_m_y_sheriff_01",
            "s_m_y_shop_mask",
            "s_m_y_strvend_01",
            "s_m_y_swat_01",
            "s_m_y_uscg_01",
            "s_m_y_valet_01",
            "s_m_y_waiter_01",
            "s_m_y_winclean_01",
            "s_m_y_xmech_01",
            "s_m_y_xmech_02u_m_m_aldinapoli",
            "u_m_m_bankman",
            "u_m_m_bikehire_01",
            "u_m_m_fibarchitect",
            "u_m_m_filmdirector",
            "u_m_m_glenstank_01",
            "u_m_m_griff_01",
            "u_m_m_jesus_01",
            "u_m_m_jewelsec_01",
            "u_m_m_jewelthief",
            "u_m_m_markfost",
            "u_m_m_partytarget",
            "u_m_m_prolsec_01",
            "u_m_m_promourn_01",
            "u_m_m_rivalpap",
            "u_m_m_spyactor",
            "u_m_m_willyfist",
            "u_m_o_finguru_01",
            "u_m_o_taphillbilly",
            "u_m_o_tramp_01",
            "u_m_y_abner",
            "u_m_y_antonb",
            "u_m_y_babyd",
            "u_m_y_baygor",
            "u_m_y_burgerdrug_01",
            "u_m_y_chip",
            "u_m_y_cyclist_01",
            "u_m_y_fibmugger_01",
            "u_m_y_guido_01",
            "u_m_y_gunvend_01",
            "u_m_y_hippie_01",
            "u_m_y_imporage",
            "u_m_y_justin",
            "u_m_y_mani",
            "u_m_y_militarybum",
            "u_m_y_paparazzi",
            "u_m_y_party_01",
            "u_m_y_pogo_01",
            "u_m_y_prisoner_01",
            "u_m_y_proldriver_01",
            "u_m_y_rsranger_01",
            "u_m_y_sbike",
            "u_m_y_staggrm_01",
            "u_m_y_tattoo_01",
            "u_m_y_zombie_01"});
            this.cmbModels.Location = new System.Drawing.Point(20, 20);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(179, 21);
            this.cmbModels.TabIndex = 1;
            // 
            // btnSetModel
            // 
            this.btnSetModel.Location = new System.Drawing.Point(20, 49);
            this.btnSetModel.Name = "btnSetModel";
            this.btnSetModel.Size = new System.Drawing.Size(179, 23);
            this.btnSetModel.TabIndex = 0;
            this.btnSetModel.Text = "Set Model";
            this.btnSetModel.UseVisualStyleBackColor = true;
            this.btnSetModel.Click += new System.EventHandler(this.btnSetModel_Click);
            // 
            // chkGravity
            // 
            this.chkGravity.AutoSize = true;
            this.chkGravity.Location = new System.Drawing.Point(73, 90);
            this.chkGravity.Name = "chkGravity";
            this.chkGravity.Size = new System.Drawing.Size(76, 17);
            this.chkGravity.TabIndex = 17;
            this.chkGravity.Text = "No Gravity";
            this.chkGravity.UseVisualStyleBackColor = true;
            this.chkGravity.CheckedChanged += new System.EventHandler(this.chkGravity_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblLoction);
            this.groupBox4.Controls.Add(this.chkLocation);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnTeleportWayPoint);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(499, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 151);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coords";
            // 
            // lblLoction
            // 
            this.lblLoction.AutoSize = true;
            this.lblLoction.Location = new System.Drawing.Point(9, 46);
            this.lblLoction.Name = "lblLoction";
            this.lblLoction.Size = new System.Drawing.Size(70, 13);
            this.lblLoction.TabIndex = 17;
            this.lblLoction.Text = "X: 0 Y: 0 Z: 0";
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Location = new System.Drawing.Point(57, 22);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(132, 17);
            this.chkLocation.TabIndex = 10;
            this.chkLocation.Text = "Auto Refresh Location";
            this.chkLocation.UseVisualStyleBackColor = true;
            this.chkLocation.CheckedChanged += new System.EventHandler(this.chkLocation_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 1);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // btnTeleportWayPoint
            // 
            this.btnTeleportWayPoint.Location = new System.Drawing.Point(20, 88);
            this.btnTeleportWayPoint.Name = "btnTeleportWayPoint";
            this.btnTeleportWayPoint.Size = new System.Drawing.Size(179, 23);
            this.btnTeleportWayPoint.TabIndex = 0;
            this.btnTeleportWayPoint.Text = "Teleport To Waypoint";
            this.btnTeleportWayPoint.UseVisualStyleBackColor = true;
            this.btnTeleportWayPoint.Click += new System.EventHandler(this.btnTeleportWayPoint_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btnSetWeather);
            this.groupBox5.Controls.Add(this.btnUnlockTrophies);
            this.groupBox5.Controls.Add(this.cmbWeathers);
            this.groupBox5.Controls.Add(this.chkGravity);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(499, 347);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 154);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MISC";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 1);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // btnSetWeather
            // 
            this.btnSetWeather.Location = new System.Drawing.Point(20, 45);
            this.btnSetWeather.Name = "btnSetWeather";
            this.btnSetWeather.Size = new System.Drawing.Size(179, 23);
            this.btnSetWeather.TabIndex = 20;
            this.btnSetWeather.Text = "Set Weather";
            this.btnSetWeather.UseVisualStyleBackColor = true;
            this.btnSetWeather.Click += new System.EventHandler(this.btnSetWeather_Click);
            // 
            // btnUnlockTrophies
            // 
            this.btnUnlockTrophies.Location = new System.Drawing.Point(20, 116);
            this.btnUnlockTrophies.Name = "btnUnlockTrophies";
            this.btnUnlockTrophies.Size = new System.Drawing.Size(179, 23);
            this.btnUnlockTrophies.TabIndex = 18;
            this.btnUnlockTrophies.Text = "Unlock All Trophies";
            this.btnUnlockTrophies.UseVisualStyleBackColor = true;
            this.btnUnlockTrophies.Click += new System.EventHandler(this.btnUnlockTrophies_Click);
            // 
            // cmbWeathers
            // 
            this.cmbWeathers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeathers.FormattingEnabled = true;
            this.cmbWeathers.Items.AddRange(new object[] {
            "Blizzard",
            "Clear",
            "Clearing",
            "Clouds",
            "ExtraSunny",
            "Foggy",
            "Neutral",
            "Overcast",
            "Rain",
            "Thunder",
            "Smog",
            "Snow",
            "SnowLight",
            "Xmas"});
            this.cmbWeathers.Location = new System.Drawing.Point(20, 18);
            this.cmbWeathers.Name = "cmbWeathers";
            this.cmbWeathers.Size = new System.Drawing.Size(179, 21);
            this.cmbWeathers.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGiveWeapon);
            this.groupBox6.Controls.Add(this.cmbWeapons);
            this.groupBox6.Controls.Add(this.chkInfiniteAmmo);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(255, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(226, 132);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Weapon";
            // 
            // btnGiveWeapon
            // 
            this.btnGiveWeapon.Location = new System.Drawing.Point(19, 47);
            this.btnGiveWeapon.Name = "btnGiveWeapon";
            this.btnGiveWeapon.Size = new System.Drawing.Size(188, 23);
            this.btnGiveWeapon.TabIndex = 19;
            this.btnGiveWeapon.Text = "Give Weapon";
            this.btnGiveWeapon.UseVisualStyleBackColor = true;
            this.btnGiveWeapon.Click += new System.EventHandler(this.btnGiveWeapon_Click);
            // 
            // cmbWeapons
            // 
            this.cmbWeapons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeapons.FormattingEnabled = true;
            this.cmbWeapons.Items.AddRange(new object[] {
            "ADVANCEDRIFLE",
            "ANIMAL",
            "APPISTOL",
            "ASSAULTRIFLE",
            "ASSAULTSHOTGUN",
            "ASSAULTSMG",
            "BALL",
            "BOTTLE",
            "BRIEFCASE",
            "BRIEFCASE_02",
            "BULLPUPRIFLE",
            "BULLPUPSHOTGUN",
            "BZGAS",
            "CARBINERIFLE",
            "COMBATMG",
            "COMBATPDW",
            "COMBATPISTOL",
            "COUGAR",
            "CROWBAR",
            "DAGGER",
            "DIGISCANNER",
            "FIREEXTINGUISHER",
            "FIREWORK",
            "FLARE",
            "FLAREGUN",
            "GOLFCLUB",
            "GRENADE",
            "GRENADELAUNCHER",
            "GRENADELAUNCHER_SMOKE",
            "GUSENBERG",
            "HAMMER",
            "HEAVYPISTOL",
            "HEAVYSHOTGUN",
            "HEAVYSNIPER",
            "HOMINGLAUNCHER",
            "KNIFE",
            "MARKSMANRIFLE",
            "MICROSMG",
            "MINIGUN",
            "MOLOTOV",
            "MUSKET",
            "NIGHTSTICK",
            "PETROLCAN",
            "PISTOL",
            "PISTOL50",
            "PROXMINE",
            "PUMPSHOTGUN",
            "SAWNOFFSHOTGUN",
            "SMOKEGRENADE",
            "SNIPERRIFLE",
            "SNOWBALL",
            "SNSPISTOL",
            "SPECIALCARBINE",
            "STICKYBOMB",
            "STINGER",
            "STUNGUN",
            "UNARMED",
            "VINTAGEPISTOL"});
            this.cmbWeapons.Location = new System.Drawing.Point(19, 20);
            this.cmbWeapons.Name = "cmbWeapons";
            this.cmbWeapons.Size = new System.Drawing.Size(188, 21);
            this.cmbWeapons.TabIndex = 18;
            // 
            // chkInfiniteAmmo
            // 
            this.chkInfiniteAmmo.AutoSize = true;
            this.chkInfiniteAmmo.Location = new System.Drawing.Point(66, 87);
            this.chkInfiniteAmmo.Name = "chkInfiniteAmmo";
            this.chkInfiniteAmmo.Size = new System.Drawing.Size(89, 17);
            this.chkInfiniteAmmo.TabIndex = 17;
            this.chkInfiniteAmmo.Text = "Infinite Ammo";
            this.chkInfiniteAmmo.UseVisualStyleBackColor = true;
            this.chkInfiniteAmmo.CheckedChanged += new System.EventHandler(this.chkInfiniteAmmo_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtTimePicker);
            this.groupBox7.Controls.Add(this.chkPauseTime);
            this.groupBox7.Controls.Add(this.btnSetTime);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(499, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(226, 132);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Time";
            // 
            // dtTimePicker
            // 
            this.dtTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimePicker.Location = new System.Drawing.Point(12, 20);
            this.dtTimePicker.Name = "dtTimePicker";
            this.dtTimePicker.ShowUpDown = true;
            this.dtTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dtTimePicker.TabIndex = 22;
            // 
            // chkPauseTime
            // 
            this.chkPauseTime.AutoSize = true;
            this.chkPauseTime.Location = new System.Drawing.Point(73, 87);
            this.chkPauseTime.Name = "chkPauseTime";
            this.chkPauseTime.Size = new System.Drawing.Size(82, 17);
            this.chkPauseTime.TabIndex = 21;
            this.chkPauseTime.Text = "Pause Time";
            this.chkPauseTime.UseVisualStyleBackColor = true;
            this.chkPauseTime.CheckedChanged += new System.EventHandler(this.chkPauseTime_CheckedChanged);
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(12, 43);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(200, 23);
            this.btnSetTime.TabIndex = 20;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 510);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTA Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVehicleSpawn;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnBoost;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Button btnNonDamage;
        private System.Windows.Forms.Button btnExplode;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModels;
        private System.Windows.Forms.Button btnSetModel;
        private System.Windows.Forms.CheckBox chkRagdoll;
        private System.Windows.Forms.CheckBox chkNightVision;
        private System.Windows.Forms.CheckBox chkSeeThrough;
        private System.Windows.Forms.CheckBox chkNoCops;
        private System.Windows.Forms.CheckBox chkPlayerInvisible;
        private System.Windows.Forms.CheckBox chkVecInvisble;
        private System.Windows.Forms.Button btnSkyDive;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckBox chkGravity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLoction;
        private volatile System.Windows.Forms.CheckBox chkLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTeleportWayPoint;
        private System.Windows.Forms.Button btnRandomPed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkInfiniteAmmo;
        private System.Windows.Forms.ComboBox cmbWeapons;
        private System.Windows.Forms.Button btnGiveWeapon;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.CheckBox chkPauseTime;
        private System.Windows.Forms.DateTimePicker dtTimePicker;
        private System.Windows.Forms.Button btnUnlockTrophies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetWeather;
        private System.Windows.Forms.ComboBox cmbWeathers;
        private volatile System.Windows.Forms.CheckBox chkSwapAimedPed;
    }
}

