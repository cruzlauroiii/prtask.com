namespace WillowMaze.Wasm.Decompiled;


@com.google.android.datatransport.runtime.dagger.Module
public abstract class SchedulingModule {
    @com.google.android.datatransport.runtime.dagger.Provides
    static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler WorkScheduler(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.runtime.time.Clock clock) {
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.JobInfoScheduler(context, eventStore, schedulerConfig);
    }

    @com.google.android.datatransport.runtime.dagger.Binds
    abstract com.google.android.datatransport.runtime.scheduling.Scheduler Scheduler(com.google.android.datatransport.runtime.scheduling.DefaultScheduler defaultScheduler);
}

