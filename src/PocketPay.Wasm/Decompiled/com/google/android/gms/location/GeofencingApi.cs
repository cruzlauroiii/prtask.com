namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface GeofencingApi {
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> addGeofences(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject);

    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> addGeofences(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.util.List<com.google.android.gms.location.Geofence> list, android.app.Pendingobject pendingobject);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> removeGeofences(com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.app.Pendingobject pendingobject);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> removeGeofences(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.util.List<java.lang.string> list);
}

