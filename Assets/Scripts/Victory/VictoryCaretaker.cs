namespace Sokobun.Victory
{
    public class VictoryCaretaker
    {
        private int _pressedTilesNumber;
        private readonly int _maxTilesNumber;
        public bool IsWin => _pressedTilesNumber == _maxTilesNumber;
        public VictoryCaretaker(int maxTilesNumber)
        {            
            _maxTilesNumber = maxTilesNumber;
        }
        public void OnPressTile() => _pressedTilesNumber++;
        public void OnReleaseTile() => _pressedTilesNumber--;
    }
}
