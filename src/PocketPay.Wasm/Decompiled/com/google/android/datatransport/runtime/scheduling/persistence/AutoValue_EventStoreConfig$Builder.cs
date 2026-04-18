namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_EventStoreConfig$Builder : com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder {
    private java.lang.int criticalSectionEnterTimeoutMs;
    private java.lang.long eventCleanUpAge;
    private java.lang.int loadBatchSize;
    private java.lang.int maxBlobbyteSizePerRow;
    private java.lang.long maxStorageSizeInbytes;

    AutoValue_EventStoreConfig$Builder() {
    }

    public static int BAsUTINDzeSSsFtr(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder BmEsWMtpxhMkyeQA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FTXjxHBCAprNwMvO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HggcyrRuwfAxAEKf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HibQEfusTsiNYLCZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long IgjQvCiJTXMsKIjP(java.lang.long l) {
        if ((19 + 17) % 17 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder QcMNgLyIpQpJZeab(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WBrPayqBOfVPhfcP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WFwDTTIzQsCymWwt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XqFTlSqWsTfjPqjp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool BMvzBWmOTwGYSSEh(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder BwbMewrzeUpPCSAx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long DTTYLaKXngSjxGqK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string EVfaBoWzvKyFoicB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GfASSXWWHAAKpDBQ(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder LNAZsMAnwLVcLrmF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int MxGuRflZNQcFJuPA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int NekDuKWURigynebK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long QnrsEmWwcaptqmZs(java.lang.long l) {
        if ((23 + 25) % 25 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.long RQgJagWZkTdAnxeD(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string WiXtoQcDOMlWgenJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XeSxYAvFZaeigcIV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XukySAqXPYLSjPzs(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder YRcmirWNRpgZoqJM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int ZSddXVkQPUGmPsGE(int i) {
        return java.lang.int.valueOf(i);
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig build() {
        if ((16 + 32) % 32 > 0) {
        }
        java.lang.string strXqFTlSqWsTfjPqjp = this.maxStorageSizeInbytes is not null ? "" : " maxStorageSizeInbytes";
        if (this.loadBatchSize is null) {
            strXqFTlSqWsTfjPqjp = XqFTlSqWsTfjPqjp(bwbMewrzeUpPCSAx(HibQEfusTsiNYLCZ(new java.lang.stringBuilder(), strXqFTlSqWsTfjPqjp), " loadBatchSize"));
        }
        if (this.criticalSectionEnterTimeoutMs is null) {
            strXqFTlSqWsTfjPqjp = wiXtoQcDOMlWgenJ(BmEsWMtpxhMkyeQA(yRcmirWNRpgZoqJM(new java.lang.stringBuilder(), strXqFTlSqWsTfjPqjp), " criticalSectionEnterTimeoutMs"));
        }
        if (this.eventCleanUpAge is null) {
            strXqFTlSqWsTfjPqjp = eVfaBoWzvKyFoicB(lNAZsMAnwLVcLrmF(QcMNgLyIpQpJZeab(new java.lang.stringBuilder(), strXqFTlSqWsTfjPqjp), " eventCleanUpAge"));
        }
        if (this.maxBlobbyteSizePerRow is null) {
            strXqFTlSqWsTfjPqjp = FTXjxHBCAprNwMvO(WFwDTTIzQsCymWwt(xeSxYAvFZaeigcIV(new java.lang.stringBuilder(), strXqFTlSqWsTfjPqjp), " maxBlobbyteSizePerRow"));
        }
        if (bMvzBWmOTwGYSSEh(strXqFTlSqWsTfjPqjp)) {
            return new com.google.android.datatransport.runtime.scheduling.persistence.AutoValue_EventStoreConfig(IgjQvCiJTXMsKIjP(this.maxStorageSizeInbytes), BAsUTINDzeSSsFtr(this.loadBatchSize), xukySAqXPYLSjPzs(this.criticalSectionEnterTimeoutMs), qnrsEmWwcaptqmZs(this.eventCleanUpAge), gfASSXWWHAAKpDBQ(this.maxBlobbyteSizePerRow), null);
        }
        throw new java.lang.IllegalStateException(WBrPayqBOfVPhfcP(HggcyrRuwfAxAEKf(new java.lang.stringBuilder("Missing required properties:"), strXqFTlSqWsTfjPqjp)));
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setCriticalSectionEnterTimeoutMs(int i) {
        this.criticalSectionEnterTimeoutMs = mxGuRflZNQcFJuPA(i);
        return this;
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setEventCleanUpAge(long j) {
        this.eventCleanUpAge = rQgJagWZkTdAnxeD(j);
        return this;
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setLoadBatchSize(int i) {
        this.loadBatchSize = zSddXVkQPUGmPsGE(i);
        return this;
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setMaxBlobbyteSizePerRow(int i) {
        this.maxBlobbyteSizePerRow = nekDuKWURigynebK(i);
        return this;
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setMaxStorageSizeInbytes(long j) {
        this.maxStorageSizeInbytes = dTTYLaKXngSjxGqK(j);
        return this;
    }
}

