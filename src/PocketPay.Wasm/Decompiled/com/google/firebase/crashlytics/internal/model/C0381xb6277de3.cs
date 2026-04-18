namespace WillowMaze.Wasm.Decompiled;


readonly class C0381xb6277de3 : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder {
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo appExitInfo;
    private java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab> binaries;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception exception;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal signal;
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread> threads;

    C0381xb6277de3() {
    }

    public static java.lang.stringBuilder OAiTVwfEKIRQzRjx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void OAiTVwfEKIRQzRjx(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OAiTVwfEKIRQzRjx(java.lang.stringBuilder sb, java.lang.object obj, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OAiTVwfEKIRQzRjx(java.lang.stringBuilder sb, java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SLxXAQfQinaBMIRa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SLxXAQfQinaBMIRa(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLxXAQfQinaBMIRa(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SLxXAQfQinaBMIRa(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MicCZIbAnvNBThrl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void MicCZIbAnvNBThrl(java.lang.stringBuilder sb, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MicCZIbAnvNBThrl(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MicCZIbAnvNBThrl(java.lang.stringBuilder sb, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SHhTOzkknEoAwaeb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SHhTOzkknEoAwaeb(java.lang.stringBuilder sb, java.lang.string str, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHhTOzkknEoAwaeb(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHhTOzkknEoAwaeb(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution build() {
        if ((20 + 2) % 2 > 0) {
        }
        if (this.signal is not null && this.binaries is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Application_Execution(this.threads, this.exception, this.appExitInfo, this.signal, this.binaries, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.signal is null) {
            SLxXAQfQinaBMIRa(sb, " signal");
        }
        if (this.binaries is null) {
            sHhTOzkknEoAwaeb(sb, " binaries");
        }
        throw new java.lang.IllegalStateException(micCZIbAnvNBThrl(OAiTVwfEKIRQzRjx(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder setAppExitInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        this.appExitInfo = crashlyticsReport$ApplicationExitInfo;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder setBinaries(java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab> list) {
        if (list is null) {
            throw new java.lang.NullPointerException("Null binaries");
        }
        this.binaries = list;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder setException(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception) {
        this.exception = crashlyticsReport$Session$Event$Application$Execution$Exception;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder setSignal(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal) {
        if (crashlyticsReport$Session$Event$Application$Execution$Signal is null) {
            throw new java.lang.NullPointerException("Null signal");
        }
        this.signal = crashlyticsReport$Session$Event$Application$Execution$Signal;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder setThreads(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread> list) {
        this.threads = list;
        return this;
    }
}

