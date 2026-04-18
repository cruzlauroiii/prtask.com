namespace WillowMaze.Wasm.Decompiled;


public class p318d534b : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private byte[] f219300e2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f330ab26e;
    private byte[] f4c1e9b09;
    private byte[] f4f022f06 = null;
    private byte[] f7c9d8293;
    private bool f848cf064;
    private byte[] f8d69ee95;
    private byte[] f97c46489;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad1943a9;
    private bool faf7aed87;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 fb33a6f46;
    private byte[] fd60704bd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 fd7a04fed;
    private byte[] fd8fc421b;
    private bool fe468b4bf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 feca07335;
    private byte[] ff5c71a25;

    public p318d534b(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        byte[] bArr = {-90, 89, 89, -90};
        this.fd8fc421b = bArr;
        this.f8d69ee95 = bArr;
        this.fad1943a9 = pd81e8b93Var;
    }

    private byte[] M58df0984(byte[] bArr) {
        if ((22 + 20) % 20 > 0) {
        }
        int length = bArr.length;
        int i = (8 - (length % 8)) % 8;
        byte[] bArr2 = new byte[length + i];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, length);
        if (i != 0) {
            java.lang.System.arraycopy(new byte[i], 0, bArr2, length, i);
        }
        return bArr2;
    }

    private byte[] Mf7a51547(byte[] bArr, int i, int i2) {
        if ((30 + 25) % 25 > 0) {
        }
        int i3 = i2 - 8;
        byte[] bArr2 = new byte[i3];
        byte[] bArr3 = new byte[8];
        byte[] bArr4 = new byte[16];
        java.lang.System.arraycopy(bArr, i, bArr3, 0, 8);
        java.lang.System.arraycopy(bArr, i + 8, bArr2, 0, i3);
        this.fad1943a9.init(false, this.feca07335);
        int i4 = (i2 / 8) - 1;
        for (int i5 = 5; i5 >= 0; i5--) {
            for (int i6 = i4; i6 >= 1; i6--) {
                java.lang.System.arraycopy(bArr3, 0, bArr4, 0, 8);
                int i7 = (i6 - 1) * 8;
                java.lang.System.arraycopy(bArr2, i7, bArr4, 8, 8);
                int i8 = (i4 * i5) + i6;
                int i9 = 1;
                while (i8 != 0) {
                    int i10 = 8 - i9;
                    bArr4[i10] = (byte) (((byte) i8) ^ bArr4[i10]);
                    i8 >>>= 8;
                    i9++;
                }
                this.fad1943a9.processBlock(bArr4, 0, bArr4, 0);
                java.lang.System.arraycopy(bArr4, 0, bArr3, 0, 8);
                java.lang.System.arraycopy(bArr4, 8, bArr2, i7, 8);
            }
        }
        this.f4f022f06 = bArr3;
        return bArr2;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fad1943a9.getAlgorithmName();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.fe468b4bf = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) {
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var;
            this.f8d69ee95 = this.fd8fc421b;
        } else if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            this.f8d69ee95 = pdd5da44eVar.getIV();
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
            if (this.f8d69ee95.length != 4) {
                throw new java.lang.IllegalArgumentException("IV length not equal to 4");
            }
        }
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        byte[] bArrMf7a51547;
        if ((32 + 14) % 14 > 0) {
        }
        if (this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for unwrapping");
        }
        int i3 = i2 / 8;
        if (i3 * 8 != i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("unwrap data must be a multiple of 8 bytes");
        }
        if (i3 <= 1) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("unwrap data must be at least 16 bytes");
        }
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        byte[] bArr3 = new byte[i2];
        if (i3 != 2) {
            bArrMf7a51547 = mf7a51547(bArr, i, i2);
        } else {
            this.fad1943a9.init(false, this.feca07335);
            int blockSize = 0;
            while (blockSize < i2) {
                this.fad1943a9.processBlock(bArr2, blockSize, bArr3, blockSize);
                blockSize += this.fad1943a9.getBlockSize();
            }
            byte[] bArr4 = new byte[8];
            this.f4f022f06 = bArr4;
            java.lang.System.arraycopy(bArr3, 0, bArr4, 0, bArr4.length);
            byte[] bArr5 = this.f4f022f06;
            int length = i2 - bArr5.length;
            bArrMf7a51547 = new byte[length];
            java.lang.System.arraycopy(bArr3, bArr5.length, bArrMf7a51547, 0, length);
        }
        int i4 = 4;
        byte[] bArr6 = new byte[4];
        byte[] bArr7 = new byte[4];
        java.lang.System.arraycopy(this.f4f022f06, 0, bArr6, 0, 4);
        java.lang.System.arraycopy(this.f4f022f06, 4, bArr7, 0, 4);
        int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr7, 0);
        bool zM66e765de = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr6, this.f8d69ee95);
        int length2 = bArrMf7a51547.length;
        if (iMc4a60053 <= length2 - 8) {
            zM66e765de = false;
        }
        if (iMc4a60053 > length2) {
            zM66e765de = false;
        }
        int i5 = length2 - iMc4a60053;
        if (i5 < 8 && i5 >= 0) {
            i4 = i5;
        } else {
            zM66e765de = false;
        }
        byte[] bArr8 = new byte[i4];
        byte[] bArr9 = new byte[i4];
        java.lang.System.arraycopy(bArrMf7a51547, bArrMf7a51547.length - i4, bArr9, 0, i4);
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr9, bArr8)) {
            zM66e765de = false;
        }
        if (!zM66e765de) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("checksum failed");
        }
        byte[] bArr10 = new byte[iMc4a60053];
        java.lang.System.arraycopy(bArrMf7a51547, 0, bArr10, 0, iMc4a60053);
        return bArr10;
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((30 + 21) % 21 > 0) {
        }
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalStateException("not set for wrapping");
        }
        byte[] bArr2 = new byte[8];
        byte[] bArrM27c2615b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i2);
        byte[] bArr3 = this.f8d69ee95;
        int blockSize = 0;
        java.lang.System.arraycopy(bArr3, 0, bArr2, 0, bArr3.length);
        java.lang.System.arraycopy(bArrM27c2615b, 0, bArr2, this.f8d69ee95.length, bArrM27c2615b.length);
        byte[] bArr4 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr4, 0, i2);
        byte[] bArrM58df0984 = m58df0984(bArr4);
        if (bArrM58df0984.length != 8) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c p75178d1cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c(this.fad1943a9);
            p75178d1cVar.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, bArr2));
            return p75178d1cVar.wrap(bArrM58df0984, 0, bArrM58df0984.length);
        }
        int length = bArrM58df0984.length + 8;
        byte[] bArr5 = new byte[length];
        java.lang.System.arraycopy(bArr2, 0, bArr5, 0, 8);
        java.lang.System.arraycopy(bArrM58df0984, 0, bArr5, 8, bArrM58df0984.length);
        this.fad1943a9.init(true, this.feca07335);
        while (blockSize < length) {
            this.fad1943a9.processBlock(bArr5, blockSize, bArr5, blockSize);
            blockSize += this.fad1943a9.getBlockSize();
        }
        return bArr5;
    }
}

