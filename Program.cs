﻿/*
using System;
using System.Numerics;
using Raylib_cs;

namespace Nonogram;
    internal class Program
{
    static void Main(string[] args)
    {
        //Work on Multidimensional Arrays to inplement 0,1 working. 0 = empty 1 = black/filled-in.
        Raylib.InitWindow(800, 480, "3D Triangle + Grid test");


        //Texture2D = Raylib.LoadImage("resources/White Tile.png");//

        Camera3D camera;
        camera.position = (new Vector3 (10.0f, 10.0f, 10.0f)); // Camera3D position
        camera.target = (new Vector3 (0.0f, 0.0f, 0.0f));      // Camera3D looking at point
        camera.up = (new Vector3 (0.0f, 1.0f, 0.0f));          // Camera3D up vector (rotation towards target)
        camera.fovy = 90.0f;                                  // Camera3D field-of-view Y
        camera.projection = CameraProjection.CAMERA_PERSPECTIVE;        // Camera3D mode type                     

        Vector3 point1 = (new Vector3 (0.0f, 0.0f, 0.0f));
        Vector3 point2 = (new Vector3 (10.0f, 0.0f, 0.0f));
        Vector3 point3 = (new Vector3 (10.0f, 10.0f, 0.0f));

        Vector3 thickness = (new Vector3(0, 0, -5.0f));

        Vector3 back1 = point1 + thickness;
        Vector3 back2 = point2 + thickness;
        Vector3 back3 = point3 + thickness;

        Raylib.SetCameraMode(camera, CameraMode.CAMERA_FREE); // Set a free camera mode    
        Raylib.SetTargetFPS(60);

    // Main game loop
    while (!Raylib.WindowShouldClose())    // Detect window close button or ESC key
    {
        // Update
        //----------------------------------------------------------------------------------
        // TODO: Update your variables here
        //----------------------------------------------------------------------------------
        

        // Draw
        //----------------------------------------------------------------------------------
        //UpdateCamera(&camera);
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RAYWHITE);

        Raylib.BeginMode3D(camera);
        Raylib.UpdateCamera(ref camera);
            // Front face
            Raylib.DrawTriangle3D(point1, point2, point3, Color.BLACK);

            // Back face
            Raylib.DrawTriangle3D(back3, back2, back1, Color.BLACK);

            // Slanted side
            Raylib.DrawTriangle3D(back1, point1, back3, Color.BLACK);
            Raylib.DrawTriangle3D(point1, point3, back3, Color.BLACK);

            // Back side
            Raylib.DrawTriangle3D(point2, back2, back3, Color.BLACK);
            Raylib.DrawTriangle3D(back3, point3, point2, Color.BLACK);

            // Bottom side
            Raylib.DrawTriangle3D(back1, back2, point2, Color.BLACK);
            Raylib.DrawTriangle3D(point2, point1, back1, Color.BLACK);


            Raylib.DrawGrid(10, 10);
        Raylib.EndMode3D();


        Raylib.EndDrawing();
        //----------------------------------------------------------------------------------
    }
    }
}
*/




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
            const int screenWidth = 1980;
            const int screenHeight = 1024;
            //Image LoadImage(const char WhiteTile)
            Raylib.InitWindow(screenWidth, screenHeight, "Nonogram");

            Raylib.SetTargetFPS(60);               // Set our game to run at 60 frames-per-second
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!Raylib.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here

                //Example of a multidimentional array (10x10)
                //To be used for loading the tile images
                int[ , ] x = new int [10, 10];

                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("Test text here", 500, 500, 50, Color.LIGHTGRAY);
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