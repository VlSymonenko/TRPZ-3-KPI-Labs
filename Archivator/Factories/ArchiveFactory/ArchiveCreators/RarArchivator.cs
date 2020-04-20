using Archivator.ArchiveTypes;
using Archivator.Factories.ArchiveFactory;
using Archivator.interfaces;
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
            //add to algorithm graf of files
            Console.WriteLine("rar file arhivating");
            return new RarArchive();
        }
    }
}
