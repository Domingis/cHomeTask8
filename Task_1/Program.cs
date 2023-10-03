

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



void SortMatrix(int [, ] matrix){
    for (int k = 0; k < matrix.GetLength(0); k++){
        for (int i = 0; i < matrix.GetLength(1); i++){
            for (int j = 0; j < matrix.GetLength(1)-1-i; j++){
                if (matrix[k,j] < matrix[k,j+1]){
                    int temp = matrix[k,j];
                    matrix[k,j] = matrix[k,j+1];
                    matrix[k,j+1] = temp;
                }
            }
        }   

    }
}

int [, ] matrix = GetMatrix(4, 5, 1, 9);
PrintMatrix(matrix);
SortMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);