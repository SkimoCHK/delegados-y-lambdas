namespace Lambdas1
{
    internal class Program
    {
        //1ER EJEMPLO
        public delegate int RealizarOperacion(int n);

        //2DO EJEMPLO
        public delegate int RealizarSuma(int n, int n2);

        static void Main(string[] args)
        {

            //uso del delegado
            RealizarOperacion operacion = new RealizarOperacion(Cuadrado);
            Console.WriteLine("Impreso con delegado apuntando al metodo Cuadrado: " + operacion(4));

            //Ahora con expresion lambda
            //Podemos notar como es mas sencillo

            //uso del delegado
            RealizarOperacion operacionv2 = n => n * n;
            Console.WriteLine("Impreso con el delegado pero con un una funcion lambda: " + operacionv2(4));



            ///////////////////////////////////////////////
            ///PASEMOS CON OTRO EJEMPLO

            //Uso del delegado apuntando a un metodo
            RealizarSuma suma = new RealizarSuma(Suma);
            Console.WriteLine("Impreso con el delegado apuntando al metodo Suma: " + suma(2, 2));

            //Uso del delegado apuntando a expresion lambda
            //cuando son dos paramestros o mas, estos deben de ir en parentesis o dara error
            RealizarSuma sumav2 = (n, n2) => n + n2;
            Console.WriteLine("Impreso con el delegado apuntando a expresion lambda: " + sumav2(2, 2));


            //Aqui podemos observar como usamos simplemente una expresion lambda, y nos ahorramos todo el show de predicados y delegados.....
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, };

            //El metodo FindAll, regresa todos los elementos de la lista que cumplan con lo que diga un filtro
            //entonces, el metodo FindAll, necesita un predicado y/o una expresion lambda que sirva como filtro.
            List<int> numerosPares = numeros.FindAll(n => n % 2 == 0);


            //El metodo foreach espera un Action, que viene siendo alguna funcion que realice algo pero no devuelve nada!
            //En este caso pues hicimos que solo imrpimiera en consola.. no devuelve nada.
            //
            numerosPares.ForEach(n => Console.WriteLine(n));

            //Si se requieren mas lineas de codigo en una expresion lambda, se tienen que abrir llaves y ahi se coloca todas las lineas que se desee
            // OJO cada linea debe de tener su punto y coma al final
            numerosPares.ForEach(n => { Console.WriteLine("El numero par es: ");
                                        Console.WriteLine(n);
                                        Console.WriteLine("El numero par multiplicado es igual a su doble, osea = " + n * 2);
            });
            //podemos observar que aqui introdujimos mas lineas de codigo a la expresion lambda....
            //mas mensajes de consola, etc, ahi agrega lo que se te de la gana, pero recuerda
            //cuando es mas de una linea de codigo, se pone entre llaves todo..
            //y cada linea de codigo tiene su punto y coma;



        }


        //1ER EJEMPLO
        public static int Cuadrado(int n)
        {
            return n * n;
        }

        //2DO EJEMPLO
        public static int Suma(int n, int n2)
        {
            return n + n;
        }

    }



    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
    }

}
