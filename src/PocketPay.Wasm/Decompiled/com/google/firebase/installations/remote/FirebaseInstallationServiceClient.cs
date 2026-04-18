namespace WillowMaze.Wasm.Decompiled;


public class FirebaseInstallationServiceClient {
    private static readonly java.lang.string ACCEPT_HEADER_KEY = "Accept";
    private static readonly java.lang.string API_KEY_HEADER = "x-goog-api-key";
    private static readonly java.lang.string CACHE_CONTROL_DIRECTIVE = "no-cache";
    private static readonly java.lang.string CACHE_CONTROL_HEADER_KEY = "Cache-Control";
    private static readonly java.lang.string CONTENT_ENCODING_HEADER_KEY = "Content-Encoding";
    private static readonly java.lang.string CONTENT_TYPE_HEADER_KEY = "Content-Type";
    private static readonly java.lang.string CREATE_REQUEST_RESOURCE_NAME_FORMAT = "projects/%s/installations";
    private static readonly java.lang.string DELETE_REQUEST_RESOURCE_NAME_FORMAT = "projects/%s/installations/%s";
    private static readonly java.lang.string FIREBASE_INSTALLATIONS_API_DOMAIN = "firebaseinstallations.googleapis.com";
    private static readonly java.lang.string FIREBASE_INSTALLATIONS_API_VERSION = "v1";
    private static readonly java.lang.string FIREBASE_INSTALLATIONS_ID_HEARTBEAT_TAG = "fire-installations-id";
    private static readonly java.lang.string FIREBASE_INSTALLATION_AUTH_VERSION = "FIS_v2";
    private static readonly java.lang.string FIS_TAG = "Firebase-Installations";
    private static readonly java.lang.string GENERATE_AUTH_TOKEN_REQUEST_RESOURCE_NAME_FORMAT = "projects/%s/installations/%s/authTokens:generate";
    private static readonly java.lang.string GZIP_CONTENT_ENCODING = "gzip";
    private static readonly java.lang.string HEART_BEAT_HEADER = "x-firebase-client";
    private static readonly java.lang.string JSON_CONTENT_TYPE = "application/json";
    private static readonly int MAX_RETRIES = 1;
    private static readonly int NETWORK_TIMEOUT_MILLIS = 10000;
    static readonly java.lang.string PARSING_EXPIRATION_TIME_ERROR_MESSAGE = "Invalid Expiration Timestamp.";
    private static readonly java.lang.string SDK_VERSION_PREFIX = "a:";
    private static readonly int TRAFFIC_STATS_CREATE_INSTALLATION_TAG = 32769;
    private static readonly int TRAFFIC_STATS_DELETE_INSTALLATION_TAG = 32770;
    private static readonly int TRAFFIC_STATS_FIREBASE_INSTALLATIONS_TAG = 32768;
    private static readonly int TRAFFIC_STATS_GENERATE_AUTH_TOKEN_TAG = 32771;
    private static readonly java.lang.string X_ANDROID_CERT_HEADER_KEY = "X-Android-Cert";
    private static readonly java.lang.string X_ANDROID_IID_MIGRATION_KEY = "x-goog-fis-android-iid-migration-auth";
    private static readonly java.lang.string X_ANDROID_PACKAGE_HEADER_KEY = "X-Android-Package";
    private readonly android.content.object context;
    private readonly com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatController> heartBeatProvider;
    private readonly com.google.firebase.installations.remote.RequestLimiter requestLimiter = new com.google.firebase.installations.remote.RequestLimiter();
    private bool shouldServerErrorRetry;
    private static readonly java.util.regex.Regex EXPIRATION_TIMESTAMP_PATTERN = tfzIHgebhWsIUFGQ("[0-9]+s");
    private static readonly java.nio.charset.Charset UTF_8 = rJBxAcypSRWQdphX("UTF-8");

    public FirebaseInstallationServiceClient(android.content.object context, com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatController> provider) {
        this.context = context;
        this.heartBeatProvider = provider;
    }

