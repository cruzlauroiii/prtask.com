namespace WillowMaze.Wasm.Decompiled;


public interface EventStore : java.io.IDisposable {
    int cleanUp();

    long getNextCallTime(com.google.android.datatransport.runtime.Transportobject transportobject);

    bool hasPendingEventsFor(com.google.android.datatransport.runtime.Transportobject transportobject);

    java.lang.IEnumerable<com.google.android.datatransport.runtime.Transportobject> loadActiveobjects();

    java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> loadBatch(com.google.android.datatransport.runtime.Transportobject transportobject);

    com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persist(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal);

    void recordFailure(java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> iterable);

    void recordNextCallTime(com.google.android.datatransport.runtime.Transportobject transportobject, long j);

    void recordSuccess(java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> iterable);
}

