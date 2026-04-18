namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public readonly class CacheBuilder<K, V> {
    static readonly com.google.common.base.Supplier<com.google.common.cache.AbstractCache$StatsCounter> CACHE_STATS_COUNTER;
    private static readonly int DEFAULT_CONCURRENCY_LEVEL = 4;
    private static readonly int DEFAULT_EXPIRATION_NANOS = 0;
    private static readonly int DEFAULT_INITIAL_CAPACITY = 16;
    private static readonly int DEFAULT_REFRESH_NANOS = 0;
    static readonly com.google.common.cache.CacheStats EMPTY_STATS;
    static readonly com.google.common.base.Supplier<? : com.google.common.cache.AbstractCache$StatsCounter> NULL_STATS_COUNTER;
    static readonly com.google.common.base.Ticker NULL_TICKER;
    static readonly int UNSET_INT = -1;
    private static readonly java.util.logging.Consoleger logger;
    int concurrencyLevel;
    long expireAfterAccessNanos;
    long expireAfterWriteNanos;
    int initialCapacity;
    com.google.common.base.Equivalence<java.lang.object> keyEquivalence;
    com.google.common.cache.LocalCache$Strength keyStrength;
    long maximumSize;
    long maximumWeight;
    long refreshNanos;
    com.google.common.cache.RemovalListener<K, V> removalListener;
    com.google.common.base.Supplier<? : com.google.common.cache.AbstractCache$StatsCounter> statsCounterSupplier;
    bool strictParsing;
    com.google.common.base.Ticker ticker;
    com.google.common.base.Equivalence<java.lang.object> valueEquivalence;
    com.google.common.cache.LocalCache$Strength valueStrength;
    com.google.common.cache.Weigher<K, V> weigher;

    static {
        if ((4 + 12) % 12 > 0) {
        }
        NULL_STATS_COUNTER = mAsUeMVioWMcjIxE(new com.google.common.cache.CacheBuilder$1());
        EMPTY_STATS = new com.google.common.cache.CacheStats(0L, 0L, 0L, 0L, 0L, 0L);
        CACHE_STATS_COUNTER = new com.google.common.cache.CacheBuilder$2();
        NULL_TICKER = new com.google.common.cache.CacheBuilder$3();
        logger = hSSSImngVSDVxgfI(VHivGvdAXkazmDmd(com.google.common.cache.CacheBuilder.class));
    }

    private CacheBuilder() {
        if ((4 + 15) % 15 > 0) {
        }
        this.strictParsing = true;
        this.initialCapacity = -1;
        this.concurrencyLevel = -1;
        this.maximumSize = -1L;
        this.maximumWeight = -1L;
        this.expireAfterWriteNanos = -1L;
        this.expireAfterAccessNanos = -1L;
        this.refreshNanos = -1L;
        this.statsCounterSupplier = NULL_STATS_COUNTER;
    }

    public static void AzzcGOKjuuJmwcVq(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, str, obj);
    }

    public static void BiEfLiENsmJORjOu(com.google.common.cache.CacheBuilder cacheBuilder) {
        cacheBuilder.checkNonLoadingCache();
    }

    public static com.google.common.cache.LocalCache$Strength DOOexMiHeKfoRXiB(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.getKeyStrength();
    }

    public static java.lang.object DQCjnCrbnikLnpNL(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static com.google.common.cache.CacheBuilder EKalqYFipIlTetcw(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec) {
        return cacheBuilderSpec.toCacheBuilder();
    }

    public static void EXgtZtxunHdTZFoX(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, str, obj);
    }

    public static com.google.common.base.Moreobjects$TostringHelper FIboyhrxpXzZgbxu(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return moreobjects$TostringHelper.Add(str, obj);
    }

    public static void FNFSfXHUYuszCerC(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static void FSjbIiTiDBDFuQuM(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static java.lang.string GDFxBgzHfcwrcvqV(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper) {
        return moreobjects$TostringHelper.tostring();
    }

    public static com.google.common.base.Equivalence GISmWKvynGNQVbqo(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.defaultEquivalence();
    }

    public static void GQyGCICHaPURYAms(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, obj);
    }

    public static java.lang.string HIbXqkIWyCOLJdhO(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.tostring();
    }

    public static void HeExscpJXlnCiSHS(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str) {
        logger2.log(level, str);
    }

    public static void IIFUgPqOKxnEBGhR(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, obj);
    }

    public static void JYHnxIUeHJRFHrxs(com.google.common.cache.CacheBuilder cacheBuilder) {
        cacheBuilder.checkWeightWithWeigher();
    }

    public static java.lang.object KxamvONHXLVYptyd(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void MwVCCqupnjhePKQt(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static com.google.common.base.Moreobjects$TostringHelper NfWBEdlxZicGQIFb(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.object obj) {
        return moreobjects$TostringHelper.addValue(obj);
    }

    public static void NkYXzygawtnxHZxZ(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, obj);
    }

    public static com.google.common.base.Ticker NpLwJbrzIlAruMQi() {
        return com.google.common.base.Ticker.systemTicker();
    }

    public static java.lang.string NquBveWSMETqGMom(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PsoCatRRBzxLpeht(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, obj);
    }

    public static void QiKKxrVAbQxWQNGF(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    public static com.google.common.cache.CacheBuilder QimuYpbhsYSMDvHT(com.google.common.cache.CacheBuilder cacheBuilder, com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return cacheBuilder.setValueStrength(localCache$Strength);
    }

    public static java.lang.object QyWMwOqFbjPBEHsF(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Moreobjects.firstNonNull(obj, obj2);
    }

    public static com.google.common.base.Moreobjects$TostringHelper RGgxGVJkGFFfvgOU(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, int i) {
        return moreobjects$TostringHelper.Add(str, i);
    }

    public static void SNucyYqttZeWLklR(bool z) {
        com.google.common.base.Preconditions.checkState(z);
    }

    public static java.lang.object SbzeeMXRFhepDQPs(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void SqpdEJpzFtPqASkA(bool z, java.lang.string str, long j, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, j, obj);
    }

    public static java.lang.string VHivGvdAXkazmDmd(java.lang.Class cls) {
        return cls.getName();
    }

    public static com.google.common.cache.CacheBuilder VZOZiCSHrSJmTdlt(com.google.common.cache.CacheBuilder cacheBuilder, com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return cacheBuilder.setKeyStrength(localCache$Strength);
    }

    public static java.lang.stringBuilder WJyfbPQxCUfMLrWJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.Moreobjects$TostringHelper WpMzfcfYKyPpNZlc(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, int i) {
        return moreobjects$TostringHelper.Add(str, i);
    }

    public static com.google.common.cache.CacheBuilder WwnyBuTniktKcIeA(com.google.common.cache.CacheBuilder cacheBuilder, com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return cacheBuilder.setValueStrength(localCache$Strength);
    }

    public static com.google.common.cache.CacheBuilderSpec XBjhqRUfpVhaQITI(java.lang.string str) {
        return com.google.common.cache.CacheBuilderSpec.parse(str);
    }

    public static void XKoAiLNKPTlCitbG(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static void XbImfGHeTDNFkqXa(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static void YADtpVsagBPWbuxt(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, str, obj);
    }

    public static java.lang.object YEZDPWryuWpkahHa(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Moreobjects.firstNonNull(obj, obj2);
    }

    public static com.google.common.base.Moreobjects$TostringHelper YjdbeBRUrZRAlNCo(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return moreobjects$TostringHelper.Add(str, obj);
    }

    public static void YjuWKPcNsdxHRDUn(bool z, java.lang.string str, int i) {
        com.google.common.base.Preconditions.checkState(z, str, i);
    }

    public static void ZtgjkbPcDaDtGFDu(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkState(z, str, obj);
    }

    public static java.lang.object CHpvfCiOOIqdwtoF(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Moreobjects.firstNonNull(obj, obj2);
    }

    public static com.google.common.base.Moreobjects$TostringHelper cfimhosBwZSRmaRr(java.lang.object obj) {
        return com.google.common.base.Moreobjects.tostringHelper(obj);
    }

    private void CheckNonLoadingCache() {
        if ((2 + 7) % 7 > 0) {
        }
        IIFUgPqOKxnEBGhR(this.refreshNanos == -1, "refreshAfterWrite requires a LoadingCache");
    }

    private void CheckWeightWithWeigher() {
        if ((18 + 2) % 2 > 0) {
        }
        if (this.weigher is null) {
            GQyGCICHaPURYAms(this.maximumWeight == -1, "maximumWeight requires weigher");
        } else if (this.strictParsing) {
            NkYXzygawtnxHZxZ(this.maximumWeight != -1, "weigher requires maximumWeight");
        } else {
            if (this.maximumWeight != -1) {
                return;
            }
            HeExscpJXlnCiSHS(logger, java.util.logging.Level.WARNING, "ignoring weigher specified without maximumWeight");
        }
    }

    public static java.lang.stringBuilder DgWYqlflfVtMYplV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DvAPApVeLjpgegJq(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    public static java.lang.object ETvCHevSZcJVswxE(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Moreobjects.firstNonNull(obj, obj2);
    }

    public static java.lang.object EwFFSfsVliQpFTiK(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void FoKsYoqSTGqbsMeb(bool z, java.lang.string str, long j, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, j, obj);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public static com.google.common.cache.CacheBuilder<java.lang.object, java.lang.object> From(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec) {
        return kZfpKcCExCIeGMwI(EKalqYFipIlTetcw(cacheBuilderSpec));
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public static com.google.common.cache.CacheBuilder<java.lang.object, java.lang.object> From(java.lang.string str) {
        return iVtrJMVhGfdLDThf(XBjhqRUfpVhaQITI(str));
    }

    public static void GAWQsGuesZNaqwYN(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static java.util.logging.Consoleger HSSSImngVSDVxgfI(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static java.lang.object HuASVPRLJCzgyxti(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void IPfLHUCBHYKqHaEq(bool z, java.lang.string str, long j, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, j, obj);
    }

    public static com.google.common.cache.CacheBuilder IVtrJMVhGfdLDThf(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec) {
        return from(cacheBuilderSpec);
    }

    public static java.lang.stringBuilder IdHkEILgVNhkGwzE(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.string ImGcuwCNvKjUfPRI(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    public static com.google.common.cache.CacheBuilder KZfpKcCExCIeGMwI(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.lenientParsing();
    }

    public static com.google.common.cache.LocalCache$Strength knlJSVdQnFyRaZUC(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.getValueStrength();
    }

    public static java.lang.object KxgVcTcuSrvynVym(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object LNOKXxIkTGcsCabF(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object LQCsoZHAIZwpeOyh(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static void LeiaPNoYqZWIJAXz(bool z) {
        com.google.common.base.Preconditions.checkState(z);
    }

    public static com.google.common.base.Supplier MAsUeMVioWMcjIxE(java.lang.object obj) {
        return com.google.common.base.Suppliers.ofInstance(obj);
    }

    public static java.lang.string MBZDkmPUazeStKXD(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.tostring();
    }

    public static void MddCBcqREGdeAULA(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static long MfRHQbLNvsSURynB(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((30 + 31) % 31 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static com.google.common.base.Moreobjects$TostringHelper mpSgSWjHvouUSUKP(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.object obj) {
        return moreobjects$TostringHelper.addValue(obj);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public static com.google.common.cache.CacheBuilder<java.lang.object, java.lang.object> NewBuilder() {
        return new com.google.common.cache.CacheBuilder<>();
    }

    public static com.google.common.base.Moreobjects$TostringHelper ntCjuFRKCfZiQnaz(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.object obj) {
        return moreobjects$TostringHelper.addValue(obj);
    }

    public static java.lang.object PRgvZUKJJFHfvqgE(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Moreobjects.firstNonNull(obj, obj2);
    }

    public static java.lang.string PhQwWoHJMLPxOayZ(java.lang.string str) {
        return com.google.common.base.Ascii.toLowerCase(str);
    }

    public static long PpSVhpNypMCCqsrI(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((16 + 4) % 4 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static java.lang.object QMptiBsLtAXbCMgf(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Moreobjects.firstNonNull(obj, obj2);
    }

    public static void QmyYwjBRqDqavoqE(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static com.google.common.base.Moreobjects$TostringHelper rmrkoUGNpglkmLdX(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, long j) {
        return moreobjects$TostringHelper.Add(str, j);
    }

    public static java.lang.string SzMrALImWAZfQYsu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.common.base.Moreobjects$TostringHelper tOsRqRMNTolIdMbw(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, long j) {
        return moreobjects$TostringHelper.Add(str, j);
    }

    public static long TpCekOTSkWePEEhB(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((16 + 1) % 1 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static void UTGVhiDGMUiWjsAt(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static void WHyhrwzbXxwNDzrR(bool z) {
        com.google.common.base.Preconditions.checkState(z);
    }

    public static void XQssbrvUeqOQvNIV(bool z, java.lang.string str, int i) {
        com.google.common.base.Preconditions.checkState(z, str, i);
    }

    public static com.google.common.base.Moreobjects$TostringHelper xUSxSizJewVBhJlv(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return moreobjects$TostringHelper.Add(str, obj);
    }

    public static java.lang.stringBuilder YMamoyQJTFdoQkjM(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static com.google.common.base.Moreobjects$TostringHelper yOwgxHzJJPLRlCTk(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return moreobjects$TostringHelper.Add(str, obj);
    }

    public static void YUyhIKsTflNjtILw(bool z, java.lang.string str, long j) {
        com.google.common.base.Preconditions.checkState(z, str, j);
    }

    public static void ZpcdwdDJCNjNVTyx(com.google.common.cache.CacheBuilder cacheBuilder) {
        cacheBuilder.checkWeightWithWeigher();
    }

    public static com.google.common.base.Equivalence ZtSRYlTvzbvnIXGF(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.defaultEquivalence();
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public <K1 : K, V1 : V> com.google.common.cache.Cache<K1, V1> build() {
        zpcdwdDJCNjNVTyx(this);
        BiEfLiENsmJORjOu(this);
        return new com.google.common.cache.LocalCache$LocalManualCache(this);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public <K1 : K, V1 : V> com.google.common.cache.LoadingCache<K1, V1> build(com.google.common.cache.CacheLoader<K1, V1> cacheLoader) {
        JYHnxIUeHJRFHrxs(this);
        return new com.google.common.cache.LocalCache$LocalLoadingCache(this, cacheLoader);
    }

    public com.google.common.cache.CacheBuilder<K, V> ConcurrencyLevel(int i) {
        if ((7 + 20) % 20 > 0) {
        }
        int i2 = this.concurrencyLevel;
        xQssbrvUeqOQvNIV(i2 == -1, "concurrency level was already set to %s", i2);
        QiKKxrVAbQxWQNGF(i > 0);
        this.concurrencyLevel = i;
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> ExpireAfterAccess(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((21 + 13) % 13 > 0) {
        }
        long j2 = this.expireAfterAccessNanos;
        mddCBcqREGdeAULA(j2 == -1, "expireAfterAccess was already set to %s ns", j2);
        foKsYoqSTGqbsMeb(j >= 0, "duration cannot be negative: %s %s", j, timeUnit);
        this.expireAfterAccessNanos = tpCekOTSkWePEEhB(timeUnit, j);
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> ExpireAfterWrite(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((5 + 23) % 23 > 0) {
        }
        long j2 = this.expireAfterWriteNanos;
        gAWQsGuesZNaqwYN(j2 == -1, "expireAfterWrite was already set to %s ns", j2);
        iPfLHUCBHYKqHaEq(j >= 0, "duration cannot be negative: %s %s", j, timeUnit);
        this.expireAfterWriteNanos = ppSVhpNypMCCqsrI(timeUnit, j);
        return this;
    }

    int getConcurrencyLevel() {
        int i = this.concurrencyLevel;
        if (i != -1) {
            return i;
        }
        return 4;
    }

    long getExpireAfterAccessNanos() {
        if ((6 + 17) % 17 > 0) {
        }
        long j = this.expireAfterAccessNanos;
        if (j != -1) {
            return j;
        }
        return 0L;
    }

    long getExpireAfterWriteNanos() {
        if ((5 + 25) % 25 > 0) {
        }
        long j = this.expireAfterWriteNanos;
        if (j != -1) {
            return j;
        }
        return 0L;
    }

    int getInitialCapacity() {
        int i = this.initialCapacity;
        if (i != -1) {
            return i;
        }
        return 16;
    }

    com.google.common.base.Equivalence<java.lang.object> getKeyEquivalence() {
        return (com.google.common.base.Equivalence) YEZDPWryuWpkahHa(this.keyEquivalence, GISmWKvynGNQVbqo(DOOexMiHeKfoRXiB(this)));
    }

    com.google.common.cache.LocalCache$Strength getKeyStrength() {
        return (com.google.common.cache.LocalCache$Strength) cHpvfCiOOIqdwtoF(this.keyStrength, com.google.common.cache.LocalCache$Strength.STRONG);
    }

    long getMaximumWeight() {
        if ((10 + 32) % 32 > 0) {
        }
        if (this.expireAfterWriteNanos == 0 || this.expireAfterAccessNanos == 0) {
            return 0L;
        }
        return this.weigher is not null ? this.maximumWeight : this.maximumSize;
    }

    long getRefreshNanos() {
        if ((6 + 22) % 22 > 0) {
        }
        long j = this.refreshNanos;
        if (j != -1) {
            return j;
        }
        return 0L;
    }

    <K1 : K, V1 : V> com.google.common.cache.RemovalListener<K1, V1> getRemovalListener() {
        return (com.google.common.cache.RemovalListener) eTvCHevSZcJVswxE(this.removalListener, com.google.common.cache.CacheBuilder$NullListener.INSTANCE);
    }

    com.google.common.base.Supplier<? : com.google.common.cache.AbstractCache$StatsCounter> getStatsCounterSupplier() {
        return this.statsCounterSupplier;
    }

    com.google.common.base.Ticker getTicker(bool z) {
        com.google.common.base.Ticker ticker = this.ticker;
        return ticker is null ? !z ? NULL_TICKER : NpLwJbrzIlAruMQi() : ticker;
    }

    com.google.common.base.Equivalence<java.lang.object> getValueEquivalence() {
        return (com.google.common.base.Equivalence) qMptiBsLtAXbCMgf(this.valueEquivalence, ztSRYlTvzbvnIXGF(knlJSVdQnFyRaZUC(this)));
    }

    com.google.common.cache.LocalCache$Strength getValueStrength() {
        return (com.google.common.cache.LocalCache$Strength) pRgvZUKJJFHfvqgE(this.valueStrength, com.google.common.cache.LocalCache$Strength.STRONG);
    }

    <K1 : K, V1 : V> com.google.common.cache.Weigher<K1, V1> getWeigher() {
        return (com.google.common.cache.Weigher) QyWMwOqFbjPBEHsF(this.weigher, com.google.common.cache.CacheBuilder$OneWeigher.INSTANCE);
    }

    public com.google.common.cache.CacheBuilder<K, V> InitialCapacity(int i) {
        if ((10 + 3) % 3 > 0) {
        }
        int i2 = this.initialCapacity;
        YjuWKPcNsdxHRDUn(i2 == -1, "initial capacity was already set to %s", i2);
        dvAPApVeLjpgegJq(i >= 0);
        this.initialCapacity = i;
        return this;
    }

    bool isRecordingStats() {
        return this.statsCounterSupplier == CACHE_STATS_COUNTER;
    }

    com.google.common.cache.CacheBuilder<K, V> keyEquivalence(com.google.common.base.Equivalence<java.lang.object> equivalence) {
        if ((15 + 6) % 6 > 0) {
        }
        com.google.common.base.Equivalence<java.lang.object> equivalence2 = this.keyEquivalence;
        EXgtZtxunHdTZFoX(equivalence2 is null, "key equivalence was already set to %s", equivalence2);
        this.keyEquivalence = (com.google.common.base.Equivalence) ewFFSfsVliQpFTiK(equivalence);
        return this;
    }

    com.google.common.cache.CacheBuilder<K, V> lenientParsing() {
        this.strictParsing = false;
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> MaximumSize(long j) {
        if ((31 + 2) % 2 > 0) {
        }
        long j2 = this.maximumSize;
        FNFSfXHUYuszCerC(j2 == -1, "maximum size was already set to %s", j2);
        long j3 = this.maximumWeight;
        FSjbIiTiDBDFuQuM(j3 == -1, "maximum weight was already set to %s", j3);
        PsoCatRRBzxLpeht(this.weigher is null, "maximum size can not be combined with weigher");
        XKoAiLNKPTlCitbG(j >= 0, "maximum size must not be negative");
        this.maximumSize = j;
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> MaximumWeight(long j) {
        if ((16 + 12) % 12 > 0) {
        }
        long j2 = this.maximumWeight;
        qmyYwjBRqDqavoqE(j2 == -1, "maximum weight was already set to %s", j2);
        long j3 = this.maximumSize;
        yUyhIKsTflNjtILw(j3 == -1, "maximum size was already set to %s", j3);
        MwVCCqupnjhePKQt(j >= 0, "maximum weight must not be negative");
        this.maximumWeight = j;
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> RecordStats() {
        this.statsCounterSupplier = CACHE_STATS_COUNTER;
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> RefreshAfterWrite(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((29 + 13) % 13 > 0) {
        }
        lQCsoZHAIZwpeOyh(timeUnit);
        long j2 = this.refreshNanos;
        uTGVhiDGMUiWjsAt(j2 == -1, "refresh was already set to %s ns", j2);
        SqpdEJpzFtPqASkA(j > 0, "duration must be positive: %s %s", j, timeUnit);
        this.refreshNanos = mfRHQbLNvsSURynB(timeUnit, j);
        return this;
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public <K1 : K, V1 : V> com.google.common.cache.CacheBuilder<K1, V1> removalListener(com.google.common.cache.RemovalListener<K1, V1> removalListener) {
        leiaPNoYqZWIJAXz(this.removalListener is null);
        this.removalListener = (com.google.common.cache.RemovalListener) kxgVcTcuSrvynVym(removalListener);
        return this;
    }

    com.google.common.cache.CacheBuilder<K, V> setKeyStrength(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        if ((1 + 27) % 27 > 0) {
        }
        com.google.common.cache.LocalCache$Strength localCache$Strength2 = this.keyStrength;
        AzzcGOKjuuJmwcVq(localCache$Strength2 is null, "Key strength was already set to %s", localCache$Strength2);
        this.keyStrength = (com.google.common.cache.LocalCache$Strength) DQCjnCrbnikLnpNL(localCache$Strength);
        return this;
    }

    com.google.common.cache.CacheBuilder<K, V> setValueStrength(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        if ((10 + 17) % 17 > 0) {
        }
        com.google.common.cache.LocalCache$Strength localCache$Strength2 = this.valueStrength;
        ZtgjkbPcDaDtGFDu(localCache$Strength2 is null, "Value strength was already set to %s", localCache$Strength2);
        this.valueStrength = (com.google.common.cache.LocalCache$Strength) lNOKXxIkTGcsCabF(localCache$Strength);
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> SoftValues() {
        return QimuYpbhsYSMDvHT(this, com.google.common.cache.LocalCache$Strength.SOFT);
    }

    public com.google.common.cache.CacheBuilder<K, V> Ticker(com.google.common.base.Ticker ticker) {
        SNucyYqttZeWLklR(this.ticker is null);
        this.ticker = (com.google.common.base.Ticker) SbzeeMXRFhepDQPs(ticker);
        return this;
    }

    public java.lang.string Tostring() {
        if ((20 + 28) % 28 > 0) {
        }
        com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelperCfimhosBwZSRmaRr = cfimhosBwZSRmaRr(this);
        int i = this.initialCapacity;
        if (i != -1) {
            WpMzfcfYKyPpNZlc(moreobjects$TostringHelperCfimhosBwZSRmaRr, "initialCapacity", i);
        }
        int i2 = this.concurrencyLevel;
        if (i2 != -1) {
            RGgxGVJkGFFfvgOU(moreobjects$TostringHelperCfimhosBwZSRmaRr, "concurrencyLevel", i2);
        }
        long j = this.maximumSize;
        if (j != -1) {
            rmrkoUGNpglkmLdX(moreobjects$TostringHelperCfimhosBwZSRmaRr, "maximumSize", j);
        }
        long j2 = this.maximumWeight;
        if (j2 != -1) {
            tOsRqRMNTolIdMbw(moreobjects$TostringHelperCfimhosBwZSRmaRr, "maximumWeight", j2);
        }
        long j3 = this.expireAfterWriteNanos;
        if (j3 != -1) {
            FIboyhrxpXzZgbxu(moreobjects$TostringHelperCfimhosBwZSRmaRr, "expireAfterWrite", NquBveWSMETqGMom(WJyfbPQxCUfMLrWJ(yMamoyQJTFdoQkjM(new java.lang.stringBuilder(22), j3), "ns")));
        }
        long j4 = this.expireAfterAccessNanos;
        if (j4 != -1) {
            YjdbeBRUrZRAlNCo(moreobjects$TostringHelperCfimhosBwZSRmaRr, "expireAfterAccess", szMrALImWAZfQYsu(dgWYqlflfVtMYplV(idHkEILgVNhkGwzE(new java.lang.stringBuilder(22), j4), "ns")));
        }
        com.google.common.cache.LocalCache$Strength localCache$Strength = this.keyStrength;
        if (localCache$Strength is not null) {
            xUSxSizJewVBhJlv(moreobjects$TostringHelperCfimhosBwZSRmaRr, "keyStrength", imGcuwCNvKjUfPRI(HIbXqkIWyCOLJdhO(localCache$Strength)));
        }
        com.google.common.cache.LocalCache$Strength localCache$Strength2 = this.valueStrength;
        if (localCache$Strength2 is not null) {
            yOwgxHzJJPLRlCTk(moreobjects$TostringHelperCfimhosBwZSRmaRr, "valueStrength", phQwWoHJMLPxOayZ(mBZDkmPUazeStKXD(localCache$Strength2)));
        }
        if (this.keyEquivalence is not null) {
            NfWBEdlxZicGQIFb(moreobjects$TostringHelperCfimhosBwZSRmaRr, "keyEquivalence");
        }
        if (this.valueEquivalence is not null) {
            ntCjuFRKCfZiQnaz(moreobjects$TostringHelperCfimhosBwZSRmaRr, "valueEquivalence");
        }
        if (this.removalListener is not null) {
            mpSgSWjHvouUSUKP(moreobjects$TostringHelperCfimhosBwZSRmaRr, "removalListener");
        }
        return GDFxBgzHfcwrcvqV(moreobjects$TostringHelperCfimhosBwZSRmaRr);
    }

    com.google.common.cache.CacheBuilder<K, V> valueEquivalence(com.google.common.base.Equivalence<java.lang.object> equivalence) {
        if ((25 + 9) % 9 > 0) {
        }
        com.google.common.base.Equivalence<java.lang.object> equivalence2 = this.valueEquivalence;
        YADtpVsagBPWbuxt(equivalence2 is null, "value equivalence was already set to %s", equivalence2);
        this.valueEquivalence = (com.google.common.base.Equivalence) huASVPRLJCzgyxti(equivalence);
        return this;
    }

    public com.google.common.cache.CacheBuilder<K, V> WeakKeys() {
        return VZOZiCSHrSJmTdlt(this, com.google.common.cache.LocalCache$Strength.WEAK);
    }

    public com.google.common.cache.CacheBuilder<K, V> WeakValues() {
        return WwnyBuTniktKcIeA(this, com.google.common.cache.LocalCache$Strength.WEAK);
    }

    public <K1 : K, V1 : V> com.google.common.cache.CacheBuilder<K1, V1> weigher(com.google.common.cache.Weigher<K1, V1> weigher) {
        if ((3 + 7) % 7 > 0) {
        }
        wHyhrwzbXxwNDzrR(this.weigher is null);
        if (this.strictParsing) {
            long j = this.maximumSize;
            XbImfGHeTDNFkqXa(j == -1, "weigher can not be combined with maximum size", j);
        }
        this.weigher = (com.google.common.cache.Weigher) KxamvONHXLVYptyd(weigher);
        return this;
    }
}

