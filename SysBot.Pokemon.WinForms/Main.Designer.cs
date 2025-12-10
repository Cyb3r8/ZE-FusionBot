using FontAwesome.Sharp;
using PKHeX.Drawing.PokeSprite.Properties;
using SysBot.Pokemon.Helpers;
using SysBot.Pokemon.WinForms.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace SysBot.Pokemon.WinForms
{

    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>


        internal FontAwesome.Sharp.IconButton btnBots;
        internal FontAwesome.Sharp.IconButton btnHub;
        internal FontAwesome.Sharp.IconButton btnLogs;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelLeftSide = new Panel();
            btnLogs = new IconButton();
            btnHub = new IconButton();
            CB_Themes = new ComboBox();
            btnBots = new IconButton();
            panelImageLogo = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            pictureLogo = new PictureBox();
            lblTitle = new Label();
            panel4 = new Panel();
            panelTitleBar = new Panel();
            btnClose = new IconPictureBox();
            btnMaximize = new IconPictureBox();
            btnMinimize = new IconPictureBox();
            childFormIcon = new IconPictureBox();
            lblTitleChildForm = new Label();
            upperPanelImage = new PictureBox();
            shadowPanelTop = new Panel();
            shadowPanelLeft = new Panel();
            panelMain = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panelLeftSide.SuspendLayout();
            panelImageLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childFormIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upperPanelImage).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeftSide
            // 
            panelLeftSide.BackColor = Color.FromArgb(31, 30, 68);
            panelLeftSide.Controls.Add(btnLogs);
            panelLeftSide.Controls.Add(btnHub);
            panelLeftSide.Controls.Add(CB_Themes);
            panelLeftSide.Controls.Add(btnBots);
            panelLeftSide.Controls.Add(panelImageLogo);
            panelLeftSide.Controls.Add(lblTitle);
            panelLeftSide.Dock = DockStyle.Left;
            panelLeftSide.Location = new Point(0, 0);
            panelLeftSide.Margin = new Padding(3, 2, 3, 2);
            panelLeftSide.Name = "panelLeftSide";
            panelLeftSide.Size = new Size(192, 473);
            panelLeftSide.TabIndex = 0;
            // 
            // btnLogs
            // 
            btnLogs.Dock = DockStyle.Top;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.ForeColor = Color.White;
            btnLogs.IconChar = IconChar.ListDots;
            btnLogs.IconColor = Color.White;
            btnLogs.IconFont = IconFont.Solid;
            btnLogs.IconSize = 50;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(0, 184);
            btnLogs.Margin = new Padding(3, 2, 3, 2);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(9, 0, 18, 0);
            btnLogs.Size = new Size(192, 45);
            btnLogs.TabIndex = 3;
            btnLogs.Text = " Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += Logs_Click;
            // 
            // btnHub
            // 
            btnHub.Dock = DockStyle.Top;
            btnHub.FlatAppearance.BorderSize = 0;
            btnHub.FlatStyle = FlatStyle.Flat;
            btnHub.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHub.ForeColor = Color.White;
            btnHub.IconChar = IconChar.TableList;
            btnHub.IconColor = Color.White;
            btnHub.IconFont = IconFont.Solid;
            btnHub.IconSize = 50;
            btnHub.ImageAlign = ContentAlignment.MiddleLeft;
            btnHub.Location = new Point(0, 139);
            btnHub.Margin = new Padding(3, 2, 3, 2);
            btnHub.Name = "btnHub";
            btnHub.Padding = new Padding(9, 0, 18, 0);
            btnHub.Size = new Size(192, 45);
            btnHub.TabIndex = 2;
            btnHub.Text = " Hub";
            btnHub.TextAlign = ContentAlignment.MiddleLeft;
            btnHub.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHub.UseVisualStyleBackColor = true;
            btnHub.Click += Hub_Click;
            // 
            // CB_Themes
            // 
            CB_Themes.BackColor = Color.FromArgb(20, 19, 57);
            CB_Themes.ForeColor = Color.White;
            CB_Themes.FormattingEnabled = true;
            CB_Themes.Location = new Point(41, 242);
            CB_Themes.Margin = new Padding(3, 2, 3, 2);
            CB_Themes.Name = "CB_Themes";
            CB_Themes.Size = new Size(112, 23);
            CB_Themes.TabIndex = 5;
            // 
            // btnBots
            // 
            btnBots.Dock = DockStyle.Top;
            btnBots.FlatAppearance.BorderSize = 0;
            btnBots.FlatStyle = FlatStyle.Flat;
            btnBots.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBots.ForeColor = Color.White;
            btnBots.IconChar = IconChar.Robot;
            btnBots.IconColor = Color.White;
            btnBots.IconFont = IconFont.Solid;
            btnBots.IconSize = 50;
            btnBots.ImageAlign = ContentAlignment.MiddleLeft;
            btnBots.Location = new Point(0, 94);
            btnBots.Margin = new Padding(3, 2, 3, 2);
            btnBots.Name = "btnBots";
            btnBots.Padding = new Padding(9, 0, 18, 0);
            btnBots.Size = new Size(192, 45);
            btnBots.TabIndex = 1;
            btnBots.Text = " Bots";
            btnBots.TextAlign = ContentAlignment.MiddleLeft;
            btnBots.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBots.UseVisualStyleBackColor = true;
            btnBots.Click += Bots_Click;
            // 
            // panelImageLogo
            // 
            panelImageLogo.BackColor = Color.Transparent;
            panelImageLogo.Controls.Add(panel6);
            panelImageLogo.Controls.Add(panel5);
            panelImageLogo.Controls.Add(panel3);
            panelImageLogo.Controls.Add(pictureLogo);
            panelImageLogo.Dock = DockStyle.Top;
            panelImageLogo.Location = new Point(0, 0);
            panelImageLogo.Margin = new Padding(3, 2, 3, 2);
            panelImageLogo.Name = "panelImageLogo";
            panelImageLogo.Size = new Size(192, 94);
            panelImageLogo.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(20, 19, 57);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 4);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 86);
            panel6.TabIndex = 5;
            panel6.Paint += panel6_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(20, 19, 57);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 4);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 19, 57);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 90);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 4);
            panel3.TabIndex = 3;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Transparent;
            pictureLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(3, 9);
            pictureLogo.Margin = new Padding(3, 2, 3, 2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(190, 80);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Bahnschrift", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Gainsboro;
            lblTitle.Location = new Point(-1, 372);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 24);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "ZE FusionBot | v0.0.0 | MODE: None";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 19, 57);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 44);
            panel4.TabIndex = 4;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(31, 30, 68);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(panel4);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(childFormIcon);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(upperPanelImage);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(192, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(754, 44);
            panelTitleBar.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(31, 30, 68);
            btnClose.ForeColor = Color.IndianRed;
            btnClose.IconChar = IconChar.Close;
            btnClose.IconColor = Color.IndianRed;
            btnClose.IconFont = IconFont.Auto;
            btnClose.IconSize = 16;
            btnClose.Location = new Point(732, 4);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(18, 16);
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(31, 30, 68);
            btnMaximize.IconChar = IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.White;
            btnMaximize.IconFont = IconFont.Auto;
            btnMaximize.IconSize = 16;
            btnMaximize.Location = new Point(716, 4);
            btnMaximize.Margin = new Padding(3, 2, 3, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(18, 16);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(31, 30, 68);
            btnMinimize.IconChar = IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.White;
            btnMinimize.IconFont = IconFont.Auto;
            btnMinimize.IconSize = 16;
            btnMinimize.Location = new Point(699, 4);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(18, 16);
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            // 
            // childFormIcon
            // 
            childFormIcon.BackColor = Color.FromArgb(31, 30, 68);
            childFormIcon.IconChar = IconChar.House;
            childFormIcon.IconColor = Color.White;
            childFormIcon.IconFont = IconFont.Auto;
            childFormIcon.IconSize = 30;
            childFormIcon.Location = new Point(13, 9);
            childFormIcon.Margin = new Padding(3, 2, 3, 2);
            childFormIcon.Name = "childFormIcon";
            childFormIcon.Size = new Size(35, 30);
            childFormIcon.TabIndex = 1;
            childFormIcon.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(40, 5);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(211, 39);
            lblTitleChildForm.TabIndex = 0;
            lblTitleChildForm.Text = "LOADING ...";
            // 
            // upperPanelImage
            // 
            upperPanelImage.Location = new Point(522, 4);
            upperPanelImage.Margin = new Padding(3, 2, 3, 2);
            upperPanelImage.Name = "upperPanelImage";
            upperPanelImage.Size = new Size(88, 38);
            upperPanelImage.TabIndex = 0;
            upperPanelImage.TabStop = false;
            // 
            // shadowPanelTop
            // 
            shadowPanelTop.BackColor = Color.FromArgb(20, 19, 57);
            shadowPanelTop.Dock = DockStyle.Top;
            shadowPanelTop.Location = new Point(192, 44);
            shadowPanelTop.Margin = new Padding(3, 2, 3, 2);
            shadowPanelTop.Name = "shadowPanelTop";
            shadowPanelTop.Size = new Size(754, 4);
            shadowPanelTop.TabIndex = 2;
            // 
            // shadowPanelLeft
            // 
            shadowPanelLeft.BackColor = Color.FromArgb(20, 19, 57);
            shadowPanelLeft.Dock = DockStyle.Left;
            shadowPanelLeft.Location = new Point(192, 48);
            shadowPanelLeft.Margin = new Padding(3, 2, 3, 2);
            shadowPanelLeft.Name = "shadowPanelLeft";
            shadowPanelLeft.Size = new Size(5, 425);
            shadowPanelLeft.TabIndex = 3;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(10, 10, 40);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(197, 48);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(749, 425);
            panelMain.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 19, 57);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 421);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 4);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 19, 57);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(744, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 425);
            panel1.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 473);
            Controls.Add(panelMain);
            Controls.Add(shadowPanelLeft);
            Controls.Add(shadowPanelTop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelLeftSide);
            Icon = Properties.Resources.icon;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(700, 316);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZE FusionBot";
            panelLeftSide.ResumeLayout(false);
            panelImageLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)childFormIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)upperPanelImage).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
{
    // Draw the existing image first
    if (panelTitleBar.BackgroundImage != null)
        e.Graphics.DrawImage(panelTitleBar.BackgroundImage, 0, 0, panelTitleBar.Width, panelTitleBar.Height);

    // Draw sparkles
    foreach (var sp in sparkles)
    {
        int alpha = (int)(255 * (float)sp.Life / sp.MaxLife);
        using (Brush brush = new SolidBrush(Color.FromArgb(alpha, 255, 255, 255)))
        {
            e.Graphics.FillEllipse(brush, sp.Position.X, sp.Position.Y, sp.Size, sp.Size);
        }
    }
}


        #endregion

        internal Panel panelLeftSide;
        internal Panel panelImageLogo;
        internal PictureBox pictureLogo;
        internal Panel panelTitleBar;
        internal Label lblTitleChildForm;
        internal FontAwesome.Sharp.IconPictureBox childFormIcon;
        internal FontAwesome.Sharp.IconPictureBox btnMaximize;
        internal FontAwesome.Sharp.IconPictureBox btnMinimize;
        internal FontAwesome.Sharp.IconPictureBox btnClose;
        internal Panel shadowPanelTop;
        internal Panel shadowPanelLeft;
        internal Panel panelMain;
        internal Label lblTitle;
        internal Panel panel2;
        internal Panel panel1;
        internal Panel panel4;
        internal Panel panel3;
        internal Panel panel6;
        internal Panel panel5;
        private ComboBox CB_Themes;
    }
}

