namespace WillowMaze.Wasm.Decompiled;


public class p8d56a9ad : p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p28f93125 {
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df f15bc31c1;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 f1c3eaa73;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a f3c0cf87f;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 f5600d880;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 f5c18ef72;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a f896a9b22;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 f90ae7a2d;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df f9dee5ea8;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df fbcedb290;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a fbd0c8e3b;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fc3737e89;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fca7e7331;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 fdb56a74d;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fe0d30cef;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df feaff45fc;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 ffdbcc4db;

    public p8d56a9ad(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        this(pf1660074Var, peb0f48a1Var, pcfffbc4aVar, null);
    }

    public p8d56a9ad(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar) {
        if (peb0f48a1Var is null) {
            throw new java.lang.IllegalArgumentException("'certificate' cannot be null");
        }
        if (WnNPHlBEzbpFKlah(peb0f48a1Var)) {
            throw new java.lang.IllegalArgumentException("'certificate' cannot be empty");
        }
        if (pcfffbc4aVar is null) {
            throw new java.lang.IllegalArgumentException("'privateKey' cannot be null");
        }
        if (!xhxssOLJxjDnjldk(pcfffbc4aVar)) {
            throw new java.lang.IllegalArgumentException("'privateKey' must be private");
        }
        if (nRgGTbvRmPkWBXht(pf1660074Var) && p345a98dfVar is null) {
            throw new java.lang.IllegalArgumentException("'signatureAndHashAlgorithm' cannot be null for (D)TLS 1.2+");
        }
        if (pcfffbc4aVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) {
            this.fdb56a74d = new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p9e0ec8d8();
        } else if (pcfffbc4aVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pacb8a170) {
            this.fdb56a74d = new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p13d35e7f();
        } else {
            if (!(pcfffbc4aVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a)) {
                throw new java.lang.IllegalArgumentException(boUjMoqcceOtJymk(LhCfbnjSRhxpVCBM(new java.lang.stringBuilder("'privateKey' type not supported: "), FsqbfVUVIGQQPYdj(iIEOfYcMsysOLHLe(pcfffbc4aVar)))));
            }
            this.fdb56a74d = new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p7390d1de();
        }
        zGrGTWTSLpmJKJfT(this.fdb56a74d, pf1660074Var);
        this.f5c18ef72 = pf1660074Var;
        this.fe0d30cef = peb0f48a1Var;
        this.fbd0c8e3b = pcfffbc4aVar;
        this.f9dee5ea8 = p345a98dfVar;
    }

    public static java.lang.string FsqbfVUVIGQQPYdj(java.lang.Class cls) {
        return cls.getName();
    }

    public static void FsqbfVUVIGQQPYdj(java.lang.Class cls, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FsqbfVUVIGQQPYdj(java.lang.Class cls, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FsqbfVUVIGQQPYdj(java.lang.Class cls, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GxrFPlsRvYadrfUn(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxrFPlsRvYadrfUn(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GxrFPlsRvYadrfUn(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] GxrFPlsRvYadrfUn(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df p345a98dfVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr) {
        return pfb2a2a44Var.generateRawSignature(p345a98dfVar, pcfffbc4aVar, bArr);
    }

    public static java.lang.stringBuilder LhCfbnjSRhxpVCBM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LhCfbnjSRhxpVCBM(java.lang.stringBuilder sb, java.lang.string str, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LhCfbnjSRhxpVCBM(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhCfbnjSRhxpVCBM(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QAUKsWHwDtwsBiRd(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QAUKsWHwDtwsBiRd(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAUKsWHwDtwsBiRd(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QAUKsWHwDtwsBiRd(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf513157.m1ddffe61(pf1660074Var);
    }

    public static void WnNPHlBEzbpFKlah(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnNPHlBEzbpFKlah(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WnNPHlBEzbpFKlah(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WnNPHlBEzbpFKlah(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var) {
        return peb0f48a1Var.Count == 0;
    }

    public static java.lang.string BoUjMoqcceOtJymk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BoUjMoqcceOtJymk(java.lang.stringBuilder sb, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoUjMoqcceOtJymk(java.lang.stringBuilder sb, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BoUjMoqcceOtJymk(java.lang.stringBuilder sb, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class IIEOfYcMsysOLHLe(java.lang.object obj) {
        return obj.GetType();
    }

    public static void IIEOfYcMsysOLHLe(java.lang.object obj, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IIEOfYcMsysOLHLe(java.lang.object obj, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IIEOfYcMsysOLHLe(java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NRgGTbvRmPkWBXht(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRgGTbvRmPkWBXht(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRgGTbvRmPkWBXht(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NRgGTbvRmPkWBXht(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf513157.m1ddffe61(pf1660074Var);
    }

    public static void QqxfARtBBNmaiKDQ(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqxfARtBBNmaiKDQ(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QqxfARtBBNmaiKDQ(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] QqxfARtBBNmaiKDQ(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr) {
        return pfb2a2a44Var.generateRawSignature(pcfffbc4aVar, bArr);
    }

    public static void XhxssOLJxjDnjldk(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhxssOLJxjDnjldk(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhxssOLJxjDnjldk(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XhxssOLJxjDnjldk(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return pcfffbc4aVar.isPrivate();
    }

    public static void ZGrGTWTSLpmJKJfT(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var) {
        pfb2a2a44Var.init(pf1660074Var);
    }

    public static void ZGrGTWTSLpmJKJfT(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZGrGTWTSLpmJKJfT(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZGrGTWTSLpmJKJfT(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pfb2a2a44 pfb2a2a44Var, p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pf1660074 pf1660074Var, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override byte[] GenerateCertificateSignature(byte[] bArr) throws java.io.IOException {
        if ((17 + 16) % 16 > 0) {
        }
        try {
            return QAUKsWHwDtwsBiRd(this.f5c18ef72) ? GxrFPlsRvYadrfUn(this.fdb56a74d, this.f9dee5ea8, this.fbd0c8e3b, bArr) : qqxfARtBBNmaiKDQ(this.fdb56a74d, this.fbd0c8e3b, bArr);
        } catch (p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f e) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p997f2b16((short) 80, e);
        }
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 GetCertificate() {
        return this.fe0d30cef;
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p345a98df GetSignatureAndHashAlgorithm() {
        return this.f9dee5ea8;
    }
}

