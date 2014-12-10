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
    while (cki.Key != ConsoleKey.Escape)
    {
      if (cki.Key == ConsoleKey.RightArrow) {
        i=i+2;
        if (i>board.w-15){
          i=board.w-15;
        }
      }

      if (cki.Key == ConsoleKey.LeftArrow) {
        i = i - 2;
        if (i<=3) {
          i=3;
        }
      }
      ship.Move(i); 
      thc = System.Diagnostics.Process.GetCurrentProcess().Threads.Count;
      if (cki.Key == ConsoleKey.Spacebar && thc < 9) {
        Projectile missle = new Projectile(i+6, board.h);
        Thread oMissle = new Thread(new ThreadStart(missle.Fire));
        oMissle.Start();
        oMissle.Join();
      }
      cki = Console.ReadKey();
    }
  }
}
