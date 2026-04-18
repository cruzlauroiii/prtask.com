namespace WillowMaze.Wasm.Decompiled;


readonly class AutoSessionEventEncoder$ProcessDetailsEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.sessions.ProcessDetails> {
    static readonly com.google.firebase.sessions.AutoSessionEventEncoder$ProcessDetailsEncoder INSTANCE = new com.google.firebase.sessions.AutoSessionEventEncoder$ProcessDetailsEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor PROCESSNAME_DESCRIPTOR = BcPhPtbGhQEdettM("processName");
    private static readonly com.google.firebase.encoders.FieldDescriptor PID_DESCRIPTOR = APJxiXUsReOyuuga("pid");
    private static readonly com.google.firebase.encoders.FieldDescriptor IMPORTANCE_DESCRIPTOR = voIPoWeOgOJkTMIr("importance");
    private static readonly com.google.firebase.encoders.FieldDescriptor DEFAULTPROCESS_DESCRIPTOR = oAgGCwnazwboJQpT("defaultProcess");

    private AutoSessionEventEncoder$ProcessDetailsEncoder() {
    }

    public static com.google.firebase.encoders.FieldDescriptor APJxiXUsReOyuuga(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor BcPhPtbGhQEdettM(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static bool DUGfNYTqSpHMLMQD(com.google.firebase.sessions.ProcessDetails processDetails) {
        return processDetails.isDefaultProcess();
    }

    public static java.lang.string EmlkzCORiOFEobvV(com.google.firebase.sessions.ProcessDetails processDetails) {
        return processDetails.getProcessName();
    }

    public static int JVYtWVwpmEUFlveO(com.google.firebase.sessions.ProcessDetails processDetails) {
        return processDetails.getPid();
    }

    public static void JjZBMdsQUlODTRyr(com.google.firebase.sessions.AutoSessionEventEncoder$ProcessDetailsEncoder autoSessionEventEncoder$ProcessDetailsEncoder, com.google.firebase.sessions.ProcessDetails processDetails, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoSessionEventEncoder$ProcessDetailsEncoder.encode(processDetails, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject KEYxEiRpwDSiTbFG(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return objectEncoderobject.Add(fieldDescriptor, i);
    }

    public static int KEnufaHbdkJOZRWG(com.google.firebase.sessions.ProcessDetails processDetails) {
        return processDetails.getImportance();
    }

    public static com.google.firebase.encoders.objectEncoderobject KhELojoldZDhwbNY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject PzTJphIyPeLGdMNK(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return objectEncoderobject.Add(fieldDescriptor, i);
    }

    public static com.google.firebase.encoders.FieldDescriptor OAgGCwnazwboJQpT(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject StldUsZSaeXIQTmr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) {
        return objectEncoderobject.Add(fieldDescriptor, z);
    }

    public static com.google.firebase.encoders.FieldDescriptor VoIPoWeOgOJkTMIr(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.firebase.sessions.ProcessDetails processDetails, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        KhELojoldZDhwbNY(objectEncoderobject, PROCESSNAME_DESCRIPTOR, EmlkzCORiOFEobvV(processDetails));
        KEYxEiRpwDSiTbFG(objectEncoderobject, PID_DESCRIPTOR, JVYtWVwpmEUFlveO(processDetails));
        PzTJphIyPeLGdMNK(objectEncoderobject, IMPORTANCE_DESCRIPTOR, KEnufaHbdkJOZRWG(processDetails));
        stldUsZSaeXIQTmr(objectEncoderobject, DEFAULTPROCESS_DESCRIPTOR, DUGfNYTqSpHMLMQD(processDetails));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        JjZBMdsQUlODTRyr(this, (com.google.firebase.sessions.ProcessDetails) obj, objectEncoderobject);
    }
}

