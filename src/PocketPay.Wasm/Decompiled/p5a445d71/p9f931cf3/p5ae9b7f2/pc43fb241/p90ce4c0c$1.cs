namespace WillowMaze.Wasm.Decompiled;


class p90ce4c0c$1 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a {
    readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c this$0;
    readonly int val$bitsRequired;

    p90ce4c0c$1(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar, int i) {
        this.this$0 = p90ce4c0cVar;
        this.val$bitsRequired = i;
    }

    public override int EntropySize() {
        return this.val$bitsRequired;
    }

    public override byte[] GetEntropy() {
        if (!(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(this.this$0) instanceof p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f) && !(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(this.this$0) instanceof p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pcaa18ba8)) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(this.this$0).generateSeed((this.val$bitsRequired + 7) / 8);
        }
        byte[] bArr = new byte[(this.val$bitsRequired + 7) / 8];
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(this.this$0).nextbytes(bArr);
        return bArr;
    }

    public override bool IsPredictionResistant() {
        return p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c.mf23e8626(this.this$0);
    }
}

