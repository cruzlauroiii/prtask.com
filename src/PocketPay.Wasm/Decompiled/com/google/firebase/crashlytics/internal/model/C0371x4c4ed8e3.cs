namespace WillowMaze.Wasm.Decompiled;


readonly class C0371x4c4ed8e3 : com.google.firebase.encoders.objectEncoder<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console> {
    static readonly com.google.firebase.crashlytics.internal.model.C0371x4c4ed8e3 INSTANCE = new com.google.firebase.crashlytics.internal.model.C0371x4c4ed8e3();
    private static readonly com.google.firebase.encoders.FieldDescriptor CONTENT_DESCRIPTOR = AqTTBBZItiLWZSWX("content");

    private C0371x4c4ed8e3() {
    }

    public static com.google.firebase.encoders.FieldDescriptor AqTTBBZItiLWZSWX(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void AqTTBBZItiLWZSWX(java.lang.string str, char c, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AqTTBBZItiLWZSWX(java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AqTTBBZItiLWZSWX(java.lang.string str, java.lang.string str2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject XAhLqUehjQyHUZpc(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void XAhLqUehjQyHUZpc(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XAhLqUehjQyHUZpc(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XAhLqUehjQyHUZpc(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ANKYpZHbvJJCvgNu(com.google.firebase.crashlytics.internal.model.C0371x4c4ed8e3 c0371x4c4ed8e3, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        c0371x4c4ed8e3.encode(crashlyticsReport$Session$Event$Console, objectEncoderobject);
    }

    public static void ANKYpZHbvJJCvgNu(com.google.firebase.crashlytics.internal.model.C0371x4c4ed8e3 c0371x4c4ed8e3, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ANKYpZHbvJJCvgNu(com.google.firebase.crashlytics.internal.model.C0371x4c4ed8e3 c0371x4c4ed8e3, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ANKYpZHbvJJCvgNu(com.google.firebase.crashlytics.internal.model.C0371x4c4ed8e3 c0371x4c4ed8e3, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DpHFDzCzZQUHkVBG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console) {
        return crashlyticsReport$Session$Event$Console.getContent();
    }

    public static void DpHFDzCzZQUHkVBG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DpHFDzCzZQUHkVBG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DpHFDzCzZQUHkVBG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public void Encode(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        XAhLqUehjQyHUZpc(objectEncoderobject, CONTENT_DESCRIPTOR, dpHFDzCzZQUHkVBG(crashlyticsReport$Session$Event$Console));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        aNKYpZHbvJJCvgNu(this, (com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console) obj, objectEncoderobject);
    }
}

