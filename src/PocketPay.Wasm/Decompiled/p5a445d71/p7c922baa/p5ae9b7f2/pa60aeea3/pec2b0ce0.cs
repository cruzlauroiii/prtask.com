namespace WillowMaze.Wasm.Decompiled;


public class pec2b0ce0 : p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.p359a906c {
    protected bool f0fb5dee5;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 f4627e6ba;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 f6cf93eb7;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a f885be1e7;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 fa8ad9575;
    protected bool fb28837cf;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a fbd0c8e3b;
    protected bool fc7a9318f;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 fcd245b46;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fd8066e6b;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fd862da06;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fdb24acb7;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a fde12c5de;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fe0d30cef;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 fee1c7cf5;
    protected p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 ffaa13c6d;

    public pec2b0ce0(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        if (peb0f48a1Var is null) {
            throw new java.lang.IllegalArgumentException("'certificate' cannot be null");
        }
        if (CYkVtphgAwGGrDCt(peb0f48a1Var)) {
            throw new java.lang.IllegalArgumentException("'certificate' cannot be empty");
        }
        if (pcfffbc4aVar is null) {
            throw new java.lang.IllegalArgumentException("'privateKey' cannot be null");
        }
        if (!yUFPJnISLCuDWzrt(pcfffbc4aVar)) {
            throw new java.lang.IllegalArgumentException("'privateKey' must be private");
        }
        if (pcfffbc4aVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc9dc4fec) {
            this.fa8ad9575 = new p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p2aacdd87();
            this.fc7a9318f = true;
        } else {
            if (!(pcfffbc4aVar is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a)) {
                throw new java.lang.IllegalArgumentException(xrrzvKeQeYcePoJu(wzwMXamNCDndMRaY(new java.lang.stringBuilder("'privateKey' type not supported: "), rTLzXsnIkgvPnPyC(japQIAZSAxdGfriF(pcfffbc4aVar)))));
            }
            this.fa8ad9575 = new p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p844d4439();
            this.fc7a9318f = false;
        }
        this.fe0d30cef = peb0f48a1Var;
        this.fbd0c8e3b = pcfffbc4aVar;
    }

    public static void CYkVtphgAwGGrDCt(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYkVtphgAwGGrDCt(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYkVtphgAwGGrDCt(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool CYkVtphgAwGGrDCt(p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 peb0f48a1Var) {
        return peb0f48a1Var.Count == 0;
    }

    public static java.math.Bigint TQAbgqHASRnuIJmb(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        return p38d4f313Var.calculateAgreement(pc9ef6b45Var);
    }

    public static void TQAbgqHASRnuIJmb(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TQAbgqHASRnuIJmb(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQAbgqHASRnuIJmb(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlzntxrQaydiqkVn(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p38d4f313Var.init(pc9ef6b45Var);
    }

    public static void UlzntxrQaydiqkVn(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UlzntxrQaydiqkVn(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UlzntxrQaydiqkVn(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BpPTlbcikaimrZTV(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var) {
        return p38d4f313Var.getFieldSize();
    }

    public static void BpPTlbcikaimrZTV(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpPTlbcikaimrZTV(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpPTlbcikaimrZTV(p5a445d71.p7c922baa.p5ae9b7f2.p38d4f313 p38d4f313Var, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgYWYuJXrVRlawMg(int i, java.math.Bigint bigint, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FgYWYuJXrVRlawMg(int i, java.math.Bigint bigint, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FgYWYuJXrVRlawMg(int i, java.math.Bigint bigint, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] FgYWYuJXrVRlawMg(int i, java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.mec6269b9(i, bigint);
    }

    public static java.lang.Class JapQIAZSAxdGfriF(java.lang.object obj) {
        return obj.GetType();
    }

    public static void JapQIAZSAxdGfriF(java.lang.object obj, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JapQIAZSAxdGfriF(java.lang.object obj, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JapQIAZSAxdGfriF(java.lang.object obj, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtCEStadYJCGFwdM(java.math.Bigint bigint, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtCEStadYJCGFwdM(java.math.Bigint bigint, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtCEStadYJCGFwdM(java.math.Bigint bigint, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] KtCEStadYJCGFwdM(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.mec6269b9(bigint);
    }

    public static java.lang.string RTLzXsnIkgvPnPyC(java.lang.Class cls) {
        return cls.getName();
    }

    public static void RTLzXsnIkgvPnPyC(java.lang.Class cls, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTLzXsnIkgvPnPyC(java.lang.Class cls, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RTLzXsnIkgvPnPyC(java.lang.Class cls, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WzwMXamNCDndMRaY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WzwMXamNCDndMRaY(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WzwMXamNCDndMRaY(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WzwMXamNCDndMRaY(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XrrzvKeQeYcePoJu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XrrzvKeQeYcePoJu(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XrrzvKeQeYcePoJu(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XrrzvKeQeYcePoJu(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YUFPJnISLCuDWzrt(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YUFPJnISLCuDWzrt(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YUFPJnISLCuDWzrt(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YUFPJnISLCuDWzrt(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return pcfffbc4aVar.isPrivate();
    }

    public override byte[] GenerateAgreement(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        if ((32 + 28) % 28 > 0) {
        }
        UlzntxrQaydiqkVn(this.fa8ad9575, this.fbd0c8e3b);
        java.math.Bigint bigintTQAbgqHASRnuIJmb = TQAbgqHASRnuIJmb(this.fa8ad9575, pcfffbc4aVar);
        return !this.fc7a9318f ? fgYWYuJXrVRlawMg(bpPTlbcikaimrZTV(this.fa8ad9575), bigintTQAbgqHASRnuIJmb) : ktCEStadYJCGFwdM(bigintTQAbgqHASRnuIJmb);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.peb0f48a1 GetCertificate() {
        return this.fe0d30cef;
    }
}

