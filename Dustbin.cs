using System;
using System.Collections.Generic;

namespace wasteRecycling
{
    public class Dustbin
    {
        public string color { get; set; }
        PaperGarbage[] paperContent=new PaperGarbage[50];
        PlasticGarbage[] plasticContent = new PlasticGarbage[50];
        Garbage[] houseWasteContent=new Garbage[50];

        public void displayContents()
        {
            Console.WriteLine(color + " Dustbin!" + "\n");

            if (houseWasteContent != null)
            {
                int elements = 0;
                for(int count=0;count<houseWasteContent.Length;count++)
                {
                    if(houseWasteContent[count]!=null)
                    {
                        elements++;
                    }
                }

                Console.WriteLine("House waste content: " + (elements).ToString());
                Console.WriteLine();

                for (int count = 0; count < elements; count++)
                {
                    Console.WriteLine("\t" + houseWasteContent[count].name);
                }
            }

            else
            {
                Console.WriteLine("House waste content: 0");
            }

            if (paperContent != null)
            {
                int elements = 0;
                for (int count = 0; count < paperContent.Length; count++)
                {
                    if (paperContent[count] != null)
                    {
                        elements++;
                    }
                }

                Console.WriteLine("\nPaper content: " + (elements).ToString());
                Console.WriteLine();
                for (int count = 0; count < elements; count++)
                {
                    Console.WriteLine("\t" + paperContent[count].name);
                }
            }

            else
            {
                Console.WriteLine("\nPaper content: 0");
            }

            if (plasticContent != null)
            {
                int elements = 0;
                for (int count = 0; count < plasticContent.Length; count++)
                {
                    if (plasticContent[count] != null)
                    {
                        elements++;
                    }
                }

                Console.WriteLine("\nPlastic content: " + (elements).ToString());
                Console.WriteLine();
                for (int count = 0; count < elements; count++)
                {
                    Console.WriteLine("\t" + plasticContent[count].name);
                }
            }

            else
            {
                Console.WriteLine("\nPlastic content: 0");
            }
        }

        public void throwOutGarbage(Garbage garbage)
        {

            if (garbage is PaperGarbage)
            {
                PaperGarbage garbageToCheck=(PaperGarbage) garbage;
                if (garbageToCheck.isSqueezed)
                {
                    for (int count = 0; count < paperContent.Length; count++)
                    {
                        if(paperContent[count]==null)
                        {
                            paperContent[count] = garbageToCheck;
                            Console.WriteLine(paperContent[count].name);
                            break;
                        }

                    }
                }
            }
        
            else if (garbage is PlasticGarbage)
            {
                PlasticGarbage garbageToCheck = (PlasticGarbage)garbage;
                if (garbageToCheck.isClean)
                {
                    for (int count = 0; count < plasticContent.Length; count++)
                    {
                        if (plasticContent[count] == null)
                        {
                            plasticContent[count] = garbageToCheck;
                            Console.WriteLine(plasticContent[count].name);
                            break;
                        }

                    }
                }
            }

            else if (garbage is Garbage)
            {
                for (int count = 0; count < houseWasteContent.Length; count++)
                {
                    if (houseWasteContent[count] == null)
                    {
                        houseWasteContent[count] = garbage;
                        Console.WriteLine(houseWasteContent[count].name);
                        break;
                    }
                }
            }

            else
            {
                throw new DustbinContentException();
            }
        }

        public void emptyContents()
        {
            this.paperContent = null;
            this.plasticContent = null;
            this.houseWasteContent = null;
        }
    }
}
