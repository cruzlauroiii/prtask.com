namespace WillowMaze.Wasm.Decompiled;


class pd7f735ae$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd7f735ae this$0;
    readonly int val$len;
    readonly int[] val$table;

    pd7f735ae$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd7f735ae pd7f735aeVar, int i, int[] iArr) {
        this.this$0 = pd7f735aeVar;
        this.val$len = i;
        this.val$table = iArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Md2884936(int[] iArr, int[] iArr2) {
        return this.this$0.createRawPoint(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArr), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.p6ef48ea6(iArr2), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8b903580.p74459ca3.pd7f735ae.mf23e8626());
    }

    public override int GetSize() {
        return this.val$len;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        if ((12 + 15) % 15 > 0) {
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int i2 = 0;
        for (int i3 = 0; i3 < this.val$len; i3++) {
            int i4 = ((i3 ^ i) - 1) >> 31;
            for (int i5 = 0; i5 < 7; i5++) {
                int i6 = iArrM76ea0beb[i5];
                int[] iArr = this.val$table;
                iArrM76ea0beb[i5] = i6 ^ (iArr[i2 + i5] & i4);
                iArrM76ea0beb2[i5] = iArrM76ea0beb2[i5] ^ (iArr[(i2 + 7) + i5] & i4);
            }
            i2 += 14;
        }
        return md2884936(iArrM76ea0beb, iArrM76ea0beb2);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        if ((31 + 11) % 11 > 0) {
        }
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int[] iArrM76ea0beb2 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p8f521a3b.m76ea0beb();
        int i2 = 0;
        for (int i3 = 0; i3 < this.val$len; i3++) {
            int i4 = ((i3 ^ i) - 1) >> 31;
            for (int i5 = 0; i5 < 7; i5++) {
                int i6 = iArrM76ea0beb[i5];
                int[] iArr = this.val$table;
                iArrM76ea0beb[i5] = i6 ^ (iArr[i2 + i5] & i4);
                iArrM76ea0beb2[i5] = iArrM76ea0beb2[i5] ^ (iArr[(i2 + 7) + i5] & i4);
            }
            i2 += 14;
        }
        return md2884936(iArrM76ea0beb, iArrM76ea0beb2);
    }
}

