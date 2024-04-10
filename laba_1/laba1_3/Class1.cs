using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_3
{

    class Program
    {
        static void Main(string[] args)
        {
            // Создание дерева
            Node root = new Node("Корень", new List<Node>
        {
            new Node("Ребенок 1", new List<Node>
            {
                new Node("Внук 1"),
                new Node("Внук 2")
            }),
            new Node("Ребенок 2", new List<Node>
            {
                new Node("Внук 3", new List<Node>
                {
                    new Node("Правнук 1")
                })
            }),
            new Node("Ребенок 3")
        });

            // Вывод всех значений дерева
            root.PrintAllValues();
        }
    }

    class Node
    {
        // Свойство для хранения значения узла
        public string Value { get; set; }

        // Список дочерних узлов
        public List<Node> Children { get; set; }

        // Конструктор для узла без потомков
        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
        }

        // Конструктор для узла с потомками
        public Node(string value, List<Node> children)
        {
            Value = value;
            Children = children;
        }

        // Метод для печати всех значений узла и его потомков
        public void PrintAllValues()
        {
            Console.WriteLine(Value); // Выводится значение текущего узла
            foreach (var child in Children) // Рекурсивный проход по всем детям
            {
                child.PrintAllValues(); // Вывод значений всех потомков
            }
        }
    }
}
