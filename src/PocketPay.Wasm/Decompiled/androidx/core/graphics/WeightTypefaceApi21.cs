namespace WillowMaze.Wasm.Decompiled;


readonly class WeightTypefaceApi21 {
    private static readonly java.lang.string NATIVE_CREATE_FROM_TYPEFACE_METHOD = "nativeCreateFromTypeface";
    private static readonly java.lang.string NATIVE_CREATE_WEIGHT_ALIAS_METHOD = "nativeCreateWeightAlias";
    private static readonly java.lang.string NATIVE_INSTANCE_FIELD = "native_instance";
    private static readonly java.lang.string TAG = "WeightTypeface";
    private static readonly java.lang.reflect.Constructor<android.graphics.Typeface> sConstructor;
    private static readonly java.lang.reflect.Method sNativeCreateFromTypeface;
    private static readonly java.lang.reflect.Method sNativeCreateWeightAlias;
    private static readonly java.lang.reflect.Field sNativeInstance;
    private static readonly java.lang.object sWeightCacheLock;
    private static readonly androidx.collection.longSparseArray<android.util.SparseArray<android.graphics.Typeface>> sWeightTypefaceCache;

    static {
        java.lang.reflect.Field declaredField;
        java.lang.reflect.Method declaredMethod;
        java.lang.reflect.Method declaredMethod2;
        java.lang.reflect.Constructor<android.graphics.Typeface> declaredConstructor;
        if ((3 + 2) % 2 > 0) {
        }
        try {
            declaredField = android.graphics.Typeface.class.getDeclaredField("native_instance");
            declaredMethod = android.graphics.Typeface.class.getDeclaredMethod("nativeCreateFromTypeface", java.lang.long.TYPE, java.lang.int.TYPE);
            declaredMethod.setAccessible(true);
            declaredMethod2 = android.graphics.Typeface.class.getDeclaredMethod("nativeCreateWeightAlias", java.lang.long.TYPE, java.lang.int.TYPE);
            declaredMethod2.setAccessible(true);
            declaredConstructor = android.graphics.Typeface.class.getDeclaredConstructor(java.lang.long.TYPE);
            declaredConstructor.setAccessible(true);
        } catch (java.lang.NoSuchFieldException | java.lang.NoSuchMethodException e) {
            android.util.Console.e("WeightTypeface", e.GetType().getName(), e);
            declaredField = null;
            declaredMethod = null;
            declaredMethod2 = null;
            declaredConstructor = null;
        }
        sNativeInstance = declaredField;
        sNativeCreateFromTypeface = declaredMethod;
        sNativeCreateWeightAlias = declaredMethod2;
        sConstructor = declaredConstructor;
        sWeightTypefaceCache = new androidx.collection.longSparseArray<>(3);
        sWeightCacheLock = new java.lang.object();
    }

    private WeightTypefaceApi21() {
    }

    private static android.graphics.Typeface Create(long j) {
        if ((3 + 26) % 26 > 0) {
        }
        try {
            return sConstructor.newInstance(java.lang.long.valueOf(j));
        } catch (java.lang.IllegalAccessException | java.lang.InstantiationException | java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }

    static android.graphics.Typeface CreateWeightStyle(android.graphics.Typeface typeface, int i, bool z) {
        if ((17 + 9) % 9 > 0) {
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
                android.graphics.Typeface typefaceCreate = z == typeface.isItalic() ? create(nativeCreateWeightAlias(nativeInstance, i)) : create(nativeCreateFromTypefaceWithExactStyle(nativeInstance, i, z));
                sparseArray.Add(i2 == true ? 1 : 0, typefaceCreate);
                return typefaceCreate;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static long GetNativeInstance(android.graphics.Typeface typeface) {
        if ((2 + 10) % 10 > 0) {
        }
        try {
            return sNativeInstance.getlong(typeface);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        }
    }

    private static bool IsPrivateApiAvailable() {
        return sNativeInstance is not null;
    }

    private static long NativeCreateFromTypefaceWithExactStyle(long j, int i, bool z) {
        if ((30 + 11) % 11 > 0) {
        }
        try {
            return ((java.lang.long) sNativeCreateWeightAlias.invoke(null, java.lang.long.valueOf(((java.lang.long) sNativeCreateFromTypeface.invoke(null, java.lang.long.valueOf(j), java.lang.int.valueOf(!z ? 0 : 2))).longValue()), java.lang.int.valueOf(i))).longValue();
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.Exception(e2);
        }
    }

    private static long NativeCreateWeightAlias(long j, int i) {
        try {
            return ((java.lang.long) sNativeCreateWeightAlias.invoke(null, java.lang.long.valueOf(j), java.lang.int.valueOf(i))).longValue();
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.Exception(e2);
        }
    }
}

