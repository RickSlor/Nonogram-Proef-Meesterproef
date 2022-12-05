using System;
using Raylib_cs;

namespace Nonogram // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puzzel p = new Puzzel();

            
            const int screenWidth = 800;
            const int screenHeight = 450;

            Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");
            


            Raylib.SetTargetFPS(60);               // Set our game to run at 60 frames-per-second
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

                    Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Congrats! You created your first window!", 190, 200, 20, Color.LIGHTGRAY);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            Raylib.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------
        }
    }
}
