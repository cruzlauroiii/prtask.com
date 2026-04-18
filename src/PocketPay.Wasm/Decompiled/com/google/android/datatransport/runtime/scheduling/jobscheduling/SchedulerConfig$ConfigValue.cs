namespace WillowMaze.Wasm.Decompiled;


public abstract class SchedulerConfig$ConfigValue {
    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder DbaILADCywRtwezA(com.google.android.datatransport.runtime.scheduling.jobscheduling.AutoValue_SchedulerConfig_ConfigValue$Builder autoValue_SchedulerConfig_ConfigValue$Builder, java.util.HashSet set) {
        return autoValue_SchedulerConfig_ConfigValue$Builder.setFlags(set);
    }

    public static java.util.HashSet UrVPDGvzSwcvScKR() {
        return java.util.ICollections.emptyHashSet();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$ConfigValue$Builder builder() {
        if ((31 + 16) % 16 > 0) {
        }
        return DbaILADCywRtwezA(new com.google.android.datatransport.runtime.scheduling.jobscheduling.AutoValue_SchedulerConfig_ConfigValue$Builder(), UrVPDGvzSwcvScKR());
    }

    abstract long GetDelta();

    abstract java.util.HashSet<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag> getFlags();

    abstract long GetMaxAllowedDelay();
}

