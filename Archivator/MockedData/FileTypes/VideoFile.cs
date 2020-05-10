using Archivator.Visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.MockedData
{
    class VideoFile : File
    {
        public VideoFile(string name, string type) : base(name,type)
        {

        }
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitVideoFile(this);
        }
    }
}
