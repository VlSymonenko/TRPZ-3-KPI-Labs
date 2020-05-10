using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.MockedData
{
    class TestFolder
    {
        static List<File> files = new List<File>{ new ImageFile("Image1.png", "png"), new VideoFile("Video.mp4", "mp4") };
        public TestFolder()
        {

        }
    }
}
