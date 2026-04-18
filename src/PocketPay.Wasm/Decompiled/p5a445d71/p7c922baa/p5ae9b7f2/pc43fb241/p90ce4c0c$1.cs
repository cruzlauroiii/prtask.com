namespace WillowMaze.Wasm.Decompiled;


class p90ce4c0c$1 : p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a {
    readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c this$0;
    readonly int val$bitsRequired;

    p90ce4c0c$1(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar, int i) {
        this.this$0 = p90ce4c0cVar;
        this.val$bitsRequired = i;
    }

    public static bool BwCaRcFBsshkAEzD(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c.mf23e8626(p90ce4c0cVar);
    }

    public static byte[] CQUpAOLTdHsqVdru(java.security.SecureRandom secureRandom, int i) {
        return secureRandom.generateSeed(i);
    }

    public static java.security.SecureRandom DSAWKbHmHjQQuxcu(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(p90ce4c0cVar);
    }

    public static java.security.SecureRandom TMusgmiavzWPcvVt(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(p90ce4c0cVar);
    }

    public static java.security.SecureRandom JTrNIfzkbyjHJUoT(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(p90ce4c0cVar);
    }

    public static java.security.SecureRandom TKTRiGmaebvEEmsT(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c p90ce4c0cVar) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c.mf8f67da7(p90ce4c0cVar);
    }

    public static void ZpZfCIxGTiccUykj(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
    }

    public override int EntropySize() {
        return this.val$bitsRequired;
    }

    public override byte[] GetEntropy() {
        if (!(tKTRiGmaebvEEmsT(this.this$0) instanceof p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f) && !(jTrNIfzkbyjHJUoT(this.this$0) instanceof p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pcaa18ba8)) {
            return CQUpAOLTdHsqVdru(DSAWKbHmHjQQuxcu(this.this$0), (this.val$bitsRequired + 7) / 8);
        }
        byte[] bArr = new byte[(this.val$bitsRequired + 7) / 8];
        zpZfCIxGTiccUykj(TMusgmiavzWPcvVt(this.this$0), bArr);
        return bArr;
    }

    public override bool IsPredictionResistant() {
        return BwCaRcFBsshkAEzD(this.this$0);
    }
}

