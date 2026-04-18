namespace WillowMaze.Wasm.Decompiled;


readonly class AutoSessionEventEncoder$AndroidApplicationInfoEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.sessions.AndroidApplicationInfo> {
    static readonly com.google.firebase.sessions.AutoSessionEventEncoder$AndroidApplicationInfoEncoder INSTANCE = new com.google.firebase.sessions.AutoSessionEventEncoder$AndroidApplicationInfoEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor PACKAGENAME_DESCRIPTOR = ekXktTlDejeTPPdb("packageName");
    private static readonly com.google.firebase.encoders.FieldDescriptor VERSIONNAME_DESCRIPTOR = QwmLtyKdkoKMRHJS("versionName");
    private static readonly com.google.firebase.encoders.FieldDescriptor APPBUILDVERSION_DESCRIPTOR = RrHjKNUmjrJdhixE("appBuildVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor DEVICEMANUFACTURER_DESCRIPTOR = oWTYOVDaGWFBYktn("deviceManufacturer");
    private static readonly com.google.firebase.encoders.FieldDescriptor CURRENTPROCESSDETAILS_DESCRIPTOR = bJvuDEYgYvunaquz("currentProcessDetails");
    private static readonly com.google.firebase.encoders.FieldDescriptor APPPROCESSDETAILS_DESCRIPTOR = caLseNdtWnTjYZiN("appProcessDetails");

    private AutoSessionEventEncoder$AndroidApplicationInfoEncoder() {
    }

    public static com.google.firebase.sessions.ProcessDetails GcYBqWAhiVBhEUtN(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getCurrentProcessDetails();
    }

    public static com.google.firebase.encoders.FieldDescriptor QwmLtyKdkoKMRHJS(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor RrHjKNUmjrJdhixE(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject TTqVEGuaqXPUnItu(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string YMxziFaXMRKwYHEE(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getDeviceManufacturer();
    }

    public static com.google.firebase.encoders.FieldDescriptor BJvuDEYgYvunaquz(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.util.List CFabCWEYMUNbYqaC(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getAppProcessDetails();
    }

    public static com.google.firebase.encoders.FieldDescriptor CaLseNdtWnTjYZiN(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string ChYMWhSFegDgbEyU(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getVersionName();
    }

    public static com.google.firebase.encoders.objectEncoderobject DOezMKIdyDCRArTX(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject EigoXLrmJXEmHdIv(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor EkXktTlDejeTPPdb(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void HVXtNAJlliuFLMcF(com.google.firebase.sessions.AutoSessionEventEncoder$AndroidApplicationInfoEncoder autoSessionEventEncoder$AndroidApplicationInfoEncoder, com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoSessionEventEncoder$AndroidApplicationInfoEncoder.encode(androidApplicationInfo, objectEncoderobject);
    }

    public static com.google.firebase.encoders.objectEncoderobject JQfgumXjAoIPJcwp(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string LAhvcbOLsYPhqXaU(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getAppBuildVersion();
    }

    public static java.lang.string LXYNxvaXqPdzqhBn(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.getPackageName();
    }

    public static com.google.firebase.encoders.FieldDescriptor OWTYOVDaGWFBYktn(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject RXtqVCZVuYapbHeL(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject RtNkWibaholZozaa(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public void Encode(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        dOezMKIdyDCRArTX(objectEncoderobject, PACKAGENAME_DESCRIPTOR, lXYNxvaXqPdzqhBn(androidApplicationInfo));
        rXtqVCZVuYapbHeL(objectEncoderobject, VERSIONNAME_DESCRIPTOR, chYMWhSFegDgbEyU(androidApplicationInfo));
        TTqVEGuaqXPUnItu(objectEncoderobject, APPBUILDVERSION_DESCRIPTOR, lAhvcbOLsYPhqXaU(androidApplicationInfo));
        rtNkWibaholZozaa(objectEncoderobject, DEVICEMANUFACTURER_DESCRIPTOR, YMxziFaXMRKwYHEE(androidApplicationInfo));
        eigoXLrmJXEmHdIv(objectEncoderobject, CURRENTPROCESSDETAILS_DESCRIPTOR, GcYBqWAhiVBhEUtN(androidApplicationInfo));
        jQfgumXjAoIPJcwp(objectEncoderobject, APPPROCESSDETAILS_DESCRIPTOR, cFabCWEYMUNbYqaC(androidApplicationInfo));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        hVXtNAJlliuFLMcF(this, (com.google.firebase.sessions.AndroidApplicationInfo) obj, objectEncoderobject);
    }
}

