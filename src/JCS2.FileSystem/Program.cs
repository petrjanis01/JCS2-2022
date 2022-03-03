using System;
using System.IO;
using System.IO.Compression;

namespace JCS2.FileSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        #region Basics

        public static void ReadFromDocumentByLine()
        {
            //var path = "path\\to\\document";
            var path = "C:\\School\\test.txt";

            if (File.Exists(path) == false)
            {
                Console.WriteLine("Error...");
                return;
            }

            var sr = new StreamReader(path);

            var line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);

                line = sr.ReadLine();
            }

            sr.Close();
        }

        public static void ReadEverything()
        {
            //var path = "path\\to\\document";
            var path = @"C:\School\test.txt";

            using (var sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        public static void ReadFromDocumentByChar()
        {
            //var path = @"path\to\document";
            var path = @"C:\School\test.txt";

            using (var sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false)
                {
                    var character = sr.Read();

                    Console.WriteLine((char)character);
                }
            }
        }

        public static void WriteToDocumentByLine()
        {
            //var path = @"path\to\document";
            var path = @"C:\School\test.txt";

            // File is created if does not exist.
            // In this configuration all previous content of file will be deleted.
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello world");
            }
        }

        public static void WriteToDocumentAppend(string path = @"C:\School\test.txt")
        {
            // In this configuration StreamWriter will append to the end of the file.
            using (var sw = new StreamWriter(path, append: true))
            {
                sw.WriteLine("Hello world");
            }
        }

        #endregion

        #region Directories

        public static string GetLocalRepositoryPathRelative()
        {
            var baseAppPath = AppContext.BaseDirectory;
            var path = Path.Combine(baseAppPath);

            for (var i = 0; i < 4; i++)
            {
                path = Path.Combine(path, "..");
            }

            return path;
        }

        public static void PrintRepositoryContentRelative()
        {
            var repositoryPath = GetLocalRepositoryPathRelative();
            DirectoryInfo repositoryInfo = new DirectoryInfo(repositoryPath);

            foreach (FileInfo fi in repositoryInfo.EnumerateFiles())
            {
                Console.WriteLine(fi);
            }

            foreach (DirectoryInfo dir in repositoryInfo.EnumerateDirectories())
            {
                Console.WriteLine(dir);
            }
        }

        public static void PrintRepositoryContent()
        {
            var baseAppPath = AppContext.BaseDirectory;
            var repositoryInfo = new DirectoryInfo(baseAppPath);

            for (var i = 0; i < 4; i++)
            {
                repositoryInfo = repositoryInfo.Parent;
            }

            foreach (FileInfo fi in repositoryInfo.EnumerateFiles())
            {
                Console.WriteLine(fi);
            }

            foreach (DirectoryInfo dir in repositoryInfo.EnumerateDirectories())
            {
                Console.WriteLine(dir);
            }
        }

        #endregion

        #region Zip

        public static void CompressFile()
        {
            var fileToCompress = new FileInfo(@"C:\School\test.txt");

            if (fileToCompress.Exists == false)
            {
                Console.WriteLine("Error");
                return;
            }

            var content = File.ReadAllText(fileToCompress.FullName);

            using (var zipStream = new GZipStream(File.Create(@"C:\School\test.gzip"), CompressionLevel.Optimal))
            using (var sw = new StreamWriter(zipStream))
            {
                sw.WriteLine(content);
            }
        }

        public static void DecompressFile()
        {
            using (var zipStream = new GZipStream(File.Open(@"C:\School\test.gzip", FileMode.Open), CompressionMode.Decompress))
            using (var sr = new StreamReader(zipStream))
            {
                var text = sr.ReadToEnd();
                File.WriteAllText(@"C:\School\test-decompressed.txt", text);
            }
        }

        #endregion
    }
}
