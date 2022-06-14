using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU4_A2
{
    //Alumnos: Daniela Ailyn Rodriguez Diaz, Jaime Emanuel Quistián Sanchez, Ricardo Lenin Vazquez Arriaga
    //Tema de Referencia: Herencia y polimorfismo
    //Objetivo: DESARROLLAR UNA APLICACIÓN EN CONSOLE (.NET CORE), QUE IMPLEMENTEUNO DE LOS PILARES DEL PARADIGMA DE
    //PROGRAMACIÓN ORIENTADA A OBJETOS, QUE ES HERENCIA, EN DONDE SE DESARROLLE UNA CLASE QUE PERMITA A PARTIR DE UNA CLASE
    //BASE DENOMINADA FIGURA DERIVAR POR LO MENOS DOS CLASES MÁS QUE PERMITAN CALCULAR AL ÁREA Y
    //PERÍMETRO DE FIGURAS GEOMÉTRICAS.
    //Asignatura: Programacion Orientada a Objetos
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desde este punto despues del "Main" es donde inicia la ejecucion del codigo programado aqui, en donde primero
            //Se declaran miembros de tipo campo, que se utilizarán para darle funcionalidad al código.
            int opcionFigura, opcionEntrada;
            double baseFigura =0, alturaFigura =0;
            //Se manda a pantalla un mensaje el cual muestra las opciones disponibles que el usuario puede escoger, en este
            //caso para entrar al sistema.
            Console.WriteLine("Ingresando al sistema...\nSeleccione una opción\n\t1. Entrar\t2. Salir");
            opcionEntrada = Convert.ToInt32(Console.ReadLine());
            //Se usa un ciclo WHILE para que se evalue la opcion dada por el usuario, en caso de dar una opcion valida
            //Se ejecutara el codigo que se encuentra dentro del ciclo. En caso contrario se saltara hasta la parte final de
            //este.
            while (opcionEntrada == 1)
            {
                //Se modifica el color de fondo de la consola a un color blanco, asi como tambien de
                //la fuente a un tono azul oscuro
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                //Se manda a pantalla un menu donde se podra elegir el tipo de figura que el usuario desee elegir disponible.
                Console.WriteLine("\t\tFIGURAS GEOMETRICAS");
                Console.WriteLine("Selecciona la figura \n\t 1.Rectangulo \n\t 2.Triangulo");
                opcionFigura = Convert.ToInt32(Console.ReadLine());
                //Se implementa la condicion IF que evalua el tipo de figura geometrica seleccionada por el usuario y de
                //acuerdo al tipo de figura, se mostrara los calculos y la informacion de la figura correspondiente.
                if (opcionFigura == 1)
                {
                    //se ejecuta el codigo para la figura rectangulo.
                    Figuras objFigura = new Figuras();
                    Rectangulo objRectangulo = new Rectangulo();
                    Console.WriteLine("\t\tRECTÁNGULO");
                    Console.WriteLine("\tCALCULO DE AREA\nIngresa la base:");
                    baseFigura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nIngresa la altura:");
                    alturaFigura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(objRectangulo.CalcularArea(baseFigura, alturaFigura));
                    Console.WriteLine("\n");
                    Console.WriteLine("CÀLCULO DE PERIMETRO");
                    Console.WriteLine(objRectangulo.CalcularPerimetro());
                    objRectangulo.DatosFigura();
                }
                //Se implementa un segundo IF para la evaluacion de otra opcion en caso de que el usuario lo haya elegido.
                if (opcionFigura == 2)
                {
                    //se ejecuta el codigo para la figura triangulo.
                    Triangulo objTriangulo = new Triangulo();
                    Console.WriteLine("\t\tTRIÁNGULO");
                    Console.WriteLine("\tCALCULO DE AREA\nIngresa la base:");
                    baseFigura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nIngresa la altura:\n");
                    alturaFigura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(objTriangulo.CalcularArea(baseFigura, alturaFigura));
                    Console.WriteLine("CÀLCULO DE PERIMETRO");
                    Console.WriteLine(objTriangulo.CalcularPerimetro());
                    objTriangulo.DatosFigura();
                   
                }
                else if (opcionFigura !=1 && opcionFigura != 2) 
                {
                    //En caso de escoger una opcion no valida, se mandara el siguiente mensaje:
                    Console.WriteLine("Esa opción no existe. ¿Desea intentarlo de nuevo?\n\t1.Si\n\t2.No");
                    opcionEntrada = Convert.ToInt32(Console.ReadLine());
                }
                
                //Se manda a pantalla las siguientes opciones para que el usuario eliga si desea continuar con las figuras
                //o desea salir de la ejecucion.
                Console.WriteLine("¿Desea escoger otra figura?\n1. Si\n2. No");
                opcionEntrada = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            //Se manda la siguiente leyenda como despedida:
            Console.Clear();
            Console.WriteLine("Que tenga buen dìa :)  \n\n\nNombres: Daniela Ailyn Rodriguez Diaz" +
                "\nJaime Emanuel Quistian Sanchez\nRicardo Lenin Vazquez Arriaga");
            Console.ReadKey();
        }
    }
}
