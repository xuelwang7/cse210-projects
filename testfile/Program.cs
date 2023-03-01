using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        team f = new team("fire?");
        player j = new player("alice",12);
        player n = new player("no",13);

        f.addplayer(j);
        f.addplayer(n);
        f.displayPlayer();
    
        j.Display();

        team angrybear = new team("bear");
        player an = new player("anna",20);
        player tom = new player("Tom",17);

        angrybear.addplayer(an);
        angrybear.addplayer(tom);
        angrybear.displayPlayer();

        


    }
}