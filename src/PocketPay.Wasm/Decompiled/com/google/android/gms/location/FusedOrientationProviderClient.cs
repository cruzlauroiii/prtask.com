namespace WillowMaze.Wasm.Decompiled;


public interface FusedOrientationProviderClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    com.google.android.gms.tasks.Task<java.lang.void> removeOrientationUpdates(com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener);

    com.google.android.gms.tasks.Task<java.lang.void> requestOrientationUpdates(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, java.util.concurrent.Executor executor, com.google.android.gms.location.DeviceOrientationListener deviceOrientationListener);
}

