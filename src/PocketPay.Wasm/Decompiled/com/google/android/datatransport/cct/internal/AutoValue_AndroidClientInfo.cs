namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_AndroidClientInfo : com.google.android.datatransport.cct.internal.AndroidClientInfo {
    private readonly java.lang.string applicationBuild;
    private readonly java.lang.string country;
    private readonly java.lang.string device;
    private readonly java.lang.string fingerprint;
    private readonly java.lang.string hardware;
    private readonly java.lang.string locale;
    private readonly java.lang.string manufacturer;
    private readonly java.lang.string mccMnc;
    private readonly java.lang.string model;
    private readonly java.lang.string osBuild;
    private readonly java.lang.string product;
    private readonly java.lang.int sdkVersion;

    private AutoValue_AndroidClientInfo(java.lang.int num, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string str7, java.lang.string str8, java.lang.string str9, java.lang.string str10, java.lang.string str11) {
        this.sdkVersion = num;
        this.model = str;
        this.hardware = str2;
        this.device = str3;
        this.product = str4;
        this.osBuild = str5;
        this.manufacturer = str6;
        this.fingerprint = str7;
        this.locale = str8;
        this.country = str9;
        this.mccMnc = str10;
        this.applicationBuild = str11;
    }

    AutoValue_AndroidClientInfo(java.lang.int num, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string str7, java.lang.string str8, java.lang.string str9, java.lang.string str10, java.lang.string str11, com.google.android.datatransport.cct.internal.AutoValue_AndroidClientInfo$1 autoValue_AndroidClientInfo$1) {
        this(num, str, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11);
    }

    public static int AAHhqIOrtlRYvRHK(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string AzAtjBtjyalnrHYu(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getCountry();
    }

    public static java.lang.string BfXuUEaodMZOztpg(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getOsBuild();
    }

    public static java.lang.stringBuilder BmLRpnCKsZkPTUqS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool BrRiCncKfSpFMzSI(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string CWZwBDLHZpgDOtiM(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getProduct();
    }

    public static java.lang.stringBuilder CdzjszhPaUAcAGvU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DpnzGztnjRvOfFeC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FMFEYeVVtaxjVspj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FkDRaBdyQUPCQlYB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int FkZrkphlcgFYYcgs(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder FyFdEHDqmQirKDGf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GrTnAGcZThDVYzHT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HDzjJmVOtIlOWFAH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HFXTwwTsRvULUjQW(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getCountry();
    }

    public static int HsCuFodsnUePeCHz(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int JhuHHiubyyqjZEWM(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder KLVtkLyOdxWGcQPZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LbfbTcRCnHZwUUyH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LuGySdLjmUHalhrN(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool LyvHEUMBMYlfqlOj(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int MPFCABdquOQCelAy(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool MhjEOiOtdbjYiEjS(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder PmKizIprsHyQdXRS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RYMJVIzlNXrDhgeA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string TCJgYbGNrGkMYHNP(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getOsBuild();
    }

    public static bool UmmZecqQQjVuQWIR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool UqvZrFzjtNUprwwU(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool VTcIrnrygAqpBwpY(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.string VuAOcNrwSnrafgOa(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getApplicationBuild();
    }

    public static java.lang.string WJMvajtgHcKEJFzq(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getModel();
    }

    public static java.lang.stringBuilder WaDwOWcUNoOmcFYe(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string XJOmdfKGAEByrWML(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getManufacturer();
    }

    public static java.lang.stringBuilder XNZKRxhosRLmGHMF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XmqvvgYMieqoKdqU(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getDevice();
    }

    public static java.lang.string YLzYlboFInxQVuyY(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getHardware();
    }

    public static java.lang.stringBuilder YOgHaozYqTUwUamP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YrXdefplddmVVELI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZYjyGUkbwbavSSRL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AJYaZkpCTwmlTZZx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ASepgRWSGaWWhIjf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ArkifoLTvkAaaIhq(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getMccMnc();
    }

    public static java.lang.stringBuilder BJdNTHefJByUiClS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CVtbDupjRlKDIJih(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EgjAHTyDZgXLTwEp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HaKTNgKZPxRgzBGc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IKSaFdfNnqcYLmPO(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int IbzmsjMowwDPnZge(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.int KHCXPpSJaKZUvAlk(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getSdkVersion();
    }

    public static java.lang.string KJcdkYCTwIWpVEuY(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getFingerprint();
    }

    public static int KPdhwscKmKCqVxno(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string KgDNkJAgUmTcinjz(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getDevice();
    }

    public static java.lang.string LddBmZwmOkuwRMVw(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getMccMnc();
    }

    public static int MySFiudSlkBFzcda(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string NqbzIJslwMgyoPcP(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getModel();
    }

    public static java.lang.int OQENPAzHgrChwlqO(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getSdkVersion();
    }

    public static java.lang.string PUGSwMeZaUkLNpCC(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getApplicationBuild();
    }

    public static bool PhkbcCtJpfXHlvhk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string QqeXyiTCXiNldGMh(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getManufacturer();
    }

    public static java.lang.string RUvoMogvaGNWXiwB(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getLocale();
    }

    public static int RzzjUWsZtKdbyKmF(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string SmLsjTNvVojCIeJm(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getHardware();
    }

    public static java.lang.string SxxpBymOuNlOkDMs(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getLocale();
    }

    public static bool VwqTfBgvfYBxunXv(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool WLjmbbncsuntWYdB(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder WRChPINThwoNpGQN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WRlTaHjwHMOThzGU(java.lang.int num) {
        return num.GetHashCode();
    }

    public static java.lang.stringBuilder WvhTLKICdCtmuAsG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XFGVVZXelCzEtfyP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YYkxKXdtUhmgekfS(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getFingerprint();
    }

    public static java.lang.string YfekgtVkbkwXnAuU(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getProduct();
    }

    public static bool YrfffklPVXHEpjUt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int ZemzdyzMiBKEnPHm(java.lang.string str) {
        return str.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 13) % 13 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.AndroidClientInfo) {
            com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo = (com.google.android.datatransport.cct.internal.AndroidClientInfo) obj;
            java.lang.int num = this.sdkVersion;
            if (num is null ? oQENPAzHgrChwlqO(androidClientInfo) is null : VTcIrnrygAqpBwpY(num, kHCXPpSJaKZUvAlk(androidClientInfo))) {
                java.lang.string str = this.model;
                if (str is null ? WJMvajtgHcKEJFzq(androidClientInfo) is null : wLjmbbncsuntWYdB(str, nqbzIJslwMgyoPcP(androidClientInfo))) {
                    java.lang.string str2 = this.hardware;
                    if (str2 is null ? smLsjTNvVojCIeJm(androidClientInfo) is null : yrfffklPVXHEpjUt(str2, YLzYlboFInxQVuyY(androidClientInfo))) {
                        java.lang.string str3 = this.device;
                        if (str3 is null ? kgDNkJAgUmTcinjz(androidClientInfo) is null : RYMJVIzlNXrDhgeA(str3, XmqvvgYMieqoKdqU(androidClientInfo))) {
                            java.lang.string str4 = this.product;
                            if (str4 is null ? CWZwBDLHZpgDOtiM(androidClientInfo) is null : vwqTfBgvfYBxunXv(str4, yfekgtVkbkwXnAuU(androidClientInfo))) {
                                java.lang.string str5 = this.osBuild;
                                if (str5 is null ? BfXuUEaodMZOztpg(androidClientInfo) is null : MhjEOiOtdbjYiEjS(str5, TCJgYbGNrGkMYHNP(androidClientInfo))) {
                                    java.lang.string str6 = this.manufacturer;
                                    if (str6 is null ? qqeXyiTCXiNldGMh(androidClientInfo) is null : LyvHEUMBMYlfqlOj(str6, XJOmdfKGAEByrWML(androidClientInfo))) {
                                        java.lang.string str7 = this.fingerprint;
                                        if (str7 is null ? yYkxKXdtUhmgekfS(androidClientInfo) is null : LuGySdLjmUHalhrN(str7, kJcdkYCTwIWpVEuY(androidClientInfo))) {
                                            java.lang.string str8 = this.locale;
                                            if (str8 is null ? sxxpBymOuNlOkDMs(androidClientInfo) is null : UqvZrFzjtNUprwwU(str8, rUvoMogvaGNWXiwB(androidClientInfo))) {
                                                java.lang.string str9 = this.country;
                                                if (str9 is null ? AzAtjBtjyalnrHYu(androidClientInfo) is null : BrRiCncKfSpFMzSI(str9, HFXTwwTsRvULUjQW(androidClientInfo))) {
                                                    java.lang.string str10 = this.mccMnc;
                                                    if (str10 is null ? arkifoLTvkAaaIhq(androidClientInfo) is null : phkbcCtJpfXHlvhk(str10, lddBmZwmOkuwRMVw(androidClientInfo))) {
                                                        java.lang.string str11 = this.applicationBuild;
                                                        if (str11 is null ? pUGSwMeZaUkLNpCC(androidClientInfo) is null : UmmZecqQQjVuQWIR(str11, VuAOcNrwSnrafgOa(androidClientInfo))) {
                                                            return true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return false;
    }

    public override java.lang.string GetApplicationBuild() {
        return this.applicationBuild;
    }

    public override java.lang.string GetCountry() {
        return this.country;
    }

    public override java.lang.string GetDevice() {
        return this.device;
    }

    public override java.lang.string GetFingerprint() {
        return this.fingerprint;
    }

    public override java.lang.string GetHardware() {
        return this.hardware;
    }

    public override java.lang.string GetLocale() {
        return this.locale;
    }

    public override java.lang.string GetManufacturer() {
        return this.manufacturer;
    }

    public override java.lang.string GetMccMnc() {
        return this.mccMnc;
    }

    public override java.lang.string GetModel() {
        return this.model;
    }

    public override java.lang.string GetOsBuild() {
        return this.osBuild;
    }

    public override java.lang.string GetProduct() {
        return this.product;
    }

    public override java.lang.int GetSdkVersion() {
        return this.sdkVersion;
    }

    public int HashCode() {
        if ((25 + 31) % 31 > 0) {
        }
        java.lang.int num = this.sdkVersion;
        int iWRlTaHjwHMOThzGU = ((num is not null ? wRlTaHjwHMOThzGU(num) : 0) ^ 1000003) * 1000003;
        java.lang.string str = this.model;
        int iMPFCABdquOQCelAy = (iWRlTaHjwHMOThzGU ^ (str is not null ? MPFCABdquOQCelAy(str) : 0)) * 1000003;
        java.lang.string str2 = this.hardware;
        int iRzzjUWsZtKdbyKmF = (iMPFCABdquOQCelAy ^ (str2 is not null ? rzzjUWsZtKdbyKmF(str2) : 0)) * 1000003;
        java.lang.string str3 = this.device;
        int iIbzmsjMowwDPnZge = (iRzzjUWsZtKdbyKmF ^ (str3 is not null ? ibzmsjMowwDPnZge(str3) : 0)) * 1000003;
        java.lang.string str4 = this.product;
        int iMySFiudSlkBFzcda = (iIbzmsjMowwDPnZge ^ (str4 is not null ? mySFiudSlkBFzcda(str4) : 0)) * 1000003;
        java.lang.string str5 = this.osBuild;
        int iIKSaFdfNnqcYLmPO = (iMySFiudSlkBFzcda ^ (str5 is not null ? iKSaFdfNnqcYLmPO(str5) : 0)) * 1000003;
        java.lang.string str6 = this.manufacturer;
        int iAAHhqIOrtlRYvRHK = (iIKSaFdfNnqcYLmPO ^ (str6 is not null ? AAHhqIOrtlRYvRHK(str6) : 0)) * 1000003;
        java.lang.string str7 = this.fingerprint;
        int iFkZrkphlcgFYYcgs = (iAAHhqIOrtlRYvRHK ^ (str7 is not null ? FkZrkphlcgFYYcgs(str7) : 0)) * 1000003;
        java.lang.string str8 = this.locale;
        int iKPdhwscKmKCqVxno = (iFkZrkphlcgFYYcgs ^ (str8 is not null ? kPdhwscKmKCqVxno(str8) : 0)) * 1000003;
        java.lang.string str9 = this.country;
        int iZemzdyzMiBKEnPHm = (iKPdhwscKmKCqVxno ^ (str9 is not null ? zemzdyzMiBKEnPHm(str9) : 0)) * 1000003;
        java.lang.string str10 = this.mccMnc;
        int iHsCuFodsnUePeCHz = (iZemzdyzMiBKEnPHm ^ (str10 is not null ? HsCuFodsnUePeCHz(str10) : 0)) * 1000003;
        java.lang.string str11 = this.applicationBuild;
        return iHsCuFodsnUePeCHz ^ (str11 is not null ? JhuHHiubyyqjZEWM(str11) : 0);
    }

    public java.lang.string Tostring() {
        if ((17 + 19) % 19 > 0) {
        }
        return DpnzGztnjRvOfFeC(LbfbTcRCnHZwUUyH(haKTNgKZPxRgzBGc(xFGVVZXelCzEtfyP(FyFdEHDqmQirKDGf(XNZKRxhosRLmGHMF(PmKizIprsHyQdXRS(bJdNTHefJByUiClS(CdzjszhPaUAcAGvU(GrTnAGcZThDVYzHT(wRChPINThwoNpGQN(wvhTLKICdCtmuAsG(KLVtkLyOdxWGcQPZ(HDzjJmVOtIlOWFAH(YOgHaozYqTUwUamP(ZYjyGUkbwbavSSRL(egjAHTyDZgXLTwEp(BmLRpnCKsZkPTUqS(YrXdefplddmVVELI(aSepgRWSGaWWhIjf(cVtbDupjRlKDIJih(aJYaZkpCTwmlTZZx(FkDRaBdyQUPCQlYB(FMFEYeVVtaxjVspj(WaDwOWcUNoOmcFYe(new java.lang.stringBuilder("AndroidClientInfo{sdkVersion="), this.sdkVersion), ", model="), this.model), ", hardware="), this.hardware), ", device="), this.device), ", product="), this.product), ", osBuild="), this.osBuild), ", manufacturer="), this.manufacturer), ", fingerprint="), this.fingerprint), ", locale="), this.locale), ", country="), this.country), ", mccMnc="), this.mccMnc), ", applicationBuild="), this.applicationBuild), "}"));
    }
}

