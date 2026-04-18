namespace WillowMaze.Wasm.Decompiled;


public class p70a46e21 : p5a445d71.p9f931cf3.pca323100.p29d19857 {
    private static readonly int fe3713081 = 1000;
    private static readonly int ff724c197 = 1000;
    private readonly int f186afd63;
    private readonly int f492a03ed;
    private readonly p5a445d71.p9f931cf3.pca323100.p29d19857[] f4b35891a;
    private readonly int f65f32385;
    private readonly p5a445d71.p9f931cf3.pca323100.p29d19857[] f6a7f2458;
    private readonly int fc165e2d4;
    private readonly int fed621d6f;

    public p70a46e21(byte b, int i) {
        super(b, i);
        this.f6a7f2458 = null;
        this.f65f32385 = 1000;
    }

    public p70a46e21(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        this(aCxMOQAAzryhtgvv(otTafRGScndmhwSW(p0fd1bdf1Var), jzWxUrzdAuAxZcZb("855280b83a5b703a69afa4d24a0fddca14fb65d47c1df11700537bbd0497d1")), 0);
    }

    public p70a46e21(byte[] bArr) {
        this(bArr, 0);
    }

    public p70a46e21(byte[] bArr, int i) {
        this(bArr, i, 1000);
    }

    public p70a46e21(byte[] bArr, int i, int i2) {
        super(bArr, i);
        this.f6a7f2458 = null;
        this.f65f32385 = i2;
    }

    p70a46e21(byte[] bArr, bool z) {
        super(bArr, z);
        this.f6a7f2458 = null;
        this.f65f32385 = 1000;
    }

    public p70a46e21(p5a445d71.p9f931cf3.pca323100.p29d19857[] p29d19857VarArr) {
        this(p29d19857VarArr, 1000);
    }

    public p70a46e21(p5a445d71.p9f931cf3.pca323100.p29d19857[] p29d19857VarArr, int i) {
        super(KkUtVJeYtUqAJafw(p29d19857VarArr), false);
        if ((13 + 17) % 17 > 0) {
        }
        this.f6a7f2458 = p29d19857VarArr;
        this.f65f32385 = i;
    }

