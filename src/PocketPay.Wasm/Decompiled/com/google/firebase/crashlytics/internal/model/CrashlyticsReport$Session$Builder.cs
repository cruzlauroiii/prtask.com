namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Builder {
    public static java.nio.charset.Charset AUoRjousuJttEHcY() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport.access$000();
    }

    public static void AUoRjousuJttEHcY(short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AUoRjousuJttEHcY(bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AUoRjousuJttEHcY(bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder IRDFGSOlgeThPPPM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Builder.setIdentifier(str);
    }

    public static void IRDFGSOlgeThPPPM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, byte b, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRDFGSOlgeThPPPM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, byte b, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IRDFGSOlgeThPPPM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, java.lang.string str2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session build();

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setApp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setAppQualitySessionId(java.lang.string str);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setCrashed(bool z);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setDevice(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setEndedAt(java.lang.long l);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setEvents(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> list);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setGenerator(java.lang.string str);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setGeneratorType(int i);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setIdentifier(java.lang.string str);

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setIdentifierFromUtf8bytes(byte[] bArr) {
        if ((28 + 16) % 16 > 0) {
        }
        return IRDFGSOlgeThPPPM(this, new java.lang.string(bArr, AUoRjousuJttEHcY()));
    }

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setOs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setStartedAt(long j);

    public abstract com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder setUser(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User crashlyticsReport$Session$User);
}

