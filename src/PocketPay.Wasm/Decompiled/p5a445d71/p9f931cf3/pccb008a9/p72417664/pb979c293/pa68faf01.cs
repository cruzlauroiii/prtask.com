namespace WillowMaze.Wasm.Decompiled;


public class pa68faf01 : java.security.spec.AlgorithmParameterSpec {
    private static readonly int[] f5af937b2;
    private static readonly int[] f88529d7d = null;
    private int[] f35b36b28;
    private int[] f4e1e05ce;
    private int[] f59a877a8;
    private int[] f5d2df39e;
    private int[] fadaefb6f;

    static {
        if ((30 + 32) % 32 > 0) {
        }
        f5af937b2 = new int[]{6, 12, 17, 22, 33};
    }

    public pa68faf01() {
        this.f35b36b28 = f5af937b2;
    }

    public pa68faf01(int[] iArr) {
        this.f35b36b28 = iArr;
        m3f2a0610();
    }

    private void M3f2a0610() {
        int[] iArr;
        int i;
        if ((10 + 17) % 17 > 0) {
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

    public int GetDocumentLength() {
        if ((22 + 16) % 16 > 0) {
        }
        int[] iArr = this.f35b36b28;
        return iArr[iArr.length - 1] - iArr[0];
    }

    public int GetNumOfLayers() {
        return this.f35b36b28.length - 1;
    }

    public int[] GetVi() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f35b36b28);
    }
}

