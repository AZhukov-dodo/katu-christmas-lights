namespace LightController
{
    public class Controller
    {
        private readonly int _width;
        private readonly int _height;
        private readonly bool[,] _matrix;

        public Controller(int width, int height)
        {
            _width = width;
            _height = height;
            _matrix = new bool[width, height];
        }

        public int GetTurnedOnAmount()
        {
            var result = 0;
            for (var i = 0; i < _width; i++)
            {
                for (var j = 0; j < _height; j++)
                {
                    result += _matrix[i, j] ? 1 : 0;
                }
            }

            return result;
        }

        public void TurnOnRange(int startI, int startJ, int endI, int endJ)
        {
            for (var i = startI; i <= endI; i++)
            {
                for (var j = startJ; j <= endJ; j++)
                {
                    _matrix[i, j] = true;
                }
            }
        }

        public void TurnOffRange(int startI, int startJ, int endI, int endJ)
        {
            for (var i = startI; i <= endI; i++)
            {
                for (var j = startJ; j <= endJ; j++)
                {
                    _matrix[i, j] = false;
                }
            }
        }

        public void ToggleRange(int startI, int startJ, int endI, int endJ)
        {
            for (var i = startI; i <= endI; i++)
            {
                for (var j = startJ; j <= endJ; j++)
                {
                    _matrix[i, j] = !_matrix[i, j];
                }
            }
        }
    }
}