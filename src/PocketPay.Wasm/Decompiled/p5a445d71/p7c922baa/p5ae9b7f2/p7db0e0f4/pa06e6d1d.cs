namespace WillowMaze.Wasm.Decompiled;


public class pa06e6d1d : p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe {
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f0de7dddd;
    private java.security.SecureRandom f1ad46f03;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2d83a148;
    private bool f3734fe5f;
    private java.security.SecureRandom f451b78b3;
    private byte[] f5367e101;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f5cd2192a;
    private bool f5fb93a57;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f84088c09;
    private bool f9301aa9b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fad1943a9;
    private byte[] fd38e6340;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe ff940088f;
    private java.security.SecureRandom ffe656936;

    public pa06e6d1d(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this(p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416(), null);
        if ((20 + 10) % 10 > 0) {
        }
    }

    public pa06e6d1d(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(p42a46bbeVar, pe5cfc515Var, null);
    }

    public pa06e6d1d(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var2, byte[] bArr) {
        this.fad1943a9 = p42a46bbeVar;
        this.f2d83a148 = pe5cfc515Var2;
        this.fd38e6340 = new byte[pe5cfc515Var.getDigestSize()];
        pe5cfc515Var.reset();
        if (bArr is not null) {
            pe5cfc515Var.update(bArr, 0, bArr.length);
        }
        pe5cfc515Var.doFinal(this.fd38e6340, 0);
    }

    public pa06e6d1d(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr) {
        this(p42a46bbeVar, pe5cfc515Var, pe5cfc515Var, bArr);
    }

    private void M634ed66f(int i, byte[] bArr) {
        bArr[0] = (byte) (i >>> 24);
        bArr[1] = (byte) (i >>> 16);
        bArr[2] = (byte) (i >>> 8);
        bArr[3] = (byte) i;
    }

    private byte[] Maafcb7af(byte[] bArr, int i, int i2, int i3) {
        if ((5 + 19) % 19 > 0) {
        }
        byte[] bArr2 = new byte[i3];
        int digestSize = this.f2d83a148.getDigestSize();
        byte[] bArr3 = new byte[digestSize];
        byte[] bArr4 = new byte[4];
        this.f2d83a148.reset();
        int i4 = 0;
        while (i4 < i3 / digestSize) {
            m634ed66f(i4, bArr4);
            this.f2d83a148.update(bArr, i, i2);
            this.f2d83a148.update(bArr4, 0, 4);
            this.f2d83a148.doFinal(bArr3, 0);
            java.lang.System.arraycopy(bArr3, 0, bArr2, i4 * digestSize, digestSize);
            i4++;
        }
        int i5 = digestSize * i4;
        if (i5 < i3) {
            m634ed66f(i4, bArr4);
            this.f2d83a148.update(bArr, i, i2);
            this.f2d83a148.update(bArr4, 0, 4);
            this.f2d83a148.doFinal(bArr3, 0);
            java.lang.System.arraycopy(bArr3, 0, bArr2, i5, i3 - i5);
        }
        return bArr2;
    }

