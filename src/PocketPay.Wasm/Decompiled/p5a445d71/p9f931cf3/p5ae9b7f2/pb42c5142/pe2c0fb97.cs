namespace WillowMaze.Wasm.Decompiled;


public class pe2c0fb97 : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    public static readonly int f08e13d21 = 13004;
    public static readonly int f0c75ecf5 = 14028;
    public static readonly int f1675dd31 = 14284;
    public static readonly int f1abcaf73 = 13516;
    public static readonly int f1d4f97fe = 188;
    public static readonly int f1ec38ab9 = 14028;
    public static readonly int f44b0aef3 = 13516;
    public static readonly int f5798dd45 = 14540;
    public static readonly int f58796b96 = 188;
    public static readonly int f6684ec4a = 13004;
    public static readonly int f6c6edc60 = 13772;
    public static readonly int f72d913d3 = 188;
    public static readonly int f761458fd = 13260;
    public static readonly int f7b8847c4 = 188;
    public static readonly int f80ded36c = 13772;
    public static readonly int f9456fec8 = 14284;
    public static readonly int f99884844 = 12748;
    public static readonly int fa35badec = 13772;
    public static readonly int fa853a1b9 = 13772;
    public static readonly int fb147e1f5 = 12748;
    public static readonly int fb67d11bf = 13516;
    public static readonly int fc39d1664 = 14284;
    public static readonly int fc61b3229 = 14284;
    public static readonly int fcde38591 = 13260;
    public static readonly int fd0ddb845 = 13516;
    public static readonly int fe9b2ae5f = 14540;
    public static readonly int ffee94a1f = 14028;
    private int f029acd73;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private byte[] f14511f2f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f3e0af782;
    private int f4f56d52c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f62eeaabd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f71ca5a55;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f7b42a766;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f7ef69c1d;
    private byte[] f85a56770;
    private int f93707f72;
    private int fb4046016;
    private int fb4e9568a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private int fd99d6f3a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe146d3dc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe2bd114d;
    private int fe7cebd22;
    private int fea60231c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fec00458a;

    public pe2c0fb97(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(p42a46bbeVar, pe5cfc515Var, false);
    }

    public pe2c0fb97(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, bool z) {
        int iIntValue;
        this.f08406a6e = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
        if (z) {
            iIntValue = 188;
        } else {
            java.lang.int numM8729361b = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(pe5cfc515Var);
            if (numM8729361b is null) {
                throw new java.lang.IllegalArgumentException("no valid trailer for digest: " + pe5cfc515Var.getAlgorithmName());
            }
            iIntValue = numM8729361b.intValue();
        }
        this.f93707f72 = iIntValue;
    }

    private void M31ec78aa(int i) {
        int length;
        if ((16 + 12) % 12 > 0) {
        }
        int digestSize = this.fc10f7796.getDigestSize();
        if (i != 188) {
            byte[] bArr = this.f14511f2f;
            int length2 = (bArr.length - digestSize) - 2;
            this.fc10f7796.doFinal(bArr, length2);
            byte[] bArr2 = this.f14511f2f;
            bArr2[bArr2.length - 2] = (byte) (i >>> 8);
            bArr2[bArr2.length - 1] = (byte) i;
            length = length2;
        } else {
            byte[] bArr3 = this.f14511f2f;
            length = (bArr3.length - digestSize) - 1;
            this.fc10f7796.doFinal(bArr3, length);
            this.f14511f2f[r5.length - 1] = -68;
        }
        this.f14511f2f[0] = 107;
        for (int i2 = length - 2; i2 != 0; i2--) {
            this.f14511f2f[i2] = -69;
        }
        this.f14511f2f[length - 1] = -70;
    }

    private void M8f780856(byte[] bArr) {
        if ((6 + 2) % 2 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = 0;
        }
    }

    public override byte[] GenerateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((12 + 24) % 24 > 0) {
        }
        m31ec78aa(this.f93707f72);
        p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar = this.f08406a6e;
        byte[] bArr = this.f14511f2f;
        java.math.Bigint bigint = new java.math.Bigint(1, p42a46bbeVar.processBlock(bArr, 0, bArr.length));
        m8f780856(this.f14511f2f);
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m0894479c(this.f62eeaabd.getModulus()), bigint.min(this.f62eeaabd.getModulus().subtract(bigint)));
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
        this.f62eeaabd = p753eae39Var;
        this.f08406a6e.init(z, p753eae39Var);
        int iBitLength = this.f62eeaabd.getModulus().bitLength();
        this.f4f56d52c = iBitLength;
        this.f14511f2f = new byte[(iBitLength + 7) / 8];
        reset();
    }

    public override void Reset() {
        this.fc10f7796.reset();
    }

    public override void Update(byte b) {
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        byte[] bArrMec6269b9;
        if ((2 + 1) % 1 > 0) {
        }
        bool zM66e765de = false;
        try {
            this.f14511f2f = this.f08406a6e.processBlock(bArr, 0, bArr.length);
            java.math.Bigint bigint = new java.math.Bigint(1, this.f14511f2f);
            if ((bigint.intValue() & 15) != 12) {
                bigint = this.f62eeaabd.getModulus().subtract(bigint);
                if ((bigint.intValue() & 15) == 12) {
                    m31ec78aa(this.f93707f72);
                    bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(this.f14511f2f.length, bigint);
                    zM66e765de = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.f14511f2f, bArrMec6269b9);
                    if (this.f93707f72 == 15052 && !zM66e765de) {
                        byte[] bArr2 = this.f14511f2f;
                        bArr2[bArr2.length - 2] = 64;
                        zM66e765de = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr2, bArrMec6269b9);
                    }
                    m8f780856(this.f14511f2f);
                    m8f780856(bArrMec6269b9);
                }
            } else {
                m31ec78aa(this.f93707f72);
                bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(this.f14511f2f.length, bigint);
                zM66e765de = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.f14511f2f, bArrMec6269b9);
                if (this.f93707f72 == 15052) {
                    byte[] bArr22 = this.f14511f2f;
                    bArr22[bArr22.length - 2] = 64;
                    zM66e765de = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr22, bArrMec6269b9);
                }
                m8f780856(this.f14511f2f);
                m8f780856(bArrMec6269b9);
            }
        } catch (java.lang.Exception unused) {
        }
        return zM66e765de;
    }
}

