﻿
namespace Polimorfismo__Tarea_
{
    private double radio;
    public class Circulo(double radio)
    {
         this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI
* Math.Pow(radio, 2);
    }
}