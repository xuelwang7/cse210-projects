// See https://aka.ms/new-console-template for more information
using System.Numerics;
using static Raylib_cs.Raylib;
using Raylib_cs;

Raylib.InitWindow(500,800,"game");
while(!WindowShouldClose())
{
      BeginDrawing();
      ClearBackground(new Color(255,130,200,255));
      DrawText("HI",300,400,200,new Color(200,199,210,120));
      DrawCircle3D(new Vector3(5, 3, 5),20,new Vector3(1,1,1),0,new Color(210,255,100,99));
      EndDrawing();
}
