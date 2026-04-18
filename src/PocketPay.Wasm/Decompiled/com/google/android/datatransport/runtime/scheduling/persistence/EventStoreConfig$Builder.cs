namespace WillowMaze.Wasm.Decompiled;


abstract class EventStoreConfig$Builder {
    EventStoreConfig$Builder() {
    }

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig Build();

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setCriticalSectionEnterTimeoutMs(int i);

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setEventCleanUpAge(long j);

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setLoadBatchSize(int i);

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setMaxBlobbyteSizePerRow(int i);

    abstract com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig$Builder setMaxStorageSizeInbytes(long j);
}

