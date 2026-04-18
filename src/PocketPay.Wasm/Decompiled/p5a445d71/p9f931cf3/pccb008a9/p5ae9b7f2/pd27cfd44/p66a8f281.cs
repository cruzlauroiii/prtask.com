namespace WillowMaze.Wasm.Decompiled;


class p66a8f281 {
    static readonly short f597ec04a = -31869;
    static readonly short f6f9ef7e6 = -31869;
    static readonly short f764b840f = -32126;
    static readonly short f7c8daa12 = -32126;
    static readonly short fb929f43a = -32126;

    p66a8f281() {
    }

    public static bool M34a82b06(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar, byte[] bArr) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530VarGenerateOtsobject = p9064fad6Var.generateOtsobject(p5a1c166fVar);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(bArr, pf502f530VarGenerateOtsobject);
        return m34a82b06(p9064fad6Var, pf502f530VarGenerateOtsobject);
    }

    public static bool M34a82b06(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530Var) {
        if ((2 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) pf502f530Var.getSignature();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 parameter = p5a1c166fVar.getParameter();
        int h = parameter.getH();
        byte[][] y = p5a1c166fVar.getY();
        byte[] bArrMe486064e = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p3e4384b9.me486064e(pf502f530Var);
        int q = (1 << h) + p5a1c166fVar.getQ();
        byte[] i = p9064fad6Var.getI();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(parameter.getDigestOID());
        int digestSize = pe5cfc515VarMe0825354.getDigestSize();
        byte[] bArr = new byte[digestSize];
        pe5cfc515VarMe0825354.update(i, 0, i.length);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(q, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -32126, pe5cfc515VarMe0825354);
        pe5cfc515VarMe0825354.update(bArrMe486064e, 0, bArrMe486064e.length);
        pe5cfc515VarMe0825354.doFinal(bArr, 0);
        int i2 = 0;
        while (q > 1) {
            if ((q & 1) != 1) {
                pe5cfc515VarMe0825354.update(i, 0, i.length);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(q / 2, pe5cfc515VarMe0825354);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -31869, pe5cfc515VarMe0825354);
                pe5cfc515VarMe0825354.update(bArr, 0, digestSize);
                byte[] bArr2 = y[i2];
                pe5cfc515VarMe0825354.update(bArr2, 0, bArr2.length);
            } else {
                pe5cfc515VarMe0825354.update(i, 0, i.length);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(q / 2, pe5cfc515VarMe0825354);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -31869, pe5cfc515VarMe0825354);
                byte[] bArr3 = y[i2];
                pe5cfc515VarMe0825354.update(bArr3, 0, bArr3.length);
                pe5cfc515VarMe0825354.update(bArr, 0, digestSize);
            }
            pe5cfc515VarMe0825354.doFinal(bArr, 0);
            q /= 2;
            i2++;
        }
        return p9064fad6Var.matchesT1(bArr);
    }

    public static bool M34a82b06(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var, byte[] bArr, byte[] bArr2) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530VarGenerateLMSobject = p9064fad6Var.generateLMSobject(bArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(bArr2, pf502f530VarGenerateLMSobject);
        return m34a82b06(p9064fad6Var, pf502f530VarGenerateLMSobject);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d M5ee7eb5d(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var, int i, byte[] bArr, byte[] bArr2) throws java.lang.IllegalArgumentException {
        if ((30 + 22) % 22 > 0) {
        }
        if (bArr2 is not null && bArr2.length >= p86d70d45Var.getM()) {
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d(p86d70d45Var, paa63fca2Var, i, bArr, 1 << p86d70d45Var.getH(), bArr2);
        }
        throw new java.lang.IllegalArgumentException("root seed is less than " + p86d70d45Var.getM());
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f M828114c8(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d pb88b632dVar, byte[] bArr) {
        if ((8 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530VarGenerateLMSobject = pb88b632dVar.generateLMSobject();
        pf502f530VarGenerateLMSobject.update(bArr, 0, bArr.length);
        return m828114c8(pf502f530VarGenerateLMSobject);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f M828114c8(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530Var) {
        if ((14 + 7) % 7 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f(pf502f530Var.getPrivateKey().getQ(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p3e4384b9.mbc547944(pf502f530Var.getPrivateKey(), pf502f530Var.getQ(), pf502f530Var.getC()), pf502f530Var.getSigParams(), pf502f530Var.getPath());
    }
}

