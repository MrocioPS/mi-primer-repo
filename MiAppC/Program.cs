using System;

namespace MiAppC
{
      class Program
     {

        static void Main(string[] args)
        {
            // crear objeto(s)/instancia(s) de tipo coche y dar u estado incial 
            Coche coche1 = new Coche(); 
            Coche coche2 = new Coche(); 
            Coche coche3 = new Coche(20.12,12.45);

            Console.WriteLine(coche1.getInfoCoche());

            Console.WriteLine(coche3.getInfoCoche());

            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());


            //suma(2, 3, 5);

            //Console.WriteLine(sumarNumeros(5,7));
            // Console.WriteLine("Bienvenidos al curso de C#");
            // operadores + - * / %
            //Console.WriteLine($"Mi edad es de {edad++} años de viejo");

            //int edadPersona1,edadPersona2,edadPersona3,edadPersona4 = 20; --> solo se guarda el valor en la ultima variable, la 4

            /*double edadPersona1 = 27.5;
            int edadPersona ;

            // conversion explicicta o casting
            edadPersona = (int) edadPersona1; // no se puede cambiar el tipo

            //Console.WriteLine(edadPersona);


            // conversion implicita
            int habitantesCiudad = 10000000;
            long habitantesCiudad2018 = habitantesCiudad;

            //Console.WriteLine(habitantesCiudad2018);

            //Input por pantalla
            Console.WriteLine("Introduce el primer número: ");

            //conversion de texto a int
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El número introducido es el " +num1);

            // var-> cambia ||| const-> no cambia

            const string NOMBRE = "rocio";
            //NOMBRE = "Rocio"; //DA ERROR
            */
        }

        //static int suma(int operador1, int operador2)=>operador1 + operador2;

        
        //static int suma(int operador1, int operador2, int operador3) => operador1 + operador2+ operador3 ;


        /*static void sumarNumeros(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        return num1+num2
        }*/
        //otra forma 
        //static double  sumarNumeros(double num1, int num2) => num1/num2;
     }

     class Coche
     {
        //Contructor, da un estado inicial a todos los Coches
        public Coche() {
            ruedas = 4;
            ancho = 0.800;
            largo = 2300.5;
            tapiceria = "tela de tipo b ";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        public String getInfoCoche()
        {
            return "Informacion del coche:\n "  + "Ruedas:" + ruedas + " Largo:" + largo + " Ancho:" +ancho;
        }

        public void setExtras( bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public String getExtras()
        {
            return "Extras del coche: \n" + "Climatizador:" + climatizador + " Tapiceria:" + tapiceria;
        }



        private int ruedas;
        private double ancho;
        private double largo;
        private String tapiceria;
        private bool climatizador;


    }
}

