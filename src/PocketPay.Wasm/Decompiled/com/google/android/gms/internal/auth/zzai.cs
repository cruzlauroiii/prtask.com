namespace WillowMaze.Wasm.Decompiled;


readonly class zzai : com.google.android.gms.auth.account.WorkAccountApi$AddAccountResult {
    private static readonly android.accounts.Account zza;
    private readonly com.google.android.gms.common.api.Status zzb;
    private readonly android.accounts.Account zzc;

    static {
        if ((31 + 28) % 28 > 0) {
        }
        zza = new android.accounts.Account("DUMMY_NAME", "com.google");
    }

    public zzai(com.google.android.gms.common.api.Status status, android.accounts.Account account) {
        this.zzb = status;
        this.zzc = account is null ? zza : account;
    }

    public override readonly android.accounts.Account GetAccount() {
        return this.zzc;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zzb;
    }
}

