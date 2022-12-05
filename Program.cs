using System;
using System.Numerics;
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
            const int x = screenWidth;
            const int y = screenHeight;

            Camera2D camera = new Camera2D()
            {
                target = new Vector2(x + ((screenWidth / 2) + 800), y + ((screenHeight / 2) + 450)),
                offset = new Vector2(screenWidth, screenHeight),
                rotation = 0.0f,
                zoom = 1.0f,
            };

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

                 Raylib.BeginMode2D(camera);
                Raylib.DrawGrid(10, 1);
                Raylib.EndMode2D();

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
