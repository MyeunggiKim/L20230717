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
                { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                { 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1},
                { 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1},
                { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1},
                { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1},
                { 1, 0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1},
                { 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1},
                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1},
                { 1, 0, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1},
                { 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1},
                { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1},
                { 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1},
                { 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 1},
                { 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1},
                { 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1},
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1},
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
            int randomY = numberY.Next(2, 19);
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
                    case ConsoleKey. DownArrow:
                        playerX++;
                        break;
                    case ConsoleKey.UpArrow:
                        playerX--;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerY--;
                        break;
                    case ConsoleKey.RightArrow:
                        playerY++;
                        break;
                }
                if (map[playerX, playerY] == 1)
                //플레이어가 맵밖으로 안나가게 하는 코드
                // map[player1,player2] 좌표에 1이 존제할 경우
                //입력키의 반대방향으로 이동하게 하여 강제로 맵안에 있도록 유지시킨다
                {
                    switch (info.Key)
                    {
                        case ConsoleKey.DownArrow:
                            playerX--;
                            break;
                        case ConsoleKey.UpArrow:
                            playerX++;
                            break;
                        case ConsoleKey.LeftArrow: 
                            playerY++;
                            break;
                        case ConsoleKey.RightArrow:
                            playerY--;
                            break;
                    }
                }

                Console.Clear();
                //화면 초기화로 기존의 필드가 화면에 남지 않게 하기


                //print()
                for (int x = 0; x < 20; x++)
                {
                    
                    for (int y = 0; y < 20; y++)
                    {
                        if (playerX == x && playerY == y)
                        // &&를 안쓰면 한줄이 전부 P로 바뀌게 된다.
                        // else를 쓰지 않으면 한칸에 2가지 경우 적용되어 한칸씩 밀리게 된다.
                        {
                            Console.Write("P ");
                        }
                        else if ((y == 17 && x == 18))
                        {
                            Console.Write("G" + " ");
                        } 
                        //좌표값에 x,y반대로 입력하면 맵이 돌아가는 개판이 일어난다
                        //주의 할것.
                        else if (map[x, y] == 1)
                        {
                            Console.Write("*" + " ");
                        }
                        else if (map[x, y] == 0)
                        {
                            Console.Write(" " + " ");
                        }
                        if (playerX == gx && playerY == gy)
                        {
                            Console.WriteLine("Game Clear!");
                            break;
                            //루프를 중단 하지 않으면 메시지 반복 출력
                        }
                    }
                    Console.WriteLine();
                    if (playerX == 18 && playerY == 17)
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
