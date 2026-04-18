namespace WillowMaze.Wasm.Decompiled;


@com.google.android.datatransport.runtime.dagger.Module
public abstract class SchedulingConfigModule {
    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig SrXyylPMEKYkAIoZ(com.google.android.datatransport.runtime.time.Clock clock) {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig.getDefault(clock);
    }

    @com.google.android.datatransport.runtime.dagger.Provides
    static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig Config(com.google.android.datatransport.runtime.time.Clock clock) {
        return SrXyylPMEKYkAIoZ(clock);
    }
}

