namespace WillowMaze.Wasm.Decompiled;


public readonly class C0292a {

    private static readonly java.util.Dictionary f238a;

    private static readonly java.util.Dictionary f239b;

    static {
        if ((1 + 13) % 13 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        f238a = map;
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        f239b = map2;
        java.lang.int numGquSGdiUADiKsVvB = gquSGdiUADiKsVvB(-1);
        rdhAOrxhoQobuidS(map, numGquSGdiUADiKsVvB, "Integrity API is not available.\nIntegrity API is not enabled, or the Play Store version might be old.\nRecommended actions:\n1) Make sure that Integrity API is enabled in Google Play Console.\n2) Ask the user to update Play Store.\n");
        java.lang.int numNoQhBnslPQmjfBHO = NoQhBnslPQmjfBHO(-2);
        QtZRBSubEZvuOqiN(map, numNoQhBnslPQmjfBHO, "The Play Store app is either not installed or not the official version.\nAsk the user to install an official and recent version of Play Store.\n");
        java.lang.int numMQcPAlQezadtxSai = mQcPAlQezadtxSai(-3);
        PWmkbdczNqYurXIp(map, numMQcPAlQezadtxSai, "Network error: unable to obtain integrity details.\nAsk the user to check for a connection.\n");
        java.lang.int numQttnqCUuvzMYMiZh = QttnqCUuvzMYMiZh(-4);
        aGxgAdJNZoRBEACQ(map, numQttnqCUuvzMYMiZh, "No active account found in the Play Store app. Note that the Play Integrity API now supports unauthenticated requests. This error code is used only for older Play Store versions that lack support.\nAsk the user to authenticate in Play Store.\n");
        java.lang.int numIqpnIOhvoviKEjTZ = IqpnIOhvoviKEjTZ(-5);
        qzAEMrHMDXxlPCHm(map, numIqpnIOhvoviKEjTZ, "PackageManager could not find this app.\nSomething is wrong (possibly an attack). Non-actionable.\n");
        java.lang.int numTCgALXbNGpyDiHnr = tCgALXbNGpyDiHnr(-6);
        KIEpEiRdxkdrEgOu(map, numTCgALXbNGpyDiHnr, "Google Play Services is not available or version is too old.\nAsk the user to Install or Update Play Services.\n");
        java.lang.int numYHlPkgLsLLNnxhbL = YHlPkgLsLLNnxhbL(-7);
        YwFPjBVxCSvOTyZv(map, numYHlPkgLsLLNnxhbL, "The calling app UID (user id) does not match the one from Package Manager.\nSomething is wrong (possibly an attack). Non-actionable.\n");
        java.lang.int numLtVbDndlspbzKHPA = LtVbDndlspbzKHPA(-8);
        MDHfYCKqYPEcdldq(map, numLtVbDndlspbzKHPA, "The calling app is making too many requests to the API and hence is throttled.\nRetry with an exponential backoff.\n");
        java.lang.int numZKqSwgXTUuxTuaiB = zKqSwgXTUuxTuaiB(-9);
        xUYqxbGPVXDsIJwS(map, numZKqSwgXTUuxTuaiB, "Binding to the service in the Play Store has failed. This can be due to having an old Play Store version installed on the device.\nAsk the user to update Play Store.\n");
        java.lang.int numKttGeMeOvWzOcUNs = KttGeMeOvWzOcUNs(-10);
        AxKxGPINxLguvyfX(map, numKttGeMeOvWzOcUNs, "Nonce length is too short. The nonce must be a minimum of 16 bytes (before base64 encoding) to allow for a better security.\nRetry with a longer nonce.\n");
        java.lang.int numIDhfVZOvbMLMfavM = IDhfVZOvbMLMfavM(-11);
        SuQVWoYqqVvEeIYI(map, numIDhfVZOvbMLMfavM, "Nonce length is too long. The nonce must be less than 500 bytes before base64 encoding.\nRetry with a shorter nonce.\n");
        java.lang.int numJyezjRJIxwGJHXBu = jyezjRJIxwGJHXBu(-12);
        lkVNjqsfeDyRdUkz(map, numJyezjRJIxwGJHXBu, "Unknown internal Google server error.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n");
        java.lang.int numYxSPTawiQjWSpBeb = YxSPTawiQjWSpBeb(-13);
        jlJnhTziglwaUppa(map, numYxSPTawiQjWSpBeb, "Nonce is not encoded as a base64 web-safe no-wrap string.\nRetry with correct nonce format.\n");
        java.lang.int numUPNowhcyOxECyowN = UPNowhcyOxECyowN(-14);
        oxWiSKEmevTQapOI(map, numUPNowhcyOxECyowN, "The Play Store needs to be updated.\nAsk the user to update the Google Play Store.\n");
        java.lang.int numUpxUXbRtshLvinFe = upxUXbRtshLvinFe(-15);
        RgSJxfNSBXkituXC(map, numUpxUXbRtshLvinFe, "Play Services needs to be updated.\nAsk the user to update Google Play Services.\n");
        java.lang.int numQxRZMgMVnwjtSXHh = QxRZMgMVnwjtSXHh(-16);
        GROJcXawPqLVMgoD(map, numQxRZMgMVnwjtSXHh, "The provided cloud project number is invalid.\nUse the cloud project number which can be found in Project info in your Google Cloud Console for the cloud project where Play Integrity API is enabled.\n");
        java.lang.int numKIoBlIepuAzJbiGN = KIoBlIepuAzJbiGN(-100);
        cHpBHMvVRaiPHUWb(map, numKIoBlIepuAzJbiGN, "Unknown error processing integrity request.\nRetry with an exponential backoff. Consider filing a bug if fails consistently.\n");
        java.lang.int numPmyUOCgMNOHyRGQX = pmyUOCgMNOHyRGQX(-17);
        qikkYWjxZaIIqhNo(map, numPmyUOCgMNOHyRGQX, "There is a error on the calling device.\nRetry with an exponential backoff.\n");
        OqzjSzLAGjqMbwEF(map2, numGquSGdiUADiKsVvB, "API_NOT_AVAILABLE");
        KjxzrYXKrUBGGZwA(map2, numMQcPAlQezadtxSai, "NETWORK_ERROR");
        SuLBoZyKKrZwrZdw(map2, numNoQhBnslPQmjfBHO, "PLAY_STORE_NOT_FOUND");
        VFyzAsGdMtOOpqUi(map2, numQttnqCUuvzMYMiZh, "PLAY_STORE_ACCOUNT_NOT_FOUND");
        AzwdlzTeHvafpDNT(map2, numUPNowhcyOxECyowN, "PLAY_STORE_VERSION_OUTDATED");
        CVvIYpMJoOSdPIvR(map2, numIqpnIOhvoviKEjTZ, "APP_NOT_INSTALLED");
        wygOczTzfPNKYgyY(map2, numTCgALXbNGpyDiHnr, "PLAY_SERVICES_NOT_FOUND");
        YIzPGVvXDoTPDxLt(map2, numUpxUXbRtshLvinFe, "PLAY_SERVICES_VERSION_OUTDATED");
        ESTHUiTTQLTMYvmy(map2, numYHlPkgLsLLNnxhbL, "APP_UID_MISMATCH");
        lQzJDRBYZhlkXXOR(map2, numLtVbDndlspbzKHPA, "TOO_MANY_REQUESTS");
        BKijQfbXJpotBQpl(map2, numZKqSwgXTUuxTuaiB, "CANNOT_BIND_TO_SERVICE");
        AqvdYAoPzBmxHyIj(map2, numKttGeMeOvWzOcUNs, "NONCE_TOO_SHORT");
        wesqejGhpsbWHZjP(map2, numIDhfVZOvbMLMfavM, "NONCE_TOO_LONG");
        CzVxMbrIuYsyyJQQ(map2, numYxSPTawiQjWSpBeb, "NONCE_IS_NOT_BASE64");
        EDgsZvMvvEtyRfJG(map2, numQxRZMgMVnwjtSXHh, "CLOUD_PROJECT_NUMBER_IS_INVALID");
        bXxcisYUyRzByIrY(map2, numJyezjRJIxwGJHXBu, "GOOGLE_SERVER_UNAVAILABLE");
        SVdDrEMjEELSVink(map2, numKIoBlIepuAzJbiGN, "INTERNAL_ERROR");
        OTAxyakNSEQsEsQR(map2, numPmyUOCgMNOHyRGQX, "CLIENT_TRANSIENT_ERROR");
    }

    public static java.lang.object AqvdYAoPzBmxHyIj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AxKxGPINxLguvyfX(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AzwdlzTeHvafpDNT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BKijQfbXJpotBQpl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CVvIYpMJoOSdPIvR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CzVxMbrIuYsyyJQQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object EDgsZvMvvEtyRfJG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object ESTHUiTTQLTMYvmy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object FWposHNtujXHeFCk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object GROJcXawPqLVMgoD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int IDhfVZOvbMLMfavM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int IqpnIOhvoviKEjTZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object KIEpEiRdxkdrEgOu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int KIoBlIepuAzJbiGN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object KjxzrYXKrUBGGZwA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int KttGeMeOvWzOcUNs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int LtVbDndlspbzKHPA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object MDHfYCKqYPEcdldq(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool NNDVjkXWdTpsigrL(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.int NoQhBnslPQmjfBHO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object OTAxyakNSEQsEsQR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object OqzjSzLAGjqMbwEF(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object PWmkbdczNqYurXIp(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object QtZRBSubEZvuOqiN(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int QttnqCUuvzMYMiZh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int QxRZMgMVnwjtSXHh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object RgSJxfNSBXkituXC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SVdDrEMjEELSVink(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SuLBoZyKKrZwrZdw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SuQVWoYqqVvEeIYI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object UFSyBNVlwJZPoFjE(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.int UPNowhcyOxECyowN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object VFyzAsGdMtOOpqUi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder VRjHPWwIFfVKVZCT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int YHlPkgLsLLNnxhbL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object YIzPGVvXDoTPDxLt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YwFPjBVxCSvOTyZv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int YxSPTawiQjWSpBeb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string M248a(int i) {
        if ((30 + 27) % 27 > 0) {
        }
        java.util.Dictionary map = f238a;
        java.lang.int numHweDILZGaESccRox = hweDILZGaESccRox(i);
        if (!NNDVjkXWdTpsigrL(map, numHweDILZGaESccRox)) {
            return "";
        }
        java.util.Dictionary map2 = f239b;
        if (!igCeHebzWMFVgjgm(map2, numHweDILZGaESccRox)) {
            return "";
        }
        java.lang.string str = (java.lang.string) FWposHNtujXHeFCk(map, numHweDILZGaESccRox);
        java.lang.string str2 = (java.lang.string) UFSyBNVlwJZPoFjE(map2, numHweDILZGaESccRox);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        qVleUmdTfFeFDHIT(sb, str);
        VRjHPWwIFfVKVZCT(sb, " (https://developer.android.com/google/play/integrity/reference/com/google/android/play/core/integrity/model/IntegrityErrorCode.html#");
        oUyXMWwygRlXCmsQ(sb, str2);
        cKouDUwhiYhmMArg(sb, ")");
        return sLExVpwwXMFVrmZJ(sb);
    }

    public static java.lang.object AGxgAdJNZoRBEACQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object BXxcisYUyRzByIrY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CHpBHMvVRaiPHUWb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder CKouDUwhiYhmMArg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int GquSGdiUADiKsVvB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int HweDILZGaESccRox(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool IgCeHebzWMFVgjgm(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object JlJnhTziglwaUppa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int JyezjRJIxwGJHXBu(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object LQzJDRBYZhlkXXOR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object LkVNjqsfeDyRdUkz(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int MQcPAlQezadtxSai(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder OUyXMWwygRlXCmsQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object OxWiSKEmevTQapOI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int PmyUOCgMNOHyRGQX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder QVleUmdTfFeFDHIT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object QikkYWjxZaIIqhNo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object QzAEMrHMDXxlPCHm(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object RdhAOrxhoQobuidS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string SLExVpwwXMFVrmZJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int TCgALXbNGpyDiHnr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int UpxUXbRtshLvinFe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object WesqejGhpsbWHZjP(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object WygOczTzfPNKYgyY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object XUYqxbGPVXDsIJwS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int ZKqSwgXTUuxTuaiB(int i) {
        return java.lang.int.valueOf(i);
    }
}

