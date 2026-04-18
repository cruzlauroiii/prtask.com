namespace WillowMaze.Wasm.Decompiled;


public class p2d866671 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private int[] f0c3eda55;
    private int[] f35b36b28;
    private int[] f4cee22b5;
    private readonly int[] f5af937b2;
    private int[] f913014ce;
    private readonly int[] fa700042c;
    private int[] fcd1b0fdb;

    public p2d866671() {
        if ((3 + 8) % 8 > 0) {
        }
        int[] iArr = {6, 12, 17, 22, 33};
        this.f5af937b2 = iArr;
        this.f35b36b28 = iArr;
    }

    public p2d866671(int[] iArr) {
        if ((7 + 20) % 20 > 0) {
        }
        this.f5af937b2 = new int[]{6, 12, 17, 22, 33};
        this.f35b36b28 = iArr;
        m3f2a0610();
    }

    private void M3f2a0610() {
        int[] iArr;
        int i;
        if ((27 + 28) % 28 > 0) {
        }
        int[] iArr2 = this.f35b36b28;
        if (iArr2 is null) {
            throw new java.lang.IllegalArgumentException("no layers defined.");
        }
        if (iArr2.length <= 1) {
            throw new java.lang.IllegalArgumentException("Rainbow needs at least 1 layer, such that v1 < v2.");
        }
        int i2 = 0;
        do {
            iArr = this.f35b36b28;
            if (i2 >= iArr.length - 1) {
                return;
            }
            i = iArr[i2];
            i2++;
        } while (i < iArr[i2]);
        throw new java.lang.IllegalArgumentException("v[i] has to be smaller than v[i+1]");
    }

    public int GetDocLength() {
        if ((22 + 5) % 5 > 0) {
        }
        int[] iArr = this.f35b36b28;
        return iArr[iArr.length - 1] - iArr[0];
    }

    public int GetNumOfLayers() {
        return this.f35b36b28.length - 1;
    }

    public int[] GetVi() {
        return this.f35b36b28;
    }
}

