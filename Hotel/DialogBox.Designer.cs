
namespace Hotel
{
    partial class DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.okBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.iconAnimation = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconExitBtn = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.messageBox = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.AllowAnimations = true;
            this.okBtn.AllowMouseEffects = true;
            this.okBtn.AllowToggling = false;
            this.okBtn.AnimationSpeed = 200;
            this.okBtn.AutoGenerateColors = false;
            this.okBtn.AutoRoundBorders = false;
            this.okBtn.AutoSizeLeftIcon = true;
            this.okBtn.AutoSizeRightIcon = true;
            this.okBtn.BackColor = System.Drawing.Color.Transparent;
            this.okBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okBtn.BackgroundImage")));
            this.okBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.ButtonText = "Ok";
            this.okBtn.ButtonTextMarginLeft = 0;
            this.okBtn.ColorContrastOnClick = 45;
            this.okBtn.ColorContrastOnHover = 45;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.okBtn.CustomizableEdges = borderEdges2;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.okBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.okBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.okBtn.IconMarginLeft = 11;
            this.okBtn.IconPadding = 10;
            this.okBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.okBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.okBtn.IconSize = 25;
            this.okBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.IdleBorderRadius = 10;
            this.okBtn.IdleBorderThickness = 1;
            this.okBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.IdleIconLeftImage = null;
            this.okBtn.IdleIconRightImage = null;
            this.okBtn.IndicateFocus = false;
            this.okBtn.Location = new System.Drawing.Point(170, 155);
            this.okBtn.Name = "okBtn";
            this.okBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.OnDisabledState.BorderRadius = 10;
            this.okBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.OnDisabledState.BorderThickness = 1;
            this.okBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.okBtn.OnDisabledState.IconLeftImage = null;
            this.okBtn.OnDisabledState.IconRightImage = null;
            this.okBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(72)))));
            this.okBtn.onHoverState.BorderRadius = 10;
            this.okBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.onHoverState.BorderThickness = 1;
            this.okBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(72)))));
            this.okBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.okBtn.onHoverState.IconLeftImage = null;
            this.okBtn.onHoverState.IconRightImage = null;
            this.okBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.OnIdleState.BorderRadius = 10;
            this.okBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.OnIdleState.BorderThickness = 1;
            this.okBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.okBtn.OnIdleState.IconLeftImage = null;
            this.okBtn.OnIdleState.IconRightImage = null;
            this.okBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.OnPressedState.BorderRadius = 10;
            this.okBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.okBtn.OnPressedState.BorderThickness = 1;
            this.okBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.okBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.okBtn.OnPressedState.IconLeftImage = null;
            this.okBtn.OnPressedState.IconRightImage = null;
            this.okBtn.Size = new System.Drawing.Size(83, 40);
            this.okBtn.TabIndex = 1;
            this.okBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.okBtn.TextMarginLeft = 0;
            this.okBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.okBtn.UseDefaultRadiusAndThickness = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = true;
            this.bunifuCircleProgress1.AnimationInterval = 4;
            this.bunifuCircleProgress1.AnimationSpeed = 1;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.IsPercentage = false;
            this.bunifuCircleProgress1.LineProgressThickness = 5;
            this.bunifuCircleProgress1.LineThickness = 5;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(177, 21);
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Empty;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(62, 62);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = "";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "30";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Value = 30;
            this.bunifuCircleProgress1.ValueByTransition = 30;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // iconAnimation
            // 
            this.iconAnimation.BackColor = System.Drawing.Color.White;
            this.iconAnimation.ForeColor = System.Drawing.Color.SeaGreen;
            this.iconAnimation.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconAnimation.IconColor = System.Drawing.Color.SeaGreen;
            this.iconAnimation.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconAnimation.IconSize = 57;
            this.iconAnimation.Location = new System.Drawing.Point(182, 28);
            this.iconAnimation.Name = "iconAnimation";
            this.iconAnimation.Size = new System.Drawing.Size(57, 57);
            this.iconAnimation.TabIndex = 17;
            this.iconAnimation.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconExitBtn
            // 
            this.iconExitBtn.BackColor = System.Drawing.Color.White;
            this.iconExitBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.iconExitBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExitBtn.IconColor = System.Drawing.Color.DarkGray;
            this.iconExitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExitBtn.IconSize = 25;
            this.iconExitBtn.Location = new System.Drawing.Point(380, 6);
            this.iconExitBtn.Name = "iconExitBtn";
            this.iconExitBtn.Size = new System.Drawing.Size(25, 25);
            this.iconExitBtn.TabIndex = 18;
            this.iconExitBtn.TabStop = false;
            this.iconExitBtn.Click += new System.EventHandler(this.iconExitBtn_Click);
            this.iconExitBtn.MouseLeave += new System.EventHandler(this.iconExitBtn_MouseLeave);
            this.iconExitBtn.MouseHover += new System.EventHandler(this.iconExitBtn_MouseHover);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 20;
            this.iconPictureBox1.TabStop = false;
            // 
            // messageBox
            // 
            this.messageBox.AllowParentOverrides = false;
            this.messageBox.AutoEllipsis = false;
            this.messageBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageBox.CursorType = System.Windows.Forms.Cursors.Default;
            this.messageBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.messageBox.Location = new System.Drawing.Point(15, 105);
            this.messageBox.MinimumSize = new System.Drawing.Size(390, 0);
            this.messageBox.Name = "messageBox";
            this.messageBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messageBox.Size = new System.Drawing.Size(390, 25);
            this.messageBox.TabIndex = 21;
            this.messageBox.Text = "Login Successful !";
            this.messageBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageBox.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 229);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconExitBtn);
            this.Controls.Add(this.iconAnimation);
            this.Controls.Add(this.bunifuCircleProgress1);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogBox";
            this.Load += new System.EventHandler(this.DialogBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton okBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
        private FontAwesome.Sharp.IconPictureBox iconAnimation;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox iconExitBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel messageBox;
    }
}