namespace Myrtille
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControlAdv2 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItemFichiers = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripExFiles = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripBtnEffectif = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAbsences = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItemAnalyse = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.openFileDialogEffectif = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogAbsences = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.integerTBRecords = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.aLType = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.aLStop = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.aLStart = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboDropDown1 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.sfDateTimeStop = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.sfDateTimeStart = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdvResults = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panelWaitForResults = new System.Windows.Forms.Panel();
            this.sfDataGridResult = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabPageAdvPeople = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panelWaitForPeople = new System.Windows.Forms.Panel();
            this.sfDataGridEffectif = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabPageAdvDayOffs = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panelWaitForDayOff = new System.Windows.Forms.Panel();
            this.sfDataGridAbsences = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.imageListTriColor = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorkerAllRows = new System.ComponentModel.BackgroundWorker();
            this.progressBarAdvAnalyse = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv2)).BeginInit();
            this.ribbonControlAdv2.SuspendLayout();
            this.toolStripTabItemFichiers.Panel.SuspendLayout();
            this.toolStripExFiles.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).BeginInit();
            this.splitContainerAdv2.Panel1.SuspendLayout();
            this.splitContainerAdv2.Panel2.SuspendLayout();
            this.splitContainerAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerTBRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdvResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridResult)).BeginInit();
            this.tabPageAdvPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridEffectif)).BeginInit();
            this.tabPageAdvDayOffs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdvAnalyse)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlAdv2
            // 
            this.ribbonControlAdv2.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv2.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv2.EnableQATCustomization = false;
            this.ribbonControlAdv2.EnableRibbonCustomization = false;
            this.ribbonControlAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv2.Header.AddMainItem(toolStripTabItemFichiers);
            this.ribbonControlAdv2.Location = new System.Drawing.Point(2, 2);
            this.ribbonControlAdv2.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv2.MenuButtonText = "";
            this.ribbonControlAdv2.MenuButtonVisible = false;
            this.ribbonControlAdv2.MenuButtonWidth = 56;
            this.ribbonControlAdv2.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv2.Name = "ribbonControlAdv2";
            this.ribbonControlAdv2.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv2.OfficeMenu
            // 
            this.ribbonControlAdv2.OfficeMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ribbonControlAdv2.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv2.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv2.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv2.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv2.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv2.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv2.SelectedTab = this.toolStripTabItemFichiers;
            this.ribbonControlAdv2.ShowQuickItemsDropDownButton = false;
            this.ribbonControlAdv2.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv2.Size = new System.Drawing.Size(2450, 244);
            this.ribbonControlAdv2.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv2.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv2.TabIndex = 1;
            this.ribbonControlAdv2.Text = "ribbonControlAdv2";
            this.ribbonControlAdv2.ThemeName = "Office2013";
            this.ribbonControlAdv2.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // toolStripTabItemFichiers
            // 
            this.toolStripTabItemFichiers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItemFichiers.Name = "toolStripTabItemFichiers";
            // 
            // ribbonControlAdv2.ribbonPanel1
            // 
            this.toolStripTabItemFichiers.Panel.Controls.Add(this.toolStripExFiles);
            this.toolStripTabItemFichiers.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItemFichiers.Panel.Name = "ribbonPanel1";
            this.toolStripTabItemFichiers.Panel.ScrollPosition = 0;
            this.toolStripTabItemFichiers.Panel.ShowCaption = false;
            this.toolStripTabItemFichiers.Panel.ShowLauncher = false;
            this.toolStripTabItemFichiers.Panel.TabIndex = 2;
            this.toolStripTabItemFichiers.Panel.Text = "Fichiers";
            this.toolStripTabItemFichiers.Position = 0;
            this.toolStripTabItemFichiers.Size = new System.Drawing.Size(91, 36);
            this.toolStripTabItemFichiers.Tag = "3";
            this.toolStripTabItemFichiers.Text = "Fichiers";
            // 
            // toolStripExFiles
            // 
            this.toolStripExFiles.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripExFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripExFiles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripExFiles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripExFiles.Image = null;
            this.toolStripExFiles.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripExFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnEffectif,
            this.toolStripBtnAbsences});
            this.toolStripExFiles.Location = new System.Drawing.Point(0, 1);
            this.toolStripExFiles.Name = "toolStripExFiles";
            this.toolStripExFiles.Office12Mode = false;
            this.toolStripExFiles.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripExFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripExFiles.Size = new System.Drawing.Size(200, 143);
            this.toolStripExFiles.TabIndex = 0;
            // 
            // toolStripBtnEffectif
            // 
            this.toolStripBtnEffectif.Image = global::Myrtille.Properties.Resources.loadpeople;
            this.toolStripBtnEffectif.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEffectif.Name = "toolStripBtnEffectif";
            this.toolStripBtnEffectif.Size = new System.Drawing.Size(83, 137);
            this.toolStripBtnEffectif.Text = "Effectif";
            this.toolStripBtnEffectif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnEffectif.Click += new System.EventHandler(this.toolStripBtnEffectif_Click);
            // 
            // toolStripBtnAbsences
            // 
            this.toolStripBtnAbsences.Image = global::Myrtille.Properties.Resources.loaddays;
            this.toolStripBtnAbsences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAbsences.Name = "toolStripBtnAbsences";
            this.toolStripBtnAbsences.Size = new System.Drawing.Size(108, 137);
            this.toolStripBtnAbsences.Text = "Absences";
            this.toolStripBtnAbsences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnAbsences.Click += new System.EventHandler(this.toolStripBtnAbsences_ClickAsync);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnRefresh});
            this.toolStripEx1.Location = new System.Drawing.Point(202, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx1.Size = new System.Drawing.Size(129, 143);
            this.toolStripEx1.TabIndex = 1;
            // 
            // toolStripBtnRefresh
            // 
            this.toolStripBtnRefresh.Image = global::Myrtille.Properties.Resources.Refresh;
            this.toolStripBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRefresh.Name = "toolStripBtnRefresh";
            this.toolStripBtnRefresh.Size = new System.Drawing.Size(121, 137);
            this.toolStripBtnRefresh.Text = "Refresh";
            this.toolStripBtnRefresh.Click += new System.EventHandler(this.toolStripBtnRefresh_Click);
            // 
            // toolStripTabItemAnalyse
            // 
            this.toolStripTabItemAnalyse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItemAnalyse.Name = "toolStripTabItemAnalyse";
            // 
            // 
            // 
            this.toolStripTabItemAnalyse.Panel.Name = "ribbonPanel2";
            this.toolStripTabItemAnalyse.Panel.ScrollPosition = 0;
            this.toolStripTabItemAnalyse.Panel.TabIndex = 5;
            this.toolStripTabItemAnalyse.Panel.Text = "Analyse";
            this.toolStripTabItemAnalyse.Position = -1;
            this.toolStripTabItemAnalyse.Size = new System.Drawing.Size(93, 36);
            this.toolStripTabItemAnalyse.Text = "Analyse";
            // 
            // openFileDialogEffectif
            // 
            this.openFileDialogEffectif.DefaultExt = "xlsx";
            this.openFileDialogEffectif.ReadOnlyChecked = true;
            this.openFileDialogEffectif.ShowReadOnly = true;
            this.openFileDialogEffectif.Title = "Sélectionnez le fichier Excel pour les Effectifs";
            // 
            // openFileDialogAbsences
            // 
            this.openFileDialogAbsences.DefaultExt = "xlsx";
            this.openFileDialogAbsences.ReadOnlyChecked = true;
            this.openFileDialogAbsences.ShowReadOnly = true;
            this.openFileDialogAbsences.Title = "Sélectionnez le fichier Excel pour les Absences";
            // 
            // splitContainerAdv2
            // 
            this.splitContainerAdv2.BeforeTouchSize = 7;
            this.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv2.Location = new System.Drawing.Point(2, 246);
            this.splitContainerAdv2.Name = "splitContainerAdv2";
            // 
            // splitContainerAdv2.Panel1
            // 
            this.splitContainerAdv2.Panel1.Controls.Add(this.progressBarAdvAnalyse);
            this.splitContainerAdv2.Panel1.Controls.Add(this.integerTBRecords);
            this.splitContainerAdv2.Panel1.Controls.Add(this.aLType);
            this.splitContainerAdv2.Panel1.Controls.Add(this.aLStop);
            this.splitContainerAdv2.Panel1.Controls.Add(this.aLStart);
            this.splitContainerAdv2.Panel1.Controls.Add(this.comboDropDown1);
            this.splitContainerAdv2.Panel1.Controls.Add(this.sfDateTimeStop);
            this.splitContainerAdv2.Panel1.Controls.Add(this.sfDateTimeStart);
            this.splitContainerAdv2.Panel1MinSize = 250;
            // 
            // splitContainerAdv2.Panel2
            // 
            this.splitContainerAdv2.Panel2.Controls.Add(this.tabControlAdv1);
            this.splitContainerAdv2.Panel2MinSize = 800;
            this.splitContainerAdv2.Size = new System.Drawing.Size(2450, 1537);
            this.splitContainerAdv2.SplitterDistance = 328;
            this.splitContainerAdv2.TabIndex = 2;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            this.splitContainerAdv2.ThemeName = "None";
            // 
            // integerTBRecords
            // 
            this.integerTBRecords.BeforeTouchSize = new System.Drawing.Size(63, 31);
            this.integerTBRecords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.integerTBRecords.IntegerValue = ((long)(0));
            this.integerTBRecords.Location = new System.Drawing.Point(0, 1343);
            this.integerTBRecords.Name = "integerTBRecords";
            this.integerTBRecords.Size = new System.Drawing.Size(63, 31);
            this.integerTBRecords.TabIndex = 6;
            // 
            // aLType
            // 
            this.aLType.Location = new System.Drawing.Point(13, 280);
            this.aLType.Name = "aLType";
            this.aLType.Size = new System.Drawing.Size(164, 25);
            this.aLType.TabIndex = 5;
            this.aLType.Text = "Type d\'absence";
            this.aLType.Visible = false;
            // 
            // aLStop
            // 
            this.aLStop.Location = new System.Drawing.Point(13, 166);
            this.aLStop.Name = "aLStop";
            this.aLStop.Size = new System.Drawing.Size(123, 25);
            this.aLStop.TabIndex = 4;
            this.aLStop.Text = "Date de Fin";
            // 
            // aLStart
            // 
            this.aLStart.Location = new System.Drawing.Point(13, 64);
            this.aLStart.Name = "aLStart";
            this.aLStart.Size = new System.Drawing.Size(147, 25);
            this.aLStart.TabIndex = 3;
            this.aLStart.Text = "Date de début";
            // 
            // comboDropDown1
            // 
            this.comboDropDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboDropDown1.BeforeTouchSize = new System.Drawing.Size(356, 31);
            this.comboDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDropDown1.Location = new System.Drawing.Point(65, 308);
            this.comboDropDown1.Name = "comboDropDown1";
            this.comboDropDown1.Size = new System.Drawing.Size(356, 31);
            this.comboDropDown1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.comboDropDown1.TabIndex = 2;
            this.comboDropDown1.Visible = false;
            // 
            // sfDateTimeStop
            // 
            this.sfDateTimeStop.Enabled = false;
            this.sfDateTimeStop.Location = new System.Drawing.Point(65, 194);
            this.sfDateTimeStop.Name = "sfDateTimeStop";
            this.sfDateTimeStop.Size = new System.Drawing.Size(356, 44);
            this.sfDateTimeStop.TabIndex = 1;
            this.sfDateTimeStop.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.onStopDateChangedAsync);
            // 
            // sfDateTimeStart
            // 
            this.sfDateTimeStart.Enabled = false;
            this.sfDateTimeStart.Location = new System.Drawing.Point(65, 92);
            this.sfDateTimeStart.Name = "sfDateTimeStart";
            this.sfDateTimeStart.Size = new System.Drawing.Size(356, 44);
            this.sfDateTimeStart.TabIndex = 0;
            this.sfDateTimeStart.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.onStartDateChangedAsync);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(2115, 1537);
            this.tabControlAdv1.Controls.Add(this.tabPageAdvResults);
            this.tabControlAdv1.Controls.Add(this.tabPageAdvPeople);
            this.tabControlAdv1.Controls.Add(this.tabPageAdvDayOffs);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.ImageList = this.imageListTriColor;
            this.tabControlAdv1.ImageOffset = 2;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(2115, 1537);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv1.ThemeName = "TabRendererOffice2016Colorful";
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // tabPageAdvResults
            // 
            this.tabPageAdvResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdvResults.Controls.Add(this.panelWaitForResults);
            this.tabPageAdvResults.Controls.Add(this.sfDataGridResult);
            this.tabPageAdvResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdvResults.Image = null;
            this.tabPageAdvResults.ImageIndex = 2;
            this.tabPageAdvResults.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdvResults.Location = new System.Drawing.Point(45, 1);
            this.tabPageAdvResults.Name = "tabPageAdvResults";
            this.tabPageAdvResults.ShowCloseButton = true;
            this.tabPageAdvResults.Size = new System.Drawing.Size(2068, 1534);
            this.tabPageAdvResults.TabIndex = 1;
            this.tabPageAdvResults.Text = "Résultats";
            this.tabPageAdvResults.ThemesEnabled = false;
            // 
            // panelWaitForResults
            // 
            this.panelWaitForResults.BackgroundImage = global::Myrtille.Properties.Resources.WaitingLightwithText;
            this.panelWaitForResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelWaitForResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWaitForResults.Location = new System.Drawing.Point(0, 0);
            this.panelWaitForResults.Name = "panelWaitForResults";
            this.panelWaitForResults.Size = new System.Drawing.Size(2068, 1534);
            this.panelWaitForResults.TabIndex = 1;
            // 
            // sfDataGridResult
            // 
            this.sfDataGridResult.AccessibleName = "Table";
            this.sfDataGridResult.AllowResizingColumns = true;
            this.sfDataGridResult.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridResult.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridResult.Name = "sfDataGridResult";
            this.sfDataGridResult.PreviewRowHeight = 56;
            this.sfDataGridResult.SerializationController = null;
            this.sfDataGridResult.Size = new System.Drawing.Size(2068, 1534);
            this.sfDataGridResult.TabIndex = 0;
            this.sfDataGridResult.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfDataGridEffectif_AutoGeneratingColumn);
            // 
            // tabPageAdvPeople
            // 
            this.tabPageAdvPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdvPeople.Controls.Add(this.panelWaitForPeople);
            this.tabPageAdvPeople.Controls.Add(this.sfDataGridEffectif);
            this.tabPageAdvPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdvPeople.Image = null;
            this.tabPageAdvPeople.ImageIndex = 2;
            this.tabPageAdvPeople.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdvPeople.Location = new System.Drawing.Point(45, 1);
            this.tabPageAdvPeople.Name = "tabPageAdvPeople";
            this.tabPageAdvPeople.ShowCloseButton = true;
            this.tabPageAdvPeople.Size = new System.Drawing.Size(2068, 1534);
            this.tabPageAdvPeople.TabIndex = 2;
            this.tabPageAdvPeople.Text = "Effectifs";
            this.tabPageAdvPeople.ThemesEnabled = false;
            // 
            // panelWaitForPeople
            // 
            this.panelWaitForPeople.BackgroundImage = global::Myrtille.Properties.Resources.WaitingLightPeople;
            this.panelWaitForPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelWaitForPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWaitForPeople.Location = new System.Drawing.Point(0, 0);
            this.panelWaitForPeople.Name = "panelWaitForPeople";
            this.panelWaitForPeople.Size = new System.Drawing.Size(2068, 1534);
            this.panelWaitForPeople.TabIndex = 1;
            // 
            // sfDataGridEffectif
            // 
            this.sfDataGridEffectif.AccessibleName = "Table";
            this.sfDataGridEffectif.AllowResizingColumns = true;
            this.sfDataGridEffectif.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGridEffectif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridEffectif.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridEffectif.Name = "sfDataGridEffectif";
            this.sfDataGridEffectif.PreviewRowHeight = 56;
            this.sfDataGridEffectif.Size = new System.Drawing.Size(2068, 1534);
            this.sfDataGridEffectif.TabIndex = 0;
            this.sfDataGridEffectif.Text = "sfDataGrid1";
            this.sfDataGridEffectif.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfDataGridEffectif_AutoGeneratingColumn);
            // 
            // tabPageAdvDayOffs
            // 
            this.tabPageAdvDayOffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdvDayOffs.Controls.Add(this.panelWaitForDayOff);
            this.tabPageAdvDayOffs.Controls.Add(this.sfDataGridAbsences);
            this.tabPageAdvDayOffs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdvDayOffs.Image = null;
            this.tabPageAdvDayOffs.ImageIndex = 2;
            this.tabPageAdvDayOffs.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdvDayOffs.Location = new System.Drawing.Point(45, 1);
            this.tabPageAdvDayOffs.Name = "tabPageAdvDayOffs";
            this.tabPageAdvDayOffs.ShowCloseButton = true;
            this.tabPageAdvDayOffs.Size = new System.Drawing.Size(2068, 1534);
            this.tabPageAdvDayOffs.TabIndex = 3;
            this.tabPageAdvDayOffs.Text = "Absences";
            this.tabPageAdvDayOffs.ThemesEnabled = false;
            // 
            // panelWaitForDayOff
            // 
            this.panelWaitForDayOff.BackgroundImage = global::Myrtille.Properties.Resources.WaitingLightDayOff;
            this.panelWaitForDayOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelWaitForDayOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWaitForDayOff.Location = new System.Drawing.Point(0, 0);
            this.panelWaitForDayOff.Name = "panelWaitForDayOff";
            this.panelWaitForDayOff.Size = new System.Drawing.Size(2068, 1534);
            this.panelWaitForDayOff.TabIndex = 1;
            // 
            // sfDataGridAbsences
            // 
            this.sfDataGridAbsences.AccessibleName = "Table";
            this.sfDataGridAbsences.AllowResizingColumns = true;
            this.sfDataGridAbsences.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGridAbsences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridAbsences.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridAbsences.Name = "sfDataGridAbsences";
            this.sfDataGridAbsences.PreviewRowHeight = 56;
            this.sfDataGridAbsences.Size = new System.Drawing.Size(2068, 1534);
            this.sfDataGridAbsences.TabIndex = 0;
            this.sfDataGridAbsences.Text = "sfDataGrid1";
            this.sfDataGridAbsences.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.sfDataGridAbsences_autoGeneratingColumn);
            // 
            // imageListTriColor
            // 
            this.imageListTriColor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTriColor.ImageStream")));
            this.imageListTriColor.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTriColor.Images.SetKeyName(0, "green3D.png");
            this.imageListTriColor.Images.SetKeyName(1, "orange3d.png");
            this.imageListTriColor.Images.SetKeyName(2, "red3d.png");
            // 
            // backgroundWorkerAllRows
            // 
            this.backgroundWorkerAllRows.WorkerReportsProgress = true;
            this.backgroundWorkerAllRows.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AllRowsProcess);
            this.backgroundWorkerAllRows.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.onWorkerProgressChanged);
            this.backgroundWorkerAllRows.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.onWorkerComplete);
            // 
            // progressBarAdvAnalyse
            // 
            this.progressBarAdvAnalyse.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016Colorful;
            this.progressBarAdvAnalyse.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdvAnalyse.BackSegments = false;
            this.progressBarAdvAnalyse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdvAnalyse.CustomText = null;
            this.progressBarAdvAnalyse.CustomWaitingRender = false;
            this.progressBarAdvAnalyse.ForegroundImage = null;
            this.progressBarAdvAnalyse.Location = new System.Drawing.Point(14, 560);
            this.progressBarAdvAnalyse.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdvAnalyse.Name = "progressBarAdvAnalyse";
            this.progressBarAdvAnalyse.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Office2016Colorful;
            this.progressBarAdvAnalyse.SegmentWidth = 12;
            this.progressBarAdvAnalyse.Size = new System.Drawing.Size(392, 25);
            this.progressBarAdvAnalyse.TabIndex = 7;
            this.progressBarAdvAnalyse.Text = "progressBarAdv1";
            this.progressBarAdvAnalyse.ThemeName = "Office2016Colorful";
            this.progressBarAdvAnalyse.Value = 0;
            this.progressBarAdvAnalyse.WaitingGradientWidth = 400;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2454, 1785);
            this.Controls.Add(this.splitContainerAdv2);
            this.Controls.Add(this.ribbonControlAdv2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Myrtille";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv2)).EndInit();
            this.ribbonControlAdv2.ResumeLayout(false);
            this.ribbonControlAdv2.PerformLayout();
            this.toolStripTabItemFichiers.Panel.ResumeLayout(false);
            this.toolStripTabItemFichiers.Panel.PerformLayout();
            this.toolStripExFiles.ResumeLayout(false);
            this.toolStripExFiles.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.splitContainerAdv2.Panel1.ResumeLayout(false);
            this.splitContainerAdv2.Panel1.PerformLayout();
            this.splitContainerAdv2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).EndInit();
            this.splitContainerAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerTBRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdvResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridResult)).EndInit();
            this.tabPageAdvPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridEffectif)).EndInit();
            this.tabPageAdvDayOffs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdvAnalyse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
//        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
//        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
//        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv2;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItemFichiers;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripExFiles;
        private System.Windows.Forms.ToolStripButton toolStripBtnEffectif;
//        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem4;
        private System.Windows.Forms.ToolStripButton toolStripBtnAbsences;
        private System.Windows.Forms.OpenFileDialog openFileDialogEffectif;
        private System.Windows.Forms.OpenFileDialog openFileDialogAbsences;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv2;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdvPeople;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridEffectif;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdvDayOffs;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridAbsences;
//        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem5;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItemAnalyse;
        private System.Windows.Forms.Panel panelWaitForPeople;
        private System.Windows.Forms.Panel panelWaitForDayOff;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeStart;
        private Syncfusion.WinForms.Input.SfDateTimeEdit sfDateTimeStop;
        private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel aLStop;
        private Syncfusion.Windows.Forms.Tools.AutoLabel aLStart;
        private Syncfusion.Windows.Forms.Tools.AutoLabel aLType;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdvResults;
        private System.Windows.Forms.Panel panelWaitForResults;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridResult;
        private System.Windows.Forms.ImageList imageListTriColor;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTBRecords;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAllRows;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripBtnRefresh;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdvAnalyse;
    }
}

