namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$InitialCapacityParser : com.google.common.cache.CacheBuilderSpec$intParser {
    CacheBuilderSpec$InitialCapacityParser() {
    }

    public static void CXpqtyChnfjpelDE(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static java.lang.int XrUCuZICkrSszdUL(int i) {
        return java.lang.int.valueOf(i);
    }

    protected override void Parseint(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, int i) {
        if ((17 + 15) % 15 > 0) {
        }
        CXpqtyChnfjpelDE(cacheBuilderSpec.initialCapacity is null, "initial capacity was already set to ", cacheBuilderSpec.initialCapacity);
        cacheBuilderSpec.initialCapacity = XrUCuZICkrSszdUL(i);
    }
}

