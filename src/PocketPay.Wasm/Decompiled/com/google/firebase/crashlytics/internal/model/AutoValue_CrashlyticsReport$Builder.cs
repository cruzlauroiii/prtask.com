namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder {
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo appExitInfo;
    private java.lang.string appQualitySessionId;
    private java.lang.string buildVersion;
    private java.lang.string displayVersion;
    private java.lang.string firebaseAuthenticationToken;
    private java.lang.string firebaseInstallationId;
    private java.lang.string gmpAppId;
    private java.lang.string installationUuid;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload ndkPayload;
    private int platform;
    private java.lang.string sdkVersion;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session session;
    private byte set$0;

    AutoValue_CrashlyticsReport$Builder() {
    }

    private AutoValue_CrashlyticsReport$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        this.sdkVersion = kwXfPsYcUpcKrnnM(crashlyticsReport);
        this.gmpAppId = QEjHfocivZKYRPGM(crashlyticsReport);
        this.platform = LDYbGfDwmBZGuZOE(crashlyticsReport);
        this.installationUuid = VSMELxOWOdWbiTNd(crashlyticsReport);
        this.firebaseInstallationId = rPgeKTEiADZZmKzL(crashlyticsReport);
        this.firebaseAuthenticationToken = GuZBJFYYwzEhwOap(crashlyticsReport);
        this.appQualitySessionId = vRHkwKBjzgungnle(crashlyticsReport);
        this.buildVersion = ampFLELatEWAuenj(crashlyticsReport);
        this.displayVersion = DxvxCMrQJHguzTBr(crashlyticsReport);
        this.session = tPyglHZCGIafFjqc(crashlyticsReport);
        this.ndkPayload = IqyPFMhspmLuBqzj(crashlyticsReport);
        this.appExitInfo = FgXBASTYcCgJIFes(crashlyticsReport);
        this.set$0 = (byte) 1;
    }

    AutoValue_CrashlyticsReport$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport$1 autoValue_CrashlyticsReport$1) {
        this(crashlyticsReport);
    }

    public static java.lang.string BoquVbuIsjelbRdf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BoquVbuIsjelbRdf(java.lang.stringBuilder sb, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BoquVbuIsjelbRdf(java.lang.stringBuilder sb, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BoquVbuIsjelbRdf(java.lang.stringBuilder sb, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DxvxCMrQJHguzTBr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getDisplayVersion();
    }

    public static void DxvxCMrQJHguzTBr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxvxCMrQJHguzTBr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DxvxCMrQJHguzTBr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo FgXBASTYcCgJIFes(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getAppExitInfo();
    }

    public static void FgXBASTYcCgJIFes(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FgXBASTYcCgJIFes(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FgXBASTYcCgJIFes(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GuZBJFYYwzEhwOap(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getFirebaseAuthenticationToken();
    }

    public static void GuZBJFYYwzEhwOap(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GuZBJFYYwzEhwOap(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GuZBJFYYwzEhwOap(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload IqyPFMhspmLuBqzj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getNdkPayload();
    }

    public static void IqyPFMhspmLuBqzj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IqyPFMhspmLuBqzj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IqyPFMhspmLuBqzj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LDYbGfDwmBZGuZOE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getPlatform();
    }

    public static void LDYbGfDwmBZGuZOE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LDYbGfDwmBZGuZOE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LDYbGfDwmBZGuZOE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LvRwmwjcDnbEETJh(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void LvRwmwjcDnbEETJh(java.lang.stringBuilder sb, java.lang.object obj, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LvRwmwjcDnbEETJh(java.lang.stringBuilder sb, java.lang.object obj, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvRwmwjcDnbEETJh(java.lang.stringBuilder sb, java.lang.object obj, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QEjHfocivZKYRPGM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getGmpAppId();
    }

    public static void QEjHfocivZKYRPGM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QEjHfocivZKYRPGM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEjHfocivZKYRPGM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VSMELxOWOdWbiTNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getInstallationUuid();
    }

    public static void VSMELxOWOdWbiTNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSMELxOWOdWbiTNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VSMELxOWOdWbiTNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AmpFLELatEWAuenj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getBuildVersion();
    }

    public static void AmpFLELatEWAuenj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AmpFLELatEWAuenj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AmpFLELatEWAuenj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BsItiIgpeSUKEcbG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BsItiIgpeSUKEcbG(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BsItiIgpeSUKEcbG(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BsItiIgpeSUKEcbG(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GPdrqPNwdQXiEzhq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GPdrqPNwdQXiEzhq(java.lang.stringBuilder sb, java.lang.string str, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GPdrqPNwdQXiEzhq(java.lang.stringBuilder sb, java.lang.string str, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GPdrqPNwdQXiEzhq(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HJAMBdKyrArivRGU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HJAMBdKyrArivRGU(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HJAMBdKyrArivRGU(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HJAMBdKyrArivRGU(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KwXfPsYcUpcKrnnM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getSdkVersion();
    }

    public static void KwXfPsYcUpcKrnnM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KwXfPsYcUpcKrnnM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KwXfPsYcUpcKrnnM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LCOhKJCUcUzVfLfm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LCOhKJCUcUzVfLfm(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LCOhKJCUcUzVfLfm(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCOhKJCUcUzVfLfm(java.lang.stringBuilder sb, java.lang.string str, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MEAsxRrHkseabAvZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MEAsxRrHkseabAvZ(java.lang.stringBuilder sb, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MEAsxRrHkseabAvZ(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MEAsxRrHkseabAvZ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RPgeKTEiADZZmKzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getFirebaseInstallationId();
    }

    public static void RPgeKTEiADZZmKzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RPgeKTEiADZZmKzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RPgeKTEiADZZmKzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session tPyglHZCGIafFjqc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getSession();
    }

    public static void TPyglHZCGIafFjqc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TPyglHZCGIafFjqc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TPyglHZCGIafFjqc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VBcpyZYawFDKdSug(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VBcpyZYawFDKdSug(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VBcpyZYawFDKdSug(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VBcpyZYawFDKdSug(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VRHkwKBjzgungnle(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getAppQualitySessionId();
    }

    public static void VRHkwKBjzgungnle(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRHkwKBjzgungnle(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VRHkwKBjzgungnle(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override com.google.firebase.crashlytics.internal.model.CrashlyticsReport Build() {
        if ((28 + 32) % 32 > 0) {
        }
        if (this.set$0 == 1 && this.sdkVersion is not null && this.gmpAppId is not null && this.installationUuid is not null && this.buildVersion is not null && this.displayVersion is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport(this.sdkVersion, this.gmpAppId, this.platform, this.installationUuid, this.firebaseInstallationId, this.firebaseAuthenticationToken, this.appQualitySessionId, this.buildVersion, this.displayVersion, this.session, this.ndkPayload, this.appExitInfo, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.sdkVersion is null) {
            bsItiIgpeSUKEcbG(sb, " sdkVersion");
        }
        if (this.gmpAppId is null) {
            hJAMBdKyrArivRGU(sb, " gmpAppId");
        }
        if ((1 & this.set$0) == 0) {
            mEAsxRrHkseabAvZ(sb, " platform");
        }
        if (this.installationUuid is null) {
            vBcpyZYawFDKdSug(sb, " installationUuid");
        }
        if (this.buildVersion is null) {
            lCOhKJCUcUzVfLfm(sb, " buildVersion");
        }
        if (this.displayVersion is null) {
            gPdrqPNwdQXiEzhq(sb, " displayVersion");
        }
        throw new java.lang.IllegalStateException(BoquVbuIsjelbRdf(LvRwmwjcDnbEETJh(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setAppExitInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        this.appExitInfo = crashlyticsReport$ApplicationExitInfo;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setAppQualitySessionId(java.lang.string str) {
        this.appQualitySessionId = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setBuildVersion(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null buildVersion");
        }
        this.buildVersion = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setDisplayVersion(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null displayVersion");
        }
        this.displayVersion = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setFirebaseAuthenticationToken(java.lang.string str) {
        this.firebaseAuthenticationToken = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setFirebaseInstallationId(java.lang.string str) {
        this.firebaseInstallationId = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setGmpAppId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null gmpAppId");
        }
        this.gmpAppId = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setInstallationUuid(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null installationUuid");
        }
        this.installationUuid = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setNdkPayload(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload) {
        this.ndkPayload = crashlyticsReport$stringsPayload;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setPlatform(int i) {
        this.platform = i;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setSdkVersion(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null sdkVersion");
        }
        this.sdkVersion = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder setSession(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        this.session = crashlyticsReport$Session;
        return this;
    }
}

