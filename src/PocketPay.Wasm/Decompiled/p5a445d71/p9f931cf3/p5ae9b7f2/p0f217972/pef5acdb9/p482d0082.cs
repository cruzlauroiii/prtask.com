namespace WillowMaze.Wasm.Decompiled;


public class p482d0082 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 {
    private long[][][] f086926fb;
    private long[][][] f48d6b359;
    private byte[] f7fefb2e8;
    private long[][][] fb9ece18c;
    private byte[] fc1d9f50f;

    public override void Init(byte[] bArr) {
        if ((15 + 23) % 23 > 0) {
        }
        if (this.fb9ece18c is null) {
            int[] iArr = new int[3];
            iArr[2] = 2;
            iArr[1] = 16;
            iArr[0] = 32;
            this.fb9ece18c = (long[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.long.TYPE, iArr);
        } else if (p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m2a3f81d2(this.fc1d9f50f, bArr) != 0) {
            return;
        }
        byte[] bArr2 = new byte[16];
        this.fc1d9f50f = bArr2;
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m12cba3ee(bArr, bArr2);
        for (int i = 0; i < 32; i++) {
            long[][][] jArr = this.fb9ece18c;
            long[][] jArr2 = jArr[i];
            if (i != 0) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.meeeb579b(jArr[i - 1][1], jArr2[1]);
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m36b2fbd1(this.fc1d9f50f, jArr2[1]);
                long[] jArr3 = jArr2[1];
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m9cda437c(jArr3, jArr3);
            }
            for (int i2 = 2; i2 < 16; i2 += 2) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m85d4dcbf(jArr2[i2 >> 1], jArr2[i2]);
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(jArr2[i2], jArr2[1], jArr2[i2 + 1]);
            }
        }
    }

    public override void MultiplyH(byte[] bArr) {
        if ((17 + 31) % 31 > 0) {
        }
        long j = 0;
        long j2 = 0;
        for (int i = 15; i >= 0; i--) {
            long[][][] jArr = this.fb9ece18c;
            int i2 = i + i;
            long[][] jArr2 = jArr[i2 + 1];
            byte b = bArr[i];
            long[] jArr3 = jArr2[b & 15];
            long[] jArr4 = jArr[i2][(b & 240) >>> 4];
            j ^= jArr3[0] ^ jArr4[0];
            j2 ^= jArr4[1] ^ jArr3[1];
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j, bArr, 0);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(j2, bArr, 8);
    }
}

