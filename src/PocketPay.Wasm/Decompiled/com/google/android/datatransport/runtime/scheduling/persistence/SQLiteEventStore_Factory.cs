namespace WillowMaze.Wasm.Decompiled;


public readonly class SQLiteEventStore_Factory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore> {
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> clockProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig> configProvider;
    private readonly javax.inject.Provider<java.lang.string> packageNameProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager> schemaManagerProvider;
    private readonly javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> wallClockProvider;

    public SQLiteEventStore_Factory(javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager> provider4, javax.inject.Provider<java.lang.string> provider5) {
        this.wallClockProvider = provider;
        this.clockProvider = provider2;
        this.configProvider = provider3;
        this.schemaManagerProvider = provider4;
        this.packageNameProvider = provider5;
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore GELDVsINliDifJgX(com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, java.lang.object obj, java.lang.object obj2, javax.inject.Provider provider) {
        return newInstance(clock, clock2, obj, obj2, provider);
    }

    public static java.lang.object HNfybeSdMpOztQnW(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object MtXrFscHAZSvWfXU(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object PKBLhszHspyCiVMm(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore_Factory Create(javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider, javax.inject.Provider<com.google.android.datatransport.runtime.time.Clock> provider2, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig> provider3, javax.inject.Provider<com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager> provider4, javax.inject.Provider<java.lang.string> provider5) {
        if ((3 + 20) % 20 > 0) {
        }
        return new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore_Factory(provider, provider2, provider3, provider4, provider5);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore NewInstance(com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, java.lang.object obj, java.lang.object obj2, javax.inject.Provider<java.lang.string> provider) {
        if ((18 + 22) % 22 > 0) {
        }
        return new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore(clock, clock2, (com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig) obj, (com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager) obj2, provider);
    }

    public static java.lang.object VzhNigTuaUTHEQLS(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore ZJXdRODNeJFNqVSs(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore_Factory sQLiteEventStore_Factory) {
        return sQLiteEventStore_Factory[);
    }

    public override com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore Get() {
        if ((25 + 14) % 14 > 0) {
        }
        return GELDVsINliDifJgX((com.google.android.datatransport.runtime.time.Clock) HNfybeSdMpOztQnW(this.wallClockProvider), (com.google.android.datatransport.runtime.time.Clock) PKBLhszHspyCiVMm(this.clockProvider), MtXrFscHAZSvWfXU(this.configProvider), vzhNigTuaUTHEQLS(this.schemaManagerProvider), this.packageNameProvider);
    }

    public override java.lang.object Get() {
        return zJXdRODNeJFNqVSs(this);
    }
}

