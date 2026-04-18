namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\u001b\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\u0006\u0010\u0005\u001a\u00020\u0006H&¢\u0006\u0002\u0010\u0007J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0005\u001a\u00020\u0006H&J \u0010\f\u001a\u00020\r2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H&R\u0012\u0010\u0011\u001a\u00020\u0012X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014¨\u0006\u0015"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p62e9fb11/p0e591676/pe17bbe42;", "", "getKeyCertificateChain", "", "Ljava/security/cert/Certificate;", "keyInfo", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;)[Ljava/security/cert/Certificate;", "getSignatureForJws", "", "data", "", "verifyJwsSignature", "", "signature", "remotePublicKey", "Ljava/security/interfaces/RSAPublicKey;", "gson", "Lcom/google/gson/Gson;", "getGson", "()Lcom/google/gson/Gson;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pe17bbe42 {
    com.google.gson.Gson getGson();

    java.security.cert.Certificate[] getKeyCertificateChain(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo);

    byte[] getSignatureForJws(java.lang.string data2, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo);

    bool verifyJwsSignature(java.lang.string data2, byte[] signature, java.security.interfaces.RSAPublicKey remotePublicKey);
}

