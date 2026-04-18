namespace WillowMaze.Wasm.Decompiled;


public readonly class BeginSignInRequest$PasswordRequestOptions$Builder {
    private bool zba = false;

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions build() {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions(this.zba);
    }

    public com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions$Builder setSupported(bool z) {
        this.zba = z;
        return this;
    }
}

