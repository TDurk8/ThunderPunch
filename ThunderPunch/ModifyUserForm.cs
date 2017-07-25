using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderPunch
{
    public partial class ModifyUserForm : Form
    {
        public ModifyUserForm()
        {
            InitializeComponent();
            tbctrlUser.DrawItem += new DrawItemEventHandler(tbctrlUser_DrawItem);
            SetDOB();
        }

        private void tbctrlUser_DrawItem(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tbctrlUser.TabPages[e.Index];
            Rectangle _tabBounds = tbctrlUser.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
                {

                    // Draw a different background color, and don't paint a focus rectangle.
                    _textBrush = new SolidBrush(Color.White);
                    g.FillRectangle(Brushes.SteelBlue, e.Bounds);
                }
            else
                {
                    _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.DarkSlateGray, e.Bounds);
                    //e.DrawBackground();
                }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)16.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
            
        }

        private void SetDOB()
        {
            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                cmboYear.Items.Add(i.ToString());
            }
            cmboYear.Text = DateTime.Now.Year.ToString();
            cmboYear.SelectedIndex = -1;
            
            for (int i= 1; i<=12; i++)
            {
                cmboDOBMonth.Items.Add(i.ToString());
            }
            cmboDOBMonth.Text = "1";
            cmboDOBMonth.Enabled = false;

            
        }

        private void cmboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboDOBMonth.Enabled = true;
        }

        private void cmboYear_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
