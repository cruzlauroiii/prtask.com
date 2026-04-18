namespace WillowMaze.Wasm.Decompiled;


public class p37d1254e : p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 {
    private int f480d1b61;
    private int f88013412;
    private int fb649fc46;

    public p37d1254e(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if (pd81e8b93Var is p5a445d71.p7c922baa.p5ae9b7f2.pe3d43295) {
            throw new java.lang.IllegalArgumentException("CTSBlockCipher can only accept ECB, or CBC ciphers");
        }
        this.f08406a6e = pd81e8b93Var;
        int iJfIflQatULLXlWhE = jfIflQatULLXlWhE(pd81e8b93Var);
        this.f480d1b61 = iJfIflQatULLXlWhE;
        this.fcb7e52b2 = new byte[iJfIflQatULLXlWhE * 2];
        this.f4fe2f532 = 0;
    }

    public static void DKcsTgqDTrKavAEU(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p37d1254e p37d1254eVar) {
        p37d1254eVar.reset();
    }

    public static void EIhocrmjRCPbILKD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int EqZFULuAUemealjp(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int FmsyWyQxtmoOnrAg(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p37d1254e p37d1254eVar, int i) {
        return p37d1254eVar.getUpdateOutputSize(i);
    }

    public static int GNDtwqUNXgwfZBra(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void HIRYuYJQNXYurkfx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void IaTqKGyfCQbpYkWn(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void JyHxHIxTJlYHpnEo(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KTtMrLMhKEwVrZbY(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int KbcKZJvJvQqzVnmL(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p37d1254e p37d1254eVar) {
        return p37d1254eVar.getBlockSize();
    }

    public static void SUBzvWyBVgVJWFlO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AhwMXADduOWGJOYe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int CsbuoszYdaSAuTve(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void EjxVObAqmislMdcp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 HVQlqcBOgKbeytao(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64 pc5fbce64Var) {
        return pc5fbce64Var.getUnderlyingCipher();
    }

    public static int JfIflQatULLXlWhE(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int LfbdMnpyeCHBFtav(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void MuFWNWzHWLGBnWLB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int NOvkruCXiYcwmTsj(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int NiqyaalAlxYDoRav(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int NmhFzvfZIvqSbnIq(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 QZNuSYqdWeCmLvOc(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64 pc5fbce64Var) {
        return pc5fbce64Var.getUnderlyingCipher();
    }

    public static int QcDsRMqgTTZNewBv(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int QzlDQQfgThAXGUnt(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int RdpTXYlodAwOwNQs(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void TcSJuCMVTIHwhcrU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void VrJusIxqyTgLcCMN(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void YGPzGXScQggNWxzA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((19 + 4) % 4 > 0) {
        }
        if (this.f4fe2f532 + i > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer to small in doFinal");
        }
        int iCsbuoszYdaSAuTve = csbuoszYdaSAuTve(this.f08406a6e);
        int i2 = this.f4fe2f532 - iCsbuoszYdaSAuTve;
        byte[] bArr2 = new byte[iCsbuoszYdaSAuTve];
        if (this.f9301aa9b) {
            if (this.f4fe2f532 < iCsbuoszYdaSAuTve) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("need at least one block of input for CTS");
            }
            KTtMrLMhKEwVrZbY(this.f08406a6e, this.fcb7e52b2, 0, bArr2, 0);
            if (this.f4fe2f532 <= iCsbuoszYdaSAuTve) {
                JyHxHIxTJlYHpnEo(bArr2, 0, bArr, i, iCsbuoszYdaSAuTve);
            } else {
                for (int i3 = this.f4fe2f532; i3 != this.fcb7e52b2.length; i3++) {
                    this.fcb7e52b2[i3] = bArr2[i3 - iCsbuoszYdaSAuTve];
                }
                for (int i4 = iCsbuoszYdaSAuTve; i4 != this.f4fe2f532; i4++) {
                    byte[] bArr3 = this.fcb7e52b2;
                    bArr3[i4] = (byte) (bArr3[i4] ^ bArr2[i4 - iCsbuoszYdaSAuTve]);
                }
                if (this.f08406a6e is p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) {
                    GNDtwqUNXgwfZBra(hVQlqcBOgKbeytao((p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e), this.fcb7e52b2, iCsbuoszYdaSAuTve, bArr, i);
                } else {
                    nmhFzvfZIvqSbnIq(this.f08406a6e, this.fcb7e52b2, iCsbuoszYdaSAuTve, bArr, i);
                }
                EIhocrmjRCPbILKD(bArr2, 0, bArr, i + iCsbuoszYdaSAuTve, i2);
            }
        } else {
            if (this.f4fe2f532 < iCsbuoszYdaSAuTve) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("need at least one block of input for CTS");
            }
            byte[] bArr4 = new byte[iCsbuoszYdaSAuTve];
            if (this.f4fe2f532 <= iCsbuoszYdaSAuTve) {
                qcDsRMqgTTZNewBv(this.f08406a6e, this.fcb7e52b2, 0, bArr2, 0);
                IaTqKGyfCQbpYkWn(bArr2, 0, bArr, i, iCsbuoszYdaSAuTve);
            } else {
                if (this.f08406a6e is p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) {
                    rdpTXYlodAwOwNQs(qZNuSYqdWeCmLvOc((p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e), this.fcb7e52b2, 0, bArr2, 0);
                } else {
                    qzlDQQfgThAXGUnt(this.f08406a6e, this.fcb7e52b2, 0, bArr2, 0);
                }
                for (int i5 = iCsbuoszYdaSAuTve; i5 != this.f4fe2f532; i5++) {
                    int i6 = i5 - iCsbuoszYdaSAuTve;
                    bArr4[i6] = (byte) (bArr2[i6] ^ this.fcb7e52b2[i5]);
                }
                yGPzGXScQggNWxzA(this.fcb7e52b2, iCsbuoszYdaSAuTve, bArr2, 0, i2);
                nOvkruCXiYcwmTsj(this.f08406a6e, bArr2, 0, bArr, i);
                ahwMXADduOWGJOYe(bArr4, 0, bArr, i + iCsbuoszYdaSAuTve, i2);
            }
        }
        int i7 = this.f4fe2f532;
        DKcsTgqDTrKavAEU(this);
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
        if ((14 + 21) % 21 > 0) {
        }
        int i2 = 0;
        if (this.f4fe2f532 == this.fcb7e52b2.length) {
            int iEqZFULuAUemealjp = EqZFULuAUemealjp(this.f08406a6e, this.fcb7e52b2, 0, bArr, i);
            ejxVObAqmislMdcp(this.fcb7e52b2, this.f480d1b61, this.fcb7e52b2, 0, this.f480d1b61);
            this.f4fe2f532 = this.f480d1b61;
            i2 = iEqZFULuAUemealjp;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i3 = this.f4fe2f532;
        this.f4fe2f532 = i3 + 1;
        bArr2[i3] = b;
        return i2;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((17 + 5) % 5 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iKbcKZJvJvQqzVnmL = KbcKZJvJvQqzVnmL(this);
        int iFmsyWyQxtmoOnrAg = FmsyWyQxtmoOnrAg(this, i2);
        if (iFmsyWyQxtmoOnrAg > 0 && iFmsyWyQxtmoOnrAg + i3 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int length = this.fcb7e52b2.length - this.f4fe2f532;
        int i4 = 0;
        if (i2 > length) {
            HIRYuYJQNXYurkfx(bArr, i, this.fcb7e52b2, this.f4fe2f532, length);
            int iNiqyaalAlxYDoRav = niqyaalAlxYDoRav(this.f08406a6e, this.fcb7e52b2, 0, bArr2, i3);
            SUBzvWyBVgVJWFlO(this.fcb7e52b2, iKbcKZJvJvQqzVnmL, this.fcb7e52b2, 0, iKbcKZJvJvQqzVnmL);
            this.f4fe2f532 = iKbcKZJvJvQqzVnmL;
            i2 -= length;
            i += length;
            while (i2 > iKbcKZJvJvQqzVnmL) {
                tcSJuCMVTIHwhcrU(bArr, i, this.fcb7e52b2, this.f4fe2f532, iKbcKZJvJvQqzVnmL);
                iNiqyaalAlxYDoRav += lfbdMnpyeCHBFtav(this.f08406a6e, this.fcb7e52b2, 0, bArr2, i3 + iNiqyaalAlxYDoRav);
                vrJusIxqyTgLcCMN(this.fcb7e52b2, iKbcKZJvJvQqzVnmL, this.fcb7e52b2, 0, iKbcKZJvJvQqzVnmL);
                i2 -= iKbcKZJvJvQqzVnmL;
                i += iKbcKZJvJvQqzVnmL;
            }
            i4 = iNiqyaalAlxYDoRav;
        }
        muFWNWzHWLGBnWLB(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
        return i4;
    }
}

