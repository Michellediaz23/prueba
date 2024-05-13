using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Automovil
    {
        internal void ReabastecerCombustible(object capacidadTanqueCombustible)
        {
            throw new NotImplementedException();
        }

        public partial class Automovil
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double CapacidadTanqueCombustible { get; set; }
        public double NivelCombustible { get; private set; }
        public double RendimientoCombustible { get; set; }

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTanqueCombustible, double rendimientoCombustible)
        {
            Marca = marca;
            Placa = placa;
            Modelo = modelo;
            Color = color;
            CapacidadTanqueCombustible = capacidadTanqueCombustible;
            NivelCombustible = 0;
            RendimientoCombustible = rendimientoCombustible;
        }

            public Automovil(string marca, string placa, string modelo, string color, double capacidadTanqueCombustible, double nivelCombustible, double rendimientoCombustible) : this(marca, placa, modelo, color, capacidadTanqueCombustible, nivelCombustible)
            {
                RendimientoCombustible = rendimientoCombustible;
            }

            public bool PuedeConducir(int distancia)
        {
            return (NivelCombustible * RendimientoCombustible) >= distancia;
        }

        public void Conducir(int distancia)
        {
            if (!PuedeConducir(distancia))
            {
                throw new InvalidOperationException("No hay suficiente combustible para recorrer la distancia especificada.");
            }

            double consumoCombustible = (double)distancia / RendimientoCombustible;
            NivelCombustible -= consumoCombustible;
        }

        public void ReabastecerCombustible(double cantidad)
        {
            if (NivelCombustible + cantidad > CapacidadTanqueCombustible)
            {
                throw new InvalidOperationException("La cantidad de combustible a reabastecer supera la capacidad máxima del tanque.");
            }

            NivelCombustible += cantidad;
        }
    }
}
}
