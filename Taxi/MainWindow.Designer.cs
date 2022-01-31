namespace Taxi
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnHome = new MaterialSkin.Controls.MaterialButton();
            this.btnCompanyInfo = new MaterialSkin.Controls.MaterialButton();
            this.btnCarInfo = new MaterialSkin.Controls.MaterialButton();
            this.btnNewTrip = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveTrip = new MaterialSkin.Controls.MaterialButton();
            this.tabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carTab = new System.Windows.Forms.TabPage();
            this.panelCarTab = new System.Windows.Forms.Panel();
            this.lblCarYear = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCarKmToLitre = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblTaxiTotalIncome = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTaxiTotalExpenses = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTaxiTotalKM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.panelCompanyTab = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pbCompanyImage = new System.Windows.Forms.PictureBox();
            this.panelButtons.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.dataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.carTab.SuspendLayout();
            this.panelCarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.companyTab.SuspendLayout();
            this.panelCompanyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Controls.Add(this.btnCompanyInfo);
            this.panelButtons.Controls.Add(this.btnCarInfo);
            this.panelButtons.Controls.Add(this.btnNewTrip);
            this.panelButtons.Controls.Add(this.btnRemoveTrip);
            this.panelButtons.Location = new System.Drawing.Point(0, 64);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1073, 52);
            this.panelButtons.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHome.Depth = 0;
            this.btnHome.HighEmphasis = true;
            this.btnHome.Icon = null;
            this.btnHome.Location = new System.Drawing.Point(118, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHome.Name = "btnHome";
            this.btnHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHome.Size = new System.Drawing.Size(82, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Начало";
            this.btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHome.UseAccentColor = true;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCompanyInfo
            // 
            this.btnCompanyInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompanyInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompanyInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompanyInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCompanyInfo.Depth = 0;
            this.btnCompanyInfo.HighEmphasis = true;
            this.btnCompanyInfo.Icon = null;
            this.btnCompanyInfo.Location = new System.Drawing.Point(783, 8);
            this.btnCompanyInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompanyInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompanyInfo.Name = "btnCompanyInfo";
            this.btnCompanyInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompanyInfo.Size = new System.Drawing.Size(172, 36);
            this.btnCompanyInfo.TabIndex = 4;
            this.btnCompanyInfo.Text = "Данни за Фирмата";
            this.btnCompanyInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompanyInfo.UseAccentColor = true;
            this.btnCompanyInfo.UseVisualStyleBackColor = true;
            this.btnCompanyInfo.Click += new System.EventHandler(this.btnCompanyInfo_Click);
            // 
            // btnCarInfo
            // 
            this.btnCarInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCarInfo.Depth = 0;
            this.btnCarInfo.HighEmphasis = true;
            this.btnCarInfo.Icon = null;
            this.btnCarInfo.Location = new System.Drawing.Point(574, 8);
            this.btnCarInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCarInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCarInfo.Name = "btnCarInfo";
            this.btnCarInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCarInfo.Size = new System.Drawing.Size(201, 36);
            this.btnCarInfo.TabIndex = 3;
            this.btnCarInfo.Text = "Данни за Автомобила";
            this.btnCarInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCarInfo.UseAccentColor = true;
            this.btnCarInfo.UseVisualStyleBackColor = true;
            this.btnCarInfo.Click += new System.EventHandler(this.btnCarInfo_Click);
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewTrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTrip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewTrip.Depth = 0;
            this.btnNewTrip.HighEmphasis = true;
            this.btnNewTrip.Icon = null;
            this.btnNewTrip.Location = new System.Drawing.Point(208, 8);
            this.btnNewTrip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewTrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewTrip.Size = new System.Drawing.Size(143, 36);
            this.btnNewTrip.TabIndex = 1;
            this.btnNewTrip.Text = "Ново Пътуване";
            this.btnNewTrip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewTrip.UseAccentColor = true;
            this.btnNewTrip.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTrip
            // 
            this.btnRemoveTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveTrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTrip.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveTrip.Depth = 0;
            this.btnRemoveTrip.HighEmphasis = true;
            this.btnRemoveTrip.Icon = null;
            this.btnRemoveTrip.Location = new System.Drawing.Point(359, 8);
            this.btnRemoveTrip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveTrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveTrip.Name = "btnRemoveTrip";
            this.btnRemoveTrip.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveTrip.Size = new System.Drawing.Size(184, 36);
            this.btnRemoveTrip.TabIndex = 2;
            this.btnRemoveTrip.Text = "Премахни Пътуване";
            this.btnRemoveTrip.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveTrip.UseAccentColor = true;
            this.btnRemoveTrip.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.dataTab);
            this.tabControlMain.Controls.Add(this.carTab);
            this.tabControlMain.Controls.Add(this.companyTab);
            this.tabControlMain.Depth = 0;
            this.tabControlMain.Location = new System.Drawing.Point(0, 117);
            this.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1073, 527);
            this.tabControlMain.TabIndex = 3;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.dataGridView1);
            this.dataTab.Location = new System.Drawing.Point(4, 24);
            this.dataTab.Name = "dataTab";
            this.dataTab.Size = new System.Drawing.Size(1065, 499);
            this.dataTab.TabIndex = 0;
            this.dataTab.Text = "dataTab";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // carTab
            // 
            this.carTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.carTab.Controls.Add(this.panelCarTab);
            this.carTab.Location = new System.Drawing.Point(4, 24);
            this.carTab.Name = "carTab";
            this.carTab.Size = new System.Drawing.Size(1065, 499);
            this.carTab.TabIndex = 1;
            this.carTab.Text = "carTab";
            // 
            // panelCarTab
            // 
            this.panelCarTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCarTab.BackColor = System.Drawing.Color.White;
            this.panelCarTab.Controls.Add(this.lblCarYear);
            this.panelCarTab.Controls.Add(this.label27);
            this.panelCarTab.Controls.Add(this.pictureBox3);
            this.panelCarTab.Controls.Add(this.pictureBox2);
            this.panelCarTab.Controls.Add(this.pictureBox1);
            this.panelCarTab.Controls.Add(this.lblCarKmToLitre);
            this.panelCarTab.Controls.Add(this.lblCarMake);
            this.panelCarTab.Controls.Add(this.lblCarModel);
            this.panelCarTab.Controls.Add(this.lblTaxiTotalIncome);
            this.panelCarTab.Controls.Add(this.label10);
            this.panelCarTab.Controls.Add(this.lblTaxiTotalExpenses);
            this.panelCarTab.Controls.Add(this.label8);
            this.panelCarTab.Controls.Add(this.lblTaxiTotalKM);
            this.panelCarTab.Controls.Add(this.label5);
            this.panelCarTab.Controls.Add(this.label4);
            this.panelCarTab.Controls.Add(this.label3);
            this.panelCarTab.Controls.Add(this.label2);
            this.panelCarTab.Controls.Add(this.lblCompanyName);
            this.panelCarTab.Controls.Add(this.pbCarImage);
            this.panelCarTab.Location = new System.Drawing.Point(161, 49);
            this.panelCarTab.Name = "panelCarTab";
            this.panelCarTab.Size = new System.Drawing.Size(743, 400);
            this.panelCarTab.TabIndex = 16;
            // 
            // lblCarYear
            // 
            this.lblCarYear.AutoSize = true;
            this.lblCarYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarYear.Location = new System.Drawing.Point(264, 130);
            this.lblCarYear.Name = "lblCarYear";
            this.lblCarYear.Size = new System.Drawing.Size(79, 18);
            this.lblCarYear.TabIndex = 49;
            this.lblCarYear.Text = "{car_year}";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(195, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 18);
            this.label27.TabIndex = 48;
            this.label27.Text = "Година:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Taxi.Properties.Resources.taxi_subtract_48;
            this.pictureBox3.Location = new System.Drawing.Point(50, 314);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Taxi.Properties.Resources.taxi_addition_48;
            this.pictureBox2.Location = new System.Drawing.Point(50, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taxi.Properties.Resources.taxi_counter_48;
            this.pictureBox1.Location = new System.Drawing.Point(50, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lblCarKmToLitre
            // 
            this.lblCarKmToLitre.AutoSize = true;
            this.lblCarKmToLitre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarKmToLitre.Location = new System.Drawing.Point(264, 156);
            this.lblCarKmToLitre.Name = "lblCarKmToLitre";
            this.lblCarKmToLitre.Size = new System.Drawing.Size(150, 18);
            this.lblCarKmToLitre.TabIndex = 44;
            this.lblCarKmToLitre.Text = "{car_km_to_litre:N0}";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarMake.Location = new System.Drawing.Point(264, 104);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(88, 18);
            this.lblCarMake.TabIndex = 43;
            this.lblCarMake.Text = "{car_make}";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarModel.Location = new System.Drawing.Point(264, 78);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(92, 18);
            this.lblCarModel.TabIndex = 42;
            this.lblCarModel.Text = "{car_model}";
            // 
            // lblTaxiTotalIncome
            // 
            this.lblTaxiTotalIncome.AutoSize = true;
            this.lblTaxiTotalIncome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaxiTotalIncome.Location = new System.Drawing.Point(193, 263);
            this.lblTaxiTotalIncome.Name = "lblTaxiTotalIncome";
            this.lblTaxiTotalIncome.Size = new System.Drawing.Size(159, 22);
            this.lblTaxiTotalIncome.TabIndex = 41;
            this.lblTaxiTotalIncome.Text = "{total_income:N1}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(88, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 40;
            this.label10.Text = "Приходи: ";
            // 
            // lblTaxiTotalExpenses
            // 
            this.lblTaxiTotalExpenses.AutoSize = true;
            this.lblTaxiTotalExpenses.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaxiTotalExpenses.Location = new System.Drawing.Point(193, 320);
            this.lblTaxiTotalExpenses.Name = "lblTaxiTotalExpenses";
            this.lblTaxiTotalExpenses.Size = new System.Drawing.Size(205, 22);
            this.lblTaxiTotalExpenses.TabIndex = 39;
            this.lblTaxiTotalExpenses.Text = "{total_expenses:N1} лв";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(88, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Разходи: ";
            // 
            // lblTaxiTotalKM
            // 
            this.lblTaxiTotalKM.AutoSize = true;
            this.lblTaxiTotalKM.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaxiTotalKM.Location = new System.Drawing.Point(193, 210);
            this.lblTaxiTotalKM.Name = "lblTaxiTotalKM";
            this.lblTaxiTotalKM.Size = new System.Drawing.Size(122, 22);
            this.lblTaxiTotalKM.TabIndex = 37;
            this.lblTaxiTotalKM.Text = "{total_km:N0}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Общо КМ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(195, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Л/КМ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Модел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Марка: ";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.Location = new System.Drawing.Point(195, 45);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(64, 24);
            this.lblCompanyName.TabIndex = 32;
            this.lblCompanyName.Text = "Такси";
            // 
            // pbCarImage
            // 
            this.pbCarImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCarImage.ErrorImage = global::Taxi.Properties.Resources.taxi_96;
            this.pbCarImage.InitialImage = global::Taxi.Properties.Resources.taxi_96;
            this.pbCarImage.Location = new System.Drawing.Point(50, 45);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(128, 121);
            this.pbCarImage.TabIndex = 31;
            this.pbCarImage.TabStop = false;
            this.pbCarImage.Click += new System.EventHandler(this.pbCarImage_Click);
            // 
            // companyTab
            // 
            this.companyTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.companyTab.Controls.Add(this.panelCompanyTab);
            this.companyTab.Location = new System.Drawing.Point(4, 24);
            this.companyTab.Name = "companyTab";
            this.companyTab.Size = new System.Drawing.Size(1065, 499);
            this.companyTab.TabIndex = 2;
            this.companyTab.Text = "companyTab";
            // 
            // panelCompanyTab
            // 
            this.panelCompanyTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCompanyTab.BackColor = System.Drawing.Color.White;
            this.panelCompanyTab.Controls.Add(this.pictureBox4);
            this.panelCompanyTab.Controls.Add(this.pictureBox5);
            this.panelCompanyTab.Controls.Add(this.pictureBox6);
            this.panelCompanyTab.Controls.Add(this.label1);
            this.panelCompanyTab.Controls.Add(this.label14);
            this.panelCompanyTab.Controls.Add(this.label15);
            this.panelCompanyTab.Controls.Add(this.label16);
            this.panelCompanyTab.Controls.Add(this.label17);
            this.panelCompanyTab.Controls.Add(this.label18);
            this.panelCompanyTab.Controls.Add(this.label19);
            this.panelCompanyTab.Controls.Add(this.label20);
            this.panelCompanyTab.Controls.Add(this.label21);
            this.panelCompanyTab.Controls.Add(this.label22);
            this.panelCompanyTab.Controls.Add(this.label23);
            this.panelCompanyTab.Controls.Add(this.label24);
            this.panelCompanyTab.Controls.Add(this.label25);
            this.panelCompanyTab.Controls.Add(this.pbCompanyImage);
            this.panelCompanyTab.Location = new System.Drawing.Point(161, 49);
            this.panelCompanyTab.Name = "panelCompanyTab";
            this.panelCompanyTab.Size = new System.Drawing.Size(743, 400);
            this.panelCompanyTab.TabIndex = 49;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Taxi.Properties.Resources.taxi_subtract_48;
            this.pictureBox4.Location = new System.Drawing.Point(50, 314);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Taxi.Properties.Resources.taxi_addition_48;
            this.pictureBox5.Location = new System.Drawing.Point(50, 258);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 63;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Taxi.Properties.Resources.taxi_counter_48;
            this.pictureBox6.Location = new System.Drawing.Point(50, 206);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 62;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "{company_phone_number}";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(285, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 18);
            this.label14.TabIndex = 60;
            this.label14.Text = "{company_cars:N0}";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(285, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 18);
            this.label15.TabIndex = 59;
            this.label15.Text = "{company_employees:N0}";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(193, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(268, 22);
            this.label16.TabIndex = 58;
            this.label16.Text = "{company_total_expenses:N1}";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(88, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 22);
            this.label17.TabIndex = 57;
            this.label17.Text = "Приходи: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(193, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(293, 22);
            this.label18.TabIndex = 56;
            this.label18.Text = "{company_total_expenses:N1} лв";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(88, 320);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 22);
            this.label19.TabIndex = 55;
            this.label19.Text = "Разходи: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(193, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(210, 22);
            this.label20.TabIndex = 54;
            this.label20.Text = "{company_total_km:N0}";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(88, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 22);
            this.label21.TabIndex = 53;
            this.label21.Text = "Общо КМ: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(195, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 18);
            this.label22.TabIndex = 52;
            this.label22.Text = "Телефон: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(195, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 18);
            this.label23.TabIndex = 51;
            this.label23.Text = "Коли: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(195, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 18);
            this.label24.TabIndex = 50;
            this.label24.Text = "Служители: ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(195, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(171, 24);
            this.label25.TabIndex = 49;
            this.label25.Text = "{company_name}";
            // 
            // pbCompanyImage
            // 
            this.pbCompanyImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCompanyImage.ErrorImage = global::Taxi.Properties.Resources.taxi_96;
            this.pbCompanyImage.InitialImage = global::Taxi.Properties.Resources.taxi_96;
            this.pbCompanyImage.Location = new System.Drawing.Point(50, 45);
            this.pbCompanyImage.Name = "pbCompanyImage";
            this.pbCompanyImage.Size = new System.Drawing.Size(128, 121);
            this.pbCompanyImage.TabIndex = 48;
            this.pbCompanyImage.TabStop = false;
            this.pbCompanyImage.Click += new System.EventHandler(this.pbCompanyImage_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 650);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(1072, 650);
            this.Name = "MainWindow";
            this.Text = "Taxi";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.dataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.carTab.ResumeLayout(false);
            this.panelCarTab.ResumeLayout(false);
            this.panelCarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.companyTab.ResumeLayout(false);
            this.panelCompanyTab.ResumeLayout(false);
            this.panelCompanyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelButtons;
        private MaterialSkin.Controls.MaterialTabControl tabControlMain;
        private TabPage dataTab;
        private TabPage carTab;
        private TabPage companyTab;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnHome;
        private MaterialSkin.Controls.MaterialButton btnCompanyInfo;
        private MaterialSkin.Controls.MaterialButton btnCarInfo;
        private MaterialSkin.Controls.MaterialButton btnNewTrip;
        private MaterialSkin.Controls.MaterialButton btnRemoveTrip;
        private Panel panelCompanyTab;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private PictureBox pbCarImage;
        private Panel panelCarTab;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblCarKmToLitre;
        private Label lblCarMake;
        private Label lblCarModel;
        private Label lblTaxiTotalIncome;
        private Label label10;
        private Label lblTaxiTotalExpenses;
        private Label label8;
        private Label lblTaxiTotalKM;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblCompanyName;
        private PictureBox pbCompanyImage;
        private Label lblCarYear;
        private Label label27;
    }
}