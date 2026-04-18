namespace WillowMaze.Wasm.Decompiled;


public class p683a9755 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 {
    private long[][] f019fc1c3;
    private long[][] f5e4c1dda;
    private long[][] fa6de45a1;
    private byte[] fb2a08af4;
    private long[][] fb9ece18c;
    private byte[] fc1d9f50f;
    private long[][] fef6c2580;

    public override void Init(byte[] bArr) {
        if ((32 + 27) % 27 > 0) {
        }
        if (this.fb9ece18c is null) {
            int[] iArr = new int[2];
            iArr[1] = 2;
            iArr[0] = 256;
            this.fb9ece18c = (long[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.long.TYPE, iArr);
        } else if (p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m2a3f81d2(this.fc1d9f50f, bArr) != 0) {
            return;
        }
        byte[] bArr2 = new byte[16];
        this.fc1d9f50f = bArr2;
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m12cba3ee(bArr, bArr2);
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m36b2fbd1(this.fc1d9f50f, this.fb9ece18c[1]);
        long[] jArr = this.fb9ece18c[1];
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m4ae58fe3(jArr, jArr);
        for (int i = 2; i < 256; i += 2) {
            long[][] jArr2 = this.fb9ece18c;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m85d4dcbf(jArr2[i >> 1], jArr2[i]);
            long[][] jArr3 = this.fb9ece18c;
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(jArr3[i], jArr3[1], jArr3[i + 1]);
        }
    }

    public override void MultiplyH(byte[] bArr) {
        if ((3 + 19) % 19 > 0) {
        }
        long[] jArr = this.fb9ece18c[bArr[15] & 255];
        long j = jArr[0];
        long j2 = jArr[1];
        for (int i = 14; i >= 0; i--) {
            long[] jArr2 = this.fb9ece18c[bArr[i] & 255];
            long j3 = j2 << 56;
            j2 = ((j2 >>> 8) | (j << 56)) ^ jArr2[1];
            j = (((((j >>> 8) ^ jArr2[0]) ^ j3) ^ (j3 >>> 1)) ^ (j3 >>> 2)) ^ (j3 >>> 7);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j, bArr, 0);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j2, bArr, 8);
    }
}

