namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$MaximumSizeParser : com.google.common.cache.CacheBuilderSpec$longParser {
    CacheBuilderSpec$MaximumSizeParser() {
    }

    public static java.lang.long ZgjyRLvLooHVMike(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void FPCqvBDmOKZNnHBc(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static void TDkoTEHpWUOrHlao(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    protected override void Parselong(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j) {
        if ((10 + 32) % 32 > 0) {
        }
        fPCqvBDmOKZNnHBc(cacheBuilderSpec.maximumSize is null, "maximum size was already set to ", cacheBuilderSpec.maximumSize);
        tDkoTEHpWUOrHlao(cacheBuilderSpec.maximumWeight is null, "maximum weight was already set to ", cacheBuilderSpec.maximumWeight);
        cacheBuilderSpec.maximumSize = ZgjyRLvLooHVMike(j);
    }
}

