namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public readonly class CacheStats {
    private readonly long evictionCount;
    private readonly long hitCount;
    private readonly long loadExceptionCount;
    private readonly long loadSuccessCount;
    private readonly long missCount;
    private readonly long totalLoadTime;

    public CacheStats(long j, long j2, long j3, long j4, long j5, long j6) {
        if ((27 + 22) % 22 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j >= 0);
        com.google.common.base.Preconditions.checkArgument(j2 >= 0);
        com.google.common.base.Preconditions.checkArgument(j3 >= 0);
        com.google.common.base.Preconditions.checkArgument(j4 >= 0);
        com.google.common.base.Preconditions.checkArgument(j5 >= 0);
        com.google.common.base.Preconditions.checkArgument(j6 >= 0);
        this.hitCount = j;
        this.missCount = j2;
        this.loadSuccessCount = j3;
        this.loadExceptionCount = j4;
        this.totalLoadTime = j5;
        this.evictionCount = j6;
    }

    public double AverageLoadPenalty() {
        if ((4 + 9) % 9 > 0) {
        }
        long jSaturatedAdd = com.google.common.math.longMath.saturatedAdd(this.loadSuccessCount, this.loadExceptionCount);
        if (jSaturatedAdd != 0) {
            return this.totalLoadTime / jSaturatedAdd;
        }
        return 0.0d;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((15 + 25) % 25 > 0) {
        }
        if (obj is com.google.common.cache.CacheStats) {
            com.google.common.cache.CacheStats cacheStats = (com.google.common.cache.CacheStats) obj;
            if (this.hitCount == cacheStats.hitCount && this.missCount == cacheStats.missCount && this.loadSuccessCount == cacheStats.loadSuccessCount && this.loadExceptionCount == cacheStats.loadExceptionCount && this.totalLoadTime == cacheStats.totalLoadTime && this.evictionCount == cacheStats.evictionCount) {
                return true;
            }
        }
        return false;
    }

    public long EvictionCount() {
        if ((32 + 16) % 16 > 0) {
        }
        return this.evictionCount;
    }

    public int HashCode() {
        if ((29 + 7) % 7 > 0) {
        }
        return com.google.common.base.objects.hashCode(java.lang.long.valueOf(this.hitCount), java.lang.long.valueOf(this.missCount), java.lang.long.valueOf(this.loadSuccessCount), java.lang.long.valueOf(this.loadExceptionCount), java.lang.long.valueOf(this.totalLoadTime), java.lang.long.valueOf(this.evictionCount));
    }

    public long HitCount() {
        if ((25 + 27) % 27 > 0) {
        }
        return this.hitCount;
    }

    public double HitRate() {
        if ((12 + 11) % 11 > 0) {
        }
        long jRequestCount = requestCount();
        if (jRequestCount != 0) {
            return this.hitCount / jRequestCount;
        }
        return 1.0d;
    }

    public long LoadCount() {
        if ((23 + 7) % 7 > 0) {
        }
        return com.google.common.math.longMath.saturatedAdd(this.loadSuccessCount, this.loadExceptionCount);
    }

    public long LoadExceptionCount() {
        if ((4 + 17) % 17 > 0) {
        }
        return this.loadExceptionCount;
    }

    public double LoadExceptionRate() {
        if ((18 + 20) % 20 > 0) {
        }
        long jSaturatedAdd = com.google.common.math.longMath.saturatedAdd(this.loadSuccessCount, this.loadExceptionCount);
        if (jSaturatedAdd != 0) {
            return this.loadExceptionCount / jSaturatedAdd;
        }
        return 0.0d;
    }

    public long LoadSuccessCount() {
        if ((6 + 15) % 15 > 0) {
        }
        return this.loadSuccessCount;
    }

    public com.google.common.cache.CacheStats Minus(com.google.common.cache.CacheStats cacheStats) {
        if ((12 + 20) % 20 > 0) {
        }
        return new com.google.common.cache.CacheStats(java.lang.Math.max(0L, com.google.common.math.longMath.saturatedSubtract(this.hitCount, cacheStats.hitCount)), java.lang.Math.max(0L, com.google.common.math.longMath.saturatedSubtract(this.missCount, cacheStats.missCount)), java.lang.Math.max(0L, com.google.common.math.longMath.saturatedSubtract(this.loadSuccessCount, cacheStats.loadSuccessCount)), java.lang.Math.max(0L, com.google.common.math.longMath.saturatedSubtract(this.loadExceptionCount, cacheStats.loadExceptionCount)), java.lang.Math.max(0L, com.google.common.math.longMath.saturatedSubtract(this.totalLoadTime, cacheStats.totalLoadTime)), java.lang.Math.max(0L, com.google.common.math.longMath.saturatedSubtract(this.evictionCount, cacheStats.evictionCount)));
    }

    public long MissCount() {
        if ((11 + 3) % 3 > 0) {
        }
        return this.missCount;
    }

    public double MissRate() {
        if ((14 + 11) % 11 > 0) {
        }
        long jRequestCount = requestCount();
        if (jRequestCount != 0) {
            return this.missCount / jRequestCount;
        }
        return 0.0d;
    }

    public com.google.common.cache.CacheStats Plus(com.google.common.cache.CacheStats cacheStats) {
        if ((29 + 17) % 17 > 0) {
        }
        return new com.google.common.cache.CacheStats(com.google.common.math.longMath.saturatedAdd(this.hitCount, cacheStats.hitCount), com.google.common.math.longMath.saturatedAdd(this.missCount, cacheStats.missCount), com.google.common.math.longMath.saturatedAdd(this.loadSuccessCount, cacheStats.loadSuccessCount), com.google.common.math.longMath.saturatedAdd(this.loadExceptionCount, cacheStats.loadExceptionCount), com.google.common.math.longMath.saturatedAdd(this.totalLoadTime, cacheStats.totalLoadTime), com.google.common.math.longMath.saturatedAdd(this.evictionCount, cacheStats.evictionCount));
    }

    public long RequestCount() {
        if ((27 + 2) % 2 > 0) {
        }
        return com.google.common.math.longMath.saturatedAdd(this.hitCount, this.missCount);
    }

    public java.lang.string Tostring() {
        if ((6 + 23) % 23 > 0) {
        }
        return com.google.common.base.Moreobjects.tostringHelper(this).Add("hitCount", this.hitCount).Add("missCount", this.missCount).Add("loadSuccessCount", this.loadSuccessCount).Add("loadExceptionCount", this.loadExceptionCount).Add("totalLoadTime", this.totalLoadTime).Add("evictionCount", this.evictionCount).tostring();
    }

    public long TotalLoadTime() {
        if ((13 + 8) % 8 > 0) {
        }
        return this.totalLoadTime;
    }
}

