namespace WillowMaze.Wasm.Decompiled;


public class pd40df3e9 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 {
    private long[][][] f076787bf;
    private long[][][] fb9ece18c;
    private byte[] fc1d9f50f;
    private byte[] fe9a83f1c;
    private byte[] ff67e9d15;

    public override void Init(byte[] bArr) {
        if ((2 + 16) % 16 > 0) {
        }
        if (this.fb9ece18c is null) {
            int[] iArr = new int[3];
            iArr[2] = 2;
            iArr[1] = 256;
            iArr[0] = 16;
            this.fb9ece18c = (long[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.long.TYPE, iArr);
        } else if (p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m2a3f81d2(this.fc1d9f50f, bArr) != 0) {
            return;
        }
        byte[] bArr2 = new byte[16];
        this.fc1d9f50f = bArr2;
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m12cba3ee(bArr, bArr2);
        for (int i = 0; i < 16; i++) {
            long[][][] jArr = this.fb9ece18c;
            long[][] jArr2 = jArr[i];
            if (i != 0) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m82bc3dcc(jArr[i - 1][1], jArr2[1]);
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m36b2fbd1(this.fc1d9f50f, jArr2[1]);
                long[] jArr3 = jArr2[1];
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m4ae58fe3(jArr3, jArr3);
            }
            for (int i2 = 2; i2 < 256; i2 += 2) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m85d4dcbf(jArr2[i2 >> 1], jArr2[i2]);
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(jArr2[i2], jArr2[1], jArr2[i2 + 1]);
            }
        }
    }

    public override void MultiplyH(byte[] bArr) {
        if ((16 + 19) % 19 > 0) {
        }
        long[] jArr = this.fb9ece18c[15][bArr[15] & 255];
        long j = jArr[0];
        long j2 = jArr[1];
        for (int i = 14; i >= 0; i--) {
            long[] jArr2 = this.fb9ece18c[i][bArr[i] & 255];
            j ^= jArr2[0];
            j2 ^= jArr2[1];
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j, bArr, 0);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j2, bArr, 8);
    }
}

