using System;
using System.Collections.Generic;
using System.Linq;
using lab6.by.bsu.lab6.entity;

namespace lab6.by.bsu.lab6
{
    public class StorableBluRayEntity
    {
        public List<BluRay.Record> Records { get; set; }

        public List<BluRay.Catalog> Catalogs { get; set; }

        public StorableBluRayEntity()
        {
            Records = new List<BluRay.Record>();
            Catalogs = new List<BluRay.Catalog>();
        }

        public StorableBluRayEntity(List<BluRay.Record> records, List<BluRay.Catalog> catalogs)
        {
            Records = records;
            Catalogs = catalogs;
        }

        public void AddCatalog(BluRay.Catalog catalog)
        {
            Catalogs.Add(catalog);
        }

        public void AddRecord(BluRay.Record record)
        {
            Records.Add(record);
        }

        public void RemoveRecord(BluRay.Record recordToRemove)
        {
            var recordInList = Records.SingleOrDefault(record => record.Name.Equals(recordToRemove.Name));
            if (recordInList != null)
                Records.Remove(recordInList);
        }

        public void RemoveCatalog(BluRay.Catalog catalogToRemove)
        {
            var catalogInDisk = Catalogs.SingleOrDefault(catalog => catalog.Name.Equals(catalogToRemove.Name));
            if (catalogInDisk != null)
                Catalogs.Remove(catalogInDisk);
        }

        public override string ToString()
        {
            return $"{nameof(Records)}: {string.Join( ",", String.Concat(Records) )}, \n {nameof(Catalogs)}: {String.Concat(Catalogs)}";
        }
    }
}