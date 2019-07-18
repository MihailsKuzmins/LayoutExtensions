using System;

namespace LayoutExtensions.WPF
{
	internal static class FontSizesExtensions
	{
		internal static string ToFontString(this Fonts font)
		{
			switch (font)
			{
				case Fonts.Aharoni:
					return "Aharoni";
				case Fonts.Andalus:
					return "Andalus";
				case Fonts.AngsanaUpc:
					return "AngsanaUPC";
				case Fonts.AngsanaNew:
					return "Angsana New";
				case Fonts.ArabicTransparent:
					return "Arabic Transparent";
				case Fonts.Arial:
					return "Arial";
				case Fonts.ArialBlack:
					return "Arial Black";
				case Fonts.Batang:
					return "Batang";
				case Fonts.BrowalliaUpc:
					return "BrowalliaUPC";
				case Fonts.BrowalliaNew:
					return "Browallia New";
				case Fonts.ComicSansMs:
					return "Comic Sans MS";
				case Fonts.CordiaUpc:
					return "CordiaUPC";
				case Fonts.CordiaNew:
					return "Cordia New";
				case Fonts.CourierNew:
					return "Courier New";
				case Fonts.David:
					return "David";
				case Fonts.DfKaiSb:
					return "DFKai-SB";
				case Fonts.DilleniaUpc:
					return "DilleniaUPC";
				case Fonts.EstrangeloEdessa:
					return "Estrangelo Edessa";
				case Fonts.EucrosiaUpc:
					return "EucrosiaUPC";
				case Fonts.FixedMiriamTransparent:
					return "Fixed Miriam Transparent";
				case Fonts.FranklinGothic:
					return "Franklin Gothic";
				case Fonts.FrankRuehl:
					return "FrankRuehl";
				case Fonts.FreesiaUpc:
					return "FreesiaUPC";
				case Fonts.Gautami:
					return "Gautami";
				case Fonts.Georgia:
					return "Georgia";
				case Fonts.Gulim:
					return "Gulim";
				case Fonts.Impact:
					return "Impact";
				case Fonts.IrisUpc:
					return "IrisUPC";
				case Fonts.JasmineUpc:
					return "JasmineUPC";
				case Fonts.KaiTi:
					return "KaiTi";
				case Fonts.Kartika:
					return "Kartika";
				case Fonts.KodchiangUpc:
					return "KodchiangUPC";
				case Fonts.Latha:
					return "Latha";
				case Fonts.LevenimMt:
					return "Levenim MT";
				case Fonts.LilyUpc:
					return "LilyUPC";
				case Fonts.LucidaConsole:
					return "Lucida Console";
				case Fonts.LucidaSans:
					return "Lucida Sans";
				case Fonts.LucidaSansUnicode:
					return "Lucida Sans Unicode";
				case Fonts.Mangal:
					return "Mangal";
				case Fonts.Marlett:
					return "Marlett";
				case Fonts.MicrosoftSansSerif:
					return "Microsoft Sans Serif";
				case Fonts.PMingLiU:
					return "PMingLiU";
				case Fonts.Miriam:
					return "Miriam";
				case Fonts.MiriamFixed:
					return "Miriam Fixed";
				case Fonts.MsGothic:
					return "MS Gothic";
				case Fonts.MsMincho:
					return "MS Mincho";
				case Fonts.MvBoli:
					return "MV Boli";
				case Fonts.Narkisim:
					return "Narkisim";
				case Fonts.PalatinoLinotype:
					return "Palatino Linotype";
				case Fonts.PMingLiUExtB:
					return "PMingLiU-ExtB";
				case Fonts.Raavi:
					return "Raavi";
				case Fonts.Rod:
					return "Rod";
				case Fonts.Shruti:
					return "Shruti";
				case Fonts.SimHei:
					return "SimHei";
				case Fonts.SimplifiedArabicFixed:
					return "Simplified Arabic Fixed";
				case Fonts.SimSunExtB:
					return "SimSun-ExtB";
				case Fonts.Sylfaen:
					return "Sylfaen";
				case Fonts.Symbol:
					return "Symbol";
				case Fonts.Tahoma:
					return "Tahoma";
				case Fonts.TimesNewRoman:
					return "Times New Roman";
				case Fonts.TraditionalArabic:
					return "Traditional Arabic";
				case Fonts.TrebuchetMs:
					return "Trebuchet MS";
				case Fonts.Tunga:
					return "Tunga";
				case Fonts.Verdana:
					return "Verdana";
				case Fonts.Vrinda:
					return "Vrinda";
				case Fonts.Webdings:
					return "Webdings";
				case Fonts.Wingdings:
					return "Wingdings";
				default:
					throw new ArgumentOutOfRangeException(nameof(font));
			}
		}
	}
}
