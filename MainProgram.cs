using System;

namespace wasteRecycling
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Garbage plastic = new PlasticGarbage("Plastic spoon", true);
            Garbage paper = new PaperGarbage("Paper cup", true);
            Garbage garbage = new Garbage("Bread");
            Garbage garbage2 = new Garbage("Rotten fruit");

            Dustbin dustb = new Dustbin();
            dustb.color = "Red";

            dustb.throwOutGarbage(plastic);
            dustb.throwOutGarbage(paper);
            dustb.throwOutGarbage(garbage);
            dustb.throwOutGarbage(garbage2);

            dustb.displayContents();

            dustb.emptyContents();
            dustb.displayContents();
            
        }
    }
}
