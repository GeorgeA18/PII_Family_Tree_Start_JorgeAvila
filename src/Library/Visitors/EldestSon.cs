using System;

namespace Library
{
    public class EldestSon : Visitor
    {
        private string NamePersonResult { get; set; }
        private int AgePersonResult { get; set; }

        public EldestSon()
        {
            this.NamePersonResult = "";
            this.AgePersonResult = 0;
        }


        // * Metodo Visit para la clase Node.
        public override void Visit(Node node)
        {   

            // Chequea la edad de los nodos hijos mediante recurción.
            foreach (Node n in node.Children)
            {
                n.person.Accept(this);
                n.Accept(this);
            }
        }


        // * Metodo Visit para la clase Person.
        public override void Visit(Person person)
        {
            int age = person.GetAge();
            if (this.AgePersonResult < age)
            {
                this.ChangeResult(person.GetName(),age);
            }
            
        }


        public void ChangeResult(string name, int age)
        {
            this.NamePersonResult = name;
            this.AgePersonResult = age;
        }

        // * Retorna un strign con el nombre y edad de la persona con mayor edad para su facil identificaión.
        public override string GetResult()
        {
            string text = $"Nombre: {this.NamePersonResult}, Edad: {this.AgePersonResult}";
            return text;
        }

    }
}