using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemCompositePattern
{
    public abstract class FileSystemComponent
    {
        protected string _name;

        protected FileSystemComponent(string name)
        {
               _name = name;    
        }
        
        public abstract void Display(int indentLevel);
        public abstract void Add(FileSystemComponent component);
        public abstract void Remove(FileSystemComponent component);
    }
}
