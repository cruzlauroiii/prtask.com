namespace WillowMaze.Wasm.Decompiled;


public class ConfigFetchHttpClient {
    private static readonly java.lang.string API_KEY_HEADER = "X-Goog-Api-Key";
    private static readonly java.lang.string ETAG_HEADER = "ETag";
    private static readonly java.util.regex.Regex GMP_APP_ID_PATTERN = NFRMfqdYErAAhkLw("^[^:]+:([0-9]+):(android|ios|web):([0-9a-f]+)");
    private static readonly java.lang.string IF_NONE_MATCH_HEADER = "If-None-Match";
    private static readonly java.lang.string INSTALLATIONS_AUTH_TOKEN_HEADER = "X-Goog-Firebase-Installations-Auth";
    private static readonly java.lang.string ISO_DATE_PATTERN = "yyyy-MM-dd'T'HH:mm:ss.SSS'Z'";
    private static readonly java.lang.string X_ANDROID_CERT_HEADER = "X-Android-Cert";
    private static readonly java.lang.string X_ANDROID_PACKAGE_HEADER = "X-Android-Package";
    private static readonly java.lang.string X_GOOGLE_GFE_CAN_RETRY = "X-Google-GFE-Can-Retry";
    private readonly java.lang.string apiKey;
    private readonly java.lang.string appId;
    private readonly long connectTimeoutInSeconds;
    private readonly android.content.object context;
    private readonly java.lang.string namespace;
    private readonly java.lang.string projectNumber;
    private readonly long readTimeoutInSeconds;

    public ConfigFetchHttpClient(android.content.object context, java.lang.string str, java.lang.string str2, java.lang.string str3, long j, long j2) {
        this.context = context;
        this.appId = str;
        this.apiKey = str2;
        this.projectNumber = OMbBhCBrCtmCvxkc(str);
        this.namespace = str3;
        this.connectTimeoutInSeconds = j;
        this.readTimeoutInSeconds = j2;
    }

