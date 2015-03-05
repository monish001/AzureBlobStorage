using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AzureBlobStorageProto
{
    class Program
    {
        public static string blobName = "testfile10mb", containerName = "anuploads", file = @"D:\10mbtemp.csv", file2 = @"D:\temp.txt";
        static void Main(string[] args)
        {
            upload();
            download();
            Console.ReadKey();
        }

        public static void upload()
        {
            var crud = new AzureStorageCRUD();
            //var container = crud.GetContainer("testcontainer");
            var container = crud.GetContainer(containerName);
            crud.UploadFile(container, blobName, file);
            Console.WriteLine("uploaded");
        }

        public static void download()
        {
            string text;
            {
                var crud = new AzureStorageCRUD();
                //var container = crud.GetContainer("testcontainer");
                var container = crud.GetContainer(containerName);
                text = crud.DownloadFile(container, blobName);
                Console.WriteLine("dled");
            }
        }
    }
}
