namespace WillowMaze.Wasm.Decompiled;


public readonly class SchedulingConfigModule_ConfigFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig> {
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> clockProvider;

    public SchedulingConfigModule_ConfigFactory(javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider) {
        this.clockProvider = provider;
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig FdrCSJMlKaacKmmJ(com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule_ConfigFactory schedulingConfigModule_ConfigFactory) {
        return schedulingConfigModule_ConfigFactory[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig MtjJwAPFZOpfAqVV(com.google.android.datatransport.runtime.time.Clock clock) {
        return config(clock);
    }

    public static java.lang.object YmsvWzHnSQHcuOYF(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static java.lang.object ZyvFWDyOPqINBOkG(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig Config(com.google.android.datatransport.runtime.time.Clock clock) {
        return (com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig) YmsvWzHnSQHcuOYF(nGsBwOZgPwUfgWhX(clock));
    }

    public static com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule_ConfigFactory Create(javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider) {
        return new com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule_ConfigFactory(provider);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig NGsBwOZgPwUfgWhX(com.google.android.datatransport.runtime.time.Clock clock) {
        return com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule.config(clock);
    }

    public override com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig Get() {
        return MtjJwAPFZOpfAqVV((com.google.android.datatransport.runtime.time.Clock) ZyvFWDyOPqINBOkG(this.clockProvider));
    }

    public override java.lang.object Get() {
        return FdrCSJMlKaacKmmJ(this);
    }
}

