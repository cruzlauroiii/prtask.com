namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\bf\u0018\u00002\u00020\u0001J\u0018\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u000fH&J \u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u000fH&J \u0010\u0017\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0012\u001a\u00020\u000fH&J\u0018\u0010\u0018\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0019\u001a\u00020\u000fH&J\u0018\u0010\u001a\u001a\u00020\u001b2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u001c\u001a\u00020\u001dH&J\u0010\u0010\u001e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H&J\u001a\u0010\u001f\u001a\u0004\u0018\u00010\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010 \u001a\u00020!H&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0012\u0010\u0006\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tR\u0012\u0010\n\u001a\u00020\u000bX¦\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\r¨\u0006\""}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/p0e591676/p15bc97bf;", "", "tophNetworkHashSettings", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/p07214c67/p1f3f6c41;", "getTophNetworkHashSettings", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/p07214c67/p1f3f6c41;", "gson", "Lcom/google/gson/Gson;", "getGson", "()Lcom/google/gson/Gson;", "hardwareFingerprint", "", "getHardwareFingerprint", "()[B", "encryptToJwe", "", "apiType", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p9efab239/p407482fe/p8a5da52e/p62c91bb3;", "payload", "decryptFromJwe", "keyType", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p9efab239/p407482fe/p8a5da52e/p82fb9ae9;", "jwe", "createJws", "parseJws", "response", "getAppNonce", "", "needUpdate", "", "getAuthorizationToken", "getSecurityChecksResult", "checksType", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p9efab239/p407482fe/pe91e6348/p9e5254cf;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p15bc97bf {
    java.lang.string createJws(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p82fb9ae9 keyType, java.lang.string payload);

    java.lang.string decryptFromJwe(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p82fb9ae9 keyType, java.lang.string jwe);

    java.lang.string encryptToJwe(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType, java.lang.string payload);

    long getAppNonce(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType, bool needUpdate);

    java.lang.string getAuthorizationToken(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType);

    com.google.gson.Gson getGson();

    byte[] getHardwareFingerprint();

    java.lang.string getSecurityChecksResult(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.pe91e6348.p9e5254cf checksType);

    p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.p07214c67.p1f3f6c41 getTophNetworkHashSettings();

    java.lang.string parseJws(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.p8a5da52e.p62c91bb3 apiType, java.lang.string response);
}

