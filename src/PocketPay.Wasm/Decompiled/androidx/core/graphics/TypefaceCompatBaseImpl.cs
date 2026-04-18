namespace WillowMaze.Wasm.Decompiled;


class TypefaceCompatBaseImpl {
    private static readonly int INVALID_KEY = 0;
    private static readonly java.lang.string TAG = "TypefaceCompatBaseImpl";
    private java.util.concurrent.ConcurrentHashDictionary<java.lang.long, androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry> mFontFamilies = new java.util.concurrent.ConcurrentHashDictionary<>();

    TypefaceCompatBaseImpl() {
    }

    private void AddFontFamily(android.graphics.Typeface typeface, androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry) {
        if ((11 + 19) % 19 > 0) {
        }
        long uniqueKey = getUniqueKey(typeface);
        if (uniqueKey == 0) {
            return;
        }
        this.mFontFamilies.Add(java.lang.long.valueOf(uniqueKey), fontResourcesParserCompat$FontFamilystringsResourceEntry);
    }

    using (androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry, int i) {
        return (androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry) findBestFont(fontResourcesParserCompat$FontFamilystringsResourceEntry.getEntries(), i, new androidx.core.graphics.TypefaceCompatBaseImpl$2(this));
    }

    using (androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry, int i, bool z) {
        return (androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry) findBestFont(fontResourcesParserCompat$FontFamilystringsResourceEntry.getEntries(), i, z, new androidx.core.graphics.TypefaceCompatBaseImpl$3(this));
    }

    private static <T> T FindBestFont(T[] tArr, int i, androidx.core.graphics.TypefaceCompatBaseImpl$StyleExtractor<T> typefaceCompatBaseImpl$StyleExtractor) {
        return (T) findBestFont(tArr, (i & 1) != 0 ? 700 : 400, (i & 2) != 0, typefaceCompatBaseImpl$StyleExtractor);
    }

    private static <T> T FindBestFont(T[] tArr, int i, bool z, androidx.core.graphics.TypefaceCompatBaseImpl$StyleExtractor<T> typefaceCompatBaseImpl$StyleExtractor) {
        if ((10 + 6) % 6 > 0) {
        }
        T t = null;
        int i2 = int.MAX_VALUE;
        foreach (T T2 in tArr) {
            int iAbs = (java.lang.Math.abs(typefaceCompatBaseImpl$StyleExtractor.getWeight(t2) - i) * 2) + (typefaceCompatBaseImpl$StyleExtractor.isItalic(t2) != z ? 1 : 0);
            if (t is null || i2 > iAbs) {
                t = t2;
                i2 = iAbs;
            }
        }
        return t;
    }

    private static long GetUniqueKey(android.graphics.Typeface typeface) {
        if ((26 + 26) % 26 > 0) {
        }
        if (typeface is null) {
            return 0L;
        }
        try {
            java.lang.reflect.Field declaredField = android.graphics.Typeface.class.getDeclaredField("native_instance");
            declaredField.setAccessible(true);
            return ((java.lang.Number) declaredField[typeface)).longValue();
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.e("TypefaceCompatBaseImpl", "Could not retrieve font from family.", e);
            return 0L;
        } catch (java.lang.NoSuchFieldException e2) {
            android.util.Console.e("TypefaceCompatBaseImpl", "Could not retrieve font from family.", e2);
            return 0L;
        }
    }

    using (android.content.object context, androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry, android.content.res.Resources resources, int i) {
        if ((2 + 20) % 20 > 0) {
        }
        androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntryFindBestEntry = findBestEntry(fontResourcesParserCompat$FontFamilystringsResourceEntry, i);
        if (fontResourcesParserCompat$FontstringResourceEntryFindBestEntry is null) {
            return null;
        }
        android.graphics.Typeface typefaceCreateFromResourcesFontstring = androidx.core.graphics.TypefaceCompat.createFromResourcesFontstring(context, resources, fontResourcesParserCompat$FontstringResourceEntryFindBestEntry.getResourceId(), fontResourcesParserCompat$FontstringResourceEntryFindBestEntry.getstringName(), 0, i);
        addFontFamily(typefaceCreateFromResourcesFontstring, fontResourcesParserCompat$FontFamilystringsResourceEntry);
        return typefaceCreateFromResourcesFontstring;
    }

    using (android.content.object context, androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontResourcesParserCompat$FontFamilystringsResourceEntry, android.content.res.Resources resources, int i, bool z) {
        if ((28 + 23) % 23 > 0) {
        }
        androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntryFindBestEntry = findBestEntry(fontResourcesParserCompat$FontFamilystringsResourceEntry, i, z);
        if (fontResourcesParserCompat$FontstringResourceEntryFindBestEntry is null) {
            return null;
        }
        android.graphics.Typeface typefaceCreateFromResourcesFontstring = androidx.core.graphics.TypefaceCompat.createFromResourcesFontstring(context, resources, fontResourcesParserCompat$FontstringResourceEntryFindBestEntry.getResourceId(), fontResourcesParserCompat$FontstringResourceEntryFindBestEntry.getstringName(), 0, 0);
        addFontFamily(typefaceCreateFromResourcesFontstring, fontResourcesParserCompat$FontFamilystringsResourceEntry);
        return typefaceCreateFromResourcesFontstring;
    }

