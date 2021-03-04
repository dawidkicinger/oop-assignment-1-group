using System;
using System.Linq;

namespace oop_assignment_1_group
{

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


            int[] array1 = { ld, lab, con, gr, bp , ukp, cuk, inet, ind };

            // Find maximum number.
          

            if (array1.Max() == bp)
                bp1 = (bp / 2);
            Console.WriteLine("BP1 " + bp1);

            int[] array2 = { ld, lab, con, gr, bp1, ukp, cuk, inet, ind };
            if (array2.Max() == bp1)
                bp2 = (bp1 / 2);
            Console.WriteLine("BP2 " + bp2);

            int[] array3 = { ld, lab, con, gr, bp2, ukp, cuk, inet, ind };

            if (array3.Max() == ld)
                ld1 = (ld / 2);
            Console.WriteLine("LD1 " + ld1);

            int[] array4 = { ld1, lab, con, gr, bp2, ukp, cuk, inet, ind };

            if (array4.Max() == lab)
                lab1 = (lab / 2);
            Console.WriteLine("LAB1 " + lab1);

            int[] array5 = { ld1, lab1, con, gr, bp2, ukp, cuk, inet, ind };

            if (array5.Max() == con)
                con1 = (con / 2);
            Console.WriteLine("CON1 " + con1);




        }
        
        
        
        
        
        
        
               
        
    }
        
           
       
}    


    



    
   



