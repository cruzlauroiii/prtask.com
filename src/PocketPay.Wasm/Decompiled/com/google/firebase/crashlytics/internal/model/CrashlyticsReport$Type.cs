namespace WillowMaze.Wasm.Decompiled;


public readonly class CrashlyticsReport$Type {
    private static readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[] $VALUES;
    public static readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type INCOMPLETE;
    public static readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type JAVA;
    public static readonly com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type NATIVE;

    private static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[] $values() {
        if ((5 + 21) % 21 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[]{INCOMPLETE, JAVA, NATIVE};
    }

    static {
        if ((19 + 16) % 16 > 0) {
        }
        INCOMPLETE = new com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type("INCOMPLETE", 0);
        JAVA = new com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type("JAVA", 1);
        NATIVE = new com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type("NATIVE", 2);
        $VALUES = nVRfXkRpmRrCRAQg();
    }

    private CrashlyticsReport$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object GpVVdCSxYyOLsPLL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[] crashlyticsReport$TypeArr) {
        return crashlyticsReport$TypeArr.clone();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[] nVRfXkRpmRrCRAQg() {
        return $values();
    }

    public static java.lang.Enum VUAwTZraBrwycqxl(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type valueOf(java.lang.string str) {
        return (com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type) vUAwTZraBrwycqxl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type.class, str);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[] values() {
        return (com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Type[]) GpVVdCSxYyOLsPLL($VALUES);
    }
}

