using System.Drawing;

namespace Элегантный_объект
{
    public class BoardSize
    {

    }
    public class SmallBoard: ChessImage
    {
        private Bitmap _chessBoard;
        private int _width,
                    _height,
                    _top,
                    _left;
        public SmallBoard(PictureChessBoard chessBoard)
        {
            _chessBoard = chessBoard.Image();
            _width = 320;
            _height = 320;
            _top = 0;
            _left = 0;
        }
        public Bitmap Image()
        {
            Bitmap _small = new Bitmap(_width, _height);
            _small.MakeTransparent();
            Graphics _graphicsBoard = Graphics.FromImage(_small);
            _graphicsBoard.DrawImage(_chessBoard, _top, _left, _width, _height);
            return _small;
        }
    }
    public class SmallBorder : ChessImage
    {
        private Bitmap _chessBoard;
        private int _width,
                    _height,
                    _top,
                    _left;
        public SmallBorder(BoardView chessBorder)
        {
            _chessBoard = chessBorder.View();
            _width = 360;
            _height = 360;
            _top = 0;
            _left = 0;
        }
        public Bitmap Image()
        {
            Bitmap _small = new Bitmap(_width, _height);
            Graphics _graphicsBoard = Graphics.FromImage(_small);
            _graphicsBoard.DrawImage(_chessBoard, _top, _left, _width, _height);
            return _small;
        }
    }
    
}
