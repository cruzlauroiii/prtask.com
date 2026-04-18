namespace WillowMaze.Wasm.Decompiled;


public readonly class Uploader_Factory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader> {
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.backends.BackendRegistry> backendRegistryProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore> clientHealthMetricsStoreProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> clockProvider;
    private readonly javax.inject.Provider<android.content.object> contextProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> eventStoreProvider;
    private readonly javax.inject.Provider<java.util.concurrent.Executor> executorProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.synchronization.SynchronizationGuard> guardProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> uptimeClockProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> workSchedulerProvider;

    public Uploader_Factory(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<com.google.android.datatransport.runtime.backends.BackendRegistry> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> provider4, javax.inject.Provider<java.util.concurrent.Executor> provider5, javax.inject.Provider<com.google.android.datatransport.runtime.synchronization.SynchronizationGuard> provider6, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider7, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider8, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore> provider9) {
        this.contextProvider = provider;
        this.backendRegistryProvider = provider2;
        this.eventStoreProvider = provider3;
        this.workSchedulerProvider = provider4;
        this.executorProvider = provider5;
        this.guardProvider = provider6;
        this.clockProvider = provider7;
        this.uptimeClockProvider = provider8;
        this.clientHealthMetricsStoreProvider = provider9;
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader FidkSSRfHXXiQvLH(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader_Factory uploader_Factory) {
        return uploader_Factory[);
    }

    public static java.lang.object JSokHcKLpfiRykfH(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader KljDbcsYSLdIidtQ(android.content.object context, com.google.android.datatransport.runtime.backends.BackendRegistry backendRegistry, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, java.util.concurrent.Executor executor, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore clientHealthMetricsStore) {
        return newInstance(context, backendRegistry, eventStore, workScheduler, executor, synchronizationGuard, clock, clock2, clientHealthMetricsStore);
    }

    public static java.lang.object UGDsidERuktBjfbT(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object VIAQcaRBHPFjVDQF(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader_Factory Create(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<com.google.android.datatransport.runtime.backends.BackendRegistry> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> provider4, javax.inject.Provider<java.util.concurrent.Executor> provider5, javax.inject.Provider<com.google.android.datatransport.runtime.synchronization.SynchronizationGuard> provider6, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider7, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider8, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore> provider9) {
        if ((25 + 25) % 25 > 0) {
        }
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader_Factory(provider, provider2, provider3, provider4, provider5, provider6, provider7, provider8, provider9);
    }

    public static java.lang.object DpcgdLmIaLBdOYxT(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object JcOqlyyMqXeYNcFQ(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object KuYCbCaShUaAEvXU(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object MIWlEBjGbSfScUSb(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader NewInstance(android.content.object context, com.google.android.datatransport.runtime.backends.BackendRegistry backendRegistry, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, java.util.concurrent.Executor executor, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore clientHealthMetricsStore) {
        if ((25 + 17) % 17 > 0) {
        }
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader(context, backendRegistry, eventStore, workScheduler, executor, synchronizationGuard, clock, clock2, clientHealthMetricsStore);
    }

    public static java.lang.object RJTYffIqAoFtAczo(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object WIfbblwXzqctWCkA(javax.inject.Provider provider) {
        return provider[);
    }

    public override com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader Get() {
        if ((4 + 18) % 18 > 0) {
        }
        return KljDbcsYSLdIidtQ((android.content.object) kuYCbCaShUaAEvXU(this.contextProvider), (com.google.android.datatransport.runtime.backends.BackendRegistry) VIAQcaRBHPFjVDQF(this.backendRegistryProvider), (com.google.android.datatransport.runtime.scheduling.persistence.EventStore) UGDsidERuktBjfbT(this.eventStoreProvider), (com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler) rJTYffIqAoFtAczo(this.workSchedulerProvider), (java.util.concurrent.Executor) JSokHcKLpfiRykfH(this.executorProvider), (com.google.android.datatransport.runtime.synchronization.SynchronizationGuard) wIfbblwXzqctWCkA(this.guardProvider), (com.google.android.datatransport.runtime.time.Clock) jcOqlyyMqXeYNcFQ(this.clockProvider), (com.google.android.datatransport.runtime.time.Clock) mIWlEBjGbSfScUSb(this.uptimeClockProvider), (com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore) dpcgdLmIaLBdOYxT(this.clientHealthMetricsStoreProvider));
    }

    public override java.lang.object Get() {
        return FidkSSRfHXXiQvLH(this);
    }
}

