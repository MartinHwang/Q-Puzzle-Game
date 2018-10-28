using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHassignment
{
    public partial class MazeDesigner : Form
    {
        private const int LEFT = 150;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int TOP = 100;
        private const int VGAP = 20;
        int r;
        int c;
        Tile[,] g;
        string message;
        /// <summary>
        /// Enum for selecting tool
        /// </summary>
        enum ImageType
        {
            none = 0,
            wall,
            redDoor,
            greenDoor,
            blueDoor,
            yellowDoor,
            redBox,
            greenBox,
            blueBox,
            yellowBox
        }

        public MazeDesigner()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event hander of button Generate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Check_Num(txtRows.Text, txtColumns.Text);
                Grid(r, c);
                txtColumns.Enabled = false;
                txtRows.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Check if input row and column are smaller than 0
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public void Check_Num(string r, string c)
        {
            message = "";
            if (Regex.IsMatch(r, "^[a-zA-Z]{1,}$")
                || txtRows.Text == "" || 
                Regex.IsMatch(c, "^[a-zA-Z]{1,}$")
                || txtColumns.Text == "")
            {
                message = "Please input valid number";
                throw new Exception(message);
            }
            else
            {
                this.r = int.Parse(r);
                this.c = int.Parse(c);
            }
            
            if(this.r <= 0 || this.c <= 0)
            {
                message = "Number must be bigger than 0";
                throw new Exception(message);
            }
        }
        /// <summary>
        /// Make the grid which row and column are input
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        public void Grid(int r, int c)
        {
            g = new Tile[r, c];
            int x = LEFT;
            int y = TOP;
            for (int i = 0; i < g.GetLength(0); i++)
            {
                for (int j = 0; j < g.GetLength(1); j++)
                {
                    g[i, j] = new Tile();
                    g[i, j].Left = x;
                    g[i, j].Top = y;
                    g[i, j].Width = WIDTH;
                    g[i, j].Height = HEIGHT;
                    g[i, j].BorderStyle = BorderStyle.Fixed3D;
                    g[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    g[i, j].Click += Tile_Click;
                    this.Controls.Add(g[i, j]); //very important
                    g[i, j].row = i;
                    g[i, j].col = j;
                    g[i, j].tileImage = 0;
                    x += WIDTH;
                }
                x = LEFT;
                y += WIDTH;
            }
        }

        ImageType imageType = new ImageType();
        /// <summary>
        /// Event hander of selecting each cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tile_Click(object sender, EventArgs e)
        {
            Tile t = (Tile)sender;

            switch (imageType)
            {
                case ImageType.none:
                    t.Image = null;
                    break;
                case ImageType.wall:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.wall;
                        t.tileImage = (int)ImageType.wall;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.redDoor:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.redDoor;
                        t.tileImage = (int)ImageType.redDoor;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.greenDoor:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.greenDoor;
                        t.tileImage = (int)ImageType.greenDoor;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.blueDoor:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.blueDoor;
                        t.tileImage = (int)ImageType.blueDoor;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.yellowDoor:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.yelloowDoor;
                        t.tileImage = (int)ImageType.yellowDoor;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.redBox:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.redBox;
                        t.tileImage = (int)ImageType.redBox;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;

                    }
                    break;
                case ImageType.greenBox:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.greenBox;
                        t.tileImage = (int)ImageType.greenBox;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.blueBox:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.blueBox;
                        t.tileImage = (int)ImageType.blueBox;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                case ImageType.yellowBox:
                    if (t.tileImage != (int)imageType)
                    {
                        t.Image = Properties.Resources.yellowBox;
                        t.tileImage = (int)ImageType.yellowBox;
                    }
                    else
                    {
                        t.Image = null;
                        t.tileImage = (int)ImageType.none;
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Event hander of selecting button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btnNone":
                    imageType = ImageType.none;
                    break;
                case "btnWall":
                    imageType = ImageType.wall;
                    break;
                case "btnRedDoor":
                    imageType = ImageType.redDoor;
                    break;
                case "btnGreenDoor":
                    imageType = ImageType.greenDoor;
                    break;
                case "btnBlueDoor":
                    imageType = ImageType.blueDoor;
                    break;
                case "btnYellowDoor":
                    imageType = ImageType.yellowDoor;
                    break;
                case "btnRedBox":
                    imageType = ImageType.redBox;
                    break;
                case "btnGreenBox":
                    imageType = ImageType.greenBox;
                    break;
                case "btnBlueBox":
                    imageType = ImageType.blueBox;
                    break;
                case "btnYellowBox":
                    imageType = ImageType.yellowBox;
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// Save grid and selected tool information
        /// </summary>
        /// <param name="fileName"></param>
        private void Save(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            r = int.Parse(txtRows.Text);
            c = int.Parse(txtColumns.Text);
            sw.WriteLine(r);
            sw.WriteLine(c);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    sw.WriteLine(g[i, j].row);
                    sw.WriteLine(g[i, j].col);
                    sw.WriteLine(g[i, j].tileImage);
                }
            }
            sw.Close();
            txtColumns.Enabled = true;
            txtRows.Enabled = true;
            txtColumns.Text = "";
            txtRows.Text = "";
            for (int i = 0; i < g.GetLength(0); i++)
            {
                for (int j = 0; j < g.GetLength(1); j++)
                {
                    g[i,j].Dispose();
                }
            }
        }
        /// <summary>
        /// Click event hander of the Save FileToolStripMenuItem 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtRows.Text) != "" || (txtColumns.Text) != "")
            {
                DialogResult d = SaveFileDialog.ShowDialog();
                switch (d)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        string fileName = SaveFileDialog.FileName;
                        Save(fileName);
                        MessageBox.Show($"Saved {fileName} successfully", 
                            "Save");
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
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter Rows and Columns you want to make",
                    "Information");
            }
        }
        /// <summary>
        /// Click event hander of the Close FileToolStripMenuItem 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
