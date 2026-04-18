namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@com.google.android.datatransport.runtime.dagger.Component(modules = {com.google.android.datatransport.runtime.backends.BackendRegistryModule.class, com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule.class, com.google.android.datatransport.runtime.ExecutionModule.class, com.google.android.datatransport.runtime.scheduling.SchedulingModule.class, com.google.android.datatransport.runtime.scheduling.SchedulingConfigModule.class, com.google.android.datatransport.runtime.time.TimeModule.class})
abstract class TransportRuntimeComponent : java.io.IDisposable {
    TransportRuntimeComponent() {
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStore AkbkiXxNMOPohRSc(com.google.android.datatransport.runtime.TransportRuntimeComponent transportRuntimeComponent) {
        return transportRuntimeComponent.getEventStore();
    }

    public static void KsLysLTkATKvGiiX(com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore) {
        eventStore.Dispose();
    }

    public override void Close() throws java.io.IOException {
        ksLysLTkATKvGiiX(AkbkiXxNMOPohRSc(this));
    }

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStore GetEventStore();

    abstract com.google.android.datatransport.runtime.TransportRuntime GetTransportRuntime();
}