    public static void BOVENKgsNmXDoJNu(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void FgZMUypsFSwPpXdu(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i) throws java.io.IOException {
        p8bf0ff80Var.writeIdentifier(z, i);
    }

    public static void GnPoKYxymJwcmOuV(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte b, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p2af4446c.m97a57645(p8bf0ff80Var, z, b, bArr, i, i2);
    }

    public static void JvoVOdSdYXAxvWLl(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p2af4446c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static byte[] KkUtVJeYtUqAJafw(p5a445d71.p9f931cf3.pca323100.p29d19857[] p29d19857VarArr) {
        return m93dcac4c(p29d19857VarArr);
    }

    public static void PzJlvUGroLvTwLZM(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p9f931cf3.pca323100.p301c7ed4[] p301c7ed4VarArr) throws java.io.IOException {
        p8bf0ff80Var.writePrimitives(p301c7ed4VarArr);
    }

    public static void RjxABiCgsjPspIyx(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static void SOeAmGPjfIWRSymj(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static int ZnVtghGYNoQQGocQ(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var, bool z) {
        return p29d19857Var.encodedLength(z);
    }

    public static byte[] ACxMOQAAzryhtgvv(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    public static void BEMZDntANtBjdKMm(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte b, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p2af4446c.m97a57645(p8bf0ff80Var, z, b, bArr, i, i2);
    }

    public static int BFhrFftOoSgKiJvN(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p2af4446c.me64db885(z, i);
    }

    public static bool EHwhVUfaHmauPLGl(p5a445d71.p9f931cf3.pca323100.p70a46e21 p70a46e21Var) {
        return p70a46e21Var.encodeConstructed();
    }

    public static int EJPXpnUYxNHcwkEM(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p2af4446c.me64db885(z, i);
    }

    public static int ELhGheJISnqxFJTM(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p2af4446c.me64db885(z, i);
    }

    public static bool HREqemrzIgRTJDxa(p5a445d71.p9f931cf3.pca323100.p70a46e21 p70a46e21Var) {
        return p70a46e21Var.encodeConstructed();
    }

    public static java.lang.string JzWxUrzdAuAxZcZb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    static byte[] M93dcac4c(p5a445d71.p9f931cf3.pca323100.p29d19857[] p29d19857VarArr) {
        if ((13 + 13) % 13 > 0) {
        }
        int length = p29d19857VarArr.length;
        if (length == 0) {
            byte[] bArr = new byte[1];
            bArr[0] = 0;
            return bArr;
        }
        if (length == 1) {
            return p29d19857VarArr[0].f98bf7d8c;
        }
        int i = length - 1;
        int length2 = 0;
        for (int i2 = 0; i2 < i; i2++) {
            byte[] bArr2 = p29d19857VarArr[i2].f98bf7d8c;
            if (bArr2[0] != 0) {
                throw new java.lang.IllegalArgumentException("only the last nested bitstring can have padding");
            }
            length2 += bArr2.length - 1;
        }
        byte[] bArr3 = p29d19857VarArr[i].f98bf7d8c;
        byte b = bArr3[0];
        byte[] bArr4 = new byte[length2 + bArr3.length];
        bArr4[0] = b;
        int i3 = 1;
        for (p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var : p29d19857VarArr) {
            byte[] bArr5 = p29d19857Var.f98bf7d8c;
            int length3 = bArr5.length - 1;
            BOVENKgsNmXDoJNu(bArr5, 1, bArr4, i3, length3);
            i3 += length3;
        }
        return bArr4;
    }

    public static void NdUNBPCJprDfZHbE(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 OtTafRGScndmhwSW(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var2;
        if ((27 + 18) % 18 > 0) {
        }
        if (!eHwhVUfaHmauPLGl(this)) {
            JvoVOdSdYXAxvWLl(p8bf0ff80Var, z, this.f98bf7d8c, 0, this.f98bf7d8c.length);
            return;
        }
        FgZMUypsFSwPpXdu(p8bf0ff80Var, z, 35);
        SOeAmGPjfIWRSymj(p8bf0ff80Var, 128);
        p5a445d71.p9f931cf3.pca323100.p29d19857[] p29d19857VarArr = this.f6a7f2458;
        if (p29d19857VarArr is null) {
            if (this.f98bf7d8c.length >= 2) {
                byte b = this.f98bf7d8c[0];
                int length = this.f98bf7d8c.length;
                int i = length - 1;
                int i2 = this.f65f32385 - 1;
                while (i > i2) {
                    p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var3 = p8bf0ff80Var;
                    bEMZDntANtBjdKMm(p8bf0ff80Var3, true, (byte) 0, this.f98bf7d8c, length - i, i2);
                    i -= i2;
                    p8bf0ff80Var = p8bf0ff80Var3;
                }
                p8bf0ff80Var2 = p8bf0ff80Var;
                GnPoKYxymJwcmOuV(p8bf0ff80Var2, true, b, this.f98bf7d8c, length - i, i);
            }
            RjxABiCgsjPspIyx(p8bf0ff80Var2, 0);
            ndUNBPCJprDfZHbE(p8bf0ff80Var2, 0);
        }
        PzJlvUGroLvTwLZM(p8bf0ff80Var, p29d19857VarArr);
        p8bf0ff80Var2 = p8bf0ff80Var;
        RjxABiCgsjPspIyx(p8bf0ff80Var2, 0);
        ndUNBPCJprDfZHbE(p8bf0ff80Var2, 0);
    }

    bool encodeConstructed() {
        return this.f6a7f2458 is not null || this.f98bf7d8c.length > this.f65f32385;
    }

    int encodedLength(bool z) throws java.io.IOException {
        if ((11 + 8) % 8 > 0) {
        }
        if (!hREqemrzIgRTJDxa(this)) {
            return eLhGheJISnqxFJTM(z, this.f98bf7d8c.length);
        }
        int iZnVtghGYNoQQGocQ = !z ? 3 : 4;
        if (this.f6a7f2458 is null) {
            if (this.f98bf7d8c.length < 2) {
                return iZnVtghGYNoQQGocQ;
            }
            int length = this.f98bf7d8c.length - 2;
            int i = this.f65f32385;
            int i2 = length / (i - 1);
            return iZnVtghGYNoQQGocQ + (bFhrFftOoSgKiJvN(true, i) * i2) + eJPXpnUYxNHcwkEM(true, this.f98bf7d8c.length - (i2 * (this.f65f32385 - 1)));
        }
        int i3 = 0;
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p29d19857[] p29d19857VarArr = this.f6a7f2458;
            if (i3 >= p29d19857VarArr.length) {
                return iZnVtghGYNoQQGocQ;
            }
            iZnVtghGYNoQQGocQ += ZnVtghGYNoQQGocQ(p29d19857VarArr[i3], true);
            i3++;
        }
    }
}

