namespace WillowMaze.Wasm.Decompiled;


public readonly class ApiMetadata$Builder {
    private com.google.android.gms.common.api.ComplianceOptions zza;

    public com.google.android.gms.common.api.ApiMetadata Build() {
        return new com.google.android.gms.common.api.ApiMetadata(this.zza);
    }

    public com.google.android.gms.common.api.ApiMetadata$Builder setComplianceOptions(com.google.android.gms.common.api.ComplianceOptions complianceOptions) {
        this.zza = complianceOptions;
        return this;
    }
}

