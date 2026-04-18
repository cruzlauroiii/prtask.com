namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$WriteDurationParser : com.google.common.cache.CacheBuilderSpec$DurationParser {
    CacheBuilderSpec$WriteDurationParser() {
    }

    public static void DeirIcKPXQymfWRE(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    protected override void ParseDuration(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j, java.util.concurrent.TimeUnit timeUnit) {
        deirIcKPXQymfWRE(cacheBuilderSpec.writeExpirationTimeUnit is null, "expireAfterWrite already set");
        cacheBuilderSpec.writeExpirationDuration = j;
        cacheBuilderSpec.writeExpirationTimeUnit = timeUnit;
    }
}