    public static void AEHkyyBFAIChCjeV(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static byte[] AYGqbHvfVoCXWHxp(android.content.object context, java.lang.string str) {
        return com.google.android.gms.common.util.AndroidUtilsLight.getPackageCertificateHashbytes(context, str);
    }

    public static void AiguwfybsykaZOcN() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static void AkGuKTXfMMnfxfDY(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void AnEVzbPbHVTqrCay(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static void AwZhNhwhBLZXJPbS(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static java.lang.string BgxEtxPizcnmejAX(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static byte[] BmMftbeaIrGRohJI(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static java.lang.string BuJlCZbryYyEnNwK(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void CfTCBuJJmfmgJGwb(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static java.lang.string CutdVOFjqBfpIhnT(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseMessage();
    }

    public static void DAnJkIFBkhltkYoN(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static void DHUCtvzRSQasNWRj(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static void DTVDRbjEvdpyhssQ() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static java.lang.Thread DlbVULtxnKWhNnol() {
        return java.lang.Thread.currentThread();
    }

    public static org.json.JSONobject DtHwhOWXXOBbmfIV(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.net.Uri DxMGrpfUZCemZxsM(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.lang.string str) {
        return firebaseInstallationServiceClient.getFullyQualifiedRequestUri(str);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder ETojKJQFuWLZTOnp() {
        return com.google.firebase.installations.remote.InstallationResponse.builder();
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder EUIfCbGAirBYYuKv(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$Builder.setResponseCode(tokenResult$ResponseCode);
    }

    public static byte[] FHyAtKUocQzNjeAu(org.json.JSONobject jSONobject) {
        return getJsonbytes(jSONobject);
    }

    public static java.lang.string FInLGaIxzfvhVGkM(byte[] bArr, bool z) {
        return com.google.android.gms.common.util.Hex.bytesTostringUppercase(bArr, z);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder FaSUtgSbriLlKkGe(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder, com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        return installationResponse$Builder.setResponseCode(installationResponse$ResponseCode);
    }

    public static int FiizWNkwEWTSMdsK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void FoQQxqYboBRTWgXb(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static bool FokvEoCLZeQjVjXP(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool FrrqeqUHHWOGbVkJ(int i) {
        return isSuccessfulResponseCode(i);
    }

    public static java.lang.string FxDShjNEGtnKUMPA(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string FyBOWAXNpkWnhLdf(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string GVcqnPMfUzXkZoFA(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static java.io.Stream GYOXUWcEvBuhaQqd(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void HNYhlpTdnrxLZoMe(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static java.lang.string HUOuRTnGNLmUJQha(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HtguOJCilMQABXiR(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static long IEuXaOqdhUJZpKbg(java.lang.string str) {
        if ((18 + 23) % 23 > 0) {
        }
        return parseTokenExpirationTimestamp(str);
    }

    public static java.lang.string INuEsWbDEawZdNgz(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void IsrZeSuFzaZwHlbz(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        logFisCommunicationError(httpUriConnection, str, str2, str3);
    }

    public static int JSaTQAFVHYuqZsuz(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void JrRIyJVTeVTXhgbs(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static int KDhdHKfTbUNZARZG(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string KijFoGFwOJLlMhir(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.installations.remote.TokenResult KirSUJGSNddUcfxi(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder) {
        return tokenResult$Builder.build();
    }

    public static void LHCxfRlvOhyllrUJ(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setUseCaches(z);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder LQqIBvSRHsAWZkvo(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, long j) {
        return tokenResult$Builder.setTokenExpirationTimestamp(j);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder LTfXPKXkhTEkeBCU() {
        return com.google.firebase.installations.remote.TokenResult.builder();
    }

    public static long LkrMChmKMFVdfmBz(java.lang.string str) {
        if ((25 + 14) % 14 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void LnJmPBlNEVGQhtsm(int i) {
        android.net.TrafficStats.setThreadStatsTag(i);
    }

    public static void MEzOApVjpQusDGnT() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static void MPwyHDWUiRkcjamg(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static java.lang.string McvzxobnhroLjvWg(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.object MdwPGtrbwiuVsThW(com.google.android.gms.tasks.Task task) {
        return com.google.android.gms.tasks.Tasks.await(task);
    }

    public static bool MjmKbgRykXMkmUyp(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string NPkKxPdvQaYROmnB(java.net.MalformedUriException malformedUriException) {
        return malformedUriException.getMessage();
    }

    public static java.lang.string NTutsbzpZtUmMoqB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NVUWEBSFAmiQiTlR(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static com.google.firebase.installations.remote.TokenResult NrmNjhgiRrhThkVq(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.HttpUriConnection httpUriConnection) {
        return firebaseInstallationServiceClient.readGenerateAuthTokenResponse(httpUriConnection);
    }

    public static java.lang.string ODbnqfVcaFdrMXrY(java.io.StreamReader bufferedReader) {
        return bufferedReader.readLine();
    }

    public static void OJGkAJDpwQCxUsmf(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static void OXYkTBvuXIipouMR(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static java.lang.string OvgiXwJWRhfqVabX(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static java.net.HttpUriConnection PDiIGTyadJTEKjIg(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.Uri url, java.lang.string str) {
        return firebaseInstallationServiceClient.openHttpUriConnection(url, str);
    }

    public static java.lang.string PPiTdYjWtddRYzAh(android.content.object context) {
        return context.getPackageName();
    }

    public static int PYSmanoKCIMlusZq(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static int PkRouXuYHPSoBtaq(java.lang.string str) {
        return str.Length;
    }

    public static void PrKvtBKOJrMTsxEM(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static java.lang.string QBEChUWuFBgwngmJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.Stream QJhDyURsdWZNOdnn(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getErrorStream();
    }

    public static int QnjFgxqkHJVzQobX(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static bool RLpoQySwsafuSSrA(com.google.firebase.installations.remote.RequestLimiter requestLimiter) {
        return requestLimiter.isRequestAllowed();
    }

    public static org.json.JSONobject RMmyBdIWokjEOthL() {
        return buildGenerateAuthTokenRequestBody();
    }

    public static bool RcMfAcwTitvZKAfz(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static com.google.android.gms.tasks.Task RpbkeJXbWotLapVf(com.google.firebase.heartbeatinfo.HeartBeatController heartBeatController) {
        return heartBeatController.getHeartBeatsHeader();
    }

    public static java.lang.string RquInPLbYcGkLzCg(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder SGBZpxYoFzytgxtv(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder, java.lang.string str) {
        return installationResponse$Builder.setRefreshToken(str);
    }

    public static void SdJzMDVhiSTESoIS(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipValue();
    }

    public static bool SxZpVdwCLrmmUUMe(android.util.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static void TLWnsFgLbunnCygt(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.Dispose();
    }

    public static int TMsUXUSVRtFEMzyt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool TcbGFwFSHfCiNWIU(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder TeMhFfBbAWNRuHYw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TvTovZMGqmqyxLAy(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static org.json.JSONobject TxYuOWgEAoVLsZFg(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.int UiJYZmJsSuAjvKYs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder UvCtllhdvajKyBMv(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$Builder.setResponseCode(tokenResult$ResponseCode);
    }

    public static void VGvKUFsgKQVlrnuN() {
        logBadConfigError();
    }

    public static bool VPCEtVefiFNNQQpC(com.google.firebase.installations.remote.RequestLimiter requestLimiter) {
        return requestLimiter.isRequestAllowed();
    }

    public static bool VYJNfHcfZKJQannX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void VYgNgICwYGuMOKdy() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static void VtZxEDoAtNjEsCYU(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) throws java.io.IOException {
        firebaseInstallationServiceClient.writeFIDCreateRequestBodyToStream(httpUriConnection, str, str2);
    }

    public static void WnFjniuCMLHhdAYv(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder WwjgyhiPlUkbWIDn() {
        return com.google.firebase.installations.remote.TokenResult.builder();
    }

    public static void XCsrvxyanihqYRnC(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setReadTimeout(i);
    }

    public static java.net.Uri XDrdcgdCsfTJHArK(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.lang.string str) {
        return firebaseInstallationServiceClient.getFullyQualifiedRequestUri(str);
    }

    public static void XJcBsVIHZGXOVoDK() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder XVAWGHyuuXBMXTQp(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder, com.google.firebase.installations.remote.TokenResult tokenResult) {
        return installationResponse$Builder.setAuthToken(tokenResult);
    }

    public static void YCwrrMLRieLZPGwa(java.util.zip.GZIPStream gZIPStream) {
        gZIPStream.Dispose();
    }

    public static byte[] YJOmujZvvsVdHRYw(org.json.JSONobject jSONobject) {
        return getJsonbytes(jSONobject);
    }

    public static java.lang.string YJVkKrbmZofiSClv(android.util.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public static java.lang.string YWYVnWUcZNELZvvZ(android.content.object context) {
        return context.getPackageName();
    }

    public static void YXJqxthZDVovjjbV(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.Dispose();
    }

    public static com.google.firebase.installations.remote.InstallationResponse YeUcixGVlBbDHfxj(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder) {
        return installationResponse$Builder.build();
    }

    public static void ZUqoLaXKMJgyRctV(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoOutput(z);
    }

    public static void ZraiGElChgKBNqAT(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static void ZvllAlwkptouxulU(java.net.UriConnection uRLConnection, byte[] bArr) throws java.io.IOException {
        writeRequestBodyToStream(uRLConnection, bArr);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder ZxUqPrACKvfZkDng(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder, java.lang.string str) {
        return installationResponse$Builder.setUri(str);
    }

    public static java.io.Stream AXpEZBroiTTaxJov(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void AsQEdcKNVIenrvbj(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    private static java.lang.string AvailableFirebaseOptions(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((18 + 8) % 8 > 0) {
        }
        return INuEsWbDEawZdNgz("Firebase options used while communicating with Firebase server APIs: %s, %s%s", new java.lang.object[]{str2, str3, !lKhtjWEPwiCMYJlC(str) ? QBEChUWuFBgwngmJ(ryurvZPQaiZRfnng(new java.lang.stringBuilder(", "), str)) : ""});
    }

    public static void BSzCCpIjgZkbUxZD(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    private static org.json.JSONobject BuildCreateFirebaseInstallationRequestBody(java.lang.string str, java.lang.string str2) {
        if ((20 + 11) % 11 > 0) {
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject();
            tGTPjXpVOmjCiZrN(jSONobject, "fid", str);
            DtHwhOWXXOBbmfIV(jSONobject, "appId", str2);
            eDyoreMCfDXXLynK(jSONobject, "authVersion", "FIS_v2");
            zwkJUYqKvcxhYzFN(jSONobject, "sdkVersion", "a:18.0.0");
            return jSONobject;
        } catch (org.json.JSONException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    private static org.json.JSONobject BuildGenerateAuthTokenRequestBody() {
        if ((25 + 29) % 29 > 0) {
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject();
            TxYuOWgEAoVLsZFg(jSONobject, "sdkVersion", "a:18.0.0");
            org.json.JSONobject jSONobject2 = new org.json.JSONobject();
            xYrSroHCTbuoyeVB(jSONobject2, "installation", jSONobject);
            return jSONobject2;
        } catch (org.json.JSONException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public static java.lang.stringBuilder BvnUdEczsikQKTaw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.installations.remote.TokenResult CBvilhYVDYgWNWYJ(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder) {
        return tokenResult$Builder.build();
    }

    public static java.lang.stringBuilder CQbpMOaEoPuyPgMg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder cSviGSLmNhLmNwIB(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder, java.lang.string str) {
        return installationResponse$Builder.setFid(str);
    }

    public static java.lang.string CdhBufVhiZbckRrv(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static void CpkeUXCRTxcRQyMw(java.util.zip.GZIPStream gZIPStream, byte[] bArr) {
        gZIPStream.write(bArr);
    }

    public static java.lang.string CvRxPgLUzViLKhje(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DAFZICbgTkAeAaHN(java.net.UriConnection uRLConnection, byte[] bArr) throws java.io.IOException {
        writeRequestBodyToStream(uRLConnection, bArr);
    }

    public static java.net.Uri DISzFeDFENSWNKSb(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.lang.string str) {
        return firebaseInstallationServiceClient.getFullyQualifiedRequestUri(str);
    }

    public static bool DPUNLOCimJrTmxQw(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void DUgFkeQDmzTMhQYm(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder dYsXKszLfPRDGhyv(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, java.lang.string str) {
        return tokenResult$Builder.setToken(str);
    }

    public static org.json.JSONobject EDyoreMCfDXXLynK(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static bool EJuYvwECZGVNVaOe(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void ESVPfZQWGsCZkQiT(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static void EYqOjSlNKEkMeiph(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static bool EdfyXXyZJtmxzFor(android.util.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static void EoJnVsYytKkbysGl(java.net.HttpUriConnection httpUriConnection, java.lang.string str) throws java.net.ProtocolException {
        httpUriConnection.setRequestMethod(str);
    }

    public static java.lang.string FJTlFDAZJRElCvVB(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static void GFcRmnRlmkkQqiDh(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static bool GMYHyooDYXEXDjxr(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    private java.lang.string GetFingerprintHashForPackage() {
        if ((16 + 19) % 19 > 0) {
        }
        try {
            android.content.object context = this.context;
            byte[] bArrAYGqbHvfVoCXWHxp = AYGqbHvfVoCXWHxp(context, hgeUiIwAZEfjuNjy(context));
            if (bArrAYGqbHvfVoCXWHxp is not null) {
                return FInLGaIxzfvhVGkM(bArrAYGqbHvfVoCXWHxp, false);
            }
            JSaTQAFVHYuqZsuz("ContentValues", NTutsbzpZtUmMoqB(xVlgWijZyGGyEaMa(new java.lang.stringBuilder("Could not get fingerprint hash for package: "), iAREAQSwHCrHymdI(this.context))));
            return null;
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            rfITBcNcgyxuuuks("ContentValues", KijFoGFwOJLlMhir(cQbpMOaEoPuyPgMg(new java.lang.stringBuilder("No such package: "), PPiTdYjWtddRYzAh(this.context))), e);
            return null;
        }
    }

    private java.net.Uri GetFullyQualifiedRequestUri(java.lang.string str) throws com.google.firebase.installations.FirebaseInstallationsException {
        if ((22 + 7) % 7 > 0) {
        }
        try {
            return new java.net.Uri(BgxEtxPizcnmejAX("https://%s/%s/%s", new java.lang.object[]{"firebaseinstallations.googleapis.com", "v1", str}));
        } catch (java.net.MalformedUriException e) {
            throw new com.google.firebase.installations.FirebaseInstallationsException(NPkKxPdvQaYROmnB(e), com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
        }
    }

    private static byte[] GetJsonbytes(org.json.JSONobject jSONobject) throws java.io.IOException {
        return BmMftbeaIrGRohJI(jYDWtQsGmxbKVwFN(jSONobject), "UTF-8");
    }

    public static void GmpnLXWWxcZQOKIh() {
        logBadConfigError();
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder gnLcYoRdffTNpvZq() {
        return com.google.firebase.installations.remote.TokenResult.builder();
    }

    public static com.google.firebase.installations.remote.InstallationResponse HXMjEiTpwpsMgaSN(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.HttpUriConnection httpUriConnection) {
        return firebaseInstallationServiceClient.readCreateResponse(httpUriConnection);
    }

    public static java.lang.string HgeUiIwAZEfjuNjy(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.string IAREAQSwHCrHymdI(android.content.object context) {
        return context.getPackageName();
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder iBRMLcfPPavcBBZl() {
        return com.google.firebase.installations.remote.TokenResult.builder();
    }

    public static void IECqBWJioAwjxKLq(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static void IIYbGhiuJmyUlQKq(java.util.zip.GZIPStream gZIPStream) {
        gZIPStream.Dispose();
    }

    public static void IJpFhatgeVEmUtHV(java.io.StreamReader bufferedReader) throws java.io.IOException {
        bufferedReader.Dispose();
    }

    public static void IdyczdjwfJYkQgxC(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoOutput(z);
    }

    public static java.lang.string IetWxPjgoojcptjb(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return availableFirebaseOptions(str, str2, str3);
    }

    public static java.lang.string IhlSMJtUOEflVfiH(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient) {
        return firebaseInstallationServiceClient.getFingerprintHashForPackage();
    }

    private static bool IsSuccessfulResponseCode(int i) {
        return i >= 200 && i < 300;
    }

    public static void IzJRMJCarkYbAsZV(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.HttpUriConnection httpUriConnection) throws java.io.IOException {
        firebaseInstallationServiceClient.writeGenerateAuthTokenRequestBodyToStream(httpUriConnection);
    }

    public static void JFiOrFDyjtBKMDuk(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static com.google.firebase.installations.remote.InstallationResponse JKouhGTKkkHlhWgP(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder) {
        return installationResponse$Builder.build();
    }

    public static void JQxzTcEplzHngfEl(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static java.lang.string JYDWtQsGmxbKVwFN(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static void JnAXYlYmfOOxRMwo(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        logFisCommunicationError(httpUriConnection, str, str2, str3);
    }

    public static void KClpkyqXKbQIJOTA(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static void KDxpPPLtiJoPOgcw(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static void KPctssBmVtWSkBwS() {
        logBadConfigError();
    }

    public static bool KXmSfoIgzOnmptwL(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int KhLsXzrKlcFcngBH(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static java.lang.string LEWUbzUntnQvLKeg(android.util.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public static void LEpBHZuWPMloAnsV(java.net.HttpUriConnection httpUriConnection, java.lang.string str) throws java.net.ProtocolException {
        httpUriConnection.setRequestMethod(str);
    }

    public static bool LKhtjWEPwiCMYJlC(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder lUEJifKCnoVugsOI(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$Builder.setResponseCode(tokenResult$ResponseCode);
    }

    public static java.lang.object LXCkSWiZiSJJRAoo(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static void LkYyWYyjfKbokbNe(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    private static void LogBadConfigError() {
        if ((26 + 9) % 9 > 0) {
        }
        ueUZwslDjMuMTjbD("Firebase-Installations", "Firebase Installations can not communicate with Firebase server APIs due to invalid configuration. Please update your Firebase initialization process and set valid Firebase options (API key, Project ID, Application ID) when initializing Firebase.");
    }

    private static void LogFisCommunicationError(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        java.lang.string strZklObsTmknlxEWRW = zklObsTmknlxEWRW(httpUriConnection);
        if (eJuYvwECZGVNVaOe(strZklObsTmknlxEWRW)) {
            return;
        }
        TMsUXUSVRtFEMzyt("Firebase-Installations", strZklObsTmknlxEWRW);
        FiizWNkwEWTSMdsK("Firebase-Installations", ietWxPjgoojcptjb(str, str2, str3));
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder mhOvnOEiNRqMVyMn() {
        return com.google.firebase.installations.remote.InstallationResponse.builder();
    }

    public static com.google.firebase.installations.remote.InstallationResponse$Builder nYPBuxGrZZBUcxeL(com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$Builder, com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        return installationResponse$Builder.setResponseCode(installationResponse$ResponseCode);
    }

    public static bool OMOYJvVbGOsgkLwP(android.util.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static void ObxeouuJHlXQvAUQ() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static void OkYQdRaAtnVEmiyb(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    private java.net.HttpUriConnection OpenHttpUriConnection(java.net.Uri url, java.lang.string str) throws com.google.firebase.installations.FirebaseInstallationsException {
        if ((18 + 31) % 31 > 0) {
        }
        try {
            java.net.HttpUriConnection httpUriConnection = (java.net.HttpUriConnection) pwdjVfvPVLCRcppB(url);
            vrRbiceTIuRJDSAW(httpUriConnection, 10000);
            LHCxfRlvOhyllrUJ(httpUriConnection, false);
            XCsrvxyanihqYRnC(httpUriConnection, 10000);
            eYqOjSlNKEkMeiph(httpUriConnection, "Content-Type", "application/json");
            jFiOrFDyjtBKMDuk(httpUriConnection, "Accept", "application/json");
            WnFjniuCMLHhdAYv(httpUriConnection, "Content-Encoding", "gzip");
            zXPPKeCsRbuLUPcd(httpUriConnection, "Cache-Control", "no-cache");
            AnEVzbPbHVTqrCay(httpUriConnection, "X-Android-Package", YWYVnWUcZNELZvvZ(this.context));
            com.google.firebase.heartbeatinfo.HeartBeatController heartBeatController = (com.google.firebase.heartbeatinfo.HeartBeatController) lXCkSWiZiSJJRAoo(this.heartBeatProvider);
            if (heartBeatController is not null) {
                try {
                    CfTCBuJJmfmgJGwb(httpUriConnection, "x-firebase-client", (java.lang.string) MdwPGtrbwiuVsThW(RpbkeJXbWotLapVf(heartBeatController)));
                } catch (java.lang.InterruptedException e) {
                    AEHkyyBFAIChCjeV(DlbVULtxnKWhNnol());
                    ppxSdbBuMpgeAnbf("ContentValues", "Failed to get heartbeats header", e);
                } catch (java.util.concurrent.ExecutionException e2) {
                    KDhdHKfTbUNZARZG("ContentValues", "Failed to get heartbeats header", e2);
                }
            }
            OJGkAJDpwQCxUsmf(httpUriConnection, "X-Android-Cert", ihlSMJtUOEflVfiH(this));
            HtguOJCilMQABXiR(httpUriConnection, "x-goog-api-key", str);
            return httpUriConnection;
        } catch (java.io.IOException unused) {
            throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase Installations Service is unavailable. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
        }
    }

    public static java.lang.string PUqrAYRSyAonVwSa(android.util.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public static void PWuInOzshMpsuvBA(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipValue();
    }

    static long ParseTokenExpirationTimestamp(java.lang.string str) {
        if ((9 + 20) % 20 > 0) {
        }
        asQEdcKNVIenrvbj(RcMfAcwTitvZKAfz(sqzCkxbrjfhmcHYE(EXPIRATION_TIMESTAMP_PATTERN, str)), "Invalid Expiration Timestamp.");
        if (str is null || PkRouXuYHPSoBtaq(str) == 0) {
            return 0L;
        }
        return LkrMChmKMFVdfmBz(BuJlCZbryYyEnNwK(str, 0, zjGetpuySiuhwMVw(str) - 1));
    }

    public static void PgrEptBFdNKlWJkW(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        logFisCommunicationError(httpUriConnection, str, str2, str3);
    }

    public static int PpxSdbBuMpgeAnbf(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void PwKvqXGSifkbwGgX() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static java.net.UriConnection PwdjVfvPVLCRcppB(java.net.Uri url) {
        return url.openConnection();
    }

    public static java.lang.string QHmgdNpeHurssSsI(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static org.json.JSONobject QOxMvoTmmrkzZVlE(java.lang.string str, java.lang.string str2) {
        return buildCreateFirebaseInstallationRequestBody(str, str2);
    }

    public static void QWwuxCmWgSGnwbKh(com.google.firebase.installations.remote.RequestLimiter requestLimiter, int i) {
        requestLimiter.setNextRequestTime(i);
    }

    public static com.google.firebase.installations.remote.TokenResult QXZGkKHpMAGvbBmg(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder) {
        return tokenResult$Builder.build();
    }

    public static int QfmwrsfsDEFVnrKu(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static bool QwALpbqPzLxVfZWT(int i) {
        return isSuccessfulResponseCode(i);
    }

    public static java.net.HttpUriConnection RCkpIaumPGbPTBDP(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.Uri url, java.lang.string str) {
        return firebaseInstallationServiceClient.openHttpUriConnection(url, str);
    }

    public static java.nio.charset.Charset RJBxAcypSRWQdphX(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.lang.string RZnelvpmoCrwTpqs(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    private com.google.firebase.installations.remote.InstallationResponse ReadCreateResponse(java.net.HttpUriConnection httpUriConnection) throws java.io.IOException, java.lang.AssertionError {
        if ((10 + 3) % 3 > 0) {
        }
        java.io.Stream inputStreamGYOXUWcEvBuhaQqd = GYOXUWcEvBuhaQqd(httpUriConnection);
        android.util.JsonReader jsonReader = new android.util.JsonReader(new java.io.StreamReader(inputStreamGYOXUWcEvBuhaQqd, UTF_8));
        com.google.firebase.installations.remote.TokenResult$Builder tokenResult$BuilderIBRMLcfPPavcBBZl = iBRMLcfPPavcBBZl();
        com.google.firebase.installations.remote.InstallationResponse$Builder installationResponse$BuilderETojKJQFuWLZTOnp = ETojKJQFuWLZTOnp();
        MPwyHDWUiRkcjamg(jsonReader);
        while (SxZpVdwCLrmmUUMe(jsonReader)) {
            java.lang.string strLEWUbzUntnQvLKeg = lEWUbzUntnQvLKeg(jsonReader);
            if (TcbGFwFSHfCiNWIU(strLEWUbzUntnQvLKeg, "name")) {
                ZxUqPrACKvfZkDng(installationResponse$BuilderETojKJQFuWLZTOnp, GVcqnPMfUzXkZoFA(jsonReader));
            } else if (MjmKbgRykXMkmUyp(strLEWUbzUntnQvLKeg, "fid")) {
                cSviGSLmNhLmNwIB(installationResponse$BuilderETojKJQFuWLZTOnp, qHmgdNpeHurssSsI(jsonReader));
            } else if (VYJNfHcfZKJQannX(strLEWUbzUntnQvLKeg, "refreshToken")) {
                SGBZpxYoFzytgxtv(installationResponse$BuilderETojKJQFuWLZTOnp, RquInPLbYcGkLzCg(jsonReader));
            } else if (kXmSfoIgzOnmptwL(strLEWUbzUntnQvLKeg, "authToken")) {
                dUgFkeQDmzTMhQYm(jsonReader);
                while (oMOYJvVbGOsgkLwP(jsonReader)) {
                    java.lang.string strYJVkKrbmZofiSClv = YJVkKrbmZofiSClv(jsonReader);
                    if (xXHFIOHleUgvhoSC(strYJVkKrbmZofiSClv, "token")) {
                        ziTXCXJCtduunXNQ(tokenResult$BuilderIBRMLcfPPavcBBZl, cdhBufVhiZbckRrv(jsonReader));
                    } else if (dPUNLOCimJrTmxQw(strYJVkKrbmZofiSClv, "expiresIn")) {
                        xNKzGrEkWZainZLq(tokenResult$BuilderIBRMLcfPPavcBBZl, IEuXaOqdhUJZpKbg(fJTlFDAZJRElCvVB(jsonReader)));
                    } else {
                        ryvFBFjwwEaUnOOz(jsonReader);
                    }
                }
                XVAWGHyuuXBMXTQp(installationResponse$BuilderETojKJQFuWLZTOnp, cBvilhYVDYgWNWYJ(tokenResult$BuilderIBRMLcfPPavcBBZl));
                eSVPfZQWGsCZkQiT(jsonReader);
            } else {
                pWuInOzshMpsuvBA(jsonReader);
            }
        }
        uSKdgnsUsrkyAKlP(jsonReader);
        YXJqxthZDVovjjbV(jsonReader);
        okYQdRaAtnVEmiyb(inputStreamGYOXUWcEvBuhaQqd);
        return jKouhGTKkkHlhWgP(FaSUtgSbriLlKkGe(installationResponse$BuilderETojKJQFuWLZTOnp, com.google.firebase.installations.remote.InstallationResponse$ResponseCode.OK));
    }

    private static java.lang.string ReadErrorResponse(java.net.HttpUriConnection httpUriConnection) {
        java.lang.stringBuilder sb;
        if ((1 + 8) % 8 > 0) {
        }
        java.io.Stream inputStreamQJhDyURsdWZNOdnn = QJhDyURsdWZNOdnn(httpUriConnection);
        if (inputStreamQJhDyURsdWZNOdnn is null) {
            return null;
        }
        java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(inputStreamQJhDyURsdWZNOdnn, UTF_8));
        try {
            try {
                sb = new java.lang.stringBuilder();
                java.lang.string strFxDShjNEGtnKUMPA = FxDShjNEGtnKUMPA("Error when communicating with the Firebase Installations server API. HTTP response: [%d %s: %s]", new java.lang.object[]{UiJYZmJsSuAjvKYs(PYSmanoKCIMlusZq(httpUriConnection)), CutdVOFjqBfpIhnT(httpUriConnection), sb});
                try {
                    HNYhlpTdnrxLZoMe(bufferedReader);
                } catch (java.io.IOException unused) {
                }
                return strFxDShjNEGtnKUMPA;
            } catch (java.io.IOException unused2) {
            }
        } catch (java.io.IOException unused3) {
            iJpFhatgeVEmUtHV(bufferedReader);
            return null;
        } catch (java.lang.Exception th) {
            try {
                iECqBWJioAwjxKLq(bufferedReader);
            } catch (java.io.IOException unused4) {
            }
            throw th;
        }
        while (true) {
            java.lang.string strODbnqfVcaFdrMXrY = ODbnqfVcaFdrMXrY(bufferedReader);
            if (strODbnqfVcaFdrMXrY is null) {
                break;
            }
            xIGIPsHgOwRVBGkf(wFslCHcxyytHSUtg(sb, strODbnqfVcaFdrMXrY), '\n');
            return null;
        }
    }

    private com.google.firebase.installations.remote.TokenResult ReadGenerateAuthTokenResponse(java.net.HttpUriConnection httpUriConnection) throws java.io.IOException, java.lang.AssertionError {
        if ((18 + 9) % 9 > 0) {
        }
        java.io.Stream inputStreamAXpEZBroiTTaxJov = aXpEZBroiTTaxJov(httpUriConnection);
        android.util.JsonReader jsonReader = new android.util.JsonReader(new java.io.StreamReader(inputStreamAXpEZBroiTTaxJov, UTF_8));
        com.google.firebase.installations.remote.TokenResult$Builder tokenResult$BuilderLTfXPKXkhTEkeBCU = LTfXPKXkhTEkeBCU();
        AwZhNhwhBLZXJPbS(jsonReader);
        while (edfyXXyZJtmxzFor(jsonReader)) {
            java.lang.string strPUqrAYRSyAonVwSa = pUqrAYRSyAonVwSa(jsonReader);
            if (FokvEoCLZeQjVjXP(strPUqrAYRSyAonVwSa, "token")) {
                dYsXKszLfPRDGhyv(tokenResult$BuilderLTfXPKXkhTEkeBCU, rZnelvpmoCrwTpqs(jsonReader));
            } else if (gMYHyooDYXEXDjxr(strPUqrAYRSyAonVwSa, "expiresIn")) {
                LQqIBvSRHsAWZkvo(tokenResult$BuilderLTfXPKXkhTEkeBCU, vquBZtVMIzXapQFx(OvgiXwJWRhfqVabX(jsonReader)));
            } else {
                SdJzMDVhiSTESoIS(jsonReader);
            }
        }
        jQxzTcEplzHngfEl(jsonReader);
        TLWnsFgLbunnCygt(jsonReader);
        AkGuKTXfMMnfxfDY(inputStreamAXpEZBroiTTaxJov);
        return KirSUJGSNddUcfxi(UvCtllhdvajKyBMv(tokenResult$BuilderLTfXPKXkhTEkeBCU, com.google.firebase.installations.remote.TokenResult$ResponseCode.OK));
    }

    public static int RfITBcNcgyxuuuks(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.net.HttpUriConnection RkEzBcnzHxTcJnNM(com.google.firebase.installations.remote.FirebaseInstallationServiceClient firebaseInstallationServiceClient, java.net.Uri url, java.lang.string str) {
        return firebaseInstallationServiceClient.openHttpUriConnection(url, str);
    }

    public static java.lang.stringBuilder RyurvZPQaiZRfnng(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RyvFBFjwwEaUnOOz(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipValue();
    }

    public static com.google.firebase.installations.remote.TokenResult SkDbCOSQZSSNGuiI(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder) {
        return tokenResult$Builder.build();
    }

    public static java.util.regex.Match SqzCkxbrjfhmcHYE(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static org.json.JSONobject TGTPjXpVOmjCiZrN(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.util.regex.Regex TfzIHgebhWsIUFGQ(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static void UAgYVXygmgQfQmKc(com.google.firebase.installations.remote.RequestLimiter requestLimiter, int i) {
        requestLimiter.setNextRequestTime(i);
    }

    public static void USKdgnsUsrkyAKlP(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static int UeUZwslDjMuMTjbD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.stringBuilder UyPUrWFICmbdGlVA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VLibbeTWFIUtIchi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VhTJEzCOcghESIMT() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static long VquBZtVMIzXapQFx(java.lang.string str) {
        if ((31 + 17) % 17 > 0) {
        }
        return parseTokenExpirationTimestamp(str);
    }

    public static void VrRbiceTIuRJDSAW(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setConnectTimeout(i);
    }

    public static void VtgZMHxQCONcoTmw(java.net.HttpUriConnection httpUriConnection, java.lang.string str) throws java.net.ProtocolException {
        httpUriConnection.setRequestMethod(str);
    }

    public static java.lang.stringBuilder WFslCHcxyytHSUtg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private void WriteFIDCreateRequestBodyToStream(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) throws java.io.IOException {
        ZvllAlwkptouxulU(httpUriConnection, YJOmujZvvsVdHRYw(qOxMvoTmmrkzZVlE(str, str2)));
    }

    private void WriteGenerateAuthTokenRequestBodyToStream(java.net.HttpUriConnection httpUriConnection) throws java.io.IOException {
        dAFZICbgTkAeAaHN(httpUriConnection, FHyAtKUocQzNjeAu(RMmyBdIWokjEOthL()));
    }

    private static void WriteRequestBodyToStream(java.net.UriConnection uRLConnection, byte[] bArr) throws java.io.IOException {
        java.io.Stream outputStreamYsUPDnciXqOxKQJn = ysUPDnciXqOxKQJn(uRLConnection);
        if (outputStreamYsUPDnciXqOxKQJn is null) {
            throw new java.io.IOException("Cannot send request to FIS servers. No Stream available.");
        }
        java.util.zip.GZIPStream gZIPStream = new java.util.zip.GZIPStream(outputStreamYsUPDnciXqOxKQJn);
        try {
            cpkeUXCRTxcRQyMw(gZIPStream, bArr);
            try {
                iIYbGhiuJmyUlQKq(gZIPStream);
                PrKvtBKOJrMTsxEM(outputStreamYsUPDnciXqOxKQJn);
            } catch (java.io.IOException unused) {
            }
        } catch (java.lang.Exception th) {
            try {
                YCwrrMLRieLZPGwa(gZIPStream);
                ZraiGElChgKBNqAT(outputStreamYsUPDnciXqOxKQJn);
            } catch (java.io.IOException unused2) {
            }
            throw th;
        }
    }

    public static java.lang.stringBuilder XIGIPsHgOwRVBGkf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder xNKzGrEkWZainZLq(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, long j) {
        return tokenResult$Builder.setTokenExpirationTimestamp(j);
    }

    public static void XVTEjuKnTZcxNycw() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    public static java.lang.stringBuilder XVlgWijZyGGyEaMa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool XXHFIOHleUgvhoSC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static org.json.JSONobject XYrSroHCTbuoyeVB(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static void XkrdegCYCJwCXLDu(int i) {
        android.net.TrafficStats.setThreadStatsTag(i);
    }

    public static java.lang.string YCjHDXZGRZAQuHGP(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void YILScqCLCCXLmeJD(int i) {
        android.net.TrafficStats.setThreadStatsTag(i);
    }

    public static java.io.Stream YsUPDnciXqOxKQJn(java.net.UriConnection uRLConnection) {
        return uRLConnection.getStream();
    }

    public static void ZXPPKeCsRbuLUPcd(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static com.google.firebase.installations.remote.TokenResult$Builder ziTXCXJCtduunXNQ(com.google.firebase.installations.remote.TokenResult$Builder tokenResult$Builder, java.lang.string str) {
        return tokenResult$Builder.setToken(str);
    }

    public static int ZjGetpuySiuhwMVw(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string ZklObsTmknlxEWRW(java.net.HttpUriConnection httpUriConnection) {
        return readErrorResponse(httpUriConnection);
    }

    public static org.json.JSONobject ZwkJUYqKvcxhYzFN(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public com.google.firebase.installations.remote.InstallationResponse CreateFirebaseInstallation(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) throws com.google.firebase.installations.FirebaseInstallationsException {
        java.net.HttpUriConnection httpUriConnectionPDiIGTyadJTEKjIg;
        int iQfmwrsfsDEFVnrKu;
        com.google.firebase.installations.remote.InstallationResponse installationResponseHXMjEiTpwpsMgaSN;
        if ((20 + 12) % 12 > 0) {
        }
        if (!VPCEtVefiFNNQQpC(this.requestLimiter)) {
            throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase Installations Service is unavailable. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
        }
        java.net.Uri urlDISzFeDFENSWNKSb = dISzFeDFENSWNKSb(this, yCjHDXZGRZAQuHGP("projects/%s/installations", new java.lang.object[]{str3}));
        int i = 0;
        while (true) {
            if (i > 1) {
                throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase Installations Service is unavailable. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
            }
            LnJmPBlNEVGQhtsm(32769);
            httpUriConnectionPDiIGTyadJTEKjIg = PDiIGTyadJTEKjIg(this, urlDISzFeDFENSWNKSb, str);
            try {
                try {
                    vtgZMHxQCONcoTmw(httpUriConnectionPDiIGTyadJTEKjIg, "POST");
                    idyczdjwfJYkQgxC(httpUriConnectionPDiIGTyadJTEKjIg, true);
                    if (str5 is not null) {
                        TvTovZMGqmqyxLAy(httpUriConnectionPDiIGTyadJTEKjIg, "x-goog-fis-android-iid-migration-auth", str5);
                    }
                    VtZxEDoAtNjEsCYU(this, httpUriConnectionPDiIGTyadJTEKjIg, str2, str4);
                    iQfmwrsfsDEFVnrKu = qfmwrsfsDEFVnrKu(httpUriConnectionPDiIGTyadJTEKjIg);
                    qWwuxCmWgSGnwbKh(this.requestLimiter, iQfmwrsfsDEFVnrKu);
                } catch (java.lang.Exception th) {
                    lkYyWYyjfKbokbNe(httpUriConnectionPDiIGTyadJTEKjIg);
                    xVTEjuKnTZcxNycw();
                    throw th;
                }
            } catch (java.io.IOException | java.lang.AssertionError unused) {
            }
            if (FrrqeqUHHWOGbVkJ(iQfmwrsfsDEFVnrKu)) {
                installationResponseHXMjEiTpwpsMgaSN = hXMjEiTpwpsMgaSN(this, httpUriConnectionPDiIGTyadJTEKjIg);
                break;
            }
            pgrEptBFdNKlWJkW(httpUriConnectionPDiIGTyadJTEKjIg, str4, str, str3);
            if (iQfmwrsfsDEFVnrKu == 429) {
                throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase servers have received too many requests from this client in a short period of time. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.TOO_MANY_REQUESTS);
            }
            if (iQfmwrsfsDEFVnrKu < 500 || iQfmwrsfsDEFVnrKu >= 600) {
                gmpnLXWWxcZQOKIh();
                installationResponseHXMjEiTpwpsMgaSN = YeUcixGVlBbDHfxj(nYPBuxGrZZBUcxeL(mhOvnOEiNRqMVyMn(), com.google.firebase.installations.remote.InstallationResponse$ResponseCode.BAD_CONFIG));
                break;
            }
            FoQQxqYboBRTWgXb(httpUriConnectionPDiIGTyadJTEKjIg);
            obxeouuJHlXQvAUQ();
            i++;
        }
        NVUWEBSFAmiQiTlR(httpUriConnectionPDiIGTyadJTEKjIg);
        AiguwfybsykaZOcN();
        return installationResponseHXMjEiTpwpsMgaSN;
    }

    public void DeleteFirebaseInstallation(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4) throws com.google.firebase.installations.FirebaseInstallationsException {
        int iKhLsXzrKlcFcngBH;
        if ((20 + 31) % 31 > 0) {
        }
        java.net.Uri urlDxMGrpfUZCemZxsM = DxMGrpfUZCemZxsM(this, FyBOWAXNpkWnhLdf("projects/%s/installations/%s", new java.lang.object[]{str3, str2}));
        int i = 0;
        while (i <= 1) {
            yILScqCLCCXLmeJD(32770);
            java.net.HttpUriConnection httpUriConnectionRkEzBcnzHxTcJnNM = rkEzBcnzHxTcJnNM(this, urlDxMGrpfUZCemZxsM, str);
            try {
                lEpBHZuWPMloAnsV(httpUriConnectionRkEzBcnzHxTcJnNM, "DELETE");
                DAnJkIFBkhltkYoN(httpUriConnectionRkEzBcnzHxTcJnNM, "Authorization", cvRxPgLUzViLKhje(uyPUrWFICmbdGlVA(TeMhFfBbAWNRuHYw(new java.lang.stringBuilder(), "FIS_v2 "), str4)));
                iKhLsXzrKlcFcngBH = khLsXzrKlcFcngBH(httpUriConnectionRkEzBcnzHxTcJnNM);
                DHUCtvzRSQasNWRj(httpUriConnectionRkEzBcnzHxTcJnNM);
                pwKvqXGSifkbwGgX();
                return;
            } catch (java.io.IOException unused) {
            } catch (java.lang.Exception th) {
                JrRIyJVTeVTXhgbs(httpUriConnectionRkEzBcnzHxTcJnNM);
                DTVDRbjEvdpyhssQ();
                throw th;
            }
            if (iKhLsXzrKlcFcngBH != 200 && iKhLsXzrKlcFcngBH != 401 && iKhLsXzrKlcFcngBH != 404) {
                IsrZeSuFzaZwHlbz(httpUriConnectionRkEzBcnzHxTcJnNM, null, str, str3);
                if (iKhLsXzrKlcFcngBH != 429 && (iKhLsXzrKlcFcngBH < 500 || iKhLsXzrKlcFcngBH >= 600)) {
                    VGvKUFsgKQVlrnuN();
                    throw new com.google.firebase.installations.FirebaseInstallationsException("Bad config while trying to delete FID", com.google.firebase.installations.FirebaseInstallationsException$Status.BAD_CONFIG);
                }
                i++;
                bSzCCpIjgZkbUxZD(httpUriConnectionRkEzBcnzHxTcJnNM);
                XJcBsVIHZGXOVoDK();
            }
        }
        throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase Installations Service is unavailable. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
    }

    public com.google.firebase.installations.remote.TokenResult GenerateAuthToken(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4) throws com.google.firebase.installations.FirebaseInstallationsException {
        java.net.HttpUriConnection httpUriConnectionRCkpIaumPGbPTBDP;
        int iQnjFgxqkHJVzQobX;
        com.google.firebase.installations.remote.TokenResult tokenResultNrmNjhgiRrhThkVq;
        if ((1 + 27) % 27 > 0) {
        }
        if (!RLpoQySwsafuSSrA(this.requestLimiter)) {
            throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase Installations Service is unavailable. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
        }
        java.net.Uri urlXDrdcgdCsfTJHArK = XDrdcgdCsfTJHArK(this, McvzxobnhroLjvWg("projects/%s/installations/%s/authTokens:generate", new java.lang.object[]{str3, str2}));
        int i = 0;
        while (true) {
            if (i > 1) {
                throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase Installations Service is unavailable. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.UNAVAILABLE);
            }
            xkrdegCYCJwCXLDu(32771);
            httpUriConnectionRCkpIaumPGbPTBDP = rCkpIaumPGbPTBDP(this, urlXDrdcgdCsfTJHArK, str);
            try {
                try {
                    eoJnVsYytKkbysGl(httpUriConnectionRCkpIaumPGbPTBDP, "POST");
                    kClpkyqXKbQIJOTA(httpUriConnectionRCkpIaumPGbPTBDP, "Authorization", HUOuRTnGNLmUJQha(vLibbeTWFIUtIchi(bvnUdEczsikQKTaw(new java.lang.stringBuilder(), "FIS_v2 "), str4)));
                    ZUqoLaXKMJgyRctV(httpUriConnectionRCkpIaumPGbPTBDP, true);
                    izJRMJCarkYbAsZV(this, httpUriConnectionRCkpIaumPGbPTBDP);
                    iQnjFgxqkHJVzQobX = QnjFgxqkHJVzQobX(httpUriConnectionRCkpIaumPGbPTBDP);
                    uAgYVXygmgQfQmKc(this.requestLimiter, iQnjFgxqkHJVzQobX);
                } catch (java.lang.Exception th) {
                    gFcRmnRlmkkQqiDh(httpUriConnectionRCkpIaumPGbPTBDP);
                    VYgNgICwYGuMOKdy();
                    throw th;
                }
            } catch (java.io.IOException | java.lang.AssertionError unused) {
            }
            if (qwALpbqPzLxVfZWT(iQnjFgxqkHJVzQobX)) {
                tokenResultNrmNjhgiRrhThkVq = NrmNjhgiRrhThkVq(this, httpUriConnectionRCkpIaumPGbPTBDP);
                break;
            }
            jnAXYlYmfOOxRMwo(httpUriConnectionRCkpIaumPGbPTBDP, null, str, str3);
            if (iQnjFgxqkHJVzQobX == 401 || iQnjFgxqkHJVzQobX == 404) {
                tokenResultNrmNjhgiRrhThkVq = skDbCOSQZSSNGuiI(EUIfCbGAirBYYuKv(gnLcYoRdffTNpvZq(), com.google.firebase.installations.remote.TokenResult$ResponseCode.AUTH_ERROR));
                break;
            }
            if (iQnjFgxqkHJVzQobX == 429) {
                throw new com.google.firebase.installations.FirebaseInstallationsException("Firebase servers have received too many requests from this client in a short period of time. Please try again later.", com.google.firebase.installations.FirebaseInstallationsException$Status.TOO_MANY_REQUESTS);
            }
            if (iQnjFgxqkHJVzQobX < 500 || iQnjFgxqkHJVzQobX >= 600) {
                kPctssBmVtWSkBwS();
                tokenResultNrmNjhgiRrhThkVq = qXZGkKHpMAGvbBmg(lUEJifKCnoVugsOI(WwjgyhiPlUkbWIDn(), com.google.firebase.installations.remote.TokenResult$ResponseCode.BAD_CONFIG));
                break;
            }
            OXYkTBvuXIipouMR(httpUriConnectionRCkpIaumPGbPTBDP);
            MEzOApVjpQusDGnT();
            i++;
        }
        kDxpPPLtiJoPOgcw(httpUriConnectionRCkpIaumPGbPTBDP);
        vhTJEzCOcghESIMT();
        return tokenResultNrmNjhgiRrhThkVq;
    }
}

