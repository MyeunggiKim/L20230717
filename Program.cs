using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] map =
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}

            };
            /*int cross = 0;
            for (cross = 0; cross < 10; cross++)
            {
                Console.Write(star[cross]);
            }*/

            int playerX = 1;
            int playerY = 1;

            Random numberX = new Random();
            int randomX = numberX.Next(2, 20);
            int randomX1 = numberX.Next(2, randomX);
            /*Console.WriteLine(randomX);*/

            Random numberY = new Random();
            int randomY = numberY.Next(2, 20);
            /*Console.WriteLine(randomY);*/

            int gx = randomX1;
            int gy = randomY;

            while (true)
            {
                //input()
                ConsoleKeyInfo info = Console.ReadKey(true);

                //Process()
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        playerX--;
                        break;
                    case ConsoleKey.UpArrow:
                        playerY--;
                        break;
                    case ConsoleKey.RightArrow:
                        playerX++;
                        break;
                    case ConsoleKey.DownArrow:
                        playerY++;
                        break;
                }

                Console.Clear();
                //화면 초기화로 기존의 필드가 화면에 남지 않게 하기


                //print()
                for (int y = 0; y < 20; y++)
                {
                    for (int x = 0; x < 20; x++)
                    {
                        if (playerX == x && playerY == y)
                        // &&를 안쓰면 한줄이 전부 P로 바뀌게 된다.
                        // else를 쓰지 않으면 한칸에 2가지 경우 적용되어 한칸씩 밀리게 된다.
                        {
                            Console.Write("P ");
                        }
                        else if ((y == gy && x == gx))
                        {
                            Console.Write("G" + " ");
                        }
                        else if (map[y, x] == 0)
                        {
                            Console.Write(" " + " ");
                        }
                        else if (map[y, x] == 1)
                        {
                            Console.Write("*" + " ");
                        }
                        if (playerX == gx && playerY == gy)
                        {
                            Console.WriteLine("Game Clear!");
                            break;
                            //루프를 중단 하지 않으면 메시지 반복 출력
                        }
                    }
                    Console.WriteLine();
                    if (playerX == gx && playerY == gy)
                    // 골도착시 맵생성 루프 중단
                    {
                        break;
                    }
                }
                if (playerX == gx && playerY == gy)
                //골 도착시 이동키 루프 중단
                {
                    break;
                }
            }
        }
    }
}
