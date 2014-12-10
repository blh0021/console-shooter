using System;
using System.Threading;

class Projectile
{
  public int x;
  public int h;
  
  public Projectile(int xx, int hh)
  {
    x=xx;
    h=hh;
  }

  public void Fire()
  {
    Console.ForegroundColor = ConsoleColor.Red;
    for (int i=h-10; i>1; i--) {
      Console.SetCursorPosition(x, i);
      Console.Write("^");
      Console.SetCursorPosition(x, i+1);
      Thread.Sleep(5);
      Console.SetCursorPosition(x, i);
      Console.Write(" ");
    }
    Console.ResetColor();
  }
}


