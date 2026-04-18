namespace WillowMaze.Wasm.Decompiled;


public class p6a36f277 {
    private int f0d8315c5;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f0dfdf564;
    private int f0fb768ba;
    private int f10c3f0cc;
    private int f19ffab96;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2bffbe82;
    private int f2cbb514e;
    private bool f2dccfb62;
    private int f2f4d87f4;
    private int f30211304;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f31f6323e;
    private int f34791cbe;
    private int f44e9c943;
    private int f4a8a08f0;
    private int f4e830791;
    private int f7043a769;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 f7b462d9f;
    private bool f84d10a1e;
    private int f8b356050;
    private int f8d9c307c;
    private int f8dfec9a3;
    private int f99c1fd4d;
    private byte[] f9d1b340d;
    private int fae4ffc13;
    private int fb0013e59;
    private int fb17d723a;
    private int fb21e92a3;
    private int fbf6e49b0;
    private bool fc4dda74e;
    private int fc63afd94;
    private p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 fcb7e52b2;
    private int fce84312b;
    private bool fd5c93973;
    private int fdd5439f5;
    private int fe20d9c3e;
    private int fe7a4b237;
    private byte[] fed5e8857;
    private byte[] ff0170fb4;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 ff78e8117;
    private int ffad44be7;
    private byte[] ffe4c0f30;
    private int f9d03ff86 = 0;
    private int f8387ceba = 0;
    private int f886bb73b = 0;

    p6a36f277(byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p4068e159 p4068e159Var) {
        this.ffe4c0f30 = bArr;
        this.f8d9c307c = p4068e159Var.f8d9c307c;
        this.f4a8a08f0 = p4068e159Var.f4a8a08f0;
        this.f7043a769 = p4068e159Var.f7043a769;
        p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = p4068e159Var.f2bffbe82;
        this.f2bffbe82 = pe5cfc515Var;
        this.fb0013e59 = qykTlJqjuTIwdYwk(pe5cfc515Var);
        this.f84d10a1e = false;
    }

