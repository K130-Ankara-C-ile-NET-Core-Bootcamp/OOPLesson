using System;

namespace OOPLesson.Abstraction
{
    public class Circle : DrawableShape
    {
        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine(
                @"*****
                  *****
                  *****");
        }

        public override string GetName()
        {
            return _name + " (ShapeType: Circle)";
        }
    }
}
