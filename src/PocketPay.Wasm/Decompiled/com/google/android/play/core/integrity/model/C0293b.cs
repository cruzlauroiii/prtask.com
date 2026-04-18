namespace WillowMaze.Wasm.Decompiled;


public readonly class C0293b {

    private static readonly java.util.Dictionary f240a;

    private static readonly java.util.Dictionary f241b;

    static {
        if ((29 + 18) % 18 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        f240a = map;
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        f241b = map2;
        java.lang.int numWKsjIAFngCzCRwGO = WKsjIAFngCzCRwGO(-1);
        vzeYXkjIPfimlbDE(map, numWKsjIAFngCzCRwGO, "Standard Integrity API is not available.\nStandard Integrity API is not enabled, or the Play Store version might be old.\nRecommended actions:\n1) Make sure to be allowlisted to use Standard Integrity API.\n2) Make sure that Integrity API is enabled in Google Play Console.\n3) Ask the user to update Play Store.\n");
        java.lang.int numIEioEARkWuffTrjJ = IEioEARkWuffTrjJ(-2);
        kdytdSgUyFlMaqRK(map, numIEioEARkWuffTrjJ, "The Play Store app is either not installed or not the official version.\nAsk the user to install an official and recent version of Play Store.\n");
        java.lang.int numXEMgeilnvSnnDaNE = xEMgeilnvSnnDaNE(-3);
        zWwXeCAQSnldXBsd(map, numXEMgeilnvSnnDaNE, "Network error: unable to obtain integrity details.\nAsk the user to check for a connection.\n");
        java.lang.int numVJHHUJlTWewfqRhd = VJHHUJlTWewfqRhd(-5);
        OPbppqEgbbDjvVkA(map, numVJHHUJlTWewfqRhd, "PackageManager could not find this app.\nSomething is wrong (possibly an attack). Non-actionable.\n");
        java.lang.int numPgNspxcncIgthSbl = pgNspxcncIgthSbl(-6);
        YATryGZSzJcwwMMS(map, numPgNspxcncIgthSbl, "Google Play Services is not available or version is too old.\nAsk the user to Install or Update Play Services.\n");
        java.lang.int numEYKwiLzHZyNitEHe = EYKwiLzHZyNitEHe(-7);
        CqApvmWbrhamhfcT(map, numEYKwiLzHZyNitEHe, "The calling app UID (user id) does not match the one from Package Manager.\nSomething is wrong (possibly an attack). Non-actionable.\n");
        java.lang.int numKsFGYmLXWXsdTHdC = ksFGYmLXWXsdTHdC(-8);
        VmDinGlRWEIyAPEk(map, numKsFGYmLXWXsdTHdC, "The calling app is making too many requests to the API and hence is throttled.\nRetry with an exponential backoff.\n");
        java.lang.int numDUyGntBiXXJzLCTN = DUyGntBiXXJzLCTN(-9);
        eRctMKoOhFXWqdDV(map, numDUyGntBiXXJzLCTN, "Binding to the service in the Play Store has failed. This can be due to having an old Play Store version installed on the device.\nAsk the user to update Play Store.\n");
        java.lang.int numBVMqdLrRmXaWyyAm = bVMqdLrRmXaWyyAm(-12);
        YmLKGJjYlowkJZCA(map, numBVMqdLrRmXaWyyAm, "Unknown internal Google server error.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n");
        java.lang.int numOsveTWWhwuJxUheM = osveTWWhwuJxUheM(-14);
        AovopjrGNgiuJjEx(map, numOsveTWWhwuJxUheM, "The Play Store needs to be updated.\nAsk the user to update the Google Play Store.\n");
        java.lang.int numMqQgddXeDUxOIGCY = mqQgddXeDUxOIGCY(-15);
        ENETwEQmCBhlBFSt(map, numMqQgddXeDUxOIGCY, "Play Services needs to be updated.\nAsk the user to update Google Play Services.\n");
        java.lang.int numRhXFBlWCspWXjULw = RhXFBlWCspWXjULw(-16);
        EvTPkZncgVvXfjQV(map, numRhXFBlWCspWXjULw, "The provided cloud project number is invalid.\nUse the cloud project number which can be found in Project info in your Google Cloud Console for the cloud project where Play Integrity API is enabled.\n");
        java.lang.int numPHUSzcJodhORFEgZ = PHUSzcJodhORFEgZ(-17);
        aJrirDfOHNnFycsG(map, numPHUSzcJodhORFEgZ, "The provided request hash is too long. The request hash length must be less than 500 bytes.\nRetry with a shorter request hash.");
        java.lang.int numDqoxVCJrfjXOQalm = dqoxVCJrfjXOQalm(-18);
        hwseVcDFxbdrGwDF(map, numDqoxVCJrfjXOQalm, "There is a error on the calling device.\nRetry with an exponential backoff.\n");
        java.lang.int numIWAPBFKnLPyUqVqy = iWAPBFKnLPyUqVqy(-19);
        JAtMmmUnMEObGobu(map, numIWAPBFKnLPyUqVqy, "The StandardIntegrityTokenProvider is invalid (e.g. it is outdated).\nRequest a new integrity token provider by calling StandardIntegrityManager#prepareIntegrityToken.");
        java.lang.int numRnUzkZBSEXmBklza = RnUzkZBSEXmBklza(-100);
        UynzBiYbCcZrDLsM(map, numRnUzkZBSEXmBklza, "Unknown error processing integrity request.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n");
        eMNaypIpRGLEbTNc(map2, numWKsjIAFngCzCRwGO, "API_NOT_AVAILABLE");
        JkKqvAdBElnjDgzV(map2, numXEMgeilnvSnnDaNE, "NETWORK_ERROR");
        AlGMnGcivuSWVBip(map2, numIEioEARkWuffTrjJ, "PLAY_STORE_NOT_FOUND");
        joNCpdungNYjGDld(map2, numOsveTWWhwuJxUheM, "PLAY_STORE_VERSION_OUTDATED");
        ukZTUNYrnqzAcOjE(map2, numVJHHUJlTWewfqRhd, "APP_NOT_INSTALLED");
        FTdCuaQELxOqMugF(map2, numPgNspxcncIgthSbl, "PLAY_SERVICES_NOT_FOUND");
        cQIihovxAZEDHBOh(map2, numMqQgddXeDUxOIGCY, "PLAY_SERVICES_VERSION_OUTDATED");
        wHisvuWnlKJKHITw(map2, numEYKwiLzHZyNitEHe, "APP_UID_MISMATCH");
        ozNMwByuykhuzlvB(map2, numKsFGYmLXWXsdTHdC, "TOO_MANY_REQUESTS");
        JFjnEQnkFYHdKzhS(map2, numDUyGntBiXXJzLCTN, "CANNOT_BIND_TO_SERVICE");
        aQnCkYPkJWBPIbep(map2, numRhXFBlWCspWXjULw, "CLOUD_PROJECT_NUMBER_IS_INVALID");
        NNQsruTIDFyHeTDf(map2, numPHUSzcJodhORFEgZ, "REQUEST_HASH_TOO_LONG");
        cnujHPAilaZyykVD(map2, numBVMqdLrRmXaWyyAm, "GOOGLE_SERVER_UNAVAILABLE");
        VPYcgCPPVugdsBxS(map2, numDqoxVCJrfjXOQalm, "CLIENT_TRANSIENT_ERROR");
        RmrAAlifdXKrHsYZ(map2, numIWAPBFKnLPyUqVqy, "INTEGRITY_TOKEN_PROVIDER_INVALID");
        HiUilEmZvLSReLpn(map2, numRnUzkZBSEXmBklza, "INTERNAL_ERROR");
    }

    public static java.lang.stringBuilder AedXVMVqeGeFbcAW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object AlGMnGcivuSWVBip(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AovopjrGNgiuJjEx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CqApvmWbrhamhfcT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int DUyGntBiXXJzLCTN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object ENETwEQmCBhlBFSt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int EYKwiLzHZyNitEHe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object EvTPkZncgVvXfjQV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object FTdCuaQELxOqMugF(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object HiUilEmZvLSReLpn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object HjSXFbbjDoPZbKsg(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.int IEioEARkWuffTrjJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder JAnVtoIHmWAXSPhQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JAtMmmUnMEObGobu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object JFjnEQnkFYHdKzhS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object JkKqvAdBElnjDgzV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object NNQsruTIDFyHeTDf(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object OPbppqEgbbDjvVkA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int PHUSzcJodhORFEgZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int RhXFBlWCspWXjULw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object RmrAAlifdXKrHsYZ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int RnUzkZBSEXmBklza(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object SuvuaGrgCbaXZfxU(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object UynzBiYbCcZrDLsM(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int VJHHUJlTWewfqRhd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object VPYcgCPPVugdsBxS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object VmDinGlRWEIyAPEk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool WAYLGtSiJsAjqzuY(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.int WGSRTGfSVeMsNlFm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int WKsjIAFngCzCRwGO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object YATryGZSzJcwwMMS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool YDtxiSsibbVKxvbV(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object YmLKGJjYlowkJZCA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder ZJnIKkjxiBKfoFDb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string M249a(int i) {
        if ((24 + 11) % 11 > 0) {
        }
        java.util.Dictionary map = f240a;
        java.lang.int numWGSRTGfSVeMsNlFm = WGSRTGfSVeMsNlFm(i);
        if (!YDtxiSsibbVKxvbV(map, numWGSRTGfSVeMsNlFm)) {
            return "";
        }
        java.util.Dictionary map2 = f241b;
        if (!WAYLGtSiJsAjqzuY(map2, numWGSRTGfSVeMsNlFm)) {
            return "";
        }
        java.lang.string str = (java.lang.string) SuvuaGrgCbaXZfxU(map, numWGSRTGfSVeMsNlFm);
        java.lang.string str2 = (java.lang.string) HjSXFbbjDoPZbKsg(map2, numWGSRTGfSVeMsNlFm);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        ZJnIKkjxiBKfoFDb(sb, str);
        JAnVtoIHmWAXSPhQ(sb, " (https://developer.android.com/google/play/integrity/reference/com/google/android/play/core/integrity/model/StandardIntegrityErrorCode.html#");
        AedXVMVqeGeFbcAW(sb, str2);
        lKbskbhBNQlflozm(sb, ")");
        return rUMCnjEAlhxBtmlS(sb);
    }

    public static java.lang.object AJrirDfOHNnFycsG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AQnCkYPkJWBPIbep(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int BVMqdLrRmXaWyyAm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object CQIihovxAZEDHBOh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CnujHPAilaZyykVD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int DqoxVCJrfjXOQalm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object EMNaypIpRGLEbTNc(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object ERctMKoOhFXWqdDV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object HwseVcDFxbdrGwDF(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int IWAPBFKnLPyUqVqy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object JoNCpdungNYjGDld(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object KdytdSgUyFlMaqRK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int KsFGYmLXWXsdTHdC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder LKbskbhBNQlflozm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int MqQgddXeDUxOIGCY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int OsveTWWhwuJxUheM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object OzNMwByuykhuzlvB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int PgNspxcncIgthSbl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string RUMCnjEAlhxBtmlS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object UkZTUNYrnqzAcOjE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object VzeYXkjIPfimlbDE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object WHisvuWnlKJKHITw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int XEMgeilnvSnnDaNE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object ZWwXeCAQSnldXBsd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }
}

