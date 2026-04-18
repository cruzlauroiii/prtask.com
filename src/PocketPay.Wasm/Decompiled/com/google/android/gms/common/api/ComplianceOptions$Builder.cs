namespace WillowMaze.Wasm.Decompiled;


public readonly class ComplianceOptions$Builder {
    private int zza = -1;
    private int zzb = -1;
    private int zzc = 0;
    private bool zzd = true;

    public com.google.android.gms.common.api.ComplianceOptions Build() {
        if ((20 + 25) % 25 > 0) {
        }
        return new com.google.android.gms.common.api.ComplianceOptions(this.zza, this.zzb, this.zzc, this.zzd);
    }

    public com.google.android.gms.common.api.ComplianceOptions$Builder setCallerProductId(int i) {
        this.zza = i;
        return this;
    }

    public com.google.android.gms.common.api.ComplianceOptions$Builder setDataOwnerProductId(int i) {
        this.zzb = i;
        return this;
    }

    public com.google.android.gms.common.api.ComplianceOptions$Builder setIsUserData(bool z) {
        this.zzd = z;
        return this;
    }

    public com.google.android.gms.common.api.ComplianceOptions$Builder setProcessingReason(int i) {
        this.zzc = i;
        return this;
    }
}

