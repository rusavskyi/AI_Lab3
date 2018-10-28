using System;
using System.Collections.Generic;

namespace AI_Lab3
{
    public class MinMax : IAlgorithm  
    {
        public bool UseRandomForEqual { get; set; }

        public Move MakeMove(Stratego game)
        {
            List<Node> posibleMoves = new List<Node>();

            for (int i = 0; i < game.SizeOfSide; i++)
            {
                for (int j = 0; j < game.SizeOfSide; j++)
                {
                    if (!game.Board[i, j])
                    {
                        posibleMoves.Add(new Node(new Move(i, j), new Queue<Node>()));
                    }
                }
            }

            foreach (Node node in posibleMoves)
            {
                node.Move.CalculateScore(node.Path, game);
                if (game.Deep > node.Path.Count && game.NumberOfMoves - game.MovesDone > node.Path.Count)
                {
                    node.AddNodes(game);
                }

                node.Evaluate(true);
                Node tmp = node;
                bool fliper = true;
                while (tmp.Nodes.Count > 0)
                {
                    //Console.Write("e: {0}, ms: {1}, x: {2}, y: {3} <-", tmp.Evaluation, tmp.Move.Score, tmp.Move.X, tmp.Move.Y);
                    tmp = fliper ? tmp.Nodes[0] : tmp.Nodes[tmp.Nodes.Count - 1];

                    fliper = !fliper;
                }
                //Console.ReadKey();
                //Console.WriteLine();
            }

            posibleMoves.Sort();

            int resultIndex = posibleMoves.Count - 1;

            if (UseRandomForEqual)
            {
                int i = resultIndex;
                for (; i >= 0; i--)
                {
                    if (posibleMoves[i].Evaluation != posibleMoves[resultIndex].Evaluation)
                    {
                        break;
                    }
                }
                Random random = new Random(DateTime.Now.GetHashCode());
                if (i < 0) i = 0;
                resultIndex = random.Next(i, posibleMoves.Count);
            }

            Console.WriteLine("min:" + posibleMoves[0].Evaluation + " max:" + posibleMoves[resultIndex].Evaluation +
                              " " + posibleMoves[resultIndex].Move.X + " " + posibleMoves[resultIndex].Move.Y);
            return posibleMoves[resultIndex].Move;
        }


    }
}