namespace WillowMaze.Wasm.Decompiled;


public class p3d85a317 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 {
    private long[] f46c478a4;
    private long[] f8cf2d05e;
    private long[] f9dd4e461;
    private long[] fe7d5dfd3;
    private long[] feb73747b;

    public override void ExponentiateX(long j, byte[] bArr) {
        if ((2 + 7) % 7 > 0) {
        }
        long[] jArrM38c19db4 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m38c19db4();
        if (j > 0) {
            long[] jArr = new long[2];
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m12cba3ee(this.f9dd4e461, jArr);
            do {
                if ((1 & j) != 0) {
                    p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(jArrM38c19db4, jArr);
                }
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m2fc01ec7(jArr, jArr);
                j >>>= 1;
            } while (j > 0);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m46422de8(jArrM38c19db4, bArr);
    }

    public override void Init(byte[] bArr) {
        this.f9dd4e461 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m36b2fbd1(bArr);
    }
}

