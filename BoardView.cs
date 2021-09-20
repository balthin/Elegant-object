using System.Drawing;

namespace Элегантный_объект
{
    public interface BoardView
    {
        Bitmap View();
    }
    public class SilverBoard : BoardView
    {
        private Bitmap _imageSilverBoard;
        public SilverBoard()
        {
            _imageSilverBoard = Properties.Resources.board_silver;
        }
        public Bitmap View()
        {
            return _imageSilverBoard;
        }
    }
    public class GoldBoard : BoardView
    {
        private Bitmap _imageGoldBoard;
        public GoldBoard()
        {
            _imageGoldBoard = Properties.Resources.board_gold;
        }
        public Bitmap View()
        {
            return _imageGoldBoard;
        }
    }
    public class IronBoard : BoardView
    {
        private Bitmap _imageIronBoard;
        public IronBoard()
        {
            _imageIronBoard = Properties.Resources.board_iron;
        }
        public Bitmap View()
        {
            return _imageIronBoard;
        }
    }
    public class SilverBorder : BoardView
    {
        private Bitmap _imageSilverBorder;
        public SilverBorder()
        {
            _imageSilverBorder = Properties.Resources.bord_silver;
        }
        public Bitmap View()
        {
            return _imageSilverBorder;
        }
    }
    public class GoldBorder : BoardView
    {
        private Bitmap _imageGoldBorder;
        public GoldBorder()
        {
            _imageGoldBorder = Properties.Resources.bord_gold;
        }
        public Bitmap View()
        {
            return _imageGoldBorder;
        }
    }
    public class IronBorder : BoardView
    {
        private Bitmap _imageIronBorder;
        public IronBorder()
        {
            _imageIronBorder = Properties.Resources.bord_iron;
        }
        public Bitmap View()
        {
            return _imageIronBorder;
        }
    }
}
