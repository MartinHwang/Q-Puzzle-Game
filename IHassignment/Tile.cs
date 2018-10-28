﻿using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHassignment
{
    /// <summary>
    /// Derived Class that inherits PictureBox
    /// </summary>
    class Tile: PictureBox
    {
        public int row;
        public int col;
        public int tileImage;
    }
}
