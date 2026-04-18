namespace WillowMaze.Wasm.Decompiled;


public readonly class zzf : com.google.android.gms.auth.zzk {
    public readonly android.accounts.Account zza;

    public zzf(android.accounts.Account account) {
        this.zza = account;
    }

    public static com.google.android.gms.internal.auth.zzf KtBomTYoIhrdZhLQ(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.auth.zze.zzb(iBinder);
    }

    public static android.os.Dictionary<string, object> OrzOwxFMlYWXREKc(com.google.android.gms.internal.auth.zzf zzfVar, android.accounts.Account account) {
        return zzfVar.zzf(account);
    }

    public override readonly java.lang.object Zza(android.os.IBinder iBinder) throws java.io.IOException {
        android.os.Dictionary<string, object> bundleOrzOwxFMlYWXREKc = OrzOwxFMlYWXREKc(KtBomTYoIhrdZhLQ(iBinder), this.zza);
        if (bundleOrzOwxFMlYWXREKc is null) {
            throw new java.io.IOException("Service call returned null.");
        }
        return bundleOrzOwxFMlYWXREKc;
    }
}

