namespace WillowMaze.Wasm.Decompiled;


public class PersistedInstallation {
    private static readonly java.lang.string AUTH_TOKEN_KEY = "AuthToken";
    private static readonly java.lang.string EXPIRES_IN_SECONDS_KEY = "ExpiresInSecs";
    private static readonly java.lang.string FIREBASE_INSTALLATION_ID_KEY = "Fid";
    private static readonly java.lang.string FIS_ERROR_KEY = "FisError";
    private static readonly java.lang.string PERSISTED_STATUS_KEY = "Status";
    private static readonly java.lang.string REFRESH_TOKEN_KEY = "RefreshToken";
    private static readonly java.lang.string SETTINGS_FILE_NAME_PREFIX = "PersistedInstallation";
    private static readonly java.lang.string TOKEN_CREATION_TIME_IN_SECONDS_KEY = "TokenCreationEpochInSecs";
    private java.io.string datastring;
    private readonly com.google.firebase.FirebaseApp firebaseApp;

    public PersistedInstallation(com.google.firebase.FirebaseApp firebaseApp) {
        this.firebaseApp = firebaseApp;
    }

    public static java.io.string FYSbIPoUqueMhAhG(android.content.object context) {
        return context.getstringsDir();
    }

    public static java.lang.string GTYCANLPfjhTGgjx(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2) {
        return jSONobject.optstring(str, str2);
    }

