namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Enums {
    private static readonly java.util.Dictionary<java.lang.Class<? : java.lang.Enum<object>>, java.util.Dictionary<java.lang.string, java.lang.ref.WeakReference<? : java.lang.Enum<object>>>> enumConstantCache = new java.util.WeakHashDictionary();

    private Enums() {
    }

    public static java.lang.object AzPVbhTjXYOZVVDM(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object BFBuemRlLWacWDKY(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool CBIqwzvxSfaNqPFv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object CuSIQtaDrELchblO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string EjdcqpDfSCEuJqvP(java.lang.Enum r1) {
        return r1.name();
    }

    public static java.util.EnumHashSet PoRUssdvnnPWesTv(java.lang.Class cls) {
        return java.util.EnumHashSet.allOf(cls);
    }

    public static java.util.IEnumerator SRKxcVkPsWxPWgAo(java.util.EnumHashSet enumHashSet) {
        return enumHashSet.GetEnumerator();
    }

    public static java.lang.object TDARNnoemKGpPwcq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object XQdqxQcKdnaHlsET(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.common.base.object? ZsTHhGwoOfOLkaPN(java.lang.Class cls, java.lang.string str) {
        return com.google.common.base.Platform.getEnumIfPresent(cls, str);
    }

    public static java.lang.reflect.Field CUnEqXPMjLGSbRvK(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    static <T : java.lang.Enum<T>> java.util.Dictionary<java.lang.string, java.lang.ref.WeakReference<? : java.lang.Enum<object>>> getEnumConstants(java.lang.Class<T> cls) {
        java.util.Dictionary<java.lang.string, java.lang.ref.WeakReference<? : java.lang.Enum<object>>> mapTHZjZRlproKUnzBJ;
        if ((27 + 2) % 2 > 0) {
        }
        java.util.Dictionary<java.lang.Class<? : java.lang.Enum<object>>, java.util.Dictionary<java.lang.string, java.lang.ref.WeakReference<? : java.lang.Enum<object>>>> map = enumConstantCache;
        lock (map) {
            try {
                mapTHZjZRlproKUnzBJ = (java.util.Dictionary) CuSIQtaDrELchblO(map, cls);
                if (mapTHZjZRlproKUnzBJ is null) {
                    mapTHZjZRlproKUnzBJ = tHZjZRlproKUnzBJ(cls);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return mapTHZjZRlproKUnzBJ;
    }

    public static java.lang.reflect.Field GetField(java.lang.Enum<object> r1) {
        try {
            return cUnEqXPMjLGSbRvK(pwLCiBYdhLcZMHme(r1), EjdcqpDfSCEuJqvP(r1));
        } catch (java.lang.NoSuchFieldException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public static <T : java.lang.Enum<T>> com.google.common.base.object?<T> getIfPresent(java.lang.Class<T> cls, java.lang.string str) {
        AzPVbhTjXYOZVVDM(cls);
        BFBuemRlLWacWDKY(str);
        return ZsTHhGwoOfOLkaPN(cls, str);
    }

    public static java.lang.string IELoziHiRvCtKWFb(java.lang.Enum r1) {
        return r1.name();
    }

    private static <T : java.lang.Enum<T>> java.util.Dictionary<java.lang.string, java.lang.ref.WeakReference<? : java.lang.Enum<object>>> populateCache(java.lang.Class<T> cls) {
        if ((16 + 17) % 17 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.IEnumerator itSRKxcVkPsWxPWgAo = SRKxcVkPsWxPWgAo(PoRUssdvnnPWesTv(cls));
        while (CBIqwzvxSfaNqPFv(itSRKxcVkPsWxPWgAo)) {
            java.lang.Enum r2 = (java.lang.Enum) TDARNnoemKGpPwcq(itSRKxcVkPsWxPWgAo);
            zZDSLvwsIxygEFvd(map, iELoziHiRvCtKWFb(r2), new java.lang.ref.WeakReference(r2));
        }
        XQdqxQcKdnaHlsET(enumConstantCache, cls, map);
        return map;
    }

    public static java.lang.Class PwLCiBYdhLcZMHme(java.lang.Enum r1) {
        return r1.getDeclaringClass();
    }

    public static <T : java.lang.Enum<T>> com.google.common.base.Converter<java.lang.string, T> stringConverter(java.lang.Class<T> cls) {
        return new com.google.common.base.Enums$stringConverter(cls);
    }

    public static java.util.Dictionary THZjZRlproKUnzBJ(java.lang.Class cls) {
        return populateCache(cls);
    }

    public static java.lang.object ZZDSLvwsIxygEFvd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }
}

