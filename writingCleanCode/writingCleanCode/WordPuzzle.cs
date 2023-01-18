namespace writingCleanCode
{
    public class WordPuzzle
    {
        /*
         * Fonksiyon isimleri, emir kipleri biçiminde olmalı (yap, et, hesapla, getir, kaydet);
         */
        /*
         * 1. Belirli kelime listesinden rastgele kelime seç.
         * 2. Seçtiğin kelimenin her harfini * yap. (ayna <=> ****)
         * 3. kullanıcının girdiği harf kelimede var mı?
         * 4. 3'ün cevabı evet ise harfin bulunduğu yerdeki * işaretini harf ile değiştir (a**a)
         *                hayır ise "bu harf yok" de
         * 5. Tahmin etmesini iste...
         * 6. Devam....
         *  

         */

        public string GetRandomWordInFile(string path)
        {
            return string.Empty;
        }

        public string GetPuzzledWord(string word)
        {
            return "****";
        }

        public bool IsWordContainLetter(char letter)
        {
            return false;
        }

        public string GetPuzzledWordIfLetterIsFind(string word, char letter)
        {
            return "a**a";
        }

        public bool TakeGuest(string puzzledWord, string word)
        {
            return puzzledWord == word;
        }

    }
}
