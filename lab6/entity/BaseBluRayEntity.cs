using System;

namespace lab6.by.bsu.lab6.entity
{
    public class BaseBluRayEntity
    {
        public string Name { get; set; }
        private DateTime CreationTime { get; set; }

        protected BaseBluRayEntity(string name, DateTime creationTime)
        {
            Name = name;
            CreationTime = creationTime;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(CreationTime)}: {CreationTime}";
        }
    }
}