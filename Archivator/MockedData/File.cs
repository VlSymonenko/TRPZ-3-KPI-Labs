using Archivator.Visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.MockedData
{
   abstract class File
    {
        private string name;
        private string type;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public File(string name,string type)
        {
            this.name = name;
            this.type = type;
        }
        public abstract void Accept(IVisitor visitor);
    }
}
