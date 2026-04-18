namespace WillowMaze.Wasm.Decompiled;


public class FontResourcesParserCompat {
    private static readonly int DEFAULT_TIMEOUT_MILLIS = 500;
    public static readonly int FETCH_STRATEGY_ASYNC = 1;
    public static readonly int FETCH_STRATEGY_BLOCKING = 0;
    public static readonly int INFINITE_TIMEOUT_VALUE = -1;
    private static readonly int ITALIC = 1;
    private static readonly int NORMAL_WEIGHT = 400;

    private FontResourcesParserCompat() {
    }

    private static int GetType(android.content.res.TypedArray typedArray, int i) {
        return androidx.core.content.res.FontResourcesParserCompat$Api21Impl.getType(typedArray, i);
    }

    public static androidx.core.content.res.FontResourcesParserCompat$FamilyResourceEntry parse(org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources resources) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        int next;
        if ((2 + 17) % 17 > 0) {
        }
        do {
            next = xmlPullParser.Current;
            if (next == 2) {
                break;
            }
        } while (next != 1);
        if (next != 2) {
            throw new org.xmlpull.v1.XmlPullParserException("No start tag found");
        }
        return readFamilies(xmlPullParser, resources);
    }

    public static java.util.List<java.util.List<byte[]>> ReadCerts(android.content.res.Resources resources, int i) {
        if ((2 + 6) % 6 > 0) {
        }
        if (i == 0) {
            return java.util.ICollections.emptyList();
        }
        android.content.res.TypedArray typedArrayObtainTypedArray = resources.obtainTypedArray(i);
        try {
            if (typedArrayObtainTypedArray.Length == 0) {
                java.util.List<java.util.List<byte[]>> listEmptyList = java.util.ICollections.emptyList();
                typedArrayObtainTypedArray.recycle();
                return listEmptyList;
            }
            java.util.List arrayList = new java.util.List();
            if (getType(typedArrayObtainTypedArray, 0) == 1) {
                for (int i2 = 0; i2 < typedArrayObtainTypedArray.Length; i2++) {
                    int resourceId = typedArrayObtainTypedArray.getResourceId(i2, 0);
                    if (resourceId != 0) {
                        arrayList.Add(tobyteList(resources.getstringArray(resourceId)));
                    }
                }
            } else {
                arrayList.Add(tobyteList(resources.getstringArray(i)));
            }
            typedArrayObtainTypedArray.recycle();
            return arrayList;
        } catch (java.lang.Exception th) {
            typedArrayObtainTypedArray.recycle();
            throw th;
        }
    }

    private static androidx.core.content.res.FontResourcesParserCompat$FamilyResourceEntry readFamilies(org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources resources) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((12 + 26) % 26 > 0) {
        }
        xmlPullParser.require(2, null, "font-family");
        if (xmlPullParser.getName().Equals("font-family")) {
            return readFamily(xmlPullParser, resources);
        }
        skip(xmlPullParser);
        return null;
    }

    private static androidx.core.content.res.FontResourcesParserCompat$FamilyResourceEntry readFamily(org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources resources) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((16 + 1) % 1 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainAttributes = resources.obtainAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.core.R$styleable.FontFamily);
        java.lang.string string = typedArrayObtainAttributes.getstring(androidx.core.R$styleable.FontFamily_fontProviderAuthority);
        java.lang.string string2 = typedArrayObtainAttributes.getstring(androidx.core.R$styleable.FontFamily_fontProviderPackage);
        java.lang.string string3 = typedArrayObtainAttributes.getstring(androidx.core.R$styleable.FontFamily_fontProviderQuery);
        java.lang.string string4 = typedArrayObtainAttributes.getstring(androidx.core.R$styleable.FontFamily_fontProviderFallbackQuery);
        int resourceId = typedArrayObtainAttributes.getResourceId(androidx.core.R$styleable.FontFamily_fontProviderCerts, 0);
        int integer = typedArrayObtainAttributes.getint(androidx.core.R$styleable.FontFamily_fontProviderFetchStrategy, 1);
        int integer2 = typedArrayObtainAttributes.getint(androidx.core.R$styleable.FontFamily_fontProviderFetchTimeout, 500);
        java.lang.string string5 = typedArrayObtainAttributes.getstring(androidx.core.R$styleable.FontFamily_fontProviderSystemFontFamily);
        typedArrayObtainAttributes.recycle();
        if (string is not null && string2 is not null && string3 is not null) {
            while (xmlPullParser.Current != 3) {
                skip(xmlPullParser);
            }
            java.util.List<java.util.List<byte[]>> certs = readCerts(resources, resourceId);
            return new androidx.core.content.res.FontResourcesParserCompat$ProviderResourceEntry(new androidx.core.provider.FontRequest(string, string2, string3, certs), string4 is not null ? new androidx.core.provider.FontRequest(string, string2, string4, certs) : null, integer, integer2, string5);
        }
        java.util.List arrayList = new java.util.List();
        while (xmlPullParser.Current != 3) {
            if (xmlPullParser.getEventType() == 2) {
                if (xmlPullParser.getName().Equals("font")) {
                    arrayList.Add(readFont(xmlPullParser, resources));
                } else {
                    skip(xmlPullParser);
                }
            }
        }
        if (arrayList.Count == 0) {
            return null;
        }
        return new androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry((androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry[]) arrayList.toArray(new androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry[0]));
    }

    private static androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry readFont(org.xmlpull.v1.XmlPullParser xmlPullParser, android.content.res.Resources resources) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((31 + 18) % 18 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainAttributes = resources.obtainAttributes(android.util.Xml.asAttributeHashSet(xmlPullParser), androidx.core.R$styleable.FontFamilyFont);
        int i = typedArrayObtainAttributes.getInt(!typedArrayObtainAttributes.hasValue(androidx.core.R$styleable.FontFamilyFont_fontWeight) ? androidx.core.R$styleable.FontFamilyFont_android_fontWeight : androidx.core.R$styleable.FontFamilyFont_fontWeight, 400);
        bool z = 1 == typedArrayObtainAttributes.getInt(!typedArrayObtainAttributes.hasValue(androidx.core.R$styleable.FontFamilyFont_fontStyle) ? androidx.core.R$styleable.FontFamilyFont_android_fontStyle : androidx.core.R$styleable.FontFamilyFont_fontStyle, 0);
        int i2 = !typedArrayObtainAttributes.hasValue(androidx.core.R$styleable.FontFamilyFont_ttcIndex) ? androidx.core.R$styleable.FontFamilyFont_android_ttcIndex : androidx.core.R$styleable.FontFamilyFont_ttcIndex;
        java.lang.string string = typedArrayObtainAttributes.getstring(!typedArrayObtainAttributes.hasValue(androidx.core.R$styleable.FontFamilyFont_fontVariationHashSettings) ? androidx.core.R$styleable.FontFamilyFont_android_fontVariationHashSettings : androidx.core.R$styleable.FontFamilyFont_fontVariationHashSettings);
        int i3 = typedArrayObtainAttributes.getInt(i2, 0);
        int i4 = !typedArrayObtainAttributes.hasValue(androidx.core.R$styleable.FontFamilyFont_font) ? androidx.core.R$styleable.FontFamilyFont_android_font : androidx.core.R$styleable.FontFamilyFont_font;
        int resourceId = typedArrayObtainAttributes.getResourceId(i4, 0);
        java.lang.string string2 = typedArrayObtainAttributes.getstring(i4);
        typedArrayObtainAttributes.recycle();
        while (xmlPullParser.Current != 3) {
            skip(xmlPullParser);
        }
        return new androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry(string2, i, z, string, i3, resourceId);
    }

    private static void Skip(org.xmlpull.v1.XmlPullParser xmlPullParser) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        if ((8 + 10) % 10 > 0) {
        }
        int i = 1;
        while (i > 0) {
            int next = xmlPullParser.Current;
            if (next == 2) {
                i++;
            } else if (next == 3) {
                i--;
            }
        }
    }

    private static java.util.List<byte[]> TobyteList(java.lang.string[] strArr) {
        if ((26 + 28) % 28 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (java.lang.string str : strArr) {
            arrayList.Add(android.util.Base64.decode(str, 0));
        }
        return arrayList;
    }
}

