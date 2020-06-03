namespace ImageCartoonEffect
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudColorReductionFactor = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudLowThreshold = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudHighThreshold = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudColorPower = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudColorFactor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSpatialFactor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKernelSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSmoothingFilter = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAlgorithm = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorReductionFactor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighThreshold)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpatialFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKernelSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPreview.Location = new System.Drawing.Point(12, 28);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(961, 584);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(979, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 584);
            this.panel1.TabIndex = 34;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(123, 548);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 31);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.nudColorReductionFactor);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(3, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 87);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Propriedades do redutor de cores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Escala de Redução";
            // 
            // nudColorReductionFactor
            // 
            this.nudColorReductionFactor.Location = new System.Drawing.Point(6, 21);
            this.nudColorReductionFactor.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudColorReductionFactor.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudColorReductionFactor.Name = "nudColorReductionFactor";
            this.nudColorReductionFactor.Size = new System.Drawing.Size(59, 21);
            this.nudColorReductionFactor.TabIndex = 1;
            this.nudColorReductionFactor.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudLowThreshold);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.nudHighThreshold);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(3, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 87);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Propriedades do detector de bordas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Limite Inferior";
            // 
            // nudLowThreshold
            // 
            this.nudLowThreshold.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLowThreshold.Location = new System.Drawing.Point(6, 49);
            this.nudLowThreshold.Name = "nudLowThreshold";
            this.nudLowThreshold.Size = new System.Drawing.Size(59, 21);
            this.nudLowThreshold.TabIndex = 3;
            this.nudLowThreshold.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLowThreshold.ValueChanged += new System.EventHandler(this.validateLTValue);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Limite Superior";
            // 
            // nudHighThreshold
            // 
            this.nudHighThreshold.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHighThreshold.Location = new System.Drawing.Point(6, 21);
            this.nudHighThreshold.Name = "nudHighThreshold";
            this.nudHighThreshold.Size = new System.Drawing.Size(59, 21);
            this.nudHighThreshold.TabIndex = 1;
            this.nudHighThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHighThreshold.ValueChanged += new System.EventHandler(this.validateHTValue);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudColorPower);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudColorFactor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSpatialFactor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudKernelSize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriedades do filtro Bilateral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poder de Cor";
            // 
            // nudColorPower
            // 
            this.nudColorPower.DecimalPlaces = 1;
            this.nudColorPower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudColorPower.Location = new System.Drawing.Point(6, 105);
            this.nudColorPower.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColorPower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudColorPower.Name = "nudColorPower";
            this.nudColorPower.Size = new System.Drawing.Size(59, 22);
            this.nudColorPower.TabIndex = 7;
            this.nudColorPower.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fator de Cor";
            // 
            // nudColorFactor
            // 
            this.nudColorFactor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudColorFactor.Location = new System.Drawing.Point(6, 77);
            this.nudColorFactor.Name = "nudColorFactor";
            this.nudColorFactor.Size = new System.Drawing.Size(59, 22);
            this.nudColorFactor.TabIndex = 5;
            this.nudColorFactor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fator Espacial";
            // 
            // nudSpatialFactor
            // 
            this.nudSpatialFactor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpatialFactor.Location = new System.Drawing.Point(6, 49);
            this.nudSpatialFactor.Name = "nudSpatialFactor";
            this.nudSpatialFactor.Size = new System.Drawing.Size(59, 22);
            this.nudSpatialFactor.TabIndex = 3;
            this.nudSpatialFactor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamanho do Kernel";
            // 
            // nudKernelSize
            // 
            this.nudKernelSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKernelSize.Location = new System.Drawing.Point(6, 21);
            this.nudKernelSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudKernelSize.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudKernelSize.Name = "nudKernelSize";
            this.nudKernelSize.Size = new System.Drawing.Size(59, 22);
            this.nudKernelSize.TabIndex = 1;
            this.nudKernelSize.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSmoothingFilter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro pré processamento";
            // 
            // cmbSmoothingFilter
            // 
            this.cmbSmoothingFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmoothingFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmoothingFilter.FormattingEnabled = true;
            this.cmbSmoothingFilter.Location = new System.Drawing.Point(6, 21);
            this.cmbSmoothingFilter.Name = "cmbSmoothingFilter";
            this.cmbSmoothingFilter.Size = new System.Drawing.Size(208, 24);
            this.cmbSmoothingFilter.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1219, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsOpen
            // 
            this.tsOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSaveAs});
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(62, 22);
            this.tsOpen.Text = "Arquivo";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(148, 22);
            this.tsmiOpen.Text = "Abrir...";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(148, 22);
            this.tsmiSaveAs.Text = "Salvar como...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // pbAlgorithm
            // 
            this.pbAlgorithm.Location = new System.Drawing.Point(12, 619);
            this.pbAlgorithm.Name = "pbAlgorithm";
            this.pbAlgorithm.Size = new System.Drawing.Size(1195, 23);
            this.pbAlgorithm.TabIndex = 36;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1219, 652);
            this.Controls.Add(this.pbAlgorithm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Cartoon Effect";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorReductionFactor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighThreshold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpatialFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKernelSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ComboBox cmbSmoothingFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ProgressBar pbAlgorithm;
        private System.Windows.Forms.NumericUpDown nudKernelSize;
        private System.Windows.Forms.NumericUpDown nudSpatialFactor;
        private System.Windows.Forms.NumericUpDown nudColorFactor;
        private System.Windows.Forms.NumericUpDown nudColorPower;
        private System.Windows.Forms.NumericUpDown nudHighThreshold;
        private System.Windows.Forms.NumericUpDown nudLowThreshold;
        private System.Windows.Forms.NumericUpDown nudColorReductionFactor;

    }
}

