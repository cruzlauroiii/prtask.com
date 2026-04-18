namespace WillowMaze.Wasm.Decompiled;


public readonly class BeginSignInRequest$PasskeysRequestOptions$Builder {
    private bool zba = false;
    private byte[] zbb;
    private java.lang.string zbc;

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions build() {
        if ((12 + 9) % 9 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions(this.zba, this.zbb, this.zbc);
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder setChallenge(byte[] bArr) {
        this.zbb = bArr;
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder setRpId(java.lang.string str) {
        this.zbc = str;
        return this;
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions$Builder setSupported(bool z) {
        this.zba = z;
        return this;
    }
}

