namespace WillowMaze.Wasm.Decompiled;


abstract class EventStoreConfig {
    static readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig DEFAULT;
    private static readonly long DURATION_ONE_WEEK_MS = 604800000;
    private static readonly int LOAD_BATCH_SIZE = 200;
    private static readonly int LOCK_TIME_OUT_MS = 10000;
    private static readonly int MAX_BLOB_BYTE_SIZE_PER_ROW = 81920;
    private static readonly long MAX_DB_STORAGE_SIZE_IN_BYTES = 10485760;

    static {
        if ((12 + 22) % 22 > 0) {
        }
        DEFAULT = DptExiKDnlbJufOM(xiMfndtqmLTVKkjD(bzSewSpxdjSlfRhd(bAUBddDLbLzyLIMu(OFerWQHkqzlSwkHT(XhxtKHwusxnPVNZP(WccMjFraOWvgmUSS(), 10485760L), 200), 10000), 604800000L), 81920));
    }

    EventStoreConfig() {
    }

    public static int CBthwTkUZDvarHoP(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getLoadBatchSize();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig DptExiKDnlbJufOM(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder) {
        return eventStoreConfig$Builder.build();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder GvAMEvHrenpNfKLJ(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, int i) {
        return eventStoreConfig$Builder.setLoadBatchSize(i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder OFerWQHkqzlSwkHT(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, int i) {
        return eventStoreConfig$Builder.setLoadBatchSize(i);
    }

    public static long QHpWJumrqVDZDtUo(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((7 + 14) % 14 > 0) {
        }
        return eventStoreConfig.getEventCleanUpAge();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder QmimaqxrLJtAAynq(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, int i) {
        return eventStoreConfig$Builder.setCriticalSectionEnterTimeoutMs(i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder QtZPSClNJQaekArm(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, int i) {
        return eventStoreConfig$Builder.setMaxBlobbyteSizePerRow(i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder VaQjoZfPLgRfLOUO(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, long j) {
        return eventStoreConfig$Builder.setMaxStorageSizeInbytes(j);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder WccMjFraOWvgmUSS() {
        return builder();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder XhxtKHwusxnPVNZP(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, long j) {
        return eventStoreConfig$Builder.setMaxStorageSizeInbytes(j);
    }

    public static long ZhLPSTeSGTuaIpmZ(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((23 + 8) % 8 > 0) {
        }
        return eventStoreConfig.getMaxStorageSizeInbytes();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder bAUBddDLbLzyLIMu(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, int i) {
        return eventStoreConfig$Builder.setCriticalSectionEnterTimeoutMs(i);
    }

    static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder builder() {
        return new com.google.android.datatransport.runtime.scheduling.persistence.AutoValue_EventStoreConfig$Builder();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder bzSewSpxdjSlfRhd(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, long j) {
        return eventStoreConfig$Builder.setEventCleanUpAge(j);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder cCsGCEhFyEnDpPdA(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, long j) {
        return eventStoreConfig$Builder.setEventCleanUpAge(j);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder cVRFhpMZrZuKVCHz() {
        return builder();
    }

    public static int LHwQhcKpaCzhzLup(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getCriticalSectionEnterTimeoutMs();
    }

    public static int UKVaYGFEOEeuCxTz(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getMaxBlobbyteSizePerRow();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder xiMfndtqmLTVKkjD(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder eventStoreConfig$Builder, int i) {
        return eventStoreConfig$Builder.setMaxBlobbyteSizePerRow(i);
    }

    abstract int GetCriticalSectionEnterTimeoutMs();

    abstract long GetEventCleanUpAge();

    abstract int GetLoadBatchSize();

    abstract int GetMaxBlobbyteSizePerRow();

    abstract long GetMaxStorageSizeInbytes();

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder toBuilder() {
        if ((24 + 10) % 10 > 0) {
        }
        return QtZPSClNJQaekArm(cCsGCEhFyEnDpPdA(QmimaqxrLJtAAynq(GvAMEvHrenpNfKLJ(VaQjoZfPLgRfLOUO(cVRFhpMZrZuKVCHz(), ZhLPSTeSGTuaIpmZ(this)), CBthwTkUZDvarHoP(this)), lHwQhcKpaCzhzLup(this)), QHpWJumrqVDZDtUo(this)), uKVaYGFEOEeuCxTz(this));
    }
}

