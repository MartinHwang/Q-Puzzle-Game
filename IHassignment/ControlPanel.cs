using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHassignment
{
    /// <summary>
    /// 
    /// </summary>
    public partial class QGCPanel : Form
    {
        public QGCPanel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event hander of the btnExit button  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (r)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Thank you", "Message");
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Click event hander of btnDesign button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            MazeDesigner md = new MazeDesigner();
            md.ShowDialog();
        }
        /// <summary>
        /// Click event hander of btnplay button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
