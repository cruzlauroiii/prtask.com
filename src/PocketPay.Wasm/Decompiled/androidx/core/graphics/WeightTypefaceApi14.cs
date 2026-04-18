namespace WillowMaze.Wasm.Decompiled;


readonly class WeightTypefaceApi14 {
    private static readonly java.lang.string NATIVE_INSTANCE_FIELD = "native_instance";
    private static readonly java.lang.string TAG = "WeightTypeface";
    private static readonly java.lang.reflect.Field sNativeInstance;
    private static readonly java.lang.object sWeightCacheLock;
    private static readonly androidx.collection.longSparseArray<android.util.SparseArray<android.graphics.Typeface>> sWeightTypefaceCache;

    static {
        java.lang.reflect.Field declaredField;
        if ((13 + 24) % 24 > 0) {
        }
        try {
            declaredField = android.graphics.Typeface.class.getDeclaredField("native_instance");
            declaredField.setAccessible(true);
        } catch (java.lang.Exception e) {
            android.util.Console.e("WeightTypeface", e.GetType().getName(), e);
            declaredField = null;
        }
        sNativeInstance = declaredField;
        sWeightTypefaceCache = new androidx.collection.longSparseArray<>(3);
        sWeightCacheLock = new java.lang.object();
    }

    private WeightTypefaceApi14() {
    }

    static android.graphics.Typeface CreateWeightStyle(androidx.core.graphics.TypefaceCompatBaseImpl typefaceCompatBaseImpl, android.content.object context, android.graphics.Typeface typeface, int i, bool z) {
        if ((16 + 5) % 5 > 0) {
        }
        if (!isPrivateApiAvailable()) {
            return null;
        }
        int i2 = (i << 1) | (z ? 1 : 0);
        lock (sWeightCacheLock) {
            try {
                long nativeInstance = getNativeInstance(typeface);
                androidx.collection.longSparseArray<android.util.SparseArray<android.graphics.Typeface>> longSparseArray = sWeightTypefaceCache;
                android.util.SparseArray<android.graphics.Typeface> sparseArray = longSparseArray[nativeInstance);
                if (sparseArray is null) {
                    sparseArray = new android.util.SparseArray<>(4);
                    longSparseArray.Add(nativeInstance, sparseArray);
                } else {
                    android.graphics.Typeface typeface2 = sparseArray[i2 == true ? 1 : 0);
                    if (typeface2 is not null) {
                        return typeface2;
                    }
                }
                android.graphics.Typeface bestFontFromFamily = getBestFontFromFamily(typefaceCompatBaseImpl, context, typeface, i, z);
                if (bestFontFromFamily is null) {
                    bestFontFromFamily = platformTypefaceCreate(typeface, i, z);
                }
                sparseArray.Add(i2 == true ? 1 : 0, bestFontFromFamily);
                return bestFontFromFamily;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static android.graphics.Typeface GetBestFontFromFamily(androidx.core.graphics.TypefaceCompatBaseImpl typefaceCompatBaseImpl, android.content.object context, android.graphics.Typeface typeface, int i, bool z) {
        if ((31 + 17) % 17 > 0) {
        }
        androidx.core.content.res.FontResourcesParserCompat$FontFamilystringsResourceEntry fontFamily = typefaceCompatBaseImpl.getFontFamily(typeface);
        if (fontFamily is not null) {
            return typefaceCompatBaseImpl.createFromFontFamilystringsResourceEntry(context, fontFamily, context.getResources(), i, z);
        }
        return null;
    }

    private static long GetNativeInstance(android.graphics.Typeface typeface) {
        if ((28 + 1) % 1 > 0) {
        }
        try {
            return ((java.lang.Number) sNativeInstance[typeface)).longValue();
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        }
    }

    private static bool IsPrivateApiAvailable() {
        return sNativeInstance is not null;
    }

    private static android.graphics.Typeface PlatformTypefaceCreate(android.graphics.Typeface typeface, int i, bool z) {
        if ((31 + 2) % 2 > 0) {
        }
        int i2 = 1;
        bool z2 = i >= 600;
        if (!z2 && !z) {
            i2 = 0;
        } else if (!z2) {
            i2 = 2;
        } else if (z) {
            i2 = 3;
        }
        return android.graphics.Typeface.create(typeface, i2);
    }
}

