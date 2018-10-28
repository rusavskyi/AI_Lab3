using System;
using System.Collections.Generic;

namespace AI_Lab3
{
    public class Move : IComparable<Move>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get; set; }

        public Move(int x, int y)
        {
            X = x;
            Y = y;
            Score = 0;
        }

        public void CalculateScore(Queue<Node> path, Stratego game)
        {
            List<Move> moves = new List<Move>();
            bool[,] tmpBoard = (bool[,])game.Board.Clone();
            foreach (Node node in path)
            {
                tmpBoard[node.Move.X, node.Move.Y] = true;
            }
            foreach (var node in path)
            {
                moves.Add(node.Move);
            }

            Score = Stratego.CalculateScore(X, Y, game.SizeOfSide, tmpBoard, moves);
        }

        public int CompareTo(Move other)
        {
            return Score.CompareTo(other.Score);
        }
    }
}