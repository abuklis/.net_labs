using System;
using lab6.by.bsu.lab6.entity;

namespace lab6.by.bsu.lab6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sonyBluRay = new BluRay("Sony", 100.0);
            
            var record = new BluRay.Record("bsu.mp3", DateTime.Now, 3.4);
            
            sonyBluRay.AddRecord(record);
            
            var musicCatalog = new BluRay.Catalog("music", DateTime.Now);
            
            sonyBluRay.AddCatalog(musicCatalog);
            
            Console.WriteLine(sonyBluRay);
            
        }
    }
}