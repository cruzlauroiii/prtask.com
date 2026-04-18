namespace WillowMaze.Wasm.Decompiled;


public class GooglePlayServicesManifestException : java.lang.IllegalStateException {
    private readonly int zza;

    public GooglePlayServicesManifestException(int i, java.lang.string str) {
        super(str);
        this.zza = i;
    }

    public int GetActualVersion() {
        return this.zza;
    }

    public int GetExpectedVersion() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.GOOGLE_PLAY_SERVICES_VERSION_CODE;
    }
}

