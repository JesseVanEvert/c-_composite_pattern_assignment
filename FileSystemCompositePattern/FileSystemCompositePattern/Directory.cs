using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemCompositePattern
{
    public class Directory : FileSystemComponent
    {
        private List<FileSystemComponent> components = [];
        public Directory(string name) : base(name)
        {
        }

        public override void Add(FileSystemComponent component)
        {
            components.Add(component);
        }

        public override void Display(int indentLevel = 0)
        {
            Console.WriteLine($"{new string('-', indentLevel)} {_name}");

            foreach (FileSystemComponent component in components)
            {
                component.Display(indentLevel + 2);  
            }
        }


        public override void Remove(FileSystemComponent component)
        {
            components.Remove(component);
        }
    }
}
