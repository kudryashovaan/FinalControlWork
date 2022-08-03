void PrintArray (String[] col){
    for(int i=0; i<col.Length; i++){
        Console.Write(col[i] +" ");
    }
    Console.WriteLine();
}
String [] array = {"Hi", "1234", "Hi!"};
String [] result = new String[array.Length];

for (int i=0; i<array.Length; i++){
    if(array[i].Length <=3){
        result[i]=array[i];
    }
}

PrintArray (result);


