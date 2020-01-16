using System;

namespace wasteRecycling
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Garbage plastic = new PlasticGarbage("Mûanyag Kanál", true);
            Garbage paper = new PaperGarbage("Papir pohár", true);
            Garbage garbage = new Garbage("Kenyér");
            Garbage garbage2 = new Garbage("Romlott gyümölcs");

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
