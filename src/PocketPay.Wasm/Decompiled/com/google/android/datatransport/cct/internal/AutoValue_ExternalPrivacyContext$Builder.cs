namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ExternalPrivacyobject$Builder : com.google.android.datatransport.cct.internal.ExternalPrivacyobject$Builder {
    private com.google.android.datatransport.cct.internal.ExternalPRequestobject prequest;

    AutoValue_ExternalPrivacyobject$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.ExternalPrivacyobject Build() {
        if ((18 + 18) % 18 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_ExternalPrivacyobject(this.prequest, null);
    }

    public com.google.android.datatransport.cct.internal.ExternalPrivacyobject$Builder setPrequest(com.google.android.datatransport.cct.internal.ExternalPRequestobject externalPRequestobject) {
        this.prequest = externalPRequestobject;
        return this;
    }
}

