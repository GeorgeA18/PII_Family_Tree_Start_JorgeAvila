using System;
using System.Text.RegularExpressions;

namespace Library
{
    public class LongestName : Visitor
    {
        private string NamePersonResult { get; set; }

        public LongestName()
        {
            this.NamePersonResult = "";
        }


        // * Metodo Visit para la clase Node.
        public override void Visit(Node node)
        {

            node.person.Accept(this);

            // Chequea la edad de los nodos hijos mediante recurción.
            foreach (Node n in node.Children)
            {
                
                n.Accept(this);
            }
        }


        // * Metodo Visit para la clase Person.
        public override void Visit(Person person)
        {
            string name = Regex.Replace(person.GetName(), @"\s", "");
            string nameResult = Regex.Replace(this.NamePersonResult, @"\s", "");
            
            // string NewString = Regex.Replace(OldString, @"\s", "");

            if (nameResult.Length < name.Length)
            {
                this.ChangeResult(person.GetName());
            }
            
        }


        public void ChangeResult(string name)
        {
            this.NamePersonResult = name;
        }

        // * Retorna un strign con el nombre y edad de la persona con mayor edad para su facil identificaión.
        public override string GetResult()
        {
            return this.NamePersonResult;
        }

    }
}