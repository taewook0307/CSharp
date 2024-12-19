using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle
    {
        private int radius;

        public void SetRadius(int _radius)
        {
            if(radius < 0)
            {
                Console.WriteLine("반지름 크기는 0보다 큰 수로 지정해주세요");
            }
            else
            {
                radius = _radius;
            }
        }

        public int GetRadius()
        {
            return radius;
        }
    }

    internal class Box
    {
        private int width;
        public int Width
        {
            get {  return width; }
            set
            {
                if(value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("너비는 0보다 큰 수여야 합니다");
                }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("높이는 0보다 큰 수여야 합니다.");
                }
            }
        }
    }
}
