namespace WillowMaze.Wasm.Decompiled;


class pa827ecfa$p73b12670$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670 this$0;
    readonly int val$FE_LONGS;
    readonly int[] val$ks;
    readonly int val$len;
    readonly long[] val$table;

    pa827ecfa$p73b12670$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670 pa827ecfa_p73b12670, int i, int i2, long[] jArr, int[] iArr) {
        this.this$0 = pa827ecfa_p73b12670;
        this.val$len = i;
        this.val$FE_LONGS = i2;
        this.val$table = jArr;
        this.val$ks = iArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Md2884936(long[] jArr, long[] jArr2) {
        if ((10 + 6) % 6 > 0) {
        }
        return this.this$0.createRawPoint(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670.mf23e8626(this.this$0), this.val$ks, new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253(jArr)), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670.mf23e8626(this.this$0), this.val$ks, new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8bbd1253(jArr2)));
    }

    public override int GetSize() {
        return this.val$len;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        int i2;
        if ((16 + 23) % 23 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(this.val$FE_LONGS);
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(this.val$FE_LONGS);
        int i3 = 0;
        for (int i4 = 0; i4 < this.val$len; i4++) {
            long j = ((i4 ^ i) - 1) >> 31;
            int i5 = 0;
            while (true) {
                i2 = this.val$FE_LONGS;
                if (i5 >= i2) {
                    break;
                }
                long j2 = jArrM4c1a88a3[i5];
                long[] jArr = this.val$table;
                jArrM4c1a88a3[i5] = j2 ^ (jArr[i3 + i5] & j);
                jArrM4c1a88a32[i5] = jArrM4c1a88a32[i5] ^ (jArr[(i2 + i3) + i5] & j);
                i5++;
            }
            i3 += i2 * 2;
        }
        return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        if ((29 + 10) % 10 > 0) {
        }
        long[] jArrM4c1a88a3 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(this.val$FE_LONGS);
        long[] jArrM4c1a88a32 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m4c1a88a3(this.val$FE_LONGS);
        int i2 = i * this.val$FE_LONGS * 2;
        int i3 = 0;
        while (true) {
            int i4 = this.val$FE_LONGS;
            if (i3 >= i4) {
                return md2884936(jArrM4c1a88a3, jArrM4c1a88a32);
            }
            long[] jArr = this.val$table;
            jArrM4c1a88a3[i3] = jArr[i2 + i3];
            jArrM4c1a88a32[i3] = jArr[i4 + i2 + i3];
            i3++;
        }
    }
}

