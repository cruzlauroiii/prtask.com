namespace WillowMaze.Wasm.Decompiled;


public class peb73fe32 : p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 {
    public peb73fe32(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = pd81e8b93Var;
        this.fcb7e52b2 = new byte[FEPpWbODEhJQrfZN(pd81e8b93Var)];
        this.f4fe2f532 = 0;
    }

    public static int FEPpWbODEhJQrfZN(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int KSwiUPUsXarVHIfv(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int OXcxiMCgQyUrszLx(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.peb73fe32 peb73fe32Var, int i) {
        return peb73fe32Var.getUpdateOutputSize(i);
    }

    public static void IRCXapXscTyuOYZY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int JUjMsoscxpIrpZPu(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void MOhInOLQvcnPhqHv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QTwaMFTtcYJKBltL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int QhNUCPQKDNuKEFJk(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int VePxHlMcqfdGIqQA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void VvhTcuRmQRtIfkAL(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.peb73fe32 peb73fe32Var) {
        peb73fe32Var.reset();
    }

    public static int XGHPdzlZZHVFXQha(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.peb73fe32 peb73fe32Var) {
        return peb73fe32Var.getBlockSize();
    }

    public static int XrvogGDzOnJcbSSD(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int YeXlzQbEHhzCVlDA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int ZRAwTqbZhIYMUMGA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        int iKSwiUPUsXarVHIfv;
        int iXrvogGDzOnJcbSSD;
        if ((29 + 19) % 19 > 0) {
        }
        int iVePxHlMcqfdGIqQA = vePxHlMcqfdGIqQA(this.f08406a6e);
        if (this.f9301aa9b) {
            if (this.f4fe2f532 != iVePxHlMcqfdGIqQA) {
                iKSwiUPUsXarVHIfv = 0;
            } else {
                if ((iVePxHlMcqfdGIqQA * 2) + i > bArr.length) {
                    throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
                }
                iKSwiUPUsXarVHIfv = KSwiUPUsXarVHIfv(this.f08406a6e, this.fcb7e52b2, 0, bArr, i);
                this.f4fe2f532 = 0;
            }
            byte b = (byte) (iVePxHlMcqfdGIqQA - this.f4fe2f532);
            while (this.f4fe2f532 < iVePxHlMcqfdGIqQA) {
                this.fcb7e52b2[this.f4fe2f532] = b;
                this.f4fe2f532++;
            }
            iXrvogGDzOnJcbSSD = iKSwiUPUsXarVHIfv + xrvogGDzOnJcbSSD(this.f08406a6e, this.fcb7e52b2, 0, bArr, i + iKSwiUPUsXarVHIfv);
        } else {
            if (this.f4fe2f532 != iVePxHlMcqfdGIqQA) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("last block incomplete in decryption");
            }
            int iJUjMsoscxpIrpZPu = jUjMsoscxpIrpZPu(this.f08406a6e, this.fcb7e52b2, 0, this.fcb7e52b2, 0);
            this.f4fe2f532 = 0;
            int i2 = this.fcb7e52b2[iVePxHlMcqfdGIqQA - 1] & 255;
            if (i2 < 0 || i2 > iVePxHlMcqfdGIqQA) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("pad block corrupted");
            }
            iXrvogGDzOnJcbSSD = iJUjMsoscxpIrpZPu - i2;
            mOhInOLQvcnPhqHv(this.fcb7e52b2, 0, bArr, i, iXrvogGDzOnJcbSSD);
        }
        vvhTcuRmQRtIfkAL(this);
        return iXrvogGDzOnJcbSSD;
    }

    public override int GetOutputSize(int i) {
        int length;
        int i2 = i + this.f4fe2f532;
        int length2 = i2 % this.fcb7e52b2.length;
        if (length2 != 0) {
            i2 -= length2;
            length = this.fcb7e52b2.length;
        } else {
            if (!this.f9301aa9b) {
                return i2;
            }
            length = this.fcb7e52b2.length;
        }
        return i2 + length;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        int length = i2 % this.fcb7e52b2.length;
        return length != 0 ? i2 - length : i2 - this.fcb7e52b2.length;
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((16 + 26) % 26 > 0) {
        }
        int i2 = 0;
        if (this.f4fe2f532 == this.fcb7e52b2.length) {
            int iQhNUCPQKDNuKEFJk = qhNUCPQKDNuKEFJk(this.f08406a6e, this.fcb7e52b2, 0, bArr, i);
            this.f4fe2f532 = 0;
            i2 = iQhNUCPQKDNuKEFJk;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i3 = this.f4fe2f532;
        this.f4fe2f532 = i3 + 1;
        bArr2[i3] = b;
        return i2;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((19 + 26) % 26 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iXGHPdzlZZHVFXQha = xGHPdzlZZHVFXQha(this);
        int iOXcxiMCgQyUrszLx = OXcxiMCgQyUrszLx(this, i2);
        if (iOXcxiMCgQyUrszLx > 0 && iOXcxiMCgQyUrszLx + i3 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int length = this.fcb7e52b2.length - this.f4fe2f532;
        int iZRAwTqbZhIYMUMGA = 0;
        if (i2 > length) {
            iRCXapXscTyuOYZY(bArr, i, this.fcb7e52b2, this.f4fe2f532, length);
            int iYeXlzQbEHhzCVlDA = yeXlzQbEHhzCVlDA(this.f08406a6e, this.fcb7e52b2, 0, bArr2, i3);
            this.f4fe2f532 = 0;
            i2 -= length;
            i += length;
            iZRAwTqbZhIYMUMGA = iYeXlzQbEHhzCVlDA;
            while (i2 > this.fcb7e52b2.length) {
                iZRAwTqbZhIYMUMGA += zRAwTqbZhIYMUMGA(this.f08406a6e, bArr, i, bArr2, i3 + iZRAwTqbZhIYMUMGA);
                i2 -= iXGHPdzlZZHVFXQha;
                i += iXGHPdzlZZHVFXQha;
            }
        }
        qTwaMFTtcYJKBltL(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
        return iZRAwTqbZhIYMUMGA;
    }
}

