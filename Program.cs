/*
using System;
using Raylib_cs;
using System.Numerics;

namespace Triangle
{

    class Program
    {

        static void Main(string[] args)
        {



            Raylib.InitWindow(800, 480, "Triangle Test");
            Camera3D camera;
            camera.position = new Vector3(10.0f, 10.0f, 10.0f);             // Camera3D position
            camera.target = new Vector3(0.0f, 0.0f, 0.0f);                  // Camera3D looking at point
            camera.up = new Vector3(0.0f, 1.0f, 0.0f);                      // Camera3D up vector (rotation towards target)
            camera.fovy = 120.0f;                                           // Camera3D field-of-view Y
            camera.projection = CameraProjection.CAMERA_PERSPECTIVE;        // Camera3D mode type



            Vector3 point1 = new Vector3(0.0f, 0.0f, 0.0f);
            Vector3 point2 = new Vector3(10.0f, 0.0f, 0.0f);
            Vector3 point3 = new Vector3(10.0f, 10.0f, 0.0f);

            Raylib.SetCameraMode(camera, CameraMode.CAMERA_FREE);           // Set a free camera mode
            Raylib.SetTargetFPS(60);

            Rlgl.rlDisableBackfaceCulling();
            while (!Raylib.WindowShouldClose())
            {
                Raylib.UpdateCamera(ref camera);
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                Raylib.BeginMode3D(camera);


                Raylib.DrawTriangle3D(point1, point2, point3, Color.BLACK);



                Raylib.EndMode3D();


                //text
                Raylib.DrawRectangle(10, 10, 320, 133, Raylib.ColorAlpha(Color.SKYBLUE, 0.5f));
                Raylib.DrawRectangleLines(10, 10, 320, 133, Color.BLUE);

                Raylib.DrawText("Free camera default controls:", 20, 20, 10, Color.BLACK);
                Raylib.DrawText("- Mouse Wheel to Zoom in-out", 40, 40, 10, Color.DARKGRAY);
                Raylib.DrawText("- Mouse Wheel Pressed to Pan", 40, 60, 10, Color.DARKGRAY);
                Raylib.DrawText("- Alt + Mouse Wheel Pressed to Rotate", 40, 80, 10, Color.DARKGRAY);
                Raylib.DrawText("- Alt + Ctrl + Mouse Wheel Pressed for Smooth Zoom", 40, 100, 10, Color.DARKGRAY);


                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
*/


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


        Texture2D = Raylib.LoadImage("resources/White Tile.png");

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





/*
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

            Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] Program");

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
                Raylib.DrawGrid(10, 10);
                //Console.WriteLine("Test");
                Raylib.EndMode2D();

                Raylib.DrawText("Testing, You created your first window!", 190, 200, 20, Color.LIGHTGRAY);
                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
            if(Raylib.DrawGrid() == true)
            {
                Console.WriteLine("Testing");
            }
            // De-Initialization
            //--------------------------------------------------------------------------------------
            Raylib.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------
        }
    }
}
*/