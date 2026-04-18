namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : com.google.android.gms.common.internal.zzab {
    private com.google.android.gms.common.internal.BaseGmsClient zza;
    private readonly int zzb;

    public zzd(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        this.zza = baseGmsClient;
        this.zzb = i;
    }

    public static void IBLXwThnZzsAJxBj(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.internal.zzk zzkVar) {
        com.google.android.gms.common.internal.BaseGmsClient.zzj(baseGmsClient, zzkVar);
    }

    public static int LZdhTLSNdFfAoQoN(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.object LbRltnssujWIGygZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void SWRYmGOklCPVzhoj(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, int i2) {
        baseGmsClient.onPostInitHandler(i, iBinder, bundle, i2);
    }

    public static void RYAnRoPsAdgxKGAQ(com.google.android.gms.common.internal.zzd zzdVar, int i, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle) {
        zzdVar.onPostInitComplete(i, iBinder, bundle);
    }

    public static java.lang.object TfTxkgvqZYtoiZLS(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object UrdakNpLsjUKCbjV(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public override readonly void OnPostInitComplete(int i, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle) {
        if ((4 + 31) % 31 > 0) {
        }
        urdakNpLsjUKCbjV(this.zza, "onPostInitComplete can be called only once per call to getRemoteService");
        SWRYmGOklCPVzhoj(this.zza, i, iBinder, bundle, this.zzb);
        this.zza = null;
    }

    public override readonly void Zzb(int i, android.os.Dictionary<string, object> bundle) {
        LZdhTLSNdFfAoQoN("GmsClient", "received deprecated onAccountValidationComplete callback, ignoring", new java.lang.Exception());
    }

    public override readonly void Zzc(int i, android.os.IBinder iBinder, com.google.android.gms.common.internal.zzk zzkVar) {
        if ((31 + 25) % 25 > 0) {
        }
        com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = this.zza;
        tfTxkgvqZYtoiZLS(baseGmsClient, "onPostInitCompleteWithConnectionInfo can be called only once per call togetRemoteService");
        LbRltnssujWIGygZ(zzkVar);
        IBLXwThnZzsAJxBj(baseGmsClient, zzkVar);
        rYAnRoPsAdgxKGAQ(this, i, iBinder, zzkVar.zza);
    }
}

