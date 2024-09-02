namespace NumericTypeSuggestor
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
			MinValueLabel = new Label();
			MaxValueLabel = new Label();
			MinValueTextBox = new TextBox();
			MaxValueTextBox = new TextBox();
			IntegralOnlyCheckBox = new CheckBox();
			MustBePreciseCheckBox = new CheckBox();
			label3 = new Label();
			TypeLabel = new Label();
			SuspendLayout();
			// 
			// MinValueLabel
			// 
			MinValueLabel.AutoSize = true;
			MinValueLabel.Font = new Font("Segoe UI", 20F);
			MinValueLabel.Location = new Point(45, 50);
			MinValueLabel.Name = "MinValueLabel";
			MinValueLabel.Size = new Size(141, 37);
			MinValueLabel.TabIndex = 0;
			MinValueLabel.Text = "Min Value:";
			// 
			// MaxValueLabel
			// 
			MaxValueLabel.AutoSize = true;
			MaxValueLabel.Font = new Font("Segoe UI", 20F);
			MaxValueLabel.Location = new Point(41, 98);
			MaxValueLabel.Name = "MaxValueLabel";
			MaxValueLabel.Size = new Size(145, 37);
			MaxValueLabel.TabIndex = 1;
			MaxValueLabel.Text = "Max Value:";
			// 
			// MinValueTextBox
			// 
			MinValueTextBox.Font = new Font("Segoe UI", 20F);
			MinValueTextBox.Location = new Point(192, 47);
			MinValueTextBox.Name = "MinValueTextBox";
			MinValueTextBox.Size = new Size(581, 43);
			MinValueTextBox.TabIndex = 2;
			MinValueTextBox.TextChanged += MinValueTextBox_TextChanged;
			MinValueTextBox.KeyPress += MinValueTextBox_KeyPress;
			// 
			// MaxValueTextBox
			// 
			MaxValueTextBox.Font = new Font("Segoe UI", 20F);
			MaxValueTextBox.Location = new Point(192, 95);
			MaxValueTextBox.Name = "MaxValueTextBox";
			MaxValueTextBox.Size = new Size(581, 43);
			MaxValueTextBox.TabIndex = 3;
			MaxValueTextBox.TextChanged += MaxValueTextBox_TextChanged;
			MaxValueTextBox.KeyPress += MaxValueTextBox_KeyPress;
			// 
			// IntegralOnlyCheckBox
			// 
			IntegralOnlyCheckBox.AutoSize = true;
			IntegralOnlyCheckBox.CheckAlign = ContentAlignment.MiddleRight;
			IntegralOnlyCheckBox.Font = new Font("Segoe UI", 14F);
			IntegralOnlyCheckBox.Location = new Point(45, 195);
			IntegralOnlyCheckBox.Name = "IntegralOnlyCheckBox";
			IntegralOnlyCheckBox.Size = new Size(149, 29);
			IntegralOnlyCheckBox.TabIndex = 4;
			IntegralOnlyCheckBox.Text = "Integral Only?";
			IntegralOnlyCheckBox.TextAlign = ContentAlignment.MiddleRight;
			IntegralOnlyCheckBox.UseVisualStyleBackColor = true;
			IntegralOnlyCheckBox.CheckedChanged += IntegralOnlyCheckBox_CheckedChanged;
			// 
			// MustBePreciseCheckBox
			// 
			MustBePreciseCheckBox.AutoSize = true;
			MustBePreciseCheckBox.CheckAlign = ContentAlignment.MiddleRight;
			MustBePreciseCheckBox.Font = new Font("Segoe UI", 14F);
			MustBePreciseCheckBox.Location = new Point(94, 242);
			MustBePreciseCheckBox.Name = "MustBePreciseCheckBox";
			MustBePreciseCheckBox.Size = new Size(100, 29);
			MustBePreciseCheckBox.TabIndex = 5;
			MustBePreciseCheckBox.Text = "Precise?";
			MustBePreciseCheckBox.TextAlign = ContentAlignment.MiddleRight;
			MustBePreciseCheckBox.UseVisualStyleBackColor = true;
			MustBePreciseCheckBox.CheckedChanged += MustBePreciseCheckBox_CheckedChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
			label3.Location = new Point(107, 318);
			label3.Name = "label3";
			label3.Size = new Size(86, 37);
			label3.TabIndex = 6;
			label3.Text = "Type:";
			// 
			// TypeLabel
			// 
			TypeLabel.AutoSize = true;
			TypeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
			TypeLabel.Location = new Point(192, 318);
			TypeLabel.Name = "TypeLabel";
			TypeLabel.Size = new Size(230, 37);
			TypeLabel.TabIndex = 7;
			TypeLabel.Text = "not enough data";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(TypeLabel);
			Controls.Add(label3);
			Controls.Add(MustBePreciseCheckBox);
			Controls.Add(IntegralOnlyCheckBox);
			Controls.Add(MaxValueTextBox);
			Controls.Add(MinValueTextBox);
			Controls.Add(MaxValueLabel);
			Controls.Add(MinValueLabel);
			Name = "Form1";
			Text = "Numeric Type Suggester";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label MinValueLabel;
		private Label MaxValueLabel;
		private TextBox MinValueTextBox;
		private TextBox MaxValueTextBox;
		private CheckBox IntegralOnlyCheckBox;
		private CheckBox MustBePreciseCheckBox;
		private Label label3;
		private Label TypeLabel;
	}
}
