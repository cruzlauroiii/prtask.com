namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_TokenResult$Builder : com.google.firebase.installations.remote.TokenResult$Builder {
    private com.google.firebase.installations.remote.TokenResult$ResponseCode responseCode;
    private java.lang.string token;
    private java.lang.long tokenExpirationTimestamp;

    AutoValue_TokenResult$Builder() {
    }

    private AutoValue_TokenResult$Builder(com.google.firebase.installations.remote.TokenResult tokenResult) {
        if ((17 + 25) % 25 > 0) {
        }
        this.token = KFPGOvGRbHDGMWPm(tokenResult);
        this.tokenExpirationTimestamp = jHJHZMwCRYJzSXPf(IGIAFolDPEYNpkkN(tokenResult));
        this.responseCode = nzIcIuSnCxBJcBOV(tokenResult);
    }

    AutoValue_TokenResult$Builder(com.google.firebase.installations.remote.TokenResult tokenResult, com.google.firebase.installations.remote.AutoValue_TokenResult$1 autoValue_TokenResult$1) {
        this(tokenResult);
    }

    public static long HZbiyDuPwlpCyosR(java.lang.long l) {
        if ((2 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static long IGIAFolDPEYNpkkN(com.google.firebase.installations.remote.TokenResult tokenResult) {
        if ((16 + 18) % 18 > 0) {
        }
        return tokenResult.getTokenExpirationTimestamp();
    }

    public static bool JyHkuGsazHyDAOKL(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string KFPGOvGRbHDGMWPm(com.google.firebase.installations.remote.TokenResult tokenResult) {
        return tokenResult.getToken();
    }

    public static java.lang.stringBuilder ADFEiYpLOzedLkzc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long JHJHZMwCRYJzSXPf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string MpteuMpWKbDdONEm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.long NmiDDrLKuDMHOGjD(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode nzIcIuSnCxBJcBOV(com.google.firebase.installations.remote.TokenResult tokenResult) {
        return tokenResult.getResponseCode();
    }

    public override com.google.firebase.installations.remote.TokenResult Build() {
        if ((9 + 32) % 32 > 0) {
        }
        java.lang.string str = this.tokenExpirationTimestamp is not null ? "" : " tokenExpirationTimestamp";
        if (JyHkuGsazHyDAOKL(str)) {
            return new com.google.firebase.installations.remote.AutoValue_TokenResult(this.token, HZbiyDuPwlpCyosR(this.tokenExpirationTimestamp), this.responseCode, null);
        }
        throw new java.lang.IllegalStateException(mpteuMpWKbDdONEm(aDFEiYpLOzedLkzc(new java.lang.stringBuilder("Missing required properties:"), str)));
    }

    public com.google.firebase.installations.remote.TokenResult$Builder setResponseCode(com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        this.responseCode = tokenResult$ResponseCode;
        return this;
    }

    public com.google.firebase.installations.remote.TokenResult$Builder setToken(java.lang.string str) {
        this.token = str;
        return this;
    }

    public com.google.firebase.installations.remote.TokenResult$Builder setTokenExpirationTimestamp(long j) {
        this.tokenExpirationTimestamp = nmiDDrLKuDMHOGjD(j);
        return this;
    }
}

