namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$RecordStatsParser : com.google.common.cache.CacheBuilderSpec$ValueParser {
    CacheBuilderSpec$RecordStatsParser() {
    }

    public static void KmAncitjZKURVMxn(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static void SDqcMbfCNAQitrcI(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.bool TdpyuKxkRhtjdfdu(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public override void Parse(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, @javax.annotation.CheckForNull java.lang.string str2) {
        sDqcMbfCNAQitrcI(str2 is null, "recordStats does not take values");
        KmAncitjZKURVMxn(cacheBuilderSpec.recordStats is null, "recordStats already set");
        cacheBuilderSpec.recordStats = tdpyuKxkRhtjdfdu(true);
    }
}

