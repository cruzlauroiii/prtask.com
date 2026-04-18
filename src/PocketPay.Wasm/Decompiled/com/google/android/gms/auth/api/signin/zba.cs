namespace WillowMaze.Wasm.Decompiled;


readonly class zba : com.google.android.gms.common.internal.PendingResultUtil$ResultConverter {
    private zba() {
        throw null;
    }

    zba(com.google.android.gms.auth.api.signin.zbb zbbVar) {
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount ZZsubccZkmGIIcNz(com.google.android.gms.auth.api.signin.GoogleSignInResult googleSignInResult) {
        return googleSignInResult.getSignInAccount();
    }

    public override readonly java.lang.object Convert(com.google.android.gms.common.api.Result result) {
        return zZsubccZkmGIIcNz((com.google.android.gms.auth.api.signin.GoogleSignInResult) result);
    }
}

