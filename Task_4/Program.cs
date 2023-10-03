int [, ] FillSpiral(int size, int step){
    int [, ] matrix = new int[size, size];
    int k = 10;
    int rowBegin = 0;
    int rowEnd = size;
    int columBegin = 0;
    int columnEnd = size;
    while (true){
        if (rowBegin == rowEnd) break;
        for (int i = rowBegin; i < rowEnd; i++){
            matrix[columBegin,i] = k;
            k +=step;
        }
        columBegin++;
        if (columBegin == columnEnd) break;
        for (int i = columBegin; i < columnEnd; i++){
            matrix[i,rowEnd-1] = k;
            k += step;
        }
        rowEnd--;
        if (rowEnd == (rowBegin)) break;
        for (int i = rowEnd-1; i > rowBegin; i--){
            matrix[columnEnd-1, i] = k;
            k += step;
        }
        columnEnd--;
        if (columnEnd == columBegin - 1) break;
        for (int i = columnEnd; i >= columBegin; i--){
            matrix[i, rowBegin] = k;
            k += step;
        }
        rowBegin++;
    }
    return matrix;
}

void PrintArray(int[, ] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write(matrix[i,j] + " ");
        }
        System.Console.WriteLine();  
    } 
}

PrintArray(FillSpiral(4,1));

