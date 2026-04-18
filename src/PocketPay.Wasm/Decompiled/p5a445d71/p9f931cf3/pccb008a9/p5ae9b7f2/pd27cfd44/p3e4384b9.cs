namespace WillowMaze.Wasm.Decompiled;


class p3e4384b9 {
    private static readonly int f00f38eec = 23;
    private static readonly int f02363ed3 = 23;
    private static readonly int f0fc5e965 = 22;
    static readonly int f0fe22f0d = 32;
    static readonly short f1f0962f5 = -32383;
    static readonly int f26d5056b = 32;
    private static readonly int f2a319453 = 23;
    private static readonly int f2a86c3ef = 20;
    private static readonly int f2b83d654 = 22;
    static readonly int f31e447c1 = 32;
    private static readonly int f32b7728e = 23;
    static readonly int f3400909b = -3;
    static readonly int f35bb98c9 = 32;
    private static readonly int f36aac45f = 20;
    static readonly int f52afe18a = 32;
    private static readonly int f5db08644 = 23;
    static readonly short f6b16e515 = -32383;
    static readonly int f6babc22f = 32;
    private static readonly short f9be8025a = -32640;
    static readonly short f9c1bfb4f = -32383;
    private static readonly short fa29490bd = -32640;
    static readonly int fad3e1af1 = 32;
    static readonly short fb6640b96 = -32383;
    static readonly int fc2a3a1ad = 32;
    static readonly int fc454c91a = -3;
    private static readonly int fcb2c627b = 20;
    private static readonly short fcfa59732 = -32640;
    static readonly int fcff73c3b = 32;
    static readonly short fdcccd6ae = -32383;
    static readonly int fe0269b3c = 32;
    private static readonly int fe7e3c29a = 22;
    static readonly int ff1bdbc01 = -3;
    static readonly int fff0641ad = -3;

    p3e4384b9() {
    }

