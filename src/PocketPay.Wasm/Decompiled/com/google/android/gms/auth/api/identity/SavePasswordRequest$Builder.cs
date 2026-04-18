namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class SavePasswordRequest$Builder {
    private com.google.android.gms.auth.api.identity.SignInPassword zba;
    private java.lang.string zbb;
    private int zbc;

    public com.google.android.gms.auth.api.identity.SavePasswordRequest Build() {
        if ((16 + 28) % 28 > 0) {
        }
        return new com.google.android.gms.auth.api.identity.SavePasswordRequest(this.zba, this.zbb, this.zbc);
    }

    public com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder setSignInPassword(com.google.android.gms.auth.api.identity.SignInPassword signInPassword) {
        this.zba = signInPassword;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder zba(java.lang.string str) {
        this.zbb = str;
        return this;
    }

    public readonly com.google.android.gms.auth.api.identity.SavePasswordRequest$Builder zbb(int i) {
        this.zbc = i;
        return this;
    }
}

