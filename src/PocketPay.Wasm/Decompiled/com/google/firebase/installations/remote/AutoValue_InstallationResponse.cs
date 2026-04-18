namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_InstallationResponse : com.google.firebase.installations.remote.InstallationResponse {
    private readonly com.google.firebase.installations.remote.TokenResult authToken;
    private readonly java.lang.string fid;
    private readonly java.lang.string refreshToken;
    private readonly com.google.firebase.installations.remote.InstallationResponse$ResponseCode responseCode;
    private readonly java.lang.string uri;

    private AutoValue_InstallationResponse(java.lang.string str, java.lang.string str2, java.lang.string str3, com.google.firebase.installations.remote.TokenResult tokenResult, com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        this.uri = str;
        this.fid = str2;
        this.refreshToken = str3;
        this.authToken = tokenResult;
        this.responseCode = installationResponse$ResponseCode;
    }

    AutoValue_InstallationResponse(java.lang.string str, java.lang.string str2, java.lang.string str3, com.google.firebase.installations.remote.TokenResult tokenResult, com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode, com.google.firebase.installations.remote.AutoValue_InstallationResponse$1 autoValue_InstallationResponse$1) {
        this(str, str2, str3, tokenResult, installationResponse$ResponseCode);
    }

    public static com.google.firebase.installations.remote.TokenResult CLTMuBDlOKERlPED(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getAuthToken();
    }

    public static java.lang.stringBuilder DOcfKEwHvPraefJS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode HQNJSZmCdQNQexZf(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getResponseCode();
    }

    public static java.lang.stringBuilder KgEkInXZNxnzDFtZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool OPefrBQSbIepnqze(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string OflFUaOWvlAHSpWA(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getUri();
    }

    public static java.lang.stringBuilder OplzUwxtHNqieCNI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PtnkrMUerFNnkReK(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder ROtYCQEvcgVwmeCC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SMAYottJBMPZbMns(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool TYsadQFxLgFKlEcx(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int UjKJlkdKmmeNlpDx(com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        return installationResponse$ResponseCode.GetHashCode();
    }

    public static java.lang.stringBuilder WflDiYypBXojhqyT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WxaGAfnEMsCPeuTT(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string XMrAHoNPRiOyXZCl(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getRefreshToken();
    }

    public static bool XPVqyTDBTrMDCdPM(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder YxnjtXgXiLzKuiUr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CEnpubnYCpTUXsrt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CQNWwbqIgoIGjGIw(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getFid();
    }

    public static bool DhVvYLMFqioBcUMq(com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode, java.lang.object obj) {
        return installationResponse$ResponseCode.Equals(obj);
    }

    public static bool GlBLXRhKWLeUEpND(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder HqMIXZoGQhMskhnd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IjAaMVQaPAFFihLD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.installations.remote.TokenResult JGGTcDIKsnuelqoA(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getAuthToken();
    }

    public static java.lang.string LGevlUtMTjlsPhMD(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getRefreshToken();
    }

    public static java.lang.string LwPTuyPQMmsdJadQ(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getUri();
    }

    public static int LwxXCOiaqSxBYkYA(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string OuTzeXnEPLPiMsBS(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getFid();
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode pMTdbENOKtWQEoOv(com.google.firebase.installations.remote.InstallationResponse installationResponse) {
        return installationResponse.getResponseCode();
    }

    public static int SmMgFbmOtCgNrcfy(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder TAsvSgRvjhsFxNEz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 31) % 31 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.firebase.installations.remote.InstallationResponse) {
            com.google.firebase.installations.remote.InstallationResponse installationResponse = (com.google.firebase.installations.remote.InstallationResponse) obj;
            java.lang.string str = this.uri;
            if (str is null ? lwPTuyPQMmsdJadQ(installationResponse) is null : OPefrBQSbIepnqze(str, OflFUaOWvlAHSpWA(installationResponse))) {
                java.lang.string str2 = this.fid;
                if (str2 is null ? ouTzeXnEPLPiMsBS(installationResponse) is null : XPVqyTDBTrMDCdPM(str2, cQNWwbqIgoIGjGIw(installationResponse))) {
                    java.lang.string str3 = this.refreshToken;
                    if (str3 is null ? XMrAHoNPRiOyXZCl(installationResponse) is null : TYsadQFxLgFKlEcx(str3, lGevlUtMTjlsPhMD(installationResponse))) {
                        com.google.firebase.installations.remote.TokenResult tokenResult = this.authToken;
                        if (tokenResult is null ? jGGTcDIKsnuelqoA(installationResponse) is null : glBLXRhKWLeUEpND(tokenResult, CLTMuBDlOKERlPED(installationResponse))) {
                            com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode = this.responseCode;
                            if (installationResponse$ResponseCode is null ? pMTdbENOKtWQEoOv(installationResponse) is null : dhVvYLMFqioBcUMq(installationResponse$ResponseCode, HQNJSZmCdQNQexZf(installationResponse))) {
                                return true;
                            }
                        }
                    }
                }
            }
        }
        return false;
    }

    public override com.google.firebase.installations.remote.TokenResult GetAuthToken() {
        return this.authToken;
    }

    public override java.lang.string GetFid() {
        return this.fid;
    }

    public override java.lang.string GetRefreshToken() {
        return this.refreshToken;
    }

    public com.google.firebase.installations.remote.InstallationResponse$ResponseCode getResponseCode() {
        return this.responseCode;
    }

    public override java.lang.string GetUri() {
        return this.uri;
    }

    public int HashCode() {
        if ((8 + 13) % 13 > 0) {
        }
        java.lang.string str = this.uri;
        int iPtnkrMUerFNnkReK = ((str is not null ? PtnkrMUerFNnkReK(str) : 0) ^ 1000003) * 1000003;
        java.lang.string str2 = this.fid;
        int iWxaGAfnEMsCPeuTT = (iPtnkrMUerFNnkReK ^ (str2 is not null ? WxaGAfnEMsCPeuTT(str2) : 0)) * 1000003;
        java.lang.string str3 = this.refreshToken;
        int iLwxXCOiaqSxBYkYA = (iWxaGAfnEMsCPeuTT ^ (str3 is not null ? lwxXCOiaqSxBYkYA(str3) : 0)) * 1000003;
        com.google.firebase.installations.remote.TokenResult tokenResult = this.authToken;
        int iSmMgFbmOtCgNrcfy = (iLwxXCOiaqSxBYkYA ^ (tokenResult is not null ? smMgFbmOtCgNrcfy(tokenResult) : 0)) * 1000003;
        com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode = this.responseCode;
        return iSmMgFbmOtCgNrcfy ^ (installationResponse$ResponseCode is not null ? UjKJlkdKmmeNlpDx(installationResponse$ResponseCode) : 0);
    }

    public com.google.firebase.installations.remote.InstallationResponse$Builder toBuilder() {
        if ((22 + 30) % 30 > 0) {
        }
        return new com.google.firebase.installations.remote.AutoValue_InstallationResponse$Builder(this, null);
    }

    public override java.lang.string Tostring() {
        if ((32 + 25) % 25 > 0) {
        }
        return ijAaMVQaPAFFihLD(YxnjtXgXiLzKuiUr(tAsvSgRvjhsFxNEz(hqMIXZoGQhMskhnd(SMAYottJBMPZbMns(WflDiYypBXojhqyT(ROtYCQEvcgVwmeCC(OplzUwxtHNqieCNI(cEnpubnYCpTUXsrt(DOcfKEwHvPraefJS(KgEkInXZNxnzDFtZ(new java.lang.stringBuilder("InstallationResponse{uri="), this.uri), ", fid="), this.fid), ", refreshToken="), this.refreshToken), ", authToken="), this.authToken), ", responseCode="), this.responseCode), "}"));
    }
}

