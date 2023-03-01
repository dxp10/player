using System.IO;

namespace Music
{
    class MediaFile
    {
        private string filePath;
        internal MediaFile(string filePath)
        {
            this.filePath = filePath;
        }

        internal string FileName { get => Path.GetFileName(filePath); }
        internal string FilePath { get => filePath; }
    }
}
