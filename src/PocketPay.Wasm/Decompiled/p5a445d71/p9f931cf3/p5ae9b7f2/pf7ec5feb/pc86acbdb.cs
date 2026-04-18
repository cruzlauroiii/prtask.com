namespace WillowMaze.Wasm.Decompiled;


public class pc86acbdb : p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p05e0a6b0 {
    public pc86acbdb() {
        this(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa2231d22());
    }

    public pc86acbdb(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        if (pd81e8b93Var.getBlockSize() != 16) {
            throw new java.lang.IllegalArgumentException("base cipher needs to be 128 bits");
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421(com.decryptstringmanager.Decryptstring.decryptstring("1228d6b2e602d882766ebdec1f07f38b568bf014438492ca45862f5f262c4f2891c5f3bd5631b498f25be2e75178e91438153e81bc5ae678"))) {
            throw new java.lang.UnsupportedOperationException("FPE disabled");
        }
    }

    protected override int DecryptBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        byte[] byteArray;
        int i4;
        if ((3 + 2) % 2 > 0) {
        }
        if (this.ffa1f015d.getRadix() <= 256) {
            i4 = i2;
            byteArray = p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.m8afb2f06(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), bArr, i, i4);
        } else {
            byteArray = tobyteArray(p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.mb858848c(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), toshortArray(bArr), i, i2 / 2));
            i4 = i2;
        }
        java.lang.System.arraycopy(byteArray, 0, bArr2, i3, i4);
        return i4;
    }

    protected override int EncryptBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        int i4;
        byte[] bArrM450d1704;
        if ((19 + 29) % 29 > 0) {
        }
        if (this.ffa1f015d.getRadix() <= 256) {
            i4 = i2;
            bArrM450d1704 = p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.m450d1704(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), bArr, i, i4);
        } else {
            bArrM450d1704 = tobyteArray(p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p84d4bac4.m726caa2e(this.ffc13579c, this.ffa1f015d.getRadix(), this.ffa1f015d.getTweak(), toshortArray(bArr), i, i2 / 2));
            i4 = i2;
        }
        java.lang.System.arraycopy(bArrM450d1704, 0, bArr2, i3, i4);
        return i4;
    }

    public override java.lang.string GetAlgorithmName() {
        return "FF3-1";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((3 + 18) % 18 > 0) {
        }
        this.f9301aa9b = z;
        this.ffa1f015d = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbb71f915) pc9ef6b45Var;
        this.ffc13579c.init(!this.ffa1f015d.isUsingInverseFunction(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(this.ffa1f015d.getKey().getKey())));
        if (this.ffa1f015d.getTweak().length != 7) {
            throw new java.lang.IllegalArgumentException("tweak should be 56 bits");
        }
    }
}

