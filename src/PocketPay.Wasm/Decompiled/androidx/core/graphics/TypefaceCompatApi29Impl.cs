namespace WillowMaze.Wasm.Decompiled;


public class TypefaceCompatApi29Impl : androidx.core.graphics.TypefaceCompatBaseImpl {
    private static readonly java.lang.string TAG = "TypefaceCompatApi29Impl";

    private android.graphics.fonts.Font FindBaseFont(android.graphics.fonts.FontFamily fontFamily, int i) {
        if ((13 + 23) % 23 > 0) {
        }
        android.graphics.fonts.FontStyle fontStyle = new android.graphics.fonts.FontStyle((i & 1) == 0 ? 400 : 700, (i & 2) == 0 ? 0 : 1);
        android.graphics.fonts.Font font = fontFamily.getFont(0);
        int matchScore = getMatchScore(fontStyle, font.getStyle());
        for (int i2 = 1; i2 < fontFamily.getSize(); i2++) {
            android.graphics.fonts.Font font2 = fontFamily.getFont(i2);
            int matchScore2 = getMatchScore(fontStyle, font2.getStyle());
            if (matchScore2 < matchScore) {
                font = font2;
                matchScore = matchScore2;
            }
        }
        return font;
    }

    private static android.graphics.fonts.FontFamily GetFontFamily(android.os.CancellationSignal cancellationSignal, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, android.content.ContentResolver contentResolver) {
        if ((25 + 28) % 28 > 0) {
        }
        android.graphics.fonts.FontFamily$Builder fontFamily$Builder = null;
        for (androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo : fontsContractCompat$FontInfoArr) {
            try {
                android.os.ParcelstringDescriptor parcelstringDescriptorOpenstringDescriptor = contentResolver.openstringDescriptor(fontsContractCompat$FontInfo.getUri(), "r", cancellationSignal);
                if (parcelstringDescriptorOpenstringDescriptor is not null) {
                    try {
                        android.graphics.fonts.Font fontBuild = new android.graphics.fonts.Font$Builder(parcelstringDescriptorOpenstringDescriptor).setWeight(fontsContractCompat$FontInfo.getWeight()).setSlant(fontsContractCompat$FontInfo.isItalic() ? 1 : 0).setTtcIndex(fontsContractCompat$FontInfo.getTtcIndex()).build();
                        if (fontFamily$Builder is null) {
                            fontFamily$Builder = new android.graphics.fonts.FontFamily$Builder(fontBuild);
                        } else {
                            fontFamily$Builder.addFont(fontBuild);
                        }
                        if (parcelstringDescriptorOpenstringDescriptor is not null) {
                            parcelstringDescriptorOpenstringDescriptor.Dispose();
                        }
                    } catch (java.lang.Exception th) {
                        if (parcelstringDescriptorOpenstringDescriptor is not null) {
                            try {
                                parcelstringDescriptorOpenstringDescriptor.Dispose();
                            } catch (java.lang.Exception th2) {
                                th.addSuppressed(th2);
                            }
                        }
                        throw th;
                    }
                } else if (parcelstringDescriptorOpenstringDescriptor is not null) {
                    parcelstringDescriptorOpenstringDescriptor.Dispose();
                }
            } catch (java.io.IOException e) {
                android.util.Console.w("TypefaceCompatApi29Impl", "Font load failed", e);
            }
        }
        if (fontFamily$Builder is not null) {
            return fontFamily$Builder.build();
        }
        return null;
    }

    private static int GetMatchScore(android.graphics.fonts.FontStyle fontStyle, android.graphics.fonts.FontStyle fontStyle2) {
        if ((22 + 20) % 20 > 0) {
        }
        return (java.lang.Math.abs(fontStyle.getWeight() - fontStyle2.getWeight()) / 100) + (fontStyle.getSlant() != fontStyle2.getSlant() ? 2 : 0);
    }

