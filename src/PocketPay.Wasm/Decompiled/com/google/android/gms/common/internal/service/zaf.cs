namespace WillowMaze.Wasm.Decompiled;


abstract class zaf : com.google.android.gms.common.internal.service.zag {
    public zaf(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        super(googleApiClient);
    }

    public override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return status;
    }
}

