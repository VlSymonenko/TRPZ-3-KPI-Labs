using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.MockedData
{
    class Folder
    {
        private List<File> files;
        public List<File> Files
        {
            get { return files; }
            set { files = value; }
        }
        public Folder(List<File> files)
        {
            this.files = files;
        }
       public void AddFileToFolder(File file)
        {   
            this.files.Add(file);
        }
    }
}
