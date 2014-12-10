using System;
using System.Threading;

class Ship
{
  public int w;
  public int h;
  // Position of Ship
  public int x;

  public Ship(int ww, int hh)
  {
    w=ww;
    h=hh; 
  }

  public void Move(int xx)
  {
    x=xx;
    Console.SetCursorPosition(xx, h-8);
    Console.Write("     / \\     ");
    Console.SetCursorPosition(xx, h-7);
    Console.Write("    (   )     ");
    Console.SetCursorPosition(xx, h-6);
    Console.Write("    (   )     ");
    Console.SetCursorPosition(xx, h-5);
    Console.Write("   /|/ \\|\\  ");
    Console.SetCursorPosition(xx, h-4);
    Console.Write("  /_|| ||_\\  ");

    Console.SetCursorPosition(w-1,h-3);
  }

}

