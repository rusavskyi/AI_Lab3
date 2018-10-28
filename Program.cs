using System;
using System.Collections.Generic;

namespace AI_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerWinsTotal = 0, secondPlayerWinsTotal = 0;
            int firstPlayerWins = 0, secondPlayerWins = 0;

            Stratego stratego = new Stratego(5);
            stratego.Deep = 6;

            //stratego.SetPlayers(
            //    new Player(new AlfaBeta { UseRandomForEqual = false }, false),
            //    new Player(new AlfaBeta { UseRandomForEqual = false }, false)
            //    );
            double time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);

            //stratego = new Stratego(5);
            //stratego.Deep = 6;
            //stratego.SetPlayers(
            //    new Player(new AlfaBeta { UseRandomForEqual = true }, false),
            //    new Player(new AlfaBeta { UseRandomForEqual = true }, false)
            //);
            //firstPlayerWins = 0;
            //secondPlayerWins = 0;
            //time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);

            //stratego = new Stratego(5);
            //stratego.Deep = 6;
            //stratego.SetPlayers(
            //    new Player(new AlfaBeta() { UseRandomForEqual = true }, false),
            //    new Player(new AlfaBeta() { UseRandomForEqual = false }, false)
            //);
            //firstPlayerWins = 0;
            //secondPlayerWins = 0;
            //time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }

            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);

            //stratego = new Stratego(5);
            //stratego.Deep = 6;
            //stratego.SetPlayers(
            //    new Player(new AlfaBeta() { UseRandomForEqual = false }, false),
            //    new Player(new AlfaBeta() { UseRandomForEqual = true }, false)
            //);
            //firstPlayerWins = 0;
            //secondPlayerWins = 0;
            //time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);


            //stratego = new Stratego(5);
            //stratego.Deep = 6;
            //stratego.SetPlayers(
            //    new Player(new MinMax() { UseRandomForEqual = false }, false),
            //    new Player(new MinMax() { UseRandomForEqual = false }, false)
            //);
            //firstPlayerWins = 0;
            //secondPlayerWins = 0;
            //time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);

            //stratego = new Stratego(5);
            //stratego.Deep = 6;
            //stratego.SetPlayers(
            //    new Player(new MinMax() { UseRandomForEqual = true }, false),
            //    new Player(new MinMax() { UseRandomForEqual = true }, false)
            //);
            //firstPlayerWins = 0;
            //secondPlayerWins = 0;
            //time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);

            //stratego = new Stratego(5);
            //stratego.Deep = 6;
            //stratego.SetPlayers(
            //    new Player(new MinMax() { UseRandomForEqual = true }, false),
            //    new Player(new MinMax() { UseRandomForEqual = false }, false)
            //);
            //firstPlayerWins = 0;
            //secondPlayerWins = 0;
            //time = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    stratego.Reinit();
            //    DateTime start = DateTime.Now;
            //    stratego.Start();
            //    time += (DateTime.Now - start).TotalMilliseconds;
            //    Console.WriteLine(time);
            //    switch (stratego.GetWinner())
            //    {
            //        case 0:
            //            firstPlayerWins++;
            //            firstPlayerWinsTotal++;
            //            break;
            //        case 1:
            //            secondPlayerWins++;
            //            secondPlayerWinsTotal++;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //time /= 10;
            //Console.WriteLine(time);
            //Console.WriteLine("p1: {0}, p2: {1}", firstPlayerWins, secondPlayerWins);

            stratego = new Stratego(5);
            stratego.Deep = 6;
            stratego.SetPlayers(
                new Player(new MinMax() { UseRandomForEqual = false }, false),
                new Player(new MinMax() { UseRandomForEqual = true }, false)
            );
            time = 0;
                stratego.Reinit();
                DateTime start = DateTime.Now;
                stratego.Start();
                time += (DateTime.Now - start).TotalMilliseconds;
                Console.WriteLine(time);
            time /= 10;
            

        }
    }
}
