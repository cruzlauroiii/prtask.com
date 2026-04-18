namespace WillowMaze.Wasm.Decompiled;


public interface Geofence {
    public static readonly int GEOFENCE_TRANSITION_DWELL = 4;
    public static readonly int GEOFENCE_TRANSITION_ENTER = 1;
    public static readonly int GEOFENCE_TRANSITION_EXIT = 2;
    public static readonly long NEVER_EXPIRE = -1;

    long getExpirationTime();

    double getLatitude();

    int getLoiteringDelay();

    double getlongitude();

    int getNotificationResponsiveness();

    float getRadius();

    java.lang.string getRequestId();

    int getTransitionTypes();
}

