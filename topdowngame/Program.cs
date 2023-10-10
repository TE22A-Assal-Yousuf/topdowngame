using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800,600, "cringe");

int x = 0;
int y = 12;
int FPS = 1;

Vector2 position = new Vector2(400, 300);


while(!Raylib.WindowShouldClose())
{

    x++;
    y++;

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.VIOLET);
    Raylib.DrawCircle(x, y, 30, Color.BLACK);

    if (y == 300){
        y = 12;
        x = 0;
        FPS *= FPS;
    }

    Raylib.SetTargetFPS(FPS);


    Raylib.EndDrawing();
}