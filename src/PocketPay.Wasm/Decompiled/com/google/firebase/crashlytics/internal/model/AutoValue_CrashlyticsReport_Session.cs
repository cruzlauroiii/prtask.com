namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session {
    private readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application app;
    private readonly java.lang.string appQualitySessionId;
    private readonly bool crashed;
    private readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device device;
    private readonly java.lang.long endedAt;
    private readonly java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> events;
    private readonly java.lang.string generator;
    private readonly int generatorType;
    private readonly java.lang.string identifier;
    private readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem os;
    private readonly long startedAt;
    private readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User user;

    private AutoValue_CrashlyticsReport_Session(java.lang.string str, java.lang.string str2, java.lang.string str3, long j, java.lang.long l, bool z, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User crashlyticsReport$Session$User, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device, java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> list, int i) {
        this.generator = str;
        this.identifier = str2;
        this.appQualitySessionId = str3;
        this.startedAt = j;
        this.endedAt = l;
        this.crashed = z;
        this.app = crashlyticsReport$Session$Application;
        this.user = crashlyticsReport$Session$User;
        this.os = crashlyticsReport$Session$OperatingSystem;
        this.device = crashlyticsReport$Session$Device;
        this.events = list;
        this.generatorType = i;
    }

    AutoValue_CrashlyticsReport_Session(java.lang.string str, java.lang.string str2, java.lang.string str3, long j, java.lang.long l, bool z, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User crashlyticsReport$Session$User, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device, java.util.List list, int i, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session$1 autoValue_CrashlyticsReport_Session$1) {
        this(str, str2, str3, j, l, z, crashlyticsReport$Session$Application, crashlyticsReport$Session$User, crashlyticsReport$Session$OperatingSystem, crashlyticsReport$Session$Device, list, i);
    }

    public static int BeqtokUpauIoAtGj(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BeqtokUpauIoAtGj(java.lang.object obj, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BeqtokUpauIoAtGj(java.lang.object obj, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BeqtokUpauIoAtGj(java.lang.object obj, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BvjwHBEOuEKWTizM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BvjwHBEOuEKWTizM(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BvjwHBEOuEKWTizM(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BvjwHBEOuEKWTizM(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ClPfHEAWmpVSIcdq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ClPfHEAWmpVSIcdq(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ClPfHEAWmpVSIcdq(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ClPfHEAWmpVSIcdq(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DQMxjmadPFmzPETd(java.lang.string str, java.lang.object obj, short s, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DQMxjmadPFmzPETd(java.lang.string str, java.lang.object obj, bool z, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DQMxjmadPFmzPETd(java.lang.string str, java.lang.object obj, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DQMxjmadPFmzPETd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder DwLBuBuKdnrhZORT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void DwLBuBuKdnrhZORT(java.lang.stringBuilder sb, int i, byte b, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DwLBuBuKdnrhZORT(java.lang.stringBuilder sb, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DwLBuBuKdnrhZORT(java.lang.stringBuilder sb, int i, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User EMFuWfXwuwcLJWws(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getUser();
    }

    public static void EMFuWfXwuwcLJWws(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EMFuWfXwuwcLJWws(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EMFuWfXwuwcLJWws(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESguDobAzpzUbNRG(java.lang.string str, java.lang.object obj, float f, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ESguDobAzpzUbNRG(java.lang.string str, java.lang.object obj, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ESguDobAzpzUbNRG(java.lang.string str, java.lang.object obj, short s, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool ESguDobAzpzUbNRG(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.util.List FAzHfvdBoBXAzuyN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getEvents();
    }

    public static void FAzHfvdBoBXAzuyN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAzHfvdBoBXAzuyN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAzHfvdBoBXAzuyN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device FBOVkgPMIyZDKNuP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getDevice();
    }

    public static void FBOVkgPMIyZDKNuP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBOVkgPMIyZDKNuP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FBOVkgPMIyZDKNuP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FWJPtyXFDpjGzFkY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getIdentifier();
    }

    public static void FWJPtyXFDpjGzFkY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWJPtyXFDpjGzFkY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FWJPtyXFDpjGzFkY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem GkTYeJtUSZCzILuL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getOs();
    }

    public static void GkTYeJtUSZCzILuL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkTYeJtUSZCzILuL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkTYeJtUSZCzILuL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GrzIzAWFPvXaWjwS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GrzIzAWFPvXaWjwS(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GrzIzAWFPvXaWjwS(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GrzIzAWFPvXaWjwS(java.lang.stringBuilder sb, java.lang.string str, int i, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IIuMCNPfCRWmrmuT(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void IIuMCNPfCRWmrmuT(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IIuMCNPfCRWmrmuT(java.lang.stringBuilder sb, java.lang.object obj, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IIuMCNPfCRWmrmuT(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IyTlmFXvMuoSkyon(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void IyTlmFXvMuoSkyon(java.lang.object obj, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IyTlmFXvMuoSkyon(java.lang.object obj, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IyTlmFXvMuoSkyon(java.lang.object obj, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JckwxiYLAJuHpgsS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JckwxiYLAJuHpgsS(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JckwxiYLAJuHpgsS(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JckwxiYLAJuHpgsS(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KOJfbElAmaUNdCXP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KOJfbElAmaUNdCXP(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KOJfbElAmaUNdCXP(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KOJfbElAmaUNdCXP(java.lang.stringBuilder sb, java.lang.string str, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KxCUrMKCxnBdoMei(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KxCUrMKCxnBdoMei(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KxCUrMKCxnBdoMei(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KxCUrMKCxnBdoMei(java.lang.stringBuilder sb, java.lang.string str, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LLMfRPLCcltMuFjO(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void LLMfRPLCcltMuFjO(java.lang.stringBuilder sb, java.lang.object obj, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LLMfRPLCcltMuFjO(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LLMfRPLCcltMuFjO(java.lang.stringBuilder sb, java.lang.object obj, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MXgdSZLBGSfhcdyc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void MXgdSZLBGSfhcdyc(java.lang.stringBuilder sb, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MXgdSZLBGSfhcdyc(java.lang.stringBuilder sb, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXgdSZLBGSfhcdyc(java.lang.stringBuilder sb, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MeCVTzmhkLcCRacP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MeCVTzmhkLcCRacP(java.lang.stringBuilder sb, java.lang.string str, char c, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MeCVTzmhkLcCRacP(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MeCVTzmhkLcCRacP(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MmGFMaGcyBPCdsXR(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void MmGFMaGcyBPCdsXR(java.lang.string str, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmGFMaGcyBPCdsXR(java.lang.string str, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MmGFMaGcyBPCdsXR(java.lang.string str, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OuRkDKLNBvLoeugr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OuRkDKLNBvLoeugr(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OuRkDKLNBvLoeugr(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OuRkDKLNBvLoeugr(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PxxZkGKFDdpjIvXE(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void PxxZkGKFDdpjIvXE(java.lang.stringBuilder sb, long j, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PxxZkGKFDdpjIvXE(java.lang.stringBuilder sb, long j, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PxxZkGKFDdpjIvXE(java.lang.stringBuilder sb, long j, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SGUVEfZWJAYYvIvP(java.lang.object obj, java.lang.object obj2, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SGUVEfZWJAYYvIvP(java.lang.object obj, java.lang.object obj2, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SGUVEfZWJAYYvIvP(java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool SGUVEfZWJAYYvIvP(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string SIfWIwBcLGaXRlZa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getAppQualitySessionId();
    }

    public static void SIfWIwBcLGaXRlZa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SIfWIwBcLGaXRlZa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SIfWIwBcLGaXRlZa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem SMHOhBVgKjqfgKwP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getOs();
    }

    public static void SMHOhBVgKjqfgKwP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SMHOhBVgKjqfgKwP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMHOhBVgKjqfgKwP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TJrMOxzfZVNarbHu(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void TJrMOxzfZVNarbHu(java.lang.string str, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TJrMOxzfZVNarbHu(java.lang.string str, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJrMOxzfZVNarbHu(java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TgNEDUBMPKjszAyW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TgNEDUBMPKjszAyW(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgNEDUBMPKjszAyW(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TgNEDUBMPKjszAyW(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AOVpusUBbgzQzuXI(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void AOVpusUBbgzQzuXI(java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AOVpusUBbgzQzuXI(java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AOVpusUBbgzQzuXI(java.lang.string str, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.long AaDYWIHXICkbLccE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getEndedAt();
    }

    public static void AaDYWIHXICkbLccE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AaDYWIHXICkbLccE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AaDYWIHXICkbLccE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BNkbJaQUroigjMXT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BNkbJaQUroigjMXT(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BNkbJaQUroigjMXT(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNkbJaQUroigjMXT(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BRbvyTFDFicQDSFd(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void BRbvyTFDFicQDSFd(java.lang.stringBuilder sb, java.lang.object obj, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BRbvyTFDFicQDSFd(java.lang.stringBuilder sb, java.lang.object obj, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BRbvyTFDFicQDSFd(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BpLfjOzpjlyvLxfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BpLfjOzpjlyvLxfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BpLfjOzpjlyvLxfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BpLfjOzpjlyvLxfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.isCrashed();
    }

    public static java.util.List EQbTKfbzdIMuNSvE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getEvents();
    }

    public static void EQbTKfbzdIMuNSvE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQbTKfbzdIMuNSvE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQbTKfbzdIMuNSvE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EWfCFmElClANtvJm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EWfCFmElClANtvJm(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWfCFmElClANtvJm(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EWfCFmElClANtvJm(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ElqmVAdbHFuwhWYI(java.lang.object obj, java.lang.object obj2, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ElqmVAdbHFuwhWYI(java.lang.object obj, java.lang.object obj2, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ElqmVAdbHFuwhWYI(java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ElqmVAdbHFuwhWYI(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder GYbytuGFulhGiEhX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GYbytuGFulhGiEhX(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GYbytuGFulhGiEhX(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GYbytuGFulhGiEhX(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HkHNAiFwOKxqrjts(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static void HkHNAiFwOKxqrjts(java.lang.stringBuilder sb, bool z, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HkHNAiFwOKxqrjts(java.lang.stringBuilder sb, bool z, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HkHNAiFwOKxqrjts(java.lang.stringBuilder sb, bool z, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IKABSAyitopAqeYi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IKABSAyitopAqeYi(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IKABSAyitopAqeYi(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKABSAyitopAqeYi(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IMdWccXofmrQAVOS(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void IMdWccXofmrQAVOS(java.lang.stringBuilder sb, java.lang.object obj, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMdWccXofmrQAVOS(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IMdWccXofmrQAVOS(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IWZoCslTtpDfXpsN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void IWZoCslTtpDfXpsN(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IWZoCslTtpDfXpsN(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IWZoCslTtpDfXpsN(java.lang.stringBuilder sb, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JOHMOmChbXCrKpMZ(java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JOHMOmChbXCrKpMZ(java.lang.object obj, java.lang.object obj2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JOHMOmChbXCrKpMZ(java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JOHMOmChbXCrKpMZ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void KEmfjPArjXMsRkjd(java.lang.object obj, java.lang.object obj2, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KEmfjPArjXMsRkjd(java.lang.object obj, java.lang.object obj2, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KEmfjPArjXMsRkjd(java.lang.object obj, java.lang.object obj2, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KEmfjPArjXMsRkjd(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application kGwGqiVPkcsEtHuu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getApp();
    }

    public static void KGwGqiVPkcsEtHuu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KGwGqiVPkcsEtHuu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGwGqiVPkcsEtHuu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static long KLJNpLThRGMhtewh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        if ((1 + 24) % 24 > 0) {
        }
        return crashlyticsReport$Session.getStartedAt();
    }

    public static void KLJNpLThRGMhtewh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KLJNpLThRGMhtewh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KLJNpLThRGMhtewh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KTSKkxejPmdrgnDC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KTSKkxejPmdrgnDC(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KTSKkxejPmdrgnDC(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTSKkxejPmdrgnDC(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User ksXiurAnsaumLQrI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getUser();
    }

    public static void KsXiurAnsaumLQrI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KsXiurAnsaumLQrI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KsXiurAnsaumLQrI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LGLRFPJJIneLbuTS(java.lang.string str, java.lang.object obj, byte b, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LGLRFPJJIneLbuTS(java.lang.string str, java.lang.object obj, byte b, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LGLRFPJJIneLbuTS(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LGLRFPJJIneLbuTS(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder LbcLCgmoYhbaxahC(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void LbcLCgmoYhbaxahC(java.lang.stringBuilder sb, java.lang.object obj, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LbcLCgmoYhbaxahC(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LbcLCgmoYhbaxahC(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OBObsQFVjPuRkpzR(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void OBObsQFVjPuRkpzR(java.lang.object obj, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBObsQFVjPuRkpzR(java.lang.object obj, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBObsQFVjPuRkpzR(java.lang.object obj, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int OfGumCUaMSwLCyWs(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void OfGumCUaMSwLCyWs(java.lang.object obj, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OfGumCUaMSwLCyWs(java.lang.object obj, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OfGumCUaMSwLCyWs(java.lang.object obj, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PlPbuIGOZcjeuBYw(java.lang.long l) {
        return l.GetHashCode();
    }

    public static void PlPbuIGOZcjeuBYw(java.lang.long l, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PlPbuIGOZcjeuBYw(java.lang.long l, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PlPbuIGOZcjeuBYw(java.lang.long l, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QZYQFFMKzuSoMZCp(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void QZYQFFMKzuSoMZCp(java.lang.object obj, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QZYQFFMKzuSoMZCp(java.lang.object obj, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QZYQFFMKzuSoMZCp(java.lang.object obj, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SQQAxhzjCmMpiMaK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getGenerator();
    }

    public static void SQQAxhzjCmMpiMaK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SQQAxhzjCmMpiMaK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SQQAxhzjCmMpiMaK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device trzKryQKrQrLRXjI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getDevice();
    }

    public static void TrzKryQKrQrLRXjI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TrzKryQKrQrLRXjI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TrzKryQKrQrLRXjI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UoudyIVRvWMlMJfe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UoudyIVRvWMlMJfe(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UoudyIVRvWMlMJfe(java.lang.stringBuilder sb, java.lang.string str, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UoudyIVRvWMlMJfe(java.lang.stringBuilder sb, java.lang.string str, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VjRqmCmUIKNjwCbG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getAppQualitySessionId();
    }

    public static void VjRqmCmUIKNjwCbG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VjRqmCmUIKNjwCbG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VjRqmCmUIKNjwCbG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZTAQzuPeWeJznkt(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WZTAQzuPeWeJznkt(java.lang.object obj, java.lang.object obj2, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WZTAQzuPeWeJznkt(java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WZTAQzuPeWeJznkt(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void XjJkegtEdlwhtUiX(java.lang.long l, java.lang.object obj, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjJkegtEdlwhtUiX(java.lang.long l, java.lang.object obj, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjJkegtEdlwhtUiX(java.lang.long l, java.lang.object obj, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XjJkegtEdlwhtUiX(java.lang.long l, java.lang.object obj) {
        return l.Equals(obj);
    }

    public static java.lang.long XmErAtBOroaANsMU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getEndedAt();
    }

    public static void XmErAtBOroaANsMU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XmErAtBOroaANsMU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmErAtBOroaANsMU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZNisULLWQkOUdbmE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getGeneratorType();
    }

    public static void ZNisULLWQkOUdbmE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZNisULLWQkOUdbmE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZNisULLWQkOUdbmE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        java.lang.string str;
        java.lang.long l;
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User crashlyticsReport$Session$User;
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem;
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device;
        java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> list;
        if ((31 + 31) % 31 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session) {
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session = (com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session) obj;
            if (lGLRFPJJIneLbuTS(this.generator, sQQAxhzjCmMpiMaK(crashlyticsReport$Session)) && ESguDobAzpzUbNRG(this.identifier, FWJPtyXFDpjGzFkY(crashlyticsReport$Session)) && ((str = this.appQualitySessionId) is null ? vjRqmCmUIKNjwCbG(crashlyticsReport$Session) is null : DQMxjmadPFmzPETd(str, SIfWIwBcLGaXRlZa(crashlyticsReport$Session))) && this.startedAt == kLJNpLThRGMhtewh(crashlyticsReport$Session) && ((l = this.endedAt) is null ? xmErAtBOroaANsMU(crashlyticsReport$Session) is null : xjJkegtEdlwhtUiX(l, aaDYWIHXICkbLccE(crashlyticsReport$Session))) && this.crashed == bpLfjOzpjlyvLxfo(crashlyticsReport$Session) && SGUVEfZWJAYYvIvP(this.app, kGwGqiVPkcsEtHuu(crashlyticsReport$Session)) && ((crashlyticsReport$Session$User = this.user) is null ? EMFuWfXwuwcLJWws(crashlyticsReport$Session) is null : elqmVAdbHFuwhWYI(crashlyticsReport$Session$User, ksXiurAnsaumLQrI(crashlyticsReport$Session))) && ((crashlyticsReport$Session$OperatingSystem = this.os) is null ? GkTYeJtUSZCzILuL(crashlyticsReport$Session) is null : kEmfjPArjXMsRkjd(crashlyticsReport$Session$OperatingSystem, SMHOhBVgKjqfgKwP(crashlyticsReport$Session))) && ((crashlyticsReport$Session$Device = this.device) is null ? trzKryQKrQrLRXjI(crashlyticsReport$Session) is null : wZTAQzuPeWeJznkt(crashlyticsReport$Session$Device, FBOVkgPMIyZDKNuP(crashlyticsReport$Session))) && ((list = this.events) is null ? FAzHfvdBoBXAzuyN(crashlyticsReport$Session) is null : jOHMOmChbXCrKpMZ(list, eQbTKfbzdIMuNSvE(crashlyticsReport$Session))) && this.generatorType == zNisULLWQkOUdbmE(crashlyticsReport$Session)) {
                return true;
            }
        }
        return false;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application getApp() {
        return this.app;
    }

    public override java.lang.string GetAppQualitySessionId() {
        return this.appQualitySessionId;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device getDevice() {
        return this.device;
    }

    public override java.lang.long GetEndedAt() {
        return this.endedAt;
    }

    public java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> getEvents() {
        return this.events;
    }

    public override java.lang.string GetGenerator() {
        return this.generator;
    }

    public override int GetGeneratorType() {
        return this.generatorType;
    }

    @com.google.firebase.encoders.annotations.Encodable$Ignore
    public override java.lang.string GetIdentifier() {
        return this.identifier;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem getOs() {
        return this.os;
    }

    public override long GetStartedAt() {
        if ((26 + 14) % 14 > 0) {
        }
        return this.startedAt;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User getUser() {
        return this.user;
    }

    public override int HashCode() {
        if ((5 + 18) % 18 > 0) {
        }
        int iAOVpusUBbgzQzuXI = (((aOVpusUBbgzQzuXI(this.generator) ^ 1000003) * 1000003) ^ TJrMOxzfZVNarbHu(this.identifier)) * 1000003;
        java.lang.string str = this.appQualitySessionId;
        int iMmGFMaGcyBPCdsXR = (iAOVpusUBbgzQzuXI ^ (str is not null ? MmGFMaGcyBPCdsXR(str) : 0)) * 1000003;
        long j = this.startedAt;
        int i = (iMmGFMaGcyBPCdsXR ^ ((int) (j ^ (j >>> 32)))) * 1000003;
        java.lang.long l = this.endedAt;
        int iPlPbuIGOZcjeuBYw = (((((i ^ (l is not null ? plPbuIGOZcjeuBYw(l) : 0)) * 1000003) ^ (!this.crashed ? 1237 : 1231)) * 1000003) ^ qZYQFFMKzuSoMZCp(this.app)) * 1000003;
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User crashlyticsReport$Session$User = this.user;
        int iIyTlmFXvMuoSkyon = (iPlPbuIGOZcjeuBYw ^ (crashlyticsReport$Session$User is not null ? IyTlmFXvMuoSkyon(crashlyticsReport$Session$User) : 0)) * 1000003;
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem = this.os;
        int iOBObsQFVjPuRkpzR = (iIyTlmFXvMuoSkyon ^ (crashlyticsReport$Session$OperatingSystem is not null ? oBObsQFVjPuRkpzR(crashlyticsReport$Session$OperatingSystem) : 0)) * 1000003;
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device = this.device;
        int iBeqtokUpauIoAtGj = (iOBObsQFVjPuRkpzR ^ (crashlyticsReport$Session$Device is not null ? BeqtokUpauIoAtGj(crashlyticsReport$Session$Device) : 0)) * 1000003;
        java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> list = this.events;
        return this.generatorType ^ ((iBeqtokUpauIoAtGj ^ (list is not null ? ofGumCUaMSwLCyWs(list) : 0)) * 1000003);
    }

    public override bool IsCrashed() {
        return this.crashed;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder toBuilder() {
        if ((10 + 31) % 31 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session$Builder(this, null);
    }

    public override java.lang.string Tostring() {
        if ((4 + 12) % 12 > 0) {
        }
        return MXgdSZLBGSfhcdyc(JckwxiYLAJuHpgsS(DwLBuBuKdnrhZORT(BvjwHBEOuEKWTizM(iWZoCslTtpDfXpsN(bNkbJaQUroigjMXT(bRbvyTFDFicQDSFd(GrzIzAWFPvXaWjwS(IIuMCNPfCRWmrmuT(uoudyIVRvWMlMJfe(lbcLCgmoYhbaxahC(KxCUrMKCxnBdoMei(LLMfRPLCcltMuFjO(KOJfbElAmaUNdCXP(hkHNAiFwOKxqrjts(gYbytuGFulhGiEhX(iMdWccXofmrQAVOS(MeCVTzmhkLcCRacP(PxxZkGKFDdpjIvXE(kTSKkxejPmdrgnDC(ClPfHEAWmpVSIcdq(OuRkDKLNBvLoeugr(TgNEDUBMPKjszAyW(iKABSAyitopAqeYi(eWfCFmElClANtvJm(new java.lang.stringBuilder("Session{generator="), this.generator), ", identifier="), this.identifier), ", appQualitySessionId="), this.appQualitySessionId), ", startedAt="), this.startedAt), ", endedAt="), this.endedAt), ", crashed="), this.crashed), ", app="), this.app), ", user="), this.user), ", os="), this.os), ", device="), this.device), ", events="), this.events), ", generatorType="), this.generatorType), "}"));
    }
}

