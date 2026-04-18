namespace WillowMaze.Wasm.Decompiled;


readonly class AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment> {
    static readonly com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder INSTANCE = new com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor ROLLOUTID_DESCRIPTOR = LNxhySrGeImCUTSp("rolloutId");
    private static readonly com.google.firebase.encoders.FieldDescriptor VARIANTID_DESCRIPTOR = krgkbEfPcGVmzvEm("variantId");
    private static readonly com.google.firebase.encoders.FieldDescriptor PARAMETERKEY_DESCRIPTOR = lwCOTZazTEpGqoGh("parameterKey");
    private static readonly com.google.firebase.encoders.FieldDescriptor PARAMETERVALUE_DESCRIPTOR = VdBpJaTEhZhlNTUW("parameterValue");
    private static readonly com.google.firebase.encoders.FieldDescriptor TEMPLATEVERSION_DESCRIPTOR = dTWPUPsEtfRdtiuD("templateVersion");

    private AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder() {
    }

    public static com.google.firebase.encoders.objectEncoderobject KvUsjMTRvTJWSFAM(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor LNxhySrGeImCUTSp(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static long RkOmqrQJHuOjCHSv(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        if ((20 + 14) % 14 > 0) {
        }
        return rolloutAssignment.getTemplateVersion();
    }

    public static com.google.firebase.encoders.FieldDescriptor VdBpJaTEhZhlNTUW(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject WiTsyYdXStYChWhA(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject XkvxCHyNChuUpvmd(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string ZpxFxdHlQRLQyaef(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getParameterValue();
    }

    public static com.google.firebase.encoders.FieldDescriptor DTWPUPsEtfRdtiuD(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string FECLuzlrTVLvjziw(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getVariantId();
    }

    public static java.lang.string FKBduoLUAyBEbWzZ(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getParameterKey();
    }

    public static com.google.firebase.encoders.objectEncoderobject IpAXtDEeUOAevErL(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject JtMppCaSpFSpYwpC(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) {
        return objectEncoderobject.Add(fieldDescriptor, j);
    }

    public static com.google.firebase.encoders.FieldDescriptor KrgkbEfPcGVmzvEm(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor LwCOTZazTEpGqoGh(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string MiTutlXVYIvQTGCo(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getRolloutId();
    }

    public static void XPPXZhAcEBJFVQsb(com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder autoRolloutAssignmentEncoder$RolloutAssignmentEncoder, com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoRolloutAssignmentEncoder$RolloutAssignmentEncoder.encode(rolloutAssignment, objectEncoderobject);
    }

    public void Encode(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        if ((5 + 23) % 23 > 0) {
        }
        WiTsyYdXStYChWhA(objectEncoderobject, ROLLOUTID_DESCRIPTOR, miTutlXVYIvQTGCo(rolloutAssignment));
        ipAXtDEeUOAevErL(objectEncoderobject, VARIANTID_DESCRIPTOR, fECLuzlrTVLvjziw(rolloutAssignment));
        XkvxCHyNChuUpvmd(objectEncoderobject, PARAMETERKEY_DESCRIPTOR, fKBduoLUAyBEbWzZ(rolloutAssignment));
        KvUsjMTRvTJWSFAM(objectEncoderobject, PARAMETERVALUE_DESCRIPTOR, ZpxFxdHlQRLQyaef(rolloutAssignment));
        jtMppCaSpFSpYwpC(objectEncoderobject, TEMPLATEVERSION_DESCRIPTOR, RkOmqrQJHuOjCHSv(rolloutAssignment));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        xPPXZhAcEBJFVQsb(this, (com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment) obj, objectEncoderobject);
    }
}

