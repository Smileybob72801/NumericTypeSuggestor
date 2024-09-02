using Microsoft.VisualBasic;
using System.Numerics;

namespace NumericTypeSuggestor
{
	public partial class Form1 : Form
	{
		private BigInteger _minValue;
		private BigInteger _maxValue;

		public Form1()
		{
			InitializeComponent();
		}

		private void IntegralOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			bool IsChecked = IntegralOnlyCheckBox.Checked;

			if (IsChecked)
			{
				MustBePreciseCheckBox.Checked = false;
			}

			MustBePreciseCheckBox.Visible = !IsChecked;

			SetSuggestedTypeText(_minValue, _maxValue);
		}

		private void MustBePreciseCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			SetSuggestedTypeText(_minValue, _maxValue);
		}

		private void MinValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!IsValidChar((TextBox)sender, e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void MaxValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!IsValidChar((TextBox)sender , e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private static bool IsValidChar(TextBox textBox, char keyChar) =>
			char.IsControl(keyChar) ||
			char.IsDigit(keyChar) ||
			(keyChar.Equals('-') && textBox.SelectionStart == 0);

		private void SetSuggestedTypeText(BigInteger min, BigInteger max)
		{
			if (min > max)
				TypeLabel.Text = "min cannot be larger than max";
			else if (MinValueTextBox.Text.Length < 1 || MaxValueTextBox.Text.Length < 1)
				TypeLabel.Text = "not enough data";
			else if (IntegralOnlyCheckBox.Checked)
			{
				if (min >= byte.MinValue && max <= byte.MaxValue)
					TypeLabel.Text = "byte";
				else if (min >= sbyte.MinValue && max <= sbyte.MaxValue)
					TypeLabel.Text = "sbyte";
				else if (min >= ushort.MinValue && max <= ushort.MaxValue)
					TypeLabel.Text = "ushort";
				else if (min >= short.MinValue && max <= short.MaxValue)
					TypeLabel.Text = "short";
				else if (min >= uint.MinValue && max <= uint.MaxValue)
					TypeLabel.Text = "uint";
				else if (min >= int.MinValue && max <= int.MaxValue)
					TypeLabel.Text = "int";
				else if (min >= ulong.MinValue && max <= ulong.MaxValue)
					TypeLabel.Text = "ulong";
				else if (min >= long.MinValue && max <= long.MaxValue)
					TypeLabel.Text = "long";
				else
					TypeLabel.Text = "BigInteger";
			}
			else if (!IntegralOnlyCheckBox.Checked)
			{
				_ = double.TryParse(MinValueTextBox.Text, out double minAsDouble);
				_ = double.TryParse(MaxValueTextBox.Text, out double maxAsDouble);

				bool minDecimalParsed = decimal.TryParse(MinValueTextBox.Text, out decimal minAsDecimal);
				bool maxDecimalParsed = decimal.TryParse(MaxValueTextBox.Text, out decimal maxAsDecimal);

				if (!MustBePreciseCheckBox.Checked)
				{
					if (minAsDouble >= float.MinValue && maxAsDouble <= float.MaxValue)
						TypeLabel.Text = "float";
					else if (minAsDouble >= double.MinValue && maxAsDouble <= double.MaxValue)
						TypeLabel.Text = "double";
					else
						TypeLabel.Text = "Impossible representation";
				}
				else
				{
					if (minDecimalParsed &&
						maxDecimalParsed &&
						minAsDecimal >= decimal.MinValue &&
						maxAsDecimal <= decimal.MaxValue)
						TypeLabel.Text = "decimal";
					else
						TypeLabel.Text = "Impossible representation";
				}
			}
		}

		private void MinValueTextBox_TextChanged(object sender, EventArgs e)
		{
			if (MinValueTextBox.Text.Length > 0)
			{
				bool wasParsed = BigInteger.TryParse(MinValueTextBox.Text, out BigInteger result);

				if (wasParsed)
				{
					_minValue = result;
				}
			}
			else
			{
				_minValue = 0;
			}

			if (_minValue > _maxValue)
			{
				MaxValueTextBox.BackColor = Color.Red;
			}
			else
			{
				MaxValueTextBox.BackColor = Color.White;
			}

			SetSuggestedTypeText(_minValue, _maxValue);
		}

		private void MaxValueTextBox_TextChanged(object sender, EventArgs e)
		{
			if (MaxValueTextBox.Text.Length > 0)
			{
				bool wasParsed = BigInteger.TryParse(MaxValueTextBox.Text, out BigInteger result);

				if (wasParsed)
				{
					_maxValue = result;
				}
			}
			else
			{
				_maxValue = 0;
			}

			if (_minValue > _maxValue)
			{
				MaxValueTextBox.BackColor = Color.Red;
			}
			else
			{
				MaxValueTextBox.BackColor = Color.White;
			}

			SetSuggestedTypeText(_minValue, _maxValue);
		}
	}
}
