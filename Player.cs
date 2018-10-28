namespace AI_Lab3
{
    public class Player
    {
        public int Score { get; set; }
        public bool IsHuman { get; }

        private IAlgorithm _algorithm;

        public Player(IAlgorithm algorithm = null, bool isHuman = true)
        {
            Score = 0;
            IsHuman = isHuman;
            _algorithm = algorithm;
        }

        public void AddScore(int value)
        {
            Score += value;
        }

        public Move GetMove(Stratego game)
        {
            if (!IsHuman)
                return _algorithm.MakeMove(game);
            else
                return new Move(0, 0); // todo
        }
    }
}