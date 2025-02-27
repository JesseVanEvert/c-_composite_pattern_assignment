﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemCompositePattern
{
    public class File : FileSystemComponent
    {
        public File(string name) : base(name)
        {
        }

        public override void Add(FileSystemComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int indentLevel = 0)
        {
            Console.WriteLine($"{new string('-', indentLevel)} {_name}");
        }


        public override void Remove(FileSystemComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
