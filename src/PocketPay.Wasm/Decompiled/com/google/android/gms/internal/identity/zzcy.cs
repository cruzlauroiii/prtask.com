namespace WillowMaze.Wasm.Decompiled;


abstract class zzcy : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl {
    public zzcy(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super((com.google.android.gms.common.api.Api<object>) com.google.android.gms.internal.identity.zzbi.zzb, googleApiClient);
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbAbyxhqshbNmuuF(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.location.LocationHashSettingsResult(status, null);
    }

    public override readonly void SetResult(java.lang.object obj) {
        bbAbyxhqshbNmuuF(this, (com.google.android.gms.common.api.Result) obj);
    }
}

