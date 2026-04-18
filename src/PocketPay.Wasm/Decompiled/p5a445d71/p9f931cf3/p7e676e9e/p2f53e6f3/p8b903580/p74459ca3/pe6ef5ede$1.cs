namespace WillowMaze.Wasm.Decompiled;


class pe6ef5ede$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe6ef5ede this$0;
    readonly int val$len;
    readonly long[] val$table;

    pe6ef5ede$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe6ef5ede pe6ef5edeVar, int i, long[] jArr) {
        this.this$0 = pe6ef5edeVar;
        this.val$len = i;
        this.val$table = jArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Md2884936(long[] jArr, long[] jArr2) {
        return this.this$0.createRawPoint(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565(jArr), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p1e82f565(jArr2), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe6ef5ede.mf23e8626());
    }

    public override int GetSize() {
        return this.val$len;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        if ((27 + 25) % 25 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        int i2 = 0;
        for (int i3 = 0; i3 < this.val$len; i3++) {
            long j = ((i3 ^ i) - 1) >> 31;
            for (int i4 = 0; i4 < 3; i4++) {
                long j2 = jArrM4c1a88a3[i4];
                long[] jArr = this.val$table;
                jArrM4c1a88a3[i4] = j2 ^ (jArr[i2 + i4] & j);
                jArrM4c1a88a32[i4] = jArrM4c1a88a32[i4] ^ (jArr[(i2 + 3) + i4] & j);
            }
            i2 += 6;
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        if ((5 + 19) % 19 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p065312dc.m4c1a88a3();
        int i2 = i * 6;
        for (int i3 = 0; i3 < 3; i3++) {
            long[] jArr = this.val$table;
            jArrM4c1a88a3[i3] = jArr[i2 + i3];
            jArrM4c1a88a32[i3] = jArr[3 + i2 + i3];
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }
}