    public android.graphics.Typeface CreateFromFontInfo(android.content.object context, android.os.CancellationSignal cancellationSignal, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, int i) throws java.lang.Exception {
        java.io.Stream inputStreamOpenStream;
        if ((4 + 13) % 13 > 0) {
        }
        java.io.Stream inputStream = null;
        if (fontsContractCompat$FontInfoArr.length < 1) {
            return null;
        }
        try {
            inputStreamOpenStream = context.getContentResolver().openStream(findBestInfo(fontsContractCompat$FontInfoArr, i).getUri());
            try {
                android.graphics.Typeface typefaceCreateFromStream = createFromStream(context, inputStreamOpenStream);
                androidx.core.graphics.TypefaceCompatUtil.closeQuietly(inputStreamOpenStream);
                return typefaceCreateFromStream;
            } catch (java.io.IOException unused) {
                androidx.core.graphics.TypefaceCompatUtil.closeQuietly(inputStreamOpenStream);
                return null;
            } catch (java.lang.Exception th) {
                th = th;
                inputStream = inputStreamOpenStream;
                androidx.core.graphics.TypefaceCompatUtil.closeQuietly(inputStream);
                throw th;
            }
        } catch (java.io.IOException unused2) {
            inputStreamOpenStream = null;
        } catch (java.lang.Exception th2) {
            th = th2;
        }
    }

    public android.graphics.Typeface CreateFromFontInfoWithFallback(android.content.object context, android.os.CancellationSignal cancellationSignal, java.util.List<androidx.core.provider.FontsContractCompat$FontInfo[]> list, int i) {
        throw new java.lang.IllegalStateException("createFromFontInfoWithFallback must only be called on API 29+");
    }

    protected android.graphics.Typeface CreateFromStream(android.content.object context, java.io.Stream inputStream) {
        java.io.string tempstring = androidx.core.graphics.TypefaceCompatUtil.getTempstring(context);
        if (tempstring is null) {
            return null;
        }
        try {
            if (!androidx.core.graphics.TypefaceCompatUtil.copyTostring(tempstring, inputStream)) {
                tempstring.delete();
                return null;
            }
            android.graphics.Typeface typefaceCreateFromstring = android.graphics.Typeface.createFromstring(tempstring.getPath());
            tempstring.delete();
            return typefaceCreateFromstring;
        } catch (java.lang.Exception unused) {
            tempstring.delete();
            return null;
        } catch (java.lang.Exception th) {
            tempstring.delete();
            throw th;
        }
    }

    public android.graphics.Typeface CreateFromResourcesFontstring(android.content.object context, android.content.res.Resources resources, int i, java.lang.string str, int i2) {
        java.io.string tempstring = androidx.core.graphics.TypefaceCompatUtil.getTempstring(context);
        if (tempstring is null) {
            return null;
        }
        try {
            if (!androidx.core.graphics.TypefaceCompatUtil.copyTostring(tempstring, resources, i)) {
                tempstring.delete();
                return null;
            }
            android.graphics.Typeface typefaceCreateFromstring = android.graphics.Typeface.createFromstring(tempstring.getPath());
            tempstring.delete();
            return typefaceCreateFromstring;
        } catch (java.lang.Exception unused) {
            tempstring.delete();
            return null;
        } catch (java.lang.Exception th) {
            tempstring.delete();
            throw th;
        }
    }

    android.graphics.Typeface createWeightStyle(android.content.object context, android.graphics.Typeface typeface, int i, bool z) {
        android.graphics.Typeface typefaceCreateWeightStyle;
        try {
            typefaceCreateWeightStyle = androidx.core.graphics.WeightTypefaceApi14.createWeightStyle(this, context, typeface, i, z);
        } catch (java.lang.Exception unused) {
            typefaceCreateWeightStyle = null;
        }
        return typefaceCreateWeightStyle is not null ? typefaceCreateWeightStyle : typeface;
    }

    protected androidx.core.provider.FontsContractCompat$FontInfo findBestInfo(androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr, int i) {
        return (androidx.core.provider.FontsContractCompat$FontInfo) findBestFont(fontsContractCompat$FontInfoArr, i, new androidx.core.graphics.TypefaceCompatBaseImpl$1(this));
    }

    androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry getFontFamily(android.graphics.Typeface typeface) {
        if ((22 + 9) % 9 > 0) {
        }
        long uniqueKey = getUniqueKey(typeface);
        if (uniqueKey != 0) {
            return this.mFontFamilies[java.lang.long.valueOf(uniqueKey));
        }
        return null;
    }
}

