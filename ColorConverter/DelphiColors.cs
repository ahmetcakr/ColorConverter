﻿using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace ColorConverter
{
    public static class DelphiColors
    {
        private static Dictionary<string, Color> colorDictionary = new Dictionary<string, Color>() {
        //Normal Colors
        {"clBlack", Color.Black},
        {"clMaroon", Color.Maroon},
        {"clGreen", Color.Green},
        {"clOlive", Color.Olive},
        {"clNavy", Color.Navy},
        {"clPurple", Color.Purple},
        {"clTeal", Color.Teal},
        {"clGray", Color.Gray},
        {"clLtGray", Color.LightGray},
        {"clDkGray", Color.DarkGray},
        {"clSilver", Color.Silver},
        {"clRed", Color.Red},
        {"clLime", Color.Lime},
        {"clYellow", Color.Yellow},
        {"clBlue", Color.Blue},
        {"clFuchsia", Color.Fuchsia},
        {"clAqua", Color.Aqua},
        {"clWhite", Color.White},
        {"clMoneyGreen", Color.FromArgb(192, 255, 192)},
        {"clSkyBlue", Color.FromArgb(135, 206, 235)},
        {"clCream", Color.FromArgb(255, 251, 240)},
        {"clMedGray", Color.FromArgb(160, 160, 164)},
        {"clNone", Color.Transparent},
        {"clSystemColor", SystemColors.Desktop},

        // System Colors

        {"clActiveBorder", SystemColors.ActiveBorder},
        {"clActiveCaption", SystemColors.ActiveCaption},
        {"clAppWorkSpace", SystemColors.AppWorkspace},
        {"clBackground", SystemColors.Desktop},
        {"clBtnFace", SystemColors.Control},
        {"clBtnHighlight", SystemColors.ControlLightLight},
        {"clBtnShadow", SystemColors.ControlDark},
        {"clBtnText", SystemColors.ControlText},
        {"clCaptionText", SystemColors.ActiveCaptionText},
        {"clDefault", SystemColors.Control},
        {"clGrayText", SystemColors.GrayText},
        {"clHighlight", SystemColors.Highlight},
        {"clHighlightText", SystemColors.HighlightText},

        {"clHotLight", SystemColors.HotTrack},
        {"clInactiveBorder", SystemColors.InactiveBorder},
        {"clInactiveCaption", SystemColors.InactiveCaption},
        {"clInactiveCaptionText", SystemColors.InactiveCaptionText},
        {"clInfoBk", SystemColors.Info},
        {"clInfoText", SystemColors.InfoText},
        {"clMenu", SystemColors.Menu},
        {"clMenuHighlight", SystemColors.MenuHighlight},
        {"clMenuBar", SystemColors.MenuBar},
        {"clMenuText", SystemColors.MenuText},
        {"clScrollBar", SystemColors.ScrollBar},
        {"clWindow", SystemColors.Window},
        {"clWindowFrame", SystemColors.WindowFrame},
        {"clWindowText", SystemColors.WindowText},
        {"cl3DDkShadow", SystemColors.ControlDarkDark},
        {"cl3DLight", SystemColors.ControlLight},
        {"clGradientActiveCaption", SystemColors.GradientActiveCaption },
        {"clGradientInactiveCaption", SystemColors.GradientInactiveCaption},

        // Web Colors

        {"clWebSnow", Color.FromArgb(255, 250, 250)},
        {"clWebFloralWhite", Color.FromArgb(255, 250, 240)},
        {"clWebLavenderBlush", Color.FromArgb(255, 240, 245)},
        {"clWebOldLace", Color.FromArgb(253, 245, 230)},
        {"clWebIvory", Color.FromArgb(255, 255, 240)},
        {"clWebCornSilk", Color.FromArgb(255, 248, 220)},
        {"clWebBeige", Color.FromArgb(245, 245, 220)},
        {"clWebAntiqueWhite", Color.FromArgb(250, 235, 215)},
        {"clWebWheat", Color.FromArgb(245, 222, 179)},
        {"clWebAliceBlue", Color.FromArgb(240, 248, 255)},
        {"clWebGhostWhite", Color.FromArgb(248, 248, 255)},
        {"clWebLavender", Color.FromArgb(230, 230, 250)},
        {"clWebSeashell", Color.FromArgb(255, 245, 238)},
        {"clWebLightYellow", Color.FromArgb(255, 255, 224)},
        {"clWebPapayaWhip", Color.FromArgb(255, 239, 213)},
        {"clWebNavajoWhite", Color.FromArgb(255, 222, 173)},
        {"clWebMoccasin", Color.FromArgb(255, 228, 181)},
        {"clWebBurlywood", Color.FromArgb(222, 184, 135)},
        {"clWebAzure", Color.FromArgb(240, 255, 255)},
        {"clWebMintcream", Color.FromArgb(245, 255, 250)},
        {"clWebHoneydew", Color.FromArgb(240, 255, 240)},
        {"clWebLinen", Color.FromArgb(250, 240, 230)},
        {"clWebLemonChiffon", Color.FromArgb(255, 250, 205)},
        {"clWebBlanchedAlmond", Color.FromArgb(255, 235, 205)},
        {"clWebBisque", Color.FromArgb(255, 228, 196)},
        {"clWebPeachPuff", Color.FromArgb(255, 218, 185)},
        {"clWebTan", Color.FromArgb(210, 180, 140)},
        {"clWebYellow", Color.FromArgb(255, 255, 0)},
        {"clWebDarkOrange", Color.FromArgb(255, 140, 0)},
        {"clWebRed", Color.FromArgb(255, 0, 0)},
        {"clWebDarkRed", Color.FromArgb(139, 0, 0)},
        {"clWebMaroon", Color.FromArgb(128, 0, 0)},
        {"clWebIndianRed", Color.FromArgb(205, 92, 92)},
        {"clWebSalmon", Color.FromArgb(250, 128, 114)},
        {"clWebCoral", Color.FromArgb(255, 127, 80)},
        {"clWebGold", Color.FromArgb(255, 215, 0)},
        {"clWebTomato", Color.FromArgb(255, 99, 71)},
        {"clWebCrimson", Color.FromArgb(220, 20, 60)},
        {"clWebBrown", Color.FromArgb(165, 42, 42)},
        {"clWebChocolate", Color.FromArgb(210, 105, 30)},
        {"clWebSandyBrown", Color.FromArgb(244, 164, 96)},
        {"clWebLightSalmon", Color.FromArgb(255, 160, 122)},
        {"clWebLightCoral", Color.FromArgb(240, 128, 128)},
        {"clWebOrange", Color.FromArgb(255, 165, 0)},
        {"clWebOrangeRed", Color.FromArgb(255, 69, 0)},
        {"clWebFirebrick", Color.FromArgb(178, 34, 34)},
        {"clWebSaddleBrown", Color.FromArgb(139, 69, 19)},
        {"clWebSienna", Color.FromArgb(160, 82, 45)},
        {"clWebPeru", Color.FromArgb(205, 133, 63)},
        {"clWebDarkSalmon", Color.FromArgb(233, 150, 122)},
        {"clWebRosyBrown", Color.FromArgb(188, 143, 143)},
        {"clWebPaleGoldenrod", Color.FromArgb(238, 232, 170)},
        {"clWebLightGoldenrodYellow", Color.FromArgb(250, 250, 210)},
        {"clWebOlive", Color.FromArgb(128, 128, 0)},
        {"clWebForestGreen", Color.FromArgb(34, 139, 34)},
        {"clWebGreenYellow", Color.FromArgb(173, 255, 47)},
        {"clWebChartreuse", Color.FromArgb(127, 255, 0)},
        {"clWebLightGreen", Color.FromArgb(144, 238, 144)},
        {"clWebAquamarine", Color.FromArgb(127, 255, 212)},
        {"clWebSeaGreen", Color.FromArgb(46, 139, 87)},
        {"clWebGoldenRod", Color.FromArgb(218, 165, 32)},
        {"clWebKhaki", Color.FromArgb(240, 230, 140)},
        {"clWebOliveDrab", Color.FromArgb(107, 142, 35)},
        {"clWebGreen", Color.FromArgb(0, 128, 0)},
        {"clWebYellowGreen", Color.FromArgb(154, 205, 50)},
        {"clWebLawnGreen", Color.FromArgb(124, 252, 0)},
        {"clWebPaleGreen", Color.FromArgb(152, 251, 152)},
        {"clWebMediumAquamarine", Color.FromArgb(102, 205, 170)},
        {"clWebMediumSeaGreen", Color.FromArgb(60, 179, 113)},
        {"clWebDarkGoldenRod", Color.FromArgb(184, 134, 11)},
        {"clWebDarkKhaki", Color.FromArgb(189, 183, 107)},
        {"clWebDarkOliveGreen", Color.FromArgb(85, 107, 47)},
        {"clWebDarkgreen", Color.FromArgb(0, 100, 0)},
        {"clWebLimeGreen", Color.FromArgb(50, 205, 50)},
        {"clWebLime", Color.FromArgb(0, 255, 0)},
        {"clWebSpringGreen", Color.FromArgb(0, 255, 127)},
        {"clWebMediumSpringGreen", Color.FromArgb(0, 250, 154)},
        {"clWebDarkSeaGreen", Color.FromArgb(143, 188, 143)},
        {"clWebLightSeaGreen", Color.FromArgb(32, 178, 170)},
        {"clWebPaleTurquoise", Color.FromArgb(175, 238, 238)},
        {"clWebLightCyan", Color.FromArgb(224, 255, 255)},
        {"clWebLightBlue", Color.FromArgb(173, 216, 230)},
        {"clWebLightSkyBlue", Color.FromArgb(135, 206, 235)},
        {"clWebCornFlowerBlue", Color.FromArgb(100, 149, 237)},
        {"clWebDarkBlue", Color.FromArgb(0, 0, 139)},
        {"clWebIndigo", Color.FromArgb(75, 0, 130)},
        {"clWebMediumTurquoise", Color.FromArgb(72, 209, 204)},
        {"clWebTurquoise", Color.FromArgb(64, 224, 208)},
        {"clWebCyan", Color.FromArgb(0, 255, 255)},
        {"clWebAqua", Color.FromArgb(0, 255, 255)},
        {"clWebPowderBlue", Color.FromArgb(176, 224, 230)},
        {"clWebSkyBlue", Color.FromArgb(135, 206, 235)},
        {"clWebRoyalBlue", Color.FromArgb(65, 105, 225)},
        {"clWebMediumBlue", Color.FromArgb(0, 0, 205)},
        {"clWebMidnightBlue", Color.FromArgb(25, 25, 112)},
        {"clWebDarkTurquoise", Color.FromArgb(0, 206, 209)},
        {"clWebCadetBlue", Color.FromArgb(95, 158, 160)},
        {"clWebDarkCyan", Color.FromArgb(0, 139, 139)},
        {"clWebTeal", Color.FromArgb(0, 128, 128)},
        {"clWebDeepskyBlue", Color.FromArgb(0, 191, 255)},
        {"clWebDodgerBlue", Color.FromArgb(30, 144, 255)},
        {"clWebBlue", Color.FromArgb(0, 191, 255)},
        {"clWebNavy", Color.FromArgb(0, 0, 128)},
        {"clWebDarkViolet", Color.FromArgb(148, 0, 211)},
        {"clWebDarkOrchid", Color.FromArgb(153, 50, 204)},
        {"clWebMagenta", Color.FromArgb(255, 0, 255)},
        {"clWebDarkMagenta", Color.FromArgb(139, 0, 139)},
        {"clWebMediumVioletRed", Color.FromArgb(199, 21, 133)},
        {"clWebPaleVioletRed", Color.FromArgb(219, 112, 147)},
        {"clWebBlueViolet", Color.FromArgb(138, 43, 226)},
        {"clWebMediumOrchid", Color.FromArgb(186, 85, 211)},
        {"clWebMediumPurple", Color.FromArgb(147, 112, 219)},
        {"clWebPurple", Color.FromArgb(128, 0, 128)},
        {"clWebDeepPink", Color.FromArgb(255, 20, 147)},
        {"clWebLightPink", Color.FromArgb(255, 182, 193)},
        {"clWebViolet", Color.FromArgb(238, 130, 238)},
        {"clWebOrchid", Color.FromArgb(218, 112, 214)},
        {"clWebPlum", Color.FromArgb(221, 160, 221)},
        {"clWebThistle", Color.FromArgb(216, 191, 216)},
        {"clWebHotPink", Color.FromArgb(255, 105, 180)},
        {"clWebPink", Color.FromArgb(255, 192, 203)},
        {"clWebLightSteelBlue", Color.FromArgb(176, 196, 222)},
        {"clWebMediumSlateBlue", Color.FromArgb(123, 104, 238)},
        {"clWebLightSlateGray", Color.FromArgb(119, 136, 153)},
        {"clWebWhite", Color.FromArgb(255, 255, 255)},
        {"clWebLightgrey", Color.FromArgb(211, 211, 211)},
        {"clWebGray", Color.FromArgb(128, 128, 128)},
        {"clWebSteelBlue", Color.FromArgb(70, 130, 180)},
        {"clWebSlateBlue", Color.FromArgb(106, 90, 205)},
        {"clWebSlateGray", Color.FromArgb(112, 128, 144)},
        {"clWebWhiteSmoke", Color.FromArgb(245, 245, 245)},
        {"clWebSilver", Color.FromArgb(192, 192, 192)},
        {"clWebDimGray", Color.FromArgb(105, 105, 105)},
        {"clWebMistyRose", Color.FromArgb(255, 228, 225)},
        {"clWebDarkSlateBlue", Color.FromArgb(72, 61, 139)},
        {"clWebDarkSlategray", Color.FromArgb(47, 79, 79)},
        {"clWebGainsboro", Color.FromArgb(220, 220, 220)},
        {"clWebDarkGray", Color.FromArgb(169, 169, 169)},
        {"clWebBlack", Color.FromArgb(0, 0, 0)},
        {"clWebFuchsia", Color.Fuchsia},
    };

        public static Color Convert(string renkKodu)
        {
            if (colorDictionary.ContainsKey(renkKodu))
            {
                return colorDictionary[renkKodu];
            }
            else
            {
                return Color.Gray;

                //throw new ArgumentException("Geçersiz renk kodu");
            }
        }
    }
}