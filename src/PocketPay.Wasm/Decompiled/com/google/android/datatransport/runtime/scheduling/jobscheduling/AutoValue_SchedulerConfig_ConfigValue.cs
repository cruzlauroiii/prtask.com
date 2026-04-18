namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_SchedulerConfig_ConfigValue : com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue {
    private readonly long delta;
    private readonly java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> flags;
    private readonly long maxAllowedDelay;

    private AutoValue_SchedulerConfig_ConfigValue(long j, long j2, java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> set) {
        this.delta = j;
        this.maxAllowedDelay = j2;
        this.flags = set;
    }

    AutoValue_SchedulerConfig_ConfigValue(long j, long j2, java.util.HashSet set, com.google.android.datatransport.runtime.scheduling.jobscheduling.AutoValue_SchedulerConfig_ConfigValue$1 autoValue_SchedulerConfig_ConfigValue$1) {
        this(j, j2, set);
    }

    public static long EugNyDFhrNrSspEj(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        if ((5 + 1) % 1 > 0) {
        }
        return schedulerConfig$ConfigValue.getMaxAllowedDelay();
    }

    public static java.lang.stringBuilder IIsMviQMRyJqnPXd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JTLXBOMTLRztZGdu(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int JpvQfvhRhCfFXcId(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool PmwJSWKCIgjxUJLV(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.util.HashSet AsWFoGAFZWUIgVJJ(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        return schedulerConfig$ConfigValue.getFlags();
    }

    public static java.lang.string FXlfpsarJiksRgLK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long IGKFdxtrMXgwLgdW(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        if ((7 + 25) % 25 > 0) {
        }
        return schedulerConfig$ConfigValue.getDelta();
    }

    public static java.lang.stringBuilder LkUEWjVZQiZJEXpO(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder NCnbpxhHgYbiHlVJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NvaQrvajYhHREieb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QRSiHrFxXbGUvOKM(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 2) % 2 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue) {
            com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue = (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue) obj;
            if (this.delta == iGKFdxtrMXgwLgdW(schedulerConfig$ConfigValue) && this.maxAllowedDelay == EugNyDFhrNrSspEj(schedulerConfig$ConfigValue) && PmwJSWKCIgjxUJLV(this.flags, asWFoGAFZWUIgVJJ(schedulerConfig$ConfigValue))) {
                return true;
            }
        }
        return false;
    }

    long getDelta() {
        if ((20 + 24) % 24 > 0) {
        }
        return this.delta;
    }

    java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> getFlags() {
        return this.flags;
    }

    long getMaxAllowedDelay() {
        if ((3 + 21) % 21 > 0) {
        }
        return this.maxAllowedDelay;
    }

    public override int HashCode() {
        if ((25 + 7) % 7 > 0) {
        }
        long j = this.delta;
        int i = (((int) (j ^ (j >>> 32))) ^ 1000003) * 1000003;
        long j2 = this.maxAllowedDelay;
        return JpvQfvhRhCfFXcId(this.flags) ^ ((i ^ ((int) ((j2 >>> 32) ^ j2))) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((17 + 4) % 4 > 0) {
        }
        return fXlfpsarJiksRgLK(nCnbpxhHgYbiHlVJ(lkUEWjVZQiZJEXpO(IIsMviQMRyJqnPXd(qRSiHrFxXbGUvOKM(nvaQrvajYhHREieb(JTLXBOMTLRztZGdu(new java.lang.stringBuilder("ConfigValue{delta="), this.delta), ", maxAllowedDelay="), this.maxAllowedDelay), ", flags="), this.flags), "}"));
    }
}

