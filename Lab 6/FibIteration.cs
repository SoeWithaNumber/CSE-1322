using System;
class FibIteration : FindFib{
    public FibIteration(){
        
    }
    public int calculateFib(int index){
        if(index == 1 || index == 2){
            return 1;
        }
        int first = 1;
        int second = 1;

        for (int i = 0; i < index-2; i++)
        {
            int next = first + second;
            first = second;
            second = next;
        }
        return second;
    }
}