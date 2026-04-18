namespace WillowMaze.Wasm.Decompiled;


readonly class zaq : com.google.android.gms.common.internal.PendingResultUtil$ResultConverter {
    readonly com.google.android.gms.common.api.Response zaa;

    zaq(com.google.android.gms.common.api.Response response) {
        this.zaa = response;
    }

    public static void RFVwloGCBuNNAafL(com.google.android.gms.common.api.Response response, com.google.android.gms.common.api.Result result) {
        response.setResult(result);
    }

    public override readonly java.lang.object Convert(com.google.android.gms.common.api.Result result) {
        rFVwloGCBuNNAafL(this.zaa, result);
        return this.zaa;
    }
}

