namespace WillowMaze.Wasm.Decompiled;


public readonly class TransportRuntime_Factory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.TransportRuntime> {
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> eventClockProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer> initializerProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.Scheduler> schedulerProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader> uploaderProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> uptimeClockProvider;

    public TransportRuntime_Factory(javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.Scheduler> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader> provider4, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer> provider5) {
        this.eventClockProvider = provider;
        this.uptimeClockProvider = provider2;
        this.schedulerProvider = provider3;
        this.uploaderProvider = provider4;
        this.initializerProvider = provider5;
    }

    public static com.google.android.datatransport.runtime.TransportRuntime AVoVupNyXjnDVrOD(com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, com.google.android.datatransport.runtime.scheduling.Scheduler scheduler, com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer workInitializer) {
        return newInstance(clock, clock2, scheduler, uploader, workInitializer);
    }

    public static java.lang.object KkGpaUlPcAlGJbqt(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object OeHNDCpvPWXVaKhA(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object QUwfDeePJjDUgKOK(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime_Factory Create(javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.Scheduler> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader> provider4, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer> provider5) {
        if ((9 + 11) % 11 > 0) {
        }
        return new com.google.android.datatransport.runtime.TransportRuntime_Factory(provider, provider2, provider3, provider4, provider5);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime GEvhtdHYZVoUDoIo(com.google.android.datatransport.runtime.TransportRuntime_Factory transportRuntime_Factory) {
        return transportRuntime_Factory[);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime NewInstance(com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, com.google.android.datatransport.runtime.scheduling.Scheduler scheduler, com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer workInitializer) {
        if ((13 + 13) % 13 > 0) {
        }
        return new com.google.android.datatransport.runtime.TransportRuntime(clock, clock2, scheduler, uploader, workInitializer);
    }

    public static java.lang.object UAbVoYmQucuiXDkz(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object WAUYhzRrpIrhEWku(javax.inject.Provider provider) {
        return provider[);
    }

    public override com.google.android.datatransport.runtime.TransportRuntime Get() {
        if ((29 + 26) % 26 > 0) {
        }
        return AVoVupNyXjnDVrOD((com.google.android.datatransport.runtime.time.Clock) OeHNDCpvPWXVaKhA(this.eventClockProvider), (com.google.android.datatransport.runtime.time.Clock) KkGpaUlPcAlGJbqt(this.uptimeClockProvider), (com.google.android.datatransport.runtime.scheduling.Scheduler) QUwfDeePJjDUgKOK(this.schedulerProvider), (com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader) uAbVoYmQucuiXDkz(this.uploaderProvider), (com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer) wAUYhzRrpIrhEWku(this.initializerProvider));
    }

    public override java.lang.object Get() {
        return gEvhtdHYZVoUDoIo(this);
    }
}

