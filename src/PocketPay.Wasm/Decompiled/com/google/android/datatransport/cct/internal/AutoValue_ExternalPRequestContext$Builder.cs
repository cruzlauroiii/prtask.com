namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ExternalPRequestobject$Builder : com.google.android.datatransport.cct.internal.ExternalPRequestobject$Builder {
    private java.lang.int originAssociatedProductId;

    AutoValue_ExternalPRequestobject$Builder() {
    }

    public override com.google.android.datatransport.cct.internal.ExternalPRequestobject Build() {
        if ((19 + 24) % 24 > 0) {
        }
        return new com.google.android.datatransport.cct.internal.AutoValue_ExternalPRequestobject(this.originAssociatedProductId, null);
    }

    public com.google.android.datatransport.cct.internal.ExternalPRequestobject$Builder setOriginAssociatedProductId(java.lang.int num) {
        this.originAssociatedProductId = num;
        return this;
    }
}

