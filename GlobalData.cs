using System.Collections.Generic;
using System.Drawing;

namespace EB_Erkennung
{
    internal class GlobalData
    {
        public static List<IBC> IbcList { get; set; }
        public static Image LoadedImage { get; set; }
        public static IBC FoundIBC { get; set; }
        public static string AccsesToken { get; set; }
    }
}
