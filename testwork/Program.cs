
string[] array = new string[12] {"Архангельск", "Три", "Табурет", "11", "Кот", "Собака", "Лист", "34", "№?%", "Одинадцать", "Тротуар", "Dotnet"};

string[] ReduceArray(string[] array){
    string[] arr = new string[array.Length];
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length > 3){
            arr = new string[array.Length - 1];
            for (int j = 0; j < i; j++){
                arr[j] = array[j];
            }
            for (int n = i; n < array.Length - 1; n++){
                arr[n] = array[n+1];
            }
            array = arr;
            i = -1;
            //Console.WriteLine($"[{String.Join(", ", array)}]!!!");

        }
    }
    return arr;
}

string[] newarray = ReduceArray(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", newarray)}]");

