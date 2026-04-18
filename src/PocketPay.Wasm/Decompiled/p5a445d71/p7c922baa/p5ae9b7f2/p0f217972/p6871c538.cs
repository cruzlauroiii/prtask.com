namespace WillowMaze.Wasm.Decompiled;


public class p6871c538 : p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 {
    private static readonly int f0a26c361 = 16;
    private static readonly int fc75e2054 = 16;
    private static readonly int ff3bda36a = 16;
    private byte[] f022caf5a;
    private byte[] f0eba983a;
    private int f11832756;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f140a7ffa;
    private int f181f1373;
    private bool f1c4ee0d4;
    private byte[] f2212d0ed;
    private byte[] f23ee11b1;
    private byte[] f2810e7aa;
    private byte[] f2aa9ed48;
    private byte[] f2eb5a1f0;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f3401c21e;
    private byte[] f3435c385;
    private byte[] f35487eba;
    private long f3cddb2eb;
    private byte[] f3f3a5c41;
    private byte[] f40528d0d;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f48d46eb8;
    private long f4e021145;
    private long f513ca562;
    private int f54a7d01d;
    private byte[] f5b46f88f;
    private byte[] f5bee5e04;
    private java.util.Vector f5c014fa2;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f6381e463;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f652f5d61;
    private byte[] f6932dfdb;
    private int f72b5616d;
    private long f7691b5df;
    private byte[] f7a301d53;
    private long f87a3ff18;
    private byte[] f89f37066;
    private byte[] f8c8682ee;
    private bool f9301aa9b;
    private byte[] f96988d91;
    private byte[] f9a28c6c0;
    private byte[] f9aa3028f;
    private byte[] f9d1bbf03;
    private byte[] fa039724e;
    private byte[] fa0ec8705;
    private long fa145324a;
    private int fa3e75e2d;
    private long fabfd0e28;
    private bool fb11dfb1e;
    private byte[] fb32c1c05;
    private java.util.Vector fb4b9da2b;
    private int fb9fef78d;
    private byte[] fc366742d;
    private java.util.Vector fcd11a818;
    private byte[] fcdde04df;
    private java.util.Vector fd20caec3;
    private bool fd9becae7;
    private int fda78e6c0;
    private byte[] fdb7ab500;
    private byte[] fdc3615b3;
    private byte[] fdded53f5;
    private byte[] fe132a456;
    private byte[] fe155e43d;
    private byte[] ff0370bf2;
    private byte[] ff170368d;
    private byte[] ff4e5bf12;
    private int ff930b6fd;
    private long ffa140ec6;
    private byte[] ffbb09a82;
    private byte[] ffede64c8;

    public p6871c538(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var2) {
        if ((11 + 20) % 20 > 0) {
        }
        this.f5b46f88f = null;
        this.ffbb09a82 = new byte[24];
        this.f35487eba = new byte[16];
        this.f9a28c6c0 = new byte[16];
        if (pd81e8b93Var is null) {
            throw new java.lang.IllegalArgumentException("'hashCipher' cannot be null");
        }
        if (KicRMuiZFZtdteSV(pd81e8b93Var) != 16) {
            throw new java.lang.IllegalArgumentException("'hashCipher' must have a block size of 16");
        }
        if (pd81e8b93Var2 is null) {
            throw new java.lang.IllegalArgumentException("'mainCipher' cannot be null");
        }
        if (ERVYTjwfBunLCNuf(pd81e8b93Var2) != 16) {
            throw new java.lang.IllegalArgumentException("'mainCipher' must have a block size of 16");
        }
        if (!nbZtsMMMolWZdGbq(dXWTthbzTcPrgSuz(pd81e8b93Var), UGEjoroBAdDygAGa(pd81e8b93Var2))) {
            throw new java.lang.IllegalArgumentException("'hashCipher' and 'mainCipher' must be the same algorithm");
        }
        this.f140a7ffa = pd81e8b93Var;
        this.f652f5d61 = pd81e8b93Var2;
    }

