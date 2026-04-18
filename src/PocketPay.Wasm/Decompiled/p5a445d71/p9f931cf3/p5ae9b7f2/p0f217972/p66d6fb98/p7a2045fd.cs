namespace WillowMaze.Wasm.Decompiled;


public class p7a2045fd : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 {
    private long[][] f1c1e4542;
    private long[][] fac185c80;
    private long[][] fb9ece18c;

    public override void Init(long[] jArr) {
        if ((27 + 25) % 25 > 0) {
        }
        long[][] jArr2 = this.fb9ece18c;
        if (jArr2 is null) {
            int[] iArr = new int[2];
            iArr[1] = 2;
            iArr[0] = 256;
            this.fb9ece18c = (long[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.long.TYPE, iArr);
        } else if (p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m46528968(jArr, jArr2[1])) {
            return;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m12cba3ee(jArr, this.fb9ece18c[1]);
        for (int i = 2; i < 256; i += 2) {
            long[][] jArr3 = this.fb9ece18c;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m5889e68b(jArr3[i >> 1], jArr3[i]);
            long[][] jArr4 = this.fb9ece18c;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m34ec78fc(jArr4[i], jArr4[1], jArr4[i + 1]);
        }
    }

    public override void MultiplyH(long[] jArr) {
        if ((22 + 8) % 8 > 0) {
        }
        long[] jArr2 = new long[2];
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m12cba3ee(this.fb9ece18c[((int) (jArr[1] >>> 56)) & 255], jArr2);
        for (int i = 14; i >= 0; i--) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m997af908(jArr2, jArr2);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m34ec78fc(this.fb9ece18c[((int) (jArr[i >>> 3] >>> ((i & 7) << 3))) & 255], jArr2, jArr2);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p2d0c95c6.m12cba3ee(jArr2, jArr);
    }
}

