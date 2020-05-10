using Archivator.interfaces;
using Archivator.MockedData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.ArchiveTypes
{
    class RarArchive : IArchive
    {
        private Folder folder;
        public RarArchive(Folder folder)
        {
            this.folder = folder;
        }
       public string ReadArchiveInfo()
        {
            foreach(var file in folder.Files)
            {
                Console.WriteLine("File with name " + file.Name);
            }
            return "rar archive info";
        }
    }
}
