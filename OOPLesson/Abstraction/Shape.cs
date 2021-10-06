namespace OOPLesson.Abstraction
{
    // Abstract methodlar sadece abstract classlar içinde olabilir
    // Abstract methodlar body içeremez
    // Normal metodlar body içermek zorundadadır
    // Abstract metodlar extend eden normal classlar override edilmek zorundadır
    // Abstract metodlar child abstract classlarda override edilmek zorunda değildir
    // Abstract class newlenemez
    public abstract class Shape
    {
        protected readonly string _name;

        public Shape(string name)
        {
            _name = name; // field
        }

        public abstract string GetName();

        public void MethodWithBody()
        {

        }
    }
}
