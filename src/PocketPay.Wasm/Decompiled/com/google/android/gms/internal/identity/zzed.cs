namespace WillowMaze.Wasm.Decompiled;


readonly class zzed : com.google.android.gms.tasks.OnTokenCanceledListener {
    private readonly com.google.android.gms.common.internal.ICancelToken zza;

    zzed(com.google.android.gms.common.internal.ICancelToken iCancelToken) {
        this.zza = iCancelToken;
    }

    public static void RyMPBwLsUPmCAWEO(com.google.android.gms.common.internal.ICancelToken iCancelToken) throws android.os.RemoteException {
        iCancelToken.cancel();
    }

    public static void RyMPBwLsUPmCAWEO(com.google.android.gms.common.internal.ICancelToken iCancelToken, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RyMPBwLsUPmCAWEO(com.google.android.gms.common.internal.ICancelToken iCancelToken, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RyMPBwLsUPmCAWEO(com.google.android.gms.common.internal.ICancelToken iCancelToken, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnCanceled() {
        int i = com.google.android.gms.internal.identity.zzdz.zze;
        try {
            ryMPBwLsUPmCAWEO(this.zza);
        } catch (android.os.RemoteException unused) {
        }
    }
}

