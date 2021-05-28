using csharp_training.Entities.Enums;

namespace csharp_training.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //metodo abstrato
    }
}
