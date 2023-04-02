using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>{
        new Video("8K Zelda Botw RTX 4090 - Raytracing GI - Ultra graphic gameplay 2022 - NEW Extreme settings", "Digital Dreams", 143200432),
        new Video("Henrik Chaim Goldschmidt plays Gabriel's Oboe", "henrik chaim goldschmidt", 33256),
        new Video("The Best 96% Slim Mech?! No Need to Mod Anymore..", ":3ildcat", 4654777)
        };

        foreach (Video video in videos){
            
            video.display();
        }
    }
}