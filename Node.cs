using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AI_Lab3
{
    public class Node : IComparable<Node>
    {
        public Queue<Node> Path { get; set; }
        public Move Move { get; set; }
        public int Evaluation { get; set; }
        public List<Node> Nodes { get; set; }

        private bool _evaluated = false;
        public Node(Move move, Queue<Node> path)
        {
            Path = new Queue<Node>(path);
            Move = move;
            Evaluation = -1;
            Nodes = new List<Node>();
            Path.Enqueue(this);
        }

        public void AddNodes(Stratego game)
        {
            bool[,] tmpBoard = (bool[,])game.Board.Clone();
            foreach (Node node in Path)
            {
                tmpBoard[node.Move.X, node.Move.Y] = true;
            }

            for (int i = 0; i < game.SizeOfSide; i++)
            {
                for (int j = 0; j < game.SizeOfSide; j++)
                {
                    if (!tmpBoard[i, j])
                    {
                        Nodes.Add(new Node(new Move(i, j), Path));
                    }
                }
            }

            foreach (Node node in Nodes)
            {
                node.Move.CalculateScore(node.Path, game);
                if (game.Deep > node.Path.Count && game.NumberOfMoves - game.MovesDone > node.Path.Count)
                {
                    node.AddNodes(game);
                }
            }
        }

        public int Evaluate(bool isMax)
        {
            int result = 0;



            _evaluated = true;

            if (Nodes.Count > 0)
            {
                foreach (Node node in Nodes)
                {
                    node.Evaluate(!isMax);
                }
                Nodes.Sort();
                result = isMax ? Nodes[0].Evaluation : Nodes[Nodes.Count - 1].Evaluation;
            }

            result += isMax ? Move.Score : -Move.Score;

            Evaluation = result;
            return result;
        }
        public int Evaluate(bool isMax, int alfa, int beta)
        {
            int result = 0;

            _evaluated = true;


            if (Nodes.Count > 0)
            {
                if (isMax)
                {
                    int best = Int32.MinValue;
                    foreach (Node node in Nodes)
                    {
                        node.Evaluate(!isMax, alfa, beta);
                        best = node.Evaluation > best ? node.Evaluation : best;
                        alfa = best > alfa ? best : alfa;
                        if(beta <= alfa)
                            break;
                    }

                    Evaluation = best;
                    result = best;
                }
                else
                {
                    int best = Int32.MaxValue; ;
                    foreach (Node node in Nodes)
                    {
                        node.Evaluate(!isMax, alfa, beta);
                        best = node.Evaluation < best ? node.Evaluation : best;
                        beta = best < beta ? best : beta;
                        if(beta <= alfa)
                            break;
                        
                    }
                    result = best;
                }

            }
            result += isMax ? Move.Score : -Move.Score;

            Evaluation = result;
            return result;
        }

        public int CompareTo(Node other)
        {
            if (Evaluation == other.Evaluation)
                return Move.CompareTo(other.Move);
            return Evaluation.CompareTo(other.Evaluation);
        }
    }
}