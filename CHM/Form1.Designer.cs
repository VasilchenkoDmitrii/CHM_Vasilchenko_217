namespace CHM
{
    partial class Form1
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
            this._buttonReDraw = new System.Windows.Forms.Button();
            this._plot = new System.Windows.Forms.PictureBox();
            this._CTextBoxYMax = new CHM.CoorTextBox();
            this._CTextBoxYMin = new CHM.CoorTextBox();
            this._CTextBoxXMin = new CHM.CoorTextBox();
            this._CTextBoxXMax = new CHM.CoorTextBox();
            this.NetRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PolynomRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SplineRichTextBox = new System.Windows.Forms.RichTextBox();
            this.LagrangeCheckBox = new System.Windows.Forms.CheckBox();
            this.SplineCheckBox = new System.Windows.Forms.CheckBox();
            this.PointsCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureSaveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this._plot)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonReDraw
            // 
            this._buttonReDraw.Location = new System.Drawing.Point(1068, 721);
            this._buttonReDraw.Name = "_buttonReDraw";
            this._buttonReDraw.Size = new System.Drawing.Size(650, 23);
            this._buttonReDraw.TabIndex = 1;
            this._buttonReDraw.Text = "Redraw";
            this._buttonReDraw.UseVisualStyleBackColor = true;
            this._buttonReDraw.Click += new System.EventHandler(this._buttonReDraw_Click);
            // 
            // _plot
            // 
            this._plot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._plot.Location = new System.Drawing.Point(1068, 26);
            this._plot.Name = "_plot";
            this._plot.Size = new System.Drawing.Size(650, 650);
            this._plot.TabIndex = 0;
            this._plot.TabStop = false;
            this._plot.Paint += new System.Windows.Forms.PaintEventHandler(this._plot_Paint);
            // 
            // _CTextBoxYMax
            // 
            this._CTextBoxYMax.Location = new System.Drawing.Point(989, 26);
            this._CTextBoxYMax.Name = "_CTextBoxYMax";
            this._CTextBoxYMax.Size = new System.Drawing.Size(73, 23);
            this._CTextBoxYMax.TabIndex = 2;
            this._CTextBoxYMax.Text = "1";
            this._CTextBoxYMax.TextChanged += new System.EventHandler(this.CoorTextBox_textChanged);
            // 
            // _CTextBoxYMin
            // 
            this._CTextBoxYMin.Location = new System.Drawing.Point(989, 653);
            this._CTextBoxYMin.Name = "_CTextBoxYMin";
            this._CTextBoxYMin.Size = new System.Drawing.Size(73, 23);
            this._CTextBoxYMin.TabIndex = 3;
            this._CTextBoxYMin.Text = "0";
            this._CTextBoxYMin.TextChanged += new System.EventHandler(this.CoorTextBox_textChanged);
            // 
            // _CTextBoxXMin
            // 
            this._CTextBoxXMin.Location = new System.Drawing.Point(1068, 682);
            this._CTextBoxXMin.Name = "_CTextBoxXMin";
            this._CTextBoxXMin.Size = new System.Drawing.Size(73, 23);
            this._CTextBoxXMin.TabIndex = 4;
            this._CTextBoxXMin.Text = "0";
            this._CTextBoxXMin.TextChanged += new System.EventHandler(this.CoorTextBox_textChanged);
            // 
            // _CTextBoxXMax
            // 
            this._CTextBoxXMax.Location = new System.Drawing.Point(1645, 682);
            this._CTextBoxXMax.Name = "_CTextBoxXMax";
            this._CTextBoxXMax.Size = new System.Drawing.Size(73, 23);
            this._CTextBoxXMax.TabIndex = 5;
            this._CTextBoxXMax.Text = "1";
            this._CTextBoxXMax.TextChanged += new System.EventHandler(this.CoorTextBox_textChanged);
            // 
            // NetRichTextBox
            // 
            this.NetRichTextBox.Location = new System.Drawing.Point(12, 26);
            this.NetRichTextBox.Name = "NetRichTextBox";
            this.NetRichTextBox.Size = new System.Drawing.Size(880, 124);
            this.NetRichTextBox.TabIndex = 6;
            this.NetRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сетка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Интерполяционный многочлен Лагранжа";
            // 
            // PolynomRichTextBox
            // 
            this.PolynomRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PolynomRichTextBox.Location = new System.Drawing.Point(12, 188);
            this.PolynomRichTextBox.Name = "PolynomRichTextBox";
            this.PolynomRichTextBox.Size = new System.Drawing.Size(880, 349);
            this.PolynomRichTextBox.TabIndex = 9;
            this.PolynomRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кубические сплайны";
            // 
            // SplineRichTextBox
            // 
            this.SplineRichTextBox.Location = new System.Drawing.Point(12, 580);
            this.SplineRichTextBox.Name = "SplineRichTextBox";
            this.SplineRichTextBox.Size = new System.Drawing.Size(880, 267);
            this.SplineRichTextBox.TabIndex = 11;
            this.SplineRichTextBox.Text = "";
            // 
            // LagrangeCheckBox
            // 
            this.LagrangeCheckBox.AutoSize = true;
            this.LagrangeCheckBox.Checked = true;
            this.LagrangeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LagrangeCheckBox.Location = new System.Drawing.Point(1069, 752);
            this.LagrangeCheckBox.Name = "LagrangeCheckBox";
            this.LagrangeCheckBox.Size = new System.Drawing.Size(136, 19);
            this.LagrangeCheckBox.TabIndex = 12;
            this.LagrangeCheckBox.Text = "Полином Лагранжа";
            this.LagrangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SplineCheckBox
            // 
            this.SplineCheckBox.AutoSize = true;
            this.SplineCheckBox.Checked = true;
            this.SplineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SplineCheckBox.Location = new System.Drawing.Point(1069, 777);
            this.SplineCheckBox.Name = "SplineCheckBox";
            this.SplineCheckBox.Size = new System.Drawing.Size(135, 19);
            this.SplineCheckBox.TabIndex = 13;
            this.SplineCheckBox.Text = "Кубический сплайн";
            this.SplineCheckBox.UseVisualStyleBackColor = true;
            // 
            // PointsCheckBox
            // 
            this.PointsCheckBox.AutoSize = true;
            this.PointsCheckBox.Checked = true;
            this.PointsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PointsCheckBox.Location = new System.Drawing.Point(1068, 802);
            this.PointsCheckBox.Name = "PointsCheckBox";
            this.PointsCheckBox.Size = new System.Drawing.Size(136, 19);
            this.PointsCheckBox.TabIndex = 14;
            this.PointsCheckBox.Text = "Изначальные точки";
            this.PointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 875);
            this.Controls.Add(this.PointsCheckBox);
            this.Controls.Add(this.SplineCheckBox);
            this.Controls.Add(this.LagrangeCheckBox);
            this.Controls.Add(this.SplineRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PolynomRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NetRichTextBox);
            this.Controls.Add(this._CTextBoxXMax);
            this.Controls.Add(this._CTextBoxXMin);
            this.Controls.Add(this._CTextBoxYMin);
            this.Controls.Add(this._CTextBoxYMax);
            this.Controls.Add(this._buttonReDraw);
            this.Controls.Add(this._plot);
            this.Name = "Form1";
            this.Text = "Vasilchenko_217";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._plot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _buttonReDraw;
        private System.Windows.Forms.PictureBox _plot;
        private CoorTextBox _CTextBoxYMax;
        private CoorTextBox _CTextBoxYMin;
        private CoorTextBox _CTextBoxXMin;
        private CoorTextBox _CTextBoxXMax;
        private System.Windows.Forms.RichTextBox NetRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PolynomRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox SplineRichTextBox;
        private System.Windows.Forms.CheckBox LagrangeCheckBox;
        private System.Windows.Forms.CheckBox SplineCheckBox;
        private System.Windows.Forms.CheckBox PointsCheckBox;
        private System.Windows.Forms.SaveFileDialog pictureSaveDialog;
    }
}
