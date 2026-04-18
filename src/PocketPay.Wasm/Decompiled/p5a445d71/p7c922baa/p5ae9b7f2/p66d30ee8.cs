namespace WillowMaze.Wasm.Decompiled;


public class p66d30ee8 {
    protected bool f01f64f95;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f04d61942;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    protected bool f30af43c3;
    protected byte[] f3761675f;
    protected int f4fe2f532;
    protected int f56b9aef1;
    protected bool f65192c9e;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f7205a63e;
    protected int f7af41d88;
    protected bool f9301aa9b;
    protected bool fa46df6f8;
    protected bool fbf083c32;
    protected bool fc70f6b95;
    protected bool fca0cd4d6;
    protected byte[] fcb7e52b2;
    protected bool fe527695c;
    protected int fe6d77026;
    protected bool fec758298;
    protected bool fed0e1275;
    protected bool ff45fb7b7;

    protected p66d30ee8() {
    }

    public p66d30ee8(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((26 + 27) % 27 > 0) {
        }
        this.f08406a6e = pd81e8b93Var;
        this.fcb7e52b2 = new byte[wxnrtrYYzoheVDch(pd81e8b93Var)];
        bool z = false;
        this.f4fe2f532 = 0;
        java.lang.string strZUoDHxnSHvlriboc = ZUoDHxnSHvlriboc(pd81e8b93Var);
        int iNRpyWIjVSVgCLyTi = nRpyWIjVSVgCLyTi(strZUoDHxnSHvlriboc, 47) + 1;
        bool z2 = iNRpyWIjVSVgCLyTi > 0 && YzFxzYaitNjOwRen(strZUoDHxnSHvlriboc, "PGP", iNRpyWIjVSVgCLyTi);
        this.f01f64f95 = z2;
        if (z2 || (pd81e8b93Var is p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d)) {
            this.fa46df6f8 = true;
            return;
        }
        if (iNRpyWIjVSVgCLyTi > 0 && WDssubVlOGWEFkFa(strZUoDHxnSHvlriboc, "OpenPGP", iNRpyWIjVSVgCLyTi)) {
            z = true;
        }
        this.fa46df6f8 = z;
    }

