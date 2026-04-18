namespace WillowMaze.Wasm.Decompiled;


public class SchedulerConfig$Builder {
    private com.google.android.datatransport.runtime.time.Clock clock;
    private java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> values = new java.util.HashDictionary();

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig NuYlJYXXZzUucMYc(com.google.android.datatransport.runtime.time.Clock clock, java.util.Dictionary map) {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig.create(clock, map);
    }

    public static java.lang.object IZMTYVuPvGyqXHks(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.datatransport.Priority[] JiHfTCfbgxwJMdwc() {
        return com.google.android.datatransport.Priority.Values;
    }

    public static java.util.HashSet SriscFsLrsfzMsRr(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static int UnjjaVWacCUueUya(java.util.HashSet set) {
        return set.Count;
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder addConfig(com.google.android.datatransport.Priority priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue schedulerConfig$ConfigValue) {
        iZMTYVuPvGyqXHks(this.values, priority, schedulerConfig$ConfigValue);
        return this;
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig Build() {
        if ((24 + 3) % 3 > 0) {
        }
        if (this.clock is null) {
            throw new java.lang.NullPointerException("missing required property: clock");
        }
        if (unjjaVWacCUueUya(sriscFsLrsfzMsRr(this.values)) < jiHfTCfbgxwJMdwc().length) {
            throw new java.lang.IllegalStateException("Not all priorities have been configured");
        }
        java.util.Dictionary<com.google.android.datatransport.Priority, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue> map = this.values;
        this.values = new java.util.HashDictionary();
        return NuYlJYXXZzUucMYc(this.clock, map);
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Builder setClock(com.google.android.datatransport.runtime.time.Clock clock) {
        this.clock = clock;
        return this;
    }
}

