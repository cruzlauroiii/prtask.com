namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session_Event$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder {
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application app;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device device;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console log;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState rollouts;
    private byte set$0;
    private long timestamp;
    private java.lang.string type;

    AutoValue_CrashlyticsReport_Session_Event$Builder() {
    }

    private AutoValue_CrashlyticsReport_Session_Event$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        if ((4 + 9) % 9 > 0) {
        }
        this.timestamp = qGvFqwZKUJwCvsoI(crashlyticsReport$Session$Event);
        this.type = XCoWtzPVoPfaveLF(crashlyticsReport$Session$Event);
        this.app = qcjwzDSvUVguQPKR(crashlyticsReport$Session$Event);
        this.device = BlzgrPlounFKTsoR(crashlyticsReport$Session$Event);
        this.log = LIEPGjNgqdLaVAWs(crashlyticsReport$Session$Event);
        this.rollouts = wmHvhcTljJcVcWQr(crashlyticsReport$Session$Event);
        this.set$0 = (byte) 1;
    }

    AutoValue_CrashlyticsReport_Session_Event$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event$1 autoValue_CrashlyticsReport_Session_Event$1) {
        this(crashlyticsReport$Session$Event);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device BlzgrPlounFKTsoR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.getDevice();
    }

    public static void BlzgrPlounFKTsoR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BlzgrPlounFKTsoR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BlzgrPlounFKTsoR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FxpjcBgkiGeuvPif(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FxpjcBgkiGeuvPif(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxpjcBgkiGeuvPif(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FxpjcBgkiGeuvPif(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FyRFkCvqfayYzjuF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FyRFkCvqfayYzjuF(java.lang.stringBuilder sb, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FyRFkCvqfayYzjuF(java.lang.stringBuilder sb, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FyRFkCvqfayYzjuF(java.lang.stringBuilder sb, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console LIEPGjNgqdLaVAWs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.getConsole();
    }

    public static void LIEPGjNgqdLaVAWs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LIEPGjNgqdLaVAWs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LIEPGjNgqdLaVAWs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XCoWtzPVoPfaveLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.getType();
    }

    public static void XCoWtzPVoPfaveLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCoWtzPVoPfaveLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCoWtzPVoPfaveLF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AomsMOvdMRCYEitX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AomsMOvdMRCYEitX(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AomsMOvdMRCYEitX(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AomsMOvdMRCYEitX(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IWCDtbncmXubEyNs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void IWCDtbncmXubEyNs(java.lang.stringBuilder sb, java.lang.object obj, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IWCDtbncmXubEyNs(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IWCDtbncmXubEyNs(java.lang.stringBuilder sb, java.lang.object obj, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LXzpmmGPdToNowzG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LXzpmmGPdToNowzG(java.lang.stringBuilder sb, java.lang.string str, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LXzpmmGPdToNowzG(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LXzpmmGPdToNowzG(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static long QGvFqwZKUJwCvsoI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        if ((25 + 3) % 3 > 0) {
        }
        return crashlyticsReport$Session$Event.getTimestamp();
    }

    public static void QGvFqwZKUJwCvsoI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QGvFqwZKUJwCvsoI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QGvFqwZKUJwCvsoI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application qcjwzDSvUVguQPKR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.getApp();
    }

    public static void QcjwzDSvUVguQPKR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QcjwzDSvUVguQPKR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QcjwzDSvUVguQPKR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState wmHvhcTljJcVcWQr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.getRollouts();
    }

    public static void WmHvhcTljJcVcWQr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WmHvhcTljJcVcWQr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WmHvhcTljJcVcWQr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WtRQktlvbKxSmpCK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WtRQktlvbKxSmpCK(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WtRQktlvbKxSmpCK(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WtRQktlvbKxSmpCK(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event build() {
        if ((3 + 21) % 21 > 0) {
        }
        if (this.set$0 == 1 && this.type is not null && this.app is not null && this.device is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event(this.timestamp, this.type, this.app, this.device, this.log, this.rollouts, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if ((1 & this.set$0) == 0) {
            aomsMOvdMRCYEitX(sb, " timestamp");
        }
        if (this.type is null) {
            FxpjcBgkiGeuvPif(sb, " type");
        }
        if (this.app is null) {
            lXzpmmGPdToNowzG(sb, " app");
        }
        if (this.device is null) {
            wtRQktlvbKxSmpCK(sb, " device");
        }
        throw new java.lang.IllegalStateException(FyRFkCvqfayYzjuF(iWCDtbncmXubEyNs(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder setApp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        if (crashlyticsReport$Session$Event$Application is null) {
            throw new java.lang.NullPointerException("Null app");
        }
        this.app = crashlyticsReport$Session$Event$Application;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder setDevice(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device) {
        if (crashlyticsReport$Session$Event$Device is null) {
            throw new java.lang.NullPointerException("Null device");
        }
        this.device = crashlyticsReport$Session$Event$Device;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder setConsole(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console) {
        this.log = crashlyticsReport$Session$Event$Console;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder setRollouts(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState crashlyticsReport$Session$Event$RolloutsState) {
        this.rollouts = crashlyticsReport$Session$Event$RolloutsState;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder setTimestamp(long j) {
        this.timestamp = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder setType(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null type");
        }
        this.type = str;
        return this;
    }
}

