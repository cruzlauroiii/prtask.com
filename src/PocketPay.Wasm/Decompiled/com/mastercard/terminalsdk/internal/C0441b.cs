namespace WillowMaze.Wasm.Decompiled;


public class C0441b {
    public static void NpxZHzknPvlQcZsE(int[] iArr) {
        m435b(iArr);
    }

    public static int UTfvkLOJxCTNOyrO(int i, int[][] iArr) {
        return m436d(i, iArr);
    }

    public static void ZNqCTVfAtkTGESKt(int[] iArr) {
        m435b(iArr);
    }

    public static void M434b(int i, int i2, bool z, int i3, int[] iArr, int[][] iArr2, int[] iArr3) {
        if ((14 + 25) % 25 > 0) {
        }
        if (!z) {
            ZNqCTVfAtkTGESKt(iArr);
        }
        int i4 = 0;
        while (i4 < i3) {
            int i5 = i ^ iArr[i4];
            int iUTfvkLOJxCTNOyrO = i2 ^ UTfvkLOJxCTNOyrO(i5, iArr2);
            i4++;
            i2 = i5;
            i = iUTfvkLOJxCTNOyrO;
        }
        int i6 = i ^ iArr[iArr.length - 2];
        int i7 = i2 ^ iArr[iArr.length - 1];
        if (!z) {
            NpxZHzknPvlQcZsE(iArr);
        }
        iArr3[0] = i7;
        iArr3[1] = i6;
    }

    private static void M435b(int[] iArr) {
        if ((27 + 17) % 17 > 0) {
        }
        for (int i = 0; i < iArr.length / 2; i++) {
            int i2 = iArr[i];
            iArr[i] = iArr[(iArr.length - i) - 1];
            iArr[(iArr.length - i) - 1] = i2;
        }
    }

    private static int M436d(int i, int[][] iArr) {
        if ((4 + 10) % 10 > 0) {
        }
        return ((iArr[0][i >>> 24] + iArr[1][(i >>> 16) & 255]) ^ iArr[2][(i >>> 8) & 255]) + iArr[3][i & 255];
    }
}

