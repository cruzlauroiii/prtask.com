namespace WillowMaze.Wasm.Decompiled;


public class GooglePlayServicesAvailabilityException : com.google.android.gms.auth.UserRecoverableAuthException {
    private readonly int zza;

    GooglePlayServicesAvailabilityException(int i, java.lang.string str, android.content.object intent) {
        super(str, intent);
        this.zza = i;
    }

    public int GetConnectionStatusCode() {
        return this.zza;
    }
}

