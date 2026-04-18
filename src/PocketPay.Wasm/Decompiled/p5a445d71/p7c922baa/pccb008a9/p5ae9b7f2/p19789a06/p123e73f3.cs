namespace WillowMaze.Wasm.Decompiled;


public class p123e73f3 {
    private int f061627e6;
    private bool f07c3edf8;
    private byte[] f0eb58043;
    private bool f154d576b;
    private bool f1b6100be;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f1f9312ad;
    private int f23a1268d;
    private byte[] f295da459;
    private bool f2a79df20;
    private int f2e8bbbc0;
    private int f396e569c;
    private int f399ddc6d;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f3bde1043;
    private bool f428cb33b;
    private java.util.Vector f441936b8;
    private byte[] f4ea40993;
    private int f59acdb47;
    private byte[] f5c9d8dfc;
    private java.util.Vector f6048c909;
    private java.util.Vector f6195e53f;
    private bool f637d1bdb;
    private int f68dc1bf6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f6993faa2;
    private java.util.Vector f699a8168;
    private bool f6dcc97e2;
    private bool f707009cb;
    private byte[] f724a3652;
    private int f8d3c64f4;
    private java.util.Vector f9523a203;
    private byte[] f9dfcf90e;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fac83138d;
    private int fad24a93f;
    private bool fb17e7238;
    private java.util.Vector fb1fb5054;
    private int fb45e1e43;
    private int fbb71d090;
    private bool fbd879312;
    private bool fd39dac5c;
    private int fe1b9ad91;
    private byte[] fe9127253;
    private byte[] fecc03d76;
    private byte[] fef426282;
    private bool ff3b9db3e;
    private int ff71cdf08;
    private int ffeccdeb1;

    public p123e73f3(java.util.Vector vector, int i, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f6048c909 = vector;
        this.f68dc1bf6 = i;
        this.f5c9d8dfc = null;
        this.fb17e7238 = false;
        this.f6dcc97e2 = false;
        this.fbd879312 = false;
        this.f3bde1043 = pe5cfc515Var;
        this.fe9127253 = new byte[osxRGSGnLgIOJmzD(pe5cfc515Var)];
        this.f724a3652 = new byte[FqismiJxuTfGVEiT(this.f3bde1043)];
    }

    public p123e73f3(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[][] bArr, int[] iArr) {
        if ((2 + 30) % 30 > 0) {
        }
        this.f3bde1043 = pe5cfc515Var;
        this.f68dc1bf6 = iArr[0];
        this.fe1b9ad91 = iArr[1];
        this.ffeccdeb1 = iArr[2];
        if (iArr[3] != 1) {
            this.f6dcc97e2 = false;
        } else {
            this.f6dcc97e2 = true;
        }
        if (iArr[4] != 1) {
            this.fb17e7238 = false;
        } else {
            this.fb17e7238 = true;
        }
        if (iArr[5] != 1) {
            this.fbd879312 = false;
        } else {
            this.fbd879312 = true;
        }
        this.f699a8168 = new java.util.Vector();
        for (int i = 0; i < this.fe1b9ad91; i++) {
            AVmQZUlwblnxJtKf(this.f699a8168, WQBogKVeJaDXODQQ(iArr[i + 6]));
        }
        this.f5c9d8dfc = bArr[0];
        this.f724a3652 = bArr[1];
        this.fe9127253 = bArr[2];
        this.f6048c909 = new java.util.Vector();
        for (int i2 = 0; i2 < this.fe1b9ad91; i2++) {
            QogtGppqTgGjNOxF(this.f6048c909, bArr[i2 + 3]);
        }
    }

