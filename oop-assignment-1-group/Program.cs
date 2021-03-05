using System;
using System.Linq;

namespace oop_assignment_1_group
{
    //DATA used

    //Brexit Party,     452321,     BP1,BP2,BP3,BP4,BP5;
    //Liberal Democrats,        203989      ,LD1,LD2,LD3,LD4,LD5;
    //Labour,       164682      ,LAB1,LAB2,LAB3,LAB4,LAB5;
    //Conservative,     126138      ,CON1,CON2,CON3,CON4,CON5;
    //Green,        124630,     GR1,GR2,GR3,GR4,GR5;
    //UKIP,     58198,       UKP1,UKP2,UKP3,UKP4,UKP5;
    //Change UK,        41117,      CUK1,CUK2,CUK3,CUK4,CUK5;
    //Independent Network,      7641,     INET1,INET2,INET3,INET4,INET5;
    //Independent,      4511,     IND1;

    class Program
    {





        static void Main()
        {
            //variable implementation

            int bp = 452321;
            int ld = 203989;
            int lab = 164682;
            int con = 126138;
            int gr = 124630;
            int ukp = 58198;
            int cuk = 41117;
            int inet = 7541;
            int ind = 4511;
            int bp1 = 0;
            int bp2 = 0;
            int ld1 = 0;
            int lab1 = 0;
            int con1 = 0;

            // array list #1
            int[] array1 = { ld, lab, con, gr, bp , ukp, cuk, inet, ind };

            // Find maximum number for first result.
            if (array1.Max() == bp)
            // Divide it by 2 the to get the answer
                bp1 = (bp / 2);
            Console.WriteLine("BP1 " + bp1);

            // array list #2
            int[] array2 = { ld, lab, con, gr, bp1, ukp, cuk, inet, ind };

            // Find maximum number second result.
            if (array2.Max() == bp1)
            // Divide it by 2 to get the answer
                bp2 = (bp1 / 3);
            Console.WriteLine("BP2 " + bp2);

            // array list #3
            int[] array3 = { ld, lab, con, gr, bp2, ukp, cuk, inet, ind };

            // Find maximum number for third result
            if (array3.Max() == ld)
            // Divide it by 2 to get the answer
                ld1 = (ld / 2);
            Console.WriteLine("LD1 " + ld1);

            // array list #4
            int[] array4 = { ld1, lab, con, gr, bp2, ukp, cuk, inet, ind };

            // Find maximum number for third result
            if (array4.Max() == lab)
            // Divide it by 2 to get the answer
                lab1 = (lab / 2);
            Console.WriteLine("LAB1 " + lab1);

            // array list #5
            int[] array5 = { ld1, lab1, con, gr, bp2, ukp, cuk, inet, ind };

            // Find maximum number for third result
            if (array5.Max() == con)
            // Divide it by 2 to get the answer
                con1 = (con / 2);
            Console.WriteLine("CON1 " + con1);

            Console.WriteLine("Would you like to see the results again?");


        }
        
        
        
        
        
        
        
               
        
    }
        
           
       
}    


    



    
   



