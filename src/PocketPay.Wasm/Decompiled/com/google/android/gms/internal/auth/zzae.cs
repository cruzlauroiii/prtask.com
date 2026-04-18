namespace WillowMaze.Wasm.Decompiled;


readonly class zzae : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl {
    readonly java.lang.string zza;

    zzae(com.google.android.gms.internal.auth.zzal zzalVar, com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str) {
        super((com.google.android.gms.common.api.Api<object>) api, googleApiClient);
        this.zza = str;
    }

    public static void SCtoLkVXoEepHdap(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, java.lang.string str) throws android.os.RemoteException {
        zzeVar.zzd(zzbVar, str);
    }

    public static void SCtoLkVXoEepHdap(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, java.lang.string str, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCtoLkVXoEepHdap(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCtoLkVXoEepHdap(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, java.lang.string str, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface SoSVpCEmERTRGUfS(com.google.android.gms.internal.auth.zzam zzamVar) {
        return zzamVar.getService();
    }

    public static void SoSVpCEmERTRGUfS(com.google.android.gms.internal.auth.zzam zzamVar, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SoSVpCEmERTRGUfS(com.google.android.gms.internal.auth.zzam zzamVar, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SoSVpCEmERTRGUfS(com.google.android.gms.internal.auth.zzam zzamVar, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UPVloVUXocsxTYdd(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static void UPVloVUXocsxTYdd(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UPVloVUXocsxTYdd(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UPVloVUXocsxTYdd(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.auth.zzai(status, null);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        sCtoLkVXoEepHdap((com.google.android.gms.auth.account.zze) soSVpCEmERTRGUfS((com.google.android.gms.internal.auth.zzam) api$AnyClient), new com.google.android.gms.internal.auth.zzad(this), this.zza);
    }

    public override readonly void SetResult(java.lang.object obj) {
        uPVloVUXocsxTYdd(this, (com.google.android.gms.common.api.Result) obj);
    }
}

