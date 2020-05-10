using System;
using System.Collections.Generic;
using System.Text;
using Archivator.MockedData;

namespace Archivator.Visitors
{
    class TestVisitor : IVisitor
    {
        public void VisitImageFile(ImageFile imageFile)
        {
            Console.WriteLine("Checking imageFile for errors");
        }

        public void VisitVideoFile(VideoFile videoFile)
        {
            Console.WriteLine("Checking videoFile for errors");
        }
    }
}
