﻿using System;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	internal static class FontsExtensions
	{
		internal static string ToFontString(this Fonts source) =>
			source switch
			{
				Fonts.Aharoni => "Aharoni",
				Fonts.Andalus => "Andalus",
				Fonts.AngsanaUpc => "AngsanaUPC",
				Fonts.AngsanaNew => "Angsana New",
				Fonts.ArabicTransparent => "Arabic Transparent",
				Fonts.Arial => "Arial",
				Fonts.ArialBlack => "Arial Black",
				Fonts.Batang => "Batang",
				Fonts.BrowalliaUpc => "BrowalliaUPC",
				Fonts.BrowalliaNew => "Browallia New",
				Fonts.ComicSansMs => "Comic Sans MS",
				Fonts.CordiaUpc => "CordiaUPC",
				Fonts.CordiaNew => "Cordia New",
				Fonts.CourierNew => "Courier New",
				Fonts.David => "David",
				Fonts.DfKaiSb => "DFKai-SB",
				Fonts.DilleniaUpc => "DilleniaUPC",
				Fonts.EstrangeloEdessa => "Estrangelo Edessa",
				Fonts.EucrosiaUpc => "EucrosiaUPC",
				Fonts.FixedMiriamTransparent => "Fixed Miriam Transparent",
				Fonts.FranklinGothic => "Franklin Gothic",
				Fonts.FrankRuehl => "FrankRuehl",
				Fonts.FreesiaUpc => "FreesiaUPC",
				Fonts.Gautami => "Gautami",
				Fonts.Georgia => "Georgia",
				Fonts.Gulim => "Gulim",
				Fonts.Impact => "Impact",
				Fonts.IrisUpc => "IrisUPC",
				Fonts.JasmineUpc => "JasmineUPC",
				Fonts.KaiTi => "KaiTi",
				Fonts.Kartika => "Kartika",
				Fonts.KodchiangUpc => "KodchiangUPC",
				Fonts.Latha => "Latha",
				Fonts.LevenimMt => "Levenim MT",
				Fonts.LilyUpc => "LilyUPC",
				Fonts.LucidaConsole => "Lucida Console",
				Fonts.LucidaSans => "Lucida Sans",
				Fonts.LucidaSansUnicode => "Lucida Sans Unicode",
				Fonts.Mangal => "Mangal",
				Fonts.Marlett => "Marlett",
				Fonts.MicrosoftSansSerif => "Microsoft Sans Serif",
				Fonts.PMingLiU => "PMingLiU",
				Fonts.Miriam => "Miriam",
				Fonts.MiriamFixed => "Miriam Fixed",
				Fonts.MsGothic => "MS Gothic",
				Fonts.MsMincho => "MS Mincho",
				Fonts.MvBoli => "MV Boli",
				Fonts.Narkisim => "Narkisim",
				Fonts.PalatinoLinotype => "Palatino Linotype",
				Fonts.PMingLiUExtB => "PMingLiU-ExtB",
				Fonts.Raavi => "Raavi",
				Fonts.Rod => "Rod",
				Fonts.Shruti => "Shruti",
				Fonts.SimHei => "SimHei",
				Fonts.SimplifiedArabicFixed => "Simplified Arabic Fixed",
				Fonts.SimSunExtB => "SimSun-ExtB",
				Fonts.Sylfaen => "Sylfaen",
				Fonts.Symbol => "Symbol",
				Fonts.Tahoma => "Tahoma",
				Fonts.TimesNewRoman => "Times New Roman",
				Fonts.TraditionalArabic => "Traditional Arabic",
				Fonts.TrebuchetMs => "Trebuchet MS",
				Fonts.Tunga => "Tunga",
				Fonts.Verdana => "Verdana",
				Fonts.Vrinda => "Vrinda",
				Fonts.Webdings => "Webdings",
				Fonts.Wingdings => "Wingdings",
				_ => throw new ArgumentOutOfRangeException($"Cannot resolve font name for {source}", nameof(source)),
			};
	}
}
