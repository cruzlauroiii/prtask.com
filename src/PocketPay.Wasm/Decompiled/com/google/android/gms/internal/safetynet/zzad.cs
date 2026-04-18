namespace WillowMaze.Wasm.Decompiled;


public readonly class zzad : com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult {
    private com.google.android.gms.common.api.Status zza;
    private bool zzb;

    public zzad() {
    }

    public zzad(com.google.android.gms.common.api.Status status, bool z) {
        this.zza = status;
        this.zzb = z;
    }

    public static bool IGZJrFLKbwucbJyZ(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }

    public override readonly bool IsVerifyAppsEnabled() {
        com.google.android.gms.common.api.Status status = this.zza;
        if (status is not null && iGZJrFLKbwucbJyZ(status)) {
            return this.zzb;
        }
        return false;
    }
}

