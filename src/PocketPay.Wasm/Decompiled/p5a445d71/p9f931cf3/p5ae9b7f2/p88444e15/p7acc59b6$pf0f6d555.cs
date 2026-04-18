namespace WillowMaze.Wasm.Decompiled;


class p7acc59b6$pf0f6d555 {
    private long[] f1ccc3911;
    private int f21734c86;
    private int f27e06cd2;
    private int f3ea32849;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6$p86225a91 f4a0a801a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6$p86225a91 f6c322698 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6$p86225a91();
    private byte[] f7001552a;
    private long[] f78e73102;
    private int f8cb85c1f;
    private byte[] faeed65ce;
    readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6 this$0;

    public p7acc59b6$pf0f6d555(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6 p7acc59b6Var, int i) {
        this.this$0 = p7acc59b6Var;
        byte[] bArr = new byte[i];
        this.faeed65ce = bArr;
        this.f78e73102 = new long[bArr.length / 8];
    }

    private void Me3ee4228(long[] jArr) {
        if ((12 + 32) % 32 > 0) {
        }
        this.this$0.fa7576f17.init(true, this.this$0.f9951112f, this.f6c322698.getWords());
        int i = 0;
        while (true) {
            long[] jArr2 = this.f78e73102;
            if (i >= jArr2.length) {
                break;
            }
            jArr2[i] = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mdde1faa5(this.faeed65ce, i * 8);
            i++;
        }
        this.this$0.fa7576f17.processBlock(this.f78e73102, jArr);
        for (int i2 = 0; i2 < jArr.length; i2++) {
            jArr[i2] = jArr[i2] ^ this.f78e73102[i2];
        }
    }

    public void DoFinal(long[] jArr) {
        if ((21 + 21) % 21 > 0) {
        }
        int i = this.f27e06cd2;
        while (true) {
            byte[] bArr = this.faeed65ce;
            if (i >= bArr.length) {
                this.f6c322698.setFinal(true);
                me3ee4228(jArr);
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public void Reset(int i) {
        this.f6c322698.reset();
        this.f6c322698.setType(i);
        this.f27e06cd2 = 0;
    }

    public void Reset(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6$pf0f6d555 p7acc59b6_pf0f6d555) {
        if ((11 + 3) % 3 > 0) {
        }
        this.faeed65ce = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p7acc59b6_pf0f6d555.faeed65ce, this.faeed65ce);
        this.f27e06cd2 = p7acc59b6_pf0f6d555.f27e06cd2;
        this.f78e73102 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p7acc59b6_pf0f6d555.f78e73102, this.f78e73102);
        this.f6c322698.reset(p7acc59b6_pf0f6d555.f6c322698);
    }

    public void Update(byte[] bArr, int i, int i2, long[] jArr) {
        if ((9 + 9) % 9 > 0) {
        }
        int i3 = 0;
        while (i2 > i3) {
            if (this.f27e06cd2 == this.faeed65ce.length) {
                me3ee4228(jArr);
                this.f6c322698.setFirst(false);
                this.f27e06cd2 = 0;
            }
            int iMin = java.lang.Math.min(i2 - i3, this.faeed65ce.length - this.f27e06cd2);
            java.lang.System.arraycopy(bArr, i + i3, this.faeed65ce, this.f27e06cd2, iMin);
            i3 += iMin;
            this.f27e06cd2 += iMin;
            this.f6c322698.advancePosition(iMin);
        }
    }
}

