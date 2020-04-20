using Archivator.ArchiveTypes;
using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.ArchiveCreators
{
    class TagArchivator
    {
            public TagArchive CacheArchivate()
            {
            Console.WriteLine("tag files arhivating");
            return new TagArchive();
            }
    }
}
