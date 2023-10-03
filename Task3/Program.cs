int[] FillNotRepeat(int size, int min, int max){
    int[] array = new int[size];
    Random rand = new Random();
    array[0] = rand.Next(min, max+1);
    for (int i = 1; i < size; i++){
        bool isTrue = false;
        int value = 0;
        while(!isTrue){
            value = rand.Next(min, max+1);
            for (int j = 0; j < size; j++){
                if (value == array[j]){
                    isTrue = false;
                    break;
                }
                isTrue = true;
            }
        }
        array[i] = value;
    }
    return array;

}

void PrintArr(int[] array){
    for (int i = 0; i < array.Length; i++){
        System.Console.Write(array[i] + " ");
    }
}

int[,, ] GetArray(int sizeA, int sizeB, int sizeC){
    int[,, ] massive = new int[sizeA, sizeB, sizeC];
    int[] tempArray = FillNotRepeat(sizeA * sizeB * sizeC, 10, 99);
    int m = 0;
    for (int i = 0; i < sizeA; i++){
        for (int j = 0; j < sizeB; j++){
            for (int k = 0; k < sizeC; k++){
                massive[i, j, k] = tempArray[m];
                m++;
            }
        }
    }
    return massive;
}

void PrintArray(int[,, ] massive){
    for (int i = 0; i < massive.GetLength(0); i++){
        for (int j = 0; j < massive.GetLength(1); j++){
            for (int k = 0; k < massive.GetLength(2); k++){
                System.Console.WriteLine($"{massive[i,j,k]}({i},{j},{k}) ");
            }
        }
    }
}

PrintArray(GetArray(2,2,2));
