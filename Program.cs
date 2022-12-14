using System;
using System.Numerics;
using Raylib_cs;


namespace Nonogram // Note: actual namespace depends on the project name.

{

    internal class Program
    {
        private static Gamescreen LOGO { get; set; }

        enum Gamescreen
            {
            LOGO = 0, TITLE, GAMEPLAY, ENDING
            };
        static void Main(string[] args)
        {
            //test
            Puzzel p = new Puzzel();

            Gamescreen currentGamescreen = LOGO;

            const int screenWidth = 1920;
            const int screenHeight = 1080;
            
            Raylib.InitWindow(screenWidth, screenHeight, "Nonogram");
            Raylib.SetTargetFPS(60);               // Set our game to run at 60 frames-per-second

            Texture2D textureI = Raylib.LoadTexture("Resources/BlackTile.png");
            Texture2D textureO = Raylib.LoadTexture("Resources/WhiteTile.png");
            
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

                Raylib.DrawTexture(textureI, screenWidth/2 - textureI.width/2, screenHeight/2 - textureI.height/2 - 40, Color.RAYWHITE);
                Raylib.DrawTexture(textureI, screenWidth/2 - textureI.width/2, screenHeight/2 - textureI.height/2 - 150, Color.RAYWHITE);
                Raylib.DrawTexture(textureO, screenWidth/2 - textureO.width/2, screenHeight/2 - textureO.height/2 - 80, Color.RAYWHITE);

                Raylib.ClearBackground(Color.LIGHTGRAY);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
            // De-Initialization
            //--------------------------------------------------------------------------------------
            Raylib.UnloadTexture(textureI);
            Raylib.UnloadTexture(textureO);

            Raylib.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------
        }
    }
}