namespace WillowMaze.Wasm.Decompiled;


public abstract class CrashlyticsReport$Session$Event$RolloutsState {
    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder builder() {
        return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_RolloutsState$Builder();
    }

    public static void Builder(char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "assignments")
    public abstract java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment> getRolloutAssignments();
}

