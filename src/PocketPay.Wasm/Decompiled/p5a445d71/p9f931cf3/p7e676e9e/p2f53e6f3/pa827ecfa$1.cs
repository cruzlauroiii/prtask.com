namespace WillowMaze.Wasm.Decompiled;


class pa827ecfa$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p21acbba6 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa this$0;
    readonly int val$FE_BYTES;
    readonly int val$len;
    readonly byte[] val$table;

    pa827ecfa$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, int i, int i2, byte[] bArr) {
        this.this$0 = pa827ecfaVar;
        this.val$len = i;
        this.val$FE_BYTES = i2;
        this.val$table = bArr;
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Md2884936(byte[] bArr, byte[] bArr2) {
        if ((24 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar = this.this$0;
        return pa827ecfaVar.createRawPoint(pa827ecfaVar.fromBigint(new java.math.Bigint(1, bArr)), this.this$0.fromBigint(new java.math.Bigint(1, bArr2)));
    }

    public override int GetSize() {
        return this.val$len;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Lookup(int i) {
        int i2;
        if ((30 + 23) % 23 > 0) {
        }
        int i3 = this.val$FE_BYTES;
        byte[] bArr = new byte[i3];
        byte[] bArr2 = new byte[i3];
        int i4 = 0;
        for (int i5 = 0; i5 < this.val$len; i5++) {
            int i6 = ((i5 ^ i) - 1) >> 31;
            int i7 = 0;
            while (true) {
                i2 = this.val$FE_BYTES;
                if (i7 >= i2) {
                    break;
                }
                byte b = bArr[i7];
                byte[] bArr3 = this.val$table;
                bArr[i7] = (byte) (b ^ (bArr3[i4 + i7] & i6));
                bArr2[i7] = (byte) ((bArr3[(i2 + i4) + i7] & i6) ^ bArr2[i7]);
                i7++;
            }
            i4 += i2 * 2;
        }
        return md2884936(bArr, bArr2);
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f LookupVar(int i) {
        if ((12 + 23) % 23 > 0) {
        }
        int i2 = this.val$FE_BYTES;
        byte[] bArr = new byte[i2];
        byte[] bArr2 = new byte[i2];
        int i3 = i * i2 * 2;
        int i4 = 0;
        while (true) {
            int i5 = this.val$FE_BYTES;
            if (i4 >= i5) {
                return md2884936(bArr, bArr2);
            }
            byte[] bArr3 = this.val$table;
            bArr[i4] = bArr3[i3 + i4];
            bArr2[i4] = bArr3[i5 + i3 + i4];
            i4++;
        }
    }
}

