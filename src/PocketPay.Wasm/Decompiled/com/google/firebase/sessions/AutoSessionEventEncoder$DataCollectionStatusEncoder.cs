namespace WillowMaze.Wasm.Decompiled;


readonly class AutoSessionEventEncoder$DataICollectionStatusEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.sessions.DataICollectionStatus> {
    static readonly com.google.firebase.sessions.AutoSessionEventEncoder$DataICollectionStatusEncoder INSTANCE = new com.google.firebase.sessions.AutoSessionEventEncoder$DataICollectionStatusEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor PERFORMANCE_DESCRIPTOR = KwlqKomVRlwFLGrG("performance");
    private static readonly com.google.firebase.encoders.FieldDescriptor CRASHLYTICS_DESCRIPTOR = qykIQCgbeLnytviK("crashlytics");
    private static readonly com.google.firebase.encoders.FieldDescriptor SESSIONSAMPLINGRATE_DESCRIPTOR = ZbpFLljdCHczHVth("sessionSamplingRate");

    private AutoSessionEventEncoder$DataICollectionStatusEncoder() {
    }

    public static com.google.firebase.encoders.objectEncoderobject GmlMWSnlCgtsgJKY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d) {
        return objectEncoderobject.Add(fieldDescriptor, d);
    }

    public static com.google.firebase.sessions.DataICollectionState HHAcjDaWuYTlcmSM(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus) {
        return dataICollectionStatus.getCrashlytics();
    }

    public static com.google.firebase.encoders.objectEncoderobject JIdNnlbEqZfpKdrY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.sessions.DataICollectionState JojaPuzrJpaTWKcx(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus) {
        return dataICollectionStatus.getPerformance();
    }

    public static void KkGmHSPsIWmSGbfp(com.google.firebase.sessions.AutoSessionEventEncoder$DataICollectionStatusEncoder autoSessionEventEncoder$DataICollectionStatusEncoder, com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoSessionEventEncoder$DataICollectionStatusEncoder.encode(dataICollectionStatus, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor KwlqKomVRlwFLGrG(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static double ORtFzjJCwlzLoRPs(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus) {
        if ((9 + 14) % 14 > 0) {
        }
        return dataICollectionStatus.getSessionSamplingRate();
    }

    public static com.google.firebase.encoders.FieldDescriptor ZbpFLljdCHczHVth(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject QKIjpqWOqmuvpcGr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor QykIQCgbeLnytviK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((5 + 32) % 32 > 0) {
        }
        JIdNnlbEqZfpKdrY(objectEncoderobject, PERFORMANCE_DESCRIPTOR, JojaPuzrJpaTWKcx(dataICollectionStatus));
        qKIjpqWOqmuvpcGr(objectEncoderobject, CRASHLYTICS_DESCRIPTOR, HHAcjDaWuYTlcmSM(dataICollectionStatus));
        GmlMWSnlCgtsgJKY(objectEncoderobject, SESSIONSAMPLINGRATE_DESCRIPTOR, ORtFzjJCwlzLoRPs(dataICollectionStatus));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        KkGmHSPsIWmSGbfp(this, (com.google.firebase.sessions.DataICollectionStatus) obj, objectEncoderobject);
    }
}

