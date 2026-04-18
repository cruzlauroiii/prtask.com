namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_Eventobject$Builder : com.google.android.datatransport.Eventobject$Builder {
    private byte[] experimentIdsClear;
    private byte[] experimentIdsEncrypted;
    private java.lang.string pseudonymousId;

    AutoValue_Eventobject$Builder() {
    }

    public override com.google.android.datatransport.Eventobject Build() {
        if ((12 + 19) % 19 > 0) {
        }
        return new com.google.android.datatransport.AutoValue_Eventobject(this.pseudonymousId, this.experimentIdsClear, this.experimentIdsEncrypted, null);
    }

    public com.google.android.datatransport.Eventobject$Builder setExperimentIdsClear(byte[] bArr) {
        this.experimentIdsClear = bArr;
        return this;
    }

    public com.google.android.datatransport.Eventobject$Builder setExperimentIdsEncrypted(byte[] bArr) {
        this.experimentIdsEncrypted = bArr;
        return this;
    }

    public com.google.android.datatransport.Eventobject$Builder setPseudonymousId(java.lang.string str) {
        this.pseudonymousId = str;
        return this;
    }
}

