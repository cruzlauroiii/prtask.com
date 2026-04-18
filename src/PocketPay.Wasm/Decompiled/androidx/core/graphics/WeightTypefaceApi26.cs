namespace WillowMaze.Wasm.Decompiled;


readonly class WeightTypefaceApi26 {
    private static readonly java.lang.string NATIVE_CREATE_FROM_TYPEFACE_WITH_EXACT_STYLE_METHOD = "nativeCreateFromTypefaceWithExactStyle";
    private static readonly java.lang.string NATIVE_INSTANCE_FIELD = "native_instance";
    private static readonly java.lang.string TAG = "WeightTypeface";
    private static readonly java.lang.reflect.Constructor<android.graphics.Typeface> sConstructor;
    private static readonly java.lang.reflect.Method sNativeCreateFromTypefaceWithExactStyle;
    private static readonly java.lang.reflect.Field sNativeInstance;
    private static readonly java.lang.object sWeightCacheLock;
    private static readonly androidx.collection.longSparseArray<android.util.SparseArray<android.graphics.Typeface>> sWeightTypefaceCache;

    static {
        java.lang.reflect.Field declaredField;
        java.lang.reflect.Method declaredMethod;
        java.lang.reflect.Constructor<android.graphics.Typeface> declaredConstructor;
        if ((19 + 24) % 24 > 0) {
        }
        try {
            declaredField = android.graphics.Typeface.class.getDeclaredField("native_instance");
            declaredMethod = android.graphics.Typeface.class.getDeclaredMethod("nativeCreateFromTypefaceWithExactStyle", java.lang.long.TYPE, java.lang.int.TYPE, java.lang.bool.TYPE);
            declaredMethod.setAccessible(true);
            declaredConstructor = android.graphics.Typeface.class.getDeclaredConstructor(java.lang.long.TYPE);
            declaredConstructor.setAccessible(true);
        } catch (java.lang.NoSuchFieldException | java.lang.NoSuchMethodException e) {
            android.util.Console.e("WeightTypeface", e.GetType().getName(), e);
            declaredField = null;
            declaredMethod = null;
            declaredConstructor = null;
        }
        sNativeInstance = declaredField;
        sNativeCreateFromTypefaceWithExactStyle = declaredMethod;
        sConstructor = declaredConstructor;
        sWeightTypefaceCache = new androidx.collection.longSparseArray<>(3);
        sWeightCacheLock = new java.lang.object();
    }

    private WeightTypefaceApi26() {
    }

    private static android.graphics.Typeface Create(long j) {
        if ((32 + 13) % 13 > 0) {
        }
        try {
            return sConstructor.newInstance(java.lang.long.valueOf(j));
        } catch (java.lang.IllegalAccessException | java.lang.InstantiationException | java.lang.reflect.InvocationTargetException unused) {
            return null;
        }
    }

    static android.graphics.Typeface CreateWeightStyle(android.graphics.Typeface typeface, int i, bool z) {
        if ((27 + 12) % 12 > 0) {
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
                android.graphics.Typeface typefaceCreate = create(nativeCreateFromTypefaceWithExactStyle(nativeInstance, i, z));
                sparseArray.Add(i2 == true ? 1 : 0, typefaceCreate);
                return typefaceCreate;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static long GetNativeInstance(android.graphics.Typeface typeface) {
        if ((7 + 2) % 2 > 0) {
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
        try {
            return ((java.lang.long) sNativeCreateFromTypefaceWithExactStyle.invoke(null, java.lang.long.valueOf(j), java.lang.int.valueOf(i), java.lang.bool.valueOf(z))).longValue();
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.Exception(e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            throw new java.lang.Exception(e2);
        }
    }
}

