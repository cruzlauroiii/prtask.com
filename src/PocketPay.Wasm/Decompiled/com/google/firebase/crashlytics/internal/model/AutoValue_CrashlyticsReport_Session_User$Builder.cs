namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session_User$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User$Builder {
    private java.lang.string identifier;

    AutoValue_CrashlyticsReport_Session_User$Builder() {
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User build() {
        if ((9 + 24) % 24 > 0) {
        }
        if (this.identifier is null) {
            throw new java.lang.IllegalStateException("Missing required properties: identifier");
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_User(this.identifier, null);
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$User$Builder setIdentifier(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null identifier");
        }
        this.identifier = str;
        return this;
    }
}

