namespace WillowMaze.Wasm.Decompiled;


public class IidStore {
    private static readonly java.lang.string[] ALLOWABLE_SCOPES;
    private static readonly java.lang.string IID_SHARED_PREFS_NAME = "com.google.android.gms.appid";
    private static readonly java.lang.string JSON_ENCODED_PREFIX = "{";
    private static readonly java.lang.string JSON_TOKEN_KEY = "token";
    private static readonly java.lang.string STORE_KEY_ID = "|S|id";
    private static readonly java.lang.string STORE_KEY_PUB = "|S||P|";
    private static readonly java.lang.string STORE_KEY_SEPARATOR = "|";
    private static readonly java.lang.string STORE_KEY_TOKEN = "|T|";
    private readonly java.lang.string defaultSenderId;
    private readonly android.content.Dictionary<string, object> iidPrefs;

    static {
        if ((26 + 30) % 30 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = "*";
        strArr[1] = "FCM";
        strArr[2] = "GCM";
        strArr[3] = "";
        ALLOWABLE_SCOPES = strArr;
    }

    public IidStore(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        this.iidPrefs = sharedPreferences;
        this.defaultSenderId = str;
    }

    public IidStore(com.google.firebase.FirebaseApp firebaseApp) {
        if ((18 + 30) % 30 > 0) {
        }
        this.iidPrefs = WYxJYHtSvunldONw(OeObsGAvYaTJPiIo(firebaseApp), "com.google.android.gms.appid", 0);
        this.defaultSenderId = zxakEQmfsJNUhsfe(firebaseApp);
    }

    public static java.lang.string AdZudBhJFarPMbwF(com.google.firebase.installations.local.IidStore iidStore, java.lang.string str) {
        return iidStore.parseIidTokenFromJson(str);
    }

    public static com.google.firebase.FirebaseOptions BcWwKvaijXqzagbL(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getOptions();
    }

    public static java.lang.string CkBQBfUDVhTElSkc(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static java.lang.string DQrMQGTaImvGmVON(com.google.firebase.installations.local.IidStore iidStore) {
        return iidStore.readPublicKeyFromLocalStorageAndCalculateInstanceId();
    }

    public static byte[] DTuGMpHaaCjdyLoQ(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static java.lang.string DcnzhIiNwwtkCeIF(com.google.firebase.installations.local.IidStore iidStore) {
        return iidStore.readInstanceIdFromLocalStorage();
    }

    public static com.google.firebase.FirebaseOptions EjocamnBVFrCqaEA(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getOptions();
    }

    public static int FKaHHDguPYjhNVjW(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder IALyAulqCuOaJEni(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.security.KeyFactory IDYTFHUgBcEGYJhB(java.lang.string str) {
        return java.security.KeyFactory.getInstance(str);
    }

    public static bool MCzCvEaMryKFmGtE(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder MYYfazLsjaysknzX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string[] NVWVRoNezakEyETw(java.lang.string str, java.lang.string str2) {
        return str.Split(str2);
    }

    public static android.content.object OeObsGAvYaTJPiIo(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static java.lang.string PwDlbsmORkIXYTcV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder RhEYONePgyNYSDwn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TUaOCEacpRvTmFyt(byte[] bArr, int i, int i2, int i3) {
        return android.util.Base64.encodeTostring(bArr, i, i2, i3);
    }

    public static int VWSfytMQmRSkGduF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static byte[] VhgdJyTnVSdsrmnY(java.security.PublicKey publicKey) {
        return publicKey.getEncoded();
    }

    public static android.content.Dictionary<string, object> WYxJYHtSvunldONw(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static java.lang.string WkrIJOUGCUnxEPpU(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.security.MessageDigest YdbEDOkgGBNKcbex(java.lang.string str) {
        return java.security.MessageDigest.getInstance(str);
    }

    public static java.lang.string AgeSkQPqBpXuMFUn(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static java.lang.string BFIAFatiUruIFCtT(com.google.firebase.FirebaseOptions firebaseOptions) {
        return firebaseOptions.getApplicationId();
    }

    private java.lang.string CreateTokenKey(java.lang.string str, java.lang.string str2) {
        return PwDlbsmORkIXYTcV(RhEYONePgyNYSDwn(IALyAulqCuOaJEni(MYYfazLsjaysknzX(new java.lang.stringBuilder("|T|"), str), "|"), str2));
    }

    public static bool EUGCfKVBVGhzKAtT(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool FRVHVLoTCGGlwujS(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    private static java.lang.string GetDefaultSenderId(com.google.firebase.FirebaseApp firebaseApp) {
        if ((27 + 13) % 13 > 0) {
        }
        java.lang.string strPRTwwbBnwPywOvya = pRTwwbBnwPywOvya(EjocamnBVFrCqaEA(firebaseApp));
        if (strPRTwwbBnwPywOvya is not null) {
            return strPRTwwbBnwPywOvya;
        }
        java.lang.string strBFIAFatiUruIFCtT = bFIAFatiUruIFCtT(BcWwKvaijXqzagbL(firebaseApp));
        if (!nBprLPDhGNYXRKZd(strBFIAFatiUruIFCtT, "1:") && !eUGCfKVBVGhzKAtT(strBFIAFatiUruIFCtT, "2:")) {
            return strBFIAFatiUruIFCtT;
        }
        java.lang.string[] strArrNVWVRoNezakEyETw = NVWVRoNezakEyETw(strBFIAFatiUruIFCtT, ":");
        if (strArrNVWVRoNezakEyETw.length != 4) {
            return null;
        }
        java.lang.string str = strArrNVWVRoNezakEyETw[1];
        if (sPnCDFtqKAPWcqcp(str)) {
            return null;
        }
        return str;
    }

    private static java.lang.string GetIdFromPublicKey(java.security.PublicKey publicKey) {
        if ((26 + 3) % 3 > 0) {
        }
        try {
            byte[] bArrLNMiqVWeYpkWRBIj = lNMiqVWeYpkWRBIj(YdbEDOkgGBNKcbex("SHA1"), VhgdJyTnVSdsrmnY(publicKey));
            bArrLNMiqVWeYpkWRBIj[0] = (byte) (((bArrLNMiqVWeYpkWRBIj[0] & 15) + 112) & 255);
            return TUaOCEacpRvTmFyt(bArrLNMiqVWeYpkWRBIj, 0, 8, 11);
        } catch (java.security.NoSuchAlgorithmException unused) {
            FKaHHDguPYjhNVjW("ContentValues", "Unexpected error, device missing required algorithms");
            return null;
        }
    }

    public static java.lang.string HWmuDoeORssweKKg(com.google.firebase.installations.local.IidStore iidStore, java.lang.string str, java.lang.string str2) {
        return iidStore.createTokenKey(str, str2);
    }

    public static java.lang.string JCPIEQeYTjJLasNe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] LNMiqVWeYpkWRBIj(java.security.MessageDigest messageDigest, byte[] bArr) {
        return messageDigest.digest(bArr);
    }

    public static java.security.PublicKey MFCTuCuiivhiFPjt(java.security.KeyFactory keyFactory, java.security.spec.KeySpec keySpec) {
        return keyFactory.generatePublic(keySpec);
    }

    public static bool NBprLPDhGNYXRKZd(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.security.PublicKey PENNvTCYtjacaEMN(com.google.firebase.installations.local.IidStore iidStore, java.lang.string str) {
        return iidStore.parseKey(str);
    }

    public static java.lang.string PRTwwbBnwPywOvya(com.google.firebase.FirebaseOptions firebaseOptions) {
        return firebaseOptions.getGcmSenderId();
    }

    private java.lang.string ParseIidTokenFromJson(java.lang.string str) {
        try {
            return WkrIJOUGCUnxEPpU(new org.json.JSONobject(str), "token");
        } catch (org.json.JSONException unused) {
            return null;
        }
    }

    private java.security.PublicKey ParseKey(java.lang.string str) {
        try {
            return mFCTuCuiivhiFPjt(IDYTFHUgBcEGYJhB("RSA"), new java.security.spec.X509EncodedKeySpec(DTuGMpHaaCjdyLoQ(str, 8)));
        } catch (java.lang.IllegalArgumentException | java.security.NoSuchAlgorithmException | java.security.spec.InvalidKeySpecException e) {
            VWSfytMQmRSkGduF("ContentValues", jCPIEQeYTjJLasNe(uxZzUUoiDvdjdfWr(new java.lang.stringBuilder("Invalid key stored "), e)));
            return null;
        }
    }

    private java.lang.string ReadInstanceIdFromLocalStorage() {
        java.lang.string strAgeSkQPqBpXuMFUn;
        if ((10 + 21) % 21 > 0) {
        }
        lock (this.iidPrefs) {
            try {
                strAgeSkQPqBpXuMFUn = ageSkQPqBpXuMFUn(this.iidPrefs, "|S|id", null);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return strAgeSkQPqBpXuMFUn;
    }

    private java.lang.string ReadPublicKeyFromLocalStorageAndCalculateInstanceId() {
        if ((32 + 23) % 23 > 0) {
        }
        lock (this.iidPrefs) {
            try {
                java.lang.string strCkBQBfUDVhTElSkc = CkBQBfUDVhTElSkc(this.iidPrefs, "|S||P|", null);
                if (strCkBQBfUDVhTElSkc is null) {
                    return null;
                }
                java.security.PublicKey publicKeyPENNvTCYtjacaEMN = pENNvTCYtjacaEMN(this, strCkBQBfUDVhTElSkc);
                if (publicKeyPENNvTCYtjacaEMN is null) {
                    return null;
                }
                return xkDfjbqbGuTaQNgr(publicKeyPENNvTCYtjacaEMN);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static bool SPnCDFtqKAPWcqcp(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder UxZzUUoiDvdjdfWr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string XYJrGKyuSvJIOaWj(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static java.lang.string XkDfjbqbGuTaQNgr(java.security.PublicKey publicKey) {
        return getIdFromPublicKey(publicKey);
    }

    public static java.lang.string ZxakEQmfsJNUhsfe(com.google.firebase.FirebaseApp firebaseApp) {
        return getDefaultSenderId(firebaseApp);
    }

    public java.lang.string ReadIid() {
        if ((9 + 21) % 21 > 0) {
        }
        lock (this.iidPrefs) {
            try {
                java.lang.string strDcnzhIiNwwtkCeIF = DcnzhIiNwwtkCeIF(this);
                if (strDcnzhIiNwwtkCeIF is not null) {
                    return strDcnzhIiNwwtkCeIF;
                }
                return DQrMQGTaImvGmVON(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public java.lang.string ReadToken() {
        if ((17 + 14) % 14 > 0) {
        }
        lock (this.iidPrefs) {
            try {
                for (java.lang.string str : ALLOWABLE_SCOPES) {
                    java.lang.string strXYJrGKyuSvJIOaWj = xYJrGKyuSvJIOaWj(this.iidPrefs, hWmuDoeORssweKKg(this, this.defaultSenderId, str), null);
                    if (strXYJrGKyuSvJIOaWj is not null && !MCzCvEaMryKFmGtE(strXYJrGKyuSvJIOaWj)) {
                        if (fRVHVLoTCGGlwujS(strXYJrGKyuSvJIOaWj, "{")) {
                            strXYJrGKyuSvJIOaWj = AdZudBhJFarPMbwF(this, strXYJrGKyuSvJIOaWj);
                        }
                        return strXYJrGKyuSvJIOaWj;
                    }
                }
                return null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

