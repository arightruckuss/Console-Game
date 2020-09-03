using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    //method changes the cursor position after users input
    public new static void UpdatePosition(string keyPressed, out int changeX,out int changeY)
    {
      switch(keyPressed)
      {
        case "LeftArrow":
          changeX = -1;
          changeY = 0;
          break;
        case "RightArrow":
          changeX = 1;
          changeY = 0;
          break;
        case "UpArrow":
          changeX = 0;
          changeY = -1;
          break;
        case "DownArrow":
          changeX = 0;
          changeY = 1;
          break;
        default:
          changeX = 0;
          changeY = 0;
          break;
      }
    }
    //method changes the cursor character after the users input
    public new static char UpdateCursor(string keyP)
      {
        switch(keyP)
        {
          case "LeftArrow":
            return '-';
          case "RightArrow":
            return '-';
          case "UpArrow":
            return '|';
          case "DownArrow":
            return '|';
          default:
            return '|';
        }
      }
     // 
     public new static int KeepInBounds(int currCord, int maxCord)
     {
       if (currCord > maxCord)
       {
         return maxCord - 1;
       }
       else if (currCord < 0)
       { 
        return maxCord - 1;
       }
       else
       {
         return currCord;
       }
    }
    public new static bool DidScore(int xChar, int yChar,int xFruit,int yFruit)
    {
      if (xChar == xFruit && yChar == yFruit)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}