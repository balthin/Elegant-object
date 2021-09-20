using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Элегантный_объект
{
    public partial class Main : Form
    {
        private PictureChessBoard chessBoard;
        private SmallBoard smallBoard;
        public Main()
        {
            InitializeComponent();
            chessBoard = new PictureChessBoard(new List<int>(), new SilverBoard());
            smallBoard = new SmallBoard(chessBoard);
            pictureBoard.BackgroundImage = new SmallBorder(new SilverBorder()).Image();
            pictureBoard.Image = smallBoard.Image();
        }
    }
}
