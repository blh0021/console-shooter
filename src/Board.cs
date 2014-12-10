using System;

class Board
{

  public int w;
  public int h;

  public Board()
  {
    w = Console.WindowWidth;
    h = Console.WindowHeight;
  }

  public void PrintWindowInfo()
  {
    int row, col;
    row = Console.CursorTop;
    col = Console.CursorLeft;
    Console.WriteLine("Width  = {0}",w);
    Console.WriteLine("Height = {0}",h);
    Console.WriteLine("Top    = {0}", row);
    Console.WriteLine("Left   = {0}", col);
  }

  public void PrintChar(int x, int y)
  {
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(x, y);
    Console.Write("|");
    Console.ResetColor();
  }

  public void PrintName()
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("       ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗");
    Console.WriteLine("      ██╔════╝██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝");
    Console.WriteLine("      ██║     ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗  ");
    Console.WriteLine("      ██║     ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝  "); 
    Console.WriteLine("      ╚██████╗╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗");
    Console.WriteLine("       ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝");
    Console.ResetColor();
  }

  public void DrawBoard()
  {
    Console.Clear();
    for (int i=0; i<w; i++) {
      PrintChar(i, 1); 
      PrintChar(i, h-1); 
    }
    for (int i=0; i<h; i++) {
      PrintChar(0, i);
      PrintChar(w-1, i);
    }
  }

}
