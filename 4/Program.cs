//0 - незакрашенный 1 - закрашенный пиксель
int[,] pic = new int[,]
{
    {0000000000000000000000000},
    {0000000000011000000000000},
    {0000000000100100000000000},
    {0000000000100100000000000},
    {0000000001000100000000000},
    {0000000001000100000000000},
    {0000000010001000000000000},
    {0000001100011000000000000},
    {0000001111111000000000000},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{matr[i, j]} ");
            if(image[i,j] == 0) 
            {
                Console.Write($" ");
            }
            else 
            {
                Console.Write($"+");
            }

        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if(pic[row, col])
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row +1, col);
        FillImage(row,col + 1);
    }
}

PrintImage(pic);
FillImage(13,3);