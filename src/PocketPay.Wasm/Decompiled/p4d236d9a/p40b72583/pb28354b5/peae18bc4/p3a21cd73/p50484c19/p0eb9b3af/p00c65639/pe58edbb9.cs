namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u0000 \u000b2\u00020\u0001:\u0001\u000bJ\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0003H&J\u0018\u0010\u0007\u001a\u00020\u00032\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0003H&¨\u0006\f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p00c65639/pe58edbb9;", "", "encryptToJwe", "", "remotePublicKey", "Ljava/security/interfaces/RSAPublicKey;", "payload", "decryptFromJwe", "keyInfo", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;", "jwe", "Companion", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pe58edbb9 {
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p00c65639.pe58edbb9$p910eef8c f910eef8c = p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p00c65639.pe58edbb9$p910eef8c.$$INSTANCE;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p00c65639.pe58edbb9$p910eef8c fcf42d232 = null;

    @kotlin.jvm.JvmStatic
    static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p00c65639.pe58edbb9 M8bab0102(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p00c65639.p0e591676.p192d20a4 p192d20a4Var) {
        return f910eef8c.getInstance(p192d20a4Var);
    }

    java.lang.string decryptFromJwe(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo, java.lang.string jwe);

    java.lang.string encryptToJwe(java.security.interfaces.RSAPublicKey remotePublicKey, java.lang.string payload);
}

