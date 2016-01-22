namespace CohesionAndCoupling
{
    using System;

    public static class FileNameGetter
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;

                // Or can throw Exception
                // throw new ArgumentException("There is no extension of this File");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string wantedFileName = fileName.Substring(0, indexOfLastDot);
            return wantedFileName;
        }
    }
}
