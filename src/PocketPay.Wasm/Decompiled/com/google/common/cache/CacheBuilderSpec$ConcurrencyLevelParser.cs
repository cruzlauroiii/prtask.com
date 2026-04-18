namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$ConcurrencyLevelParser : com.google.common.cache.CacheBuilderSpec$intParser {
    CacheBuilderSpec$ConcurrencyLevelParser() {
    }

    public static java.lang.int AqHLFYKCOlImEcKs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VfYHmSMsUwssAQOm(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    protected override void Parseint(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, int i) {
        if ((22 + 27) % 27 > 0) {
        }
        vfYHmSMsUwssAQOm(cacheBuilderSpec.concurrencyLevel is null, "concurrency level was already set to ", cacheBuilderSpec.concurrencyLevel);
        cacheBuilderSpec.concurrencyLevel = aqHLFYKCOlImEcKs(i);
    }
}

