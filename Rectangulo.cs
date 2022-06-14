using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A2
{
    //Se realiza herencia de las propiedades de Figuras a la clase Rectangulo.
    internal class Rectangulo : Figuras
    {
        //Se declaran miembros globales de tipo campo de tipo de acceso private, que se utilizarán para darle funcionalidad
        //al código.
        private double areaRectangulo =0, perimetroRectangulo=0;

        //Se crea un constructor para la clase.
        public Rectangulo() { }

        //Se crea un metodo de tipo public de nombre "CalcularArea" que recibira los parametros (double baseFigura,
        //double alturaFigura) para calcular el area del rectangulo. ademas se sobrescribe el metodo poliformado.
        public override double CalcularArea(double baseFigura, double alturaFigura)
        {
             base.CalcularArea(baseFigura, alturaFigura);
            areaRectangulo = baseFigura * alturaFigura;
            Console.WriteLine("\nArea:");
            return areaRectangulo;
        }

        //Se crea un metodo de tipo public de nombre "CalcularPerimetro" que recibira los parametros (double baseFigura,
        //double alturaFigura) para calcular el perimetro del rectangulo, ademas se sobrescribe el metodo poliformado.
        public double CalcularPerimetro()
        {
            //Se declaran variables locales de tipo double para guardar los datos de la figura.
            double medidaLado, medidaLado2, medidaLado3, medidaLado4;
            //Se le da la instruccion al usuario de ingresar la medida de los lados de la figura para una vez tienendo los
            //datos, calcular el perimetro correspondiente.
            Console.WriteLine("Ingresa la medida del lado 1");
            medidaLado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del lado 2");
            medidaLado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del lado 3");
            medidaLado3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la medida del lado 4");
            medidaLado4 = Convert.ToDouble(Console.ReadLine());
            perimetroRectangulo = medidaLado + medidaLado2 + medidaLado3+ medidaLado4;
            Console.WriteLine("\nPerimetro:");
            return perimetroRectangulo;
        }

        //Se crea un metodo de tipo public de nombre "DatosFigura" para mostrar la informacion del rectangulo.
        public string DatosFigura()
        {
            string valorDeRetorno = "0";
            Console.WriteLine("\t\t DATOS FINALES \nFIGURA: RECTANGULO  \nÀREA:{0} \nPERÌMETRO: {1}", areaRectangulo, perimetroRectangulo);
            return valorDeRetorno;
        }
    }
}
