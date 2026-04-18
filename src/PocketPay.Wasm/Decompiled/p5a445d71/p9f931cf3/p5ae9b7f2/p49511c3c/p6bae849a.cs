namespace WillowMaze.Wasm.Decompiled;


public class p6bae849a : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f39ee4d43;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;

    public p6bae849a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    private byte[] Mde3e38ba() {
        if ((26 + 2) % 2 > 0) {
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr = new byte[digestSize];
        this.fc10f7796.update(this.f5f4dcc3b, 0, this.f5f4dcc3b.length);
        this.fc10f7796.update(this.fceb20772, 0, this.fceb20772.length);
        this.fc10f7796.doFinal(bArr, 0);
        for (int i = 1; i < this.f40e092b2; i++) {
            this.fc10f7796.update(bArr, 0, digestSize);
            this.fc10f7796.doFinal(bArr, 0);
        }
        return bArr;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        return generateDerivedParameters(i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((26 + 21) % 21 > 0) {
        }
        int i2 = i / 8;
        if (i2 > this.fc10f7796.getDigestSize()) {
            throw new java.lang.IllegalArgumentException("Can't generate a derived key " + i2 + " bytes long.");
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mde3e38ba(), 0, i2);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((31 + 14) % 14 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        int i5 = i3 + i4;
        if (i5 > this.fc10f7796.getDigestSize()) {
            throw new java.lang.IllegalArgumentException("Can't generate a derived key " + i5 + " bytes long.");
        }
        byte[] bArrMde3e38ba = mde3e38ba();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArrMde3e38ba, 0, i3), bArrMde3e38ba, i3, i4);
    }
}

