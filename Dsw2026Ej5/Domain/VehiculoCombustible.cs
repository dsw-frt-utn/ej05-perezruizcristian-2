using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoCombustible: Vehiculo
{
    private double kilometrosPorLitro;
    private double litrosExtra;

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kilometrosPorLitro, double litrosExtra) : base(VehiculoTipo.Combustible, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kilometrosPorLitro = kilometrosPorLitro;
        this.litrosExtra = litrosExtra;
    }

    public double GetKilometrosPorLitro()
    {
        return kilometrosPorLitro;
    }

    public double GetLitrosExtra()
    {
        return litrosExtra;
    }

    public override double CalcularConsumo(double kilometros)
    {
        // 1. Cálculo base
        double total = kilometros * kilometrosPorLitro;

        // 2. Obtener el año actual en C#
        int anioActual = DateTime.Now.Year;

        // 3. Calcular antigüedad (suponiendo que 'anio' es accesible desde la clase base)
        int antiguedad = anioActual - this.GetAnio();

        // 4. Lógica de litros extra por antigüedad
        if (antiguedad > 5)
        {
            double aux = kilometros * 15.0;
            total += litrosExtra * aux;
        }
        Console.WriteLine(total);
        return total;
    }
}
