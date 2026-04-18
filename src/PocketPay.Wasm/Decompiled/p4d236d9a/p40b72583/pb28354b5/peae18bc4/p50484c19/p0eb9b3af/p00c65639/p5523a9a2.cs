namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0012\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0019\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J \u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000bH\u0016J \u0010\u000f\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J \u0010\u0014\u001a\u00020\u000b2\u0006\u0010\u0015\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000bH\u0016J\u0018\u0010\u0016\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u0017\u001a\u00020\u0018H\u0016J(\u0010\u0019\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u001a\u001a\u00020\u000b2\u0006\u0010\u001b\u001a\u00020\u000bH\u0016R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p00c65639/p5523a9a2;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p00c65639/p0e591676/p192d20a4;", "gson", "Lcom/google/gson/Gson;", "tophCrypto", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5ae9b7f2/p97f30e5f;", "<init>", "(Lcom/google/gson/Gson;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p5ae9b7f2/p97f30e5f;)V", "getGson", "()Lcom/google/gson/Gson;", "decryptDataFromJwe", "", "encryptedText", "secretKey", "iv", "decryptKeyForJwe", "keyInfo", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/p5fba3d2b/p30582d95;", "algToCipher", "", "encryptDataForJwe", "inputbytes", "encryptKeyForJwe", "remotePublicKey", "Ljava/security/interfaces/RSAPublicKey;", "genHMac", "aad", "cipherText", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5523a9a2 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p00c65639.p0e591676.p192d20a4 {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f06385498;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f11db8d5f;
    private readonly com.google.gson.Gson f203a0758;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f3ba04cb7;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f3cd69739;
    private readonly com.google.gson.Gson f4bd31454;
    private readonly com.google.gson.Gson f53230a7c;
    private readonly com.google.gson.Gson f5cd40511;
    private readonly com.google.gson.Gson f67166080;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f f9c89a287;

    @javax.inject.Inject
    public p5523a9a2(com.google.gson.Gson gson, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar) {
        aCRlrNivvKiOnsem(gson, "gson");
        anofrozjELgtMhCy(p97f30e5fVar, "tophCrypto");
        this.f67166080 = gson;
        this.f06385498 = p97f30e5fVar;
    }

    public static void BRjFovVmZuSJeBIk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DnhynWHYUbXJdyan(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] MuanSOADlSBGPlil(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        return p97f30e5fVar.genHMac(bArr, bArr2, bArr3, bArr4);
    }

    public static byte[] QzpLQAQsEKCPEMMC(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, byte[] bArr, java.security.interfaces.RSAPublicKey rSAPublicKey) {
        return p97f30e5fVar.encryptKeyForJwe(bArr, rSAPublicKey);
    }

    public static void RyzxyvhdxNEsKRMg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SIlqwcbhUDfLRvZu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] TAVZXINprTzCeXoX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        return p97f30e5fVar.decryptDataFromJwe(bArr, bArr2, bArr3);
    }

    public static void USdKldeXGvHyqbLB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VNlCFjFuXHIluDPM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YJBTiRZQnqnesPwY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ACRlrNivvKiOnsem(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AnofrozjELgtMhCy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CAQJMqIbFiZmTlVr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DYLtrmLLaIVJGPov(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GSzYvJdwofJqwOYX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HRUVSRaHaBjXlYaD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IQcFyAKBxOkMlQDK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] KoAFLjGTAwBFZPIp(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        return p97f30e5fVar.encryptDataForJwe(bArr, bArr2, bArr3);
    }

    public static void QcLtdtZrHvgFHtVT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QlTADxBpAKCfFDUg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void USnUbPbaLHbJhehV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] YISdyLCQTNoVKuMe(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p5ae9b7f2.p97f30e5f p97f30e5fVar, byte[] bArr, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 p30582d95Var, java.lang.string str) {
        return p97f30e5fVar.decryptKeyForJwe(bArr, p30582d95Var, str);
    }

    public override byte[] DecryptDataFromJwe(byte[] encryptedText, byte[] secretKey, byte[] iv) {
        iQcFyAKBxOkMlQDK(encryptedText, "encryptedText");
        hRUVSRaHaBjXlYaD(secretKey, "secretKey");
        DnhynWHYUbXJdyan(iv, "iv");
        return TAVZXINprTzCeXoX(this.f06385498, encryptedText, secretKey, iv);
    }

    public override byte[] DecryptKeyForJwe(byte[] secretKey, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.p5fba3d2b.p30582d95 keyInfo, java.lang.string algToCipher) {
        SIlqwcbhUDfLRvZu(secretKey, "secretKey");
        dYLtrmLLaIVJGPov(keyInfo, "keyInfo");
        YJBTiRZQnqnesPwY(algToCipher, "algToCipher");
        return yISdyLCQTNoVKuMe(this.f06385498, secretKey, keyInfo, algToCipher);
    }

    public override byte[] EncryptDataForJwe(byte[] inputbytes, byte[] secretKey, byte[] iv) {
        cAQJMqIbFiZmTlVr(inputbytes, "inputbytes");
        qcLtdtZrHvgFHtVT(secretKey, "secretKey");
        BRjFovVmZuSJeBIk(iv, "iv");
        return koAFLjGTAwBFZPIp(this.f06385498, inputbytes, secretKey, iv);
    }

    public override byte[] EncryptKeyForJwe(byte[] secretKey, java.security.interfaces.RSAPublicKey remotePublicKey) {
        gSzYvJdwofJqwOYX(secretKey, "secretKey");
        uSnUbPbaLHbJhehV(remotePublicKey, "remotePublicKey");
        return QzpLQAQsEKCPEMMC(this.f06385498, secretKey, remotePublicKey);
    }

    public override byte[] GenHMac(byte[] secretKey, byte[] iv, byte[] aad, byte[] cipherText) {
        qlTADxBpAKCfFDUg(secretKey, "secretKey");
        RyzxyvhdxNEsKRMg(iv, "iv");
        VNlCFjFuXHIluDPM(aad, "aad");
        USdKldeXGvHyqbLB(cipherText, "cipherText");
        return MuanSOADlSBGPlil(this.f06385498, secretKey, iv, aad, cipherText);
    }

    public override com.google.gson.Gson GetGson() {
        return this.f67166080;
    }
}

