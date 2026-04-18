namespace WillowMaze.Wasm.Decompiled;


readonly class zzag : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl {
    readonly android.accounts.Account zza;

    zzag(com.google.android.gms.internal.auth.zzal zzalVar, com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.GoogleApiClient googleApiClient, android.accounts.Account account) {
        super((com.google.android.gms.common.api.Api<object>) api, googleApiClient);
        this.zza = account;
    }

    public static void HNGizoAYwGZISNfo(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, android.accounts.Account account) throws android.os.RemoteException {
        zzeVar.zze(zzbVar, account);
    }

    public static void HNGizoAYwGZISNfo(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, android.accounts.Account account, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNGizoAYwGZISNfo(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, android.accounts.Account account, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNGizoAYwGZISNfo(com.google.android.gms.auth.account.zze zzeVar, com.google.android.gms.auth.account.zzb zzbVar, android.accounts.Account account, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IInterface IKPVXUcUYODHvxMi(com.google.android.gms.internal.auth.zzam zzamVar) {
        return zzamVar.getService();
    }

    public static void IKPVXUcUYODHvxMi(com.google.android.gms.internal.auth.zzam zzamVar, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IKPVXUcUYODHvxMi(com.google.android.gms.internal.auth.zzam zzamVar, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IKPVXUcUYODHvxMi(com.google.android.gms.internal.auth.zzam zzamVar, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LbIgAzGkmVwkoUyh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result) {
        super.setResult(result);
    }

    public static void LbIgAzGkmVwkoUyh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LbIgAzGkmVwkoUyh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LbIgAzGkmVwkoUyh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Result result, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    protected override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.internal.auth.zzak(status);
    }

    protected override readonly void DoExecute(com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.RemoteException {
        HNGizoAYwGZISNfo((com.google.android.gms.auth.account.zze) iKPVXUcUYODHvxMi((com.google.android.gms.internal.auth.zzam) api$AnyClient), new com.google.android.gms.internal.auth.zzaf(this), this.zza);
    }

    public override readonly void SetResult(java.lang.object obj) {
        lbIgAzGkmVwkoUyh(this, (com.google.android.gms.common.api.Result) obj);
    }
}

