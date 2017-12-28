namespace PaintMate
{
    partial class PaintMateForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintMateForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomWidth = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoomVolume = new System.Windows.Forms.TextBox();
            this.txtFloorArea = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaskingTapeLength = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPaintRequired = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomArea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDoorOrWindow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDWwidth = new System.Windows.Forms.TextBox();
            this.txtRoomBase = new System.Windows.Forms.TextBox();
            this.txtRoomHeight = new System.Windows.Forms.TextBox();
            this.txtDWheight = new System.Windows.Forms.TextBox();
            this.btnAddDW = new System.Windows.Forms.Button();
            this.dgvDW = new System.Windows.Forms.DataGridView();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCoats = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPaintType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDryingTime = new System.Windows.Forms.TextBox();
            this.txtRecoatTime = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDW)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "What are the dimensions of the Room?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base (M)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height (M)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width (M)";
            // 
            // txtRoomWidth
            // 
            this.txtRoomWidth.Location = new System.Drawing.Point(79, 55);
            this.txtRoomWidth.MaxLength = 6;
            this.txtRoomWidth.Name = "txtRoomWidth";
            this.txtRoomWidth.Size = new System.Drawing.Size(58, 20);
            this.txtRoomWidth.TabIndex = 2;
            this.txtRoomWidth.TextChanged += new System.EventHandler(this.txtRoomWidth_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRecoatTime);
            this.panel1.Controls.Add(this.txtDryingTime);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtCoats);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtRoomVolume);
            this.panel1.Controls.Add(this.txtFloorArea);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtMaskingTapeLength);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPaintRequired);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtRoomArea);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(287, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 355);
            this.panel1.TabIndex = 8;
            // 
            // txtRoomVolume
            // 
            this.txtRoomVolume.Location = new System.Drawing.Point(145, 67);
            this.txtRoomVolume.Name = "txtRoomVolume";
            this.txtRoomVolume.ReadOnly = true;
            this.txtRoomVolume.Size = new System.Drawing.Size(81, 20);
            this.txtRoomVolume.TabIndex = 12;
            this.txtRoomVolume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFloorArea
            // 
            this.txtFloorArea.Location = new System.Drawing.Point(145, 45);
            this.txtFloorArea.Name = "txtFloorArea";
            this.txtFloorArea.ReadOnly = true;
            this.txtFloorArea.Size = new System.Drawing.Size(81, 20);
            this.txtFloorArea.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Volume of room (M³)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Area of floor (M²)";
            // 
            // txtMaskingTapeLength
            // 
            this.txtMaskingTapeLength.Location = new System.Drawing.Point(145, 245);
            this.txtMaskingTapeLength.Name = "txtMaskingTapeLength";
            this.txtMaskingTapeLength.ReadOnly = true;
            this.txtMaskingTapeLength.Size = new System.Drawing.Size(81, 20);
            this.txtMaskingTapeLength.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Masking tape length (M)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Misc information";
            // 
            // txtPaintRequired
            // 
            this.txtPaintRequired.Location = new System.Drawing.Point(145, 119);
            this.txtPaintRequired.Name = "txtPaintRequired";
            this.txtPaintRequired.ReadOnly = true;
            this.txtPaintRequired.Size = new System.Drawing.Size(81, 20);
            this.txtPaintRequired.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Minimum paint required (Ltr)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Paint information";
            // 
            // txtRoomArea
            // 
            this.txtRoomArea.Location = new System.Drawing.Point(145, 23);
            this.txtRoomArea.Name = "txtRoomArea";
            this.txtRoomArea.ReadOnly = true;
            this.txtRoomArea.Size = new System.Drawing.Size(81, 20);
            this.txtRoomArea.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Area to paint (M²)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Room information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Does the room have any doors or windows?";
            // 
            // cmbDoorOrWindow
            // 
            this.cmbDoorOrWindow.FormattingEnabled = true;
            this.cmbDoorOrWindow.Items.AddRange(new object[] {
            "Door",
            "Window"});
            this.cmbDoorOrWindow.Location = new System.Drawing.Point(12, 135);
            this.cmbDoorOrWindow.Name = "cmbDoorOrWindow";
            this.cmbDoorOrWindow.Size = new System.Drawing.Size(69, 21);
            this.cmbDoorOrWindow.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Width (M)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Height (M)";
            // 
            // txtDWwidth
            // 
            this.txtDWwidth.Location = new System.Drawing.Point(87, 136);
            this.txtDWwidth.MaxLength = 6;
            this.txtDWwidth.Name = "txtDWwidth";
            this.txtDWwidth.Size = new System.Drawing.Size(73, 20);
            this.txtDWwidth.TabIndex = 5;
            // 
            // txtRoomBase
            // 
            this.txtRoomBase.Location = new System.Drawing.Point(16, 55);
            this.txtRoomBase.MaxLength = 6;
            this.txtRoomBase.Name = "txtRoomBase";
            this.txtRoomBase.Size = new System.Drawing.Size(58, 20);
            this.txtRoomBase.TabIndex = 1;
            this.txtRoomBase.TextChanged += new System.EventHandler(this.txtRoomBase_TextChanged);
            // 
            // txtRoomHeight
            // 
            this.txtRoomHeight.Location = new System.Drawing.Point(143, 55);
            this.txtRoomHeight.MaxLength = 6;
            this.txtRoomHeight.Name = "txtRoomHeight";
            this.txtRoomHeight.Size = new System.Drawing.Size(58, 20);
            this.txtRoomHeight.TabIndex = 3;
            this.txtRoomHeight.TextChanged += new System.EventHandler(this.txtRoomHeight_TextChanged);
            // 
            // txtDWheight
            // 
            this.txtDWheight.Location = new System.Drawing.Point(166, 136);
            this.txtDWheight.MaxLength = 6;
            this.txtDWheight.Name = "txtDWheight";
            this.txtDWheight.Size = new System.Drawing.Size(73, 20);
            this.txtDWheight.TabIndex = 6;
            // 
            // btnAddDW
            // 
            this.btnAddDW.Location = new System.Drawing.Point(245, 136);
            this.btnAddDW.Name = "btnAddDW";
            this.btnAddDW.Size = new System.Drawing.Size(36, 23);
            this.btnAddDW.TabIndex = 7;
            this.btnAddDW.Text = "Add";
            this.btnAddDW.UseVisualStyleBackColor = true;
            this.btnAddDW.Click += new System.EventHandler(this.btnAddDW_Click);
            // 
            // dgvDW
            // 
            this.dgvDW.AllowUserToAddRows = false;
            this.dgvDW.AllowUserToDeleteRows = false;
            this.dgvDW.AllowUserToResizeColumns = false;
            this.dgvDW.AllowUserToResizeRows = false;
            this.dgvDW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnType,
            this.columnWidth,
            this.columnHeight});
            this.dgvDW.Location = new System.Drawing.Point(12, 165);
            this.dgvDW.Name = "dgvDW";
            this.dgvDW.ReadOnly = true;
            this.dgvDW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDW.Size = new System.Drawing.Size(269, 175);
            this.dgvDW.TabIndex = 19;
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Type";
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            this.columnType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnType.Width = 75;
            // 
            // columnWidth
            // 
            this.columnWidth.HeaderText = "Width (cm)";
            this.columnWidth.Name = "columnWidth";
            this.columnWidth.ReadOnly = true;
            this.columnWidth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnWidth.Width = 75;
            // 
            // columnHeight
            // 
            this.columnHeight.HeaderText = "Height (cm)";
            this.columnHeight.Name = "columnHeight";
            this.columnHeight.ReadOnly = true;
            this.columnHeight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnHeight.Width = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Export Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "No. of coats";
            // 
            // txtCoats
            // 
            this.txtCoats.Location = new System.Drawing.Point(145, 142);
            this.txtCoats.Name = "txtCoats";
            this.txtCoats.ReadOnly = true;
            this.txtCoats.Size = new System.Drawing.Size(81, 20);
            this.txtCoats.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 347);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "Paint type";
            // 
            // cmbPaintType
            // 
            this.cmbPaintType.FormattingEnabled = true;
            this.cmbPaintType.Items.AddRange(new object[] {
            "Estate Emulsion",
            "Modern Emulsion",
            "Estate Eggshell",
            "Modern Eggshell",
            "Full Gloss",
            "Dead Flat",
            "Exterior Masonry",
            "Exterior Eggshell",
            "Casein Distemper",
            "Soft Distemper"});
            this.cmbPaintType.Location = new System.Drawing.Point(87, 346);
            this.cmbPaintType.Name = "cmbPaintType";
            this.cmbPaintType.Size = new System.Drawing.Size(194, 21);
            this.cmbPaintType.TabIndex = 8;
            this.cmbPaintType.Text = "Please Select";
            this.cmbPaintType.SelectedIndexChanged += new System.EventHandler(this.cmbPaintType_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Drying time (Hrs)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Recoat time (Hrs)";
            // 
            // txtDryingTime
            // 
            this.txtDryingTime.Location = new System.Drawing.Point(145, 165);
            this.txtDryingTime.Name = "txtDryingTime";
            this.txtDryingTime.ReadOnly = true;
            this.txtDryingTime.Size = new System.Drawing.Size(81, 20);
            this.txtDryingTime.TabIndex = 17;
            // 
            // txtRecoatTime
            // 
            this.txtRecoatTime.Location = new System.Drawing.Point(145, 189);
            this.txtRecoatTime.Name = "txtRecoatTime";
            this.txtRecoatTime.ReadOnly = true;
            this.txtRecoatTime.Size = new System.Drawing.Size(81, 20);
            this.txtRecoatTime.TabIndex = 18;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // PaintMateForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 408);
            this.Controls.Add(this.cmbPaintType);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDW);
            this.Controls.Add(this.btnAddDW);
            this.Controls.Add(this.txtDWheight);
            this.Controls.Add(this.txtRoomHeight);
            this.Controls.Add(this.txtRoomBase);
            this.Controls.Add(this.txtDWwidth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDoorOrWindow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRoomWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaintMateForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintMate";
            this.Load += new System.EventHandler(this.PaintMateForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoorOrWindow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDWwidth;
        private System.Windows.Forms.TextBox txtRoomBase;
        private System.Windows.Forms.TextBox txtRoomHeight;
        private System.Windows.Forms.TextBox txtDWheight;
        private System.Windows.Forms.Button btnAddDW;
        private System.Windows.Forms.DataGridView dgvDW;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRoomVolume;
        private System.Windows.Forms.TextBox txtFloorArea;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMaskingTapeLength;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPaintRequired;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRoomArea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCoats;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPaintType;
        private System.Windows.Forms.TextBox txtRecoatTime;
        private System.Windows.Forms.TextBox txtDryingTime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

