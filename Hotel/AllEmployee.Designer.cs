
namespace Hotel
{
    partial class AllEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEmployee));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.grid = new System.Windows.Forms.DataGridView();
            this.scroll = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.availableBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.allBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bookedBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.allEmployeeDataSet = new Hotel.AllEmployeeDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Hotel.AllEmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.sNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoGenerateColumns = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.bGDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.empTypeDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.grid.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(43)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.grid.Location = new System.Drawing.Point(0, 104);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 40;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(959, 387);
            this.grid.TabIndex = 14;
            // 
            // scroll
            // 
            this.scroll.AllowCursorChanges = true;
            this.scroll.AllowHomeEndKeysDetection = false;
            this.scroll.AllowIncrementalClickMoves = true;
            this.scroll.AllowMouseDownEffects = true;
            this.scroll.AllowMouseHoverEffects = true;
            this.scroll.AllowScrollingAnimations = true;
            this.scroll.AllowScrollKeysDetection = true;
            this.scroll.AllowScrollOptionsMenu = true;
            this.scroll.AllowShrinkingOnFocusLost = false;
            this.scroll.BackgroundColor = System.Drawing.Color.Silver;
            this.scroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scroll.BackgroundImage")));
            this.scroll.BindingContainer = null;
            this.scroll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.scroll.BorderRadius = 0;
            this.scroll.BorderThickness = 1;
            this.scroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll.DurationBeforeShrink = 2000;
            this.scroll.LargeChange = 10;
            this.scroll.Location = new System.Drawing.Point(959, 104);
            this.scroll.Maximum = 100;
            this.scroll.Minimum = 0;
            this.scroll.MinimumThumbLength = 18;
            this.scroll.Name = "scroll";
            this.scroll.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.scroll.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scroll.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.scroll.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.scroll.ScrollBarColor = System.Drawing.Color.Silver;
            this.scroll.ShrinkSizeLimit = 3;
            this.scroll.Size = new System.Drawing.Size(15, 387);
            this.scroll.SmallChange = 1;
            this.scroll.TabIndex = 13;
            this.scroll.ThumbColor = System.Drawing.Color.Gray;
            this.scroll.ThumbLength = 38;
            this.scroll.ThumbMargin = 1;
            this.scroll.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.scroll.Value = 0;
            this.scroll.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.scroll_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuButton1);
            this.panel2.Controls.Add(this.availableBtn);
            this.panel2.Controls.Add(this.allBtn);
            this.panel2.Controls.Add(this.bookedBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 104);
            this.panel2.TabIndex = 12;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "All";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuButton1.IdleBorderRadius = 34;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(321, 45);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 34;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 34;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 34;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 34;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(45, 36);
            this.bunifuButton1.TabIndex = 5;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // availableBtn
            // 
            this.availableBtn.AllowAnimations = true;
            this.availableBtn.AllowMouseEffects = true;
            this.availableBtn.AllowToggling = false;
            this.availableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableBtn.AnimationSpeed = 200;
            this.availableBtn.AutoGenerateColors = false;
            this.availableBtn.AutoRoundBorders = false;
            this.availableBtn.AutoSizeLeftIcon = true;
            this.availableBtn.AutoSizeRightIcon = true;
            this.availableBtn.BackColor = System.Drawing.Color.Transparent;
            this.availableBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.availableBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("availableBtn.BackgroundImage")));
            this.availableBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.availableBtn.ButtonText = "Admin";
            this.availableBtn.ButtonTextMarginLeft = 0;
            this.availableBtn.ColorContrastOnClick = 45;
            this.availableBtn.ColorContrastOnHover = 45;
            this.availableBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.availableBtn.CustomizableEdges = borderEdges2;
            this.availableBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.availableBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.availableBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.availableBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.availableBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.availableBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.availableBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.availableBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.availableBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.availableBtn.IconMarginLeft = 11;
            this.availableBtn.IconPadding = 10;
            this.availableBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.availableBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.availableBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.availableBtn.IconSize = 25;
            this.availableBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.availableBtn.IdleBorderRadius = 34;
            this.availableBtn.IdleBorderThickness = 1;
            this.availableBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.availableBtn.IdleIconLeftImage = null;
            this.availableBtn.IdleIconRightImage = null;
            this.availableBtn.IndicateFocus = false;
            this.availableBtn.Location = new System.Drawing.Point(12, 45);
            this.availableBtn.Name = "availableBtn";
            this.availableBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.availableBtn.OnDisabledState.BorderRadius = 34;
            this.availableBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.availableBtn.OnDisabledState.BorderThickness = 1;
            this.availableBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.availableBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.availableBtn.OnDisabledState.IconLeftImage = null;
            this.availableBtn.OnDisabledState.IconRightImage = null;
            this.availableBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.availableBtn.onHoverState.BorderRadius = 34;
            this.availableBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.availableBtn.onHoverState.BorderThickness = 1;
            this.availableBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.availableBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.availableBtn.onHoverState.IconLeftImage = null;
            this.availableBtn.onHoverState.IconRightImage = null;
            this.availableBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.availableBtn.OnIdleState.BorderRadius = 34;
            this.availableBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.availableBtn.OnIdleState.BorderThickness = 1;
            this.availableBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.availableBtn.OnIdleState.ForeColor = System.Drawing.Color.Gainsboro;
            this.availableBtn.OnIdleState.IconLeftImage = null;
            this.availableBtn.OnIdleState.IconRightImage = null;
            this.availableBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.availableBtn.OnPressedState.BorderRadius = 34;
            this.availableBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.availableBtn.OnPressedState.BorderThickness = 1;
            this.availableBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.availableBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.availableBtn.OnPressedState.IconLeftImage = null;
            this.availableBtn.OnPressedState.IconRightImage = null;
            this.availableBtn.Size = new System.Drawing.Size(100, 36);
            this.availableBtn.TabIndex = 4;
            this.availableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.availableBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.availableBtn.TextMarginLeft = 0;
            this.availableBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.availableBtn.UseDefaultRadiusAndThickness = true;
            this.availableBtn.Click += new System.EventHandler(this.availableBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.AllowAnimations = true;
            this.allBtn.AllowMouseEffects = true;
            this.allBtn.AllowToggling = false;
            this.allBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allBtn.AnimationSpeed = 200;
            this.allBtn.AutoGenerateColors = false;
            this.allBtn.AutoRoundBorders = false;
            this.allBtn.AutoSizeLeftIcon = true;
            this.allBtn.AutoSizeRightIcon = true;
            this.allBtn.BackColor = System.Drawing.Color.Transparent;
            this.allBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.allBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allBtn.BackgroundImage")));
            this.allBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.allBtn.ButtonText = "Recipsotins";
            this.allBtn.ButtonTextMarginLeft = 0;
            this.allBtn.ColorContrastOnClick = 45;
            this.allBtn.ColorContrastOnHover = 45;
            this.allBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = false;
            borderEdges3.TopRight = false;
            this.allBtn.CustomizableEdges = borderEdges3;
            this.allBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.allBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.allBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.allBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.allBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.allBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.allBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.allBtn.IconMarginLeft = 11;
            this.allBtn.IconPadding = 10;
            this.allBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.allBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.allBtn.IconSize = 25;
            this.allBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.allBtn.IdleBorderRadius = 34;
            this.allBtn.IdleBorderThickness = 1;
            this.allBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.allBtn.IdleIconLeftImage = null;
            this.allBtn.IdleIconRightImage = null;
            this.allBtn.IndicateFocus = false;
            this.allBtn.Location = new System.Drawing.Point(209, 45);
            this.allBtn.Name = "allBtn";
            this.allBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.allBtn.OnDisabledState.BorderRadius = 34;
            this.allBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.allBtn.OnDisabledState.BorderThickness = 1;
            this.allBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.allBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.allBtn.OnDisabledState.IconLeftImage = null;
            this.allBtn.OnDisabledState.IconRightImage = null;
            this.allBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.allBtn.onHoverState.BorderRadius = 34;
            this.allBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.allBtn.onHoverState.BorderThickness = 1;
            this.allBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.allBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.allBtn.onHoverState.IconLeftImage = null;
            this.allBtn.onHoverState.IconRightImage = null;
            this.allBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.allBtn.OnIdleState.BorderRadius = 34;
            this.allBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.allBtn.OnIdleState.BorderThickness = 1;
            this.allBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.allBtn.OnIdleState.ForeColor = System.Drawing.Color.Gainsboro;
            this.allBtn.OnIdleState.IconLeftImage = null;
            this.allBtn.OnIdleState.IconRightImage = null;
            this.allBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.allBtn.OnPressedState.BorderRadius = 34;
            this.allBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.allBtn.OnPressedState.BorderThickness = 1;
            this.allBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.allBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.allBtn.OnPressedState.IconLeftImage = null;
            this.allBtn.OnPressedState.IconRightImage = null;
            this.allBtn.Size = new System.Drawing.Size(109, 36);
            this.allBtn.TabIndex = 3;
            this.allBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.allBtn.TextMarginLeft = 0;
            this.allBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.allBtn.UseDefaultRadiusAndThickness = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // bookedBtn
            // 
            this.bookedBtn.AllowAnimations = true;
            this.bookedBtn.AllowMouseEffects = true;
            this.bookedBtn.AllowToggling = false;
            this.bookedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookedBtn.AnimationSpeed = 200;
            this.bookedBtn.AutoGenerateColors = false;
            this.bookedBtn.AutoRoundBorders = false;
            this.bookedBtn.AutoSizeLeftIcon = true;
            this.bookedBtn.AutoSizeRightIcon = true;
            this.bookedBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookedBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bookedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookedBtn.BackgroundImage")));
            this.bookedBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bookedBtn.ButtonText = "Manager";
            this.bookedBtn.ButtonTextMarginLeft = 0;
            this.bookedBtn.ColorContrastOnClick = 45;
            this.bookedBtn.ColorContrastOnHover = 45;
            this.bookedBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = false;
            borderEdges4.BottomRight = false;
            borderEdges4.TopLeft = false;
            borderEdges4.TopRight = false;
            this.bookedBtn.CustomizableEdges = borderEdges4;
            this.bookedBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bookedBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bookedBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bookedBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bookedBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bookedBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookedBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookedBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bookedBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bookedBtn.IconMarginLeft = 11;
            this.bookedBtn.IconPadding = 10;
            this.bookedBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookedBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bookedBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bookedBtn.IconSize = 25;
            this.bookedBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bookedBtn.IdleBorderRadius = 34;
            this.bookedBtn.IdleBorderThickness = 1;
            this.bookedBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bookedBtn.IdleIconLeftImage = null;
            this.bookedBtn.IdleIconRightImage = null;
            this.bookedBtn.IndicateFocus = false;
            this.bookedBtn.Location = new System.Drawing.Point(115, 45);
            this.bookedBtn.Name = "bookedBtn";
            this.bookedBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bookedBtn.OnDisabledState.BorderRadius = 34;
            this.bookedBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bookedBtn.OnDisabledState.BorderThickness = 1;
            this.bookedBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bookedBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bookedBtn.OnDisabledState.IconLeftImage = null;
            this.bookedBtn.OnDisabledState.IconRightImage = null;
            this.bookedBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bookedBtn.onHoverState.BorderRadius = 34;
            this.bookedBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bookedBtn.onHoverState.BorderThickness = 1;
            this.bookedBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bookedBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bookedBtn.onHoverState.IconLeftImage = null;
            this.bookedBtn.onHoverState.IconRightImage = null;
            this.bookedBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bookedBtn.OnIdleState.BorderRadius = 34;
            this.bookedBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bookedBtn.OnIdleState.BorderThickness = 1;
            this.bookedBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.bookedBtn.OnIdleState.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookedBtn.OnIdleState.IconLeftImage = null;
            this.bookedBtn.OnIdleState.IconRightImage = null;
            this.bookedBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bookedBtn.OnPressedState.BorderRadius = 34;
            this.bookedBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bookedBtn.OnPressedState.BorderThickness = 1;
            this.bookedBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bookedBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bookedBtn.OnPressedState.IconLeftImage = null;
            this.bookedBtn.OnPressedState.IconRightImage = null;
            this.bookedBtn.Size = new System.Drawing.Size(90, 36);
            this.bookedBtn.TabIndex = 2;
            this.bookedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bookedBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookedBtn.TextMarginLeft = 0;
            this.bookedBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.bookedBtn.UseDefaultRadiusAndThickness = true;
            this.bookedBtn.Click += new System.EventHandler(this.bookedBtn_Click);
            // 
            // allEmployeeDataSet
            // 
            this.allEmployeeDataSet.DataSetName = "AllEmployeeDataSet";
            this.allEmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.allEmployeeDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "SN";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            this.sNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bGDataGridViewTextBoxColumn
            // 
            this.bGDataGridViewTextBoxColumn.DataPropertyName = "BG";
            this.bGDataGridViewTextBoxColumn.HeaderText = "BG";
            this.bGDataGridViewTextBoxColumn.Name = "bGDataGridViewTextBoxColumn";
            this.bGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "JoiningDate";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empTypeDataGridViewTextBoxColumn
            // 
            this.empTypeDataGridViewTextBoxColumn.DataPropertyName = "EmpType";
            this.empTypeDataGridViewTextBoxColumn.HeaderText = "EmpType";
            this.empTypeDataGridViewTextBoxColumn.Name = "empTypeDataGridViewTextBoxColumn";
            this.empTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // AllEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(974, 491);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.scroll);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllEmployee";
            this.Text = "AllEmployee";
            this.Load += new System.EventHandler(this.AllEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private Bunifu.UI.WinForms.BunifuVScrollBar scroll;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton availableBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton allBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bookedBtn;
        private AllEmployeeDataSet allEmployeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AllEmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}