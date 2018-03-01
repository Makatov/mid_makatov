using System;
using System.IO;

namespace mid1
{
    class car
    {
        
    }
    class MainClass
    {
        public static void Main(string[] args){

			/* {
				 StreamReader sr = new StreamReader(@"input.txt");
				 string s = sr.ReadLine();
				 string[] arr = new string[int.Parse(s)];
				 for (int i = 0; i < int.Parse(s); i++)
				 {
					 arr[i] = sr.ReadLine(); 
				 }
				 int max = new int();
				 max = 0;
				 for (int i = 0; i < int.Parse(s); i++ )
				 {
					 string[] list = arr[i].Split(); 

				 }
				 for (int i = 1; i < int.Parse(s); i = i+3)
				 {
					 if (max < list +int.Parse(list[i+2]))
					 {
						 max = int.Parse(arr[i]) + int.Parse(arr[i + 2]);
					 }

				 }

		 */
			string text = System.IO.File.ReadAllText(@"input.txt");
			string[] arr = text.Split(' ');
            int n = int.Parse(arr[0]);
            int max = 0;
            int sum = 0;
			string ans = "";
            int indexofcar = 0;
            for (int i = 1; i <= n*3 ; i=i+3)
			{
                sum = ((int.Parse(arr[i]) + (int.Parse(arr[i + 2]))));
                if (max <= sum)
				{
                    max = sum;
					indexofcar++;
				}
                for (int j = 1; j < n * 3; j++)
                {
                    if (int.Parse(arr[j]) == indexofcar)
                    {
                           ans = arr[j];
                    }
                }

                sum = 0;
            }
     
            System.IO.File.WriteAllText(@"output.txt",ans);
        }
	
		
		
           
         
    }

}
