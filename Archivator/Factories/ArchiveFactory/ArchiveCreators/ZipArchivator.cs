using Archivator.ArchiveTypes;
using Archivator.Factories.ArchiveFactory;
using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.ArchiveCreators
{
    class ZipArchivator : ArchivatorFactory
    {
        public override IArchive Archivate()
        {
            Console.WriteLine("zip file arhivating");
            return new ZipArchive();
        }
    }
}
