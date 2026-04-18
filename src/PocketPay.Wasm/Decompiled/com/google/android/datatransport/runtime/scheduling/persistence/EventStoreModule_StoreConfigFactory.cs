namespace WillowMaze.Wasm.Decompiled;


public readonly class EventStoreModule_StoreConfigFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig> {
    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig FcwiOpSFeETXPvFF(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_StoreConfigFactory eventStoreModule_StoreConfigFactory) {
        return eventStoreModule_StoreConfigFactory[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig LejfFYOYSEYdRAwI() {
        return storeConfig();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_StoreConfigFactory BYSrqSTrwtJEjnrn() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_StoreConfigFactory$InstanceHolder.access$000();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_StoreConfigFactory Create() {
        return bYSrqSTrwtJEjnrn();
    }

    public static java.lang.object DDZQyWttlBExgBDe(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig StoreConfig() {
        return (com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig) dDZQyWttlBExgBDe(wAOdeRuxSCRYSgTz());
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig WAOdeRuxSCRYSgTz() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule.storeConfig();
    }

    public override com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig Get() {
        return LejfFYOYSEYdRAwI();
    }

    public override java.lang.object Get() {
        return FcwiOpSFeETXPvFF(this);
    }
}

