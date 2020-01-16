using System;

namespace wasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool isClean { get; set; }

        public PlasticGarbage(string itemName, bool isClean):base(itemName)
        {
            base.name=itemName;
            this.isClean = isClean;
        }

        public void clean()
        {
            this.isClean = true;
        }
    }
}
