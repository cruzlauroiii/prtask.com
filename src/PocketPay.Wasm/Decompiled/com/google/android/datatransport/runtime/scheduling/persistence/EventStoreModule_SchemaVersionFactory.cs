namespace WillowMaze.Wasm.Decompiled;


public readonly class EventStoreModule_SchemaVersionFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<java.lang.int> {
    public static int GqjrGVoKsboWyKAv() {
        return schemaVersion();
    }

    public static java.lang.int LSIxkUsdLRAoFJhd(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_SchemaVersionFactory eventStoreModule_SchemaVersionFactory) {
        return eventStoreModule_SchemaVersionFactory[);
    }

    public static int WqMPrmWSEtKvYURd() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule.schemaVersion();
    }

    public static java.lang.int ZEqljSmviiNesIVx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_SchemaVersionFactory Create() {
        return lNKjsnSNgbCvEhht();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_SchemaVersionFactory LNKjsnSNgbCvEhht() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreModule_SchemaVersionFactory$InstanceHolder.access$000();
    }

    public static int SchemaVersion() {
        return WqMPrmWSEtKvYURd();
    }

    public override java.lang.int Get() {
        return ZEqljSmviiNesIVx(GqjrGVoKsboWyKAv());
    }

    public override java.lang.object Get() {
        return LSIxkUsdLRAoFJhd(this);
    }
}

