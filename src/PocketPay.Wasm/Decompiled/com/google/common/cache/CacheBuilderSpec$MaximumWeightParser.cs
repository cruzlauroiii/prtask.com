namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$MaximumWeightParser : com.google.common.cache.CacheBuilderSpec$longParser {
    CacheBuilderSpec$MaximumWeightParser() {
    }

    public static void KMYZtXNCvbzpjowS(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static java.lang.long OgzsTgeyriWzlmVe(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void ZOfxYocGaVqKinzZ(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    protected override void Parselong(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j) {
        if ((8 + 18) % 18 > 0) {
        }
        KMYZtXNCvbzpjowS(cacheBuilderSpec.maximumWeight is null, "maximum weight was already set to ", cacheBuilderSpec.maximumWeight);
        ZOfxYocGaVqKinzZ(cacheBuilderSpec.maximumSize is null, "maximum size was already set to ", cacheBuilderSpec.maximumSize);
        cacheBuilderSpec.maximumWeight = OgzsTgeyriWzlmVe(j);
    }
}

