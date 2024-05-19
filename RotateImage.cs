public class Solution {
    public void Rotate(int[][] matrix) {

        int matrixlen=matrix.GetLength(0);
        // Step 1: Transpose the matrix
        for(int i=0; i<matrixlen; i++){
            for(int j=0+i; j<matrixlen; j++){
                int temp=matrix[i][j];
                matrix[i][j]=matrix[j][i];
                matrix[j][i]=temp;
            }  
        }
        // Step 2: Reverse each row
        for(int i=0; i<matrixlen; i++){
            for(int j=0; j<matrixlen/2; j++){
                int temp=matrix[i][j];    
                matrix[i][j]=matrix[i][matrixlen-1-j];
                matrix[i][matrixlen-1-j]=temp; 
            } 
        }
    }
}