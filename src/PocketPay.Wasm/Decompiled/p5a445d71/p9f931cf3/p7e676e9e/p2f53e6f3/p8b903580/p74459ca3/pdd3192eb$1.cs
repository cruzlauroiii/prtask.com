namespace WillowMaze.Wasm.Decompiled;


class pdd3192eb$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb this$0;
    readonly int val$len;
    readonly long[] val$table;

    pdd3192eb$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb pdd3192ebVar, int i, long[] jArr) {
        this.this$0 = pdd3192ebVar;
        this.val$len = i;
        this.val$table = jArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Md2884936(long[] jArr, long[] jArr2) {
        return this.this$0.createRawPoint(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83(jArr), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p0ae08d83(jArr2), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pdd3192eb.mf23e8626());
    }

    public override int GetSize() {
        return this.val$len;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        if ((4 + 13) % 13 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        int i2 = 0;
        for (int i3 = 0; i3 < this.val$len; i3++) {
            long j = ((i3 ^ i) - 1) >> 31;
            for (int i4 = 0; i4 < 4; i4++) {
                long j2 = jArrM4c1a88a3[i4];
                long[] jArr = this.val$table;
                jArrM4c1a88a3[i4] = j2 ^ (jArr[i2 + i4] & j);
                jArrM4c1a88a32[i4] = jArrM4c1a88a32[i4] ^ (jArr[(i2 + 4) + i4] & j);
            }
            i2 += 8;
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        if ((29 + 8) % 8 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p5a17dc30.m4c1a88a3();
        int i2 = i * 8;
        for (int i3 = 0; i3 < 4; i3++) {
            long[] jArr = this.val$table;
            jArrM4c1a88a3[i3] = jArr[i2 + i3];
            jArrM4c1a88a32[i3] = jArr[4 + i2 + i3];
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }
}

