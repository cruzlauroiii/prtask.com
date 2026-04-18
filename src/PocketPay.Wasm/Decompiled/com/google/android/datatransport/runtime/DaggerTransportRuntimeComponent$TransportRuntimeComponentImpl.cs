namespace WillowMaze.Wasm.Decompiled;


readonly class DaggerTransportRuntimeComponent$TransportRuntimeComponentImpl : com.google.android.datatransport.runtime.TransportRuntimeComponent {
    private javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.SchedulerConfig> configProvider;
    private javax.inject.Provider creationobjectFactoryProvider;
    private javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.DefaultScheduler> defaultSchedulerProvider;
    private javax.inject.Provider<java.util.concurrent.Executor> executorProvider;
    private javax.inject.Provider metadataBackendRegistryProvider;
    private javax.inject.Provider<java.lang.string> packageNameProvider;
    private javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore> sQLiteEventStoreProvider;
    private javax.inject.Provider schemaManagerProvider;
    private javax.inject.Provider<android.content.object> setApplicationobjectProvider;
    private readonly com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$TransportRuntimeComponentImpl transportRuntimeComponentImpl;
    private javax.inject.Provider<com.google.android.datatransport.runtime.TransportRuntime> transportRuntimeProvider;
    private javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader> uploaderProvider;
    private javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer> workInitializerProvider;
    private javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler> workSchedulerProvider;

    private DaggerTransportRuntimeComponent$TransportRuntimeComponentImpl(android.content.object context) {
        this.transportRuntimeComponentImpl = this;
        fhsTlEWzkJgQKjxG(this, context);
    }

    DaggerTransportRuntimeComponent$TransportRuntimeComponentImpl(android.content.object context, com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$1 daggerTransportRuntimeComponent$1) {
        this(context);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_SchemaVersionFactory CKSkwwbSOoDSbVCE() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_SchemaVersionFactory.create();
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory CbXSTsYVMyBAkcwD() {
        return com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory.create();
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory CkQwgeGTsqSrSXyD() {
        return com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory.create();
    }

    public static javax.inject.Provider EmCnRujXkNsqsjTT(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader_Factory FIubNPHCIkgQmMek(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4, javax.inject.Provider provider5, javax.inject.Provider provider6, javax.inject.Provider provider7, javax.inject.Provider provider8, javax.inject.Provider provider9) {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader_Factory.create(provider, provider2, provider3, provider4, provider5, provider6, provider7, provider8, provider9);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory FYmzYUUwJBgonBHw() {
        return com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory.create();
    }

    public static javax.inject.Provider GTtItblRqKIxERqE(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory IyPtAHHMnrZjMzXC() {
        return com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory.create();
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory KkqkPIEBSkJNKjpd() {
        return com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory.create();
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory KowynOPVgptkaLlh() {
        return com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory.create();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager_Factory NNgHvLXPZlGQVktS(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager_Factory.create(provider, provider2, provider3);
    }

    public static java.lang.object RMbshCkCprgSCznZ(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory SbCsKdcyqhUmEwGD() {
        return com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory.create();
    }

    public static javax.inject.Provider SqzwgfdMJhKceGvh(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.android.datatransport.runtime.scheduling.SchedulingModule_WorkSchedulerFactory WRKHnBKSsncCZjQn(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4) {
        return com.google.android.datatransport.runtime.scheduling.SchedulingModule_WorkSchedulerFactory.create(provider, provider2, provider3, provider4);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory YmacazjISqgiPlTp() {
        return com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory.create();
    }

    public static com.google.android.datatransport.runtime.ExecutionModule_ExecutorFactory AtljabFWBvbCmstX() {
        return com.google.android.datatransport.runtime.ExecutionModule_ExecutorFactory.create();
    }

    public static com.google.android.datatransport.runtime.scheduling.DefaultScheduler_Factory ByYguIKgioVygsrs(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4, javax.inject.Provider provider5) {
        return com.google.android.datatransport.runtime.scheduling.DefaultScheduler_Factory.create(provider, provider2, provider3, provider4, provider5);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_PackageNameFactory EdHRdUBDintCuWzU(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_PackageNameFactory.create(provider);
    }

    public static com.google.android.datatransport.runtime.backends.MetadataBackendRegistry_Factory EkZCwxnssbZbxhtX(javax.inject.Provider provider, javax.inject.Provider provider2) {
        return com.google.android.datatransport.runtime.backends.MetadataBackendRegistry_Factory.create(provider, provider2);
    }

    public static com.google.android.datatransport.runtime.backends.CreationobjectFactory_Factory ErTxMmxBGQzoifsb(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3) {
        return com.google.android.datatransport.runtime.backends.CreationobjectFactory_Factory.create(provider, provider2, provider3);
    }

    public static void FhsTlEWzkJgQKjxG(com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent$TransportRuntimeComponentImpl daggerTransportRuntimeComponent$TransportRuntimeComponentImpl, android.content.object context) {
        daggerTransportRuntimeComponent$TransportRuntimeComponentImpl.initialize(context);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_DbNameFactory FimcnYkOxUegbWZO() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_DbNameFactory.create();
    }

    public static javax.inject.Provider IDOSJOiJAGMCaSyn(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule_ConfigFactory IfLkHaZnjPPjUxrQ(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule_ConfigFactory.create(provider);
    }

    private void Initialize(android.content.object context) {
        if ((30 + 28) % 28 > 0) {
        }
        this.executorProvider = ixMLAjulIGoyeAzb(atljabFWBvbCmstX());
        com.google.android.datatransport.runtime.dagger.internal.Factory factoryNqzgWYDrGbppHDkw = nqzgWYDrGbppHDkw(context);
        this.setApplicationobjectProvider = factoryNqzgWYDrGbppHDkw;
        com.google.android.datatransport.runtime.backends.CreationobjectFactory_Factory creationobjectFactory_FactoryErTxMmxBGQzoifsb = erTxMmxBGQzoifsb(factoryNqzgWYDrGbppHDkw, CkQwgeGTsqSrSXyD(), CbXSTsYVMyBAkcwD());
        this.creationobjectFactoryProvider = creationobjectFactory_FactoryErTxMmxBGQzoifsb;
        this.metadataBackendRegistryProvider = EmCnRujXkNsqsjTT(ekZCwxnssbZbxhtX(this.setApplicationobjectProvider, creationobjectFactory_FactoryErTxMmxBGQzoifsb));
        this.schemaManagerProvider = NNgHvLXPZlGQVktS(this.setApplicationobjectProvider, fimcnYkOxUegbWZO(), CKSkwwbSOoDSbVCE());
        this.packageNameProvider = iDOSJOiJAGMCaSyn(edHRdUBDintCuWzU(this.setApplicationobjectProvider));
        this.sQLiteEventStoreProvider = SqzwgfdMJhKceGvh(qasONCXGpwEriKYJ(IyPtAHHMnrZjMzXC(), KowynOPVgptkaLlh(), kqzuQGWcCFuxKtKx(), this.schemaManagerProvider, this.packageNameProvider));
        com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule_ConfigFactory schedulingConfigModule_ConfigFactoryIfLkHaZnjPPjUxrQ = ifLkHaZnjPPjUxrQ(yKhuYFnHeMwCPzTs());
        this.configProvider = schedulingConfigModule_ConfigFactoryIfLkHaZnjPPjUxrQ;
        com.google.android.datatransport.runtime.scheduling.SchedulingModule_WorkSchedulerFactory schedulingModule_WorkSchedulerFactoryWRKHnBKSsncCZjQn = WRKHnBKSsncCZjQn(this.setApplicationobjectProvider, this.sQLiteEventStoreProvider, schedulingConfigModule_ConfigFactoryIfLkHaZnjPPjUxrQ, KkqkPIEBSkJNKjpd());
        this.workSchedulerProvider = schedulingModule_WorkSchedulerFactoryWRKHnBKSsncCZjQn;
        javax.inject.Provider<java.util.concurrent.Executor> provider = this.executorProvider;
        javax.inject.Provider provider2 = this.metadataBackendRegistryProvider;
        javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore> provider3 = this.sQLiteEventStoreProvider;
        this.defaultSchedulerProvider = byYguIKgioVygsrs(provider, provider2, schedulingModule_WorkSchedulerFactoryWRKHnBKSsncCZjQn, provider3, provider3);
        javax.inject.Provider<android.content.object> provider4 = this.setApplicationobjectProvider;
        javax.inject.Provider provider5 = this.metadataBackendRegistryProvider;
        javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore> provider6 = this.sQLiteEventStoreProvider;
        this.uploaderProvider = FIubNPHCIkgQmMek(provider4, provider5, provider6, this.workSchedulerProvider, this.executorProvider, provider6, SbCsKdcyqhUmEwGD(), YmacazjISqgiPlTp(), this.sQLiteEventStoreProvider);
        javax.inject.Provider<java.util.concurrent.Executor> provider7 = this.executorProvider;
        javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore> provider8 = this.sQLiteEventStoreProvider;
        this.workInitializerProvider = uhvtrtOXTNolLiyo(provider7, provider8, this.workSchedulerProvider, provider8);
        this.transportRuntimeProvider = GTtItblRqKIxERqE(uWUDfnjBSElPuuPF(FYmzYUUwJBgonBHw(), vfsNpROTMFZCkEpR(), this.defaultSchedulerProvider, this.uploaderProvider, this.workInitializerProvider));
    }

    public static javax.inject.Provider IxMLAjulIGoyeAzb(javax.inject.Provider provider) {
        return com.google.android.datatransport.runtime.dagger.internal.doubleCheck.provider(provider);
    }

    public static java.lang.object JGprGImISaZFrEmN(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_StoreConfigFactory KqzuQGWcCFuxKtKx() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_StoreConfigFactory.create();
    }

    public static com.google.android.datatransport.runtime.dagger.internal.Factory NqzgWYDrGbppHDkw(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.InstanceFactory.create(obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore_Factory QasONCXGpwEriKYJ(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4, javax.inject.Provider provider5) {
        return com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore_Factory.create(provider, provider2, provider3, provider4, provider5);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime_Factory UWUDfnjBSElPuuPF(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4, javax.inject.Provider provider5) {
        return com.google.android.datatransport.runtime.TransportRuntime_Factory.create(provider, provider2, provider3, provider4, provider5);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer_Factory UhvtrtOXTNolLiyo(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4) {
        return com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer_Factory.create(provider, provider2, provider3, provider4);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory VfsNpROTMFZCkEpR() {
        return com.google.android.datatransport.runtime.time.TimeModule_UptimeClockFactory.create();
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory YKhuYFnHeMwCPzTs() {
        return com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory.create();
    }

    com.google.android.datatransport.runtime.scheduling.persistence.EventStore getEventStore() {
        return (com.google.android.datatransport.runtime.scheduling.persistence.EventStore) RMbshCkCprgSCznZ(this.sQLiteEventStoreProvider);
    }

    com.google.android.datatransport.runtime.TransportRuntime getTransportRuntime() {
        return (com.google.android.datatransport.runtime.TransportRuntime) jGprGImISaZFrEmN(this.transportRuntimeProvider);
    }
}

