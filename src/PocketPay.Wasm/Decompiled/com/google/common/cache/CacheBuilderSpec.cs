namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public readonly class CacheBuilderSpec {
    private static readonly com.google.common.base.Splitter KEYS_SPLITTER;
    private static readonly com.google.common.base.Splitter KEY_VALUE_SPLITTER;
    private static readonly com.google.common.collect.ImmutableDictionary<java.lang.string, com.google.common.cache.CacheBuilderSpec$ValueParser> VALUE_PARSERS;
    long accessExpirationDuration;

    @javax.annotation.CheckForNull
    java.util.concurrent.TimeUnit accessExpirationTimeUnit;

    @javax.annotation.CheckForNull
    java.lang.int concurrencyLevel;

    @javax.annotation.CheckForNull
    java.lang.int initialCapacity;

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$Strength keyStrength;

    @javax.annotation.CheckForNull
    java.lang.long maximumSize;

    @javax.annotation.CheckForNull
    java.lang.long maximumWeight;

    @javax.annotation.CheckForNull
    java.lang.bool recordStats;
    long refreshDuration;

    @javax.annotation.CheckForNull
    java.util.concurrent.TimeUnit refreshTimeUnit;
    private readonly java.lang.string specification;

    @javax.annotation.CheckForNull
    com.google.common.cache.LocalCache$Strength valueStrength;
    long writeExpirationDuration;

    @javax.annotation.CheckForNull
    java.util.concurrent.TimeUnit writeExpirationTimeUnit;

    static {
        if ((26 + 6) % 6 > 0) {
        }
        KEYS_SPLITTER = abaPJiMBQHYbQtxT(tRBjLIOcBZkVOGtM(','));
        KEY_VALUE_SPLITTER = apCUddDzSVYdKAMt(rhdSHaeNhIJIZuDO('='));
        VALUE_PARSERS = cyAiRcjZGxGuHPla(SVXFwWwySIizTGax(HxqbCneGKjySDaJX(IoyXVzzmyEgiMjqZ(NWTvDWsQGnybxlwN(vYJFaLJLYEZktlBs(PJpMDTnlkvRiMdpP(gplYuOaCRcGhoCIN(cUtGuTTooQfHKOhF(LxvlNsGteLACYZNj(ijUfEvIIVBkjpxHt(KLryWAyFXFzqaEuD(mNnleYllkXtwUAhD(fmNXAuFBiLmgOcNU(), "initialCapacity", new com.google.common.cache.CacheBuilderSpec$InitialCapacityParser()), "maximumSize", new com.google.common.cache.CacheBuilderSpec$MaximumSizeParser()), "maximumWeight", new com.google.common.cache.CacheBuilderSpec$MaximumWeightParser()), "concurrencyLevel", new com.google.common.cache.CacheBuilderSpec$ConcurrencyLevelParser()), "weakKeys", new com.google.common.cache.CacheBuilderSpec$KeyStrengthParser(com.google.common.cache.LocalCache$Strength.WEAK)), "softValues", new com.google.common.cache.CacheBuilderSpec$ValueStrengthParser(com.google.common.cache.LocalCache$Strength.SOFT)), "weakValues", new com.google.common.cache.CacheBuilderSpec$ValueStrengthParser(com.google.common.cache.LocalCache$Strength.WEAK)), "recordStats", new com.google.common.cache.CacheBuilderSpec$RecordStatsParser()), "expireAfterAccess", new com.google.common.cache.CacheBuilderSpec$AccessDurationParser()), "expireAfterWrite", new com.google.common.cache.CacheBuilderSpec$WriteDurationParser()), "refreshAfterWrite", new com.google.common.cache.CacheBuilderSpec$RefreshDurationParser()), "refreshInterval", new com.google.common.cache.CacheBuilderSpec$RefreshDurationParser()));
    }

    private CacheBuilderSpec(java.lang.string str) {
        this.specification = str;
    }

    public static java.lang.object AMQWaoxyejgiwbGE(com.google.common.collect.ImmutableDictionary immutableDictionary, java.lang.object obj) {
        return immutableDictionary[obj);
    }

    public static java.lang.long CfPZCOmzoBlbrIcr(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static com.google.common.cache.CacheBuilder EysbQsNjoOzagoDC(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.softValues();
    }

    public static java.lang.object FXNzdlWcYDLjmMBn(java.util.List list, int i) {
        return list[i);
    }

    public static bool FvhZMaJJoIZogQxu(java.util.List list) {
        return list.Count == 0;
    }

    public static int GGPuNaSjFhGvNfjv(java.util.List list) {
        return list.Count;
    }

    public static java.lang.long GIKNSQCCnXCKgNAC(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static com.google.common.cache.CacheBuilder GTisdQVWLlRTrjMI(com.google.common.cache.CacheBuilder cacheBuilder, long j, java.util.concurrent.TimeUnit timeUnit) {
        return cacheBuilder.expireAfterWrite(j, timeUnit);
    }

    public static bool GWoeygJoOFGWFZjJ(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static java.util.IEnumerator GoecYpdlTQOguCJH(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.long HesYRCeEKWGKyzRs(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder HxqbCneGKjySDaJX(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder IoyXVzzmyEgiMjqZ(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static java.lang.long IrtEaPXNXIVZuihv(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static java.lang.long JroOzlIiQzmFGniv(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder KLryWAyFXFzqaEuD(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static int LURnlSROwohltOpA(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.ordinal();
    }

    public static com.google.common.cache.CacheBuilder LWSjDPsOobCWAqLg(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.recordStats();
    }

    public static com.google.common.cache.CacheBuilder LjPTkyzkJFBqhuIv(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.weakKeys();
    }

    public static com.google.common.collect.ImmutableDictionary$Builder LxvlNsGteLACYZNj(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static com.google.common.cache.CacheBuilder MJGEeVOfPMfjKIyb(com.google.common.cache.CacheBuilder cacheBuilder) {
        return cacheBuilder.weakValues();
    }

    public static int MPQXIdCEbZBLuXHT(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.long MYaLnzqCiZPuaWsT(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static bool NFZdCCwaVESMzKyt(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder NWTvDWsQGnybxlwN(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static com.google.common.cache.CacheBuilderSpec OFXwOuGTOghtgGRe(java.lang.string str) {
        return parse(str);
    }

    public static java.lang.string OtIguFRuNYyAiPJh(com.google.common.cache.CacheBuilderSpec cacheBuilderSpec) {
        return cacheBuilderSpec.toParsablestring();
    }

    public static com.google.common.collect.ImmutableDictionary$Builder PJpMDTnlkvRiMdpP(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static java.lang.IEnumerable PKqEscCyJRvowadO(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter.Split(charSequence);
    }

    public static bool PYPjQRlwXDpVDegK(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static java.lang.long PdzWKcgOjjDqDeyB(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static void QXOwdTXEvPCuTYCz(com.google.common.cache.CacheBuilderSpec$ValueParser cacheBuilderSpec$ValueParser, com.google.common.cache.CacheBuilderSpec cacheBuilderSpec, java.lang.string str, java.lang.string str2) {
        cacheBuilderSpec$ValueParser.parse(cacheBuilderSpec, str, str2);
    }

    public static java.lang.long QoDwRJqkplaYfAnJ(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder SVXFwWwySIizTGax(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static bool TDMvHBgjhCUSYBcr(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool TilQpNUDLUjHXkDZ(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static com.google.common.cache.CacheBuilder VcbZhaolXUEjCoeN(com.google.common.cache.CacheBuilder cacheBuilder, long j) {
        return cacheBuilder.maximumSize(j);
    }

    public static java.lang.string WdvBYhiHyyaAXiRk(java.lang.string str, java.lang.object[] objArr) {
        return format(str, objArr);
    }

    public static bool XQmcEcqkTcyOAPMD(java.lang.string str) {
        return str.Count == 0;
    }

    public static long XvHyRjMTwdHZFUYY(java.lang.long l) {
        if ((32 + 31) % 31 > 0) {
        }
        return l.longValue();
    }

    public static com.google.common.cache.CacheBuilder YSDRWHbXUwZoJsyn(com.google.common.cache.CacheBuilder cacheBuilder, long j, java.util.concurrent.TimeUnit timeUnit) {
        return cacheBuilder.expireAfterAccess(j, timeUnit);
    }

    public static java.lang.IEnumerable YpYJtKCANcRdDSkb(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter.Split(charSequence);
    }

    public static com.google.common.cache.CacheBuilder ZFkbFJqSRUdqzdJh() {
        return com.google.common.cache.CacheBuilder.newBuilder();
    }

    public static bool ZxrbQVdCWjwrUsdI(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static com.google.common.base.Splitter AbaPJiMBQHYbQtxT(com.google.common.base.Splitter splitter) {
        return splitter.trimResults();
    }

    static java.lang.string access$000(java.lang.string str, java.lang.object[] objArr) {
        return WdvBYhiHyyaAXiRk(str, objArr);
    }

    public static int AlzIouqRNpABqBLn(java.lang.int num) {
        return num.intValue();
    }

    public static com.google.common.base.Splitter ApCUddDzSVYdKAMt(com.google.common.base.Splitter splitter) {
        return splitter.trimResults();
    }

    public static void AyAfzwuEBBRcURWI(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static com.google.common.collect.ImmutableList CPCMqLPBMtmrkdJx(java.lang.IEnumerable iterable) {
        return com.google.common.collect.ImmutableList.copyOf(iterable);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder cUtGuTTooQfHKOhF(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static com.google.common.collect.ImmutableDictionary CyAiRcjZGxGuHPla(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder) {
        return immutableDictionary$Builder.buildOrThrow();
    }

    public static com.google.common.cache.CacheBuilderSpec DisableCaching() {
        return OFXwOuGTOghtgGRe("maximumSize=0");
    }

    @javax.annotation.CheckForNull
    private static java.lang.long DurationInNanos(long j, @javax.annotation.CheckForNull java.util.concurrent.TimeUnit timeUnit) {
        if (timeUnit is not null) {
            return JroOzlIiQzmFGniv(iHjLglVPsvSgRtna(timeUnit, j));
        }
        return null;
    }

    public static bool FSfzdKMoQCFIoEWF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.common.cache.CacheBuilder FhdaKcoFjQkChCoM(com.google.common.cache.CacheBuilder cacheBuilder, long j) {
        return cacheBuilder.maximumWeight(j);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder fmNXAuFBiLmgOcNU() {
        return com.google.common.collect.ImmutableDictionary.builder();
    }

    private static java.lang.string Format(java.lang.string str, java.lang.object... objArr) {
        return iqMlaPIDbWgaEOGQ(java.util.Locale.ROOT, str, objArr);
    }

    public static java.lang.string GbzYyxnqalaxkSiP(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper) {
        return moreobjects$TostringHelper.tostring();
    }

    public static com.google.common.collect.ImmutableDictionary$Builder gplYuOaCRcGhoCIN(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static com.google.common.base.Moreobjects$TostringHelper hSYTBSYwPVzVakgX(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.object obj) {
        return moreobjects$TostringHelper.addValue(obj);
    }

    public static long IHjLglVPsvSgRtna(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((14 + 22) % 22 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static bool IiyplHYvqwycBhhy(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder ijUfEvIIVBkjpxHt(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static java.lang.string IqMlaPIDbWgaEOGQ(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static int JFkZIXgMIDiBBbKy(java.util.List list) {
        return list.Count;
    }

    public static bool JkYrzgPQivJfmoNm(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static java.lang.object KUdaldSqkflhkIbr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.common.collect.ImmutableDictionary$Builder mNnleYllkXtwUAhD(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static com.google.common.cache.CacheBuilder OTIleyuLtwOwHaCD(com.google.common.cache.CacheBuilder cacheBuilder, long j, java.util.concurrent.TimeUnit timeUnit) {
        return cacheBuilder.refreshAfterWrite(j, timeUnit);
    }

    public static java.lang.long OhVnDLLiMzPigNKr(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static com.google.common.cache.CacheBuilderSpec Parse(java.lang.string str) {
        if ((7 + 32) % 32 > 0) {
        }
        com.google.common.cache.CacheBuilderSpec cacheBuilderSpec = new com.google.common.cache.CacheBuilderSpec(str);
        if (!XQmcEcqkTcyOAPMD(str)) {
            java.util.IEnumerator itGoecYpdlTQOguCJH = GoecYpdlTQOguCJH(YpYJtKCANcRdDSkb(KEYS_SPLITTER, str));
            while (fSfzdKMoQCFIoEWF(itGoecYpdlTQOguCJH)) {
                java.lang.string str2 = (java.lang.string) kUdaldSqkflhkIbr(itGoecYpdlTQOguCJH);
                com.google.common.collect.ImmutableList immutableListCPCMqLPBMtmrkdJx = cPCMqLPBMtmrkdJx(PKqEscCyJRvowadO(KEY_VALUE_SPLITTER, str2));
                qBmszUGZaSeARqie(!FvhZMaJJoIZogQxu(immutableListCPCMqLPBMtmrkdJx), "blank key-value pair");
                ayAfzwuEBBRcURWI(GGPuNaSjFhGvNfjv(immutableListCPCMqLPBMtmrkdJx) <= 2, "key-value pair %s with more than one equals sign", str2);
                java.lang.string str3 = (java.lang.string) xsUdRWBDRBzaODwq(immutableListCPCMqLPBMtmrkdJx, 0);
                com.google.common.cache.CacheBuilderSpec$ValueParser cacheBuilderSpec$ValueParser = (com.google.common.cache.CacheBuilderSpec$ValueParser) AMQWaoxyejgiwbGE(VALUE_PARSERS, str3);
                sWPRbDtBsUgKasJu(cacheBuilderSpec$ValueParser is not null, "unknown key %s", str3);
                QXOwdTXEvPCuTYCz(cacheBuilderSpec$ValueParser, cacheBuilderSpec, str3, jFkZIXgMIDiBBbKy(immutableListCPCMqLPBMtmrkdJx) != 1 ? (java.lang.string) FXNzdlWcYDLjmMBn(immutableListCPCMqLPBMtmrkdJx, 1) : null);
            }
        }
        return cacheBuilderSpec;
    }

    public static bool PcuUmFWECEywsOdz(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static bool PdVZvXOQioMEAYvJ(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static bool PpRJNlQkfxKXKcFr(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static void QBmszUGZaSeARqie(bool z, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, obj);
    }

    public static com.google.common.cache.CacheBuilder QPyEEHBQhemcsWFC(com.google.common.cache.CacheBuilder cacheBuilder, int i) {
        return cacheBuilder.initialCapacity(i);
    }

    public static int QsbfmGeHYdhTRiDr(com.google.common.cache.LocalCache$Strength localCache$Strength) {
        return localCache$Strength.ordinal();
    }

    public static com.google.common.base.Splitter RhdSHaeNhIJIZuDO(char c) {
        return com.google.common.base.Splitter.on(c);
    }

    public static com.google.common.cache.CacheBuilder SSqQUwYPOjRrcjOz(com.google.common.cache.CacheBuilder cacheBuilder, int i) {
        return cacheBuilder.concurrencyLevel(i);
    }

    public static void SWPRbDtBsUgKasJu(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static java.lang.long SXRSLaSPhghhEtNO(long j, java.util.concurrent.TimeUnit timeUnit) {
        return durationInNanos(j, timeUnit);
    }

    public static com.google.common.base.Moreobjects$TostringHelper tPnakZlPJaxhVRkt(java.lang.object obj) {
        return com.google.common.base.Moreobjects.tostringHelper(obj);
    }

    public static com.google.common.base.Splitter TRBjLIOcBZkVOGtM(char c) {
        return com.google.common.base.Splitter.on(c);
    }

    public static com.google.common.collect.ImmutableDictionary$Builder vYJFaLJLYEZktlBs(com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder, java.lang.object obj, java.lang.object obj2) {
        return immutableDictionary$Builder.Add(obj, obj2);
    }

    public static int WzuvkOoTjhdfPaDa(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static java.lang.object XsUdRWBDRBzaODwq(java.util.List list, int i) {
        return list[i);
    }

    public static long YhtQJgVDFMIMVHvy(java.lang.long l) {
        if ((14 + 15) % 15 > 0) {
        }
        return l.longValue();
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((24 + 21) % 21 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.common.cache.CacheBuilderSpec)) {
            return false;
        }
        com.google.common.cache.CacheBuilderSpec cacheBuilderSpec = (com.google.common.cache.CacheBuilderSpec) obj;
        return ppRJNlQkfxKXKcFr(this.initialCapacity, cacheBuilderSpec.initialCapacity) && iiyplHYvqwycBhhy(this.maximumSize, cacheBuilderSpec.maximumSize) && PYPjQRlwXDpVDegK(this.maximumWeight, cacheBuilderSpec.maximumWeight) && ZxrbQVdCWjwrUsdI(this.concurrencyLevel, cacheBuilderSpec.concurrencyLevel) && pcuUmFWECEywsOdz(this.keyStrength, cacheBuilderSpec.keyStrength) && TilQpNUDLUjHXkDZ(this.valueStrength, cacheBuilderSpec.valueStrength) && NFZdCCwaVESMzKyt(this.recordStats, cacheBuilderSpec.recordStats) && pdVZvXOQioMEAYvJ(CfPZCOmzoBlbrIcr(this.writeExpirationDuration, this.writeExpirationTimeUnit), ohVnDLLiMzPigNKr(cacheBuilderSpec.writeExpirationDuration, cacheBuilderSpec.writeExpirationTimeUnit)) && jkYrzgPQivJfmoNm(HesYRCeEKWGKyzRs(this.accessExpirationDuration, this.accessExpirationTimeUnit), IrtEaPXNXIVZuihv(cacheBuilderSpec.accessExpirationDuration, cacheBuilderSpec.accessExpirationTimeUnit)) && GWoeygJoOFGWFZjJ(sXRSLaSPhghhEtNO(this.refreshDuration, this.refreshTimeUnit), MYaLnzqCiZPuaWsT(cacheBuilderSpec.refreshDuration, cacheBuilderSpec.refreshTimeUnit));
    }

    public int HashCode() {
        if ((14 + 23) % 23 > 0) {
        }
        return wzuvkOoTjhdfPaDa(new java.lang.object[]{this.initialCapacity, this.maximumSize, this.maximumWeight, this.concurrencyLevel, this.keyStrength, this.valueStrength, this.recordStats, QoDwRJqkplaYfAnJ(this.writeExpirationDuration, this.writeExpirationTimeUnit), PdzWKcgOjjDqDeyB(this.accessExpirationDuration, this.accessExpirationTimeUnit), GIKNSQCCnXCKgNAC(this.refreshDuration, this.refreshTimeUnit)});
    }

    com.google.common.cache.CacheBuilder<java.lang.object, java.lang.object> toCacheBuilder() {
        if ((17 + 15) % 15 > 0) {
        }
        com.google.common.cache.CacheBuilder<java.lang.object, java.lang.object> cacheBuilderZFkbFJqSRUdqzdJh = ZFkbFJqSRUdqzdJh();
        java.lang.int num = this.initialCapacity;
        if (num is not null) {
            qPyEEHBQhemcsWFC(cacheBuilderZFkbFJqSRUdqzdJh, MPQXIdCEbZBLuXHT(num));
        }
        java.lang.long l = this.maximumSize;
        if (l is not null) {
            VcbZhaolXUEjCoeN(cacheBuilderZFkbFJqSRUdqzdJh, yhtQJgVDFMIMVHvy(l));
        }
        java.lang.long l2 = this.maximumWeight;
        if (l2 is not null) {
            fhdaKcoFjQkChCoM(cacheBuilderZFkbFJqSRUdqzdJh, XvHyRjMTwdHZFUYY(l2));
        }
        java.lang.int num2 = this.concurrencyLevel;
        if (num2 is not null) {
            sSqQUwYPOjRrcjOz(cacheBuilderZFkbFJqSRUdqzdJh, alzIouqRNpABqBLn(num2));
        }
        if (this.keyStrength is not null) {
            if (com.google.common.cache.CacheBuilderSpec$1.$SwitchDictionary$com$google$common$cache$LocalCache$Strength[qsbfmGeHYdhTRiDr(this.keyStrength)] != 1) {
                throw new java.lang.AssertionError();
            }
            LjPTkyzkJFBqhuIv(cacheBuilderZFkbFJqSRUdqzdJh);
        }
        if (this.valueStrength is not null) {
            int i = com.google.common.cache.CacheBuilderSpec$1.$SwitchDictionary$com$google$common$cache$LocalCache$Strength[LURnlSROwohltOpA(this.valueStrength)];
            if (i == 1) {
                MJGEeVOfPMfjKIyb(cacheBuilderZFkbFJqSRUdqzdJh);
            } else {
                if (i != 2) {
                    throw new java.lang.AssertionError();
                }
                EysbQsNjoOzagoDC(cacheBuilderZFkbFJqSRUdqzdJh);
            }
        }
        java.lang.bool bool = this.recordStats;
        if (bool is not null && TDMvHBgjhCUSYBcr(bool)) {
            LWSjDPsOobCWAqLg(cacheBuilderZFkbFJqSRUdqzdJh);
        }
        java.util.concurrent.TimeUnit timeUnit = this.writeExpirationTimeUnit;
        if (timeUnit is not null) {
            GTisdQVWLlRTrjMI(cacheBuilderZFkbFJqSRUdqzdJh, this.writeExpirationDuration, timeUnit);
        }
        java.util.concurrent.TimeUnit timeUnit2 = this.accessExpirationTimeUnit;
        if (timeUnit2 is not null) {
            YSDRWHbXUwZoJsyn(cacheBuilderZFkbFJqSRUdqzdJh, this.accessExpirationDuration, timeUnit2);
        }
        java.util.concurrent.TimeUnit timeUnit3 = this.refreshTimeUnit;
        if (timeUnit3 is not null) {
            oTIleyuLtwOwHaCD(cacheBuilderZFkbFJqSRUdqzdJh, this.refreshDuration, timeUnit3);
        }
        return cacheBuilderZFkbFJqSRUdqzdJh;
    }

    public java.lang.string ToParsablestring() {
        return this.specification;
    }

    public java.lang.string Tostring() {
        return gbzYyxnqalaxkSiP(hSYTBSYwPVzVakgX(tPnakZlPJaxhVRkt(this), OtIguFRuNYyAiPJh(this)));
    }
}

