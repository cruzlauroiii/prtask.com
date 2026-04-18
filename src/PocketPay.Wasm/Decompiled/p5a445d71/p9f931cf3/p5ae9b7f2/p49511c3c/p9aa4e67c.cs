namespace WillowMaze.Wasm.Decompiled;


public class p9aa4e67c : p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 {
    private int f52f9790e;
    private byte[] f5b6c1b66;
    private byte[] f90870c2c;
    private byte[] fa367d463;
    private int fb0013e59;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fdc08e631;
    private int fdccb2ef2;
    private byte[] ffe4c0f30;

    public p9aa4e67c(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
        this.fb0013e59 = pe5cfc515Var.getDigestSize();
    }

    private void M634ed66f(int i, byte[] bArr) {
        bArr[0] = (byte) (i >>> 24);
        bArr[1] = (byte) (i >>> 16);
        bArr[2] = (byte) (i >>> 8);
        bArr[3] = (byte) i;
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        int i3;
        if ((1 + 27) % 27 > 0) {
        }
        if (bArr.length - i2 < i) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too small");
        }
        byte[] bArr2 = new byte[this.fb0013e59];
        byte[] bArr3 = new byte[4];
        this.fc10f7796.reset();
        if (i2 <= this.fb0013e59) {
            i3 = 0;
        } else {
            i3 = 0;
            do {
                m634ed66f(i3, bArr3);
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
                byte[] bArr4 = this.ffe4c0f30;
                pe5cfc515Var.update(bArr4, 0, bArr4.length);
                this.fc10f7796.update(bArr3, 0, 4);
                this.fc10f7796.doFinal(bArr2, 0);
                int i4 = this.fb0013e59;
                java.lang.System.arraycopy(bArr2, 0, bArr, (i3 * i4) + i, i4);
                i3++;
            } while (i3 < i2 / this.fb0013e59);
        }
        if (this.fb0013e59 * i3 < i2) {
            m634ed66f(i3, bArr3);
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fc10f7796;
            byte[] bArr5 = this.ffe4c0f30;
            pe5cfc515Var2.update(bArr5, 0, bArr5.length);
            this.fc10f7796.update(bArr3, 0, 4);
            this.fc10f7796.doFinal(bArr2, 0);
            int i5 = this.fb0013e59;
            java.lang.System.arraycopy(bArr2, 0, bArr, i + (i3 * i5), i2 - (i3 * i5));
        }
        return i2;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2fcfd194)) {
            throw new java.lang.IllegalArgumentException("MGF parameters required for MGF1Generator");
        }
        this.ffe4c0f30 = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2fcfd194) p873e950bVar).getSeed();
    }
}

