using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemCompositePattern
{
    abstract class FileSystemComponent
    {
        private string _name;

        protected FileSystemComponent(string name)
        {
               _name = name;    
        }
        
        protected abstract void Display();
        protected abstract void Add(FileSystemComponent component);
        protected abstract void Remove(FileSystemComponent component);
    }
}