    public static int M0fbf8164(byte[] bArr, int i, int i2) {
        if ((30 + 8) % 8 > 0) {
        }
        int i3 = (i * i2) / 8;
        int i4 = ((~i) & ((8 / i2) - 1)) * i2;
        return (bArr[i3] >>> i4) & ((1 << i2) - 1);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 M36faf070(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 p5b89b9c3Var) {
        if ((16 + 26) % 26 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851(p5b89b9c3Var.getParameter(), p5b89b9c3Var.getI(), p5b89b9c3Var.getQ(), m36faf070(p5b89b9c3Var.getParameter(), p5b89b9c3Var.getI(), p5b89b9c3Var.getQ(), p5b89b9c3Var.getMasterSecret()));
    }

    static byte[] M36faf070(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var, byte[] bArr, int i, byte[] bArr2) {
        if ((13 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(paa63fca2Var.getDigestOID());
        byte[] bArrBuild = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().bytes(bArr).u32str(i).u16str(-32640).padUntil(0, 22).build();
        pe5cfc515VarMe0825354.update(bArrBuild, 0, bArrBuild.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe08253542 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(paa63fca2Var.getDigestOID());
        byte[] bArrBuild2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().bytes(bArr).u32str(i).padUntil(0, pe5cfc515VarMe08253542.getDigestSize() + 23).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 pe1a02e85Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85(bArr, bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(paa63fca2Var.getDigestOID()));
        pe1a02e85Var.setQ(i);
        pe1a02e85Var.setJ(0);
        int p = paa63fca2Var.getP();
        int n = paa63fca2Var.getN();
        int w = (1 << paa63fca2Var.getW()) - 1;
        int i2 = 0;
        while (i2 < p) {
            pe1a02e85Var.deriveSeed(bArrBuild2, i2 < p + (-1), 23);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m7b247d76((short) i2, bArrBuild2, 20);
            for (int i3 = 0; i3 < w; i3++) {
                bArrBuild2[22] = (byte) i3;
                pe5cfc515VarMe08253542.update(bArrBuild2, 0, bArrBuild2.length);
                pe5cfc515VarMe08253542.doFinal(bArrBuild2, 23);
            }
            pe5cfc515VarMe0825354.update(bArrBuild2, 23, n);
            i2++;
        }
        byte[] bArr3 = new byte[pe5cfc515VarMe0825354.getDigestSize()];
        pe5cfc515VarMe0825354.doFinal(bArr3, 0);
        return bArr3;
    }

    public static int M64304d34(byte[] bArr, int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var) {
        if ((8 + 8) % 8 > 0) {
        }
        int w = (1 << paa63fca2Var.getW()) - 1;
        int iM0fbf8164 = 0;
        for (int i2 = 0; i2 < (i * 8) / paa63fca2Var.getW(); i2++) {
            iM0fbf8164 = (iM0fbf8164 + w) - m0fbf8164(bArr, i2, paa63fca2Var.getW());
        }
        return iM0fbf8164 << paa63fca2Var.getLs();
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 Mbc547944(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 p5b89b9c3Var, byte[] bArr, byte[] bArr2) {
        if ((10 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 parameter = p5b89b9c3Var.getParameter();
        int n = parameter.getN();
        int p = parameter.getP();
        int w = parameter.getW();
        byte[] bArr3 = new byte[p * n];
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(parameter.getDigestOID());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 derivationFunction = p5b89b9c3Var.getDerivationFunction();
        int iM64304d34 = m64304d34(bArr, n, parameter);
        bArr[n] = (byte) ((iM64304d34 >>> 8) & 255);
        bArr[n + 1] = (byte) iM64304d34;
        int i = n + 23;
        byte[] bArrBuild = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().bytes(p5b89b9c3Var.getI()).u32str(p5b89b9c3Var.getQ()).padUntil(0, i).build();
        derivationFunction.setJ(0);
        int i2 = 0;
        while (i2 < p) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m7b247d76((short) i2, bArrBuild, 20);
            derivationFunction.deriveSeed(bArrBuild, i2 < p + (-1), 23);
            int iM0fbf8164 = m0fbf8164(bArr, i2, w);
            for (int i3 = 0; i3 < iM0fbf8164; i3++) {
                bArrBuild[22] = (byte) i3;
                pe5cfc515VarMe0825354.update(bArrBuild, 0, i);
                pe5cfc515VarMe0825354.doFinal(bArrBuild, 23);
            }
            java.lang.System.arraycopy(bArrBuild, 23, bArr3, n * i2, n);
            i2++;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129(parameter, bArr2, bArr3);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 Mbc547944(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 p5b89b9c3Var, byte[][] bArr, byte[] bArr2, bool z) {
        byte[] c;
        if ((6 + 29) % 29 > 0) {
        }
        byte[] q = new byte[34];
        if (z) {
            c = new byte[32];
            java.lang.System.arraycopy(bArr2, 0, q, 0, p5b89b9c3Var.getParameter().getN());
        } else {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 signatureobject = p5b89b9c3Var.getSignatureobject(p86d70d45Var, bArr);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(bArr2, 0, bArr2.length, signatureobject);
            c = signatureobject.getC();
            q = signatureobject.getQ();
        }
        return mbc547944(p5b89b9c3Var, q, c);
    }

    public static bool Mbfa4108a(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 p1f46f851Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var, byte[] bArr, bool z) throws p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1ac14b98 {
        if (p56cbf129Var.getType().Equals(p1f46f851Var.getParameter())) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(me486064e(p1f46f851Var, p56cbf129Var, bArr), p1f46f851Var.getK());
        }
        throw new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1ac14b98("public key and signature ots types do not match");
    }

    public static byte[] Me486064e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 p1f46f851Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 p56cbf129Var, byte[] bArr) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530VarCreateOtsobject = p1f46f851Var.createOtsobject(p56cbf129Var);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(bArr, pf502f530VarCreateOtsobject);
        return me486064e(pf502f530VarCreateOtsobject);
    }

    public static byte[] Me486064e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 pf502f530Var) {
        if ((3 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 publicKey = pf502f530Var.getPublicKey();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 parameter = publicKey.getParameter();
        java.lang.object signature = pf502f530Var.getSignature();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129 otsSignature = !(signature is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) ? (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p56cbf129) signature : ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f) signature).getOtsSignature();
        int n = parameter.getN();
        int w = parameter.getW();
        int p = parameter.getP();
        byte[] q = pf502f530Var.getQ();
        int iM64304d34 = m64304d34(q, n, parameter);
        q[n] = (byte) ((iM64304d34 >>> 8) & 255);
        q[n + 1] = (byte) iM64304d34;
        byte[] i = publicKey.getI();
        int q2 = publicKey.getQ();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(parameter.getDigestOID());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(i, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(q2, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -32640, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a pbcba235aVarU32str = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().bytes(i).u32str(q2);
        int i2 = n + 23;
        byte[] bArrBuild = pbcba235aVarU32str.padUntil(0, i2).build();
        int i3 = (1 << w) - 1;
        byte[] y = otsSignature.getY();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe08253542 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(parameter.getDigestOID());
        for (int i4 = 0; i4 < p; i4++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m7b247d76((short) i4, bArrBuild, 20);
            java.lang.System.arraycopy(y, i4 * n, bArrBuild, 23, n);
            for (int iM0fbf8164 = m0fbf8164(q, i4, w); iM0fbf8164 < i3; iM0fbf8164++) {
                bArrBuild[22] = (byte) iM0fbf8164;
                pe5cfc515VarMe08253542.update(bArrBuild, 0, i2);
                pe5cfc515VarMe08253542.doFinal(bArrBuild, 23);
            }
            pe5cfc515VarMe0825354.update(bArrBuild, 23, n);
        }
        byte[] bArr = new byte[n];
        pe5cfc515VarMe0825354.doFinal(bArr, 0);
        return bArr;
    }
}

