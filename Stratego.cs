using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AI_Lab3
{
    public class Stratego
    {
        public bool[,] Board { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public int MovesDone { get; protected set; }
        public int Deep { get; set; }
        public int SizeOfSide { get; }

        private Player[] _players;

        public Stratego()
        {
            SizeOfSide = 10;
            Initialization();
        }

        public Stratego(int sizeOfSide)
        {
            SizeOfSide = sizeOfSide;
            Initialization();
        }

        public void SetPlayers(Player playerOne, Player playerTwo)
        {
            _players[0] = playerOne;
            _players[1] = playerTwo;
        }

        public void Reinit()
        {
            _players[0].Score = 0;
            _players[1].Score = 0;
            MovesDone = 0;
            for (int i = 0; i < SizeOfSide; i++)
            {
                for (int j = 0; j < SizeOfSide; j++)
                {
                    Board[i, j] = false;
                }
            }
        }

        public int GetWinner()
        {
            if (_players[0].Score > _players[1].Score) return 0;
            if (_players[0].Score < _players[1].Score) return 1;
            return -1;
        }

        public void Start()
        {
            int selectedDeep = Deep;
            if (!_players[0].IsHuman && !_players[1].IsHuman)
            {
                while (MovesDone < NumberOfMoves)
                {
                    for (int i = 0; i < _players.Length && MovesDone < NumberOfMoves; i++, MovesDone++)
                    {
                        Deep = ((float)MovesDone / (float)NumberOfMoves) < 0.3f ? 4 : selectedDeep;
                        Move move = _players[i].GetMove(this);
                        Board[move.X, move.Y] = true;
                        _players[i].AddScore(CalculateScore(move.X, move.Y, SizeOfSide, Board));

                        Console.WriteLine(ToString());
                        //Console.ReadKey();
                    }
                }
            }
        }

        public static int CalculateScore(int x, int y, int size, bool[,] board)
        {
            int result = 0;
            int counter = 0, tmpX = 0, tmpY = 0;
            bool ok = true;

            // vertical
            for (int i = 0; i < size && ok; i++)
            {
                ok = board[i, y];
            }

            if (ok) result += size;
            ok = true;

            // horizontal
            for (int i = 0; i < size && ok; i++)
            {
                ok = board[x, i];
            }

            if (ok) result += size;
            ok = true;


            // diagonal 1
            tmpX = x;
            tmpY = y;
            while (tmpX > 0 && tmpY > 0)
            {
                tmpX--;
                tmpY--;
            }

            for (int xi = tmpX, yi = tmpY; xi < size && yi < size && ok; xi++, yi++)
            {
                counter++;
                ok = board[xi, yi];
            }

            if (ok && counter > 1) result += counter;
            ok = true;

            // diagonal 2
            tmpX = x;
            tmpY = y;
            while (tmpX < size - 1 && tmpY > 0)
            {
                tmpX++;
                tmpY--;
            }

            counter = 0;
            for (int xi = tmpX, yi = tmpY; xi >= 0 && yi < size && ok; xi--, yi++)
            {
                counter++;
                ok = board[xi, yi];
            }

            if (ok && counter > 1) result += counter;
            if (result < 2) result = 0;

            return result;
        }

        public static int CalculateScore(int x, int y, int size, bool[,] board, List<Move> previousMoves)
        {
            bool[,] tmpBoard = (bool[,])board.Clone();
            foreach (Move move in previousMoves)
            {
                tmpBoard[move.X, move.Y] = true;
            }

            tmpBoard[x, y] = true;
            int result = 0;
            int counter = 0, tmpX = 0, tmpY = 0;
            bool ok = true;

            // vertical
            for (int i = 0; i < size && ok; i++)
            {
                ok = tmpBoard[i, y];
            }

            if (ok) result += size;
            ok = true;

            // horizontal
            for (int i = 0; i < size && ok; i++)
            {
                ok = tmpBoard[x, i];
            }

            if (ok) result += size;
            ok = true;


            // diagonal 1
            tmpX = x;
            tmpY = y;
            while (tmpX > 0 && tmpY > 0)
            {
                tmpX--;
                tmpY--;
            }

            for (int xi = tmpX, yi = tmpY; xi < size && yi < size && ok; xi++, yi++)
            {
                counter++;
                ok = tmpBoard[xi, yi];
            }

            if (ok && counter > 1) result += counter;
            ok = true;

            // diagonal 2
            tmpX = x;
            tmpY = y;
            while (tmpX < size - 1 && tmpY > 0)
            {
                tmpX++;
                tmpY--;
            }

            counter = 0;
            for (int xi = tmpX, yi = tmpY; xi >= 0 && yi < size && ok; xi--, yi++)
            {
                counter++;
                ok = tmpBoard[xi, yi];
            }

            if (ok && counter > 1) result += counter;
            if (result < 2) result = 0;
            return result;
        }

        private void Initialization()
        {
            MovesDone = 0;
            NumberOfMoves = SizeOfSide * SizeOfSide;
            Board = new bool[SizeOfSide, SizeOfSide];
            for (int i = 0; i < SizeOfSide; i++)
            {
                for (int j = 0; j < SizeOfSide; j++)
                {
                    Board[i, j] = false;
                }
            }
            _players = new Player[2];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(String.Empty);
            for (int j = 0; j < SizeOfSide; j++)
            {
                for (int i = 0; i < SizeOfSide; i++)
                {
                    stringBuilder.Append(Board[j, i] ? "1 " : "0 ");
                }

                stringBuilder.Append("\n");
            }

            stringBuilder.Append("Move: ");
            stringBuilder.Append(MovesDone + 1);
            stringBuilder.Append("\n");
            stringBuilder.Append("Player one score: ");
            stringBuilder.Append(_players[0].Score);
            stringBuilder.Append("\n");
            stringBuilder.Append("Player two score: ");
            stringBuilder.Append(_players[1].Score);
            stringBuilder.Append("\n");

            return stringBuilder.ToString();
        }
    }
}