    public static void AVmQZUlwblnxJtKf(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void AerkQidxjixXbzSd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object AnCpMRrYYwPJHfyP(java.util.Vector vector) {
        return vector.lastElement();
    }

    public static void AtrEVzxiVQTRFBgy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ClbvHQwAPjYQVqGj(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void DGoKpsjTmuOTMEuF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string FDRisuHwqbBCmqHc(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int FqismiJxuTfGVEiT(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static byte[] GtCiCTHdGMvtJknO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr) {
        return p177006abVar.nextSeed(bArr);
    }

    public static int GzLnXLDLjBseIGSt(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder HZigTDQTVSuqPWom(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HbZvnhHgvYzgxXtV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HoguokQUYbJjRKmI(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void JLOEtDLFoFSHVUSt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void JcKtuXThaHgItdwX(java.util.Vector vector, int i) {
        vector.removeElementAt(i);
    }

    public static int JzlKBXbcfXRAYRhx(java.util.Vector vector) {
        return vector.Count;
    }

    public static void KaoxihmhUUEcksuV(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KwoljCMDBcEBuErh(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.string LiWAQFDiTJxMVKtQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LjjwVzXkhBJhpaWl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MIlLZrbxjWkUIPQk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int MjpAjpMwAwhcvxwl(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int OSBmpSfXUfBQnoiB(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.string OSHcsciwGzwWvSCt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object OlVkbIvbwElPhaTh(java.util.Vector vector) {
        return vector.lastElement();
    }

    public static java.lang.object PBaEXFHqDCkHPHTK(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void PFEayYfsCvbTxfNu(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void PTYRPadRgsEkWDaC(java.util.Vector vector, int i) {
        vector.removeElementAt(i);
    }

    public static java.lang.int PaQEspZVPDvJhgRN(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static java.lang.stringBuilder QdswHDtmPtzEukHn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QogtGppqTgGjNOxF(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static java.lang.stringBuilder TDMvydjqBSmRtJyi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder UKKAxSLoWHyJhdkh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int VrlrvdDAGDpEKcQD(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static java.lang.int WQBogKVeJaDXODQQ(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static java.lang.stringBuilder WtLxfJOHUNSWPrRl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XCHvbsIuWSiFUVjc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int YkPrPvleJInxdYPS(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.stringBuilder ZHsVbdtjSjHtsrDS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ZcWAWmUCDqcJSUrA(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int BsBJTEJPMhYJdqwv(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int BwvlvaixUHHRCWmK(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int CGaFYVjRekXQUszM(java.util.Vector vector) {
        return vector.Count;
    }

    public static void DqPbunxbUuMpkdie(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int EEwWWFuUQQTNnjqM(java.lang.int num) {
        return num.intValue();
    }

    public static void EGqzuYxFcYVfDkdt(java.util.Vector vector, int i) {
        vector.removeElementAt(i);
    }

    public static java.lang.stringBuilder EXYOgwCtvleZpuIZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EhebZrZeauHqXciw(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.object FBbRcKHuXwsXZBYe(java.util.Vector vector) {
        return vector.lastElement();
    }

    public static int HqoQkGhNQFrxzHft(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder IUCAemNOTTRDYOGo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IkypwAZJoIHKcPYN(java.util.Vector vector) {
        return vector.Count;
    }

    public static int ImpeYoVgMjdOAhGz(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int JIHtcTYtJZksFlGC(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.object JPtYMUouyClFZnuU(java.util.Vector vector) {
        return vector.lastElement();
    }

    public static int JrDcchwTvPTXhIQh(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void KlefMBHBwIhwMtWQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder LabLcKOjridFcvgL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MGYHGoIsuZvmnGEK(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int MOFbJOKFFCzaUAuZ(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int[] MyWxeBHCwZnHIRSf(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3 p123e73f3Var) {
        return p123e73f3Var.getStatInt();
    }

    public static void NREAQGxrnIByUzuI(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void OrvQPDHkxwlfdmsg(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static int OsxRGSGnLgIOJmzD(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.stringBuilder PHBBgSaHwxwChNaw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] PtWjaobXzXmhWJgG(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m97a57645(bArr);
    }

    public static java.lang.stringBuilder QCLoKzsybPSgUQBc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QVbypRcQwUMkoBaa(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static int RZGkGIIVHUVUmQYq(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static int RbYJmDQgVykHxjVk(java.util.Vector vector) {
        return vector.Count;
    }

    public static java.lang.object RfkqhtWWauzPbvLq(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static int SBzRCbdfbpvyObhe(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void SzboxeSICwmVsHFc(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3 p123e73f3Var) {
        p123e73f3Var.initialize();
    }

    public static void TJIuqPHVhFdUOlqI(java.util.Vector vector, int i) {
        vector.removeElementAt(i);
    }

    public static java.lang.object TtQiBrksuNFFceIf(java.util.Vector vector) {
        return vector.lastElement();
    }

    public static java.lang.object TzNsGsSelHdHWEZx(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static byte[] UFfLeudeFgWjdEWt(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr) {
        return p177006abVar.nextSeed(bArr);
    }

    public static java.lang.string UGHbFGCvYgcGZVwn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[][] UfBmbGSuQUDrPWxS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3 p123e73f3Var) {
        return p123e73f3Var.getStatbyte();
    }

    public static void VrbeliLhIzutScEv(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static java.lang.string XQEQaKzktQFakhHR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[][] XsZopJRceftYOTva(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p123e73f3 p123e73f3Var) {
        return p123e73f3Var.getStatbyte();
    }

    public static void ZTASOXCxhQXUnSFI(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public void Destroy() {
        if ((6 + 19) % 19 > 0) {
        }
        this.fb17e7238 = false;
        this.f6dcc97e2 = false;
        this.f5c9d8dfc = null;
        this.fe1b9ad91 = 0;
        this.ffeccdeb1 = -1;
    }

    public byte[] GetFirstNode() {
        return this.f5c9d8dfc;
    }

    public int GetFirstNodeHeight() {
        return this.f5c9d8dfc is not null ? this.ffeccdeb1 : this.f68dc1bf6;
    }

    public int GetLowestNodeHeight() {
        return this.f5c9d8dfc is not null ? this.fe1b9ad91 != 0 ? ZcWAWmUCDqcJSUrA(this.ffeccdeb1, eEwWWFuUQQTNnjqM((java.lang.int) ttQiBrksuNFFceIf(this.f699a8168))) : this.ffeccdeb1 : this.f68dc1bf6;
    }

    public byte[] GetSeedActive() {
        return this.f724a3652;
    }

    public byte[][] GetStatbyte() {
        if ((6 + 15) % 15 > 0) {
        }
        int i = this.fe1b9ad91 + 3;
        int[] iArr = new int[2];
        iArr[1] = bwvlvaixUHHRCWmK(this.f3bde1043);
        iArr[0] = i;
        byte[][] bArr = (byte[][]) PBaEXFHqDCkHPHTK(java.lang.byte.TYPE, iArr);
        bArr[0] = this.f5c9d8dfc;
        bArr[1] = this.f724a3652;
        bArr[2] = this.fe9127253;
        for (int i2 = 0; i2 < this.fe1b9ad91; i2++) {
            bArr[i2 + 3] = (byte[]) rfkqhtWWauzPbvLq(this.f6048c909, i2);
        }
        return bArr;
    }

    public int[] GetStatInt() {
        if ((4 + 8) % 8 > 0) {
        }
        int i = this.fe1b9ad91;
        int[] iArr = new int[i + 6];
        iArr[0] = this.f68dc1bf6;
        iArr[1] = i;
        iArr[2] = this.ffeccdeb1;
        if (this.f6dcc97e2) {
            iArr[3] = 1;
        } else {
            iArr[3] = 0;
        }
        if (this.fb17e7238) {
            iArr[4] = 1;
        } else {
            iArr[4] = 0;
        }
        if (this.fbd879312) {
            iArr[5] = 1;
        } else {
            iArr[5] = 0;
        }
        for (int i2 = 0; i2 < this.fe1b9ad91; i2++) {
            iArr[i2 + 6] = hqoQkGhNQFrxzHft((java.lang.int) tzNsGsSelHdHWEZx(this.f699a8168, i2));
        }
        return iArr;
    }

    public java.util.Vector GetTailStack() {
        return this.f6048c909;
    }

    public void Initialize() {
        if ((23 + 27) % 27 > 0) {
        }
        if (!this.fbd879312) {
            nREAQGxrnIByUzuI(java.lang.System.err, uGHbFGCvYgcGZVwn(HZigTDQTVSuqPWom(ZHsVbdtjSjHtsrDS(new java.lang.stringBuilder("Seed "), this.f68dc1bf6), " not initialized")));
            return;
        }
        this.f699a8168 = new java.util.Vector();
        this.fe1b9ad91 = 0;
        this.f5c9d8dfc = null;
        this.ffeccdeb1 = -1;
        this.fb17e7238 = true;
        AerkQidxjixXbzSd(this.fe9127253, 0, this.f724a3652, 0, ClbvHQwAPjYQVqGj(this.f3bde1043));
    }

    public void InitializeSeed(byte[] bArr) {
        if ((2 + 16) % 16 > 0) {
        }
        AtrEVzxiVQTRFBgy(bArr, 0, this.fe9127253, 0, mOFbJOKFFCzaUAuZ(this.f3bde1043));
        this.fbd879312 = true;
    }

    public void SetFirstNode(byte[] bArr) {
        if (!this.fb17e7238) {
            szboxeSICwmVsHFc(this);
        }
        this.f5c9d8dfc = bArr;
        this.ffeccdeb1 = this.f68dc1bf6;
        this.f6dcc97e2 = true;
    }

    public java.lang.string Tostring() {
        java.lang.string strFDRisuHwqbBCmqHc;
        if ((18 + 20) % 20 > 0) {
        }
        java.lang.string strXQEQaKzktQFakhHR = "Treehash    : ";
        int i = 0;
        while (true) {
            int i2 = this.fe1b9ad91 + 6;
            strFDRisuHwqbBCmqHc = FDRisuHwqbBCmqHc("e3daca9476a2c2872747dd000e7d84a4f96d652eff33583a86f5167000");
            if (i >= i2) {
                break;
            }
            strXQEQaKzktQFakhHR = LiWAQFDiTJxMVKtQ(XCHvbsIuWSiFUVjc(QdswHDtmPtzEukHn(pHBBgSaHwxwChNaw(new java.lang.stringBuilder(), strXQEQaKzktQFakhHR), myWxeBHCwZnHIRSf(this)[i]), strFDRisuHwqbBCmqHc));
            i++;
        }
        for (int i3 = 0; i3 < this.fe1b9ad91 + 3; i3++) {
            strXQEQaKzktQFakhHR = xsZopJRceftYOTva(this)[i3] is null ? xQEQaKzktQFakhHR(WtLxfJOHUNSWPrRl(labLcKOjridFcvgL(new java.lang.stringBuilder(), strXQEQaKzktQFakhHR), "null ")) : OSHcsciwGzwWvSCt(LjjwVzXkhBJhpaWl(qCLoKzsybPSgUQBc(UKKAxSLoWHyJhdkh(new java.lang.stringBuilder(), strXQEQaKzktQFakhHR), new java.lang.string(ptWjaobXzXmhWJgG(ufBmbGSuQUDrPWxS(this)[i3]))), strFDRisuHwqbBCmqHc));
        }
        return HbZvnhHgvYzgxXtV(TDMvydjqBSmRtJyi(iUCAemNOTTRDYOGo(eXYOgwCtvleZpuIZ(new java.lang.stringBuilder(), strXQEQaKzktQFakhHR), "  "), rZGkGIIVHUVUmQYq(this.f3bde1043)));
    }

    public void Update(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar, byte[] bArr) {
        if ((24 + 18) % 18 > 0) {
        }
        if (this.f6dcc97e2) {
            zTASOXCxhQXUnSFI(java.lang.System.err, "No more update possible for treehash instance!");
            return;
        }
        if (!this.fb17e7238) {
            PFEayYfsCvbTxfNu(java.lang.System.err, "Treehash instance not initialized before update");
            return;
        }
        byte[] bArr2 = new byte[mGYHGoIsuZvmnGEK(this.f3bde1043)];
        GtCiCTHdGMvtJknO(p177006abVar, this.f724a3652);
        if (this.f5c9d8dfc is not null) {
            int i = 0;
            while (this.fe1b9ad91 > 0 && i == OSBmpSfXUfBQnoiB((java.lang.int) AnCpMRrYYwPJHfyP(this.f699a8168))) {
                int iBsBJTEJPMhYJdqwv = bsBJTEJPMhYJdqwv(this.f3bde1043) << 1;
                byte[] bArr3 = new byte[iBsBJTEJPMhYJdqwv];
                JLOEtDLFoFSHVUSt(OlVkbIvbwElPhaTh(this.f6048c909), 0, bArr3, 0, KwoljCMDBcEBuErh(this.f3bde1043));
                java.util.Vector vector = this.f6048c909;
                JcKtuXThaHgItdwX(vector, rbYJmDQgVykHxjVk(vector) - 1);
                java.util.Vector vector2 = this.f699a8168;
                tJIuqPHVhFdUOlqI(vector2, cGaFYVjRekXQUszM(vector2) - 1);
                klefMBHBwIhwMtWQ(bArr, 0, bArr3, sBzRCbdfbpvyObhe(this.f3bde1043), jIHtcTYtJZksFlGC(this.f3bde1043));
                vrbeliLhIzutScEv(this.f3bde1043, bArr3, 0, iBsBJTEJPMhYJdqwv);
                bArr = new byte[ehebZrZeauHqXciw(this.f3bde1043)];
                MjpAjpMwAwhcvxwl(this.f3bde1043, bArr, 0);
                i++;
                this.fe1b9ad91--;
            }
            orvQPDHkxwlfdmsg(this.f6048c909, bArr);
            qVbypRcQwUMkoBaa(this.f699a8168, PaQEspZVPDvJhgRN(i));
            this.fe1b9ad91++;
            if (GzLnXLDLjBseIGSt((java.lang.int) fBbRcKHuXwsXZBYe(this.f699a8168)) == this.ffeccdeb1) {
                int iMIlLZrbxjWkUIPQk = MIlLZrbxjWkUIPQk(this.f3bde1043) << 1;
                byte[] bArr4 = new byte[iMIlLZrbxjWkUIPQk];
                KaoxihmhUUEcksuV(this.f5c9d8dfc, 0, bArr4, 0, YkPrPvleJInxdYPS(this.f3bde1043));
                DGoKpsjTmuOTMEuF(jPtYMUouyClFZnuU(this.f6048c909), 0, bArr4, HoguokQUYbJjRKmI(this.f3bde1043), jrDcchwTvPTXhIQh(this.f3bde1043));
                java.util.Vector vector3 = this.f6048c909;
                eGqzuYxFcYVfDkdt(vector3, JzlKBXbcfXRAYRhx(vector3) - 1);
                java.util.Vector vector4 = this.f699a8168;
                PTYRPadRgsEkWDaC(vector4, ikypwAZJoIHKcPYN(vector4) - 1);
                dqPbunxbUuMpkdie(this.f3bde1043, bArr4, 0, iMIlLZrbxjWkUIPQk);
                byte[] bArr5 = new byte[impeYoVgMjdOAhGz(this.f3bde1043)];
                this.f5c9d8dfc = bArr5;
                VrlrvdDAGDpEKcQD(this.f3bde1043, bArr5, 0);
                this.ffeccdeb1++;
                this.fe1b9ad91 = 0;
            }
        } else {
            this.f5c9d8dfc = bArr;
            this.ffeccdeb1 = 0;
        }
        if (this.ffeccdeb1 != this.f68dc1bf6) {
            return;
        }
        this.f6dcc97e2 = true;
    }

    public void UpdateNextSeed(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab p177006abVar) {
        uFfLeudeFgWjdEWt(p177006abVar, this.fe9127253);
    }

    public bool WasFinished() {
        return this.f6dcc97e2;
    }

    public bool WasInitialized() {
        return this.fb17e7238;
    }
}

