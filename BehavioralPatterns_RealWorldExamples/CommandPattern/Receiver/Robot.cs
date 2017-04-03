using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Receiver
{
    public class Robot
    {
        public void Move(int distance)
        {
            if (distance > 0)
                Console.WriteLine("Robot moved forwards {0}mm.", distance);
            else
                Console.WriteLine("Robot moved backwards {0}mm.", -distance);
        }

        public void RotateLeft(double angle)
        {
            if (angle > 0)
                Console.WriteLine("Robot rotated left {0} degrees.", angle);
            else
                Console.WriteLine("Robot rotated right {0} degrees.", -angle);
        }

        public void RotateRight(double angle)
        {
            if (angle > 0)
                Console.WriteLine("Robot rotated right {0} degrees.", angle);
            else
                Console.WriteLine("Robot rotated left {0} degrees.", -angle);
        }

        public void TakeSample(bool take)
        {
            if(take)
                Console.WriteLine("Robot took sample");
            else
                Console.WriteLine("Robot released sample");
        }
    }
}
