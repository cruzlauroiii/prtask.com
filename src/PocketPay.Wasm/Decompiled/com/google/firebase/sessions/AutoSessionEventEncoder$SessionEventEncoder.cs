namespace WillowMaze.Wasm.Decompiled;


readonly class AutoSessionEventEncoder$SessionEventEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.sessions.SessionEvent> {
    static readonly com.google.firebase.sessions.AutoSessionEventEncoder$SessionEventEncoder INSTANCE = new com.google.firebase.sessions.AutoSessionEventEncoder$SessionEventEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENTTYPE_DESCRIPTOR = ojaejvOYuNGEaTJW("eventType");
    private static readonly com.google.firebase.encoders.FieldDescriptor SESSIONDATA_DESCRIPTOR = hbZuctYJfkLNlyar("sessionData");
    private static readonly com.google.firebase.encoders.FieldDescriptor APPLICATIONINFO_DESCRIPTOR = uvVWIQwzmkwEOeWk("applicationInfo");

    private AutoSessionEventEncoder$SessionEventEncoder() {
    }

    public static com.google.firebase.encoders.objectEncoderobject ImIqgfwFCPwlICRp(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.sessions.SessionInfo JqvmOMDAiDkzroha(com.google.firebase.sessions.SessionEvent sessionEvent) {
        return sessionEvent.getSessionData();
    }

    public static void TnVyLkgqyPtvvhfN(com.google.firebase.sessions.AutoSessionEventEncoder$SessionEventEncoder autoSessionEventEncoder$SessionEventEncoder, com.google.firebase.sessions.SessionEvent sessionEvent, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoSessionEventEncoder$SessionEventEncoder.encode(sessionEvent, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject UuankaKOGzWggnqn(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.sessions.EventType HXBTOJGyfVXFMbUb(com.google.firebase.sessions.SessionEvent sessionEvent) {
        return sessionEvent.getEventType();
    }

    public static com.google.firebase.encoders.FieldDescriptor HbZuctYJfkLNlyar(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor OjaejvOYuNGEaTJW(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.sessions.ApplicationInfo RRATTOcjzSRPlYSK(com.google.firebase.sessions.SessionEvent sessionEvent) {
        return sessionEvent.getApplicationInfo();
    }

    public static com.google.firebase.encoders.FieldDescriptor UvVWIQwzmkwEOeWk(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject ZTzgOEkaRgWFYqTY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public void Encode(com.google.firebase.sessions.SessionEvent sessionEvent, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        UuankaKOGzWggnqn(objectEncoderobject, EVENTTYPE_DESCRIPTOR, hXBTOJGyfVXFMbUb(sessionEvent));
        zTzgOEkaRgWFYqTY(objectEncoderobject, SESSIONDATA_DESCRIPTOR, JqvmOMDAiDkzroha(sessionEvent));
        ImIqgfwFCPwlICRp(objectEncoderobject, APPLICATIONINFO_DESCRIPTOR, rRATTOcjzSRPlYSK(sessionEvent));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        TnVyLkgqyPtvvhfN(this, (com.google.firebase.sessions.SessionEvent) obj, objectEncoderobject);
    }
}

