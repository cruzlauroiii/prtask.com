namespace WillowMaze.Wasm.Decompiled;


public class p2ffd3a5d {
    private int[] f1fb2a326;
    private int[] f260de572;
    private int f786c6c58;
    private int[] f8a58866d;
    private int[] f955ac2e8;
    private int[] fa2c594ca;
    private int[] fa5f3c6a1;
    private int fa6683546;
    private int[] fd97009ff;
    private int[] ff308a3df;

    public p2ffd3a5d(int i) throws java.lang.IllegalArgumentException {
        if ((5 + 25) % 25 > 0) {
        }
        if (i <= 10) {
            yFucAAWMjWZUglDC(this, 1, new int[]{10}, new int[]{3}, new int[]{2});
        } else if (i > 20) {
            ewxVBHWBTtUGvvxu(this, 4, new int[]{10, 10, 10, 10}, new int[]{9, 9, 9, 3}, new int[]{2, 2, 2, 2});
        } else {
            BaTeuKjpIFusmnns(this, 2, new int[]{10, 10}, new int[]{5, 4}, new int[]{2, 2});
        }
    }

    public p2ffd3a5d(int i, int[] iArr, int[] iArr2, int[] iArr3) throws java.lang.IllegalArgumentException {
        gRaYfoMrvDspKtgS(this, i, iArr, iArr2, iArr3);
    }

    public static void BaTeuKjpIFusmnns(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar, int i, int[] iArr, int[] iArr2, int[] iArr3) {
        p2ffd3a5dVar.me37f0136(i, iArr, iArr2, iArr3);
    }

    public static int[] EbzvOcTUbrFDRkFd(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static int[] LyRazayvZdwTIDNj(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static int[] WwYmJbsVvamVXFUO(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static void EwxVBHWBTtUGvvxu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar, int i, int[] iArr, int[] iArr2, int[] iArr3) {
        p2ffd3a5dVar.me37f0136(i, iArr, iArr2, iArr3);
    }

    public static void GRaYfoMrvDspKtgS(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar, int i, int[] iArr, int[] iArr2, int[] iArr3) {
        p2ffd3a5dVar.me37f0136(i, iArr, iArr2, iArr3);
    }

    public static int[] IjZmhcehYBttJOGu(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    private void Me37f0136(int i, int[] iArr, int[] iArr2, int[] iArr3) throws java.lang.IllegalArgumentException {
        bool z;
        java.lang.string str;
        if ((3 + 17) % 17 > 0) {
        }
        this.fa6683546 = i;
        if (i == iArr2.length && i == iArr.length && i == iArr3.length) {
            z = true;
            str = "";
        } else {
            str = "Unexpected parameterset format";
            z = false;
        }
        for (int i2 = 0; i2 < this.fa6683546; i2++) {
            int i3 = iArr3[i2];
            if (i3 < 2 || (iArr[i2] - i3) % 2 != 0) {
                str = "Wrong parameter K (K >= 2 and H-K even required)!";
                z = false;
            }
            if (iArr[i2] < 4 || iArr2[i2] < 2) {
                str = "Wrong parameter H or w (H > 3 and w > 1 required)!";
                z = false;
            }
        }
        if (!z) {
            throw new java.lang.IllegalArgumentException(str);
        }
        this.ff308a3df = utPMAGgtATGbZemZ(iArr);
        this.f955ac2e8 = WwYmJbsVvamVXFUO(iArr2);
        this.fa5f3c6a1 = xVcPlZKVYwvzMAWH(iArr3);
    }

    public static int[] UtPMAGgtATGbZemZ(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static int[] XVcPlZKVYwvzMAWH(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static void YFucAAWMjWZUglDC(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar, int i, int[] iArr, int[] iArr2, int[] iArr3) {
        p2ffd3a5dVar.me37f0136(i, iArr, iArr2, iArr3);
    }

    public int[] GetHeightOfTrees() {
        return EbzvOcTUbrFDRkFd(this.ff308a3df);
    }

    public int[] GetK() {
        return ijZmhcehYBttJOGu(this.fa5f3c6a1);
    }

    public int GetNumOfLayers() {
        return this.fa6683546;
    }

    public int[] GetWinternitzParameter() {
        return LyRazayvZdwTIDNj(this.f955ac2e8);
    }
}

