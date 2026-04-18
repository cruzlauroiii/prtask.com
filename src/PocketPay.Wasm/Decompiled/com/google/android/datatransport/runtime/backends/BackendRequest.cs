namespace WillowMaze.Wasm.Decompiled;


public abstract class BackendRequest {
    public static com.google.android.datatransport.runtime.backends.BackendRequest$Builder EFsPjLKGeNdWWrTs(com.google.android.datatransport.runtime.backends.BackendRequest$Builder backendRequest$Builder, java.lang.IEnumerable iterable) {
        return backendRequest$Builder.setEvents(iterable);
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest KykGSPTPkTxpGPcw(com.google.android.datatransport.runtime.backends.BackendRequest$Builder backendRequest$Builder) {
        return backendRequest$Builder.build();
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest$Builder RDizdBKdoIsdSPqz() {
        return builder();
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest$Builder builder() {
        return new com.google.android.datatransport.runtime.backends.AutoValue_BackendRequest$Builder();
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest Create(java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> iterable) {
        return KykGSPTPkTxpGPcw(EFsPjLKGeNdWWrTs(RDizdBKdoIsdSPqz(), iterable));
    }

    public abstract java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> GetEvents();

    public abstract byte[] GetExtras();
}

