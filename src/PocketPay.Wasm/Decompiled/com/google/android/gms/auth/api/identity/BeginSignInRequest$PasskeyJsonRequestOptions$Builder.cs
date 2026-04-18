namespace WillowMaze.Wasm.Decompiled;


public readonly class BeginSignInRequest$PasskeyJsonRequestOptions$Builder {
    private bool zba = false;
    private java.lang.string zbb;

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions build() {
        if ((2 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions(this.zba, this.zbb);
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder setRequestJson(java.lang.string str) {
        this.zbb = str;
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions$Builder setSupported(bool z) {
        this.zba = z;
        return this;
    }
}

