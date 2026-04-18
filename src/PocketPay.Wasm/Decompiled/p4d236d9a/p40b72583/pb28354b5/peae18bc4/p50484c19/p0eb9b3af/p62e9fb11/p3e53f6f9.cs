namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B!\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u001b\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\r2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016¢\u0006\u0002\u0010\u0011J\u0018\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u000f\u001a\u00020\u0010H\u0016J \u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0018\u001a\u00020\u00132\u0006\u0010\u0019\u001a\u00020\u001aH\u0016R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p62e9fb11/p3e53f6f9;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p62e9fb11/p0e591676/pe17bbe42;", "gson", "Lcom/google/gson/Gson;", "tophCrypto", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5ae9b7f2/p97f30e5f;", "tophKeystore", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5fba3d2b/p1129f41d;", "<init>", "(Lcom/google/gson/Gson;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5ae9b7f2/p97f30e5f;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5fba3d2b/p1129f41d;)V", "getGson", "()Lcom/google/gson/Gson;", "getKeyCertificateChain", "", "Ljava/security/cert/Certificate;", "keyInfo", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;)[Ljava/security/cert/Certificate;", "getSignatureForJws", "", "data", "", "verifyJwsSignature", "", "signature", "remotePublicKey", "Ljava/security/interfaces/RSAPublicKey;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3e53f6f9 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p62e9fb11.p0e591676.pe17bbe42 {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f06385498;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f55725e99;
    private readonly com.google.gson.Gson f67166080;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d f7c707ee7;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d f801dc402;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d f91a24207;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d f9be77322;
    private readonly com.google.gson.Gson fa57c4ed2;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d fbc395a54;

    @javax.inject.Inject
    public p3e53f6f9(com.google.gson.Gson gson, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d p1129f41dVar) {
        vYvuSyqncWGwMITc(gson, "gson");
        vtAWscgvpwxouTJW(p97f30e5fVar, "tophCrypto");
        UZGDPdMpZrKgiqUu(p1129f41dVar, "tophKeystore");
        this.f67166080 = gson;
        this.f06385498 = p97f30e5fVar;
        this.f9be77322 = p1129f41dVar;
    }

    public static byte[] BhVxHxDplODGSOXX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 p30582d95Var) {
        return p97f30e5fVar.getSignatureForJws(str, p30582d95Var);
    }

    public static void DFkSKcoSfEvuFXZw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DeLrINpkuuNJdaPf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FKrwPbvxVxwEuUnN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.security.cert.Certificate[] FSdcrolPErMccYpC(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5fba3d2b.p1129f41d p1129f41dVar, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 p30582d95Var) {
        return p1129f41dVar.getKeyCertificateChain(p30582d95Var);
    }

    public static bool LgJPmEOIVvHmBoeS(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, java.lang.string str, byte[] bArr, java.security.interfaces.RSAPublicKey rSAPublicKey) {
        return p97f30e5fVar.verifyJwsSignature(str, bArr, rSAPublicKey);
    }

    public static void UZGDPdMpZrKgiqUu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LIrrZiRDQwSctuYh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SkYzrmqAPlwerAPA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VYvuSyqncWGwMITc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VtAWscgvpwxouTJW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WkTxMhOOaIUDPgzv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override com.google.gson.Gson GetGson() {
        return this.f67166080;
    }

    public override java.security.cert.Certificate[] GetKeyCertificateChain(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo) {
        DFkSKcoSfEvuFXZw(keyInfo, "keyInfo");
        return FSdcrolPErMccYpC(this.f9be77322, keyInfo);
    }

    public override byte[] GetSignatureForJws(java.lang.string data2, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo) {
        wkTxMhOOaIUDPgzv(data2, "data");
        skYzrmqAPlwerAPA(keyInfo, "keyInfo");
        return BhVxHxDplODGSOXX(this.f06385498, data2, keyInfo);
    }

    public override bool VerifyJwsSignature(java.lang.string data2, byte[] signature, java.security.interfaces.RSAPublicKey remotePublicKey) {
        DeLrINpkuuNJdaPf(data2, "data");
        FKrwPbvxVxwEuUnN(signature, "signature");
        lIrrZiRDQwSctuYh(remotePublicKey, "remotePublicKey");
        return LgJPmEOIVvHmBoeS(this.f06385498, data2, signature, remotePublicKey);
    }
}

