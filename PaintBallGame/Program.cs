using System;
namespace PaintBallGame
{
    class program
    {
        static void Main(string[] args)
        {
            PaintBallGun gun = new PaintBallGun();
            while(true)
            {
                Console.WriteLine($"{gun.GetBalls()} balls, {gun.GetBallsLoaded()} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING: You're out of ammo");
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.SetBalls(gun.GetBalls() + PaintBallGun.MAGAZINE_SIZE);
                else if (key == 'q') return;
            }
        }
    }
}