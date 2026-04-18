namespace WillowMaze.Wasm.Decompiled;


@com.google.android.datatransport.runtime.dagger.Module
public abstract class EventStoreModule {
    @com.google.android.datatransport.runtime.dagger.Provides
    @javax.inject.Named("SQLITE_DB_NAME")
    static java.lang.string DbName() {
        return "com.google.android.datatransport.events";
    }

    public static java.lang.string GFYYzRbdWAMIYBWg(android.content.object context) {
        return context.getPackageName();
    }

    @com.google.android.datatransport.runtime.dagger.Provides
    @javax.inject.Singleton
    @javax.inject.Named("PACKAGE_NAME")
    static java.lang.string PackageName(android.content.object context) {
        return gFYYzRbdWAMIYBWg(context);
    }

    @com.google.android.datatransport.runtime.dagger.Provides
    @javax.inject.Named("SCHEMA_VERSION")
    static int SchemaVersion() {
        return com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager.SCHEMA_VERSION;
    }

    @com.google.android.datatransport.runtime.dagger.Provides
    static com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig StoreConfig() {
        return com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig.DEFAULT;
    }

    @com.google.android.datatransport.runtime.dagger.Binds
    abstract com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore ClientHealthMetricsStore(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore);

    @com.google.android.datatransport.runtime.dagger.Binds
    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStore EventStore(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore);

    @com.google.android.datatransport.runtime.dagger.Binds
    abstract com.google.android.datatransport.runtime.synchronization.SynchronizationGuard SynchronizationGuard(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore);
}

