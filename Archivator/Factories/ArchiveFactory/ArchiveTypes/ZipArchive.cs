using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.ArchiveTypes
{
    class ZipArchive : IArchive
    {
        public string ReadArchiveInfo()
        {
            return "zip archive info";
        }
    }
}
