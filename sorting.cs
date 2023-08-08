using System;

class Sorting 
{
    public class collection
    {
        int[] Coll = new int[100];
        int size;
        
        private void Swap(int p, int q){
            int temp = Coll[p];
            Coll[p] = Coll[q];
            Coll[q] = temp;
        }        

        public void PrintColl(){
            for(int i=0; i<size; i++){
                Console.Write(Coll[i] + " ");
            }
            Console.WriteLine(" ");
        }
        
        public void BubbleSort(){
            int i, j;
            
            for(i=0; i<size; i++){
                for(j=0; j<size-i-1; j++){
                    if(Coll[j] > Coll[j+1])
                        Swap(j, j+1);
                }
            }
        }
        
        public void GetData(){
            int pos = 0;
            int num;
            string input;
            bool check;
            
            while(true){
                input = Console.ReadLine();
                check = int.TryParse(input, out num);
                if(check == true){
                    //Console.WriteLine(num);
                    if(pos < 100){
                        Coll[pos] = num;
                        pos++;
                    }else{
                        size = pos;
                        break;
                    }
                }
                else{
                    size = pos;
                    break;
                }
            }
            
        }
        
        
    }
  static void Main() 
  {
        collection c1 = new collection();
        
        c1.GetData();
        
        c1.BubbleSort();
        
        c1.PrintColl();
        
  }
}
