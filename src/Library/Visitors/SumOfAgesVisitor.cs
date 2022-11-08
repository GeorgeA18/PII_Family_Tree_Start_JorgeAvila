using System;

namespace Library
{
    public class SumOfAgesVisitor : Visitor
    {
        public int Result { get; set; }

        public SumOfAgesVisitor()
        {
            this.Result = 0;
        }


        // * Metodo Visit para la clase Node.
        public override void Visit(Node node)
        {   
            // Toma la edad del nodo padre antes que de los hijos.
            node.person.Accept(this);

            // Toma la edad de los nodos hijos mediante recurción.
            foreach (Node n in node.Children)
            {
                n.Accept(this);
            }
        }


        // * Metodo Visit para la clase Person.
        public override void Visit(Person person)
        {
            this.ChangeResult(person.GetAge());
        }


        public void ChangeResult(int age)
        {
            this.Result = Result + age;
        }

        // * Retorna el Resutlado
        public override string GetResult()
        {
            return this.Result.ToString();
        }

    }
}