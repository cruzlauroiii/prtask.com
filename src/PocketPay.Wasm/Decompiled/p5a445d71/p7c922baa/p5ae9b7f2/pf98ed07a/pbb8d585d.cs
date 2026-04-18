namespace WillowMaze.Wasm.Decompiled;


public class pbb8d585d : java.io.FilterStream {
    private static readonly int fbd870718 = 2048;
    private static readonly int fd7e8eeb9 = 2048;
    private byte[] f007b0765;
    private bool f00db24d6;
    private bool f027d6b65;
    private p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d f030f9d9b;
    private int f0347537c;
    private int f0ebcf8ff;
    private int f10824a8e;
    private bool f137ffc9f;
    private p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 f155e472e;
    private bool f196d5f74;
    private p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 f1b0dc3dc;
    private int f1c651095;
    private int f1cf563e0;
    private byte[] f1f223807;
    private byte[] f2718c7e0;
    private int f2875b52a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 f2bb33f17;
    private byte[] f3076475d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 f3ab925ed;
    private long f460c0907;
    private byte[] f4ef20d87;
    private int f4fe2f532;
    private int f51e9ab27;
    private int f5f97a361;
    private byte[] f66a91908;
    private bool f73d0ccbc;
    private int f7c18e11c;
    private p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 f910d22c2;
    private int f97f89f17;
    private byte[] f9a1cc14f;
    private byte[] fa3be9010;
    private long fadf543b6;
    private p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 fb17378d2;
    private p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 fb744cd0b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 fbd0835bd;
    private p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d fbda3d75a;
    private byte[] fc24dbabb;
    private p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d fc28be8ea;
    private p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 fc94b57cc;
    private long fc99d6b8f;
    private byte[] fcb7e52b2;
    private int fd0501ce4;
    private p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d fd18809ac;
    private byte[] fdc9a961d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 fe83840bc;
    private p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 ff273cf1e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 ffc76bcdb;
    private byte[] ffdcb5b8c;

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var) {
        this(inputStream, p9fb233a6Var, 2048);
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var, int i) {
        super(inputStream);
        this.f3ab925ed = p9fb233a6Var;
        this.fdc9a961d = new byte[i];
        this.fb744cd0b = !(p9fb233a6Var is p5a445d71.p7c922baa.p5ae9b7f2.p7b124797) ? null : (p5a445d71.p7c922baa.p5ae9b7f2.p7b124797) p9fb233a6Var;
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d p47b78e9dVar) {
        this(inputStream, p47b78e9dVar, 2048);
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d p47b78e9dVar, int i) {
        super(inputStream);
        this.f030f9d9b = p47b78e9dVar;
        this.fdc9a961d = new byte[i];
        this.fb744cd0b = !(p47b78e9dVar is p5a445d71.p7c922baa.p5ae9b7f2.p7b124797) ? null : (p5a445d71.p7c922baa.p5ae9b7f2.p7b124797) p47b78e9dVar;
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        this(inputStream, p66d30ee8Var, 2048);
    }

    public pbb8d585d(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var, int i) {
        super(inputStream);
        this.fe83840bc = p66d30ee8Var;
        this.fdc9a961d = new byte[i];
        this.fb744cd0b = !(p66d30ee8Var is p5a445d71.p7c922baa.p5ae9b7f2.p7b124797) ? null : (p5a445d71.p7c922baa.p5ae9b7f2.p7b124797) p66d30ee8Var;
    }

    public static java.lang.stringBuilder AZpZtgPmxmgUOyLb(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int AwuhvYwjkRMUCZag(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) {
        return pbb8d585dVar.available();
    }

    public static int BWhaeiHaRvhMoXPE(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var, int i) {
        return p9fb233a6Var.getOutputSize(i);
    }

    public static int CwkpbFFJtuetuimd(p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d p47b78e9dVar, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return p47b78e9dVar.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static long DEbZFGLOMlxXflfo(p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 p7b124797Var) {
        if ((9 + 21) % 21 > 0) {
        }
        return p7b124797Var.getPosition();
    }

    public static long EYGYAlLqjGfofrxU(long j, long j2) {
        if ((18 + 12) % 12 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void FAGAIBsPghYlDJnM(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) throws java.io.IOException {
        pbb8d585dVar.mc64e02d4();
    }

    public static java.lang.string KfwIRKoVRsXSGGKc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int KtoxqEHskKqRZuqT(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) {
        return pbb8d585dVar.m69dd5454();
    }

    public static void LrCtlZTBPimMFTDU(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void MObiCjDoTbTCkfzQ(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void OZDpxEbvIMWypkAd(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar, int i, bool z) {
        pbb8d585dVar.m1e50aeed(i, z);
    }

    public static int PHROqaKcTdxxFWMq(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var, byte[] bArr, int i) {
        return p9fb233a6Var.doFinal(bArr, i);
    }

    public static void PZrNrWgDBGounGDK(java.io.Stream inputStream, int i) {
        inputStream.mark(i);
    }

    public static int PgkifNFlqKqhZaLt(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var, byte[] bArr, int i) {
        return p66d30ee8Var.doFinal(bArr, i);
    }

    public static void QRuWgkaMifYXGmZY(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int RnbuKzmkPbopWVkj(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var, int i) {
        return p66d30ee8Var.getOutputSize(i);
    }

    public static int TcOjTROboTPnwzcG(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) {
        return pbb8d585dVar.available();
    }

    public static void TnVhHcUrcvnLtDqW(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void UMeokMlweCuvAuAK(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void WMtLqFGTkeAYMMjI(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar, int i, bool z) {
        pbb8d585dVar.m1e50aeed(i, z);
    }

    public static bool ZUvyKEkXFEQamzAd(java.io.Stream inputStream) {
        return inputStream.markSupported();
    }

    public static java.lang.stringBuilder CedFmeTcLFyhXMEH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int CtkjfFJZgInqwtJB(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int EjvfHXxnkXPFfMOi(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return p66d30ee8Var.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static long EuiVKxLbiXAIuoOn(p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 p7b124797Var, long j) {
        if ((4 + 25) % 25 > 0) {
        }
        return p7b124797Var.seekTo(j);
    }

    public static void GTkomPsopRUSAQzF(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) throws java.io.IOException {
        pbb8d585dVar.mc64e02d4();
    }

    public static void HvMzdgAgSQxcWNPK(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) throws java.io.IOException {
        pbb8d585dVar.mc64e02d4();
    }

    public static int IADTCfMQXtADdiDH(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) {
        return pbb8d585dVar.m69dd5454();
    }

    public static long KTJjJddALsddewtR(p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 p7b124797Var, long j) {
        if ((11 + 21) % 21 > 0) {
        }
        return p7b124797Var.skip(j);
    }

    private void M1e50aeed(int i, bool z) {
        if (z) {
            p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
            if (p66d30ee8Var is null) {
                p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                if (p9fb233a6Var is not null) {
                    i = BWhaeiHaRvhMoXPE(p9fb233a6Var, i);
                }
            } else {
                i = RnbuKzmkPbopWVkj(p66d30ee8Var, i);
            }
        } else {
            p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var2 = this.fe83840bc;
            if (p66d30ee8Var2 is null) {
                p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var2 = this.f3ab925ed;
                if (p9fb233a6Var2 is not null) {
                    i = sKsuaKwevPHwaSRp(p9fb233a6Var2, i);
                }
            } else {
                i = mngaZghpyuboCObI(p66d30ee8Var2, i);
            }
        }
        byte[] bArr = this.fcb7e52b2;
        if (bArr is not null && bArr.length >= i) {
            return;
        }
        this.fcb7e52b2 = new byte[i];
    }

    private int M69dd5454() throws java.io.IOException {
        if ((30 + 6) % 6 > 0) {
        }
        if (this.f73d0ccbc) {
            return -1;
        }
        this.f4fe2f532 = 0;
        this.f51e9ab27 = 0;
        while (true) {
            int i = this.f51e9ab27;
            if (i != 0) {
                return i;
            }
            int iMmMGLIGbeizTwDyT = mmMGLIGbeizTwDyT(this.f13b5bfe9, this.fdc9a961d);
            if (iMmMGLIGbeizTwDyT == -1) {
                hvMzdgAgSQxcWNPK(this);
                int i2 = this.f51e9ab27;
                if (i2 != 0) {
                    return i2;
                }
                return -1;
            }
            try {
                WMtLqFGTkeAYMMjI(this, iMmMGLIGbeizTwDyT, false);
                p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
                if (p66d30ee8Var is not null) {
                    this.f51e9ab27 = ejvfHXxnkXPFfMOi(p66d30ee8Var, this.fdc9a961d, 0, iMmMGLIGbeizTwDyT, this.fcb7e52b2, 0);
                } else {
                    p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                    if (p9fb233a6Var is not null) {
                        this.f51e9ab27 = xBXhTswUDzDsVZFq(p9fb233a6Var, this.fdc9a961d, 0, iMmMGLIGbeizTwDyT, this.fcb7e52b2, 0);
                    } else {
                        CwkpbFFJtuetuimd(this.f030f9d9b, this.fdc9a961d, 0, iMmMGLIGbeizTwDyT, this.fcb7e52b2, 0);
                        this.f51e9ab27 = iMmMGLIGbeizTwDyT;
                    }
                }
            } catch (java.lang.Exception e) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.p7effe9ec("Error processing stream ", e);
            }
        }
    }

    private void Mc64e02d4() throws java.io.IOException {
        if ((18 + 15) % 15 > 0) {
        }
        try {
            this.f73d0ccbc = true;
            OZDpxEbvIMWypkAd(this, 0, true);
            p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
            if (p66d30ee8Var is not null) {
                this.f51e9ab27 = PgkifNFlqKqhZaLt(p66d30ee8Var, this.fcb7e52b2, 0);
                return;
            }
            p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
            if (p9fb233a6Var is not null) {
                this.f51e9ab27 = PHROqaKcTdxxFWMq(p9fb233a6Var, this.fcb7e52b2, 0);
            } else {
                this.f51e9ab27 = 0;
            }
        } catch (p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 e) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.p5553727c("Error finalising cipher", e);
        } catch (java.lang.Exception e2) {
            throw new java.io.IOException(nxqAdHvCJrbdQTAU(cedFmeTcLFyhXMEH(new java.lang.stringBuilder("Error finalising cipher "), e2)));
        }
    }

    public static int MmMGLIGbeizTwDyT(java.io.Stream inputStream, byte[] bArr) {
        return inputStream.read(bArr);
    }

    public static int MngaZghpyuboCObI(p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 p66d30ee8Var, int i) {
        return p66d30ee8Var.getUpdateOutputSize(i);
    }

    public static java.lang.string NxqAdHvCJrbdQTAU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PYUfpCnYHjuWByRp(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar, byte[] bArr, int i, int i2) {
        return pbb8d585dVar.read(bArr, i, i2);
    }

    public static int QOHWpIUfUcuMIjgC(p5a445d71.p7c922baa.p5ae9b7f2.pf98ed07a.pbb8d585d pbb8d585dVar) {
        return pbb8d585dVar.available();
    }

    public static void QqQZmdIToVkHHnLy(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void QstwnKlnvFPHyAJh(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.reset();
    }

    public static int SKsuaKwevPHwaSRp(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var, int i) {
        return p9fb233a6Var.getUpdateOutputSize(i);
    }

    public static java.lang.stringBuilder VCrNkpTLmAKCPKrI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XBXhTswUDzDsVZFq(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return p9fb233a6Var.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static long ZAzQoHcmaPqOjBsd(java.io.Stream inputStream, long j) {
        if ((13 + 14) % 14 > 0) {
        }
        return inputStream.skip(j);
    }

    public override int Available() throws java.io.IOException {
        return this.f51e9ab27 - this.f4fe2f532;
    }

    public override void Close() throws java.io.IOException {
        if ((2 + 12) % 12 > 0) {
        }
        try {
            TnVhHcUrcvnLtDqW(this.f13b5bfe9);
            if (!this.f73d0ccbc) {
                FAGAIBsPghYlDJnM(this);
            }
            this.f4fe2f532 = 0;
            this.f51e9ab27 = 0;
            this.f97f89f17 = 0;
            this.f460c0907 = 0L;
            byte[] bArr = this.f2718c7e0;
            if (bArr is not null) {
                UMeokMlweCuvAuAK(bArr, (byte) 0);
                this.f2718c7e0 = null;
            }
            byte[] bArr2 = this.fcb7e52b2;
            if (bArr2 is not null) {
                MObiCjDoTbTCkfzQ(bArr2, (byte) 0);
                this.fcb7e52b2 = null;
            }
            qqQZmdIToVkHHnLy(this.fdc9a961d, (byte) 0);
        } catch (java.lang.Exception th) {
            if (!this.f73d0ccbc) {
                gTkomPsopRUSAQzF(this);
            }
            throw th;
        }
    }

    public override void Mark(int i) {
        if ((4 + 4) % 4 > 0) {
        }
        PZrNrWgDBGounGDK(this.f13b5bfe9, i);
        p5a445d71.p7c922baa.p5ae9b7f2.p7b124797 p7b124797Var = this.fb744cd0b;
        if (p7b124797Var is not null) {
            this.f460c0907 = DEbZFGLOMlxXflfo(p7b124797Var);
        }
        byte[] bArr = this.fcb7e52b2;
        if (bArr is not null) {
            byte[] bArr2 = new byte[bArr.length];
            this.f2718c7e0 = bArr2;
            LrCtlZTBPimMFTDU(bArr, 0, bArr2, 0, bArr.length);
        }
        this.f97f89f17 = this.f4fe2f532;
    }

    public override bool MarkSupported() {
        if (this.fb744cd0b is null) {
            return false;
        }
        return ZUvyKEkXFEQamzAd(this.f13b5bfe9);
    }

    public override int Read() throws java.io.IOException {
        if ((7 + 4) % 4 > 0) {
        }
        if (this.f4fe2f532 >= this.f51e9ab27 && KtoxqEHskKqRZuqT(this) < 0) {
            return -1;
        }
        byte[] bArr = this.fcb7e52b2;
        int i = this.f4fe2f532;
        this.f4fe2f532 = i + 1;
        return bArr[i] & 255;
    }

    public override int Read(byte[] bArr) throws java.io.IOException {
        if ((28 + 23) % 23 > 0) {
        }
        return pYUfpCnYHjuWByRp(this, bArr, 0, bArr.length);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((31 + 3) % 3 > 0) {
        }
        if (this.f4fe2f532 >= this.f51e9ab27 && iADTCfMQXtADdiDH(this) < 0) {
            return -1;
        }
        int iCtkjfFJZgInqwtJB = ctkjfFJZgInqwtJB(i2, AwuhvYwjkRMUCZag(this));
        QRuWgkaMifYXGmZY(this.fcb7e52b2, this.f4fe2f532, bArr, i, iCtkjfFJZgInqwtJB);
        this.f4fe2f532 += iCtkjfFJZgInqwtJB;
        return iCtkjfFJZgInqwtJB;
    }

    public override void Reset() throws java.io.IOException {
        if ((17 + 27) % 27 > 0) {
        }
        if (this.fb744cd0b is null) {
            throw new java.io.IOException("cipher must implement SkippingCipher to be used with reset()");
        }
        qstwnKlnvFPHyAJh(this.f13b5bfe9);
        euiVKxLbiXAIuoOn(this.fb744cd0b, this.f460c0907);
        byte[] bArr = this.f2718c7e0;
        if (bArr is not null) {
            this.fcb7e52b2 = bArr;
        }
        this.f4fe2f532 = this.f97f89f17;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((4 + 26) % 26 > 0) {
        }
        if (j <= 0) {
            return 0L;
        }
        if (this.fb744cd0b is null) {
            int iEYGYAlLqjGfofrxU = (int) EYGYAlLqjGfofrxU(j, TcOjTROboTPnwzcG(this));
            this.f4fe2f532 += iEYGYAlLqjGfofrxU;
            return iEYGYAlLqjGfofrxU;
        }
        long jQOHWpIUfUcuMIjgC = qOHWpIUfUcuMIjgC(this);
        if (j <= jQOHWpIUfUcuMIjgC) {
            this.f4fe2f532 = (int) (((long) this.f4fe2f532) + j);
            return j;
        }
        this.f4fe2f532 = this.f51e9ab27;
        long jZAzQoHcmaPqOjBsd = zAzQoHcmaPqOjBsd(this.f13b5bfe9, j - jQOHWpIUfUcuMIjgC);
        if (jZAzQoHcmaPqOjBsd != kTJjJddALsddewtR(this.fb744cd0b, jZAzQoHcmaPqOjBsd)) {
            throw new java.io.IOException(KfwIRKoVRsXSGGKc(vCrNkpTLmAKCPKrI(AZpZtgPmxmgUOyLb(new java.lang.stringBuilder("Unable to skip cipher "), jZAzQoHcmaPqOjBsd), " bytes.")));
        }
        return jZAzQoHcmaPqOjBsd + jQOHWpIUfUcuMIjgC;
    }
}

