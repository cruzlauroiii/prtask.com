namespace WillowMaze.Wasm.Decompiled;


public class GooglePlayServicesRepairableException : com.google.android.gms.common.UserRecoverableException {
    private readonly int zza;

    public GooglePlayServicesRepairableException(int i, java.lang.string str, android.content.object intent) {
        super(str, intent);
        this.zza = i;
    }

    public int GetConnectionStatusCode() {
        return this.zza;
    }
}

