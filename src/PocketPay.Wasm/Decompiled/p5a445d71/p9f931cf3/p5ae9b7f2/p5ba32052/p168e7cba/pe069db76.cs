namespace WillowMaze.Wasm.Decompiled;


public class pe069db76 : p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f08abf8a4;
    private byte[] f117c55e6;
    private byte[] f2effb287;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f626c59b9;
    private byte[] f63641252;
    private byte[] f9e81e7b9;
    private int f9fb997de;
    private int fb0013e59;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] ffdce7a34;

    public pe069db76(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
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
        int i4;
        if ((16 + 7) % 7 > 0) {
        }
        if (bArr.length - i2 < i) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too small");
        }
        byte[] bArr2 = new byte[this.fb0013e59];
        byte[] bArr3 = new byte[4];
        this.fc10f7796.reset();
        int i5 = 1;
        if (i2 <= this.fb0013e59) {
            i3 = 0;
        } else {
            i3 = 0;
            while (true) {
                m634ed66f(i5, bArr3);
                this.fc10f7796.update(bArr3, 0, 4);
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
                byte[] bArr4 = this.f9e81e7b9;
                pe5cfc515Var.update(bArr4, 0, bArr4.length);
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fc10f7796;
                byte[] bArr5 = this.ffdce7a34;
                pe5cfc515Var2.update(bArr5, 0, bArr5.length);
                this.fc10f7796.doFinal(bArr2, 0);
                java.lang.System.arraycopy(bArr2, 0, bArr, i + i3, this.fb0013e59);
                int i6 = this.fb0013e59;
                i3 += i6;
                i4 = i5 + 1;
                if (i5 >= i2 / i6) {
                    break;
                }
                i5 = i4;
            }
            i5 = i4;
        }
        if (i3 < i2) {
            m634ed66f(i5, bArr3);
            this.fc10f7796.update(bArr3, 0, 4);
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var3 = this.fc10f7796;
            byte[] bArr6 = this.f9e81e7b9;
            pe5cfc515Var3.update(bArr6, 0, bArr6.length);
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var4 = this.fc10f7796;
            byte[] bArr7 = this.ffdce7a34;
            pe5cfc515Var4.update(bArr7, 0, bArr7.length);
            this.fc10f7796.doFinal(bArr2, 0);
            java.lang.System.arraycopy(bArr2, 0, bArr, i + i3, i2 - i3);
        }
        return i2;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3)) {
            throw new java.lang.IllegalArgumentException("KDF parameters required for generator");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3 pc03b0fe3Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc03b0fe3) p873e950bVar;
        this.f9e81e7b9 = pc03b0fe3Var.getSharedSecret();
        this.ffdce7a34 = pc03b0fe3Var.getIV();
    }
}

