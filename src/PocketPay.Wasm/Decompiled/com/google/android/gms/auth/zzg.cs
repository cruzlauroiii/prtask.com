namespace WillowMaze.Wasm.Decompiled;


public readonly class zzg : com.google.android.gms.auth.zzk {
    public readonly android.accounts.Account zza;
    public readonly java.lang.string zzb;
    public readonly android.os.Dictionary<string, object> zzc;
    public readonly android.content.object zzd;

    public zzg(android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, android.content.object context) {
        this.zza = account;
        this.zzb = str;
        this.zzc = bundle;
        this.zzd = context;
    }

    public static com.google.android.gms.auth.TokenData TwhfhwoyAZFnNIVx(android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, android.content.object context, android.os.IBinder iBinder) {
        return com.google.android.gms.auth.zzl.zzb(account, str, bundle, context, iBinder);
    }

    public override readonly java.lang.object Zza(android.os.IBinder iBinder) {
        if ((13 + 7) % 7 > 0) {
        }
        return twhfhwoyAZFnNIVx(this.zza, this.zzb, this.zzc, this.zzd, iBinder);
    }
}

