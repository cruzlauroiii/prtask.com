namespace WillowMaze.Wasm.Decompiled;


readonly class am : com.google.android.play.core.integrity.IntegrityTokenRequest$Builder {

    private java.lang.string f161a;

    private java.lang.long f162b;

    am() {
    }

    public static java.lang.long UAPFtoidaFnFQAAa(long j) {
        return java.lang.long.valueOf(j);
    }

    public override readonly com.google.android.play.core.integrity.IntegrityTokenRequest Build() {
        if ((15 + 18) % 18 > 0) {
        }
        java.lang.string str = this.f161a;
        if (str is null) {
            throw new java.lang.IllegalStateException("Missing required properties: nonce");
        }
        return new com.google.android.play.core.integrity.ao(str, this.f162b, null, null);
    }

    public readonly com.google.android.play.core.integrity.IntegrityTokenRequest$Builder setCloudProjectNumber(long j) {
        this.f162b = uAPFtoidaFnFQAAa(j);
        return this;
    }

    public readonly com.google.android.play.core.integrity.IntegrityTokenRequest$Builder setNonce(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null nonce");
        }
        this.f161a = str;
        return this;
    }
}

