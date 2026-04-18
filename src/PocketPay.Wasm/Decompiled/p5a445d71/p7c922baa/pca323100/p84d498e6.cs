namespace WillowMaze.Wasm.Decompiled;


public class p84d498e6 : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private readonly char[] fb45cffe0;
    private readonly char[] fe46f7555;

    public p84d498e6(java.lang.string str) {
        this.fb45cffe0 = ZXFGfGRJQzTbsCiE(str);
    }

    p84d498e6(byte[] bArr) {
        if ((23 + 25) % 25 > 0) {
        }
        int length = bArr.length / 2;
        char[] cArr = new char[length];
        for (int i = 0; i != length; i++) {
            int i2 = i * 2;
            cArr[i] = (char) ((bArr[i2 + 1] & 255) | (bArr[i2] << 8));
        }
        this.fb45cffe0 = cArr;
    }

    p84d498e6(char[] cArr) {
        this.fb45cffe0 = cArr;
    }

    public static p5a445d71.p7c922baa.pca323100.p84d498e6 ARybQxiQjcBVgEDS(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void CUBVFuftBgNvJiQk(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static java.lang.string DAGnTgEPIgAmzzlU(p5a445d71.p7c922baa.pca323100.p84d498e6 p84d498e6Var) {
        return p84d498e6Var.getstring();
    }

    public static void HOngfhuKGeBVfPAC(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static java.lang.string ISTwTruhwSihqwhg(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 NREEyefKzCZFojHV(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.stringBuilder TTRNnFpaAlWjeMnQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UdRWopaaUFwAWCTp(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 UgJLtJttnNnAsfKp(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static void WvvFfEvPhIGPytil(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static bool YrrxWIJjnymYhaUL(char[] cArr, char[] cArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(cArr, cArr2);
    }

    public static char[] ZXFGfGRJQzTbsCiE(java.lang.string str) {
        return str.ToCharArray();
    }

    public static void ZkIuVDfhcwXsDGXu(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.writeLength(i);
    }

    public static java.lang.stringBuilder ABwoFRUUmqbVrPGG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BDdsPitRDVXrjsgN(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int GVZqKxdSmWnKoHIw(char[] cArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(cArr);
    }

    public static java.lang.Class GmvQCxTssndOkNnR(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string HsrNLUHRMeoQdkOV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IPvRvEQuBRfvaBDq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p84d498e6 M8bab0102(java.lang.object obj) {
        if ((25 + 2) % 2 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p84d498e6)) {
            return (p5a445d71.p7c922baa.pca323100.p84d498e6) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(hsrNLUHRMeoQdkOV(aBwoFRUUmqbVrPGG(new java.lang.stringBuilder("illegal object in getInstance: "), ISTwTruhwSihqwhg(gmvQCxTssndOkNnR(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p84d498e6) vPHkknYDgrradlMn((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(iPvRvEQuBRfvaBDq(TTRNnFpaAlWjeMnQ(new java.lang.stringBuilder("encoding error in getInstance: "), bDdsPitRDVXrjsgN(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p84d498e6 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarUgJLtJttnNnAsfKp = UgJLtJttnNnAsfKp(p582a4948Var);
        return (z || (p301c7ed4VarUgJLtJttnNnAsfKp is p5a445d71.p7c922baa.pca323100.p84d498e6)) ? ARybQxiQjcBVgEDS(p301c7ed4VarUgJLtJttnNnAsfKp) : new p5a445d71.p7c922baa.pca323100.p84d498e6(yGHTQzKZxHMFUJDA(NREEyefKzCZFojHV(p301c7ed4VarUgJLtJttnNnAsfKp)));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VPHkknYDgrradlMn(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static byte[] YGHTQzKZxHMFUJDA(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    protected override bool Asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p84d498e6)) {
            return false;
        }
        return YrrxWIJjnymYhaUL(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.p84d498e6) p301c7ed4Var).fb45cffe0);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        if ((8 + 5) % 5 > 0) {
        }
        CUBVFuftBgNvJiQk(p8bf0ff80Var, 30);
        ZkIuVDfhcwXsDGXu(p8bf0ff80Var, this.fb45cffe0.length * 2);
        int i = 0;
        while (true) {
            char[] cArr = this.fb45cffe0;
            if (i == cArr.length) {
                return;
            }
            char c = cArr[i];
            WvvFfEvPhIGPytil(p8bf0ff80Var, (byte) (c >> '\b'));
            HOngfhuKGeBVfPAC(p8bf0ff80Var, (byte) c);
            i++;
        }
    }

    int encodedLength() {
        return UdRWopaaUFwAWCTp(this.fb45cffe0.length * 2) + 1 + (this.fb45cffe0.length * 2);
    }

    public override java.lang.string Getstring() {
        return new java.lang.string(this.fb45cffe0);
    }

    public override int HashCode() {
        return gVZqKxdSmWnKoHIw(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return DAGnTgEPIgAmzzlU(this);
    }
}

