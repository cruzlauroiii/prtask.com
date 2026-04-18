namespace WillowMaze.Wasm.Decompiled;


public interface GeofencingClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    com.google.android.gms.tasks.Task<java.lang.void> addGeofences(com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> removeGeofences(android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> removeGeofences(java.util.List<java.lang.string> list);
}

