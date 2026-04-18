namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_stringsPayload$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder {
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$string> files;
    private java.lang.string orgId;

    AutoValue_CrashlyticsReport_stringsPayload$Builder() {
    }

    private AutoValue_CrashlyticsReport_stringsPayload$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload) {
        this.files = jKoIAkGNynqCaraJ(crashlyticsReport$stringsPayload);
        this.orgId = uBAoimFskTDmybRC(crashlyticsReport$stringsPayload);
    }

    AutoValue_CrashlyticsReport_stringsPayload$Builder(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_stringsPayload$1 autoValue_CrashlyticsReport_stringsPayload$1) {
        this(crashlyticsReport$stringsPayload);
    }

    public static java.util.List JKoIAkGNynqCaraJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload) {
        return crashlyticsReport$stringsPayload.getstrings();
    }

    public static void JKoIAkGNynqCaraJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JKoIAkGNynqCaraJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKoIAkGNynqCaraJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UBAoimFskTDmybRC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload) {
        return crashlyticsReport$stringsPayload.getOrgId();
    }

    public static void UBAoimFskTDmybRC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UBAoimFskTDmybRC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBAoimFskTDmybRC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload build() {
        if ((10 + 3) % 3 > 0) {
        }
        if (this.files is null) {
            throw new java.lang.IllegalStateException("Missing required properties: files");
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_stringsPayload(this.files, this.orgId, null);
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder setstrings(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$string> list) {
        if (list is null) {
            throw new java.lang.NullPointerException("Null files");
        }
        this.files = list;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder setOrgId(java.lang.string str) {
        this.orgId = str;
        return this;
    }
}

