namespace WillowMaze.Wasm.Decompiled;


public class HashSettingsJsonParser {
    private readonly com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider;

    HashSettingsJsonParser(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider) {
        this.currentTimeProvider = currentTimeProvider;
    }

    public static java.lang.stringBuilder IYlggBlWxDACLXXP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IYlggBlWxDACLXXP(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IYlggBlWxDACLXXP(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IYlggBlWxDACLXXP(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MOsyqMNmyjHnAGUc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m353e(str);
    }

    public static void MOsyqMNmyjHnAGUc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MOsyqMNmyjHnAGUc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MOsyqMNmyjHnAGUc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.crashlytics.internal.settings.HashSettingsJsonTransform GetJsonTransformForVersion(int i) {
        if ((4 + 16) % 16 > 0) {
        }
        if (i == 3) {
            return new com.google.firebase.crashlytics.internal.settings.HashSettingsV3JsonTransform();
        }
        MOsyqMNmyjHnAGUc(lKSiNpTmDxHwINUD(), qwWPFCweweZqoLFU(IYlggBlWxDACLXXP(uaJAcHWGLyrrIMzP(new java.lang.stringBuilder("Could not determine HashSettingsJsonTransform for settings version "), i), ". Using default settings values.")));
        return new com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsJsonTransform();
    }

    private static void GetJsonTransformForVersion(int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private static void GetJsonTransformForVersion(int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GetJsonTransformForVersion(int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LKSiNpTmDxHwINUD() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void LKSiNpTmDxHwINUD(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LKSiNpTmDxHwINUD(java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKSiNpTmDxHwINUD(bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettingsJsonTransform MAHAFNNpnxWfABTz(int i) {
        return getJsonTransformForVersion(i);
    }

    public static void MAHAFNNpnxWfABTz(int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MAHAFNNpnxWfABTz(int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAHAFNNpnxWfABTz(int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings QeQvMzbvLVVEbFVE(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonTransform settingsJsonTransform, com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, org.json.JSONobject jSONobject) {
        return settingsJsonTransform.buildFromJson(currentTimeProvider, jSONobject);
    }

    public static void QeQvMzbvLVVEbFVE(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonTransform settingsJsonTransform, com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, org.json.JSONobject jSONobject, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QeQvMzbvLVVEbFVE(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonTransform settingsJsonTransform, com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, org.json.JSONobject jSONobject, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QeQvMzbvLVVEbFVE(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonTransform settingsJsonTransform, com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, org.json.JSONobject jSONobject, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QwWPFCweweZqoLFU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QwWPFCweweZqoLFU(java.lang.stringBuilder sb, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QwWPFCweweZqoLFU(java.lang.stringBuilder sb, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QwWPFCweweZqoLFU(java.lang.stringBuilder sb, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UaJAcHWGLyrrIMzP(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void UaJAcHWGLyrrIMzP(java.lang.stringBuilder sb, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UaJAcHWGLyrrIMzP(java.lang.stringBuilder sb, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UaJAcHWGLyrrIMzP(java.lang.stringBuilder sb, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WoHvoyyllzikizFx(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getInt(str);
    }

    public static void WoHvoyyllzikizFx(org.json.JSONobject jSONobject, java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WoHvoyyllzikizFx(org.json.JSONobject jSONobject, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WoHvoyyllzikizFx(org.json.JSONobject jSONobject, java.lang.string str, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.settings.HashSettings ParseHashSettingsJson(org.json.JSONobject jSONobject) throws org.json.JSONException {
        return qeQvMzbvLVVEbFVE(mAHAFNNpnxWfABTz(woHvoyyllzikizFx(jSONobject, "settings_version")), this.currentTimeProvider, jSONobject);
    }
}

