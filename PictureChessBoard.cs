using System.Collections.Generic;
using System.Drawing;

namespace Элегантный_объект
{
    public interface ChessImage
    {
        Bitmap Image();
    } 

    public class PictureChessBoard: ChessImage
    {
        private List<int> _position;
        private Bitmap _view;
        public PictureChessBoard(List<int> p, BoardView board)
        {
            _position = p;
            _view = board.View();
        }
        public Bitmap Image()
        {
            Bitmap _bitmap = _view;
            return _bitmap;
        }
    }
}
