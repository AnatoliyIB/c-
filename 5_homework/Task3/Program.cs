int[] SumRows(int[,] array)
    {
      int [] sumrow= new int [array.GetLength(0)];
     int sum=0;
      //Напишите свое решение здесь
      for (int i=0; i<array.GetLength(0); i++)
      {
        sum=0;
        for (int j=0; j<array.GetLength(1); j++)
        {
          sum=sum+array[i,j];
          sumrow[i]=sum;
        }
        
      }
      return sumrow;
    }
    
    void PrintArray (int [] array)
    {
        for (int i=0; i<array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
    }
    
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};
int [] result=SumRows(numbers);
PrintArray(result);