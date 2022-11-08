using System;


namespace Library
{
    public class Person
    {
        private string Name{get;set;}
        private int Age{get;set;}

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Metodo que retorna el nombre.
        public string GetName()
        {
            return this.Name;
        }
        // Metodo que retorna la edad.
        public int GetAge()
        {
            return this.Age;
        }

        public void Accept(Visitor visitor)
        {

            visitor.Visit(this);
        }

    }
}