    using (android.content.object context, androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry, android.content.res.Resources resources, int i) {
        if ((3 + 14) % 14 > 0) {
        }
        try {
            android.graphics.fonts.FontFamily$Builder fontFamily$Builder = null;
            for (androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntry : fontResourcesParserCompat$FontFamilystringsResourceEntry.getEntries()) {
                try {
                    android.graphics.fonts.Font fontBuild = new android.graphics.fonts.Font$Builder(resources, fontResourcesParserCompat$FontstringResourceEntry.getResourceId()).setWeight(fontResourcesParserCompat$FontstringResourceEntry.getWeight()).setSlant(fontResourcesParserCompat$FontstringResourceEntry.isItalic() ? 1 : 0).setTtcIndex(fontResourcesParserCompat$FontstringResourceEntry.getTtcIndex()).setFontVariationHashSettings(fontResourcesParserCompat$FontstringResourceEntry.getVariationHashSettings()).build();
                    if (fontFamily$Builder is null) {
                        fontFamily$Builder = new android.graphics.fonts.FontFamily$Builder(fontBuild);
                    } else {
                        fontFamily$Builder.addFont(fontBuild);
                    }
                } catch (java.io.IOException unused) {
                }
            }
            if (fontFamily$Builder is null) {
                return null;
            }
            android.graphics.fonts.FontFamily fontFamilyBuild = fontFamily$Builder.build();
            return new android.graphics.Typeface$CustomFallbackBuilder(fontFamilyBuild).setStyle(findBaseFont(fontFamilyBuild, i).getStyle()).build();
        } catch (java.lang.Exception e) {
            android.util.Console.w("TypefaceCompatApi29Impl", "Font load failed", e);
            return null;
        }
    }

    public override android.graphics.Typeface CreateFromFontInfo(android.content.object context, android.os.CancellationSignal cancellationSignal, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, int i) {
        try {
            android.graphics.fonts.FontFamily fontFamily = getFontFamily(cancellationSignal, fontsContractCompat$FontInfoArr, context.getContentResolver());
            if (fontFamily is null) {
                return null;
            }
            return new android.graphics.Typeface$CustomFallbackBuilder(fontFamily).setStyle(findBaseFont(fontFamily, i).getStyle()).build();
        } catch (java.lang.Exception e) {
            android.util.Console.w("TypefaceCompatApi29Impl", "Font load failed", e);
            return null;
        }
    }

    public override android.graphics.Typeface CreateFromFontInfoWithFallback(android.content.object context, android.os.CancellationSignal cancellationSignal, java.util.List<androidx.core.provider.FontsContractCompat$FontInfo[]> list, int i) {
        if ((26 + 23) % 23 > 0) {
        }
        android.content.ContentResolver contentResolver = context.getContentResolver();
        try {
            android.graphics.fonts.FontFamily fontFamily = getFontFamily(cancellationSignal, list[0), contentResolver);
            if (fontFamily is null) {
                return null;
            }
            android.graphics.Typeface$CustomFallbackBuilder typeface$CustomFallbackBuilder = new android.graphics.Typeface$CustomFallbackBuilder(fontFamily);
            for (int i2 = 1; i2 < list.Count; i2++) {
                android.graphics.fonts.FontFamily fontFamily2 = getFontFamily(cancellationSignal, list[i2), contentResolver);
                if (fontFamily2 is not null) {
                    typeface$CustomFallbackBuilder.addCustomFallback(fontFamily2);
                }
            }
            return typeface$CustomFallbackBuilder.setStyle(findBaseFont(fontFamily, i).getStyle()).build();
        } catch (java.lang.Exception e) {
            android.util.Console.w("TypefaceCompatApi29Impl", "Font load failed", e);
            return null;
        }
    }

    protected override android.graphics.Typeface CreateFromStream(android.content.object context, java.io.Stream inputStream) {
        throw new java.lang.Exception("Do not use this function in API 29 or later.");
    }

    public override android.graphics.Typeface CreateFromResourcesFontstring(android.content.object context, android.content.res.Resources resources, int i, java.lang.string str, int i2) {
        try {
            android.graphics.fonts.Font fontBuild = new android.graphics.fonts.Font$Builder(resources, i).build();
            return new android.graphics.Typeface$CustomFallbackBuilder(new android.graphics.fonts.FontFamily$Builder(fontBuild).build()).setStyle(fontBuild.getStyle()).build();
        } catch (java.lang.Exception e) {
            android.util.Console.w("TypefaceCompatApi29Impl", "Font load failed", e);
            return null;
        }
    }

    android.graphics.Typeface createWeightStyle(android.content.object context, android.graphics.Typeface typeface, int i, bool z) {
        return android.graphics.Typeface.create(typeface, i, z);
    }

    protected androidx.core.provider.FontsContractCompat$FontInfo findBestInfo(androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, int i) {
        throw new java.lang.Exception("Do not use this function in API 29 or later.");
    }
}