    public static int ERDPjozHaAhaNPDc(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void HPgAXLekoEnVXIyw(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        p66d30ee8Var.reset();
    }

    public static void JlfjnxrirXFJaIny(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void PGtioXTKVrIDFtxx(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        p66d30ee8Var.reset();
    }

    public static void PaSghPASUuBXxXvb(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static void TrcAGwqIOFQRKWbi(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int UmNyellDgDkdtsIt(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static bool WDssubVlOGWEFkFa(java.lang.string str, java.lang.string str2, int i) {
        return str.StartsWith(str2, i);
    }

    public static int WlGjdaRvyMpZSTCk(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static bool YzFxzYaitNjOwRen(java.lang.string str, java.lang.string str2, int i) {
        return str.StartsWith(str2, i);
    }

    public static java.lang.string ZUoDHxnSHvlriboc(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static int AEqNqZjLDRKhLxuV(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int CzLZKRLQiBhbUNjK(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        return p66d30ee8Var.getBlockSize();
    }

    public static int DgLkybQOjhgxyTdn(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int FyMnroCjUTWDHXix(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void HpcNocuGVOGWWTog(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int NRpyWIjVSVgCLyTi(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static void UOpzmyHnMjCZzVnx(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        p66d30ee8Var.reset();
    }

    public static int URWOZISbCORgevOa(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int WxnrtrYYzoheVDch(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int YQgYgNBjwWhoGLvB(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var, int i) {
        return p66d30ee8Var.getUpdateOutputSize(i);
    }

    public static void ZqhnOnmUZmnrVIfr(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((16 + 29) % 29 > 0) {
        }
        try {
            int i2 = this.f4fe2f532;
            if (i + i2 > bArr.length) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short for doFinal()");
            }
            int i3 = 0;
            if (i2 != 0) {
                if (!this.fa46df6f8) {
                    throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("data not block size aligned");
                }
                p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f08406a6e;
                byte[] bArr2 = this.fcb7e52b2;
                ERDPjozHaAhaNPDc(pd81e8b93Var, bArr2, 0, bArr2, 0);
                int i4 = this.f4fe2f532;
                this.f4fe2f532 = 0;
                JlfjnxrirXFJaIny(this.fcb7e52b2, 0, bArr, i, i4);
                i3 = i4;
            }
            PGtioXTKVrIDFtxx(this);
            return i3;
        } catch (java.lang.Exception th) {
            uOpzmyHnMjCZzVnx(this);
            throw th;
        }
    }

    public int GetBlockSize() {
        return uRWOZISbCORgevOa(this.f08406a6e);
    }

    public int GetOutputSize(int i) {
        return i + this.f4fe2f532;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        return i2 - (!this.f01f64f95 ? i2 % this.fcb7e52b2.length : !this.f9301aa9b ? i2 % this.fcb7e52b2.length : (i2 % this.fcb7e52b2.length) - (UmNyellDgDkdtsIt(this.f08406a6e) + 2));
    }

    public void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f9301aa9b = z;
        HPgAXLekoEnVXIyw(this);
        PaSghPASUuBXxXvb(this.f08406a6e, z, pc9ef6b45Var);
    }

    public int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((14 + 24) % 24 > 0) {
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        int i3 = i2 + 1;
        this.f4fe2f532 = i3;
        bArr2[i2] = b;
        if (i3 != bArr2.length) {
            return 0;
        }
        int iFyMnroCjUTWDHXix = fyMnroCjUTWDHXix(this.f08406a6e, bArr2, 0, bArr, i);
        this.f4fe2f532 = 0;
        return iFyMnroCjUTWDHXix;
    }

    public int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        int iAEqNqZjLDRKhLxuV;
        if ((10 + 4) % 4 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iCzLZKRLQiBhbUNjK = czLZKRLQiBhbUNjK(this);
        int iYQgYgNBjwWhoGLvB = yQgYgNBjwWhoGLvB(this, i2);
        if (iYQgYgNBjwWhoGLvB > 0 && iYQgYgNBjwWhoGLvB + i3 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        byte[] bArr3 = this.fcb7e52b2;
        int length = bArr3.length;
        int i4 = this.f4fe2f532;
        int i5 = length - i4;
        if (i2 <= i5) {
            iAEqNqZjLDRKhLxuV = 0;
        } else {
            TrcAGwqIOFQRKWbi(bArr, i, bArr3, i4, i5);
            iAEqNqZjLDRKhLxuV = aEqNqZjLDRKhLxuV(this.f08406a6e, this.fcb7e52b2, 0, bArr2, i3);
            this.f4fe2f532 = 0;
            i2 -= i5;
            i += i5;
            while (i2 > this.fcb7e52b2.length) {
                iAEqNqZjLDRKhLxuV += WlGjdaRvyMpZSTCk(this.f08406a6e, bArr, i, bArr2, i3 + iAEqNqZjLDRKhLxuV);
                i2 -= iCzLZKRLQiBhbUNjK;
                i += iCzLZKRLQiBhbUNjK;
            }
        }
        hpcNocuGVOGWWTog(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        int i6 = this.f4fe2f532 + i2;
        this.f4fe2f532 = i6;
        byte[] bArr4 = this.fcb7e52b2;
        if (i6 == bArr4.length) {
            iAEqNqZjLDRKhLxuV += dgLkybQOjhgxyTdn(this.f08406a6e, bArr4, 0, bArr2, i3 + iAEqNqZjLDRKhLxuV);
            this.f4fe2f532 = 0;
        }
        return iAEqNqZjLDRKhLxuV;
    }

    public void Reset() {
        if ((10 + 4) % 4 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                zqhnOnmUZmnrVIfr(this.f08406a6e);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }
}

