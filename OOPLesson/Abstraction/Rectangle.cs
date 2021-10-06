using System;

namespace OOPLesson.Abstraction
{
    public class Rectangle : DrawableShape
    {
        public Rectangle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine( 
                @"*****
                  *   *
                  *****");
        }

        public override string GetName()
        {
            return _name + " (ShapeType: Rectangle)";
        }
    }
}
