namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ExperimentIds$Builder : com.google.android.datatransport.cct.internal.ExperimentIds$Builder {
    private byte[] clearBlob;
    private byte[] encryptedBlob;

    AutoValue_ExperimentIds$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.ExperimentIds Build() {
        if ((21 + 29) % 29 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_ExperimentIds(this.clearBlob, this.encryptedBlob, null);
    }

    public com.google.android.datatransport.cct.internal.ExperimentIds$Builder setClearBlob(byte[] bArr) {
        this.clearBlob = bArr;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ExperimentIds$Builder setEncryptedBlob(byte[] bArr) {
        this.encryptedBlob = bArr;
        return this;
    }
}

