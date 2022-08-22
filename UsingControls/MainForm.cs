using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControls
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Console.WriteLine(" >>> MainForm_Load Execute!!!");
			var Fonts = FontFamily.Families;
			foreach(FontFamily font in Fonts)
			{
				cboFont.Items.Add(font.Name);
			}
		}

		private void cboFont_Click(object sender, EventArgs e)
		{
			Console.WriteLine(" >>> cboFont_Click Execute!!!");
			cboFont_SelectedIndexChanged(sender, e);
		}

		private void chkBold_Click(object sender, EventArgs e)
		{
			Console.WriteLine(" >>> chkBold_Click Execute!!!");
			chkBold_CheckedChanged(sender, e);
		}

		private void chkItalic_Click(object sender, EventArgs e)
		{
		}

		private void chkItalic_Click_1(object sender, EventArgs e)
		{
			Console.WriteLine(" >>> chkItalic_Click Execute!!!");
			chkItalic_CheckedChanged(sender, e);
		}

		void ChangeFont() {
			if(cboFont.SelectedIndex < 0)
			{
				return;
			}

			// FontStyle Init.
			FontStyle style = FontStyle.Regular;
			
			if(chkBold.Checked)
			{
				style |= FontStyle.Bold;
			}
			if(chkItalic.Checked)
			{
				style |= FontStyle.Italic;
			}

			Console.WriteLine("String -> cboFont.selectedItem");
			Console.WriteLine((string)cboFont.SelectedItem);
			txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
		}

		private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChangeFont();
		}

		private void chkBold_CheckedChanged(object sender, EventArgs e)
		{
			Console.WriteLine(" >> chkBold_CheckedChanged Execute!!!");
			ChangeFont();
		}

		private void chkItalic_CheckedChanged(object sender, EventArgs e)
		{
			
			ChangeFont();
		}

		private void grpFont_Enter(object sender, EventArgs e)
		{

		}

		
	}
}
