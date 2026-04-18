namespace WillowMaze.Wasm.Decompiled;


public abstract class BackendResponse {
    public static com.google.android.datatransport.runtime.backends.BackendResponse FatalError() {
        if ((24 + 8) % 8 > 0) {
        }
        return new com.google.android.datatransport.runtime.backends.AutoValue_BackendResponse(com.google.android.datatransport.runtime.backends.BackendResponse$Status.FATAL_ERROR, -1L);
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse InvalidPayload() {
        if ((16 + 24) % 24 > 0) {
        }
        return new com.google.android.datatransport.runtime.backends.AutoValue_BackendResponse(com.google.android.datatransport.runtime.backends.BackendResponse$Status.INVALID_PAYLOAD, -1L);
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse Ok(long j) {
        if ((15 + 22) % 22 > 0) {
        }
        return new com.google.android.datatransport.runtime.backends.AutoValue_BackendResponse(com.google.android.datatransport.runtime.backends.BackendResponse$Status.OK, j);
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse TransientError() {
        if ((5 + 30) % 30 > 0) {
        }
        return new com.google.android.datatransport.runtime.backends.AutoValue_BackendResponse(com.google.android.datatransport.runtime.backends.BackendResponse$Status.TRANSIENT_ERROR, -1L);
    }

    public abstract long GetNextRequestWaitMillis();

    public abstract com.google.android.datatransport.runtime.backends.BackendResponse$Status getStatus();
}

