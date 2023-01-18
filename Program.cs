using System;
using System.Numerics;
using Raylib_cs;


namespace Nonogram // Note: actual namespace depends on the project name.

{

    internal class Program
    {
        //private static Gamescreen LOGO { get; set; }

        enum Gamescreen
            {
            LOGO = 0, TITLE, GAMEPLAY, ENDING
            };
        static void Main(string[] args)
        {
            //test
            Puzzel p = new Puzzel();

            Gamescreen currentGamescreen = Gamescreen.LOGO;

            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!Raylib.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();

                p.HandlePuzzel();

                Raylib.ClearBackground(Color.LIGHTGRAY);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
            // De-Initialization
            //--------------------------------------------------------------------------------------
            

            p.Close();

            Raylib.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------
        }
    }
}