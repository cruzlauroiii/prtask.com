namespace WillowMaze.Wasm.Decompiled;


public class p0ac1b423 : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private byte[] f1af6c1ca;
    private byte[] fb45cffe0;
    private byte[] fc01571eb;

    public p0ac1b423(java.lang.string str) {
        this.fb45cffe0 = wFBZOjddyFPkQxzT(str);
    }

    public p0ac1b423(byte[] bArr) {
        this.fb45cffe0 = cOXnUdIhTOGHsYUA(bArr);
    }

    public static java.lang.string MBGUBSGhyDaIOzmM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PJhvlyJTmIFqsEdq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PYRPPzkBPqmIwBGI(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static bool QLiknQJCkkUmgRBE(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.pca323100.p0ac1b423 RcLEIZRHLNoyNcVd(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string UmUleAxiEkdUUzWO(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 WoZcrnwuCIdDnAaN(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 XyaFOlNLzczktoEu(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static byte[] BSgcGaOxTKNzSuyt(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.Class BxBpgeYmEXIhEPdB(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte[] COXnUdIhTOGHsYUA(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string CbBJRgELQpQrmDEd(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string DQxqgcJuLVCAvrzZ(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int FfRIsZSCFdYYxqcs(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 JfcsTTWXFCeTZeyB(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.stringBuilder KyHpqCATnGpeWrYW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LcWQNQELsFQhBdfl(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0ac1b423 M8bab0102(java.lang.object obj) {
        if ((5 + 25) % 25 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p0ac1b423)) {
            return (p5a445d71.p7c922baa.pca323100.p0ac1b423) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(MBGUBSGhyDaIOzmM(kyHpqCATnGpeWrYW(new java.lang.stringBuilder("illegal object in getInstance: "), cbBJRgELQpQrmDEd(bxBpgeYmEXIhEPdB(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p0ac1b423) jfcsTTWXFCeTZeyB((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(qtDEEqYvVsZNtvte(PJhvlyJTmIFqsEdq(new java.lang.stringBuilder("encoding error in getInstance: "), dQxqgcJuLVCAvrzZ(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p0ac1b423 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarXyaFOlNLzczktoEu = XyaFOlNLzczktoEu(p582a4948Var);
        return (z || (p301c7ed4VarXyaFOlNLzczktoEu is p5a445d71.p7c922baa.pca323100.p0ac1b423)) ? RcLEIZRHLNoyNcVd(p301c7ed4VarXyaFOlNLzczktoEu) : new p5a445d71.p7c922baa.pca323100.p0ac1b423(zieKQhPTCVAqPWzR(WoZcrnwuCIdDnAaN(p301c7ed4VarXyaFOlNLzczktoEu)));
    }

    public static java.lang.string QtDEEqYvVsZNtvte(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SYTSGKMUbCYdSsvT(p5a445d71.p7c922baa.pca323100.p0ac1b423 p0ac1b423Var) {
        return p0ac1b423Var.getstring();
    }

    public static byte[] WFBZOjddyFPkQxzT(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static byte[] ZieKQhPTCVAqPWzR(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p0ac1b423) {
            return QLiknQJCkkUmgRBE(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.p0ac1b423) p301c7ed4Var).fb45cffe0);
        }
        return false;
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        PYRPPzkBPqmIwBGI(p8bf0ff80Var, 20, this.fb45cffe0);
    }

    int encodedLength() {
        return ffRIsZSCFdYYxqcs(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    public override byte[] GetOctets() {
        return bSgcGaOxTKNzSuyt(this.fb45cffe0);
    }

    public override java.lang.string Getstring() {
        return UmUleAxiEkdUUzWO(this.fb45cffe0);
    }

    public override int HashCode() {
        return lcWQNQELsFQhBdfl(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return sYTSGKMUbCYdSsvT(this);
    }
}

