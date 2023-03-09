using System;

namespace Sample_1
{
    class Program
    {
        public static void Main()
        {
            //初期値の設定
            Random rand = new ();
            int Player1 = 50;
            int Player2 = 50;
            int[] Weapon = new int[4];
            int[] Armor = new int[4];
            int P1Select = 0;
            int P2Select = 0;

            Console.WriteLine($"Player1 HP:{Player1}, Player2 HP:{Player2}");

            //実際のコード
            do
            {
                //プレイヤー１のターン
                Console.WriteLine("Player1's turn!\n");

                //武器の攻撃力の決定
                Weapon[1] = rand.Next(1, 10);
                Weapon[2] = rand.Next(1, 10);
                Weapon[3] = rand.Next(1, 10);

                //任意の武器の決定
                Console.WriteLine("Select your weapon.");

                Player1sTurnA:
                Console.WriteLine($"Weapon1: {Weapon[1]}, Weapon2: {Weapon[2]}, Weapon3: {Weapon[3]}\n");

                try
                {
                    P1Select = int.Parse(Console.ReadLine());
                    if (P1Select == 0)
                    {
                        Console.WriteLine("Player1, select your weapon again.");
                        goto Player1sTurnA;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Player1, select your weapon again.");
                    goto Player1sTurnA;
                }

                //アーマー値の決定
                Armor[1] = rand.Next(1, 10);
                Armor[2] = rand.Next(1, 10);
                Armor[3] = rand.Next(1, 10);

                //任意の防具の決定
                Console.WriteLine("Player2, select an armor.");

                Player1sTurnB:
                Console.WriteLine($"Armor1: {Armor[1]}, Armor2: {Armor[2]}, Armor3: {Armor[3]}\n");

                try
                {
                    P2Select = int.Parse(Console.ReadLine());
                    if (P2Select == 0)
                    {
                        Console.WriteLine("Player2, select an armor again.");
                        goto Player1sTurnB;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine ("Player2, select an armor again.");
                    goto Player1sTurnB;
                }

                //プレイヤーそれぞれの選んだ武器、防具の確認
                Console.WriteLine($"Player1 selected Weapon {P1Select}, and Player2 selected Armor {P2Select}!\n");

                //ダメージ計算
                int P2Damage = Weapon[P1Select] - Armor[P2Select];
                if (P2Damage > 0) Player2 -= P2Damage;
                else Player2 -= 0;

                Console.WriteLine($"Player1 HP:{Player1}, Player2 HP:{Player2}");
                Console.WriteLine("--------------------------------------------------\n");

                //死亡判定
                if (Player2 < 0) break;

                //プレイヤー２のターン
                Console.WriteLine("Player2's turn!\n");

                //武器の攻撃力の決定
                Weapon[1] = rand.Next(1, 10);
                Weapon[2] = rand.Next(1, 10);
                Weapon[3] = rand.Next(1, 10);

                //任意の武器の決定
                Console.WriteLine("Select your weapon.");

                Player2sTurnA:
                Console.WriteLine($"Weapon1: {Weapon[1]}, Weapon2: {Weapon[2]}, Weapon3: {Weapon[3]}\n");

                try
                {
                    P2Select = int.Parse(Console.ReadLine());
                    if (P2Select == 0)
                    {
                        Console.WriteLine("Player2, select your weapon again.");
                        goto Player2sTurnA;
                    }
                }
                
                catch (Exception)
                {
                    Console.WriteLine("Player2, select your weapon again.");
                    goto Player2sTurnA;
                }

                //アーマー値の決定
                Armor[1] = rand.Next(1, 10);
                Armor[2] = rand.Next(1, 10);
                Armor[3] = rand.Next(1, 10);

                //任意の防具の決定
                Console.WriteLine("Player1, select an armor.");

                Player2sTurnB:
                Console.WriteLine($"Armor1: {Armor[1]}, Armor2: {Armor[2]}, Armor3: {Armor[3]}\n");
                
                try
                {
                    P1Select = int.Parse(Console.ReadLine());
                    if (P1Select == 0)
                    {
                        Console.WriteLine("Player1, select an armor again.");
                        goto Player2sTurnB;
                    }
                }

                catch(Exception)
                {
                    Console.WriteLine("Player1, select an armor again.");
                    goto Player2sTurnB;
                }
                

                //プレイヤーそれぞれの選んだ武器、防具の確認
                Console.WriteLine($"Player2 selected Weapon {P2Select}, and Player1 selected Armor {P1Select}!\n");

                //ダメージ計算
                int P1Damage = Weapon[P2Select] - Armor[P1Select];
                if (P1Damage > 0) Player1 -= P1Damage;
                else Player1 -= 0;

                //最終的なプレイヤーそれぞれの体力の確認
                Console.WriteLine($"Player1 HP:{Player1}, Player2 HP:{Player2}");
                Console.WriteLine("--------------------------------------------------\n");

            } while (Player1 > 0); //プレイヤー１の死亡判定

            //勝者の確認
            Console.WriteLine(Player1 > Player2 ? "Player1 won the match!" : "Player2 won the match!");

        }

    }

}