namespace WillowMaze.Wasm.Decompiled;


readonly class zzeb : com.google.android.gms.tasks.OnTokenCanceledListener {
    private readonly com.google.android.gms.common.internal.ICancelToken zza;

    zzeb(com.google.android.gms.common.internal.ICancelToken iCancelToken) {
        this.zza = iCancelToken;
    }

    public static void ASjpfPcEzBrfmAQD(com.google.android.gms.common.internal.ICancelToken iCancelToken) throws android.os.RemoteException {
        iCancelToken.cancel();
    }

    public static void ASjpfPcEzBrfmAQD(com.google.android.gms.common.internal.ICancelToken iCancelToken, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASjpfPcEzBrfmAQD(com.google.android.gms.common.internal.ICancelToken iCancelToken, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASjpfPcEzBrfmAQD(com.google.android.gms.common.internal.ICancelToken iCancelToken, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnCanceled() {
        int i = com.google.android.gms.internal.identity.zzdz.zze;
        try {
            aSjpfPcEzBrfmAQD(this.zza);
        } catch (android.os.RemoteException unused) {
        }
    }
}

