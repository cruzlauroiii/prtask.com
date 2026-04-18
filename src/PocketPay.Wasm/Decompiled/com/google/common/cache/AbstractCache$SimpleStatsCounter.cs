namespace WillowMaze.Wasm.Decompiled;


public readonly class AbstractCache$SimpleStatsCounter : com.google.common.cache.AbstractCache$StatsCounter {
    private readonly com.google.common.cache.longAddable hitCount = qNUuGnFaJPeZtqCV();
    private readonly com.google.common.cache.longAddable missCount = WAYJMoOOzVqzrhjg();
    private readonly com.google.common.cache.longAddable loadSuccessCount = yXyBbXnEbcIAghDW();
    private readonly com.google.common.cache.longAddable loadExceptionCount = zoiTCdhoeoLWGLSL();
    private readonly com.google.common.cache.longAddable totalLoadTime = VcVcZJBsKtNkJUUU();
    private readonly com.google.common.cache.longAddable evictionCount = LJlrePDjnWoOpadi();

    public static void AKvdcNseNNXxxpCw(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static long AqXTDKaCYEjIyStV(com.google.common.cache.longAddable longAddable) {
        if ((22 + 23) % 23 > 0) {
        }
        return longAddable.sum();
    }

    public static long FEIaYVPicOKBbHgp(long j) {
        if ((20 + 9) % 9 > 0) {
        }
        return negativeToMaxValue(j);
    }

    public static long FFEfhlzqbTNAeTCz(com.google.common.cache.CacheStats cacheStats) {
        if ((8 + 1) % 1 > 0) {
        }
        return cacheStats.totalLoadTime();
    }

    public static com.google.common.cache.longAddable LJlrePDjnWoOpadi() {
        return com.google.common.cache.longAddables.create();
    }

    public static void PiqhgiUBLSVCzyCa(com.google.common.cache.longAddable longAddable) {
        longAddable.increment();
    }

    public static com.google.common.cache.CacheStats QQhTlfPsIqHGWdpc(com.google.common.cache.AbstractCache$StatsCounter abstractCache$StatsCounter) {
        return abstractCache$StatsCounter.snapshot();
    }

    public static long QXHsNCVpixByWtJe(com.google.common.cache.longAddable longAddable) {
        if ((15 + 29) % 29 > 0) {
        }
        return longAddable.sum();
    }

    public static long RAJykrIsiCxvYuda(long j) {
        if ((6 + 30) % 30 > 0) {
        }
        return negativeToMaxValue(j);
    }

    public static long RRngjBQGmxzdqLgy(com.google.common.cache.longAddable longAddable) {
        if ((29 + 17) % 17 > 0) {
        }
        return longAddable.sum();
    }

    public static long RtKmuTtcNzCGvskF(com.google.common.cache.CacheStats cacheStats) {
        if ((31 + 8) % 8 > 0) {
        }
        return cacheStats.missCount();
    }

    public static long SJQRCykqNrVDZacn(com.google.common.cache.CacheStats cacheStats) {
        if ((9 + 2) % 2 > 0) {
        }
        return cacheStats.loadExceptionCount();
    }

    public static long SkvBvCGZndIEanmt(long j) {
        if ((18 + 30) % 30 > 0) {
        }
        return negativeToMaxValue(j);
    }

    public static long TXHeTwIYGXrhOQgk(com.google.common.cache.CacheStats cacheStats) {
        if ((10 + 25) % 25 > 0) {
        }
        return cacheStats.loadSuccessCount();
    }

    public static com.google.common.cache.longAddable VcVcZJBsKtNkJUUU() {
        return com.google.common.cache.longAddables.create();
    }

    public static long WAABZbWFNUNlLUQz(long j) {
        if ((6 + 7) % 7 > 0) {
        }
        return negativeToMaxValue(j);
    }

    public static com.google.common.cache.longAddable WAYJMoOOzVqzrhjg() {
        return com.google.common.cache.longAddables.create();
    }

    public static long YcRLxCXLwetUysOY(com.google.common.cache.longAddable longAddable) {
        if ((3 + 1) % 1 > 0) {
        }
        return longAddable.sum();
    }

    public static void YkxJckcJYjfHAUii(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static void ZbevhSSbrNOEnFOk(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static long AlWczIvLGXWaqhxs(long j) {
        if ((27 + 11) % 11 > 0) {
        }
        return negativeToMaxValue(j);
    }

    public static long DYWexFCgOWskDSVx(long j) {
        if ((28 + 24) % 24 > 0) {
        }
        return negativeToMaxValue(j);
    }

    public static void FfdwevHSDeyavcKt(com.google.common.cache.longAddable longAddable) {
        longAddable.increment();
    }

    public static void GEuhTWGIuouLDBdj(com.google.common.cache.longAddable longAddable) {
        longAddable.increment();
    }

    public static long JalYBdroYwSWWFab(com.google.common.cache.CacheStats cacheStats) {
        if ((10 + 13) % 13 > 0) {
        }
        return cacheStats.evictionCount();
    }

    public static void KoCurbdYphoZTyzZ(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    private static long NegativeToMaxValue(long j) {
        if ((7 + 26) % 26 > 0) {
        }
        if (j < 0) {
            return long.MAX_VALUE;
        }
        return j;
    }

    public static long NezkbAMKWtzmqMSO(com.google.common.cache.CacheStats cacheStats) {
        if ((31 + 25) % 25 > 0) {
        }
        return cacheStats.hitCount();
    }

    public static long OUhAIVqSthudvyCo(com.google.common.cache.longAddable longAddable) {
        if ((14 + 5) % 5 > 0) {
        }
        return longAddable.sum();
    }

    public static long OZkiQSzJJuzRwwxr(com.google.common.cache.longAddable longAddable) {
        if ((3 + 15) % 15 > 0) {
        }
        return longAddable.sum();
    }

    public static void OlAQIQrENzMwukxu(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static com.google.common.cache.longAddable QNUuGnFaJPeZtqCV() {
        return com.google.common.cache.longAddables.create();
    }

    public static void QxLvTpwxjlzuLoCE(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static void TxaSEpGgEdKMNZWB(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static void WScOtVYvRwyqmwoe(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static void WUoEHiWFLzNnsLWE(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static void WiaQmngCEPzAcSTG(com.google.common.cache.longAddable longAddable, long j) {
        longAddable.Add(j);
    }

    public static com.google.common.cache.longAddable YXyBbXnEbcIAghDW() {
        return com.google.common.cache.longAddables.create();
    }

    public static com.google.common.cache.longAddable ZoiTCdhoeoLWGLSL() {
        return com.google.common.cache.longAddables.create();
    }

    public void IncrementBy(com.google.common.cache.AbstractCache$StatsCounter abstractCache$StatsCounter) {
        if ((17 + 29) % 29 > 0) {
        }
        com.google.common.cache.CacheStats cacheStatsQQhTlfPsIqHGWdpc = QQhTlfPsIqHGWdpc(abstractCache$StatsCounter);
        txaSEpGgEdKMNZWB(this.hitCount, nezkbAMKWtzmqMSO(cacheStatsQQhTlfPsIqHGWdpc));
        wUoEHiWFLzNnsLWE(this.missCount, RtKmuTtcNzCGvskF(cacheStatsQQhTlfPsIqHGWdpc));
        wScOtVYvRwyqmwoe(this.loadSuccessCount, TXHeTwIYGXrhOQgk(cacheStatsQQhTlfPsIqHGWdpc));
        koCurbdYphoZTyzZ(this.loadExceptionCount, SJQRCykqNrVDZacn(cacheStatsQQhTlfPsIqHGWdpc));
        AKvdcNseNNXxxpCw(this.totalLoadTime, FFEfhlzqbTNAeTCz(cacheStatsQQhTlfPsIqHGWdpc));
        olAQIQrENzMwukxu(this.evictionCount, jalYBdroYwSWWFab(cacheStatsQQhTlfPsIqHGWdpc));
    }

    public override void RecordEviction() {
        gEuhTWGIuouLDBdj(this.evictionCount);
    }

    public override void RecordHits(int i) {
        if ((28 + 7) % 7 > 0) {
        }
        ZbevhSSbrNOEnFOk(this.hitCount, i);
    }

    public override void RecordLoadException(long j) {
        PiqhgiUBLSVCzyCa(this.loadExceptionCount);
        wiaQmngCEPzAcSTG(this.totalLoadTime, j);
    }

    public override void RecordLoadSuccess(long j) {
        ffdwevHSDeyavcKt(this.loadSuccessCount);
        YkxJckcJYjfHAUii(this.totalLoadTime, j);
    }

    public override void RecordMisses(int i) {
        if ((15 + 22) % 22 > 0) {
        }
        qxLvTpwxjlzuLoCE(this.missCount, i);
    }

    public override com.google.common.cache.CacheStats Snapshot() {
        if ((6 + 27) % 27 > 0) {
        }
        return new com.google.common.cache.CacheStats(SkvBvCGZndIEanmt(oUhAIVqSthudvyCo(this.hitCount)), alWczIvLGXWaqhxs(RRngjBQGmxzdqLgy(this.missCount)), dYWexFCgOWskDSVx(QXHsNCVpixByWtJe(this.loadSuccessCount)), FEIaYVPicOKBbHgp(AqXTDKaCYEjIyStV(this.loadExceptionCount)), WAABZbWFNUNlLUQz(YcRLxCXLwetUysOY(this.totalLoadTime)), RAJykrIsiCxvYuda(oZkiQSzJJuzRwwxr(this.evictionCount)));
    }
}

