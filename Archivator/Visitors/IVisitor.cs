using Archivator.MockedData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.Visitors
{
    interface IVisitor
    {
        void VisitImageFile(ImageFile imageFile);
        void VisitVideoFile(VideoFile videoFile);
    }
}
