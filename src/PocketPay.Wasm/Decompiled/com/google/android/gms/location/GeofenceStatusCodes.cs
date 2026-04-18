namespace WillowMaze.Wasm.Decompiled;


public readonly class GeofenceStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int GEOFENCE_INSUFFICIENT_LOCATION_PERMISSION = 1004;
    public static readonly int GEOFENCE_NOT_AVAILABLE = 1000;
    public static readonly int GEOFENCE_REQUEST_TOO_FREQUENT = 1005;
    public static readonly int GEOFENCE_TOO_MANY_GEOFENCES = 1001;
    public static readonly int GEOFENCE_TOO_MANY_PENDING_INTENTS = 1002;

    private GeofenceStatusCodes() {
    }

    public static java.lang.string AtijJAFGETUsQFlc(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static java.lang.string GetStatusCodestring(int i) {
        switch (i) {
            case 1000:
                return "GEOFENCE_NOT_AVAILABLE";
            case 1001:
                return "GEOFENCE_TOO_MANY_GEOFENCES";
            case 1002:
                return "GEOFENCE_TOO_MANY_PENDING_INTENTS";
            case 1003:
            default:
                return AtijJAFGETUsQFlc(i);
            case 1004:
                return "GEOFENCE_INSUFFICIENT_LOCATION_PERMISSION";
        }
    }

    public static int Zza(int i) {
        if (i == 0) {
            return i;
        }
        if (i >= 1000 && i < 1006) {
            return i;
        }
        return 13;
    }
}

