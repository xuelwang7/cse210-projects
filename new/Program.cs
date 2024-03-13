// See https://aka.ms/new-console-template for more information
using System.Numerics;
using static Raylib_cs.Raylib;
using Raylib_cs;

Vector3 pos1 = new Vector3(50,50,50);


Raylib.InitWindow(2000,1000,"game");
// Define the camera to 3d 
Camera3D camera = new Camera3D();
camera.position = new Vector3(5,10,30); // Camera3D position};
camera.target = pos1;//looking at point
camera.up = new Vector3(2,1,8);//
camera.fovy = 120.0f;
camera.projection = CameraProjection.CAMERA_PERSPECTIVE;

while(!WindowShouldClose())
{

      BeginDrawing();
      BeginMode3D(camera);
      
      ClearBackground(new Color(120,200,200,255));
      // DrawText("HI",300,400,200,new Color(200,199,210,120));
      // DrawCircle3D(new Vector3(5, 3, 5),20,new Vector3(1,1,1),0,new Color(210,255,100,99));
      
      // DrawSphere(pos1, 10, new Color(0,0,0,255));
      DrawCube(pos1, 30, 30, 10, new Color(0,0,0,100));
      DrawCubeWires(pos1,30, 30, 10, new Color(0,0,0,250));
      
      pos1.Y +=0.01f;

      if (IsKeyDown(KeyboardKey.KEY_S)){
            pos1.Y -=0.1f;
      }
      if (IsKeyDown(KeyboardKey.KEY_W)){
            pos1.Y +=0.1f;
      }
      if (pos1.X < -10){
            pos1.X += 1f;
      }
      if (pos1.X > 10){
            pos1.X -= 1f;
      }

      EndMode3D();
      EndDrawing();
}

CloseWindow();