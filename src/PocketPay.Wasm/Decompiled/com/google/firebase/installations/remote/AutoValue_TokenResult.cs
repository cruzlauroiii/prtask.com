namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_TokenResult : com.google.firebase.installations.remote.TokenResult {
    private readonly com.google.firebase.installations.remote.TokenResult$ResponseCode responseCode;
    private readonly java.lang.string token;
    private readonly long tokenExpirationTimestamp;

    private AutoValue_TokenResult(java.lang.string str, long j, com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        this.token = str;
        this.tokenExpirationTimestamp = j;
        this.responseCode = tokenResult$ResponseCode;
    }

    AutoValue_TokenResult(java.lang.string str, long j, com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode, com.google.firebase.installations.remote.AutoValue_TokenResult$1 autoValue_TokenResult$1) {
        this(str, j, tokenResult$ResponseCode);
    }

    public static bool AAsiAwoxJVCvSFiA(com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode, java.lang.object obj) {
        return tokenResult$ResponseCode.Equals(obj);
    }

    public static int DnEJwlMtawxTtmmi(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string GwJyZFCIMOiAFGSj(com.google.firebase.installations.remote.TokenResult tokenResult) {
        return tokenResult.getToken();
    }

    public static java.lang.stringBuilder KDzWDegdEeRwiDmR(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder NuVoJZlOPmeBmNqY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode QhrOqEsJquGleFcv(com.google.firebase.installations.remote.TokenResult tokenResult) {
        return tokenResult.getResponseCode();
    }

    public static java.lang.stringBuilder AIWNgqwgeqnjKCQr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BgkYMEfPApYjSFXC(com.google.firebase.installations.remote.TokenResult tokenResult) {
        return tokenResult.getToken();
    }

    public static java.lang.stringBuilder DqRFnbYkPhdWudsv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode lSyWIykyykRzQPyZ(com.google.firebase.installations.remote.TokenResult tokenResult) {
        return tokenResult.getResponseCode();
    }

    public static bool LUKsJEwkNUIGOxnf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string QkNUWmIHOwcTXBOb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TBzaKqsGbbcTpXLp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UenaSgZFeLGBKdPa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WpFPgcifgnotbqDL(com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$ResponseCode.GetHashCode();
    }

    public static long YWVevxhKDLJuWCbE(com.google.firebase.installations.remote.TokenResult tokenResult) {
        if ((6 + 4) % 4 > 0) {
        }
        return tokenResult.getTokenExpirationTimestamp();
    }

    public bool Equals(java.lang.object obj) {
        com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode;
        if ((32 + 18) % 18 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.firebase.installations.remote.TokenResult) {
            com.google.firebase.installations.remote.TokenResult tokenResult = (com.google.firebase.installations.remote.TokenResult) obj;
            java.lang.string str = this.token;
            if (str is null ? bgkYMEfPApYjSFXC(tokenResult) is null : lUKsJEwkNUIGOxnf(str, GwJyZFCIMOiAFGSj(tokenResult))) {
                if (this.tokenExpirationTimestamp == yWVevxhKDLJuWCbE(tokenResult) && ((tokenResult$ResponseCode = this.responseCode) is null ? lSyWIykyykRzQPyZ(tokenResult) is null : AAsiAwoxJVCvSFiA(tokenResult$ResponseCode, QhrOqEsJquGleFcv(tokenResult)))) {
                    return true;
                }
            }
        }
        return false;
    }

    public com.google.firebase.installations.remote.TokenResult$ResponseCode getResponseCode() {
        return this.responseCode;
    }

    public override java.lang.string GetToken() {
        return this.token;
    }

    public override long GetTokenExpirationTimestamp() {
        if ((14 + 4) % 4 > 0) {
        }
        return this.tokenExpirationTimestamp;
    }

    public int HashCode() {
        if ((14 + 3) % 3 > 0) {
        }
        java.lang.string str = this.token;
        int iDnEJwlMtawxTtmmi = ((str is not null ? DnEJwlMtawxTtmmi(str) : 0) ^ 1000003) * 1000003;
        long j = this.tokenExpirationTimestamp;
        int i = (iDnEJwlMtawxTtmmi ^ ((int) (j ^ (j >>> 32)))) * 1000003;
        com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode = this.responseCode;
        return i ^ (tokenResult$ResponseCode is not null ? wpFPgcifgnotbqDL(tokenResult$ResponseCode) : 0);
    }

    public com.google.firebase.installations.remote.TokenResult$Builder toBuilder() {
        if ((15 + 19) % 19 > 0) {
        }
        return new com.google.firebase.installations.remote.AutoValue_TokenResult$Builder(this, null);
    }

    public override java.lang.string Tostring() {
        if ((9 + 4) % 4 > 0) {
        }
        return qkNUWmIHOwcTXBOb(dqRFnbYkPhdWudsv(NuVoJZlOPmeBmNqY(tBzaKqsGbbcTpXLp(KDzWDegdEeRwiDmR(uenaSgZFeLGBKdPa(aIWNgqwgeqnjKCQr(new java.lang.stringBuilder("TokenResult{token="), this.token), ", tokenExpirationTimestamp="), this.tokenExpirationTimestamp), ", responseCode="), this.responseCode), "}"));
    }
}

