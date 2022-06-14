using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A2
{
    internal class Figuras
    {
        //La clase Figuras sera utilizada para realizar una herencia de las propiedades de esta a las clases Triangulo y
        //Rectangulo.

        //Se declaran miembros de tipo campo con tipo de accesibilidad private, que se utilizarán para darle funcionalidad
        //al código.
        private double areaFigura, perimetroFigura, baseFigura, alturaFigura, medidaLado;

        //Se crea un constructor con parámetros (double areaFigura, double perimetroFigura, double baseFigura,
        //double alturaFigura, double medidaLado), para inicializar los datos de las figuras.
        public Figuras(double areaFigura, double perimetroFigura, double baseFigura,
            double alturaFigura, double medidaLado)
        {
            this.areaFigura = areaFigura;
            this.perimetroFigura = perimetroFigura;
            this.baseFigura = baseFigura;
            this.alturaFigura = alturaFigura;
            this.medidaLado = medidaLado;
        }

        //Segundo constructor.
        public Figuras() { }

        //Se crea un metodo de tipo public de nombre "CalcularArea" que recibira los parametros (double baseFigura,
        //double alturaFigura) para calcular el area de la figura (ademas se hara poliformismo para sobrescribir este metodo).
        public virtual double CalcularArea(double baseFigura, double alturaFigura)
        {
            double valorDeRetorno=0;
            valorDeRetorno = baseFigura * alturaFigura;
            return valorDeRetorno;
        }
    }
}
