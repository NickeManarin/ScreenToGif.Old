﻿using ScreenToGif.Properties;

namespace ScreenToGif.Pages
{
    partial class TitleFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleFrame));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.backColorDialog = new System.Windows.Forms.ColorDialog();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.flowContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblContent = new System.Windows.Forms.Label();
            this.gbBackground = new System.Windows.Forms.GroupBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.rbBlured = new System.Windows.Forms.RadioButton();
            this.rbSolidColor = new System.Windows.Forms.RadioButton();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnBold = new System.Windows.Forms.CheckBox();
            this.btnItalics = new System.Windows.Forms.CheckBox();
            this.btnUnderline = new System.Windows.Forms.CheckBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.lblExample = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSeparator2 = new System.Windows.Forms.PictureBox();
            this.pbForeColor = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMoreOptions = new System.Windows.Forms.Button();
            this.foreColorDialog = new System.Windows.Forms.ColorDialog();
            this.flowContent.SuspendLayout();
            this.gbBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.flowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::ScreenToGif.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(420, 260);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = global::ScreenToGif.Properties.Resources.btnCancel;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Image = global::ScreenToGif.Properties.Resources.Done;
            this.btnOk.Location = new System.Drawing.Point(-1, 260);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(421, 41);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = global::ScreenToGif.Properties.Resources.btnDone;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // backColorDialog
            // 
            this.backColorDialog.AnyColor = true;
            this.backColorDialog.SolidColorOnly = true;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(56, 3);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(526, 137);
            this.tbTitle.TabIndex = 0;
            // 
            // flowContent
            // 
            this.flowContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowContent.ColumnCount = 2;
            this.flowContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.flowContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowContent.Controls.Add(this.lblContent, 0, 0);
            this.flowContent.Controls.Add(this.tbTitle, 1, 0);
            this.flowContent.Location = new System.Drawing.Point(12, 37);
            this.flowContent.Name = "flowContent";
            this.flowContent.RowCount = 1;
            this.flowContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowContent.Size = new System.Drawing.Size(585, 143);
            this.flowContent.TabIndex = 26;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(0, 7);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(53, 15);
            this.lblContent.TabIndex = 19;
            this.lblContent.Text = "Content:";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBackground
            // 
            this.gbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBackground.Controls.Add(this.btnBackColor);
            this.gbBackground.Controls.Add(this.pbBackground);
            this.gbBackground.Controls.Add(this.rbBlured);
            this.gbBackground.Controls.Add(this.rbSolidColor);
            this.gbBackground.Location = new System.Drawing.Point(12, 186);
            this.gbBackground.Name = "gbBackground";
            this.gbBackground.Size = new System.Drawing.Size(263, 69);
            this.gbBackground.TabIndex = 1;
            this.gbBackground.TabStop = false;
            this.gbBackground.Text = "Background";
            // 
            // btnBackColor
            // 
            this.btnBackColor.AutoSize = true;
            this.btnBackColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackColor.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnBackColor.FlatAppearance.BorderSize = 0;
            this.btnBackColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(179, 19);
            this.btnBackColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(57, 25);
            this.btnBackColor.TabIndex = 0;
            this.btnBackColor.Text = global::ScreenToGif.Properties.Resources.btnSelect;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.Black;
            this.pbBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackground.Location = new System.Drawing.Point(140, 21);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(30, 20);
            this.pbBackground.TabIndex = 2;
            this.pbBackground.TabStop = false;
            this.pbBackground.Click += new System.EventHandler(this.btnBackColor_Click);
            this.pbBackground.MouseHover += new System.EventHandler(this.pbBackground_MouseHover);
            // 
            // rbBlured
            // 
            this.rbBlured.AutoSize = true;
            this.rbBlured.Location = new System.Drawing.Point(9, 47);
            this.rbBlured.Name = "rbBlured";
            this.rbBlured.Size = new System.Drawing.Size(161, 19);
            this.rbBlured.TabIndex = 1;
            this.rbBlured.Text = global::ScreenToGif.Properties.Resources.Radio_NextFrame;
            this.tooltip.SetToolTip(this.rbBlured, "This option makes your Title Frame\'s  background using a blured version of the\r\n " +
        "next frame.");
            this.rbBlured.UseVisualStyleBackColor = true;
            // 
            // rbSolidColor
            // 
            this.rbSolidColor.AutoSize = true;
            this.rbSolidColor.Checked = true;
            this.rbSolidColor.Location = new System.Drawing.Point(9, 22);
            this.rbSolidColor.Name = "rbSolidColor";
            this.rbSolidColor.Size = new System.Drawing.Size(83, 19);
            this.rbSolidColor.TabIndex = 0;
            this.rbSolidColor.TabStop = true;
            this.rbSolidColor.Text = global::ScreenToGif.Properties.Resources.Radio_SolidColor;
            this.rbSolidColor.UseVisualStyleBackColor = true;
            this.rbSolidColor.CheckedChanged += new System.EventHandler(this.rbSolidColor_CheckedChanged);
            // 
            // btnBold
            // 
            this.btnBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Image = global::ScreenToGif.Properties.Resources.Bold16x;
            this.btnBold.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBold.Location = new System.Drawing.Point(254, 0);
            this.btnBold.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBold.Name = "btnBold";
            this.btnBold.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.btnBold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBold.Size = new System.Drawing.Size(25, 31);
            this.btnBold.TabIndex = 42;
            this.btnBold.TabStop = false;
            this.btnBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.btnBold, global::ScreenToGif.Properties.Resources.Tooltip_GifSettings);
            this.btnBold.UseVisualStyleBackColor = true;
            // 
            // btnItalics
            // 
            this.btnItalics.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnItalics.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnItalics.FlatAppearance.BorderSize = 0;
            this.btnItalics.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnItalics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnItalics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalics.Image = global::ScreenToGif.Properties.Resources.Italics16x;
            this.btnItalics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItalics.Location = new System.Drawing.Point(279, 0);
            this.btnItalics.Margin = new System.Windows.Forms.Padding(0);
            this.btnItalics.Name = "btnItalics";
            this.btnItalics.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.btnItalics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnItalics.Size = new System.Drawing.Size(25, 31);
            this.btnItalics.TabIndex = 43;
            this.btnItalics.TabStop = false;
            this.btnItalics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.btnItalics, global::ScreenToGif.Properties.Resources.Tooltip_GifSettings);
            this.btnItalics.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            this.btnUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnUnderline.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnUnderline.FlatAppearance.BorderSize = 0;
            this.btnUnderline.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUnderline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Image = global::ScreenToGif.Properties.Resources.Underline16x;
            this.btnUnderline.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnderline.Location = new System.Drawing.Point(304, 0);
            this.btnUnderline.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.btnUnderline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUnderline.Size = new System.Drawing.Size(25, 31);
            this.btnUnderline.TabIndex = 44;
            this.btnUnderline.TabStop = false;
            this.btnUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.btnUnderline, global::ScreenToGif.Properties.Resources.Tooltip_GifSettings);
            this.btnUnderline.UseVisualStyleBackColor = true;
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.Color.White;
            this.fontDialog.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.fontDialog.MaxSize = 72;
            this.fontDialog.MinSize = 5;
            this.fontDialog.ShowColor = true;
            // 
            // lblExample
            // 
            this.lblExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExample.BackColor = System.Drawing.Color.Black;
            this.lblExample.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblExample.ForeColor = System.Drawing.Color.White;
            this.lblExample.Location = new System.Drawing.Point(281, 186);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(316, 69);
            this.lblExample.TabIndex = 22;
            this.lblExample.Text = "Example";
            this.lblExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPanel
            // 
            this.flowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowPanel.Controls.Add(this.cbFonts);
            this.flowPanel.Controls.Add(this.numSize);
            this.flowPanel.Controls.Add(this.pictureBox1);
            this.flowPanel.Controls.Add(this.btnBold);
            this.flowPanel.Controls.Add(this.btnItalics);
            this.flowPanel.Controls.Add(this.btnUnderline);
            this.flowPanel.Controls.Add(this.pbSeparator2);
            this.flowPanel.Controls.Add(this.pbForeColor);
            this.flowPanel.Controls.Add(this.pictureBox3);
            this.flowPanel.Controls.Add(this.btnMoreOptions);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(609, 31);
            this.flowPanel.TabIndex = 30;
            // 
            // cbFonts
            // 
            this.cbFonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFonts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(3, 4);
            this.cbFonts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(187, 23);
            this.cbFonts.TabIndex = 0;
            // 
            // numSize
            // 
            this.numSize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.numSize.Location = new System.Drawing.Point(193, 4);
            this.numSize.Margin = new System.Windows.Forms.Padding(0, 4, 5, 5);
            this.numSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numSize.Size = new System.Drawing.Size(43, 23);
            this.numSize.TabIndex = 49;
            this.numSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ScreenToGif.Properties.Resources.Separator;
            this.pictureBox1.Location = new System.Drawing.Point(244, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pbSeparator2
            // 
            this.pbSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.pbSeparator2.Image = global::ScreenToGif.Properties.Resources.Separator;
            this.pbSeparator2.Location = new System.Drawing.Point(337, 4);
            this.pbSeparator2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.pbSeparator2.Name = "pbSeparator2";
            this.pbSeparator2.Size = new System.Drawing.Size(2, 25);
            this.pbSeparator2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSeparator2.TabIndex = 45;
            this.pbSeparator2.TabStop = false;
            // 
            // pbForeColor
            // 
            this.pbForeColor.BackColor = System.Drawing.Color.Black;
            this.pbForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbForeColor.Location = new System.Drawing.Point(345, 6);
            this.pbForeColor.Margin = new System.Windows.Forms.Padding(3, 6, 6, 3);
            this.pbForeColor.Name = "pbForeColor";
            this.pbForeColor.Size = new System.Drawing.Size(30, 20);
            this.pbForeColor.TabIndex = 46;
            this.pbForeColor.TabStop = false;
            this.pbForeColor.Click += new System.EventHandler(this.pbForeColor_Click);
            this.pbForeColor.MouseHover += new System.EventHandler(this.pbForeColor_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ScreenToGif.Properties.Resources.Separator;
            this.pictureBox3.Location = new System.Drawing.Point(384, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // btnMoreOptions
            // 
            this.btnMoreOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoreOptions.AutoSize = true;
            this.btnMoreOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoreOptions.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnMoreOptions.FlatAppearance.BorderSize = 0;
            this.btnMoreOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMoreOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreOptions.Location = new System.Drawing.Point(394, 4);
            this.btnMoreOptions.Margin = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.btnMoreOptions.Name = "btnMoreOptions";
            this.btnMoreOptions.Size = new System.Drawing.Size(90, 25);
            this.btnMoreOptions.TabIndex = 47;
            this.btnMoreOptions.Text = "More Options";
            this.btnMoreOptions.UseVisualStyleBackColor = true;
            this.btnMoreOptions.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // TitleFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 300);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.flowContent);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.gbBackground);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(625, 290);
            this.Name = "TitleFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title Frame";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TitleFrameSettings_FormClosing);
            this.flowContent.ResumeLayout(false);
            this.flowContent.PerformLayout();
            this.gbBackground.ResumeLayout(false);
            this.gbBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog backColorDialog;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.GroupBox gbBackground;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RadioButton rbBlured;
        private System.Windows.Forms.RadioButton rbSolidColor;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TableLayoutPanel flowContent;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox btnBold;
        private System.Windows.Forms.CheckBox btnItalics;
        private System.Windows.Forms.CheckBox btnUnderline;
        private System.Windows.Forms.PictureBox pbSeparator2;
        private System.Windows.Forms.PictureBox pbForeColor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMoreOptions;
        private System.Windows.Forms.ColorDialog foreColorDialog;
    }
}