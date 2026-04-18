namespace WillowMaze.Wasm.Decompiled;


public class paf405b9b : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private byte[] f72e945bf;
    private byte[] f829127b2;
    private byte[] facfeab79;
    private byte[] fb45cffe0;

    public paf405b9b(java.lang.string str) {
        this(eOzmSemClQDtgdkV(str));
    }

    public paf405b9b(byte[] bArr) {
        this.fb45cffe0 = bArr;
    }

    public static void BDJwLhiYqiWyLWKA(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 CRTXucnskSfbZFcY(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string CwtnVfxzPGndJmLL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string DTiuyidqJsAqtmNG(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int FCrmxfDIsLzLHEyl(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static byte[] FriauAcMZntoDqzy(p5a445d71.p7c922baa.pca323100.p0ac1b423 p0ac1b423Var) {
        return p0ac1b423Var.getOctets();
    }

    public static bool FvxCfJHtyrsbbADV(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] NHAwqPvjoDzQxuip(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 NdLdHhIcibItIpSr(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 TEgLKbXneAhWcmkK(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.string TOiEpCYdzwRKiBEA(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder UAlIoFzCQYlJbIpT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VjdYDAJVoWhIQIrA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.paf405b9b WNlFPmvRbAuKoRKR(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static byte[] XRcFpOuzieqOAMnB(p5a445d71.p7c922baa.pca323100.p0ac1b423 p0ac1b423Var) {
        return p0ac1b423Var.getOctets();
    }

    public static java.lang.string YQpjKiJemoMnOTMJ(p5a445d71.p7c922baa.pca323100.paf405b9b paf405b9bVar) {
        return paf405b9bVar.getstring();
    }

    public static int EAgQRmQYefjoRZJp(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static byte[] EOzmSemClQDtgdkV(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m48fbf2cf(str);
    }

    public static java.lang.Class LmTJgAoPRhEmGvlR(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.paf405b9b M8bab0102(java.lang.object obj) {
        if ((2 + 17) % 17 > 0) {
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p0ac1b423) {
            return new p5a445d71.p7c922baa.pca323100.paf405b9b(XRcFpOuzieqOAMnB((p5a445d71.p7c922baa.pca323100.p0ac1b423) obj));
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.paf405b9b)) {
            return (p5a445d71.p7c922baa.pca323100.paf405b9b) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(VjdYDAJVoWhIQIrA(UAlIoFzCQYlJbIpT(new java.lang.stringBuilder("illegal object in getInstance: "), TOiEpCYdzwRKiBEA(lmTJgAoPRhEmGvlR(obj)))));
        }
        try {
            return new p5a445d71.p7c922baa.pca323100.paf405b9b(FriauAcMZntoDqzy((p5a445d71.p7c922baa.pca323100.p0ac1b423) CRTXucnskSfbZFcY((byte[]) obj)));
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(CwtnVfxzPGndJmLL(wkOiYarzigxhDuAK(new java.lang.stringBuilder("encoding error in getInstance: "), DTiuyidqJsAqtmNG(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.paf405b9b M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarTEgLKbXneAhWcmkK = TEgLKbXneAhWcmkK(p582a4948Var);
        return (z || (p301c7ed4VarTEgLKbXneAhWcmkK is p5a445d71.p7c922baa.pca323100.p0ac1b423) || (p301c7ed4VarTEgLKbXneAhWcmkK is p5a445d71.p7c922baa.pca323100.paf405b9b)) ? WNlFPmvRbAuKoRKR(p301c7ed4VarTEgLKbXneAhWcmkK) : new p5a445d71.p7c922baa.pca323100.paf405b9b(NHAwqPvjoDzQxuip(NdLdHhIcibItIpSr(p301c7ed4VarTEgLKbXneAhWcmkK)));
    }

    public static byte[] OiPsJYlzojnUilUs(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string PkFyTnmsErqxkOsF(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m67d92862(bArr);
    }

    public static java.lang.stringBuilder WkOiYarzigxhDuAK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (p301c7ed4Var is p5a445d71.p7c922baa.pca323100.paf405b9b) {
            return FvxCfJHtyrsbbADV(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.paf405b9b) p301c7ed4Var).fb45cffe0);
        }
        return false;
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        BDJwLhiYqiWyLWKA(p8bf0ff80Var, 20, this.fb45cffe0);
    }

    int encodedLength() {
        return FCrmxfDIsLzLHEyl(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    public override byte[] GetOctets() {
        return oiPsJYlzojnUilUs(this.fb45cffe0);
    }

    public override java.lang.string Getstring() {
        return pkFyTnmsErqxkOsF(this.fb45cffe0);
    }

    public override int HashCode() {
        return eAgQRmQYefjoRZJp(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return YQpjKiJemoMnOTMJ(this);
    }
}

