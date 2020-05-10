using Archivator.ArchiveTypes;
using Archivator.Factories.ArchiveFactory;
using Archivator.interfaces;
using Archivator.MockedData;
using Archivator.Visitors;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace Archivator.ArchiveCreators
{
    class RarArchivator : ArchivatorFactory
    {
        public override IArchive Archivate()
        {
            Folder folder = new Folder(new List<File> { new ImageFile("Image1.png", "png"), new VideoFile("Video.mp4", "mp4") });
            TestVisitor testVisitor = new TestVisitor();
            foreach(var file in folder.Files)
            {
                file.Accept(testVisitor);
            }
            Console.WriteLine("rar file arhivating");
            return new RarArchive(folder);
        }
    }
}
