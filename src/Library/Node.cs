using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        private List<Node> children = new List<Node>();

        public Person person;
        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number,Person person)
        {
            this.number = number;
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }


        public void Accept(Visitor visitor)
        {

            visitor.Visit(this);
        }

        public string GetNamePerson()
        {
            return this.person.GetName();
        }

        public int GetAgePerson()
        {
            return this.person.GetAge();
        }
        
    }
}
