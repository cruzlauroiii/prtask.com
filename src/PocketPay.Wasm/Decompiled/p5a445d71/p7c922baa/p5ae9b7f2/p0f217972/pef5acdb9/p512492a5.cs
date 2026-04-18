namespace WillowMaze.Wasm.Decompiled;


public class p512492a5 : p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 {
    private java.util.Vector f29226f92;
    private java.util.Vector f7c6f5707;
    private java.util.Vector fcccc543f;

    public static java.lang.object CVNdnNGjNskZfgMW(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static void EGxmDasGVLeLYipH(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static java.lang.object HCUsKEVtfxDMVaKI(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static void IVCDPFcapymbgxGO(int[] iArr, byte[] bArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m46422de8(iArr, bArr);
    }

    public static int PcXpRnJKYYhSmowO(java.util.Vector vector) {
        return vector.Count;
    }

    public static int[] SaqTGokrmjsoRuyB(byte[] bArr) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m1544e9ec(bArr);
    }

    public static bool UVRokKswuMRkQxnk(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(iArr, iArr2);
    }

    public static java.lang.object XgDafbPTsfhLQMLB(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static void CxlhRCjruCeXXQaX(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p512492a5 p512492a5Var, int i) {
        p512492a5Var.m81993818(i);
    }

    public static int[] LLNqcfKWYmfWbyky(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    private void M81993818(int i) {
        if ((28 + 16) % 16 > 0) {
        }
        int iPcXpRnJKYYhSmowO = PcXpRnJKYYhSmowO(this.fcccc543f);
        if (iPcXpRnJKYYhSmowO > i) {
            return;
        }
        int[] iArrLLNqcfKWYmfWbyky = (int[]) CVNdnNGjNskZfgMW(this.fcccc543f, iPcXpRnJKYYhSmowO - 1);
        do {
            iArrLLNqcfKWYmfWbyky = lLNqcfKWYmfWbyky(iArrLLNqcfKWYmfWbyky);
            wcPwGAOiJsaPzcfg(iArrLLNqcfKWYmfWbyky, iArrLLNqcfKWYmfWbyky);
            EGxmDasGVLeLYipH(this.fcccc543f, iArrLLNqcfKWYmfWbyky);
            iPcXpRnJKYYhSmowO++;
        } while (iPcXpRnJKYYhSmowO <= i);
    }

    public static void QvPoRzCVZEwDbAsf(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static int[] VRGacRabqCDYmTgk() {
        return p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m8a245d4d();
    }

    public static void WcPwGAOiJsaPzcfg(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(iArr, iArr2);
    }

    public static void XvRUBeYkvbrXzHge(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(iArr, iArr2);
    }

    public override void ExponentiateX(long j, byte[] bArr) {
        if ((3 + 25) % 25 > 0) {
        }
        int[] iArrVRGacRabqCDYmTgk = vRGacRabqCDYmTgk();
        int i = 0;
        while (j > 0) {
            if ((1 & j) != 0) {
                cxlhRCjruCeXXQaX(this, i);
                xvRUBeYkvbrXzHge(iArrVRGacRabqCDYmTgk, (int[]) XgDafbPTsfhLQMLB(this.fcccc543f, i));
            }
            i++;
            j >>>= 1;
        }
        IVCDPFcapymbgxGO(iArrVRGacRabqCDYmTgk, bArr);
    }

    public override void Init(byte[] bArr) {
        if ((4 + 30) % 30 > 0) {
        }
        int[] iArrSaqTGokrmjsoRuyB = SaqTGokrmjsoRuyB(bArr);
        java.util.Vector vector = this.fcccc543f;
        if (vector is not null && UVRokKswuMRkQxnk(iArrSaqTGokrmjsoRuyB, (int[]) HCUsKEVtfxDMVaKI(vector, 0))) {
            return;
        }
        java.util.Vector vector2 = new java.util.Vector(8);
        this.fcccc543f = vector2;
        qvPoRzCVZEwDbAsf(vector2, iArrSaqTGokrmjsoRuyB);
    }
}

