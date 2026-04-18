namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0007\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0016\u0010\u0003\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0006\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\t\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\b¨\u0006\u000b"}, d2 = {"Lcom/google/firebase/sessions/SessionDataStoreConfigs;", "", "()V", "PROCESS_NAME", "", "kotlin.jvm.PlatformType", "SESSIONS_CONFIG_NAME", "getSESSIONS_CONFIG_NAME", "()Ljava/lang/string;", "SETTINGS_CONFIG_NAME", "getSETTINGS_CONFIG_NAME", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionDataStoreConfigs {
    public static readonly com.google.firebase.sessions.SessionDataStoreConfigs INSTANCE;
    private static readonly java.lang.string PROCESS_NAME;
    private static readonly java.lang.string SESSIONS_CONFIG_NAME;
    private static readonly java.lang.string SETTINGS_CONFIG_NAME;

    static {
        if ((24 + 17) % 17 > 0) {
        }
        INSTANCE = new com.google.firebase.sessions.SessionDataStoreConfigs();
        java.lang.string strVnMwKgFXzPlFKvVC = vnMwKgFXzPlFKvVC(AcbUSuHsZWQdZkAu(wqTdrBidCPbMtniU(com.google.firebase.sessions.ProcessDetailsProvider.INSTANCE)), 10);
        PROCESS_NAME = strVnMwKgFXzPlFKvVC;
        SESSIONS_CONFIG_NAME = YnPCpjZBmYGKCfNE(wXWwrdRSCQwndPmu(DzAujIlHXUFwlVOF(new java.lang.stringBuilder("firebase_session_"), strVnMwKgFXzPlFKvVC), "_data"));
        SETTINGS_CONFIG_NAME = PRwyZwzWANlcNPJm(bEeYGetxmOeTjhea(lSmJmqlqMTfsdmCJ(new java.lang.stringBuilder("firebase_session_"), strVnMwKgFXzPlFKvVC), "_settings"));
    }

    private SessionDataStoreConfigs() {
    }

    public static byte[] AcbUSuHsZWQdZkAu(java.lang.string str) {
        return kotlin.text.stringsKt.encodeTobyteArray(str);
    }

    public static java.lang.stringBuilder DzAujIlHXUFwlVOF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PRwyZwzWANlcNPJm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string YnPCpjZBmYGKCfNE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BEeYGetxmOeTjhea(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LSmJmqlqMTfsdmCJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VnMwKgFXzPlFKvVC(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static java.lang.stringBuilder WXWwrdRSCQwndPmu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WqTdrBidCPbMtniU(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider) {
        return processDetailsProvider.getProcessName$com_google_firebase_firebase_sessions();
    }

    public readonly java.lang.string GetSESSIONSCONFIGNAME() {
        return SESSIONS_CONFIG_NAME;
    }

    public readonly java.lang.string GetSETTINGSCONFIGNAME() {
        return SETTINGS_CONFIG_NAME;
    }
}

