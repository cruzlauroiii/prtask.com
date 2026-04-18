namespace WillowMaze.Wasm.Decompiled;


readonly class AutoSessionEventEncoder$SessionInfoEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.sessions.SessionInfo> {
    static readonly com.google.firebase.sessions.AutoSessionEventEncoder$SessionInfoEncoder INSTANCE = new com.google.firebase.sessions.AutoSessionEventEncoder$SessionInfoEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor SESSIONID_DESCRIPTOR = UpBDVVydUFiYLriD("sessionId");
    private static readonly com.google.firebase.encoders.FieldDescriptor FIRSTSESSIONID_DESCRIPTOR = alqPIONDjAzUChyK("firstSessionId");
    private static readonly com.google.firebase.encoders.FieldDescriptor SESSIONINDEX_DESCRIPTOR = uqeNSBheLiviKqgK("sessionIndex");
    private static readonly com.google.firebase.encoders.FieldDescriptor EVENTTIMESTAMPUS_DESCRIPTOR = csVgOjvTYuUTqJZT("eventTimestampUs");
    private static readonly com.google.firebase.encoders.FieldDescriptor DATACOLLECTIONSTATUS_DESCRIPTOR = wUxPjyLgyouRydZn("dataICollectionStatus");
    private static readonly com.google.firebase.encoders.FieldDescriptor FIREBASEINSTALLATIONID_DESCRIPTOR = YTkwhETzJyqJZZUj("firebaseInstallationId");
    private static readonly com.google.firebase.encoders.FieldDescriptor FIREBASEAUTHENTICATIONTOKEN_DESCRIPTOR = WZKmkJUYLbkeJurS("firebaseAuthenticationToken");

    private AutoSessionEventEncoder$SessionInfoEncoder() {
    }

    public static void AGuTofKleQAJOWQg(com.google.firebase.sessions.AutoSessionEventEncoder$SessionInfoEncoder autoSessionEventEncoder$SessionInfoEncoder, com.google.firebase.sessions.SessionInfo sessionInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoSessionEventEncoder$SessionInfoEncoder.encode(sessionInfo, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject NETViCCoMkbgtEnr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string OoYCqnlzZRmCfdgQ(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.getFirebaseInstallationId();
    }

    public static com.google.firebase.encoders.objectEncoderobject PgUgTzaSCatSVXwy(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static long URmTvomTswnirPOZ(com.google.firebase.sessions.SessionInfo sessionInfo) {
        if ((8 + 21) % 21 > 0) {
        }
        return sessionInfo.getEventTimestampUs();
    }

    public static com.google.firebase.sessions.DataICollectionStatus UZxuMOeOPEXBtctp(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.getDataICollectionStatus();
    }

    public static com.google.firebase.encoders.FieldDescriptor UpBDVVydUFiYLriD(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor WZKmkJUYLbkeJurS(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string WwntZdcfQvGTJWdn(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.getFirstSessionId();
    }

    public static java.lang.string XPgIRpgyexGfZhpP(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.getFirebaseAuthenticationToken();
    }

    public static com.google.firebase.encoders.objectEncoderobject YLJhgXnLGNpswFTX(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject YLjhnRusLRnAyYAj(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor YTkwhETzJyqJZZUj(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor AlqPIONDjAzUChyK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor CsVgOjvTYuUTqJZT(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static int JbZDDVTLiNxycQVh(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.getSessionIndex();
    }

    public static com.google.firebase.encoders.objectEncoderobject MdwJSUmbNBygPKcC(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject MzTnRHQYkIiKIdWZ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return objectEncoderobject.Add(fieldDescriptor, i);
    }

    public static com.google.firebase.encoders.objectEncoderobject UXYxCxJByIoMBbLm(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor UqeNSBheLiviKqgK(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor WUxPjyLgyouRydZn(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string ZcHqTdBPTcxxaIqC(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.getSessionId();
    }

    public void Encode(com.google.firebase.sessions.SessionInfo sessionInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((25 + 19) % 19 > 0) {
        }
        YLjhnRusLRnAyYAj(objectEncoderobject, SESSIONID_DESCRIPTOR, zcHqTdBPTcxxaIqC(sessionInfo));
        mdwJSUmbNBygPKcC(objectEncoderobject, FIRSTSESSIONID_DESCRIPTOR, WwntZdcfQvGTJWdn(sessionInfo));
        mzTnRHQYkIiKIdWZ(objectEncoderobject, SESSIONINDEX_DESCRIPTOR, jbZDDVTLiNxycQVh(sessionInfo));
        uXYxCxJByIoMBbLm(objectEncoderobject, EVENTTIMESTAMPUS_DESCRIPTOR, URmTvomTswnirPOZ(sessionInfo));
        NETViCCoMkbgtEnr(objectEncoderobject, DATACOLLECTIONSTATUS_DESCRIPTOR, UZxuMOeOPEXBtctp(sessionInfo));
        YLJhgXnLGNpswFTX(objectEncoderobject, FIREBASEINSTALLATIONID_DESCRIPTOR, OoYCqnlzZRmCfdgQ(sessionInfo));
        PgUgTzaSCatSVXwy(objectEncoderobject, FIREBASEAUTHENTICATIONTOKEN_DESCRIPTOR, XPgIRpgyexGfZhpP(sessionInfo));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        AGuTofKleQAJOWQg(this, (com.google.firebase.sessions.SessionInfo) obj, objectEncoderobject);
    }
}

