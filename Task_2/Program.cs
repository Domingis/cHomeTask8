

int[, ] GetMatrix(int rowsCount, int columsCount, int minValue, int maxValue){
    int[, ] matrix = new int[rowsCount,columsCount];
    Random rand= new Random();
    for (int i = 0; i < rowsCount; i++){
        for (int j = 0; j < columsCount; j++){
            matrix[i,j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[, ] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write(matrix[i,j] + " ");
        }
        System.Console.WriteLine();  
    } 
}



int MinRow(int [, ] matrix){
    int minSum = 0;
    int row = 1;
    for (int j = 0; j < matrix.GetLength(1); j++){
        minSum += matrix[0, j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++){
            sum += matrix[i,j];
        }
        if (minSum > sum){ 
            minSum = sum;
            row = i+1;
        }

    }
    return row;
}

int [, ] matrix = GetMatrix(4, 3, 1, 9);
PrintMatrix(matrix);
System.Console.WriteLine($"{MinRow(matrix)} строка");
