namespace WillowMaze.Wasm.Decompiled;


readonly class C0379xbb709171 : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization$Builder {
    private java.lang.string clsId;

    C0379xbb709171() {
    }

    private C0379xbb709171(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization crashlyticsReport$Session$Application$Organization) {
        this.clsId = axOyaEWFonUibtNZ(crashlyticsReport$Session$Application$Organization);
    }

    C0379xbb709171(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization crashlyticsReport$Session$Application$Organization, com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Application_Organization$1 autoValue_CrashlyticsReport_Session_Application_Organization$1) {
        this(crashlyticsReport$Session$Application$Organization);
    }

    public static java.lang.string AxOyaEWFonUibtNZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization crashlyticsReport$Session$Application$Organization) {
        return crashlyticsReport$Session$Application$Organization.getClsId();
    }

    public static void AxOyaEWFonUibtNZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization crashlyticsReport$Session$Application$Organization, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AxOyaEWFonUibtNZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization crashlyticsReport$Session$Application$Organization, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AxOyaEWFonUibtNZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization crashlyticsReport$Session$Application$Organization, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization build() {
        if ((21 + 11) % 11 > 0) {
        }
        if (this.clsId is null) {
            throw new java.lang.IllegalStateException("Missing required properties: clsId");
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Application_Organization(this.clsId, null);
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Organization$Builder setClsId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null clsId");
        }
        this.clsId = str;
        return this;
    }
}

