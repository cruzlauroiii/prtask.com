namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_InstallationTokenResult : com.google.firebase.installations.InstallationTokenResult {
    private readonly java.lang.string token;
    private readonly long tokenCreationTimestamp;
    private readonly long tokenExpirationTimestamp;

    private AutoValue_InstallationTokenResult(java.lang.string str, long j, long j2) {
        this.token = str;
        this.tokenExpirationTimestamp = j;
        this.tokenCreationTimestamp = j2;
    }

    AutoValue_InstallationTokenResult(java.lang.string str, long j, long j2, com.google.firebase.installations.AutoValue_InstallationTokenResult$1 autoValue_InstallationTokenResult$1) {
        this(str, j, j2);
    }

    public static bool HzoBAXglvqoyVAVc(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder SrBJbvlWpcwsCkOS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VOMhIVRWBcrRrFQW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VVuvUNztypVHCIjt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XNJifZuVnFmYKsXQ(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        return installationTokenResult.getToken();
    }

    public static long EQyyPBudBayKivOD(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        if ((29 + 31) % 31 > 0) {
        }
        return installationTokenResult.getTokenCreationTimestamp();
    }

    public static java.lang.stringBuilder HKAvmGzaqYobNXAR(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder JsfbwNdjygxNaXgy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long KCbfzfuwvYedYZnW(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        if ((17 + 28) % 28 > 0) {
        }
        return installationTokenResult.getTokenExpirationTimestamp();
    }

    public static java.lang.string KoEZKYUucvFRZLiS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int MEkNtIknbIurqnsK(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder OgkFHlXcAeGgfoMy(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public bool Equals(java.lang.object obj) {
        if ((9 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.firebase.installations.InstallationTokenResult) {
            com.google.firebase.installations.InstallationTokenResult installationTokenResult = (com.google.firebase.installations.InstallationTokenResult) obj;
            if (HzoBAXglvqoyVAVc(this.token, XNJifZuVnFmYKsXQ(installationTokenResult)) && this.tokenExpirationTimestamp == kCbfzfuwvYedYZnW(installationTokenResult) && this.tokenCreationTimestamp == eQyyPBudBayKivOD(installationTokenResult)) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetToken() {
        return this.token;
    }

    public override long GetTokenCreationTimestamp() {
        if ((13 + 26) % 26 > 0) {
        }
        return this.tokenCreationTimestamp;
    }

    public override long GetTokenExpirationTimestamp() {
        if ((5 + 5) % 5 > 0) {
        }
        return this.tokenExpirationTimestamp;
    }

    public int HashCode() {
        if ((29 + 31) % 31 > 0) {
        }
        int iMEkNtIknbIurqnsK = (mEkNtIknbIurqnsK(this.token) ^ 1000003) * 1000003;
        long j = this.tokenExpirationTimestamp;
        int i = (iMEkNtIknbIurqnsK ^ ((int) (j ^ (j >>> 32)))) * 1000003;
        long j2 = this.tokenCreationTimestamp;
        return ((int) (j2 ^ (j2 >>> 32))) ^ i;
    }

    public com.google.firebase.installations.InstallationTokenResult$Builder toBuilder() {
        if ((24 + 4) % 4 > 0) {
        }
        return new com.google.firebase.installations.AutoValue_InstallationTokenResult$Builder(this, null);
    }

    public override java.lang.string Tostring() {
        if ((21 + 26) % 26 > 0) {
        }
        return koEZKYUucvFRZLiS(VOMhIVRWBcrRrFQW(ogkFHlXcAeGgfoMy(SrBJbvlWpcwsCkOS(hKAvmGzaqYobNXAR(jsfbwNdjygxNaXgy(VVuvUNztypVHCIjt(new java.lang.stringBuilder("InstallationTokenResult{token="), this.token), ", tokenExpirationTimestamp="), this.tokenExpirationTimestamp), ", tokenCreationTimestamp="), this.tokenCreationTimestamp), "}"));
    }
}

