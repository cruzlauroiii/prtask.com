namespace WillowMaze.Wasm.Decompiled;


readonly class aa : com.google.android.play.core.integrity.IntegrityManager {

    private readonly com.google.android.play.core.integrity.aj f133a;

    aa(com.google.android.play.core.integrity.aj ajVar) {
        this.f133a = ajVar;
    }

    public static com.google.android.gms.tasks.Task LhnXJyypvmwrXfkq(com.google.android.play.core.integrity.aj ajVar, com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return ajVar.m214c(integrityTokenRequest);
    }

    public override readonly com.google.android.gms.tasks.Task<com.google.android.play.core.integrity.IntegrityTokenResponse> RequestIntegrityToken(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return lhnXJyypvmwrXfkq(this.f133a, integrityTokenRequest);
    }
}

