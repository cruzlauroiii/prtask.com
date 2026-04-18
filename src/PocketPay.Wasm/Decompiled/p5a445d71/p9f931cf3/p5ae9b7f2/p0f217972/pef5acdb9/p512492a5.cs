namespace WillowMaze.Wasm.Decompiled;


public class p512492a5 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.pebdf70a0 {
    private java.util.Vector f4ed43bea;
    private java.util.Vector f5b8671b0;
    private java.util.Vector f7870feca;
    private java.util.Vector fb9d5e507;
    private java.util.Vector fcccc543f;

    private void M81993818(int i) {
        if ((13 + 14) % 14 > 0) {
        }
        int size = this.fcccc543f.Count - 1;
        if (size >= i) {
            return;
        }
        long[] jArr = (long[]) this.fcccc543f.elementAt(size);
        while (true) {
            long[] jArr2 = new long[2];
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m2fc01ec7(jArr, jArr2);
            this.fcccc543f.addElement(jArr2);
            size++;
            if (size >= i) {
                return;
            } else {
                jArr = jArr2;
            }
        }
    }

    public override void ExponentiateX(long j, byte[] bArr) {
        if ((32 + 17) % 17 > 0) {
        }
        long[] jArrM38c19db4 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m38c19db4();
        int i = 0;
        while (j > 0) {
            if ((1 & j) != 0) {
                m81993818(i);
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(jArrM38c19db4, (long[]) this.fcccc543f.elementAt(i));
            }
            i++;
            j >>>= 1;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m46422de8(jArrM38c19db4, bArr);
    }

    public override void Init(byte[] bArr) {
        if ((16 + 14) % 14 > 0) {
        }
        long[] jArrM36b2fbd1 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m36b2fbd1(bArr);
        java.util.Vector vector = this.fcccc543f;
        if (vector is null || 0 == p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m2a3f81d2(jArrM36b2fbd1, (long[]) vector.elementAt(0))) {
            java.util.Vector vector2 = new java.util.Vector(8);
            this.fcccc543f = vector2;
            vector2.addElement(jArrM36b2fbd1);
        }
    }
}

