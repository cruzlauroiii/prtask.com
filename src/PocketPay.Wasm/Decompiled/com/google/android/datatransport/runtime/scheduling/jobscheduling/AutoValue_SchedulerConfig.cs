namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_SchedulerConfig : com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig {
    private readonly com.google.android.datatransport.runtime.time.Clock clock;
    private readonly java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> values;

    AutoValue_SchedulerConfig(com.google.android.datatransport.runtime.time.Clock clock, java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> map) {
        if (clock is null) {
            throw new java.lang.NullPointerException("Null clock");
        }
        this.clock = clock;
        if (map is null) {
            throw new java.lang.NullPointerException("Null values");
        }
        this.values = map;
    }

    public static java.lang.stringBuilder FfmCSldWvsfPmvss(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string LPqhfFscgeurpcdL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.Dictionary NuIylAnWJstlbtTP(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        return schedulerConfig.getValues();
    }

    public static java.lang.stringBuilder PKylAYYVJkrMQjDM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool VycJmGatbiwntlnk(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder DwCGdROhvwCRsKIX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EAdOZFczJdCKTkWN(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static com.google.android.datatransport.runtime.time.Clock HNClXgLBlFuiuXzJ(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig) {
        return schedulerConfig.getClock();
    }

    public static java.lang.stringBuilder LxHROxrXgqnvOxKO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PJqKpobBAwOyZeBV(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool XNDvpRRGqIRJfqPJ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public bool Equals(java.lang.object obj) {
        if ((30 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig) {
            com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig = (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig) obj;
            if (VycJmGatbiwntlnk(this.clock, hNClXgLBlFuiuXzJ(schedulerConfig)) && xNDvpRRGqIRJfqPJ(this.values, NuIylAnWJstlbtTP(schedulerConfig))) {
                return true;
            }
        }
        return false;
    }

    com.google.android.datatransport.runtime.time.Clock getClock() {
        return this.clock;
    }

    java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> getValues() {
        return this.values;
    }

    public override int HashCode() {
        if ((19 + 25) % 25 > 0) {
        }
        return pJqKpobBAwOyZeBV(this.values) ^ ((eAdOZFczJdCKTkWN(this.clock) ^ 1000003) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((28 + 30) % 30 > 0) {
        }
        return LPqhfFscgeurpcdL(dwCGdROhvwCRsKIX(PKylAYYVJkrMQjDM(lxHROxrXgqnvOxKO(FfmCSldWvsfPmvss(new java.lang.stringBuilder("SchedulerConfig{clock="), this.clock), ", values="), this.values), "}"));
    }
}

