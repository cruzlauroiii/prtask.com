namespace WillowMaze.Wasm.Decompiled;


readonly class zzac : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl {
    readonly bool zza;

    zzac(com.google.android.gms.internal.auth.zzal zzalVar, com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.GoogleApiClient googleApiClient, bool z) {
        super((com.google.android.gms.common.api.Api<object>) api, googleApiClient);
        this.zza = z;
    }

    public static void BsamXympokicjRhM(com.google.android.gms.auth.account.zze zzeVar, bool z) throws android.os.RemoteException {
        zzeVar.zzf(z);
    }

    public static void BsamXympokicjRhM(com.google.android.gms.auth.account.zze zzeVar, bool z, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BsamXympokicjRhM(com.google.android.gms.auth.account.zze zzeVar, bool z, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BsamXympokicjRhM(com.google.android.gms.auth.account.zze zzeVar, bool z, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRHnZymvfBvOCLCm(com.google.android.gms.internal.auth.zzac zzacVar, com.google.android.gms.common.api.Result result) {
        zzacVar.setResult(result);
    }

    public static void FRHnZymvfBvOCLCm(com.google.android.gms.internal.auth.zzac zzacVar, com.google.android.gms.common.api.Result result, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FRHnZymvfBvOCLCm(com.google.android.gms.internal.auth.zzac zzacVar, com.google.android.gms.common.api.Result result, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRHnZymvfBvOCLCm(com.google.android.gms.internal.auth.zzac zzacVar, com.google.android.gms.common.api.Result result, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface LwcSGAtRqIIBTUoO(com.google.android.gms.internal.auth.zzam zzamVar) {
        return zzamVar.getService();
    }

    public static void LwcSGAtRqIIBTUoO(com.google.android.gms.internal.auth.zzam zzamVar, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LwcSGAtRqIIBTUoO(com.google.android.gms.internal.auth.zzam zzamVar, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwcSGAtRqIIBTUoO(com.google.android.gms.internal.auth.zzam zzamVar, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOlotiSQPHQdVxRh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static void OOlotiSQPHQdVxRh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OOlotiSQPHQdVxRh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OOlotiSQPHQdVxRh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.auth.zzaj(status);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        BsamXympokicjRhM((com.google.android.gms.auth.account.zze) LwcSGAtRqIIBTUoO((com.google.android.gms.internal.auth.zzam) api$AnyClient), this.zza);
        FRHnZymvfBvOCLCm(this, new com.google.android.gms.internal.auth.zzaj(com.google.android.gms.common.api.Status.RESULT_SUCCESS));
    }

    public override readonly void SetResult(java.lang.object obj) {
        OOlotiSQPHQdVxRh(this, (com.google.android.gms.common.api.Result) obj);
    }
}