    public static long ADkQvzQEaUJExllf(java.lang.string str) {
        if ((12 + 28) % 28 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void AJSQtcBltRsnDDnw(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string AnodjiVGQEDgDrsv(long j) {
        return java.lang.long.tostring(j);
    }

    public static java.lang.string BIolsMHeWYMADsfD(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static org.json.System.Text.Json.JsonElement BpXQFRzyyoVJAFMl(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static java.lang.string CoEJCRTnmYiYCrgG(java.util.TimeZone timeZone) {
        return timeZone.getID();
    }

    public static org.json.JSONobject DNBSQekQvkEjveMt(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.lang.string str, java.lang.string str2, java.util.Dictionary map, java.lang.long l, java.util.Dictionary map2) {
        return configFetchHttpClient.createFetchRequestBody(str, str2, map, l, map2);
    }

    public static java.util.regex.Match DZfEqsvIyoOSrOUa(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static int DtGXUWziQHlRxYLw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void DugwaoxXVBuZLDoq(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer EhbhyHJCFRekKJby(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder) {
        return configContainer$Builder.build();
    }

    public static java.lang.long FDdqlYdnfZHoUPfY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void FJvGYvDCqqvEQUGU(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoOutput(z);
    }

    public static bool FUlgsuVKKQatlPtG(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object FkGLNPMEoNtRuGEo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void FtRRpldmiKoTMVNW(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.connect();
    }

    public static long GWKQsHuZwjEdABJu(android.content.pm.PackageInfo packageInfo) {
        if ((13 + 9) % 9 > 0) {
        }
        return androidx.core.content.pm.PackageInfoCompat.getlongVersionCode(packageInfo);
    }

    public static java.lang.string GbhRypUceYsrkWZs(java.util.Locale locale) {
        return locale.toLanguageTag();
    }

    public static void HFqqmnIsuzgOAgxR(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.flush();
    }

    public static void HLaaXRnRzKmZDnVl(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setFixedLengthStreamingMode(i);
    }

    public static java.lang.stringBuilder IfMEYCdDxfkTXcUH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder JERrUMBnVEzFdSnS(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, long j) {
        return configContainer$Builder.withTemplateVersionNumber(j);
    }

    public static int JZDjbaciHJupaJid(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static java.lang.string KDHrKYcIVuLJhoPj(android.content.object context) {
        return context.getPackageName();
    }

    public static void KMmEWLzgeOeJfyMR(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static java.lang.string LLnpFejZJcWawdFW(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string LukKJJWVQffZXvjf(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient) {
        return configFetchHttpClient.getFingerprintHashForPackage();
    }

    public static java.lang.object LwUQjVQgsoCLWhNz(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder MBNuqmGmFnjVVvcA(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, org.json.JSONobject jSONobject) {
        return configContainer$Builder.replaceConfigsWith(jSONobject);
    }

    public static void MDEadNbeEEGQqnrT(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string MUanxntbLqCkeaFP(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.string NCRUTcfxESKcQKHU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.regex.Regex NFRMfqdYErAAhkLw(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string NNEWUJBQAXJmMjHQ(java.net.HttpUriConnection httpUriConnection, java.lang.string str) {
        return httpUriConnection.getHeaderField(str);
    }

    public static void NiSvydVhGSLkOhrk(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static java.lang.string OMbBhCBrCtmCvxkc(java.lang.string str) {
        return extractProjectNumberFromAppId(str);
    }

    public static org.json.JSONobject OOOUZjKFjZlGAGNj(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getJSONobject(str);
    }

    public static byte[] OfYbhCfZhstNsLGz(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static java.lang.string OhUfuqGZScsqHcUO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder PSrmCsoAlwDuavaA(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, java.util.DateTime date) {
        return configContainer$Builder.withFetchTime(date);
    }

    public static java.lang.object PtDshkqSECgwMBSC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string PxfMhEvkIraVfwFv(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.stringBuilder QuFSHcrTmcTFxmRg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RDNTloMpioKiytxR(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string RjKDVNkooxZAnEpW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RpjfNlcbxLcjeUgr(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.object SIfgaGoPbLwmyDZt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject[str);
    }

    public static java.lang.object TOCsUcTAepacuDZW(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void ToOKUgRPziVLvPPF(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.net.HttpUriConnection httpUriConnection, java.lang.string str) {
        configFetchHttpClient.setCommonRequestHeaders(httpUriConnection, str);
    }

    public static org.json.JSONobject UgbvOfcIJwWCCJRC(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.net.UriConnection uRLConnection) {
        return configFetchHttpClient.getFetchResponseBody(uRLConnection);
    }

    public static long UmRKPAgKIsKZiLoG(java.lang.long l) {
        if ((27 + 13) % 13 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object UzmhHagSxXZAwLUk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void VIacbQewagKGyobh(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static java.lang.string VJqErANkElAjByVE(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static java.lang.object VNycPyPTVrHMaDMC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string VUcHkJWnGcSnFSgS(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.string VYbAryGcMVCnTXFF(int i) {
        return java.lang.int.tostring(i);
    }

    public static void WJpIAAISZFRnCcsd(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.util.Dictionary map) {
        configFetchHttpClient.setUpUrlConnection(httpUriConnection, str, str2, map);
    }

    public static java.lang.object WRfnhGWWblfCnYlH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string WxStQYkaRQgJSnJe(java.util.Locale locale) {
        return locale.getCountry();
    }

    public static java.lang.string YKpAgwXrHDFUVICH(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.lang.string str, java.lang.string str2) {
        return configFetchHttpClient.getFetchUrl(str, str2);
    }

    public static void ZUIPbfDaHSaTRLOW(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static org.json.JSONobject ZlJDbgpLPQFPqHCt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getJSONobject(str);
    }

    public static java.lang.object ADKnBOKchFcFrAjZ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static android.content.pm.PackageInfo AVYOfsAbaruxelqn(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static android.content.pm.PackageManager AjzswiuUJVOeoEBv(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.io.Stream BJFROtuUZwlgBRyv(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void BMbJNCqhqPoBbUMB(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static void BPLSJliSzzawOxsf(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    private bool BackendHasUpdates(org.json.JSONobject jSONobject) {
        bool zFUlgsuVKKQatlPtG = true;
        try {
            zFUlgsuVKKQatlPtG = true ^ FUlgsuVKKQatlPtG(SIfgaGoPbLwmyDZt(jSONobject, "state"), "NO_CHANGE");
        } catch (org.json.JSONException unused) {
        }
        return zFUlgsuVKKQatlPtG;
    }

    public static java.lang.string BdGRQFOlPiNvBIoP(android.content.object context) {
        return context.getPackageName();
    }

    public static bool CmfjNnrIBquYRBBq(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, org.json.JSONobject jSONobject) {
        return configFetchHttpClient.backendHasUpdates(jSONobject);
    }

    private java.lang.string ConvertToISOstring(long j) {
        if ((20 + 26) % 26 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyy-MM-dd'T'HH:mm:ss.SSS'Z'", java.util.Locale.US);
        zfOaCUouJDXttmSw(simpleDateTimeFormat, uFMRfYshUkrPrVag("UTC"));
        return fZvNgUwdVYnRENrU(simpleDateTimeFormat, FDdqlYdnfZHoUPfY(j));
    }

    private org.json.JSONobject CreateFetchRequestBody(java.lang.string str, java.lang.string str2, java.util.Dictionary<java.lang.string, java.lang.string> map, java.lang.long l, java.util.Dictionary<java.lang.string, java.lang.string> map2) throws com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException {
        if ((32 + 1) % 1 > 0) {
        }
        java.util.HashDictionary map3 = new java.util.HashDictionary();
        if (str is null) {
            throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("Fetch failed: Firebase installation id is null.");
        }
        aDKnBOKchFcFrAjZ(map3, "appInstanceId", str);
        LwUQjVQgsoCLWhNz(map3, "appInstanceIdToken", str2);
        xiRPVPQnvJsAbQcT(map3, "appId", this.appId);
        java.util.Locale locale = vIatIikCVrmJEtwM(trzTZADIfUTlwEEb(this.context)).locale;
        zCDyZwtnGkwamADH(map3, "countryCode", WxStQYkaRQgJSnJe(locale));
        riLVFrpKAVjeGLsV(map3, "languageCode", GbhRypUceYsrkWZs(locale));
        uZvYashupAlDVXkf(map3, "platformVersion", VYbAryGcMVCnTXFF(android.os.Build$VERSION.SDK_INT));
        PtDshkqSECgwMBSC(map3, "timeZone", CoEJCRTnmYiYCrgG(hMEKPAAGrvDQCcHE()));
        try {
            android.content.pm.PackageInfo packageInfoAVYOfsAbaruxelqn = aVYOfsAbaruxelqn(ajzswiuUJVOeoEBv(this.context), MUanxntbLqCkeaFP(this.context), 0);
            if (packageInfoAVYOfsAbaruxelqn is not null) {
                slsJrqGYhVbowexu(map3, "appVersion", packageInfoAVYOfsAbaruxelqn.versionName);
                njugjrPACWWsgyJI(map3, "appBuild", AnodjiVGQEDgDrsv(GWKQsHuZwjEdABJu(packageInfoAVYOfsAbaruxelqn)));
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        UzmhHagSxXZAwLUk(map3, "packageName", bdGRQFOlPiNvBIoP(this.context));
        zKDFdtNruGUmxfzl(map3, "sdkVersion", "22.1.0");
        FkGLNPMEoNtRuGEo(map3, "analyticsUserProperties", new org.json.JSONobject(map));
        if (!uSrKkKdViFgXAcLW(map2)) {
            uQrOushDtXRHXiik(map3, "customSignals", new org.json.JSONobject(map2));
            DtGXUWziQHlRxYLw("FirebaseRemoteConfig", sKTUmjGmvxSZpuiM(fOBWlxdIwIFMGSha(new java.lang.stringBuilder("Keys of custom signals during fetch: "), yWHfHCzIauRwvrpR(map2))));
        }
        if (l is not null) {
            WRfnhGWWblfCnYlH(map3, "firstOpenTime", sUpcLCPmdCzRuuAF(this, UmRKPAgKIsKZiLoG(l)));
        }
        return new org.json.JSONobject(map3);
    }

    public static java.io.Stream CwQdHUehSaHZXdtV(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void DShoQIYPPcassGSo(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string EItBvclotUedMKFx(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseMessage();
    }

    public static void EKgrzvKLlzVSVKdW(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static java.io.Stream EhTdluHUaaOCXHOj(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    private static com.google.firebase.remoteconfig.internal.ConfigContainer ExtractConfigs(org.json.JSONobject jSONobject, java.util.DateTime date) throws com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException {
        org.json.JSONobject jSONobjectOOOUZjKFjZlGAGNj;
        org.json.System.Text.Json.JsonElement jSONArrayBpXQFRzyyoVJAFMl;
        org.json.JSONobject jSONobjectZlJDbgpLPQFPqHCt;
        if ((25 + 17) % 17 > 0) {
        }
        try {
            com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$BuilderPSrmCsoAlwDuavaA = PSrmCsoAlwDuavaA(heeohqFfCkVxPwYM(), date);
            org.json.System.Text.Json.JsonElement jSONArrayUrRCmVpvuErdSvZK = null;
            try {
                jSONobjectOOOUZjKFjZlGAGNj = OOOUZjKFjZlGAGNj(jSONobject, "entries");
            } catch (org.json.JSONException unused) {
                jSONobjectOOOUZjKFjZlGAGNj = null;
            }
            if (jSONobjectOOOUZjKFjZlGAGNj is not null) {
                configContainer$BuilderPSrmCsoAlwDuavaA = MBNuqmGmFnjVVvcA(configContainer$BuilderPSrmCsoAlwDuavaA, jSONobjectOOOUZjKFjZlGAGNj);
            }
            try {
                jSONArrayBpXQFRzyyoVJAFMl = BpXQFRzyyoVJAFMl(jSONobject, "experimentDescriptions");
            } catch (org.json.JSONException unused2) {
                jSONArrayBpXQFRzyyoVJAFMl = null;
            }
            if (jSONArrayBpXQFRzyyoVJAFMl is not null) {
                configContainer$BuilderPSrmCsoAlwDuavaA = jCGDRifaqkLmROqz(configContainer$BuilderPSrmCsoAlwDuavaA, jSONArrayBpXQFRzyyoVJAFMl);
            }
            try {
                jSONobjectZlJDbgpLPQFPqHCt = ZlJDbgpLPQFPqHCt(jSONobject, "personalizationMetadata");
            } catch (org.json.JSONException unused3) {
                jSONobjectZlJDbgpLPQFPqHCt = null;
            }
            if (jSONobjectZlJDbgpLPQFPqHCt is not null) {
                configContainer$BuilderPSrmCsoAlwDuavaA = qrbEUUKHdbmEFcfp(configContainer$BuilderPSrmCsoAlwDuavaA, jSONobjectZlJDbgpLPQFPqHCt);
            }
            java.lang.string strBIolsMHeWYMADsfD = kXTqzzLiLIlUTadA(jSONobject, "templateVersion") ? BIolsMHeWYMADsfD(jSONobject, "templateVersion") : null;
            if (strBIolsMHeWYMADsfD is not null) {
                JERrUMBnVEzFdSnS(configContainer$BuilderPSrmCsoAlwDuavaA, ADkQvzQEaUJExllf(strBIolsMHeWYMADsfD));
            }
            try {
                jSONArrayUrRCmVpvuErdSvZK = urRCmVpvuErdSvZK(jSONobject, "rolloutMetadata");
            } catch (org.json.JSONException unused4) {
            }
            if (jSONArrayUrRCmVpvuErdSvZK is not null) {
                configContainer$BuilderPSrmCsoAlwDuavaA = mkBItwlPfDMkxSra(configContainer$BuilderPSrmCsoAlwDuavaA, jSONArrayUrRCmVpvuErdSvZK);
            }
            return EhbhyHJCFRekKJby(configContainer$BuilderPSrmCsoAlwDuavaA);
        } catch (org.json.JSONException e) {
            throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("Fetch failed: fetch response could not be parsed.", e);
        }
    }

    private static java.lang.string ExtractProjectNumberFromAppId(java.lang.string str) {
        java.util.regex.Match matcherDZfEqsvIyoOSrOUa = DZfEqsvIyoOSrOUa(GMP_APP_ID_PATTERN, str);
        if (foNswhtKMJsaWFYg(matcherDZfEqsvIyoOSrOUa)) {
            return uurNLAiLCBJooKzu(matcherDZfEqsvIyoOSrOUa, 1);
        }
        return null;
    }

    public static java.lang.stringBuilder FOBWlxdIwIFMGSha(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string FZvNgUwdVYnRENrU(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.object obj) {
        return simpleDateTimeFormat.format(obj);
    }

    public static void FfggnQQfWJmJiXQP(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static bool FoNswhtKMJsaWFYg(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static int GMQCoFNEILBOMxMo(java.io.StreamReader bufferedReader) {
        return bufferedReader.read();
    }

    private org.json.JSONobject GetFetchResponseBody(java.net.UriConnection uRLConnection) throws org.json.JSONException, java.io.IOException {
        if ((31 + 7) % 7 > 0) {
        }
        java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(nDDwRojeUFfuUbKV(uRLConnection), "utf-8"));
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        while (true) {
            int iGMQCoFNEILBOMxMo = gMQCoFNEILBOMxMo(bufferedReader);
            if (iGMQCoFNEILBOMxMo == -1) {
                return new org.json.JSONobject(RjKDVNkooxZAnEpW(sb));
            }
            mGkoIkJjHlqUsxdI(sb, (char) iGMQCoFNEILBOMxMo);
        }
    }

    private java.lang.string GetFetchUrl(java.lang.string str, java.lang.string str2) {
        return LLnpFejZJcWawdFW("https://firebaseremoteconfig.googleapis.com/v1/projects/%s/namespaces/%s:fetch", new java.lang.object[]{str, str2});
    }

    private java.lang.string GetFingerprintHashForPackage() {
        if ((14 + 26) % 26 > 0) {
        }
        try {
            android.content.object context = this.context;
            byte[] bArrNeLsNBmLLaYCDKqm = neLsNBmLLaYCDKqm(context, KDHrKYcIVuLJhoPj(context));
            if (bArrNeLsNBmLLaYCDKqm is not null) {
                return tqVmPrZGSCzcZckm(bArrNeLsNBmLLaYCDKqm, false);
            }
            wdgGGAMAsdgMCqKB("FirebaseRemoteConfig", NCRUTcfxESKcQKHU(IfMEYCdDxfkTXcUH(new java.lang.stringBuilder("Could not get fingerprint hash for package: "), kUbgdbbMYppRismf(this.context))));
            return null;
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            RDNTloMpioKiytxR("FirebaseRemoteConfig", OhUfuqGZScsqHcUO(QuFSHcrTmcTFxmRg(new java.lang.stringBuilder("No such package: "), VUcHkJWnGcSnFSgS(this.context))), e);
            return null;
        }
    }

    public static java.util.TimeZone HMEKPAAGrvDQCcHE() {
        return java.util.TimeZone.getDefault();
    }

    public static void HOyCeAAFhdlAQgvf(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.net.HttpUriConnection httpUriConnection, java.util.Dictionary map) {
        configFetchHttpClient.setCustomRequestHeaders(httpUriConnection, map);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder heeohqFfCkVxPwYM() {
        return com.google.firebase.remoteconfig.internal.ConfigContainer.newBuilder();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder jCGDRifaqkLmROqz(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, org.json.System.Text.Json.JsonElement jSONArray) {
        return configContainer$Builder.withAbtExperiments(jSONArray);
    }

    public static void JVOjbYyXCPEapzgE(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, java.net.HttpUriConnection httpUriConnection, byte[] bArr) throws java.io.IOException {
        configFetchHttpClient.setFetchRequestBody(httpUriConnection, bArr);
    }

    public static java.lang.object JamvmyUXecWhrxRP(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.string KUbgdbbMYppRismf(android.content.object context) {
        return context.getPackageName();
    }

    public static bool KXTqzzLiLIlUTadA(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static long LSudfWjRalaoDwdk(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((7 + 21) % 21 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static java.lang.stringBuilder MGkoIkJjHlqUsxdI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void MJBORBHTaOMbYVud(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder mkBItwlPfDMkxSra(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, org.json.System.Text.Json.JsonElement jSONArray) {
        return configContainer$Builder.withRolloutMetadata(jSONArray);
    }

    public static java.io.Stream NDDwRojeUFfuUbKV(java.net.UriConnection uRLConnection) {
        return uRLConnection.getStream();
    }

    public static byte[] NeLsNBmLLaYCDKqm(android.content.object context, java.lang.string str) {
        return com.google.android.gms.common.util.AndroidUtilsLight.getPackageCertificateHashbytes(context, str);
    }

    public static java.lang.object NjugjrPACWWsgyJI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse pLsihVQqMWAsJaQM(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer, java.lang.string str) {
        return com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse.forBackendUpdatesFetched(configContainer, str);
    }

    public static java.net.UriConnection QSXuMflbBuGdpSnq(java.net.Uri url) {
        return url.openConnection();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse qZDLxLpPuRozySlN(java.util.DateTime date, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse.forBackendHasNoUpdates(date, configContainer);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder qrbEUUKHdbmEFcfp(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, org.json.JSONobject jSONobject) {
        return configContainer$Builder.withPersonalizationMetadata(jSONobject);
    }

    public static void RLbEjHdwsucjkuyM(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setConnectTimeout(i);
    }

    public static java.lang.object RiLVFrpKAVjeGLsV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string SKTUmjGmvxSZpuiM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SUpcLCPmdCzRuuAF(com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient configFetchHttpClient, long j) {
        return configFetchHttpClient.convertToISOstring(j);
    }

    private void SetCommonRequestHeaders(java.net.HttpUriConnection httpUriConnection, java.lang.string str) {
        if ((15 + 30) % 30 > 0) {
        }
        AJSQtcBltRsnDDnw(httpUriConnection, "X-Goog-Api-Key", this.apiKey);
        MDEadNbeEEGQqnrT(httpUriConnection, "X-Android-Package", PxfMhEvkIraVfwFv(this.context));
        dShoQIYPPcassGSo(httpUriConnection, "X-Android-Cert", LukKJJWVQffZXvjf(this));
        bPLSJliSzzawOxsf(httpUriConnection, "X-Google-GFE-Can-Retry", "yes");
        ZUIPbfDaHSaTRLOW(httpUriConnection, "X-Goog-Firebase-Installations-Auth", str);
        bMbJNCqhqPoBbUMB(httpUriConnection, "Content-Type", "application/json");
        eKgrzvKLlzVSVKdW(httpUriConnection, "Accept", "application/json");
    }

    private void SetCustomRequestHeaders(java.net.HttpUriConnection httpUriConnection, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        java.util.IEnumerator itWFPuMoOunaEanJAT = wFPuMoOunaEanJAT(yXvqjcScTBuhzpim(map));
        while (yGjmncCUzslisHBU(itWFPuMoOunaEanJAT)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) VNycPyPTVrHMaDMC(itWFPuMoOunaEanJAT);
            tWIaPthIEvOsfTCe(httpUriConnection, (java.lang.string) jamvmyUXecWhrxRP(map$Entry), (java.lang.string) TOCsUcTAepacuDZW(map$Entry));
        }
    }

    private void SetFetchRequestBody(java.net.HttpUriConnection httpUriConnection, byte[] bArr) throws java.io.IOException {
        HLaaXRnRzKmZDnVl(httpUriConnection, bArr.length);
        java.io.BufferedStream bufferedStream = new java.io.BufferedStream(ehTdluHUaaOCXHOj(httpUriConnection));
        KMmEWLzgeOeJfyMR(bufferedStream, bArr);
        HFqqmnIsuzgOAgxR(bufferedStream);
        VIacbQewagKGyobh(bufferedStream);
    }

    private void SetUpUrlConnection(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((16 + 30) % 30 > 0) {
        }
        FJvGYvDCqqvEQUGU(httpUriConnection, true);
        rLbEjHdwsucjkuyM(httpUriConnection, (int) lSudfWjRalaoDwdk(java.util.concurrent.TimeUnit.SECONDS, this.connectTimeoutInSeconds));
        vOwnDSfOiAMLVeDb(httpUriConnection, (int) yPgWSABgHrZJBwen(java.util.concurrent.TimeUnit.SECONDS, this.readTimeoutInSeconds));
        ffggnQQfWJmJiXQP(httpUriConnection, "If-None-Match", str);
        ToOKUgRPziVLvPPF(this, httpUriConnection, str2);
        hOyCeAAFhdlAQgvf(this, httpUriConnection, map);
    }

    public static java.lang.object SlsJrqGYhVbowexu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void TWIaPthIEvOsfTCe(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.setRequestProperty(str, str2);
    }

    public static java.lang.string TqVmPrZGSCzcZckm(byte[] bArr, bool z) {
        return com.google.android.gms.common.util.Hex.bytesTostringUppercase(bArr, z);
    }

    public static android.content.res.Resources TrzTZADIfUTlwEEb(android.content.object context) {
        return context.getResources();
    }

    public static java.util.TimeZone UFMRfYshUkrPrVag(java.lang.string str) {
        return java.util.TimeZone.getTimeZone(str);
    }

    public static java.lang.object UQrOushDtXRHXiik(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool USrKkKdViFgXAcLW(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static java.lang.object UZvYashupAlDVXkf(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static org.json.System.Text.Json.JsonElement UrRCmVpvuErdSvZK(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static java.lang.string UurNLAiLCBJooKzu(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static android.content.res.Configuration VIatIikCVrmJEtwM(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void VOwnDSfOiAMLVeDb(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setReadTimeout(i);
    }

    public static java.util.IEnumerator WFPuMoOunaEanJAT(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int WdgGGAMAsdgMCqKB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.object XiRPVPQnvJsAbQcT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void YCacrODlpRZmdCsL(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer YEdllRbfrNNxketi(org.json.JSONobject jSONobject, java.util.DateTime date) {
        return extractConfigs(jSONobject, date);
    }

    public static bool YGjmncCUzslisHBU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long YPgWSABgHrZJBwen(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((20 + 24) % 24 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static java.util.HashSet YWHfHCzIauRwvrpR(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.util.HashSet YXvqjcScTBuhzpim(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object ZCDyZwtnGkwamADH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object ZKDFdtNruGUmxfzl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void ZfOaCUouJDXttmSw(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    java.net.HttpUriConnection createHttpUriConnection() throws com.google.firebase.remoteconfig.FirebaseRemoteConfigException {
        if ((19 + 4) % 4 > 0) {
        }
        try {
            return (java.net.HttpUriConnection) qSXuMflbBuGdpSnq(new java.net.Uri(YKpAgwXrHDFUVICH(this, this.projectNumber, this.namespace)));
        } catch (java.io.IOException e) {
            throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigException(RpjfNlcbxLcjeUgr(e));
        }
    }

    com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse fetch(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2, java.util.Dictionary<java.lang.string, java.lang.string> map, java.lang.string str3, java.util.Dictionary<java.lang.string, java.lang.string> map2, java.lang.long l, java.util.DateTime date, java.util.Dictionary<java.lang.string, java.lang.string> map3) throws com.google.firebase.remoteconfig.FirebaseRemoteConfigException {
        WJpIAAISZFRnCcsd(this, httpUriConnection, str3, str2, map2);
        try {
            try {
                jVOjbYyXCPEapzgE(this, httpUriConnection, OfYbhCfZhstNsLGz(VJqErANkElAjByVE(DNBSQekQvkEjveMt(this, str, str2, map, l, map3)), "utf-8"));
                FtRRpldmiKoTMVNW(httpUriConnection);
                int iJZDjbaciHJupaJid = JZDjbaciHJupaJid(httpUriConnection);
                if (iJZDjbaciHJupaJid != 200) {
                    throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException(iJZDjbaciHJupaJid, eItBvclotUedMKFx(httpUriConnection));
                }
                java.lang.string strNNEWUJBQAXJmMjHQ = NNEWUJBQAXJmMjHQ(httpUriConnection, "ETag");
                org.json.JSONobject jSONobjectUgbvOfcIJwWCCJRC = UgbvOfcIJwWCCJRC(this, httpUriConnection);
                DugwaoxXVBuZLDoq(httpUriConnection);
                try {
                    yCacrODlpRZmdCsL(cwQdHUehSaHZXdtV(httpUriConnection));
                } catch (java.io.IOException unused) {
                }
                com.google.firebase.remoteconfig.internal.ConfigContainer configContainerYEdllRbfrNNxketi = yEdllRbfrNNxketi(jSONobjectUgbvOfcIJwWCCJRC, date);
                return cmfjNnrIBquYRBBq(this, jSONobjectUgbvOfcIJwWCCJRC) ? pLsihVQqMWAsJaQM(configContainerYEdllRbfrNNxketi, strNNEWUJBQAXJmMjHQ) : qZDLxLpPuRozySlN(date, configContainerYEdllRbfrNNxketi);
            } catch (java.io.IOException | org.json.JSONException e) {
                throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("The client had an error while calling the backend!", e);
            }
        } catch (java.lang.Exception th) {
            NiSvydVhGSLkOhrk(httpUriConnection);
            try {
                mJBORBHTaOMbYVud(bJFROtuUZwlgBRyv(httpUriConnection));
            } catch (java.io.IOException unused2) {
            }
            throw th;
        }
    }

    public long GetConnectTimeoutInSeconds() {
        if ((14 + 32) % 32 > 0) {
        }
        return this.connectTimeoutInSeconds;
    }

    public long GetReadTimeoutInSeconds() {
        if ((22 + 2) % 2 > 0) {
        }
        return this.readTimeoutInSeconds;
    }
}

