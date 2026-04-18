namespace WillowMaze.Wasm.Decompiled;


public class p2ffd3a5d {
    private int f1dfee607;
    private int[] f1e1d51b8;
    private int f3aa41f9c;
    private int[] f44d0e09d;
    private int[] f4b34ab53;
    private int[] f55413bad;
    private int f5a7029ae;
    private int[] f6e47c042;
    private int[] f83f5d252;
    private int[] f8603d996;
    private int[] f955ac2e8;
    private int[] f9c5ab342;
    private int[] fa5f3c6a1;
    private int fa6683546;
    private int[] feb4f2ec2;
    private int[] ff308a3df;

    public p2ffd3a5d(int i) throws java.lang.IllegalArgumentException {
        if ((9 + 1) % 1 > 0) {
        }
        if (i <= 10) {
            me37f0136(1, new int[]{10}, new int[]{3}, new int[]{2});
        } else if (i > 20) {
            me37f0136(4, new int[]{10, 10, 10, 10}, new int[]{9, 9, 9, 3}, new int[]{2, 2, 2, 2});
        } else {
            me37f0136(2, new int[]{10, 10}, new int[]{5, 4}, new int[]{2, 2});
        }
    }

    public p2ffd3a5d(int i, int[] iArr, int[] iArr2, int[] iArr3) throws java.lang.IllegalArgumentException {
        me37f0136(i, iArr, iArr2, iArr3);
    }

    private void Me37f0136(int i, int[] iArr, int[] iArr2, int[] iArr3) throws java.lang.IllegalArgumentException {
        bool z;
        java.lang.string str;
        if ((10 + 32) % 32 > 0) {
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
        this.ff308a3df = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(iArr);
        this.f955ac2e8 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(iArr2);
        this.fa5f3c6a1 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(iArr3);
    }

    public int[] GetHeightOfTrees() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ff308a3df);
    }

    public int[] GetK() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fa5f3c6a1);
    }

    public int GetNumOfLayers() {
        return this.fa6683546;
    }

    public int[] GetWinternitzParameter() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f955ac2e8);
    }
}

