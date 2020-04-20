using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.ArchiveTypes
{
    class RarArchive : IArchive
    {
       public string ReadArchiveInfo()
        {
            return "rar archive info";
        }
    }
}
