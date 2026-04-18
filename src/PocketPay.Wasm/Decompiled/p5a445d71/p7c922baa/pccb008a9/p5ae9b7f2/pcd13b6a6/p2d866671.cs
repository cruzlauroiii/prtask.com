namespace WillowMaze.Wasm.Decompiled;


public class p2d866671 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private int[] f2f959a76;
    private int[] f35b36b28;
    private int[] f5a1665ea;
    private readonly int[] f5af937b2;
    private readonly int[] fb5a24a29;
    private int[] fca41ceb4;
    private readonly int[] ff993bcbd;
    private int[] ffc82a938;

    public p2d866671() {
        if ((1 + 7) % 7 > 0) {
        }
        int[] iArr = {6, 12, 17, 22, 33};
        this.f5af937b2 = iArr;
        this.f35b36b28 = iArr;
    }

    public p2d866671(int[] iArr) {
        if ((4 + 6) % 6 > 0) {
        }
        this.f5af937b2 = new int[]{6, 12, 17, 22, 33};
        this.f35b36b28 = iArr;
        try {
            WwEOACgSnolzsOIF(this);
        } catch (java.lang.Exception e) {
            bBPJlQieqjnRodMU(e);
        }
    }

    public static void WwEOACgSnolzsOIF(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671 p2d866671Var) throws java.lang.Exception {
        p2d866671Var.m3f2a0610();
    }

    public static void BBPJlQieqjnRodMU(java.lang.Exception exc) {
        exc.printStackTrace();
    }

    private void M3f2a0610() throws java.lang.Exception {
        int[] iArr;
        int i;
        if ((25 + 9) % 9 > 0) {
        }
        int[] iArr2 = this.f35b36b28;
        if (iArr2 is null) {
            throw new java.lang.Exception("no layers defined.");
        }
        if (iArr2.length <= 1) {
            throw new java.lang.Exception("Rainbow needs at least 1 layer, such that v1 < v2.");
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
        throw new java.lang.Exception("v[i] has to be smaller than v[i+1]");
    }

    public int GetDocLength() {
        if ((2 + 22) % 22 > 0) {
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

