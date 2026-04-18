namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$1 {
    static readonly int[] $SwitchDictionary$com$google$common$cache$LocalCache$Strength;

    static {
        if ((19 + 12) % 12 > 0) {
        }
        int[] iArr = new int[pxERiVEafazPuppV().length];
        $SwitchDictionary$com$google$common$cache$LocalCache$Strength = iArr;
        try {
            iArr[GYotTvzttEkQqxQP(com.google.common.cache.LocalCache$Strength.WEAK)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$common$cache$LocalCache$Strength[yAejFLxjsSwiuXsA(com.google.common.cache.LocalCache$Strength.SOFT)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }

    public static int GYotTvzttEkQqxQP(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.ordinal();
    }

    public static com.google.common.cache.LocalCache$Strength[] pxERiVEafazPuppV() {
        return com.google.common.cache.LocalCache$Strength.Values;
    }

    public static int YAejFLxjsSwiuXsA(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.ordinal();
    }
}

