namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$RefreshDurationParser : com.google.common.cache.CacheBuilderSpec$DurationParser {
    CacheBuilderSpec$RefreshDurationParser() {
    }

    public static void BqVpElBHvfrQPxXB(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    protected override void ParseDuration(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j, java.util.concurrent.TimeUnit timeUnit) {
        BqVpElBHvfrQPxXB(cacheBuilderSpec.refreshTimeUnit is null, "refreshAfterWrite already set");
        cacheBuilderSpec.refreshDuration = j;
        cacheBuilderSpec.refreshTimeUnit = timeUnit;
    }
}

