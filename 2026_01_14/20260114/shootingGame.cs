using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20260114
{
    // 미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;

        public bool fire;
    }

    // 플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;

        public BULLET[] playerBullet = new BULLET[20]; // 미사일 20개 생성 후 준비된 미사일을 활용  -> Unity: 오브젝트 풀
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;

        // 아이템
        public Item item = new Item();
        public int itemCount = 0;

        public Player() // 플레이어 초기값
        {
            // 플레이어 좌표 위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) // 총알 20개 초기화
            {
                playerBullet[i] = new BULLET(); // 객체 생성
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET(); // 객체 생성
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET(); // 객체 생성
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        }


        public void GameMain()
        {
            // 키를 입력받는 부분
            KeyControl();

            // 플레이어를 그려주는 부분
            PlayerDraw();

            // UI 점수판
            UIscore();

            if(item.ItemLife)
            {
                item.ItemDraw();

                // 아이템 충돌
                CrashItem();
            }
        }

        // 아이템 충돌이 일어나면 양쪽으로 미사일 발사
        public void CrashItem()
        {
            if(playerY +1 == item.itemY)
            {
                if(playerX >= item.itemX-2 && playerX <= item.itemX +2)
                {
                    item.ItemLife = false;
                    if(itemCount < 3)
                    {
                        itemCount++;
                    }
                }
            }
        }

        public void KeyControl()
        {

            int pressKey;   // 정수형 변수 선언, 키값 받는 변수

            if (Console.KeyAvailable)
            {
                pressKey = _getch();

                if (pressKey == 224)        // 지연 줄이기
                    pressKey = _getch();

                switch (pressKey)
                {
                    case 72:    // 위
                        playerY--;
                        if (playerY < 1) playerY = 0;
                        break;

                    case 75:    // 왼쪽
                        playerX--;
                        if (playerX < 0) playerX = 0;
                        break;

                    case 77:    // 오른쪽
                        playerX++;
                        if (playerX > 75) playerX = 75;
                        break;
                    case 80:    // 아래
                        playerY++;
                        if (playerY > 21) playerY = 21;
                        break;
                    case 32:    // Space - 미사일 발사
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;

                                // 플레이어 앞에서 미사일 쏘기
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;

                                // 한 발씩 쏘겠다.
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;

                                // 플레이어 앞에서 미사일 쏘기
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY + 1+1; // 2번 미사일을 상단에서 나오게 하기 위해 y + 1

                                // 한 발씩 쏘겠다.
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;

                                // 플레이어 앞에서 미사일 쏘기
                                playerBullet3[i].x = playerX + 5; 
                                playerBullet3[i].y = playerY + 1 - 1;  // 3번미사일을 하단에서 나오게 하기 위해 y - 1

                                // 한 발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
        }

        // 미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    // 좌표 설정. 중간 위치 보정을 위해 x -1
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    Console.Write(bullet);

                    playerBullet[i].x++;    // 미사일 오른쪽으로 날리기
                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;   // 다시 준비 상태
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    // 좌표 설정. 중간 위치 보정을 위해 x -1, 
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    Console.Write(bullet);

                    playerBullet2[i].x++;    // 미사일 오른쪽으로 날리기
                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;   // 다시 준비 상태
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    // 좌표 설정. 중간 위치 보정을 위해 x -1, 
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    Console.Write(bullet);

                    playerBullet3[i].x++;    // 미사일 오른쪽으로 날리기
                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;   // 다시 준비 상태
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            string[] player =
            {
                "->",
                ">>>",
                "->"
            };  // 배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        // 충돌 처리
        public void clashEnemyAndBullet(Enemy enemy)
        {

            for (int i = 0; i < 20; i++)
            {
                // 살아 있는 미사일
                if (playerBullet[i].fire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1) && playerBullet[i].x <= (enemy.enemyX + 1))
                        {
                            // 아이템 생성
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            // 충돌 후 재생성
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            // 미사일도 준비상태로
                            playerBullet[i].fire = false;

                            // 스코어
                            Score += 100;
                        }
                    }
                }
            }

            // 미사일 2
            for (int i = 0; i < 20; i++)
            {
                // 살아 있는 미사일
                if (playerBullet2[i].fire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1) && playerBullet2[i].x <= (enemy.enemyX + 1))
                        {                         

                            // 아이템 생성
                            //item.ItemLife = true;
                            //item.itemX = enemy.enemyX;
                            //item.itemY = enemy.enemyY;

                            // 충돌 후 재생성
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            // 미사일도 준비상태로
                            playerBullet2[i].fire = false;

                            // 스코어
                            Score += 100;
                        }
                    }
                }
            }

            // 미사일 3
            for (int i = 0; i < 20; i++)
            {
                // 살아 있는 미사일
                if (playerBullet3[i].fire == true)
                {
                    // 미사일과 적의 y값이 같을 때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        if (playerBullet3[i].x >= (enemy.enemyX - 1) && playerBullet3[i].x <= (enemy.enemyX + 1))
                        {
                            //// 아이템 생성
                            //item.ItemLife = true;
                            //item.itemX = enemy.enemyX;
                            //item.itemY = enemy.enemyY;

                            // 충돌 후 재생성
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            // 미사일도 준비상태로
                            playerBullet3[i].fire = false;

                            // 스코어
                            Score += 100;
                        }
                    }
                }
            }
        }
    }

    // 적 클래스

    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->"; // 문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY);
            Console.WriteLine(enemy);   // 출력
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--; // 왼쪽으로 움직임

            if (enemyX < 2) // 화면 넘어가면 새로 좌표 만들기
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22);
            }
        }    
    }

    // 아이템 클래스
    public class Item
    {
        public string Itemname;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }
    }

    internal class shootingGame
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            // 플레이어 생성
            Player player = new Player();

            // 적 생성
            Enemy enemy = new Enemy();

            // frame 설정 (60fps)
            int dwTime = Environment.TickCount;

            while(true)
            {
                if(dwTime + 50 < Environment.TickCount)
                {
                    // 현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    // 플레이어
                    player.GameMain();

                    // 총알
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    // 적
                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    // 충돌처리
                    player.clashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
