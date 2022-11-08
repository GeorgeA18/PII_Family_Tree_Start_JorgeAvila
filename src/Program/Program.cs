using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // * Creacion de intencias de Personas
            Person abuelo = new Person("Jose Guevara", 90);

            Person padre = new Person("Luis Guevara",50);

            Person hijo1 = new Person("Carlos Rodriguez",20);
            Person hijo2 = new Person("Pablo Rodriguez",22);

            Person bisnieto1 = new Person("Maria Alvarez",4);
            Person bisnieto2 = new Person("Camila Perez",5);
            Person bisnieto3 = new Person("Valeria",60);
            Person bisnieto4 = new Person("Rodrigo Oropeza",1);


            // *  Creacion de intencias de Nodos
            Node n1 = new Node(1, abuelo);
            Node n2 = new Node(2,padre);
            Node n3 = new Node(3,hijo1);
            Node n4 = new Node(4,hijo2);
            Node n5 = new Node(5,bisnieto1);
            Node n6 = new Node(6,bisnieto2);
            Node n7 = new Node(7,bisnieto3);
            Node n8 = new Node(8,bisnieto4);

            // * Asignación de los nodos Padres e Hijos.
            n1.AddChildren(n2);
            n1.AddChildren(n3);


            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);

            n4.AddChildren(n7);
            n6.AddChildren(n8);


            // visitar el árbol aquí

            Visitor sumeOFages = new SumOfAgesVisitor();
            Visitor eldestSon = new EldestSon();
            Visitor longestName = new LongestName();


            n1.Accept(sumeOFages);
            n1.Accept(eldestSon);
            n1.Accept(longestName);


            Console.WriteLine("La Suma de todas las edades es: " + sumeOFages.GetResult());
            Console.WriteLine("La hijo con la edad mayor es: " + eldestSon.GetResult());
            Console.WriteLine("La hijo con el nombre mas largo es: " + longestName.GetResult());

        }
    }
}



/*
Añadir una forma para compara el nombre de las personas sin contar los espacios.


*/