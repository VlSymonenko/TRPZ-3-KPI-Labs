using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.Factories.ArchiveFactory
{
   abstract class ArchivatorFactory
    {
        public void getArchiveInfo()
        {
            IArchive archive = Archivate();
            Console.WriteLine(archive.ReadArchiveInfo());
        }

        public abstract IArchive Archivate();
    }
}
