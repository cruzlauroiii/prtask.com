namespace WillowMaze.Wasm.Decompiled;


public class pb6fd7338 : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private static readonly int f782ac786 = 16;
    private static readonly int fc75e2054 = 16;
    private static readonly int fd868d5e8 = 16;
    private static readonly int ff4af94e9 = 16;
    private static readonly int ff7273b1a = 16;
    private int f0574cabc;
    private int f080b17fc;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private int f08a9256a;
    private int f0b1040aa;
    private int f0bce78e0;
    private readonly byte[] f0ca73915;
    private int f1044934e;
    private int f1c50d0f4;
    private int f1ca0615d;
    private readonly byte[] f1fa314bd;
    private int f215fddf2;
    private int f28d61f7b;
    private int f2a206ca1;
    private int f2aeb9b95;
    private int f346b81a3;
    private int f392076f7;
    private int f3a4e2ec2;
    private int f3b4b570a;
    private int f3d7c633d;
    private int f41de3844;
    private int f44379f2b;
    private int f44e7f40b;
    private readonly byte[] f45647766;
    private int f48127e96;
    private int f48e6f36b;
    private int f490b2834;
    private int f50f10aff;
    private int f5499d704;
    private int f60652893;
    private readonly byte[] f608dfd93;
    private int f61620957;
    private readonly byte[] f66d8d784;
    private int f6a138698;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f6dd40d62;
    private int f6f207f8b;
    private int f6fdffaed;
    private int f7122dc1f;
    private readonly byte[] f78c2180e;
    private int f7c92cf1e;
    private int f7e7cb681;
    private int f7ed4d8aa;
    private int f85773399;
    private int f8b80ab1c;
    private int f8cee5723;
    private int f8d71c0ff;
    private int f8ddf8780;
    private int f932bd6b0;
    private int f9d3e622d;
    private int fa065f8df;
    private int fa7aa752f;
    private readonly byte[] faeed65ce;
    private int fb080e8d0;
    private int fb09be553;
    private int fb637b17a;
    private int fb6e5fb32;
    private int fc0828e03;
    private int fc347d664;
    private int fc62ef5c5;
    private int fcc15cffe;
    private int fce1b1e8c;
    private int fd2791864;
    private int fdb7874dc;
    private int fdde1af6f;
    private int fde56dc6c;
    private int fdf5a0e4d;
    private int fdff05bc2;
    private int fe33ff8d0;
    private int feaf18bcc;
    private int feb853f86;
    private int fec12561c;
    private int fef346fdd;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 ff1135442;
    private int ff193951d;
    private int ff3f8e4c8;
    private int ff57561fb;
    private int ff7ab469d;
    private int ffac98944;

    public pb6fd7338() {
        this.f608dfd93 = new byte[1];
        this.faeed65ce = new byte[16];
        this.fdde1af6f = 0;
        this.f08406a6e = null;
    }

    public pb6fd7338(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((18 + 32) % 32 > 0) {
        }
        this.f608dfd93 = new byte[1];
        this.faeed65ce = new byte[16];
        this.fdde1af6f = 0;
        if (xxAvIkFluEXIUxSw(pd81e8b93Var) != 16) {
            throw new java.lang.IllegalArgumentException("Poly1305 requires a 128 bit block cipher.");
        }
        this.f08406a6e = pd81e8b93Var;
    }

    public static int ArwAcVmIcBoOhJKW(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static void CTbyaIMCeFFytgsz(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m45d2d6ef(i, bArr, i2);
    }

    public static void DOfRxniJXJnspbxo(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pb6fd7338 pb6fd7338Var) {
        pb6fd7338Var.me3ee4228();
    }

    public static byte[] ExudBMElBzGvZYQD(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public static long FangRLGPhURAvsPv(int i, int i2) {
        if ((2 + 23) % 23 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long FjktYzFsrGLErssw(int i, int i2) {
        if ((32 + 20) % 20 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long FzocofYUJVlfLblw(int i, int i2) {
        if ((26 + 20) % 20 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static void GGdpovQxTiqTUUhZ(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m45d2d6ef(i, bArr, i2);
    }

    public static long HHwWGVqbofPFEbsN(int i, int i2) {
        if ((3 + 8) % 8 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long HZQoRchBEouyTytr(int i, int i2) {
        if ((27 + 28) % 28 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long KBBaPeEspPDYzyiW(int i, int i2) {
        if ((10 + 22) % 22 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int KqiYQtNeLkgSSZpT(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static java.lang.string LGRVtkcVsIPunjvo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] LOKojnZuDNslHJBb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static void LSsuKxIhDvIOtniz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void MBtpyYdtFffARUos(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pb6fd7338 pb6fd7338Var) {
        pb6fd7338Var.reset();
    }

    public static long MbARaouoUDqiGPfi(int i, int i2) {
        if ((20 + 16) % 16 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long MkNvjddzIeSgRWaz(int i, int i2) {
        if ((1 + 26) % 26 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long NTwOLljReRKDzTfw(int i, int i2) {
        if ((15 + 25) % 25 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int OqUXYebmxeAZMHNH(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static int QfcwWeZBXFEYOpkT(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static long RQRuRzYoJYTsNCIu(int i, int i2) {
        if ((13 + 14) % 14 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long TFGhmYHLCjPanQKX(int i, int i2) {
        if ((22 + 11) % 11 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static void TIxOhasjBQJSacEF(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pb6fd7338 pb6fd7338Var, byte[] bArr, byte[] bArr2) {
        pb6fd7338Var.m40939905(bArr, bArr2);
    }

    public static int TOVGklRflgTpRgyw(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static long VVUshkTRMVtqTToS(int i, int i2) {
        if ((22 + 12) % 12 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long VoTcIIIonXMOuGGN(int i, int i2) {
        if ((22 + 27) % 27 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static void XEcHCKkGiMkPFoww(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m45d2d6ef(i, bArr, i2);
    }

    public static long YmULfvDwuEexoudn(int i, int i2) {
        if ((10 + 1) % 1 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long AQlPyGqUIpxLcedH(int i, int i2) {
        if ((13 + 9) % 9 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int BaaabdLzRvMMSgvb(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static long BjEIMrUVeyYufDdP(int i, int i2) {
        if ((30 + 32) % 32 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long BtbuQgqmfcVxEsxX(int i, int i2) {
        if ((10 + 7) % 7 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int EJplkignpiRdXHdG(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static long EuFXFdaZEMLPvXvB(int i, int i2) {
        if ((29 + 31) % 31 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long FJBJZtVRAOofvHCX(int i, int i2) {
        if ((7 + 30) % 30 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static long FVwunlLayufOFbsL(int i, int i2) {
        if ((11 + 20) % 20 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int IxbAohLyVbbUBFvw(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static java.lang.stringBuilder JxBtrGPfLTeZhfoZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long KMpNHOhksbgapsiz(int i, int i2) {
        if ((25 + 28) % 28 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int KfhuhVxuvaQuOWXp(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static long LWIJBxyRoVAzVsop(int i, int i2) {
        if ((2 + 6) % 6 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    private static readonly long M05b4da7c(int i, int i2) {
        if ((13 + 16) % 16 > 0) {
        }
        return (((long) i) & 4294967295L) * ((long) i2);
    }

    private void M40939905(byte[] bArr, byte[] bArr2) {
        if ((7 + 14) % 14 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Poly1305 key must be 256 bits.");
        }
        int i = 16;
        if (this.f08406a6e is not null && (bArr2 is null || bArr2.length != 16)) {
            throw new java.lang.IllegalArgumentException("Poly1305 requires a 128 bit IV.");
        }
        int iOqUXYebmxeAZMHNH = OqUXYebmxeAZMHNH(bArr, 0);
        int iPpsrmQRyALmVPqyk = ppsrmQRyALmVPqyk(bArr, 4);
        int iKqiYQtNeLkgSSZpT = KqiYQtNeLkgSSZpT(bArr, 8);
        int iTOVGklRflgTpRgyw = TOVGklRflgTpRgyw(bArr, 12);
        this.fcc15cffe = 67108863 & iOqUXYebmxeAZMHNH;
        int i2 = ((iOqUXYebmxeAZMHNH >>> 26) | (iPpsrmQRyALmVPqyk << 6)) & 67108611;
        this.f7c92cf1e = i2;
        int i3 = ((iPpsrmQRyALmVPqyk >>> 20) | (iKqiYQtNeLkgSSZpT << 12)) & 67092735;
        this.fd2791864 = i3;
        int i4 = ((iKqiYQtNeLkgSSZpT >>> 14) | (iTOVGklRflgTpRgyw << 18)) & 66076671;
        this.f9d3e622d = i4;
        int i5 = (iTOVGklRflgTpRgyw >>> 8) & 1048575;
        this.f44379f2b = i5;
        this.f8ddf8780 = i2 * 5;
        this.ffac98944 = i3 * 5;
        this.fc0828e03 = i4 * 5;
        this.f7e7cb681 = i5 * 5;
        p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f08406a6e;
        if (pd81e8b93Var is not null) {
            byte[] bArr3 = new byte[16];
            sKOwhylJwXZEKkLj(pd81e8b93Var, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArr, 16, 16));
            zPxwSxLdsbpWJfPI(this.f08406a6e, bArr2, 0, bArr3, 0);
            i = 0;
            bArr = bArr3;
        }
        this.f28d61f7b = ixbAohLyVbbUBFvw(bArr, i);
        this.fb637b17a = udjnqBmsZAttmGQu(bArr, i + 4);
        this.f61620957 = ArwAcVmIcBoOhJKW(bArr, i + 8);
        this.ff7ab469d = wWlrlpLPAcdCaIZQ(bArr, i + 12);
    }

    private void Me3ee4228() {
        if ((16 + 25) % 25 > 0) {
        }
        int i = this.fdde1af6f;
        if (i < 16) {
            this.faeed65ce[i] = 1;
            for (int i2 = i + 1; i2 < 16; i2++) {
                this.faeed65ce[i2] = 0;
            }
        }
        long jKfhuhVxuvaQuOWXp = kfhuhVxuvaQuOWXp(this.faeed65ce, 0);
        long j = jKfhuhVxuvaQuOWXp & 4294967295L;
        long jEJplkignpiRdXHdG = ((long) eJplkignpiRdXHdG(this.faeed65ce, 4)) & 4294967295L;
        long jTEtVQqIvQgQwedtp = ((long) tEtVQqIvQgQwedtp(this.faeed65ce, 8)) & 4294967295L;
        long jBaaabdLzRvMMSgvb = 4294967295L & ((long) baaabdLzRvMMSgvb(this.faeed65ce, 12));
        int i3 = (int) (((long) this.fdb7874dc) + (jKfhuhVxuvaQuOWXp & 67108863));
        this.fdb7874dc = i3;
        this.f346b81a3 = (int) (((long) this.f346b81a3) + ((((jEJplkignpiRdXHdG << 32) | j) >>> 26) & 67108863));
        this.f490b2834 = (int) (((long) this.f490b2834) + (((jEJplkignpiRdXHdG | (jTEtVQqIvQgQwedtp << 32)) >>> 20) & 67108863));
        this.f6f207f8b = (int) (((long) this.f6f207f8b) + ((((jBaaabdLzRvMMSgvb << 32) | jTEtVQqIvQgQwedtp) >>> 14) & 67108863));
        int i4 = (int) (((long) this.fce1b1e8c) + (jBaaabdLzRvMMSgvb >>> 8));
        this.fce1b1e8c = i4;
        if (this.fdde1af6f == 16) {
            this.fce1b1e8c = i4 + 16777216;
        }
        long jFzocofYUJVlfLblw = FzocofYUJVlfLblw(i3, this.fcc15cffe) + KBBaPeEspPDYzyiW(this.f346b81a3, this.f7e7cb681) + lWIJBxyRoVAzVsop(this.f490b2834, this.fc0828e03) + pntNrxdNfijrLcSX(this.f6f207f8b, this.ffac98944) + VoTcIIIonXMOuGGN(this.fce1b1e8c, this.f8ddf8780);
        long jMkNvjddzIeSgRWaz = MkNvjddzIeSgRWaz(this.fdb7874dc, this.f7c92cf1e) + MbARaouoUDqiGPfi(this.f346b81a3, this.fcc15cffe) + fJBJZtVRAOofvHCX(this.f490b2834, this.f7e7cb681) + HZQoRchBEouyTytr(this.f6f207f8b, this.fc0828e03) + TFGhmYHLCjPanQKX(this.fce1b1e8c, this.ffac98944);
        long jYmULfvDwuEexoudn = YmULfvDwuEexoudn(this.fdb7874dc, this.fd2791864) + VVUshkTRMVtqTToS(this.f346b81a3, this.f7c92cf1e) + FjktYzFsrGLErssw(this.f490b2834, this.fcc15cffe) + RQRuRzYoJYTsNCIu(this.f6f207f8b, this.f7e7cb681) + aQlPyGqUIpxLcedH(this.fce1b1e8c, this.fc0828e03);
        long jYcotTdFGuHrHLKre = ycotTdFGuHrHLKre(this.fdb7874dc, this.f9d3e622d) + btbuQgqmfcVxEsxX(this.f346b81a3, this.fd2791864) + euFXFdaZEMLPvXvB(this.f490b2834, this.f7c92cf1e) + kMpNHOhksbgapsiz(this.f6f207f8b, this.fcc15cffe) + HHwWGVqbofPFEbsN(this.fce1b1e8c, this.f7e7cb681);
        long jBjEIMrUVeyYufDdP = bjEIMrUVeyYufDdP(this.fdb7874dc, this.f44379f2b) + fVwunlLayufOFbsL(this.f346b81a3, this.f9d3e622d) + FangRLGPhURAvsPv(this.f490b2834, this.fd2791864) + zWUfaFOcXgXVGKBs(this.f6f207f8b, this.f7c92cf1e) + NTwOLljReRKDzTfw(this.fce1b1e8c, this.fcc15cffe);
        int i5 = ((int) jFzocofYUJVlfLblw) & 67108863;
        long j2 = jMkNvjddzIeSgRWaz + (jFzocofYUJVlfLblw >>> 26);
        int i6 = ((int) j2) & 67108863;
        long j3 = jYmULfvDwuEexoudn + (j2 >>> 26);
        this.f490b2834 = ((int) j3) & 67108863;
        long j4 = jYcotTdFGuHrHLKre + (j3 >>> 26);
        this.f6f207f8b = ((int) j4) & 67108863;
        long j5 = jBjEIMrUVeyYufDdP + (j4 >>> 26);
        this.fce1b1e8c = ((int) j5) & 67108863;
        int i7 = i5 + (((int) (j5 >>> 26)) * 5);
        this.f346b81a3 = i6 + (i7 >>> 26);
        this.fdb7874dc = i7 & 67108863;
    }

    public static void MhFsXDvOIsBUpbPs(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pb6fd7338 pb6fd7338Var, byte[] bArr, int i, int i2) {
        pb6fd7338Var.update(bArr, i, i2);
    }

    public static void PEyUwzvtrAkDfixI(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m45d2d6ef(i, bArr, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 PKPvTOezPAFvUrwb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static long PntNrxdNfijrLcSX(int i, int i2) {
        if ((20 + 1) % 1 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int PpsrmQRyALmVPqyk(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static void QjYWFiTOZYXfJxpf(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pb6fd7338 pb6fd7338Var) {
        pb6fd7338Var.reset();
    }

    public static java.lang.string QnYkRgPkSHIGidCe(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void SKOwhylJwXZEKkLj(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int TEtVQqIvQgQwedtp(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static int UdjnqBmsZAttmGQu(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static int WWlrlpLPAcdCaIZQ(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
    }

    public static void WvxsIrLeYfkvBRdR(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.pb6fd7338 pb6fd7338Var) {
        pb6fd7338Var.me3ee4228();
    }

    public static int XxAvIkFluEXIUxSw(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static long YcotTdFGuHrHLKre(int i, int i2) {
        if ((1 + 27) % 27 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public static int ZPxwSxLdsbpWJfPI(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static long ZWUfaFOcXgXVGKBs(int i, int i2) {
        if ((12 + 21) % 21 > 0) {
        }
        return m05b4da7c(i, i2);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((5 + 17) % 17 > 0) {
        }
        if (i + 16 > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer is too short.");
        }
        if (this.fdde1af6f > 0) {
            DOfRxniJXJnspbxo(this);
        }
        int i2 = this.f346b81a3;
        int i3 = this.fdb7874dc;
        int i4 = i2 + (i3 >>> 26);
        int i5 = i3 & 67108863;
        int i6 = this.f490b2834 + (i4 >>> 26);
        int i7 = i4 & 67108863;
        int i8 = this.f6f207f8b + (i6 >>> 26);
        int i9 = i6 & 67108863;
        int i10 = this.fce1b1e8c + (i8 >>> 26);
        int i11 = i8 & 67108863;
        int i12 = i5 + ((i10 >>> 26) * 5);
        int i13 = i10 & 67108863;
        int i14 = i7 + (i12 >>> 26);
        int i15 = i12 & 67108863;
        int i16 = i15 + 5;
        int i17 = i16 >>> 26;
        int i18 = i16 & 67108863;
        int i19 = i17 + i14;
        int i20 = i19 >>> 26;
        int i21 = i19 & 67108863;
        int i22 = i20 + i9;
        int i23 = i22 >>> 26;
        int i24 = i22 & 67108863;
        int i25 = i23 + i11;
        int i26 = 67108863 & i25;
        int i27 = ((i25 >>> 26) + i13) - 67108864;
        int i28 = (i27 >>> 31) - 1;
        int i29 = ~i28;
        int i30 = (i15 & i29) | (i18 & i28);
        this.fdb7874dc = i30;
        int i31 = (i14 & i29) | (i21 & i28);
        this.f346b81a3 = i31;
        int i32 = (i9 & i29) | (i24 & i28);
        this.f490b2834 = i32;
        int i33 = (i26 & i28) | (i11 & i29);
        this.f6f207f8b = i33;
        int i34 = (i13 & i29) | (i27 & i28);
        this.fce1b1e8c = i34;
        long j = (((long) (i30 | (i31 << 26))) & 4294967295L) + (((long) this.f28d61f7b) & 4294967295L);
        long j2 = (((long) ((i31 >>> 6) | (i32 << 20))) & 4294967295L) + (((long) this.fb637b17a) & 4294967295L);
        long j3 = (((long) ((i32 >>> 12) | (i33 << 14))) & 4294967295L) + (((long) this.f61620957) & 4294967295L);
        long j4 = (((long) ((i33 >>> 18) | (i34 << 8))) & 4294967295L) + (4294967295L & ((long) this.ff7ab469d));
        GGdpovQxTiqTUUhZ((int) j, bArr, i);
        long j5 = j2 + (j >>> 32);
        CTbyaIMCeFFytgsz((int) j5, bArr, i + 4);
        long j6 = j3 + (j5 >>> 32);
        XEcHCKkGiMkPFoww((int) j6, bArr, i + 8);
        pEyUwzvtrAkDfixI((int) (j4 + (j6 >>> 32)), bArr, i + 12);
        qjYWFiTOZYXfJxpf(this);
        return 16;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((9 + 2) % 2 > 0) {
        }
        return this.f08406a6e is not null ? LGRVtkcVsIPunjvo(jxBtrGPfLTeZhfoZ(new java.lang.stringBuilder("Poly1305-"), qnYkRgPkSHIGidCe(this.f08406a6e))) : "Poly1305";
    }

    public override int GetMacSize() {
        return 16;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] bArrLOKojnZuDNslHJBb;
        if ((12 + 6) % 6 > 0) {
        }
        if (this.f08406a6e is null) {
            bArrLOKojnZuDNslHJBb = null;
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("Poly1305 requires an IV when used with a block cipher.");
            }
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            bArrLOKojnZuDNslHJBb = LOKojnZuDNslHJBb(pdd5da44eVar);
            pc9ef6b45Var = pKPvTOezPAFvUrwb(pdd5da44eVar);
        }
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Poly1305 requires a key.");
        }
        TIxOhasjBQJSacEF(this, ExudBMElBzGvZYQD((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var), bArrLOKojnZuDNslHJBb);
        MBtpyYdtFffARUos(this);
    }

    public override void Reset() {
        this.fdde1af6f = 0;
        this.fce1b1e8c = 0;
        this.f6f207f8b = 0;
        this.f490b2834 = 0;
        this.f346b81a3 = 0;
        this.fdb7874dc = 0;
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((23 + 7) % 7 > 0) {
        }
        byte[] bArr = this.f608dfd93;
        bArr[0] = b;
        mhFsXDvOIsBUpbPs(this, bArr, 0, 1);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((32 + 9) % 9 > 0) {
        }
        int i3 = 0;
        while (i2 > i3) {
            if (this.fdde1af6f == 16) {
                wvxsIrLeYfkvBRdR(this);
                this.fdde1af6f = 0;
            }
            int iQfcwWeZBXFEYOpkT = QfcwWeZBXFEYOpkT(i2 - i3, 16 - this.fdde1af6f);
            LSsuKxIhDvIOtniz(bArr, i3 + i, this.faeed65ce, this.fdde1af6f, iQfcwWeZBXFEYOpkT);
            i3 += iQfcwWeZBXFEYOpkT;
            this.fdde1af6f += iQfcwWeZBXFEYOpkT;
        }
    }
}

