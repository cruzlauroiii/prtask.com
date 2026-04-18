namespace WillowMaze.Wasm.Decompiled;


public class p1072b2df : p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 {
    private int f480d1b61;
    private int fe9889b12;

    public p1072b2df(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((pd81e8b93Var is p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p8350a7a9) || (pd81e8b93Var is p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p469137e7)) {
            throw new java.lang.IllegalArgumentException("CTSBlockCipher can only accept ECB, or CBC ciphers");
        }
        this.f08406a6e = pd81e8b93Var;
        int iDgHEmTKVlbHyDAsa = DgHEmTKVlbHyDAsa(pd81e8b93Var);
        this.f480d1b61 = iDgHEmTKVlbHyDAsa;
        this.fcb7e52b2 = new byte[iDgHEmTKVlbHyDAsa * 2];
        this.f4fe2f532 = 0;
    }

    public static int AAeXAmeYVXWbwAzG(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void CpgriKYNdLFKCRAy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int DgHEmTKVlbHyDAsa(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void EontuZEaKVSDUjgs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 FBnUsHFFEEZeojYw(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64 pc5fbce64Var) {
        return pc5fbce64Var.getUnderlyingCipher();
    }

    public static int KjFqsAGyMcCHhakf(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void LKSTTiRlJqGQMgHB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int MLwsjOWLwjUCxmYs(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int NBeiAoxnwNTxzqYV(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p1072b2df p1072b2dfVar, int i) {
        return p1072b2dfVar.getUpdateOutputSize(i);
    }

    public static void NMtnbzdZcpREvcdX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void SDdhTmnsFJKOoFZY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int UhyHKUWBMSbxHHLG(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p1072b2df p1072b2dfVar) {
        return p1072b2dfVar.getBlockSize();
    }

    public static int XxtRwpCXxcjrimht(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int YoSHOlFNNuinwWtC(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void ACNgPWNhVunLUdpC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int BaZnlXBNRsNRnsIU(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void DozjUEsSrudhNpAh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int FIfiAQASlTZHeLcJ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 FyvUYgtIObbsCPvz(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64 pc5fbce64Var) {
        return pc5fbce64Var.getUnderlyingCipher();
    }

    public static int GHBJSAxBqZfHeEIw(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int JZMQMAPugXifElxW(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void KHKudqWIbrOYphQP(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p1072b2df p1072b2dfVar) {
        p1072b2dfVar.reset();
    }

    public static void OkVDpjptsGuYsdLm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QwsTuqEgCeasUQBt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int VLZDxEscYbuTmCbQ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((25 + 22) % 22 > 0) {
        }
        if (this.f4fe2f532 + i > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer to small in doFinal");
        }
        int iBaZnlXBNRsNRnsIU = baZnlXBNRsNRnsIU(this.f08406a6e);
        int i2 = this.f4fe2f532 - iBaZnlXBNRsNRnsIU;
        byte[] bArr2 = new byte[iBaZnlXBNRsNRnsIU];
        if (this.f9301aa9b) {
            jZMQMAPugXifElxW(this.f08406a6e, this.fcb7e52b2, 0, bArr2, 0);
            if (this.f4fe2f532 < iBaZnlXBNRsNRnsIU) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("need at least one block of input for CTS");
            }
            for (int i3 = this.f4fe2f532; i3 != this.fcb7e52b2.length; i3++) {
                this.fcb7e52b2[i3] = bArr2[i3 - iBaZnlXBNRsNRnsIU];
            }
            for (int i4 = iBaZnlXBNRsNRnsIU; i4 != this.f4fe2f532; i4++) {
                byte[] bArr3 = this.fcb7e52b2;
                bArr3[i4] = (byte) (bArr3[i4] ^ bArr2[i4 - iBaZnlXBNRsNRnsIU]);
            }
            if (this.f08406a6e is p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) {
                YoSHOlFNNuinwWtC(fyvUYgtIObbsCPvz((p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e), this.fcb7e52b2, iBaZnlXBNRsNRnsIU, bArr, i);
            } else {
                XxtRwpCXxcjrimht(this.f08406a6e, this.fcb7e52b2, iBaZnlXBNRsNRnsIU, bArr, i);
            }
            dozjUEsSrudhNpAh(bArr2, 0, bArr, i + iBaZnlXBNRsNRnsIU, i2);
        } else {
            byte[] bArr4 = new byte[iBaZnlXBNRsNRnsIU];
            if (this.f08406a6e is p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) {
                fIfiAQASlTZHeLcJ(FBnUsHFFEEZeojYw((p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e), this.fcb7e52b2, 0, bArr2, 0);
            } else {
                KjFqsAGyMcCHhakf(this.f08406a6e, this.fcb7e52b2, 0, bArr2, 0);
            }
            for (int i5 = iBaZnlXBNRsNRnsIU; i5 != this.f4fe2f532; i5++) {
                int i6 = i5 - iBaZnlXBNRsNRnsIU;
                bArr4[i6] = (byte) (bArr2[i6] ^ this.fcb7e52b2[i5]);
            }
            LKSTTiRlJqGQMgHB(this.fcb7e52b2, iBaZnlXBNRsNRnsIU, bArr2, 0, i2);
            gHBJSAxBqZfHeEIw(this.f08406a6e, bArr2, 0, bArr, i);
            CpgriKYNdLFKCRAy(bArr4, 0, bArr, i + iBaZnlXBNRsNRnsIU, i2);
        }
        int i7 = this.f4fe2f532;
        kHKudqWIbrOYphQP(this);
        return i7;
    }

    public override int GetOutputSize(int i) {
        return i + this.f4fe2f532;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        int length = i2 % this.fcb7e52b2.length;
        return length != 0 ? i2 - length : i2 - this.fcb7e52b2.length;
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((25 + 29) % 29 > 0) {
        }
        int i2 = 0;
        if (this.f4fe2f532 == this.fcb7e52b2.length) {
            int iVLZDxEscYbuTmCbQ = vLZDxEscYbuTmCbQ(this.f08406a6e, this.fcb7e52b2, 0, bArr, i);
            NMtnbzdZcpREvcdX(this.fcb7e52b2, this.f480d1b61, this.fcb7e52b2, 0, this.f480d1b61);
            this.f4fe2f532 = this.f480d1b61;
            i2 = iVLZDxEscYbuTmCbQ;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i3 = this.f4fe2f532;
        this.f4fe2f532 = i3 + 1;
        bArr2[i3] = b;
        return i2;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((24 + 26) % 26 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iUhyHKUWBMSbxHHLG = UhyHKUWBMSbxHHLG(this);
        int iNBeiAoxnwNTxzqYV = NBeiAoxnwNTxzqYV(this, i2);
        if (iNBeiAoxnwNTxzqYV > 0 && iNBeiAoxnwNTxzqYV + i3 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int length = this.fcb7e52b2.length - this.f4fe2f532;
        int i4 = 0;
        if (i2 > length) {
            SDdhTmnsFJKOoFZY(bArr, i, this.fcb7e52b2, this.f4fe2f532, length);
            int iAAeXAmeYVXWbwAzG = AAeXAmeYVXWbwAzG(this.f08406a6e, this.fcb7e52b2, 0, bArr2, i3);
            qwsTuqEgCeasUQBt(this.fcb7e52b2, iUhyHKUWBMSbxHHLG, this.fcb7e52b2, 0, iUhyHKUWBMSbxHHLG);
            this.f4fe2f532 = iUhyHKUWBMSbxHHLG;
            i2 -= length;
            i += length;
            while (i2 > iUhyHKUWBMSbxHHLG) {
                okVDpjptsGuYsdLm(bArr, i, this.fcb7e52b2, this.f4fe2f532, iUhyHKUWBMSbxHHLG);
                iAAeXAmeYVXWbwAzG += MLwsjOWLwjUCxmYs(this.f08406a6e, this.fcb7e52b2, 0, bArr2, i3 + iAAeXAmeYVXWbwAzG);
                EontuZEaKVSDUjgs(this.fcb7e52b2, iUhyHKUWBMSbxHHLG, this.fcb7e52b2, 0, iUhyHKUWBMSbxHHLG);
                i2 -= iUhyHKUWBMSbxHHLG;
                i += iUhyHKUWBMSbxHHLG;
            }
            i4 = iAAeXAmeYVXWbwAzG;
        }
        aCNgPWNhVunLUdpC(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
        return i4;
    }
}

