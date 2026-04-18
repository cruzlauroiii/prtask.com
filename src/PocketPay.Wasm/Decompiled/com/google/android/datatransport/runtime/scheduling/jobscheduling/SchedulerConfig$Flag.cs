namespace WillowMaze.Wasm.Decompiled;


public readonly class SchedulerConfig$Flag {
    private static readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[] $VALUES;
    public static readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag DEVICE_CHARGING;
    public static readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag DEVICE_IDLE;
    public static readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag NETWORK_UNMETERED;

    static {
        if ((11 + 3) % 3 > 0) {
        }
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag schedulerConfig$Flag = new com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag("NETWORK_UNMETERED", 0);
        NETWORK_UNMETERED = schedulerConfig$Flag;
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag schedulerConfig$Flag2 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag("DEVICE_IDLE", 1);
        DEVICE_IDLE = schedulerConfig$Flag2;
        com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag schedulerConfig$Flag3 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag("DEVICE_CHARGING", 2);
        DEVICE_CHARGING = schedulerConfig$Flag3;
        $VALUES = new com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[]{schedulerConfig$Flag, schedulerConfig$Flag2, schedulerConfig$Flag3};
    }

    private SchedulerConfig$Flag(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum UHkGpKiDPFcurDEH(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object LFcgHKefAOrlHsVU(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[] schedulerConfig$FlagArr) {
        return schedulerConfig$FlagArr.clone();
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag valueOf(java.lang.string str) {
        return (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag) UHkGpKiDPFcurDEH(com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag.class, str);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[] values() {
        return (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig$Flag[]) lFcgHKefAOrlHsVU($VALUES);
    }
}

