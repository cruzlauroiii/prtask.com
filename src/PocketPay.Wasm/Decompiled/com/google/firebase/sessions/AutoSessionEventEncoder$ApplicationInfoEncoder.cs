namespace WillowMaze.Wasm.Decompiled;


readonly class AutoSessionEventEncoder$ApplicationInfoEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.sessions.ApplicationInfo> {
    static readonly com.google.firebase.sessions.AutoSessionEventEncoder$ApplicationInfoEncoder INSTANCE = new com.google.firebase.sessions.AutoSessionEventEncoder$ApplicationInfoEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor APPID_DESCRIPTOR = JeLOwYQIFCWVaafB("appId");
    private static readonly com.google.firebase.encoders.FieldDescriptor DEVICEMODEL_DESCRIPTOR = vqsNALiZhlZwRsyW("deviceModel");
    private static readonly com.google.firebase.encoders.FieldDescriptor SESSIONSDKVERSION_DESCRIPTOR = uyfUHtcijHziDdSq("sessionSdkVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor OSVERSION_DESCRIPTOR = ubYsEMuHeUMNaTCg("osVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor LOGENVIRONMENT_DESCRIPTOR = WljhDcGNbQyinxnB("logEnvironment");
    private static readonly com.google.firebase.encoders.FieldDescriptor ANDROIDAPPINFO_DESCRIPTOR = PafqRlhjofiYXgMj("androidAppInfo");

    private AutoSessionEventEncoder$ApplicationInfoEncoder() {
    }

    public static com.google.firebase.encoders.objectEncoderobject BZvlHPOttCjLecIF(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject CJRLhvxsmOTfDNGC(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor JeLOwYQIFCWVaafB(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string PWVdKhjoTtKYqeAM(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getOsVersion();
    }

    public static com.google.firebase.encoders.FieldDescriptor PafqRlhjofiYXgMj(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject TDurgHUzycHhmrGG(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void VfqVzfYnMVGHbQvW(com.google.firebase.sessions.AutoSessionEventEncoder$ApplicationInfoEncoder autoSessionEventEncoder$ApplicationInfoEncoder, com.google.firebase.sessions.ApplicationInfo applicationInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoSessionEventEncoder$ApplicationInfoEncoder.encode(applicationInfo, objectEncoderobject);
    }

    public static java.lang.string WSCnFUmKSbsZVxfT(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getAppId();
    }

    public static com.google.firebase.encoders.FieldDescriptor WljhDcGNbQyinxnB(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject XDnCYmMAefHQrpYX(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string YucPfGupEwNqwNqJ(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getSessionSdkVersion();
    }

    public static java.lang.string BCvVpChxVrmbyJpv(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getDeviceModel();
    }

    public static com.google.firebase.sessions.ConsoleEnvironment HYNChxHdKlmUXpEt(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getConsoleEnvironment();
    }

    public static com.google.firebase.encoders.objectEncoderobject IxLSrwgvGArHVers(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.sessions.AndroidApplicationInfo SzAsUorNzJmVYGUh(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.getAndroidAppInfo();
    }

    public static com.google.firebase.encoders.objectEncoderobject TAiOmxeLWZNGEnxe(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor UbYsEMuHeUMNaTCg(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor UyfUHtcijHziDdSq(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor VqsNALiZhlZwRsyW(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.firebase.sessions.ApplicationInfo applicationInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        XDnCYmMAefHQrpYX(objectEncoderobject, APPID_DESCRIPTOR, WSCnFUmKSbsZVxfT(applicationInfo));
        ixLSrwgvGArHVers(objectEncoderobject, DEVICEMODEL_DESCRIPTOR, bCvVpChxVrmbyJpv(applicationInfo));
        CJRLhvxsmOTfDNGC(objectEncoderobject, SESSIONSDKVERSION_DESCRIPTOR, YucPfGupEwNqwNqJ(applicationInfo));
        TDurgHUzycHhmrGG(objectEncoderobject, OSVERSION_DESCRIPTOR, PWVdKhjoTtKYqeAM(applicationInfo));
        BZvlHPOttCjLecIF(objectEncoderobject, LOGENVIRONMENT_DESCRIPTOR, hYNChxHdKlmUXpEt(applicationInfo));
        tAiOmxeLWZNGEnxe(objectEncoderobject, ANDROIDAPPINFO_DESCRIPTOR, szAsUorNzJmVYGUh(applicationInfo));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        VfqVzfYnMVGHbQvW(this, (com.google.firebase.sessions.ApplicationInfo) obj, objectEncoderobject);
    }
}

