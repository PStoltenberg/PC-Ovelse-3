using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Praktikcenter_Øvelse_3
{
    class Program
    {

        public string name;
        public int y { get; set; }
        public int x { get; set; }
        public string Playermarker;

        public string[] bane = { "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "|F|", };


        static void Main(string[] args)
        {


            WriteLine("PN TrackStar");


            //Patrick

            Program program = new Program();




            // Menu

            // Spillernavn

            program.Player(0, 2);

            // Bane
            WriteLine("Spillernavn: {0}", program.name);
            program.BaneDraw();
            program.PlayerDraw();


            while (true)
            {

                program.DrawFrame();
                program.PlayerMovement();
                program.IsPositionWalkable();


            }


            //Player Input

            // Timer

            // Check for win

            // Highscore
            // Session
            // All time

            ReadKey();
        }

        public void BaneDraw()
        {

            for (int x = 0; x < bane.GetLength(0); x++)
            {
                string element = bane[x];
                SetCursorPosition(x, y);
                Write(element);
            }

        }

        public void Player(int InitialX, int InitialY)
        {

            x = InitialX;
            y = InitialY;
            Playermarker = "X";

        }
        public void PlayerDraw()
        {
            
            
            SetCursorPosition(x, y);
            Write(Playermarker);

        }

        public void PlayerMovement()
        {

            Program program = new Program();

            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;

            if (ReadKey(true).Key == ConsoleKey.LeftArrow)
            {

                program.x += 1;

                if ((ReadKey(true).Key == ConsoleKey.RightArrow))
                {

                    program.x += 1;

                }

                else
                {
                    PlayerMovement();
                }

            }

            else
            {

                PlayerMovement();
            }

        }

        public bool IsPositionWalkable()
        {

            return bane[x] == "_" || bane[x] == "|F|";
        }

        public void DrawFrame()
        {
            Clear();
            BaneDraw();
            PlayerDraw();
        }
    }
}
