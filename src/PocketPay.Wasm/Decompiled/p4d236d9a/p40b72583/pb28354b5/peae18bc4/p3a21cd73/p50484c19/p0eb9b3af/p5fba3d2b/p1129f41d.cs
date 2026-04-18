namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\bf\u0018\u0000 \u00152\u00020\u0001:\u0001\u0015J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H&J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0004\u001a\u00020\u0005H&J\u001b\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e2\u0006\u0010\u0004\u001a\u00020\u0005H&¢\u0006\u0002\u0010\u0010J\b\u0010\u0011\u001a\u00020\u0003H&J\u0010\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0013H&¨\u0006\u0016"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5fba3d2b/p1129f41d;", "", "generateKeyValueTuple", "", "keyInfo", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;", "challenge", "", "deleteEntry", "getPrivateKey", "Ljava/security/PrivateKey;", "getOrGenerateSecretKey", "Ljavax/crypto/SecretKey;", "getKeyCertificateChain", "", "Ljava/security/cert/Certificate;", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;)[Ljava/security/cert/Certificate;", "clearStore", "checkStoreAuthentic", "", "value", "Companion", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p1129f41d {
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d$p910eef8c f30377539 = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d$p910eef8c f31e48712 = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d$p910eef8c f7bb8e456 = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d$p910eef8c f910eef8c = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d$p910eef8c.$$INSTANCE;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d$p910eef8c fee1b0f3f = null;

    @kotlin.jvm.JvmStatic
    static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d M8bab0102() {
        return f910eef8c.getInstance();
    }

    int checkStoreAuthentic(int value);

    void clearStore();

    void deleteEntry(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo);

    void generateKeyValueTuple(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo, byte[] challenge);

    java.security.cert.Certificate[] getKeyCertificateChain(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo);

    javax.crypto.SecretKey getOrGenerateSecretKey(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo);

    java.security.PrivateKey getPrivateKey(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo);
}

