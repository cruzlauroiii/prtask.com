namespace WillowMaze.Wasm.Decompiled;


public class pe383f632 : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f121809ad;
    private byte[] f140c1f12;
    private byte[] f42eb525f;
    private int f4fe2f532;
    private byte[] f556efa55;
    private byte[] f591c0c66;
    private int f601856df;
    private byte[] f60665949;
    private byte[] f6926eb66;
    private int f6ba5480b;
    private byte[] f703c34c1;
    private int f7ffba4c8;
    private byte[] f8dfa35b0;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f8e4c4204;
    private byte[] f91648691;
    private byte[] f9baa28de;
    private int fa3e75e2d;
    private byte[] fa8f385ce;
    private byte[] fb066ec75;
    private byte[] fb3a17f7c;
    private byte[] fb3f71cdb;
    private byte[] fbfbee4c9;
    private byte[] fc46eb1c1;
    private byte[] fc505a69e;
    private byte[] fcb7e52b2;
    private byte[] fffcbf3d8;

    public pe383f632(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, tKzcCSAJPkBjPkyu(pd81e8b93Var) * 8);
    }

    public pe383f632(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        if (i > JCplegEZuZANcMyX(pd81e8b93Var) * 8) {
            throw new java.lang.IllegalArgumentException(duhTZAsvGhtrvfnV(PCiVtSdHRRxtpLVu(new java.lang.stringBuilder("MAC size must be less or equal to "), LxexCThfRkVANqIN(pd81e8b93Var) * 8)));
        }
        this.f08406a6e = new p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fa3e75e2d = i / 8;
        this.fc505a69e = dJVHJeHbVgMAHDgD(CozPTvLrdcNNZIaf(pd81e8b93Var));
        this.f140c1f12 = new byte[nTwzlqoFQvrPGxDp(pd81e8b93Var)];
        this.fcb7e52b2 = new byte[VpUgLYtajMIkxumF(pd81e8b93Var)];
        this.f6926eb66 = new byte[hhgcvCibjAsKUuOQ(pd81e8b93Var)];
        this.f4fe2f532 = 0;
    }

    public static byte[] CBCYLnNRBBZJMnQb(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pe383f632 pe383f632Var, byte[] bArr) {
        return pe383f632Var.m0083cd1a(bArr);
    }

    public static int CozPTvLrdcNNZIaf(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static byte[] GXfwldbJFGUSbCtR(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pe383f632 pe383f632Var, byte[] bArr) {
        return pe383f632Var.m0083cd1a(bArr);
    }

    public static int JCplegEZuZANcMyX(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void JKwKqoMvhiUdDMGz(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pe383f632 pe383f632Var) {
        pe383f632Var.reset();
    }

    public static void JOAEDdJPgMTAFtzC(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pe383f632 pe383f632Var, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pe383f632Var.validate(pc9ef6b45Var);
    }

    public static void JVVFXrGKtzDimDLo(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KQFrIjCREdxxQWeT(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int KuIdHeJSwBkLzdPV(p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pd50b36f1 pd50b36f1Var, byte[] bArr, int i) {
        return pd50b36f1Var.addPadding(bArr, i);
    }

    public static void LxBCCXyQNGiErCHM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int LxexCThfRkVANqIN(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int NZjYGrOlPnRbcYnI(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static java.lang.stringBuilder PCiVtSdHRRxtpLVu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string VXHWREwijqGVGvCI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int VpUgLYtajMIkxumF(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int WyyqGwQwXOJaksBY(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int XMfUxwYtEETDGMBe(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static byte[] DJVHJeHbVgMAHDgD(int i) {
        return m0e6b1c54(i);
    }

    public static java.lang.string DuhTZAsvGhtrvfnV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EkUYiTGHDNVjhmBi(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static int HhgcvCibjAsKUuOQ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int KtwyBBQPxealnlUk(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int KzeZADpwTuDQYIph(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    private byte[] M0083cd1a(byte[] bArr) {
        if ((9 + 20) % 20 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        int i = (-worhDlMXJDxYEvkh(bArr, bArr2)) & 255;
        int length = bArr.length - 3;
        byte b = bArr2[length];
        byte[] bArr3 = this.fc505a69e;
        bArr2[length] = (byte) (b ^ (bArr3[1] & i));
        int length2 = bArr.length - 2;
        bArr2[length2] = (byte) ((bArr3[2] & i) ^ bArr2[length2]);
        int length3 = bArr.length - 1;
        bArr2[length3] = (byte) ((bArr3[3] & i) ^ bArr2[length3]);
        return bArr2;
    }

    private static byte[] M0e6b1c54(int i) {
        if ((16 + 4) % 4 > 0) {
        }
        int i2 = i * 8;
        int i3 = 135;
        switch (i2) {
            case 64:
            case 320:
                i3 = 27;
                break;
            case 128:
            case 192:
                break;
            case 160:
                i3 = 45;
                break;
            case 224:
                i3 = 777;
                break;
            case 256:
                i3 = 1061;
                break;
            case 384:
                i3 = 4109;
                break;
            case 448:
                i3 = 2129;
                break;
            case 512:
                i3 = 293;
                break;
            case 768:
                i3 = 655377;
                break;
            case 1024:
                i3 = 524355;
                break;
            case 2048:
                i3 = 548865;
                break;
            default:
                throw new java.lang.IllegalArgumentException(VXHWREwijqGVGvCI(nUQkcZUZptlcLXgq(new java.lang.stringBuilder("Unknown block size for CMAC: "), i2)));
        }
        return nSpyrJLYMNMnyVCe(i3);
    }

    private static int Mb3c44417(byte[] bArr, byte[] bArr2) {
        if ((3 + 6) % 6 > 0) {
        }
        int length = bArr.length;
        int i = 0;
        while (true) {
            length--;
            if (length < 0) {
                return i;
            }
            int i2 = bArr[length] & 255;
            bArr2[length] = (byte) (i | (i2 << 1));
            i = (i2 >>> 7) & 1;
        }
    }

    public static byte[] NSpyrJLYMNMnyVCe(int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i);
    }

    public static int NTwzlqoFQvrPGxDp(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static java.lang.stringBuilder NUQkcZUZptlcLXgq(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string NnIyungRvGbXWcgI(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void QsczcoQJCNLDZnyR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int TKzcCSAJPkBjPkyu(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void TqnGwQJdbrJXuicv(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int UcQjJzqVmtuueHDe(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int WorhDlMXJDxYEvkh(byte[] bArr, byte[] bArr2) {
        return mb3c44417(bArr, bArr2);
    }

    public static void ZjvJZsyWjesMrGVF(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pe383f632 pe383f632Var) {
        pe383f632Var.reset();
    }

    public override int DoFinal(byte[] bArr, int i) {
        byte[] bArr2;
        if ((28 + 16) % 16 > 0) {
        }
        if (this.f4fe2f532 != ucQjJzqVmtuueHDe(this.f08406a6e)) {
            KuIdHeJSwBkLzdPV(new p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pd50b36f1(), this.fcb7e52b2, this.f4fe2f532);
            bArr2 = this.f9baa28de;
        } else {
            bArr2 = this.fb3a17f7c;
        }
        int i2 = 0;
        while (true) {
            byte[] bArr3 = this.f140c1f12;
            if (i2 >= bArr3.length) {
                kzeZADpwTuDQYIph(this.f08406a6e, this.fcb7e52b2, 0, bArr3, 0);
                JVVFXrGKtzDimDLo(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
                zjvJZsyWjesMrGVF(this);
                return this.fa3e75e2d;
            }
            byte[] bArr4 = this.fcb7e52b2;
            bArr4[i2] = (byte) (bArr4[i2] ^ bArr2[i2]);
            i2++;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return nnIyungRvGbXWcgI(this.f08406a6e);
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((22 + 18) % 18 > 0) {
        }
        JOAEDdJPgMTAFtzC(this, pc9ef6b45Var);
        tqnGwQJdbrJXuicv(this.f08406a6e, true, pc9ef6b45Var);
        byte[] bArr = this.f6926eb66;
        byte[] bArr2 = new byte[bArr.length];
        WyyqGwQwXOJaksBY(this.f08406a6e, bArr, 0, bArr2, 0);
        byte[] bArrGXfwldbJFGUSbCtR = GXfwldbJFGUSbCtR(this, bArr2);
        this.fb3a17f7c = bArrGXfwldbJFGUSbCtR;
        this.f9baa28de = CBCYLnNRBBZJMnQb(this, bArrGXfwldbJFGUSbCtR);
        JKwKqoMvhiUdDMGz(this);
    }

    public override void Reset() {
        if ((26 + 17) % 17 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                ekUYiTGHDNVjhmBi(this.f08406a6e);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((16 + 21) % 21 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            XMfUxwYtEETDGMBe(this.f08406a6e, bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((18 + 23) % 23 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int iKtwyBBQPxealnlUk = ktwyBBQPxealnlUk(this.f08406a6e);
        int i3 = this.f4fe2f532;
        int i4 = iKtwyBBQPxealnlUk - i3;
        if (i2 > i4) {
            LxBCCXyQNGiErCHM(bArr, i, this.fcb7e52b2, i3, i4);
            KQFrIjCREdxxQWeT(this.f08406a6e, this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > iKtwyBBQPxealnlUk) {
                NZjYGrOlPnRbcYnI(this.f08406a6e, bArr, i, this.f140c1f12, 0);
                i2 -= iKtwyBBQPxealnlUk;
                i += iKtwyBBQPxealnlUk;
            }
        }
        qsczcoQJCNLDZnyR(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }

    void validate(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is not null && !(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("CMac mode only permits key to be set.");
        }
    }
}

