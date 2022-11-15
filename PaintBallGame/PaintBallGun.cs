﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallGame
{
    internal class PaintBallGun
    {
        private int balls = 0;
        private int ballsLoaded = 0;
        public const int MAGAZINE_SIZE = 16;
        public int GetBallsLoaded() { return ballsLoaded; }
        public bool IsEmpty() { return ballsLoaded == 0; }
        public int GetBalls() { return balls; }
        public void SetBalls(int numberOfBalls)
        {
            if (numberOfBalls > 0)
                balls = numberOfBalls;
            Reload();
        }
        public void Reload()
        {
            if (balls > MAGAZINE_SIZE)
                ballsLoaded = MAGAZINE_SIZE;
            else
                ballsLoaded = balls;
        }
        public bool Shoot()
        {
            if (ballsLoaded == 0) return false;
            ballsLoaded--;
            balls--;
            return true;
        }
    }
}
