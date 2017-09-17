using System;
using System.Collections.Generic;
using System.Text;

namespace Updater
{
    class UFile
    {
        public readonly string fileName;
        public readonly string filePath;
        public readonly int fileSize;

        public UFile(string file, int filesize)
        {
            this.filePath = file;
            this.fileName = file.Substring(file.LastIndexOf('/') + 1);
            this.fileSize = filesize;
        }

    }
}
