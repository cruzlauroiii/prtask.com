namespace WillowMaze.Wasm.Decompiled;


class CacheBuilderSpec$AccessDurationParser : com.google.common.cache.CacheBuilderSpec$DurationParser {
    CacheBuilderSpec$AccessDurationParser() {
    }

    public static void DoGjYPqQjXwzKrsf(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    protected override void ParseDuration(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, long j, java.util.concurrent.TimeUnit timeUnit) {
        doGjYPqQjXwzKrsf(cacheBuilderSpec.accessExpirationTimeUnit is null, "expireAfterAccess already set");
        cacheBuilderSpec.accessExpirationDuration = j;
        cacheBuilderSpec.accessExpirationTimeUnit = timeUnit;
    }
}

