using System;
using System.Threading;

class ConsoleWindow 
{

  public static void Main()
  {
    Board board = new Board();
    board.DrawBoard();
    ConsoleKeyInfo cki = Console.ReadKey();
    int i = board.w/2;
    int thc = 0;
    Ship ship = new Ship(board.w, board.h);
    ship.Move(i);
    while (cki.Key != ConsoleKey.Escape)
    {
      if (cki.Key == ConsoleKey.RightArrow) {
        i = ship.Right();      
      }

      if (cki.Key == ConsoleKey.LeftArrow) {
        i = ship.Left();
      }
      thc = System.Diagnostics.Process.GetCurrentProcess().Threads.Count;
      if (cki.Key == ConsoleKey.Spacebar && thc < 9) {
        Projectile missle = new Projectile(i+6, board.h);
        Thread oMissle = new Thread(new ThreadStart(missle.Fire));
        oMissle.Start();
        //oMissle.Join();
      }
      cki = Console.ReadKey();
    }
  }
}
