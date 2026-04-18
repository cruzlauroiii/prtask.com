namespace WillowMaze.Wasm.Decompiled;


public class p3d85a317 : p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 {
    private int[] f4560238b;
    private int[] f4ce6a20f;
    private int[] f5c007776;
    private int[] f9dd4e461;

    public static int[] LgSTtndPufiudJtp() {
        return p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m8a245d4d();
    }

    public static int[] WsCuGfjEbsFlLQBk(byte[] bArr) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m1544e9ec(bArr);
    }

    public static int[] FBrHhGDDmhAqCSuw(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static void FZEoDmugjvJnEPTt(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(iArr, iArr2);
    }

    public static void JvdMAibamghYlfVC(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(iArr, iArr2);
    }

    public static void MsMoZTbQZqdhoFgY(int[] iArr, byte[] bArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m46422de8(iArr, bArr);
    }

    public override void ExponentiateX(long j, byte[] bArr) {
        if ((27 + 9) % 9 > 0) {
        }
        int[] iArrLgSTtndPufiudJtp = LgSTtndPufiudJtp();
        if (j > 0) {
            int[] iArrFBrHhGDDmhAqCSuw = fBrHhGDDmhAqCSuw(this.f9dd4e461);
            do {
                if ((1 & j) != 0) {
                    jvdMAibamghYlfVC(iArrLgSTtndPufiudJtp, iArrFBrHhGDDmhAqCSuw);
                }
                fZEoDmugjvJnEPTt(iArrFBrHhGDDmhAqCSuw, iArrFBrHhGDDmhAqCSuw);
                j >>>= 1;
            } while (j > 0);
        }
        msMoZTbQZqdhoFgY(iArrLgSTtndPufiudJtp, bArr);
    }

    public override void Init(byte[] bArr) {
        this.f9dd4e461 = WsCuGfjEbsFlLQBk(bArr);
    }
}

