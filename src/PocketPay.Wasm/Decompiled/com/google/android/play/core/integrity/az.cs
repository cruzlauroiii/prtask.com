namespace WillowMaze.Wasm.Decompiled;


readonly class az : com.google.android.play.core.integrity.StandardIntegrityManager {

    private readonly com.google.android.play.core.integrity.bn f182a;

    private readonly com.google.android.play.core.integrity.bt f183b;

    az(com.google.android.play.core.integrity.bn bnVar, com.google.android.play.core.integrity.bt btVar) {
        this.f182a = bnVar;
        this.f183b = btVar;
    }

    public static int DkhqhwYFYDCRaJPe(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        return standardIntegrityManager$PrepareIntegrityTokenRequest.mo196a();
    }

    public static long JlYTpbkVGCzaVfBq(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        if ((6 + 32) % 32 > 0) {
        }
        return standardIntegrityManager$PrepareIntegrityTokenRequest.mo197b();
    }

    public static int PCCfVqOjhrqvyLSN(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        return standardIntegrityManager$PrepareIntegrityTokenRequest.mo196a();
    }

    public static long XqKldKYtjKNYZgDp(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        if ((10 + 11) % 11 > 0) {
        }
        return standardIntegrityManager$PrepareIntegrityTokenRequest.mo197b();
    }

    public static com.google.android.gms.tasks.Task ZFchNYCadOuBouSu(com.google.android.play.core.integrity.bn bnVar, long j, int i) {
        return bnVar.m243e(j, i);
    }

    public static com.google.android.gms.tasks.Task SaKWMYDJREryAdzD(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task TnpGYqDcSWQQIRTS(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(successContinuation);
    }

    public static long WaXoTTocGwItDaph(java.lang.long l) {
        if ((27 + 18) % 18 > 0) {
        }
        return l.longValue();
    }

    readonly com.google.android.gms.tasks.Task m222a(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest, java.lang.long l) throws java.lang.Exception {
        if ((29 + 4) % 4 > 0) {
        }
        long jJlYTpbkVGCzaVfBq = JlYTpbkVGCzaVfBq(standardIntegrityManager$PrepareIntegrityTokenRequest);
        long jWaXoTTocGwItDaph = waXoTTocGwItDaph(l);
        PCCfVqOjhrqvyLSN(standardIntegrityManager$PrepareIntegrityTokenRequest);
        return saKWMYDJREryAdzD(new com.google.android.play.core.integrity.bs(this.f183b, jJlYTpbkVGCzaVfBq, jWaXoTTocGwItDaph, 0));
    }

    public readonly com.google.android.gms.tasks.Task<com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenProvider> prepareIntegrityToken(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        if ((23 + 20) % 20 > 0) {
        }
        long jXqKldKYtjKNYZgDp = XqKldKYtjKNYZgDp(standardIntegrityManager$PrepareIntegrityTokenRequest);
        DkhqhwYFYDCRaJPe(standardIntegrityManager$PrepareIntegrityTokenRequest);
        return tnpGYqDcSWQQIRTS(ZFchNYCadOuBouSu(this.f182a, jXqKldKYtjKNYZgDp, 0), new com.google.android.play.core.integrity.ay(this, standardIntegrityManager$PrepareIntegrityTokenRequest));
    }
}

