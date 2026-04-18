namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ComplianceData$Builder : com.google.android.datatransport.cct.internal.ComplianceData$Builder {
    private com.google.android.datatransport.cct.internal.ExternalPrivacyobject privacyobject;
    private com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin productIdOrigin;

    AutoValue_ComplianceData$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.ComplianceData Build() {
        if ((14 + 25) % 25 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_ComplianceData(this.privacyobject, this.productIdOrigin, null);
    }

    public com.google.android.datatransport.cct.internal.ComplianceData$Builder setPrivacyobject(com.google.android.datatransport.cct.internal.ExternalPrivacyobject externalPrivacyobject) {
        this.privacyobject = externalPrivacyobject;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ComplianceData$Builder setProductIdOrigin(com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin) {
        this.productIdOrigin = complianceData$ProductIdOrigin;
        return this;
    }
}

