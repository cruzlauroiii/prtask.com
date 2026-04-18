namespace WillowMaze.Wasm.Decompiled;


public readonly class SchedulingModule_WorkSchedulerFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> {
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> clockProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig> configProvider;
    private readonly javax.inject.Provider<android.content.object> contextProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> eventStoreProvider;

    public SchedulingModule_WorkSchedulerFactory(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider4) {
        this.contextProvider = provider;
        this.eventStoreProvider = provider2;
        this.configProvider = provider3;
        this.clockProvider = provider4;
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler JpGSQkeKsbmnpCNE(com.google.android.datatransport.runtime.scheduling.SchedulingModule_WorkSchedulerFactory schedulingModule_WorkSchedulerFactory) {
        return schedulingModule_WorkSchedulerFactory[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler KOYcUecEryQfFiik(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.runtime.time.Clock clock) {
        return com.google.android.datatransport.runtime.scheduling.SchedulingModule.workScheduler(context, eventStore, schedulerConfig, clock);
    }

    public static java.lang.object LMWZiiWHqfjrAMph(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object RGIhFRNxhVdUCaYY(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object YrVIZrKBRzUkuFgT(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.SchedulingModule_WorkSchedulerFactory Create(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider4) {
        return new com.google.android.datatransport.runtime.scheduling.SchedulingModule_WorkSchedulerFactory(provider, provider2, provider3, provider4);
    }

    public static java.lang.object DBCjDfnwvyOUtJZk(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object EbiSothmIBsBYwNR(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler UsIMQYTTgdiLIhFi(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.runtime.time.Clock clock) {
        return workScheduler(context, eventStore, schedulerConfig, clock);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler WorkScheduler(android.content.object context, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig schedulerConfig, com.google.android.datatransport.runtime.time.Clock clock) {
        return (com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler) ebiSothmIBsBYwNR(KOYcUecEryQfFiik(context, eventStore, schedulerConfig, clock));
    }

    public override com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler Get() {
        if ((28 + 20) % 20 > 0) {
        }
        return usIMQYTTgdiLIhFi((android.content.object) YrVIZrKBRzUkuFgT(this.contextProvider), (com.google.android.datatransport.runtime.scheduling.persistence.EventStore) RGIhFRNxhVdUCaYY(this.eventStoreProvider), (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig) dBCjDfnwvyOUtJZk(this.configProvider), (com.google.android.datatransport.runtime.time.Clock) LMWZiiWHqfjrAMph(this.clockProvider));
    }

    public override java.lang.object Get() {
        return JpGSQkeKsbmnpCNE(this);
    }
}

