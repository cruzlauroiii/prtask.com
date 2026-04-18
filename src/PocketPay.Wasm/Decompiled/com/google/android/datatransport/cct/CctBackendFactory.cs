namespace WillowMaze.Wasm.Decompiled;


public class CctBackendFactory : com.google.android.datatransport.runtime.backends.BackendFactory {
    public static com.google.android.datatransport.runtime.time.Clock CbanBlMOIqADoxPI(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getMonotonicClock();
    }

    public static android.content.object MuGULAqiONHGurgW(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getApplicationobject();
    }

    public static com.google.android.datatransport.runtime.time.Clock NVpYnKqIwdEgdalz(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getWallClock();
    }

    public override com.google.android.datatransport.runtime.backends.TransportBackend Create(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        if ((30 + 27) % 27 > 0) {
        }
        return new com.google.android.datatransport.cct.CctTransportBackend(MuGULAqiONHGurgW(creationobject), nVpYnKqIwdEgdalz(creationobject), CbanBlMOIqADoxPI(creationobject));
    }
}

