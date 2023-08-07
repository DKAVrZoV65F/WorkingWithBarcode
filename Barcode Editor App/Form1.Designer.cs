
namespace Barcode_Editor_App
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnExecuteLength = new Button();
			nudLengthBarcode = new NumericUpDown();
			gp2 = new GroupBox();
			chbSelectionLength = new CheckBox();
			tbRangeText = new TextBox();
			gp1 = new GroupBox();
			btnExecute = new Button();
			gp3 = new GroupBox();
			nudLength = new NumericUpDown();
			btnExecuteRect = new Button();
			nudY2 = new NumericUpDown();
			nudX2 = new NumericUpDown();
			nudY = new NumericUpDown();
			nudX = new NumericUpDown();
			label3 = new Label();
			label4 = new Label();
			label2 = new Label();
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			btnToGrey = new Button();
			groupBox3 = new GroupBox();
			btnInversion = new Button();
			gbMain = new GroupBox();
			pbMain = new PictureBox();
			gbClue = new GroupBox();
			rbSummer = new RadioButton();
			rbMin = new RadioButton();
			rbMax = new RadioButton();
			tbIncDecVal = new TextBox();
			((System.ComponentModel.ISupportInitialize)nudLengthBarcode).BeginInit();
			gp2.SuspendLayout();
			gp1.SuspendLayout();
			gp3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudY2).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudX2).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
			groupBox3.SuspendLayout();
			gbMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
			gbClue.SuspendLayout();
			SuspendLayout();
			// 
			// btnExecuteLength
			// 
			btnExecuteLength.Enabled = false;
			btnExecuteLength.Location = new Point(5, 75);
			btnExecuteLength.Margin = new Padding(4, 3, 4, 3);
			btnExecuteLength.Name = "btnExecuteLength";
			btnExecuteLength.Size = new Size(124, 32);
			btnExecuteLength.TabIndex = 2;
			btnExecuteLength.Text = "Execute";
			btnExecuteLength.UseVisualStyleBackColor = true;
			btnExecuteLength.Click += btnExecuteLength_Click;
			// 
			// nudLengthBarcode
			// 
			nudLengthBarcode.Location = new Point(6, 44);
			nudLengthBarcode.Margin = new Padding(4, 3, 4, 3);
			nudLengthBarcode.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudLengthBarcode.Name = "nudLengthBarcode";
			nudLengthBarcode.Size = new Size(124, 23);
			nudLengthBarcode.TabIndex = 1;
			// 
			// gp2
			// 
			gp2.Controls.Add(chbSelectionLength);
			gp2.Controls.Add(nudLengthBarcode);
			gp2.Controls.Add(btnExecuteLength);
			gp2.Controls.Add(tbRangeText);
			gp2.Location = new Point(6, 42);
			gp2.Margin = new Padding(4, 3, 4, 3);
			gp2.Name = "gp2";
			gp2.Padding = new Padding(4, 3, 4, 3);
			gp2.Size = new Size(142, 119);
			gp2.TabIndex = 3;
			gp2.TabStop = false;
			gp2.Text = "Select length barcode";
			// 
			// chbSelectionLength
			// 
			chbSelectionLength.AutoSize = true;
			chbSelectionLength.Location = new Point(6, 19);
			chbSelectionLength.Margin = new Padding(4, 3, 4, 3);
			chbSelectionLength.Name = "chbSelectionLength";
			chbSelectionLength.Size = new Size(80, 19);
			chbSelectionLength.TabIndex = 3;
			chbSelectionLength.Text = "Range *(-)";
			chbSelectionLength.UseVisualStyleBackColor = true;
			chbSelectionLength.CheckedChanged += chbSelectionLength_CheckedChanged;
			// 
			// tbRangeText
			// 
			tbRangeText.Location = new Point(7, 44);
			tbRangeText.Name = "tbRangeText";
			tbRangeText.Size = new Size(122, 23);
			tbRangeText.TabIndex = 4;
			tbRangeText.Visible = false;
			// 
			// gp1
			// 
			gp1.Controls.Add(tbIncDecVal);
			gp1.Controls.Add(btnExecute);
			gp1.Location = new Point(6, 167);
			gp1.Margin = new Padding(4, 3, 4, 3);
			gp1.Name = "gp1";
			gp1.Padding = new Padding(4, 3, 4, 3);
			gp1.Size = new Size(142, 83);
			gp1.TabIndex = 4;
			gp1.TabStop = false;
			gp1.Text = "Increase or reduce";
			// 
			// btnExecute
			// 
			btnExecute.Enabled = false;
			btnExecute.Location = new Point(4, 51);
			btnExecute.Margin = new Padding(4, 3, 4, 3);
			btnExecute.Name = "btnExecute";
			btnExecute.Size = new Size(125, 28);
			btnExecute.TabIndex = 5;
			btnExecute.Text = "Execute";
			btnExecute.UseVisualStyleBackColor = true;
			btnExecute.Click += btnExecute_Click;
			// 
			// gp3
			// 
			gp3.Controls.Add(nudLength);
			gp3.Controls.Add(btnExecuteRect);
			gp3.Controls.Add(nudY2);
			gp3.Controls.Add(nudX2);
			gp3.Controls.Add(nudY);
			gp3.Controls.Add(nudX);
			gp3.Controls.Add(label3);
			gp3.Controls.Add(label4);
			gp3.Controls.Add(label2);
			gp3.Controls.Add(label1);
			gp3.Location = new Point(6, 256);
			gp3.Margin = new Padding(4, 3, 4, 3);
			gp3.Name = "gp3";
			gp3.Padding = new Padding(4, 3, 4, 3);
			gp3.Size = new Size(142, 233);
			gp3.TabIndex = 5;
			gp3.TabStop = false;
			gp3.Text = "Up/Down length barcode";
			// 
			// nudLength
			// 
			nudLength.Location = new Point(7, 164);
			nudLength.Margin = new Padding(4, 3, 4, 3);
			nudLength.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudLength.Name = "nudLength";
			nudLength.Size = new Size(122, 23);
			nudLength.TabIndex = 17;
			nudLength.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// btnExecuteRect
			// 
			btnExecuteRect.Location = new Point(5, 195);
			btnExecuteRect.Margin = new Padding(4, 3, 4, 3);
			btnExecuteRect.Name = "btnExecuteRect";
			btnExecuteRect.Size = new Size(125, 31);
			btnExecuteRect.TabIndex = 14;
			btnExecuteRect.Text = "Execute";
			btnExecuteRect.UseVisualStyleBackColor = true;
			btnExecuteRect.Click += btnExecuteRect_Click;
			// 
			// nudY2
			// 
			nudY2.Location = new Point(58, 133);
			nudY2.Margin = new Padding(4, 3, 4, 3);
			nudY2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudY2.Name = "nudY2";
			nudY2.Size = new Size(71, 23);
			nudY2.TabIndex = 13;
			nudY2.Value = new decimal(new int[] { 20, 0, 0, 0 });
			nudY2.ValueChanged += nudX_ValueChanged;
			// 
			// nudX2
			// 
			nudX2.Location = new Point(58, 103);
			nudX2.Margin = new Padding(4, 3, 4, 3);
			nudX2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudX2.Name = "nudX2";
			nudX2.Size = new Size(71, 23);
			nudX2.TabIndex = 12;
			nudX2.Value = new decimal(new int[] { 10, 0, 0, 0 });
			nudX2.ValueChanged += nudX_ValueChanged;
			// 
			// nudY
			// 
			nudY.Location = new Point(29, 74);
			nudY.Margin = new Padding(4, 3, 4, 3);
			nudY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudY.Name = "nudY";
			nudY.Size = new Size(100, 23);
			nudY.TabIndex = 11;
			nudY.Value = new decimal(new int[] { 20, 0, 0, 0 });
			nudY.ValueChanged += nudX_ValueChanged;
			// 
			// nudX
			// 
			nudX.Location = new Point(29, 45);
			nudX.Margin = new Padding(4, 3, 4, 3);
			nudX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudX.Name = "nudX";
			nudX.Size = new Size(100, 23);
			nudX.TabIndex = 10;
			nudX.Value = new decimal(new int[] { 10, 0, 0, 0 });
			nudX.ValueChanged += nudX_ValueChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(7, 134);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(46, 15);
			label3.TabIndex = 3;
			label3.Text = "Height:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 105);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(42, 15);
			label4.TabIndex = 2;
			label4.Text = "Width:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 76);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(17, 15);
			label2.TabIndex = 1;
			label2.Text = "Y:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 47);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(17, 15);
			label1.TabIndex = 0;
			label1.Text = "X:";
			// 
			// button1
			// 
			button1.Location = new Point(7, 23);
			button1.Margin = new Padding(4, 3, 4, 3);
			button1.Name = "button1";
			button1.Size = new Size(138, 52);
			button1.TabIndex = 9;
			button1.Text = "Open image";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(2, 96);
			button2.Margin = new Padding(4, 3, 4, 3);
			button2.Name = "button2";
			button2.Size = new Size(138, 52);
			button2.TabIndex = 9;
			button2.Text = "Clue";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// btnToGrey
			// 
			btnToGrey.Location = new Point(299, 23);
			btnToGrey.Margin = new Padding(4, 3, 4, 3);
			btnToGrey.Name = "btnToGrey";
			btnToGrey.Size = new Size(138, 52);
			btnToGrey.TabIndex = 12;
			btnToGrey.Text = "From RGB to black-white";
			btnToGrey.UseVisualStyleBackColor = true;
			btnToGrey.Click += btnToGrey_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btnInversion);
			groupBox3.Controls.Add(button1);
			groupBox3.Controls.Add(btnToGrey);
			groupBox3.Location = new Point(156, 600);
			groupBox3.Margin = new Padding(4, 3, 4, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(4, 3, 4, 3);
			groupBox3.Size = new Size(1018, 91);
			groupBox3.TabIndex = 13;
			groupBox3.TabStop = false;
			groupBox3.Text = "Options";
			// 
			// btnInversion
			// 
			btnInversion.Location = new Point(153, 23);
			btnInversion.Margin = new Padding(4, 3, 4, 3);
			btnInversion.Name = "btnInversion";
			btnInversion.Size = new Size(138, 52);
			btnInversion.TabIndex = 13;
			btnInversion.Text = "Inversion";
			btnInversion.UseVisualStyleBackColor = true;
			btnInversion.Click += btnInversion_Click;
			// 
			// gbMain
			// 
			gbMain.Controls.Add(pbMain);
			gbMain.Location = new Point(156, 42);
			gbMain.Margin = new Padding(4, 3, 4, 3);
			gbMain.Name = "gbMain";
			gbMain.Padding = new Padding(4, 3, 4, 3);
			gbMain.Size = new Size(1018, 548);
			gbMain.TabIndex = 11;
			gbMain.TabStop = false;
			gbMain.Text = "1 image";
			// 
			// pbMain
			// 
			pbMain.Location = new Point(8, 30);
			pbMain.Margin = new Padding(4, 3, 4, 3);
			pbMain.Name = "pbMain";
			pbMain.Size = new Size(1000, 500);
			pbMain.SizeMode = PictureBoxSizeMode.AutoSize;
			pbMain.TabIndex = 9;
			pbMain.TabStop = false;
			pbMain.Paint += pictureBox3_Paint;
			pbMain.MouseDown += pictureBox3_MouseDown;
			pbMain.MouseMove += pictureBox3_MouseMove;
			// 
			// gbClue
			// 
			gbClue.Controls.Add(rbSummer);
			gbClue.Controls.Add(rbMin);
			gbClue.Controls.Add(rbMax);
			gbClue.Controls.Add(button2);
			gbClue.Location = new Point(8, 496);
			gbClue.Name = "gbClue";
			gbClue.Size = new Size(140, 155);
			gbClue.TabIndex = 14;
			gbClue.TabStop = false;
			gbClue.Text = "Clue";
			// 
			// rbSummer
			// 
			rbSummer.AutoSize = true;
			rbSummer.Location = new Point(6, 22);
			rbSummer.Name = "rbSummer";
			rbSummer.Size = new Size(70, 19);
			rbSummer.TabIndex = 12;
			rbSummer.TabStop = true;
			rbSummer.Text = "Summer";
			rbSummer.UseVisualStyleBackColor = true;
			rbSummer.Click += rbSummer_Click;
			// 
			// rbMin
			// 
			rbMin.AutoSize = true;
			rbMin.Location = new Point(6, 71);
			rbMin.Name = "rbMin";
			rbMin.Size = new Size(46, 19);
			rbMin.TabIndex = 11;
			rbMin.TabStop = true;
			rbMin.Text = "Min";
			rbMin.UseVisualStyleBackColor = true;
			rbMin.Click += rbMin_Click;
			// 
			// rbMax
			// 
			rbMax.AutoSize = true;
			rbMax.Location = new Point(6, 46);
			rbMax.Name = "rbMax";
			rbMax.Size = new Size(48, 19);
			rbMax.TabIndex = 10;
			rbMax.TabStop = true;
			rbMax.Text = "Max";
			rbMax.UseVisualStyleBackColor = true;
			rbMax.Click += rbMax_Click;
			// 
			// tbIncDecVal
			// 
			tbIncDecVal.Location = new Point(5, 22);
			tbIncDecVal.Name = "tbIncDecVal";
			tbIncDecVal.Size = new Size(124, 23);
			tbIncDecVal.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1189, 697);
			Controls.Add(gbClue);
			Controls.Add(gbMain);
			Controls.Add(groupBox3);
			Controls.Add(gp3);
			Controls.Add(gp1);
			Controls.Add(gp2);
			FormStyle = FormStyles.ActionBar_None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Padding = new Padding(4, 28, 4, 3);
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Barcode Editor";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)nudLengthBarcode).EndInit();
			gp2.ResumeLayout(false);
			gp2.PerformLayout();
			gp1.ResumeLayout(false);
			gp1.PerformLayout();
			gp3.ResumeLayout(false);
			gp3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
			((System.ComponentModel.ISupportInitialize)nudY2).EndInit();
			((System.ComponentModel.ISupportInitialize)nudX2).EndInit();
			((System.ComponentModel.ISupportInitialize)nudY).EndInit();
			((System.ComponentModel.ISupportInitialize)nudX).EndInit();
			groupBox3.ResumeLayout(false);
			gbMain.ResumeLayout(false);
			gbMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
			gbClue.ResumeLayout(false);
			gbClue.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Button btnExecuteLength;
		private NumericUpDown nudLengthBarcode;
		private GroupBox gp2;
		private GroupBox gp1;
		private Button btnExecute;
		private GroupBox gp3;
		private PictureBox pictureBox2;
		private Button button1;
		private NumericUpDown nudY2;
		private NumericUpDown nudX2;
		private NumericUpDown nudY;
		private NumericUpDown nudX;
		private Label label3;
		private Label label4;
		private Label label2;
		private Label label1;
		private NumericUpDown nudLength;
		private Button btnExecuteRect;
		private GroupBox groupBox1;
		private GroupBox gbMain;
		private PictureBox pbMain;
		private Button button2;
		private Button btnToGrey;
		private GroupBox groupBox3;
		private Button btnInversion;
		private CheckBox chbSelectionLength;
		private TextBox tbRangeText;
		private GroupBox gbClue;
		private RadioButton rbSummer;
		private RadioButton rbMin;
		private RadioButton rbMax;
		private TextBox tbIncDecVal;
	}
}

