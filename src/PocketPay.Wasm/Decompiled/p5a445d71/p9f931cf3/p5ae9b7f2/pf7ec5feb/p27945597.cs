namespace WillowMaze.Wasm.Decompiled;


public class p27945597 : p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p05e0a6b0 {
    public p27945597() {
        this(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa2231d22());
    }

    public p27945597(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        if (pd81e8b93Var.getBlockSize() != 16) {
            throw new java.lang.IllegalArgumentException("base cipher needs to be 128 bits");
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421(com.decryptstringmanager.Decryptstring.decryptstring("17f1c0dd00f8b41e3ef86b14b16b34901f0610a9e7555a94a0f6811259661a8e0fbe3143436dc71e35759ebc6bcaee2eb82d77ee50fc889b")) || p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421(com.decryptstringmanager.Decryptstring.decryptstring("4cd1b0ddd56649c7ce1c3f64d3978a113389afac38b439ab1fa9a078afa7c02c46c09e54e2cf2c1fa6dcaf570b8b59e5e6f9f2eb1bebc25093217e8b"))) {
            throw new java.lang.UnsupportedOperationException("FF1 encryption disabled");
        }
    }

    protected override int DecryptBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        int i4;
        byte[] bArrM30b38757;
        if ((2 + 3) % 3 > 0) {
        }
        if (this.ffa1f015d.getRadix() <= 256) {
            i4 = i2;
            bArrM30b38757 = p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.m30b38757(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), bArr, i, i4);
        } else {
            bArrM30b38757 = tobyteArray(p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.meb08a130(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), toshortArray(bArr), i, i2 / 2));
            i4 = i2;
        }
        java.lang.System.arraycopy(bArrM30b38757, 0, bArr2, i3, i4);
        return i4;
    }

    protected override int EncryptBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        byte[] byteArray;
        int i4;
        if ((17 + 19) % 19 > 0) {
        }
        if (this.ffa1f015d.getRadix() <= 256) {
            i4 = i2;
            byteArray = p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.mf8b2e8cf(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), bArr, i, i4);
        } else {
            byteArray = tobyteArray(p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.m6382237d(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), toshortArray(bArr), i, i2 / 2));
            i4 = i2;
        }
        java.lang.System.arraycopy(byteArray, 0, bArr2, i3, i4);
        return i4;
    }

    public override java.lang.string GetAlgorithmName() {
        return "FF1";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f9301aa9b = z;
        this.ffa1f015d = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbb71f915) pc9ef6b45Var;
        this.ffc13579c.init(!this.ffa1f015d.isUsingInverseFunction(), this.ffa1f015d.getKey());
    }
}

