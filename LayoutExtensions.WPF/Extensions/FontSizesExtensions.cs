using System;

namespace LayoutExtensions.WPF
{
	internal static class FontSizesExtensions
	{
		internal static string ToFontSizeString(this FontSizes fontSize)
		{
			switch (fontSize)
			{
				case FontSizes.Aharoni:
					return "Aharoni";
				case FontSizes.Andalus:
					return "Andalus";
				case FontSizes.AngsanaUpc:
					return "AngsanaUPC";
				case FontSizes.AngsanaNew:
					return "Angsana New";
				case FontSizes.ArabicTransparent:
					return "Arabic Transparent";
				case FontSizes.Arial:
					return "Arial";
				case FontSizes.ArialBlack:
					return "Arial Black";
				case FontSizes.Batang:
					return "Batang";
				case FontSizes.BrowalliaUpc:
					return "BrowalliaUPC";
				case FontSizes.BrowalliaNew:
					return "Browallia New";
				case FontSizes.ComicSansMs:
					return "Comic Sans MS";
				case FontSizes.CordiaUpc:
					return "CordiaUPC";
				case FontSizes.CordiaNew:
					return "Cordia New";
				case FontSizes.CourierNew:
					return "Courier New";
				case FontSizes.David:
					return "David";
				case FontSizes.DfKaiSb:
					return "DFKai-SB";
				case FontSizes.DilleniaUpc:
					return "DilleniaUPC";
				case FontSizes.EstrangeloEdessa:
					return "Estrangelo Edessa";
				case FontSizes.EucrosiaUpc:
					return "EucrosiaUPC";
				case FontSizes.FixedMiriamTransparent:
					return "Fixed Miriam Transparent";
				case FontSizes.FranklinGothic:
					return "Franklin Gothic";
				case FontSizes.FrankRuehl:
					return "FrankRuehl";
				case FontSizes.FreesiaUpc:
					return "FreesiaUPC";
				case FontSizes.Gautami:
					return "Gautami";
				case FontSizes.Georgia:
					return "Georgia";
				case FontSizes.Gulim:
					return "Gulim";
				case FontSizes.Impact:
					return "Impact";
				case FontSizes.IrisUpc:
					return "IrisUPC";
				case FontSizes.JasmineUpc:
					return "JasmineUPC";
				case FontSizes.KaiTi:
					return "KaiTi";
				case FontSizes.Kartika:
					return "Kartika";
				case FontSizes.KodchiangUpc:
					return "KodchiangUPC";
				case FontSizes.Latha:
					return "Latha";
				case FontSizes.LevenimMt:
					return "Levenim MT";
				case FontSizes.LilyUpc:
					return "LilyUPC";
				case FontSizes.LucidaConsole:
					return "Lucida Console";
				case FontSizes.LucidaSans:
					return "Lucida Sans";
				case FontSizes.LucidaSansUnicode:
					return "Lucida Sans Unicode";
				case FontSizes.Mangal:
					return "Mangal";
				case FontSizes.Marlett:
					return "Marlett";
				case FontSizes.MicrosoftSansSerif:
					return "Microsoft Sans Serif";
				case FontSizes.PMingLiU:
					return "PMingLiU";
				case FontSizes.Miriam:
					return "Miriam";
				case FontSizes.MiriamFixed:
					return "Miriam Fixed";
				case FontSizes.MsGothic:
					return "MS Gothic";
				case FontSizes.MsMincho:
					return "MS Mincho";
				case FontSizes.MvBoli:
					return "MV Boli";
				case FontSizes.Narkisim:
					return "Narkisim";
				case FontSizes.PalatinoLinotype:
					return "Palatino Linotype";
				case FontSizes.PMingLiUExtB:
					return "PMingLiU-ExtB";
				case FontSizes.Raavi:
					return "Raavi";
				case FontSizes.Rod:
					return "Rod";
				case FontSizes.Shruti:
					return "Shruti";
				case FontSizes.SimHei:
					return "SimHei";
				case FontSizes.SimplifiedArabicFixed:
					return "Simplified Arabic Fixed";
				case FontSizes.SimSunExtB:
					return "SimSun-ExtB";
				case FontSizes.Sylfaen:
					return "Sylfaen";
				case FontSizes.Symbol:
					return "Symbol";
				case FontSizes.Tahoma:
					return "Tahoma";
				case FontSizes.TimesNewRoman:
					return "Times New Roman";
				case FontSizes.TraditionalArabic:
					return "Traditional Arabic";
				case FontSizes.TrebuchetMs:
					return "Trebuchet MS";
				case FontSizes.Tunga:
					return "Tunga";
				case FontSizes.Verdana:
					return "Verdana";
				case FontSizes.Vrinda:
					return "Vrinda";
				case FontSizes.Webdings:
					return "Webdings";
				case FontSizes.Wingdings:
					return "Wingdings";
				default:
					throw new ArgumentOutOfRangeException(nameof(fontSize));
			}
		}
	}
}
