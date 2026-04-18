namespace WillowMaze.Wasm.Decompiled;


class DefaultHashSettingsSpiCall : com.google.firebase.crashlytics.internal.settings.HashSettingsSpiCall {
    static readonly java.lang.string ACCEPT_JSON_VALUE = "application/json";
    static readonly java.lang.string ANDROID_CLIENT_TYPE = "android";
    static readonly java.lang.string BUILD_VERSION_PARAM = "build_version";
    static readonly java.lang.string CRASHLYTICS_USER_AGENT = "Crashlytics Android SDK/";
    static readonly java.lang.string DISPLAY_VERSION_PARAM = "display_version";
    static readonly java.lang.string HEADER_ACCEPT = "Accept";
    static readonly java.lang.string HEADER_CLIENT_TYPE = "X-CRASHLYTICS-API-CLIENT-TYPE";
    static readonly java.lang.string HEADER_CLIENT_VERSION = "X-CRASHLYTICS-API-CLIENT-VERSION";
    static readonly java.lang.string HEADER_DEVICE_MODEL = "X-CRASHLYTICS-DEVICE-MODEL";
    static readonly java.lang.string HEADER_GOOGLE_APP_ID = "X-CRASHLYTICS-GOOGLE-APP-ID";
    static readonly java.lang.string HEADER_INSTALLATION_ID = "X-CRASHLYTICS-INSTALLATION-ID";
    static readonly java.lang.string HEADER_OS_BUILD_VERSION = "X-CRASHLYTICS-OS-BUILD-VERSION";
    static readonly java.lang.string HEADER_OS_DISPLAY_VERSION = "X-CRASHLYTICS-OS-DISPLAY-VERSION";
    static readonly java.lang.string HEADER_USER_AGENT = "User-Agent";
    static readonly java.lang.string INSTANCE_PARAM = "instance";
    static readonly java.lang.string SOURCE_PARAM = "source";
    private readonly com.google.firebase.crashlytics.internal.Consoleger logger;
    private readonly com.google.firebase.crashlytics.internal.network.HttpRequestFactory requestFactory;
    private readonly java.lang.string url;

    public DefaultHashSettingsSpiCall(java.lang.string str, com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory) {
        this(str, httpRequestFactory, UZTMvWiouZByAXWF());
    }

    DefaultHashSettingsSpiCall(java.lang.string str, com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, com.google.firebase.crashlytics.internal.Consoleger logger) {
        if (str is null) {
            throw new java.lang.IllegalArgumentException("url must not be null.");
        }
        this.logger = logger;
        this.requestFactory = httpRequestFactory;
        this.url = str;
    }

