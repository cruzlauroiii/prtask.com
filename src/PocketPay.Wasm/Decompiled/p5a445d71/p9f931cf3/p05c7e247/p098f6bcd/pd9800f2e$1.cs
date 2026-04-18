namespace WillowMaze.Wasm.Decompiled;


class pd9800f2e$1 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a {
    readonly p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e this$0;
    readonly int val$bitsRequired;

    pd9800f2e$1(p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e pd9800f2eVar, int i) {
        this.this$0 = pd9800f2eVar;
        this.val$bitsRequired = i;
    }

    public override int EntropySize() {
        return this.val$bitsRequired;
    }

    public override byte[] GetEntropy() {
        byte[] bArr = new byte[(this.val$bitsRequired + 7) / 8];
        p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e.mf8f67da7(this.this$0).nextbytes(bArr);
        return bArr;
    }

    public override bool IsPredictionResistant() {
        return p5a445d71.p9f931cf3.p05c7e247.p098f6bcd.pd9800f2e.mf23e8626(this.this$0);
    }
}

