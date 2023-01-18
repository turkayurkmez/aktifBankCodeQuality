
int i; //kullanıcının kayıt olduğu tarihten bu yana geçen gün...



int daysSinceUserCreation = 15;
//evrensel isimler = ingilizce:
int musterininKaydidanBuyanaGecenGunSayisi = 10;

var hitPoint = 0;
/*
 * 1. Horse power
 * 2. Health Point
 * 3. HP Laptop sayısı
 * 4. Hit Point
 */
//var o = 0;
//var l = 1;

//if (o == l)
//{

//}

List<int[]> cellsOnBoardGame = new List<int[]>();

List<int[]> getFlaggedCellsOnGameBoard()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cellsOnBoardGame)
    {
        checkCellIsFlgagged(flaggedCells, cell);
    }
    return flaggedCells;
}


void checkCellIsFlgagged(List<int[]> flaggedCells, int[] cell)
{
    if (cell[0] == Flags.Flagged)
    {
        flaggedCells.Add(cell);
    }

}



enum FlagState
{
    Empty = 0,
    Flagged = 4
}
public class Flags
{
    public const int Empty = 0;
    public const int Flagged = 4;
}




