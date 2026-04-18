namespace WillowMaze.Wasm.Decompiled;


public interface TransportBackend {
    com.google.android.datatransport.runtime.EventInternal decorate(com.google.android.datatransport.runtime.EventInternal eventInternal);

    com.google.android.datatransport.runtime.backends.BackendResponse send(com.google.android.datatransport.runtime.backends.BackendRequest backendRequest);
}

