namespace WillowMaze.Wasm.Decompiled;


class pe7a9c849$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe7a9c849 this$0;
    readonly int val$len;
    readonly long[] val$table;

    pe7a9c849$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe7a9c849 pe7a9c849Var, int i, long[] jArr) {
        this.this$0 = pe7a9c849Var;
        this.val$len = i;
        this.val$table = jArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Md2884936(long[] jArr, long[] jArr2) {
        return this.this$0.createRawPoint(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcfa73bff(jArr), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pcfa73bff(jArr2), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pe7a9c849.mf23e8626());
    }

    public override int GetSize() {
        return this.val$len;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        if ((1 + 4) % 4 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p65350c36.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p65350c36.m4c1a88a3();
        int i2 = 0;
        for (int i3 = 0; i3 < this.val$len; i3++) {
            long j = ((i3 ^ i) - 1) >> 31;
            for (int i4 = 0; i4 < 7; i4++) {
                long j2 = jArrM4c1a88a3[i4];
                long[] jArr = this.val$table;
                jArrM4c1a88a3[i4] = j2 ^ (jArr[i2 + i4] & j);
                jArrM4c1a88a32[i4] = jArrM4c1a88a32[i4] ^ (jArr[(i2 + 7) + i4] & j);
            }
            i2 += 14;
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        if ((30 + 22) % 22 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p65350c36.m4c1a88a3();
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p65350c36.m4c1a88a3();
        int i2 = i * 14;
        for (int i3 = 0; i3 < 7; i3++) {
            long[] jArr = this.val$table;
            jArrM4c1a88a3[i3] = jArr[i2 + i3];
            jArrM4c1a88a32[i3] = jArr[7 + i2 + i3];
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }
}

