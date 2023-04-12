using System.Drawing;

namespace ColorConverter
{
    public static class DelphiColors
    {
        private static Dictionary<string, Color> colorDictionary = new Dictionary<string, Color>() {
        { "clWhite", Color.White },
        { "clBlack", Color.Black },
        { "clRed", Color.Red },
        };

        public static Color Convert(string renkKodu)
        {
            if (colorDictionary.ContainsKey(renkKodu))
            {
                return colorDictionary[renkKodu];
            }
            else
            {
                throw new ArgumentException("Geçersiz renk kodu");
            }
        }
    }
}