    public static void CfpUfWMbSTFnVGMv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void DlWbEyRfWGwgvnFm(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void EFQEwowAYywhMvxJ(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static void ENPdZePsVvVNHcJZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ERVYTjwfBunLCNuf(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void EneFbbSeZkedyTRg(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr, int i, int i2) {
        p6871c538Var.processAADbytes(bArr, i, i2);
    }

    public static int EsFuqLmHLnOUUMwf(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static byte[] FeQggImvIRYfJcBW(byte[] bArr) {
        return m6bde0870(bArr);
    }

    public static byte[] FiywcRQqkOxqLuZh(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static void FngzoUPuswWRpBLY(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void GsFmvhlWCtlFTqwt(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static int HMJYqPVRLgNSEeCb(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        return p6871c538Var.processNonce(bArr);
    }

    public static java.lang.object HhzihckdyOhAuQQO(java.util.Vector vector) {
        return vector.lastElement();
    }

    public static void HnwPAVSSZqWdABMV(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void INzGbUSBeUSQoVIp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string IupYLXrQiPTMlFyr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JLjzGgnzmeKpsVFl(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static int JQauDLgwSmdcnYFY(java.util.Vector vector) {
        return vector.Count;
    }

    public static void KBEEMsjntdwmBlBC(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.clear(bArr);
    }

    public static void KReJMNdASKlFqXTY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void KfwOBjyEHGeHQuJV(byte[] bArr, int i) {
        m7e44d9c4(bArr, i);
    }

    public static int KicRMuiZFZtdteSV(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int KohMCpoeydJTpiks(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static byte[] MDewzXoIPOgIIkei(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var) {
        return ped128738Var.getAssociatedText();
    }

    public static byte[] NqWZDJtlIaPItfsH(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void OEPLEImzusDaACrv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int PUlfKBjNmNlfpTho(long j) {
        return mc698dde1(j);
    }

    public static void RqRkAizpOgxzwDPs(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.clear(bArr);
    }

    public static void SxPMQDVsXbyRCRTw(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 TShzSOopNYmcDNWZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var) {
        return ped128738Var.getKey();
    }

    public static void UCUFLMCFcqVRCTBJ(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static byte[] UDtTqDaPdnbnVnRB(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, int i) {
        return p6871c538Var.getLSub(i);
    }

    public static java.lang.string UGEjoroBAdDygAGa(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void UNUnFavkRMSPqbZZ(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void VFaJNjamICAqkKBS(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void WYtxxuKfyRHeDzUL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WznxSMseckOgfVzx(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool XryIulMbKFMXpQEg(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static int YhBWEilfLVTNxZkR(byte[] bArr, byte[] bArr2) {
        return mb3c44417(bArr, bArr2);
    }

    public static byte[] ZRGBIfJjhsQuFkzv(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var) {
        return ped128738Var.getNonce();
    }

    public static void ZyAwZubElqXzCrFd(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 AhihKtGeDKfgYfsB(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static void BqdVrcBhIIeZMCRj(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.updateHASH(bArr);
    }

    public static void BtWyfTbTfLjphFEV(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.clear(bArr);
    }

    public static void CGvEIUPnJdOpjATj(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, bool z) {
        p6871c538Var.reset(z);
    }

    public static java.lang.string DXWTthbzTcPrgSuz(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void FBDPCiAbJydKiyUN(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var) {
        p6871c538Var.processHashBlock();
    }

    public static java.lang.stringBuilder FBzRXdVRITjzXPwy(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FCFDjpUUVysXCibK(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.clear(bArr);
    }

    public static void FLyIzxOUHhbfciJe(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int FwPploAwsdRqVXuw(long j) {
        return mc698dde1(j);
    }

    public static void GUPGgVnywHUUMlCv(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var) {
        p6871c538Var.processHashBlock();
    }

    public static void GnrNXHTITJUbfcqD(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void GulhKrMtOtiNmOGd(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.clear(bArr);
    }

    public static void IdrTmGTnUGJeGVSo(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void JHMebUWBJKcmacOQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool JKxeipyYkgXniFoc(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m66e765de(bArr, bArr2);
    }

    public static void JTwclUXVyrMPpGhs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void KQLoDDzgCDpbaOfr(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr) {
        p6871c538Var.updateHASH(bArr);
    }

    public static void KoZMjpdddKjnhByw(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void KxRbRvcRPpLhWLgR(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static java.lang.stringBuilder LdfgnzpBGzqQwOuG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LnIoEZRUCcqOfsAk(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    protected static byte[] M6bde0870(byte[] bArr) {
        if ((30 + 4) % 4 > 0) {
        }
        byte[] bArr2 = new byte[16];
        bArr2[15] = (byte) ((135 >>> ((1 - YhBWEilfLVTNxZkR(bArr, bArr2)) << 3)) ^ bArr2[15]);
        return bArr2;
    }

    protected static void M7e44d9c4(byte[] bArr, int i) {
        bArr[i] = -128;
        while (true) {
            i++;
            if (i >= 16) {
                return;
            } else {
                bArr[i] = 0;
            }
        }
    }

    public static int MCtDaSJZeQVzaotA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    protected static void Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((18 + 29) % 29 > 0) {
        }
        for (int i = 15; i >= 0; i--) {
            bArr[i] = (byte) (bArr[i] ^ bArr2[i]);
        }
    }

    protected static int Mb3c44417(byte[] bArr, byte[] bArr2) {
        if ((20 + 20) % 20 > 0) {
        }
        int i = 16;
        int i2 = 0;
        while (true) {
            i--;
            if (i < 0) {
                return i2;
            }
            int i3 = bArr[i] & 255;
            bArr2[i] = (byte) (i2 | (i3 << 1));
            i2 = (i3 >>> 7) & 1;
        }
    }

    protected static int Mc698dde1(long j) {
        if ((30 + 19) % 19 > 0) {
        }
        if (j == 0) {
            return 64;
        }
        int i = 0;
        while ((1 & j) == 0) {
            i++;
            j >>>= 1;
        }
        return i;
    }

    public static bool NbZtsMMMolWZdGbq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void NiGWfNYESYgAuIfw(byte[] bArr, int i) {
        m7e44d9c4(bArr, i);
    }

    public static void OMjItCzaWkqGRhvG(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void OlxJHaYaBIjycpub(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static void OrpZhNbNgcORzhbS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void PKtphClDhlLouLQy(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int PXLLWgHvbYvaUqIm(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static int QRCNNyNeRUXDBYdb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var) {
        return ped128738Var.getMacSize();
    }

    public static void QhCVwtTedQoHwAbe(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr, int i) {
        p6871c538Var.processMainBlock(bArr, i);
    }

    public static java.lang.string QlHnlEVTKqbnvEra(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] RPAuYIBErDtfFlfn(byte[] bArr) {
        return m6bde0870(bArr);
    }

    public static void SgSamytrPTJqDimO(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr, int i, int i2) {
        p6871c538Var.processAADbytes(bArr, i, i2);
    }

    public static void TDGVagQualWbQzcU(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static byte[] TDqqIbSwxIkeQLaH(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, int i) {
        return p6871c538Var.getLSub(i);
    }

    public static java.lang.object TYgbAXZmzcohvAMv(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static void VHLyBjrbxWcKkFRP(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, bool z) {
        p6871c538Var.reset(z);
    }

    public static void XnxrwxCwGWEWsLPg(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static void XrcyyhZliCHkDrAO(byte[] bArr, int i) {
        m7e44d9c4(bArr, i);
    }

    public static java.lang.stringBuilder YQdsJDnBljshTYet(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YTyTSVJxxYSsarfw(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static byte[] YbbYCoiKiAqhVMOL(byte[] bArr) {
        return m6bde0870(bArr);
    }

    public static java.lang.string ZYMlcNRJKKjeJLTU(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void ZaUEZzTCYVKXJSfm(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p6871c538 p6871c538Var, byte[] bArr, int i) {
        p6871c538Var.processMainBlock(bArr, i);
    }

    public static void ZgxInYNoiYiGlSef(byte[] bArr, byte[] bArr2) {
        ma3929604(bArr, bArr2);
    }

    public static int ZvUyjMzywEBEEcNb(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    protected void Clear(byte[] bArr) {
        if (bArr is null) {
            return;
        }
        JLjzGgnzmeKpsVFl(bArr, (byte) 0);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        byte[] bArr2;
        if ((3 + 11) % 11 > 0) {
        }
        if (this.f9301aa9b) {
            bArr2 = null;
        } else {
            int i2 = this.fb9fef78d;
            int i3 = this.fa3e75e2d;
            if (i2 < i3) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("data too short");
            }
            int i4 = i2 - i3;
            this.fb9fef78d = i4;
            bArr2 = new byte[i3];
            OEPLEImzusDaACrv(this.f2212d0ed, i4, bArr2, 0, i3);
        }
        int i5 = this.fda78e6c0;
        if (i5 > 0) {
            KfwOBjyEHGeHQuJV(this.f96988d91, i5);
            bqdVrcBhIIeZMCRj(this, this.fdb7ab500);
        }
        int i6 = this.fb9fef78d;
        if (i6 > 0) {
            if (this.f9301aa9b) {
                xrcyyhZliCHkDrAO(this.f2212d0ed, i6);
                gnrNXHTITJUbfcqD(this.f89f37066, this.f2212d0ed);
            }
            GsFmvhlWCtlFTqwt(this.f9a28c6c0, this.fdb7ab500);
            byte[] bArr3 = new byte[16];
            lnIoEZRUCcqOfsAk(this.f140a7ffa, this.f9a28c6c0, 0, bArr3, 0);
            UCUFLMCFcqVRCTBJ(this.f2212d0ed, bArr3);
            int length = bArr.length;
            int i7 = this.fb9fef78d;
            if (length < i + i7) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            INzGbUSBeUSQoVIp(this.f2212d0ed, 0, bArr, i, i7);
            if (!this.f9301aa9b) {
                niGWfNYESYgAuIfw(this.f2212d0ed, this.fb9fef78d);
                UNUnFavkRMSPqbZZ(this.f89f37066, this.f2212d0ed);
            }
        }
        FngzoUPuswWRpBLY(this.f89f37066, this.f9a28c6c0);
        DlWbEyRfWGwgvnFm(this.f89f37066, this.f9aa3028f);
        p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f140a7ffa;
        byte[] bArr4 = this.f89f37066;
        EsFuqLmHLnOUUMwf(pd81e8b93Var, bArr4, 0, bArr4, 0);
        yTyTSVJxxYSsarfw(this.f89f37066, this.fa0ec8705);
        int i8 = this.fa3e75e2d;
        byte[] bArr5 = new byte[i8];
        this.f0eba983a = bArr5;
        orpZhNbNgcORzhbS(this.f89f37066, 0, bArr5, 0, i8);
        int i9 = this.fb9fef78d;
        if (this.f9301aa9b) {
            int length2 = bArr.length;
            int i10 = i + i9;
            int i11 = this.fa3e75e2d;
            if (length2 < i10 + i11) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer too short");
            }
            KReJMNdASKlFqXTY(this.f0eba983a, 0, bArr, i10, i11);
            i9 += this.fa3e75e2d;
        } else if (!jKxeipyYkgXniFoc(this.f0eba983a, bArr2)) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("mac check in OCB failed");
        }
        vHLyBjrbxWcKkFRP(this, false);
        return i9;
    }

    public override java.lang.string GetAlgorithmName() {
        return qlHnlEVTKqbnvEra(yQdsJDnBljshTYet(ldfgnzpBGzqQwOuG(new java.lang.stringBuilder(), zYMlcNRJKKjeJLTU(this.f652f5d61)), "/OCB"));
    }

    protected byte[] GetLSub(int i) {
        if ((32 + 27) % 27 > 0) {
        }
        while (i >= JQauDLgwSmdcnYFY(this.fd20caec3)) {
            java.util.Vector vector = this.fd20caec3;
            koZMjpdddKjnhByw(vector, rPAuYIBErDtfFlfn((byte[]) HhzihckdyOhAuQQO(vector)));
        }
        return (byte[]) tYgbAXZmzcohvAMv(this.fd20caec3, i);
    }

    public override byte[] GetMac() {
        byte[] bArr = this.f0eba983a;
        return bArr is not null ? NqWZDJtlIaPItfsH(bArr) : new byte[this.fa3e75e2d];
    }

    public override int GetOutputSize(int i) {
        int i2 = i + this.fb9fef78d;
        if (this.f9301aa9b) {
            return i2 + this.fa3e75e2d;
        }
        int i3 = this.fa3e75e2d;
        if (i2 >= i3) {
            return i2 - i3;
        }
        return 0;
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f652f5d61;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.fb9fef78d;
        if (!this.f9301aa9b) {
            int i3 = this.fa3e75e2d;
            if (i2 < i3) {
                return 0;
            }
            i2 -= i3;
        }
        return i2 - (i2 % 16);
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        byte[] bArrFiywcRQqkOxqLuZh;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6VarTShzSOopNYmcDNWZ;
        if ((22 + 20) % 20 > 0) {
        }
        bool z2 = this.f9301aa9b;
        this.f9301aa9b = z;
        this.f0eba983a = null;
        if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            bArrFiywcRQqkOxqLuZh = ZRGBIfJjhsQuFkzv(ped128738Var);
            this.fdc3615b3 = MDewzXoIPOgIIkei(ped128738Var);
            int iQRCNNyNeRUXDBYdb = qRCNNyNeRUXDBYdb(ped128738Var);
            if (iQRCNNyNeRUXDBYdb < 64 || iQRCNNyNeRUXDBYdb > 128 || iQRCNNyNeRUXDBYdb % 8 != 0) {
                throw new java.lang.IllegalArgumentException(IupYLXrQiPTMlFyr(fBzRXdVRITjzXPwy(new java.lang.stringBuilder("Invalid value for MAC size: "), iQRCNNyNeRUXDBYdb)));
            }
            this.fa3e75e2d = iQRCNNyNeRUXDBYdb / 8;
            p94919be6VarTShzSOopNYmcDNWZ = TShzSOopNYmcDNWZ(ped128738Var);
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("invalid parameters passed to OCB");
            }
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            bArrFiywcRQqkOxqLuZh = FiywcRQqkOxqLuZh(pdd5da44eVar);
            this.fdc3615b3 = null;
            this.fa3e75e2d = 16;
            p94919be6VarTShzSOopNYmcDNWZ = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) ahihKtGeDKfgYfsB(pdd5da44eVar);
        }
        this.f96988d91 = new byte[16];
        this.f2212d0ed = new byte[!z ? this.fa3e75e2d + 16 : 16];
        if (bArrFiywcRQqkOxqLuZh is null) {
            bArrFiywcRQqkOxqLuZh = new byte[0];
        }
        if (bArrFiywcRQqkOxqLuZh.length > 15) {
            throw new java.lang.IllegalArgumentException("IV must be no more than 15 bytes");
        }
        if (p94919be6VarTShzSOopNYmcDNWZ is not null) {
            ZyAwZubElqXzCrFd(this.f140a7ffa, true, p94919be6VarTShzSOopNYmcDNWZ);
            pKtphClDhlLouLQy(this.f652f5d61, z, p94919be6VarTShzSOopNYmcDNWZ);
            this.f5b46f88f = null;
        } else if (z2 != z) {
            throw new java.lang.IllegalArgumentException("cannot change encrypting state without providing key.");
        }
        byte[] bArr = new byte[16];
        this.fdb7ab500 = bArr;
        KohMCpoeydJTpiks(this.f140a7ffa, bArr, 0, bArr, 0);
        this.f9aa3028f = ybbYCoiKiAqhVMOL(this.fdb7ab500);
        java.util.Vector vector = new java.util.Vector();
        this.fd20caec3 = vector;
        VFaJNjamICAqkKBS(vector, FeQggImvIRYfJcBW(this.f9aa3028f));
        int iHMJYqPVRLgNSEeCb = HMJYqPVRLgNSEeCb(this, bArrFiywcRQqkOxqLuZh);
        int i = iHMJYqPVRLgNSEeCb % 8;
        int i2 = iHMJYqPVRLgNSEeCb / 8;
        if (i != 0) {
            for (int i3 = 0; i3 < 16; i3++) {
                byte[] bArr2 = this.ffbb09a82;
                int i4 = bArr2[i2] & 255;
                i2++;
                this.f35487eba[i3] = (byte) (((bArr2[i2] & 255) >>> (8 - i)) | (i4 << i));
            }
        } else {
            WYtxxuKfyRHeDzUL(this.ffbb09a82, i2, this.f35487eba, 0, 16);
        }
        this.fda78e6c0 = 0;
        this.fb9fef78d = 0;
        this.f87a3ff18 = 0L;
        this.fa145324a = 0L;
        this.fc366742d = new byte[16];
        this.fa0ec8705 = new byte[16];
        fLyIzxOUHhbfciJe(this.f35487eba, 0, this.f9a28c6c0, 0, 16);
        this.f89f37066 = new byte[16];
        byte[] bArr3 = this.fdc3615b3;
        if (bArr3 is null) {
            return;
        }
        sgSamytrPTJqDimO(this, bArr3, 0, bArr3.length);
    }

    public override void ProcessAADbyte(byte b) {
        if ((30 + 11) % 11 > 0) {
        }
        byte[] bArr = this.f96988d91;
        int i = this.fda78e6c0;
        bArr[i] = b;
        int i2 = i + 1;
        this.fda78e6c0 = i2;
        if (i2 != bArr.length) {
            return;
        }
        gUPGgVnywHUUMlCv(this);
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        if ((11 + 26) % 26 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            byte[] bArr2 = this.f96988d91;
            int i4 = this.fda78e6c0;
            bArr2[i4] = bArr[i + i3];
            int i5 = i4 + 1;
            this.fda78e6c0 = i5;
            if (i5 == bArr2.length) {
                fBDPCiAbJydKiyUN(this);
            }
        }
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((3 + 12) % 12 > 0) {
        }
        byte[] bArr2 = this.f2212d0ed;
        int i2 = this.fb9fef78d;
        bArr2[i2] = b;
        int i3 = i2 + 1;
        this.fb9fef78d = i3;
        if (i3 != bArr2.length) {
            return 0;
        }
        zaUEZzTCYVKXJSfm(this, bArr, i);
        return 16;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((13 + 28) % 28 > 0) {
        }
        if (bArr.length < i + i2) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("Input buffer too short");
        }
        int i4 = 0;
        for (int i5 = 0; i5 < i2; i5++) {
            byte[] bArr3 = this.f2212d0ed;
            int i6 = this.fb9fef78d;
            bArr3[i6] = bArr[i + i5];
            int i7 = i6 + 1;
            this.fb9fef78d = i7;
            if (i7 == bArr3.length) {
                qhCVwtTedQoHwAbe(this, bArr2, i3 + i4);
                i4 += 16;
            }
        }
        return i4;
    }

    protected void ProcessHashBlock() {
        if ((3 + 32) % 32 > 0) {
        }
        long j = this.f87a3ff18 + 1;
        this.f87a3ff18 = j;
        kQLoDDzgCDpbaOfr(this, tDqqIbSwxIkeQLaH(this, PUlfKBjNmNlfpTho(j)));
        this.fda78e6c0 = 0;
    }

    protected void ProcessMainBlock(byte[] bArr, int i) {
        if ((21 + 25) % 25 > 0) {
        }
        if (bArr.length < i + 16) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (this.f9301aa9b) {
            SxPMQDVsXbyRCRTw(this.f89f37066, this.f2212d0ed);
            this.fb9fef78d = 0;
        }
        byte[] bArr2 = this.f9a28c6c0;
        long j = this.fa145324a + 1;
        this.fa145324a = j;
        zgxInYNoiYiGlSef(bArr2, UDtTqDaPdnbnVnRB(this, fwPploAwsdRqVXuw(j)));
        HnwPAVSSZqWdABMV(this.f2212d0ed, this.f9a28c6c0);
        p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f652f5d61;
        byte[] bArr3 = this.f2212d0ed;
        zvUyjMzywEBEEcNb(pd81e8b93Var, bArr3, 0, bArr3, 0);
        idrTmGTnUGJeGVSo(this.f2212d0ed, this.f9a28c6c0);
        jHMebUWBJKcmacOQ(this.f2212d0ed, 0, bArr, i, 16);
        if (this.f9301aa9b) {
            return;
        }
        oMjItCzaWkqGRhvG(this.f89f37066, this.f2212d0ed);
        byte[] bArr4 = this.f2212d0ed;
        CfpUfWMbSTFnVGMv(bArr4, 16, bArr4, 0, this.fa3e75e2d);
        this.fb9fef78d = this.fa3e75e2d;
    }

    protected int ProcessNonce(byte[] bArr) {
        if ((17 + 15) % 15 > 0) {
        }
        byte[] bArr2 = new byte[16];
        int i = 0;
        WznxSMseckOgfVzx(bArr, 0, bArr2, 16 - bArr.length, bArr.length);
        bArr2[0] = (byte) (this.fa3e75e2d << 4);
        int length = 15 - bArr.length;
        bArr2[length] = (byte) (bArr2[length] | 1);
        byte b = bArr2[15];
        int i2 = b & 63;
        bArr2[15] = (byte) (b & 192);
        byte[] bArr3 = this.f5b46f88f;
        if (bArr3 is null || !XryIulMbKFMXpQEg(bArr2, bArr3)) {
            byte[] bArr4 = new byte[16];
            this.f5b46f88f = bArr2;
            pXLLWgHvbYvaUqIm(this.f140a7ffa, bArr2, 0, bArr4, 0);
            jTwclUXVyrMPpGhs(bArr4, 0, this.ffbb09a82, 0, 16);
            while (i < 8) {
                byte[] bArr5 = this.ffbb09a82;
                int i3 = i + 16;
                byte b2 = bArr4[i];
                i++;
                bArr5[i3] = (byte) (b2 ^ bArr4[i]);
            }
        }
        return i2;
    }

    public override void Reset() {
        cGvEIUPnJdOpjATj(this, true);
    }

    protected void Reset(bool z) {
        if ((19 + 22) % 22 > 0) {
        }
        xnxrwxCwGWEWsLPg(this.f140a7ffa);
        EFQEwowAYywhMvxJ(this.f652f5d61);
        RqRkAizpOgxzwDPs(this, this.f96988d91);
        KBEEMsjntdwmBlBC(this, this.f2212d0ed);
        this.fda78e6c0 = 0;
        this.fb9fef78d = 0;
        this.f87a3ff18 = 0L;
        this.fa145324a = 0L;
        fCFDjpUUVysXCibK(this, this.fc366742d);
        btWyfTbTfLjphFEV(this, this.fa0ec8705);
        ENPdZePsVvVNHcJZ(this.f35487eba, 0, this.f9a28c6c0, 0, 16);
        gulhKrMtOtiNmOGd(this, this.f89f37066);
        if (z) {
            this.f0eba983a = null;
        }
        byte[] bArr = this.fdc3615b3;
        if (bArr is null) {
            return;
        }
        EneFbbSeZkedyTRg(this, bArr, 0, bArr.length);
    }

    protected void UpdateHASH(byte[] bArr) {
        if ((22 + 6) % 6 > 0) {
        }
        olxJHaYaBIjycpub(this.fc366742d, bArr);
        kxRbRvcRPpLhWLgR(this.f96988d91, this.fc366742d);
        p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f140a7ffa;
        byte[] bArr2 = this.f96988d91;
        mCtDaSJZeQVzaotA(pd81e8b93Var, bArr2, 0, bArr2, 0);
        tDGVagQualWbQzcU(this.fa0ec8705, this.f96988d91);
    }
}

