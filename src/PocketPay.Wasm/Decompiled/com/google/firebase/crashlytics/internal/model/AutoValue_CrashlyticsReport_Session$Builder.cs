namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder {
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application app;
    private java.lang.string appQualitySessionId;
    private bool crashed;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device device;
    private java.lang.long endedAt;
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> events;
    private java.lang.string generator;
    private int generatorType;
    private java.lang.string identifier;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem os;
    private byte set$0;
    private long startedAt;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User user;

    AutoValue_CrashlyticsReport_Session$Builder() {
    }

    private AutoValue_CrashlyticsReport_Session$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        if ((25 + 19) % 19 > 0) {
        }
        this.generator = bmKorqWWjosEcLLF(crashlyticsReport$Session);
        this.identifier = utIxgjHzALZfEGyv(crashlyticsReport$Session);
        this.appQualitySessionId = rILaDLXctIJkVali(crashlyticsReport$Session);
        this.startedAt = zjNkXYszCEaZwSxD(crashlyticsReport$Session);
        this.endedAt = dEdeRGHjCxcYGGeD(crashlyticsReport$Session);
        this.crashed = pohpvNgaUMSBCsvg(crashlyticsReport$Session);
        this.app = hYTrjScwlnjLVsOz(crashlyticsReport$Session);
        this.user = oTCXoLGGnArNeOUP(crashlyticsReport$Session);
        this.os = ZwALVxWBmVKrKAEy(crashlyticsReport$Session);
        this.device = MBmAkgZnHcWWvtLN(crashlyticsReport$Session);
        this.events = lAabJhryCiKdbZml(crashlyticsReport$Session);
        this.generatorType = RQWxQTfSbdzvbFzB(crashlyticsReport$Session);
        this.set$0 = (byte) 7;
    }

    AutoValue_CrashlyticsReport_Session$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session$1 autoValue_CrashlyticsReport_Session$1) {
        this(crashlyticsReport$Session);
    }

    public static java.lang.stringBuilder BNysfRcBrLMFTmQx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BNysfRcBrLMFTmQx(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNysfRcBrLMFTmQx(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNysfRcBrLMFTmQx(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CXKxPxIWhwbfudVb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CXKxPxIWhwbfudVb(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CXKxPxIWhwbfudVb(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CXKxPxIWhwbfudVb(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device MBmAkgZnHcWWvtLN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getDevice();
    }

    public static void MBmAkgZnHcWWvtLN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBmAkgZnHcWWvtLN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MBmAkgZnHcWWvtLN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QLlkueAhxUieFHHP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QLlkueAhxUieFHHP(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QLlkueAhxUieFHHP(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QLlkueAhxUieFHHP(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int RQWxQTfSbdzvbFzB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getGeneratorType();
    }

    public static void RQWxQTfSbdzvbFzB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RQWxQTfSbdzvbFzB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RQWxQTfSbdzvbFzB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem ZwALVxWBmVKrKAEy(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getOs();
    }

    public static void ZwALVxWBmVKrKAEy(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZwALVxWBmVKrKAEy(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZwALVxWBmVKrKAEy(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BmKorqWWjosEcLLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getGenerator();
    }

    public static void BmKorqWWjosEcLLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BmKorqWWjosEcLLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BmKorqWWjosEcLLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.long DEdeRGHjCxcYGGeD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getEndedAt();
    }

    public static void DEdeRGHjCxcYGGeD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEdeRGHjCxcYGGeD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DEdeRGHjCxcYGGeD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EAbtFmTeBIVmyPAL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EAbtFmTeBIVmyPAL(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAbtFmTeBIVmyPAL(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EAbtFmTeBIVmyPAL(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GUxHxJBREuyWaxVD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GUxHxJBREuyWaxVD(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GUxHxJBREuyWaxVD(java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUxHxJBREuyWaxVD(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HNXSkXpWzJLwXHud(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void HNXSkXpWzJLwXHud(java.lang.stringBuilder sb, java.lang.object obj, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNXSkXpWzJLwXHud(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNXSkXpWzJLwXHud(java.lang.stringBuilder sb, java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application hYTrjScwlnjLVsOz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getApp();
    }

    public static void HYTrjScwlnjLVsOz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HYTrjScwlnjLVsOz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HYTrjScwlnjLVsOz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List LAabJhryCiKdbZml(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getEvents();
    }

    public static void LAabJhryCiKdbZml(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LAabJhryCiKdbZml(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LAabJhryCiKdbZml(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User oTCXoLGGnArNeOUP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getUser();
    }

    public static void OTCXoLGGnArNeOUP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OTCXoLGGnArNeOUP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OTCXoLGGnArNeOUP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PohpvNgaUMSBCsvg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PohpvNgaUMSBCsvg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PohpvNgaUMSBCsvg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PohpvNgaUMSBCsvg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.isCrashed();
    }

    public static java.lang.string RILaDLXctIJkVali(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getAppQualitySessionId();
    }

    public static void RILaDLXctIJkVali(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RILaDLXctIJkVali(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RILaDLXctIJkVali(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UtIxgjHzALZfEGyv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getIdentifier();
    }

    public static void UtIxgjHzALZfEGyv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UtIxgjHzALZfEGyv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UtIxgjHzALZfEGyv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XQKsOVoqeOndZPkg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XQKsOVoqeOndZPkg(java.lang.stringBuilder sb, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XQKsOVoqeOndZPkg(java.lang.stringBuilder sb, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XQKsOVoqeOndZPkg(java.lang.stringBuilder sb, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YPcAnGmfjRuNaOpZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YPcAnGmfjRuNaOpZ(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPcAnGmfjRuNaOpZ(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPcAnGmfjRuNaOpZ(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long ZjNkXYszCEaZwSxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        if ((26 + 8) % 8 > 0) {
        }
        return crashlyticsReport$Session.getStartedAt();
    }

    public static void ZjNkXYszCEaZwSxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZjNkXYszCEaZwSxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZjNkXYszCEaZwSxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session build() {
        if ((23 + 15) % 15 > 0) {
        }
        if (this.set$0 == 7 && this.generator is not null && this.identifier is not null && this.app is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session(this.generator, this.identifier, this.appQualitySessionId, this.startedAt, this.endedAt, this.crashed, this.app, this.user, this.os, this.device, this.events, this.generatorType, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.generator is null) {
            QLlkueAhxUieFHHP(sb, " generator");
        }
        if (this.identifier is null) {
            BNysfRcBrLMFTmQx(sb, " identifier");
        }
        if ((this.set$0 & 1) == 0) {
            eAbtFmTeBIVmyPAL(sb, " startedAt");
        }
        if ((this.set$0 & 2) == 0) {
            CXKxPxIWhwbfudVb(sb, " crashed");
        }
        if (this.app is null) {
            yPcAnGmfjRuNaOpZ(sb, " app");
        }
        if ((this.set$0 & 4) == 0) {
            gUxHxJBREuyWaxVD(sb, " generatorType");
        }
        throw new java.lang.IllegalStateException(xQKsOVoqeOndZPkg(hNXSkXpWzJLwXHud(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setApp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application) {
        if (crashlyticsReport$Session$Application is null) {
            throw new java.lang.NullPointerException("Null app");
        }
        this.app = crashlyticsReport$Session$Application;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setAppQualitySessionId(java.lang.string str) {
        this.appQualitySessionId = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setCrashed(bool z) {
        this.crashed = z;
        this.set$0 = (byte) (this.set$0 | 2);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setDevice(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device) {
        this.device = crashlyticsReport$Session$Device;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setEndedAt(java.lang.long l) {
        this.endedAt = l;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setEvents(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> list) {
        this.events = list;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setGenerator(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null generator");
        }
        this.generator = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setGeneratorType(int i) {
        this.generatorType = i;
        this.set$0 = (byte) (this.set$0 | 4);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setIdentifier(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null identifier");
        }
        this.identifier = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setOs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem) {
        this.os = crashlyticsReport$Session$OperatingSystem;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setStartedAt(long j) {
        this.startedAt = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setUser(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User crashlyticsReport$Session$User) {
        this.user = crashlyticsReport$Session$User;
        return this;
    }
}

