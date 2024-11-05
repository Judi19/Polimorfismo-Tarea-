

namespace Polimorfismo__Tarea_
{

    private double baseRectangulo;
    private double altura;
    public class Rectangulo(double baseRectangulo, double altura)
    {
         this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return baseRectangulo * altura;

    }
}
