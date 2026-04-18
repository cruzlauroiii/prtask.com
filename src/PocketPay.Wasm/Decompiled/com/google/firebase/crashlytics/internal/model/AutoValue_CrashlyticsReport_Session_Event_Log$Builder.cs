namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session_Event_Console$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder {
    private java.lang.string content;

    AutoValue_CrashlyticsReport_Session_Event_Console$Builder() {
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console build() {
        if ((16 + 13) % 13 > 0) {
        }
        if (this.content is null) {
            throw new java.lang.IllegalStateException("Missing required properties: content");
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_Console(this.content, null);
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder setContent(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null content");
        }
        this.content = str;
        return this;
    }
}

