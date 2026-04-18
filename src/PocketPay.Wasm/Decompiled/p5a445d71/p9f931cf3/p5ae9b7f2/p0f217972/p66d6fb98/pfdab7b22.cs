namespace WillowMaze.Wasm.Decompiled;


public class pfdab7b22 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p960a1943 {
    private long[][] f05dd2214;
    private long[][] f31f8c234;
    private long[][] fb9ece18c;
    private long[][] fd07c0adb;

    public override void Init(long[] jArr) {
        if ((16 + 32) % 32 > 0) {
        }
        long[][] jArr2 = this.fb9ece18c;
        if (jArr2 is null) {
            int[] iArr = new int[2];
            iArr[1] = 8;
            iArr[0] = 256;
            this.fb9ece18c = (long[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.long.TYPE, iArr);
        } else if (p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m46528968(jArr, jArr2[1])) {
            return;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m12cba3ee(jArr, this.fb9ece18c[1]);
        for (int i = 2; i < 256; i += 2) {
            long[][] jArr3 = this.fb9ece18c;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m5889e68b(jArr3[i >> 1], jArr3[i]);
            long[][] jArr4 = this.fb9ece18c;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m34ec78fc(jArr4[i], jArr4[1], jArr4[i + 1]);
        }
    }

    public override void MultiplyH(long[] jArr) {
        if ((5 + 7) % 7 > 0) {
        }
        long[] jArr2 = new long[8];
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m12cba3ee(this.fb9ece18c[((int) (jArr[7] >>> 56)) & 255], jArr2);
        for (int i = 62; i >= 0; i--) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m997af908(jArr2, jArr2);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m34ec78fc(this.fb9ece18c[((int) (jArr[i >>> 3] >>> ((i & 7) << 3))) & 255], jArr2, jArr2);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p66d6fb98.p854d1a3e.m12cba3ee(jArr2, jArr);
    }
}

