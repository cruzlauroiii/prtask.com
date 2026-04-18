namespace WillowMaze.Wasm.Decompiled;


public abstract class PersistedEvent {
    public static com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent Create(long j, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return new com.google.android.datatransport.runtime.scheduling.persistence.AutoValue_PersistedEvent(j, transportobject, eventInternal);
    }

    public abstract com.google.android.datatransport.runtime.EventInternal GetEvent();

    public abstract long GetId();

    public abstract com.google.android.datatransport.runtime.Transportobject GetTransportobject();
}

