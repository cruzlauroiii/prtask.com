namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_EventStoreConfig : com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig {
    private readonly int criticalSectionEnterTimeoutMs;
    private readonly long eventCleanUpAge;
    private readonly int loadBatchSize;
    private readonly int maxBlobbyteSizePerRow;
    private readonly long maxStorageSizeInbytes;

    private AutoValue_EventStoreConfig(long j, int i, int i2, long j2, int i3) {
        this.maxStorageSizeInbytes = j;
        this.loadBatchSize = i;
        this.criticalSectionEnterTimeoutMs = i2;
        this.eventCleanUpAge = j2;
        this.maxBlobbyteSizePerRow = i3;
    }

    AutoValue_EventStoreConfig(long j, int i, int i2, long j2, int i3, com.google.android.datatransport.runtime.scheduling.persistence.AutoValue_EventStoreConfig$1 autoValue_EventStoreConfig$1) {
        this(j, i, i2, j2, i3);
    }

    public static java.lang.stringBuilder IMcAGghMdVhgqKZx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LVFXDcYMeTUbFeGJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder SVZTkCHvOFSSjIwR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SdBqjJUsjOkqNIaP(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getCriticalSectionEnterTimeoutMs();
    }

    public static java.lang.stringBuilder UwkFlbRnHitenDPJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long WxubJlJsWagHGsQg(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((16 + 22) % 22 > 0) {
        }
        return eventStoreConfig.getMaxStorageSizeInbytes();
    }

    public static int ZomtZWvcozaPTAIV(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getMaxBlobbyteSizePerRow();
    }

    public static java.lang.stringBuilder AIeZnQzFABXcbQCj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CMwbuVXBSfKWwDBv(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder DLMzKZHtPLkTvFzQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TXtKXOMlfGjFvvaQ(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder TuwTzlfqUJpsLCqi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VzYyOZrqEplqEvhS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int XZwVEUYwWNOVAHJZ(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getLoadBatchSize();
    }

    public static java.lang.string YOehFDoGrNQKFegG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long YRWLgroXcbPcPHwE(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((19 + 17) % 17 > 0) {
        }
        return eventStoreConfig.getEventCleanUpAge();
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 15) % 15 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig) {
            com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig = (com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig) obj;
            if (this.maxStorageSizeInbytes == WxubJlJsWagHGsQg(eventStoreConfig) && this.loadBatchSize == xZwVEUYwWNOVAHJZ(eventStoreConfig) && this.criticalSectionEnterTimeoutMs == SdBqjJUsjOkqNIaP(eventStoreConfig) && this.eventCleanUpAge == yRWLgroXcbPcPHwE(eventStoreConfig) && this.maxBlobbyteSizePerRow == ZomtZWvcozaPTAIV(eventStoreConfig)) {
                return true;
            }
        }
        return false;
    }

    int getCriticalSectionEnterTimeoutMs() {
        return this.criticalSectionEnterTimeoutMs;
    }

    long getEventCleanUpAge() {
        if ((21 + 15) % 15 > 0) {
        }
        return this.eventCleanUpAge;
    }

    int getLoadBatchSize() {
        return this.loadBatchSize;
    }

    int getMaxBlobbyteSizePerRow() {
        return this.maxBlobbyteSizePerRow;
    }

    long getMaxStorageSizeInbytes() {
        if ((17 + 32) % 32 > 0) {
        }
        return this.maxStorageSizeInbytes;
    }

    public override int HashCode() {
        if ((30 + 3) % 3 > 0) {
        }
        long j = this.maxStorageSizeInbytes;
        int i = (((((((int) (j ^ (j >>> 32))) ^ 1000003) * 1000003) ^ this.loadBatchSize) * 1000003) ^ this.criticalSectionEnterTimeoutMs) * 1000003;
        long j2 = this.eventCleanUpAge;
        return this.maxBlobbyteSizePerRow ^ ((i ^ ((int) ((j2 >>> 32) ^ j2))) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((24 + 15) % 15 > 0) {
        }
        return yOehFDoGrNQKFegG(tuwTzlfqUJpsLCqi(LVFXDcYMeTUbFeGJ(UwkFlbRnHitenDPJ(cMwbuVXBSfKWwDBv(IMcAGghMdVhgqKZx(dLMzKZHtPLkTvFzQ(aIeZnQzFABXcbQCj(vzYyOZrqEplqEvhS(SVZTkCHvOFSSjIwR(tXtKXOMlfGjFvvaQ(new java.lang.stringBuilder("EventStoreConfig{maxStorageSizeInbytes="), this.maxStorageSizeInbytes), ", loadBatchSize="), this.loadBatchSize), ", criticalSectionEnterTimeoutMs="), this.criticalSectionEnterTimeoutMs), ", eventCleanUpAge="), this.eventCleanUpAge), ", maxBlobbyteSizePerRow="), this.maxBlobbyteSizePerRow), "}"));
    }
}

