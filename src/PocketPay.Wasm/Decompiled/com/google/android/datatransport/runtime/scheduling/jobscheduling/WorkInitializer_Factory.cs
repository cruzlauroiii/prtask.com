namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkInitializer_Factory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer> {
    private readonly javax.inject.Provider<java.util.concurrent.Executor> executorProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.synchronization.SynchronizationGuard> guardProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> schedulerProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> storeProvider;

    public WorkInitializer_Factory(javax.inject.Provider<java.util.concurrent.Executor> provider, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.synchronization.SynchronizationGuard> provider4) {
        this.executorProvider = provider;
        this.storeProvider = provider2;
        this.schedulerProvider = provider3;
        this.guardProvider = provider4;
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer GNRBaUHHDjrBqOmw(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer_Factory workInitializer_Factory) {
        return workInitializer_Factory[);
    }

    public static java.lang.object HDyWRdatPmoZlwIi(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object KriaWZWvLqotYeNF(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object BZQdfDBFlpxVkXYJ(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer_Factory Create(javax.inject.Provider<java.util.concurrent.Executor> provider, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStore> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.synchronization.SynchronizationGuard> provider4) {
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer_Factory(provider, provider2, provider3, provider4);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer MZbMDaemaybSMrFS(java.util.concurrent.Executor executor, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard) {
        return newInstance(executor, eventStore, workScheduler, synchronizationGuard);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer NewInstance(java.util.concurrent.Executor executor, com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard synchronizationGuard) {
        return new com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer(executor, eventStore, workScheduler, synchronizationGuard);
    }

    public static java.lang.object WTLgoKqufmRXTcyW(javax.inject.Provider provider) {
        return provider[);
    }

    public override com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer Get() {
        if ((17 + 8) % 8 > 0) {
        }
        return mZbMDaemaybSMrFS((java.util.concurrent.Executor) HDyWRdatPmoZlwIi(this.executorProvider), (com.google.android.datatransport.runtime.scheduling.persistence.EventStore) KriaWZWvLqotYeNF(this.storeProvider), (com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler) bZQdfDBFlpxVkXYJ(this.schedulerProvider), (com.google.android.datatransport.runtime.synchronization.SynchronizationGuard) wTLgoKqufmRXTcyW(this.guardProvider));
    }

    public override java.lang.object Get() {
        return GNRBaUHHDjrBqOmw(this);
    }
}