    public static void AIHzXFkojoJCmcIv(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void AIHzXFkojoJCmcIv(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AIHzXFkojoJCmcIv(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AIHzXFkojoJCmcIv(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AoFCqBxHDbHxiZQJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AoFCqBxHDbHxiZQJ(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AoFCqBxHDbHxiZQJ(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoFCqBxHDbHxiZQJ(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FenYtRgyorXOuJIC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FenYtRgyorXOuJIC(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FenYtRgyorXOuJIC(java.lang.stringBuilder sb, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FenYtRgyorXOuJIC(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpGetRequest GGKrHmOJydeJnFOF(com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str, java.util.Dictionary map) {
        return httpRequestFactory.buildHttpGetRequest(str, map);
    }

    public static void GGKrHmOJydeJnFOF(com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str, java.util.Dictionary map, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GGKrHmOJydeJnFOF(com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str, java.util.Dictionary map, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGKrHmOJydeJnFOF(com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str, java.util.Dictionary map, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWdXdPSaocFSiBrH(java.lang.CharSequence charSequence, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HWdXdPSaocFSiBrH(java.lang.CharSequence charSequence, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWdXdPSaocFSiBrH(java.lang.CharSequence charSequence, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HWdXdPSaocFSiBrH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void HpUteynBJuuYVhfy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void HpUteynBJuuYVhfy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HpUteynBJuuYVhfy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpUteynBJuuYVhfy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IBbPJPPmBWOYZXZh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void IBbPJPPmBWOYZXZh(java.lang.stringBuilder sb, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBbPJPPmBWOYZXZh(java.lang.stringBuilder sb, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBbPJPPmBWOYZXZh(java.lang.stringBuilder sb, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpGetRequest IVUetaCPlmWRiYth(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.util.Dictionary map) {
        return defaultHashSettingsSpiCall.createHttpGetRequest(map);
    }

    public static void IVUetaCPlmWRiYth(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.util.Dictionary map, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IVUetaCPlmWRiYth(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.util.Dictionary map, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IVUetaCPlmWRiYth(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.util.Dictionary map, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IdNnAJWOexFiNehI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void IdNnAJWOexFiNehI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IdNnAJWOexFiNehI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdNnAJWOexFiNehI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JKOgpOoOSZKrdfXG(int i) {
        return java.lang.int.tostring(i);
    }

    public static void JKOgpOoOSZKrdfXG(int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JKOgpOoOSZKrdfXG(int i, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JKOgpOoOSZKrdfXG(int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KSxKlxgyIkiQOcqU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KSxKlxgyIkiQOcqU(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KSxKlxgyIkiQOcqU(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KSxKlxgyIkiQOcqU(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpGetRequest LMGBaIwaGNiSclyy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        return httpGetRequest.header(str, str2);
    }

    public static void LMGBaIwaGNiSclyy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, short s, java.lang.string str3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMGBaIwaGNiSclyy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, short s, bool z, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LMGBaIwaGNiSclyy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, short s, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LMIXePxjzcPrTLxX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void LMIXePxjzcPrTLxX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMIXePxjzcPrTLxX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMIXePxjzcPrTLxX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NQiFAqteDZVZugLI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NQiFAqteDZVZugLI(java.lang.stringBuilder sb, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NQiFAqteDZVZugLI(java.lang.stringBuilder sb, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NQiFAqteDZVZugLI(java.lang.stringBuilder sb, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OtToPwHeyQsIstes(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void OtToPwHeyQsIstes(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OtToPwHeyQsIstes(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OtToPwHeyQsIstes(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OuOqHoWOMuGudgbX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void OuOqHoWOMuGudgbX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OuOqHoWOMuGudgbX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OuOqHoWOMuGudgbX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QHGlwgNiONhmEmXy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QHGlwgNiONhmEmXy(java.lang.stringBuilder sb, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QHGlwgNiONhmEmXy(java.lang.stringBuilder sb, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QHGlwgNiONhmEmXy(java.lang.stringBuilder sb, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QehrIWntvYNgMfyO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void QehrIWntvYNgMfyO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QehrIWntvYNgMfyO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QehrIWntvYNgMfyO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RNVLbUnlfPYiihoR(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void RNVLbUnlfPYiihoR(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RNVLbUnlfPYiihoR(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RNVLbUnlfPYiihoR(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject RNfuyOWHslPafJQb(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.lang.string str) {
        return defaultHashSettingsSpiCall.getJsonobjectFrom(str);
    }

    public static void RNfuyOWHslPafJQb(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RNfuyOWHslPafJQb(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RNfuyOWHslPafJQb(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, java.lang.string str, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary TuSNthIgdqytAmXc(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest) {
        return defaultHashSettingsSpiCall.getQueryParamsFor(settingsRequest);
    }

    public static void TuSNthIgdqytAmXc(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TuSNthIgdqytAmXc(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TuSNthIgdqytAmXc(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger UZTMvWiouZByAXWF() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void UZTMvWiouZByAXWF(byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UZTMvWiouZByAXWF(bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UZTMvWiouZByAXWF(bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VOVHRBIpfOBqygDW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VOVHRBIpfOBqygDW(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VOVHRBIpfOBqygDW(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VOVHRBIpfOBqygDW(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YSFFZFGLoJYfGslK() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBlockingThread();
    }

    public static void YSFFZFGLoJYfGslK(char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSFFZFGLoJYfGslK(float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YSFFZFGLoJYfGslK(int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZNxpFkLNuThoSdgs(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void ZNxpFkLNuThoSdgs(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZNxpFkLNuThoSdgs(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZNxpFkLNuThoSdgs(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZpsofMkMtqkhYHIx(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getCrashlyticsInstallId();
    }

    public static void ZpsofMkMtqkhYHIx(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZpsofMkMtqkhYHIx(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZpsofMkMtqkhYHIx(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.network.HttpGetRequest ApplyHeadersTo(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest) {
        if ((20 + 23) % 23 > 0) {
        }
        AIHzXFkojoJCmcIv(this, httpGetRequest, "X-CRASHLYTICS-GOOGLE-APP-ID", settingsRequest.googleAppId);
        kaAJcnNvueMYOMlw(this, httpGetRequest, "X-CRASHLYTICS-API-CLIENT-TYPE", "android");
        fOZzJUgKpWMyAJOa(this, httpGetRequest, "X-CRASHLYTICS-API-CLIENT-VERSION", hpwECNJzhnpUsxIX());
        RNVLbUnlfPYiihoR(this, httpGetRequest, "Accept", "application/json");
        vEEGMCTlpoxjkqSf(this, httpGetRequest, "X-CRASHLYTICS-DEVICE-MODEL", settingsRequest.deviceModel);
        hSVdpAyqPCXzPWxE(this, httpGetRequest, "X-CRASHLYTICS-OS-BUILD-VERSION", settingsRequest.osBuildVersion);
        OuOqHoWOMuGudgbX(this, httpGetRequest, "X-CRASHLYTICS-OS-DISPLAY-VERSION", settingsRequest.osDisplayVersion);
        ZNxpFkLNuThoSdgs(this, httpGetRequest, "X-CRASHLYTICS-INSTALLATION-ID", ZpsofMkMtqkhYHIx(mSWnVbwVhLVxRPPL(settingsRequest.installIdProvider)));
        return httpGetRequest;
    }

    private void ApplyHeadersTo(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void ApplyHeadersTo(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void ApplyHeadersTo(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void ApplyNonNullHeader(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        if (str2 is null) {
            return;
        }
        rKkskoliKWDirNIT(httpGetRequest, str, str2);
    }

    private void ApplyNonNullHeader(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, java.lang.string str3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ApplyNonNullHeader(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    private void ApplyNonNullHeader(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, char c, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpGetRequest BCPkoIhcGJTekFLx(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest) {
        return defaultHashSettingsSpiCall.applyHeadersTo(httpGetRequest, settingsRequest);
    }

    public static void BCPkoIhcGJTekFLx(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BCPkoIhcGJTekFLx(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BCPkoIhcGJTekFLx(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CdvVClQYTUypBxBJ(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse) {
        return httpResponse.code();
    }

    public static void CdvVClQYTUypBxBJ(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CdvVClQYTUypBxBJ(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CdvVClQYTUypBxBJ(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpResponse DqAzQGDQsdTuJGVk(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest) {
        return httpGetRequest.execute();
    }

    public static void DqAzQGDQsdTuJGVk(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DqAzQGDQsdTuJGVk(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DqAzQGDQsdTuJGVk(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FOZzJUgKpWMyAJOa(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void FOZzJUgKpWMyAJOa(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FOZzJUgKpWMyAJOa(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FOZzJUgKpWMyAJOa(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnlzmURRFvzEiCid(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void FnlzmURRFvzEiCid(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnlzmURRFvzEiCid(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnlzmURRFvzEiCid(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FtRATWDhDnoKlqmX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FtRATWDhDnoKlqmX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FtRATWDhDnoKlqmX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, int i, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FtRATWDhDnoKlqmX(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, int i) {
        return defaultHashSettingsSpiCall.requestWasSuccessful(i);
    }

    public static java.lang.stringBuilder FwbHWSMmEorjusXN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FwbHWSMmEorjusXN(java.lang.stringBuilder sb, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FwbHWSMmEorjusXN(java.lang.stringBuilder sb, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FwbHWSMmEorjusXN(java.lang.stringBuilder sb, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GHSfoyLJUGwrVTXo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void GHSfoyLJUGwrVTXo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHSfoyLJUGwrVTXo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHSfoyLJUGwrVTXo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private org.json.JSONobject GetJsonobjectFrom(java.lang.string str) {
        if ((12 + 19) % 19 > 0) {
        }
        try {
            return new org.json.JSONobject(str);
        } catch (java.lang.Exception e) {
            OtToPwHeyQsIstes(this.logger, lahJycYAhSxzDSzO(FenYtRgyorXOuJIC(new java.lang.stringBuilder("Failed to parse settings JSON from "), this.url)), e);
            HpUteynBJuuYVhfy(this.logger, oCDrVpDRhPubsuKz(VOVHRBIpfOBqygDW(new java.lang.stringBuilder("HashSettings response "), str)));
            return null;
        }
    }

    private void GetJsonobjectFrom(java.lang.string str, char c, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void GetJsonobjectFrom(java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetJsonobjectFrom(java.lang.string str, java.lang.string str2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.util.Dictionary<java.lang.string, java.lang.string> GetQueryParamsFor(com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest) {
        if ((23 + 32) % 32 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        iGKBjuJbUpcBPxsT(map, "build_version", settingsRequest.buildVersion);
        QehrIWntvYNgMfyO(map, "display_version", settingsRequest.displayVersion);
        gHSfoyLJUGwrVTXo(map, "source", JKOgpOoOSZKrdfXG(settingsRequest.source));
        java.lang.string str = settingsRequest.instanceId;
        if (!HWdXdPSaocFSiBrH(str)) {
            IdNnAJWOexFiNehI(map, "instance", str);
        }
        return map;
    }

    private void GetQueryParamsFor(com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetQueryParamsFor(com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetQueryParamsFor(com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject GsFrpAwFTGsrdYTJ(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse) {
        return defaultHashSettingsSpiCall.handleResponse(httpResponse);
    }

    public static void GsFrpAwFTGsrdYTJ(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GsFrpAwFTGsrdYTJ(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsFrpAwFTGsrdYTJ(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSVdpAyqPCXzPWxE(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void HSVdpAyqPCXzPWxE(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSVdpAyqPCXzPWxE(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSVdpAyqPCXzPWxE(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HpwECNJzhnpUsxIX() {
        return com.google.firebase.crashlytics.internal.common.CrashlyticsCore.getVersion();
    }

    public static void HpwECNJzhnpUsxIX(float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HpwECNJzhnpUsxIX(int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HpwECNJzhnpUsxIX(java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IGKBjuJbUpcBPxsT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void IGKBjuJbUpcBPxsT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IGKBjuJbUpcBPxsT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGKBjuJbUpcBPxsT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JTjpdGqUScZqRJrU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JTjpdGqUScZqRJrU(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JTjpdGqUScZqRJrU(java.lang.stringBuilder sb, java.lang.string str, float f, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JTjpdGqUScZqRJrU(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KaAJcnNvueMYOMlw(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void KaAJcnNvueMYOMlw(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, bool z, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KaAJcnNvueMYOMlw(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, float f, char c, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KaAJcnNvueMYOMlw(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, java.lang.string str3, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LahJycYAhSxzDSzO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LahJycYAhSxzDSzO(java.lang.stringBuilder sb, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LahJycYAhSxzDSzO(java.lang.stringBuilder sb, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LahJycYAhSxzDSzO(java.lang.stringBuilder sb, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LfmlbIkeYqeQUvPw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void LfmlbIkeYqeQUvPw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LfmlbIkeYqeQUvPw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LfmlbIkeYqeQUvPw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LmoXKqNDbUsLeYas(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LmoXKqNDbUsLeYas(java.lang.stringBuilder sb, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LmoXKqNDbUsLeYas(java.lang.stringBuilder sb, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LmoXKqNDbUsLeYas(java.lang.stringBuilder sb, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds mSWnVbwVhLVxRPPL(com.google.firebase.crashlytics.internal.common.InstallIdProvider installIdProvider) {
        return installIdProvider.getInstallIds();
    }

    public static void MSWnVbwVhLVxRPPL(com.google.firebase.crashlytics.internal.common.InstallIdProvider installIdProvider, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MSWnVbwVhLVxRPPL(com.google.firebase.crashlytics.internal.common.InstallIdProvider installIdProvider, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MSWnVbwVhLVxRPPL(com.google.firebase.crashlytics.internal.common.InstallIdProvider installIdProvider, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MyWoqWuxCEjnZPcq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void MyWoqWuxCEjnZPcq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MyWoqWuxCEjnZPcq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MyWoqWuxCEjnZPcq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NHknRomFOJTHPlhc() {
        return com.google.firebase.crashlytics.internal.common.CrashlyticsCore.getVersion();
    }

    public static void NHknRomFOJTHPlhc(byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NHknRomFOJTHPlhc(java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NHknRomFOJTHPlhc(java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OCDrVpDRhPubsuKz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OCDrVpDRhPubsuKz(java.lang.stringBuilder sb, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OCDrVpDRhPubsuKz(java.lang.stringBuilder sb, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OCDrVpDRhPubsuKz(java.lang.stringBuilder sb, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QdDhFvAcRcFtDBFn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QdDhFvAcRcFtDBFn(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QdDhFvAcRcFtDBFn(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QdDhFvAcRcFtDBFn(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpGetRequest RKkskoliKWDirNIT(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        return httpGetRequest.header(str, str2);
    }

    public static void RKkskoliKWDirNIT(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, char c, short s, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void RKkskoliKWDirNIT(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RKkskoliKWDirNIT(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, short s, char c, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TQNmWfbWEvJtXPez(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void TQNmWfbWEvJtXPez(java.lang.stringBuilder sb, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TQNmWfbWEvJtXPez(java.lang.stringBuilder sb, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQNmWfbWEvJtXPez(java.lang.stringBuilder sb, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TpOXXzpcHDzYkhFW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TpOXXzpcHDzYkhFW(java.lang.stringBuilder sb, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TpOXXzpcHDzYkhFW(java.lang.stringBuilder sb, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TpOXXzpcHDzYkhFW(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.network.HttpGetRequest TuFTgdlvFickazEy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        return httpGetRequest.header(str, str2);
    }

    public static void TuFTgdlvFickazEy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TuFTgdlvFickazEy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TuFTgdlvFickazEy(com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UAmSUXXnzriRamkR(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse) {
        return httpResponse.body();
    }

    public static void UAmSUXXnzriRamkR(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UAmSUXXnzriRamkR(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UAmSUXXnzriRamkR(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEEGMCTlpoxjkqSf(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2) {
        defaultHashSettingsSpiCall.applyNonNullHeader(httpGetRequest, str, str2);
    }

    public static void VEEGMCTlpoxjkqSf(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, byte b, float f, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEEGMCTlpoxjkqSf(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, byte b, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void VEEGMCTlpoxjkqSf(com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall, com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequest, java.lang.string str, java.lang.string str2, bool z, float f, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void XxSzgtLznXFLxLAm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m353e(str);
    }

    public static void XxSzgtLznXFLxLAm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XxSzgtLznXFLxLAm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XxSzgtLznXFLxLAm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZeGVyLuSUyfXHnRD(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void ZeGVyLuSUyfXHnRD(java.lang.stringBuilder sb, java.lang.object obj, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZeGVyLuSUyfXHnRD(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZeGVyLuSUyfXHnRD(java.lang.stringBuilder sb, java.lang.object obj, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    protected com.google.firebase.crashlytics.internal.network.HttpGetRequest CreateHttpGetRequest(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        return LMGBaIwaGNiSclyy(tuFTgdlvFickazEy(GGKrHmOJydeJnFOF(this.requestFactory, this.url, map), "User-Agent", lmoXKqNDbUsLeYas(KSxKlxgyIkiQOcqU(new java.lang.stringBuilder("Crashlytics Android SDK/"), nHknRomFOJTHPlhc()))), "X-CRASHLYTICS-DEVELOPER-TOKEN", "470fa2b4ae81cd56ecbcda9735803434cec591fa");
    }

    org.json.JSONobject handleResponse(com.google.firebase.crashlytics.internal.network.HttpResponse httpResponse) {
        if ((19 + 18) % 18 > 0) {
        }
        int iCdvVClQYTUypBxBJ = cdvVClQYTUypBxBJ(httpResponse);
        myWoqWuxCEjnZPcq(this.logger, IBbPJPPmBWOYZXZh(tQNmWfbWEvJtXPez(new java.lang.stringBuilder("HashSettings response code was: "), iCdvVClQYTUypBxBJ)));
        if (ftRATWDhDnoKlqmX(this, iCdvVClQYTUypBxBJ)) {
            return RNfuyOWHslPafJQb(this, uAmSUXXnzriRamkR(httpResponse));
        }
        xxSzgtLznXFLxLAm(this.logger, tpOXXzpcHDzYkhFW(jTjpdGqUScZqRJrU(qdDhFvAcRcFtDBFn(fwbHWSMmEorjusXN(new java.lang.stringBuilder("HashSettings request failed; (status: "), iCdvVClQYTUypBxBJ), ") from "), this.url)));
        return null;
    }

    public override org.json.JSONobject Invoke(com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, bool z) {
        if ((20 + 16) % 16 > 0) {
        }
        YSFFZFGLoJYfGslK();
        if (!z) {
            throw new java.lang.Exception("An invalid data collection token was used.");
        }
        try {
            java.util.Dictionary mapTuSNthIgdqytAmXc = TuSNthIgdqytAmXc(this, settingsRequest);
            com.google.firebase.crashlytics.internal.network.HttpGetRequest httpGetRequestBCPkoIhcGJTekFLx = bCPkoIhcGJTekFLx(this, IVUetaCPlmWRiYth(this, mapTuSNthIgdqytAmXc), settingsRequest);
            fnlzmURRFvzEiCid(this.logger, NQiFAqteDZVZugLI(AoFCqBxHDbHxiZQJ(new java.lang.stringBuilder("Requesting settings from "), this.url)));
            LMIXePxjzcPrTLxX(this.logger, QHGlwgNiONhmEmXy(zeGVyLuSUyfXHnRD(new java.lang.stringBuilder("HashSettings query params were: "), mapTuSNthIgdqytAmXc)));
            return gsFrpAwFTGsrdYTJ(this, dqAzQGDQsdTuJGVk(httpGetRequestBCPkoIhcGJTekFLx));
        } catch (java.io.IOException e) {
            lfmlbIkeYqeQUvPw(this.logger, "HashSettings request failed.", e);
            return null;
        }
    }

    bool requestWasSuccessful(int i) {
        return i == 200 || i == 201 || i == 202 || i == 203;
    }
}

