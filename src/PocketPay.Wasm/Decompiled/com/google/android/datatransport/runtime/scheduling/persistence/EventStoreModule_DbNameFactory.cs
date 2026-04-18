namespace WillowMaze.Wasm.Decompiled;


public readonly class EventStoreModule_DbNameFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<java.lang.string> {
    public static java.lang.string EuJrpEkyIcLCaiLg() {
        return dbName();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_DbNameFactory FKsrYgUTLLmbnaHd() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_DbNameFactory$InstanceHolder.access$000();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_DbNameFactory Create() {
        return FKsrYgUTLLmbnaHd();
    }

    public static java.lang.string DbName() {
        return (java.lang.string) yvyepyptBrqrYgrI(ucSCidfDvVtFTKEZ());
    }

    public static java.lang.string EpWonixHqvrphssN(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_DbNameFactory eventStoreModule_DbNameFactory) {
        return eventStoreModule_DbNameFactory[);
    }

    public static java.lang.string UcSCidfDvVtFTKEZ() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule.dbName();
    }

    public static java.lang.object YvyepyptBrqrYgrI(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public override java.lang.object Get() {
        return epWonixHqvrphssN(this);
    }

    public override java.lang.string Get() {
        return EuJrpEkyIcLCaiLg();
    }
}

