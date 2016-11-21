using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_RekursiveChess
{
    class Program
    {
        private static bool[,] boardBools= new bool[8,8];
        public static void Main(string[] argStrings)
        {
            for (int i = 0; i < 8; i++)
            {
                if (Try(boardBools, i))
                    Print();
            }
            
            Console.ReadKey();

        }
        public static bool Try(bool[,] board, int x)
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                if (IsAllowed(board, x, y))
                {
                    board[x, y] = true;
                    if (x == board.GetLength(0) - 1 || Try(board, x + 1))
                    {
                        return true;
                    }
                    board[x, y] = false;
                }
            }
            return false;
        }
        //verify diagonals, column and row from i=0 to x because from x to down it dont put anything
        private static bool IsAllowed(bool[,] board, int x, int y)
        {
            for (int i = 0; i <= x; i++)
            {
                if (board[i, y] || (i <= y && board[x - i, y - i]) || (y + i < board.GetLength(0) && board[x - i, y + i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static void Print()
        {
            for (int i=0;i< boardBools.GetLength(0);i++)
            {
                for (int j= 0; j < boardBools.GetLength(0); j++)
                {

                    if(boardBools[i,j])
                        Console.Write('O');
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.Write('\n');
            }
        }
    }
}