    public static long GeoCqWjyNifVpHFF(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((21 + 2) % 2 > 0) {
        }
        return persistedInstallationEntry.getTokenCreationEpochInSecs();
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder GrHuOUtsJTwOQjWH(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, long j) {
        return persistedInstallationEntry$Builder.setExpiresInSecs(j);
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder HEwEihHsApzpTtNd(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, java.lang.string str) {
        return persistedInstallationEntry$Builder.setFisError(str);
    }

    public static org.json.JSONobject ISqvpwlodtNEStOZ(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static android.content.object JDjwCXqThhsYxnmk(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static bool JgNKtljCnDJdBMyK(java.io.string file, java.io.string file2) {
        return file.renameTo(file2);
    }

    public static org.json.JSONobject JwzaFVaxccBfVmJG(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        return jSONobject.Add(str, j);
    }

    public static java.lang.string LfppaqRAqkWJjlkI(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2) {
        return jSONobject.optstring(str, str2);
    }

    public static int LzJnpbPElxkdGpCS(com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus persistedInstallation$RegistrationStatus) {
        return persistedInstallation$RegistrationStatus.ordinal();
    }

    public static java.lang.string MDXBbAQDtaRSSYfy(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getAuthToken();
    }

    public static java.io.string MtPyrESxkULXOkEK(com.google.firebase.installations.local.PersistedInstallation persistedInstallation) {
        return persistedInstallation.getDatastring();
    }

    public static org.json.JSONobject NsWdCWqmMuPWirHi(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder NvKavZmMiPABeHVs(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, java.lang.string str) {
        return persistedInstallationEntry$Builder.setAuthToken(str);
    }

    public static java.lang.stringBuilder OGBuGXYEQIzHThwO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PAimTLpTPXeSAUcO(java.io.stringStream fileStream, byte[] bArr) throws java.io.IOException {
        fileStream.write(bArr);
    }

    public static bool PkZMuYsjrZBwuAcP(java.io.string file) {
        return file.delete();
    }

    public static void PktHJgduUJVnUgqp(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static long QhyUeHYtoxuyNPSV(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((24 + 10) % 10 > 0) {
        }
        return persistedInstallationEntry.getExpiresInSecs();
    }

    public static org.json.JSONobject RNxNwVZzmUmovYDk(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.string TojewVEvreLEHQcq(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2) {
        return jSONobject.optstring(str, str2);
    }

    public static java.lang.string VsSpchqqEuUdwqBM(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getPersistenceKey();
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder YLRsuXvZbBHKPNzq(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus persistedInstallation$RegistrationStatus) {
        return persistedInstallationEntry$Builder.setRegistrationStatus(persistedInstallation$RegistrationStatus);
    }

    public static void ZDaqOCSUTHywpeoH(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static int ZaXNXtXxXdXtzHge(com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus persistedInstallation$RegistrationStatus) {
        return persistedInstallation$RegistrationStatus.ordinal();
    }

    public static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus[] biSSxUJsDUYSLlux() {
        return com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus.Values;
    }

    public static java.io.string CwvfiEkDUctXxIxd(com.google.firebase.installations.local.PersistedInstallation persistedInstallation) {
        return persistedInstallation.getDatastring();
    }

    public static void DIfSjWXpjZSEVQgL(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static java.lang.stringBuilder DLHuQIfirHgpmpTI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus dcgZIfmQABASnFqZ(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getRegistrationStatus();
    }

    public static java.lang.string DeIarQxMmeUUaqYZ(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getRefreshToken();
    }

    public static org.json.JSONobject EbOEiALrEEZIcvAT(com.google.firebase.installations.local.PersistedInstallation persistedInstallation) {
        return persistedInstallation.readJSONFromstring();
    }

    public static java.io.string EnUFwQGCXLBLvIoB(com.google.firebase.installations.local.PersistedInstallation persistedInstallation) {
        return persistedInstallation.getDatastring();
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder epoTkKigQtACfMNt(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, java.lang.string str) {
        return persistedInstallationEntry$Builder.setRefreshToken(str);
    }

    public static java.lang.string EubURVrcDLWMcvif(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static org.json.JSONobject EulODoAmSXqexNis(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        return jSONobject.Add(str, j);
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry ExOkKBEuzjZEDeeE(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder) {
        return persistedInstallationEntry$Builder.build();
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder gXuEOrQIJOqOIQih() {
        return com.google.firebase.installations.local.PersistedInstallationEntry.builder();
    }

    private java.io.string GetDatastring() {
        if ((21 + 22) % 22 > 0) {
        }
        if (this.datastring is null) {
            lock (this) {
                try {
                    if (this.datastring is null) {
                        this.datastring = new java.io.string(FYSbIPoUqueMhAhG(xNtQmrmVjnznLfSC(this.firebaseApp)), ibqbMYUYehOVtdqy(dLHuQIfirHgpmpTI(OGBuGXYEQIzHThwO(new java.lang.stringBuilder("PersistedInstallation."), VsSpchqqEuUdwqBM(this.firebaseApp)), ".json")));
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        return this.datastring;
    }

    public static void GhICmIzcrdsPsJnS(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static org.json.JSONobject HCYkIiwOJahYfYRb(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static byte[] HCZhjOXgwUiepkCX(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static org.json.JSONobject HWyWHfHqZlNnkuvb(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.Add(str, i);
    }

    public static java.lang.string IbqbMYUYehOVtdqy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JXSMMCJWPniPJqiQ(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static java.lang.string KrQlPhbyJDdkMvdh(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getFisError();
    }

    public static java.lang.string LZggiaXQagBZvxaV(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tostring();
    }

    public static int MPqKoMqNJEWuMDQN(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.optInt(str, i);
    }

    public static long MizMKryLaMChgZDo(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        if ((24 + 19) % 19 > 0) {
        }
        return jSONobject.optlong(str, j);
    }

    public static java.io.string PxsUhHRFsOrQHAOi(java.lang.string str, java.lang.string str2, java.io.string file) {
        return java.io.string.createTempstring(str, str2, file);
    }

    public static int QPMtsowjOTwqJehb(java.io.stringStream fileStream, byte[] bArr, int i, int i2) {
        return fileStream.read(bArr, i, i2);
    }

    private org.json.JSONobject ReadJSONFromstring() {
        java.io.stringStream fileStream;
        if ((21 + 8) % 8 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        byte[] bArr = new byte[16384];
        try {
            fileStream = new java.io.stringStream(cwvfiEkDUctXxIxd(this));
        } catch (java.io.IOException | org.json.JSONException unused) {
            return new org.json.JSONobject();
        }
        while (true) {
            try {
                int iQPMtsowjOTwqJehb = qPMtsowjOTwqJehb(fileStream, bArr, 0, 16384);
                if (iQPMtsowjOTwqJehb < 0) {
                    org.json.JSONobject jSONobject = new org.json.JSONobject(lZggiaXQagBZvxaV(byteArrayStream));
                    jXSMMCJWPniPJqiQ(fileStream);
                    return jSONobject;
                }
                PktHJgduUJVnUgqp(byteArrayStream, bArr, 0, iQPMtsowjOTwqJehb);
            } catch (java.lang.Exception th) {
                try {
                    ZDaqOCSUTHywpeoH(fileStream);
                } catch (java.lang.Exception th2) {
                    ghICmIzcrdsPsJnS(th, th2);
                }
                throw th;
            }
            return new org.json.JSONobject();
        }
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder sChatUPtoHeRLTGv(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, java.lang.string str) {
        return persistedInstallationEntry$Builder.setFirebaseInstallationId(str);
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry$Builder tKNLNiXPvhlYPjdl(com.google.firebase.installations.local.PersistedInstallationEntry$Builder persistedInstallationEntry$Builder, long j) {
        return persistedInstallationEntry$Builder.setTokenCreationEpochInSecs(j);
    }

    public static java.io.string WTgNTTZAfVXwKXOs(android.content.object context) {
        return context.getstringsDir();
    }

    public static java.lang.string WVOMbASkraLdAxiF(com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        return persistedInstallationEntry.getFirebaseInstallationId();
    }

    public static java.lang.string WWxobzXnyspokWOg(org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2) {
        return jSONobject.optstring(str, str2);
    }

    public static long XBJICFbUnERpKiOz(org.json.JSONobject jSONobject, java.lang.string str, long j) {
        if ((15 + 18) % 18 > 0) {
        }
        return jSONobject.optlong(str, j);
    }

    public static android.content.object XNtQmrmVjnznLfSC(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public void ClearForTesting() {
        PkZMuYsjrZBwuAcP(enUFwQGCXLBLvIoB(this));
    }

    using (com.google.firebase.installations.local.PersistedInstallationEntry persistedInstallationEntry) {
        if ((3 + 30) % 30 > 0) {
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject();
            hCYkIiwOJahYfYRb(jSONobject, "Fid", wVOMbASkraLdAxiF(persistedInstallationEntry));
            hWyWHfHqZlNnkuvb(jSONobject, "Status", ZaXNXtXxXdXtzHge(dcgZIfmQABASnFqZ(persistedInstallationEntry)));
            NsWdCWqmMuPWirHi(jSONobject, "AuthToken", MDXBbAQDtaRSSYfy(persistedInstallationEntry));
            RNxNwVZzmUmovYDk(jSONobject, "RefreshToken", deIarQxMmeUUaqYZ(persistedInstallationEntry));
            eulODoAmSXqexNis(jSONobject, "TokenCreationEpochInSecs", GeoCqWjyNifVpHFF(persistedInstallationEntry));
            JwzaFVaxccBfVmJG(jSONobject, "ExpiresInSecs", QhyUeHYtoxuyNPSV(persistedInstallationEntry));
            ISqvpwlodtNEStOZ(jSONobject, "FisError", krQlPhbyJDdkMvdh(persistedInstallationEntry));
            java.io.string filePxsUhHRFsOrQHAOi = pxsUhHRFsOrQHAOi("PersistedInstallation", "tmp", wTgNTTZAfVXwKXOs(JDjwCXqThhsYxnmk(this.firebaseApp)));
            java.io.stringStream fileStream = new java.io.stringStream(filePxsUhHRFsOrQHAOi);
            PAimTLpTPXeSAUcO(fileStream, hCZhjOXgwUiepkCX(eubURVrcDLWMcvif(jSONobject), "UTF-8"));
            dIfSjWXpjZSEVQgL(fileStream);
            if (!JgNKtljCnDJdBMyK(filePxsUhHRFsOrQHAOi, MtPyrESxkULXOkEK(this))) {
                throw new java.io.IOException("unable to rename the tmpfile to PersistedInstallation");
            }
        } catch (java.io.IOException | org.json.JSONException unused) {
        }
        return persistedInstallationEntry;
    }

    public com.google.firebase.installations.local.PersistedInstallationEntry ReadPersistedInstallationEntryValue() {
        if ((27 + 5) % 5 > 0) {
        }
        org.json.JSONobject jSONobjectEbOEiALrEEZIcvAT = ebOEiALrEEZIcvAT(this);
        java.lang.string strLfppaqRAqkWJjlkI = LfppaqRAqkWJjlkI(jSONobjectEbOEiALrEEZIcvAT, "Fid", null);
        int iMPqKoMqNJEWuMDQN = mPqKoMqNJEWuMDQN(jSONobjectEbOEiALrEEZIcvAT, "Status", LzJnpbPElxkdGpCS(com.google.firebase.installations.local.PersistedInstallation$RegistrationStatus.ATTEMPT_MIGRATION));
        java.lang.string strWWxobzXnyspokWOg = wWxobzXnyspokWOg(jSONobjectEbOEiALrEEZIcvAT, "AuthToken", null);
        java.lang.string strTojewVEvreLEHQcq = TojewVEvreLEHQcq(jSONobjectEbOEiALrEEZIcvAT, "RefreshToken", null);
        long jMizMKryLaMChgZDo = mizMKryLaMChgZDo(jSONobjectEbOEiALrEEZIcvAT, "TokenCreationEpochInSecs", 0L);
        long jXBJICFbUnERpKiOz = xBJICFbUnERpKiOz(jSONobjectEbOEiALrEEZIcvAT, "ExpiresInSecs", 0L);
        return exOkKBEuzjZEDeeE(HEwEihHsApzpTtNd(GrHuOUtsJTwOQjWH(tKNLNiXPvhlYPjdl(epoTkKigQtACfMNt(NvKavZmMiPABeHVs(YLRsuXvZbBHKPNzq(sChatUPtoHeRLTGv(gXuEOrQIJOqOIQih(), strLfppaqRAqkWJjlkI), biSSxUJsDUYSLlux()[iMPqKoMqNJEWuMDQN]), strWWxobzXnyspokWOg), strTojewVEvreLEHQcq), jMizMKryLaMChgZDo), jXBJICFbUnERpKiOz), GTYCANLPfjhTGgjx(jSONobjectEbOEiALrEEZIcvAT, "FisError", null)));
    }
}

