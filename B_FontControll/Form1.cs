using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_FontControll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == tsbtnFont)
            {
                if (this.fontDlg.ShowDialog() == DialogResult.OK)
                {
                    this.rtbText.SelectionFont = this.fontDlg.Font;
                }
            }
            else if(e.ClickedItem == tsbtnColor)
            {
                if (this.colorDlg.ShowDialog() == DialogResult.OK)
                {
                    this.rtbText.SelectionColor = this.colorDlg.Color;
                }
            }
        }
    }
}
