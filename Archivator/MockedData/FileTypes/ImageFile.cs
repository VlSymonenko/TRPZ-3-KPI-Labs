using Archivator.Visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.MockedData
{
    class ImageFile:File
    {
        public ImageFile(string name,string type) : base(name,type)
        {
              
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitImageFile(this);
        }
    }
}
