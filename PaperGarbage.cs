using System;

namespace wasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool isSqueezed { get; set; }

        public PaperGarbage(string ItemName, bool isDirty) : base(ItemName)
        {
            base.name = ItemName;
            this.isSqueezed = isDirty;
        }

        public void squeeze()
        {
            this.isSqueezed = true;
        }

    }
}
