using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.ArchiveTypes
{
    class TagArchive : IArchive
    {
        public string ReadArchiveInfo()
        {
            return "tag archive with cache info";
        }
    }
}