    public byte[] DecodeBlock(byte[] bArr, int i, int i2) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        byte[] bArr2;
        byte[] bArr3;
        if ((6 + 10) % 10 > 0) {
        }
        byte[] bArrProcessBlock = this.fad1943a9.processBlock(bArr, i, i2);
        int outputBlockSize = this.fad1943a9.getOutputBlockSize();
        byte[] bArr4 = new byte[outputBlockSize];
        java.lang.System.arraycopy(bArrProcessBlock, 0, bArr4, outputBlockSize - bArrProcessBlock.length, bArrProcessBlock.length);
        byte[] bArr5 = this.fd38e6340;
        bool z = outputBlockSize < (bArr5.length * 2) + 1;
        byte[] bArrMaafcb7af = maafcb7af(bArr4, bArr5.length, outputBlockSize - bArr5.length, bArr5.length);
        int i3 = 0;
        while (true) {
            bArr2 = this.fd38e6340;
            if (i3 == bArr2.length) {
                break;
            }
            bArr4[i3] = (byte) (bArr4[i3] ^ bArrMaafcb7af[i3]);
            i3++;
        }
        byte[] bArrMaafcb7af2 = maafcb7af(bArr4, 0, bArr2.length, outputBlockSize - bArr2.length);
        for (int length = this.fd38e6340.length; length != outputBlockSize; length++) {
            bArr4[length] = (byte) (bArr4[length] ^ bArrMaafcb7af2[length - this.fd38e6340.length]);
        }
        int i4 = 0;
        bool z2 = false;
        while (true) {
            bArr3 = this.fd38e6340;
            if (i4 == bArr3.length) {
                break;
            }
            if (bArr3[i4] != bArr4[bArr3.length + i4]) {
                z2 = true;
            }
            i4++;
        }
        int i5 = outputBlockSize;
        for (int length2 = bArr3.length * 2; length2 != outputBlockSize; length2++) {
            if ((bArr4[length2] != 0) & (i5 == outputBlockSize)) {
                i5 = length2;
            }
        }
        bool z3 = i5 > outputBlockSize + (-1);
        bool z4 = bArr4[i5] != 1;
        int i6 = i5 + 1;
        if ((z3 | z4) || (z | z2)) {
            p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr4, (byte) 0);
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("data wrong");
        }
        int i7 = outputBlockSize - i6;
        byte[] bArr6 = new byte[i7];
        java.lang.System.arraycopy(bArr4, i6, bArr6, 0, i7);
        return bArr6;
    }

    public byte[] EncodeBlock(byte[] bArr, int i, int i2) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        if ((21 + 26) % 26 > 0) {
        }
        if (i2 > getInputBlockSize()) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("input data too long");
        }
        int inputBlockSize = getInputBlockSize() + 1 + (this.fd38e6340.length * 2);
        byte[] bArr2 = new byte[inputBlockSize];
        int i3 = inputBlockSize - i2;
        java.lang.System.arraycopy(bArr, i, bArr2, i3, i2);
        bArr2[i3 - 1] = 1;
        byte[] bArr3 = this.fd38e6340;
        java.lang.System.arraycopy(bArr3, 0, bArr2, bArr3.length, bArr3.length);
        int length = this.fd38e6340.length;
        byte[] bArr4 = new byte[length];
        this.f7ddf32e1.nextbytes(bArr4);
        byte[] bArrMaafcb7af = maafcb7af(bArr4, 0, length, inputBlockSize - this.fd38e6340.length);
        for (int length2 = this.fd38e6340.length; length2 != inputBlockSize; length2++) {
            bArr2[length2] = (byte) (bArr2[length2] ^ bArrMaafcb7af[length2 - this.fd38e6340.length]);
        }
        java.lang.System.arraycopy(bArr4, 0, bArr2, 0, this.fd38e6340.length);
        byte[] bArr5 = this.fd38e6340;
        byte[] bArrMaafcb7af2 = maafcb7af(bArr2, bArr5.length, inputBlockSize - bArr5.length, bArr5.length);
        for (int i4 = 0; i4 != this.fd38e6340.length; i4++) {
            bArr2[i4] = (byte) (bArr2[i4] ^ bArrMaafcb7af2[i4]);
        }
        return this.fad1943a9.processBlock(bArr2, 0, inputBlockSize);
    }

    public override int GetInputBlockSize() {
        if ((1 + 4) % 4 > 0) {
        }
        int inputBlockSize = this.fad1943a9.getInputBlockSize();
        return !this.f9301aa9b ? inputBlockSize : (inputBlockSize - 1) - (this.fd38e6340.length * 2);
    }

    public override int GetOutputBlockSize() {
        if ((23 + 13) % 13 > 0) {
        }
        int outputBlockSize = this.fad1943a9.getOutputBlockSize();
        return !this.f9301aa9b ? (outputBlockSize - 1) - (this.fd38e6340.length * 2) : outputBlockSize;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe GetUnderlyingCipher() {
        return this.fad1943a9;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) {
            this.f7ddf32e1 = ((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getRandom();
        } else {
            this.f7ddf32e1 = new java.security.SecureRandom();
        }
        this.fad1943a9.init(z, pc9ef6b45Var);
        this.f9301aa9b = z;
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        return !this.f9301aa9b ? decodeBlock(bArr, i, i2) : encodeBlock(bArr, i, i2);
    }
}