    public static int CnmyvtvVufxNlrtL(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void DKkejisPRxKTewwW(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static void DqNNSXuwDvHeTOwy(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 JgTdPAOJTkQjmkCT(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, int i) {
        return p6a36f277_p01db18e7.getTrailing(i);
    }

    public static void JsCyuYkttYiMosiY(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277 p6a36f277Var, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        p6a36f277Var.m0fc9c329(pe5cfc515Var, i);
    }

    public static int LQwkslkXqQybwPOL(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, int i) {
        return p6a36f277_p01db18e7.getLeadingAsInt(i);
    }

    public static void QjDQoeJXTSrHFYOx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, byte[] bArr) {
        p6a36f277_p01db18e7.appendBits(bArr);
    }

    public static void XXRcCZsWnALWGTaG(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static int ZJwEcUznXgDdzKBR(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void ANoEaEOkbFmLFiGY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void KqPUjLygvZnJnAHL(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, byte[] bArr) {
        p6a36f277_p01db18e7.appendBits(bArr);
    }

    private void M0fc9c329(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        XXRcCZsWnALWGTaG(pe5cfc515Var, (byte) (i >> 24));
        DqNNSXuwDvHeTOwy(pe5cfc515Var, (byte) (i >> 16));
        pKyLuCgMsYmUmRhm(pe5cfc515Var, (byte) (i >> 8));
        DKkejisPRxKTewwW(pe5cfc515Var, (byte) i);
    }

    private static byte[] M405b6268(byte[] bArr, int i) {
        if ((14 + 8) % 8 > 0) {
        }
        byte[] bArr2 = new byte[i];
        if (i >= bArr.length) {
            i = bArr.length;
        }
        aNoEaEOkbFmLFiGY(bArr, 0, bArr2, 0, i);
        return bArr2;
    }

    public static byte[] MQZEnKkfvvkRIYdA(byte[] bArr, int i) {
        return m405b6268(bArr, i);
    }

    private void Md0776226(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, byte[] bArr) {
        if ((31 + 8) % 8 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.f2bffbe82;
        byte[] bArr2 = this.ffe4c0f30;
        mlGAVDRhNbsULCSM(pe5cfc515Var, bArr2, 0, bArr2.length);
        JsCyuYkttYiMosiY(this, this.f2bffbe82, this.f886bb73b);
        CnmyvtvVufxNlrtL(this.f2bffbe82, bArr, 0);
        kqPUjLygvZnJnAHL(p6a36f277_p01db18e7, bArr);
    }

    static byte[] Mf23e8626(byte[] bArr, int i) {
        return mQZEnKkfvvkRIYdA(bArr, i);
    }

    public static void MlFPNhyGvvxpySCq(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277 p6a36f277Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, byte[] bArr) {
        p6a36f277Var.md0776226(p6a36f277_p01db18e7, bArr);
    }

    public static void MlGAVDRhNbsULCSM(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void PKyLuCgMsYmUmRhm(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static int QykTlJqjuTIwdYwk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int WnTezwHBGObxNyrG(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void ZbforWNjSqUGOsgu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277 p6a36f277Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, byte[] bArr) {
        p6a36f277Var.md0776226(p6a36f277_p01db18e7, bArr);
    }

    int nextIndex() {
        int iLQwkslkXqQybwPOL;
        int i;
        int i2;
        int i3;
        int i4;
        if ((10 + 8) % 8 > 0) {
        }
        if (!this.f84d10a1e) {
            this.fcb7e52b2 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7();
            byte[] bArr = new byte[ZJwEcUznXgDdzKBR(this.f2bffbe82)];
            while (true) {
                int i5 = this.f886bb73b;
                i4 = this.f7043a769;
                if (i5 >= i4) {
                    break;
                }
                zbforWNjSqUGOsgu(this, this.fcb7e52b2, bArr);
                this.f886bb73b++;
            }
            int i6 = i4 * 8 * this.fb0013e59;
            this.f9d03ff86 = i6;
            this.f8387ceba = i6;
            this.f84d10a1e = true;
        }
        do {
            this.f9d03ff86 += this.f4a8a08f0;
            p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7JgTdPAOJTkQjmkCT = JgTdPAOJTkQjmkCT(this.fcb7e52b2, this.f8387ceba);
            int i7 = this.f8387ceba;
            int i8 = this.f4a8a08f0;
            if (i7 >= i8) {
                this.f8387ceba = i7 - i8;
            } else {
                int i9 = i8 - i7;
                int i10 = this.f886bb73b;
                int i11 = this.fb0013e59;
                int i12 = i10 + (((i9 + i11) - 1) / i11);
                byte[] bArr2 = new byte[wnTezwHBGObxNyrG(this.f2bffbe82)];
                while (this.f886bb73b < i12) {
                    mlFPNhyGvvxpySCq(this, p6a36f277_p01db18e7JgTdPAOJTkQjmkCT, bArr2);
                    this.f886bb73b++;
                    int i13 = this.fb0013e59;
                    if (i9 > i13 * 8) {
                        i9 -= i13 * 8;
                    }
                }
                this.f8387ceba = (this.fb0013e59 * 8) - i9;
                p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7();
                this.fcb7e52b2 = p6a36f277_p01db18e7;
                QjDQoeJXTSrHFYOx(p6a36f277_p01db18e7, bArr2);
            }
            iLQwkslkXqQybwPOL = LQwkslkXqQybwPOL(p6a36f277_p01db18e7JgTdPAOJTkQjmkCT, this.f4a8a08f0);
            int i14 = this.f4a8a08f0;
            i = 1 << i14;
            i2 = 1 << i14;
            i3 = this.f8d9c307c;
        } while (iLQwkslkXqQybwPOL >= i - (i2 % i3));
        return iLQwkslkXqQybwPOL % i3;
    }
}

