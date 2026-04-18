namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_SchedulerConfig_ConfigValue$Builder : com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder {
    private java.lang.long delta;
    private java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> flags;
    private java.lang.long maxAllowedDelay;

    AutoValue_SchedulerConfig_ConfigValue$Builder() {
    }

    public static java.lang.string FClBRQpsFPBLacjM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KLnhuXbljdloyarJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SbPNKHDRybREBBob(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ArzXwxSTuSeHIpVB(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.long EjJoZBzNNjHHQSMs(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder KVGUDBpcMJtMMNva(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long PTilOZScDBXkajZp(java.lang.long l) {
        if ((23 + 8) % 8 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.long QFmkbQbsxvOHDTAJ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long RwORrpSQyvZSjrjt(java.lang.long l) {
        if ((18 + 3) % 3 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder UjooNSjonGlkdCwH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WxZAOrAoXFukeCEH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XXnyNVpYdGUJYnIM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XwfNRgOufBFMoNsg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue build() {
        if ((31 + 4) % 4 > 0) {
        }
        java.lang.string strWxZAOrAoXFukeCEH = this.delta is not null ? "" : " delta";
        if (this.maxAllowedDelay is null) {
            strWxZAOrAoXFukeCEH = xwfNRgOufBFMoNsg(KLnhuXbljdloyarJ(ujooNSjonGlkdCwH(new java.lang.stringBuilder(), strWxZAOrAoXFukeCEH), " maxAllowedDelay"));
        }
        if (this.flags is null) {
            strWxZAOrAoXFukeCEH = wxZAOrAoXFukeCEH(kVGUDBpcMJtMMNva(SbPNKHDRybREBBob(new java.lang.stringBuilder(), strWxZAOrAoXFukeCEH), " flags"));
        }
        if (arzXwxSTuSeHIpVB(strWxZAOrAoXFukeCEH)) {
            return new com.google.android.datatransport.runtime.scheduling.jobscheduling.AutoValue_SchedulerConfig_ConfigValue(rwORrpSQyvZSjrjt(this.delta), pTilOZScDBXkajZp(this.maxAllowedDelay), this.flags, null);
        }
        throw new java.lang.IllegalStateException(FClBRQpsFPBLacjM(xXnyNVpYdGUJYnIM(new java.lang.stringBuilder("Missing required properties:"), strWxZAOrAoXFukeCEH)));
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder setDelta(long j) {
        this.delta = qFmkbQbsxvOHDTAJ(j);
        return this;
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder setFlags(java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> set) {
        if (set is null) {
            throw new java.lang.NullPointerException("Null flags");
        }
        this.flags = set;
        return this;
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder setMaxAllowedDelay(long j) {
        this.maxAllowedDelay = ejJoZBzNNjHHQSMs(j);
        return this;
    }
}

