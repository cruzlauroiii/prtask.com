namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session_Event_RolloutsState$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder {
    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment> rolloutAssignments;

    AutoValue_CrashlyticsReport_Session_Event_RolloutsState$Builder() {
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState build() {
        if ((31 + 11) % 11 > 0) {
        }
        if (this.rolloutAssignments is null) {
            throw new java.lang.IllegalStateException("Missing required properties: rolloutAssignments");
        }
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_RolloutsState(this.rolloutAssignments, null);
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder setRolloutAssignments(java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment> list) {
        if (list is null) {
            throw new java.lang.NullPointerException("Null rolloutAssignments");
        }
        this.rolloutAssignments = list;
        return this;
    }
}

