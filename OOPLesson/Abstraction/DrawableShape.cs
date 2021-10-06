namespace OOPLesson.Abstraction
{
    public abstract class DrawableShape : Shape
    {
        public DrawableShape(string name) : base(name)
        {

        }

        public abstract void Draw();
    }
}
