using System;

namespace wasteRecycling
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Garbage plastic = new PlasticGarbage("M�anyag Kan�l", true);
            Garbage paper = new PaperGarbage("Papir poh�r", true);
            Garbage garbage = new Garbage("Keny�r");
            Garbage garbage2 = new Garbage("Romlott gy�m�lcs");

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
