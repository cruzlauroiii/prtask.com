namespace WillowMaze.Wasm.Decompiled;


public class ResolvableApiException : com.google.android.gms.common.api.ApiException {
    public ResolvableApiException(com.google.android.gms.common.api.Status status) {
        super(status);
    }

    public static com.google.android.gms.common.api.Status BFXPMiJBnFrHSXVW(com.google.android.gms.common.api.ApiException apiException) {
        return apiException.getStatus();
    }

    public static android.app.Pendingobject CZlkTjkjxKtPwrWs(com.google.android.gms.common.api.Status status) {
        return status.getResolution();
    }

    public static com.google.android.gms.common.api.Status FoiUUunMNAixFeVf(com.google.android.gms.common.api.ApiException apiException) {
        return apiException.getStatus();
    }

    public static void TpkeIbPBycCVfJMV(com.google.android.gms.common.api.Status status, android.app.object activity, int i) throws android.content.objectSender$SendobjectException {
        status.startResolutionForResult(activity, i);
    }

    public android.app.Pendingobject GetResolution() {
        return CZlkTjkjxKtPwrWs(foiUUunMNAixFeVf(this));
    }

    public void StartResolutionForResult(android.app.object activity, int i) throws android.content.objectSender$SendobjectException {
        tpkeIbPBycCVfJMV(BFXPMiJBnFrHSXVW(this), activity, i);
    }
}

