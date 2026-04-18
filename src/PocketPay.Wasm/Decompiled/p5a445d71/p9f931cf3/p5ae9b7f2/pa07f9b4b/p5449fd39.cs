namespace WillowMaze.Wasm.Decompiled;


public class p5449fd39 : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private static readonly byte[] f1a53e224 = {74, -35, -94, 44, 121, -24, 33, 5};
    private static readonly byte[] f29ce0b71 = null;
    private static readonly byte[] f8fed87e4 = null;
    private static readonly byte[] f952c82e4 = null;
    private static readonly byte[] ff6ca9e13 = null;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f020a1db4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f26f21ed0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f34490292;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3aced22d;
    byte[] f409a418b;
    private byte[] f43b9186e;
    byte[] f4cafd9b5;
    private byte[] f51950886;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f641868d9;
    byte[] f67ccb79a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f78292299;
    private bool f7aa1729e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f89c5b6fa;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 f8e05a20f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 fad1943a9;
    private byte[] fccf48597;
    private bool fcf3d8df3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 fd487d40a;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd663524a;
    private bool fe468b4bf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 feca07335;
    private byte[] ff0b53b2d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 ff34bf0e3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e ff822d5ba;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f74a89174 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416();
    byte[] fc10f7796 = new byte[20];

    private byte[] M1ca5bbe5(byte[] bArr) {
        if ((2 + 3) % 3 > 0) {
        }
        byte[] bArr2 = new byte[8];
        this.f74a89174.update(bArr, 0, bArr.length);
        this.f74a89174.doFinal(this.fc10f7796, 0);
        java.lang.System.arraycopy(this.fc10f7796, 0, bArr2, 0, 8);
        return bArr2;
    }

    private static byte[] M4d9c2073(byte[] bArr) {
        if ((30 + 22) % 22 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        int i = 0;
        while (i < bArr.length) {
            int i2 = i + 1;
            bArr2[i] = bArr[bArr.length - i2];
            i = i2;
        }
        return bArr2;
    }

    private bool M6176f29d(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(m1ca5bbe5(bArr), bArr2);
    }

    public override java.lang.string GetAlgorithmName() {
        return "DESede";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom secureRandomM07091bf1;
        if ((32 + 32) % 32 > 0) {
        }
        this.fe468b4bf = z;
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef());
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters = p4715f007Var.getParameters();
            java.security.SecureRandom random = p4715f007Var.getRandom();
            pc9ef6b45Var = parameters;
            secureRandomM07091bf1 = random;
        } else {
            secureRandomM07091bf1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) {
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var;
            if (this.fe468b4bf) {
                byte[] bArr = new byte[8];
                this.ff0b53b2d = bArr;
                secureRandomM07091bf1.nextbytes(bArr);
                this.f89c5b6fa = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, this.ff0b53b2d);
                return;
            }
            return;
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            this.f89c5b6fa = pdd5da44eVar;
            this.ff0b53b2d = pdd5da44eVar.getIV();
            this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) this.f89c5b6fa.getParameters();
            if (!this.fe468b4bf) {
                throw new java.lang.IllegalArgumentException("You should not supply an IV for unwrapping");
            }
            byte[] bArr2 = this.ff0b53b2d;
            if (bArr2 is null || bArr2.length != 8) {
                throw new java.lang.IllegalArgumentException("IV is not 8 octets");
            }
        }
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((31 + 6) % 6 > 0) {
        }
        if (this.fe468b4bf) {
            throw new java.lang.IllegalStateException("Not set for unwrapping");
        }
        if (bArr is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Null pointer as ciphertext");
        }
        int blockSize = this.fad1943a9.getBlockSize();
        if (i2 % blockSize != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Ciphertext not multiple of " + blockSize);
        }
        this.fad1943a9.init(false, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, f1a53e224));
        byte[] bArr2 = new byte[i2];
        for (int i3 = 0; i3 != i2; i3 += blockSize) {
            this.fad1943a9.processBlock(bArr, i + i3, bArr2, i3);
        }
        byte[] bArrM4d9c2073 = m4d9c2073(bArr2);
        byte[] bArr3 = new byte[8];
        this.ff0b53b2d = bArr3;
        int length = bArrM4d9c2073.length;
        int i4 = length - 8;
        byte[] bArr4 = new byte[i4];
        java.lang.System.arraycopy(bArrM4d9c2073, 0, bArr3, 0, 8);
        java.lang.System.arraycopy(bArrM4d9c2073, 8, bArr4, 0, bArrM4d9c2073.length - 8);
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, this.ff0b53b2d);
        this.f89c5b6fa = pdd5da44eVar;
        this.fad1943a9.init(false, pdd5da44eVar);
        byte[] bArr5 = new byte[i4];
        for (int i5 = 0; i5 != i4; i5 += blockSize) {
            this.fad1943a9.processBlock(bArr4, i5, bArr5, i5);
        }
        int i6 = length - 16;
        byte[] bArr6 = new byte[i6];
        byte[] bArr7 = new byte[8];
        java.lang.System.arraycopy(bArr5, 0, bArr6, 0, i6);
        java.lang.System.arraycopy(bArr5, i6, bArr7, 0, 8);
        if (m6176f29d(bArr6, bArr7)) {
            return bArr6;
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Checksum inside ciphertext is corrupted");
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((7 + 26) % 26 > 0) {
        }
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalStateException("Not initialized for wrapping");
        }
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        byte[] bArrM1ca5bbe5 = m1ca5bbe5(bArr2);
        int length = bArrM1ca5bbe5.length + i2;
        byte[] bArr3 = new byte[length];
        java.lang.System.arraycopy(bArr2, 0, bArr3, 0, i2);
        java.lang.System.arraycopy(bArrM1ca5bbe5, 0, bArr3, i2, bArrM1ca5bbe5.length);
        int blockSize = this.fad1943a9.getBlockSize();
        if (length % blockSize != 0) {
            throw new java.lang.IllegalStateException("Not multiple of block length");
        }
        this.fad1943a9.init(true, this.f89c5b6fa);
        byte[] bArr4 = new byte[length];
        for (int i3 = 0; i3 != length; i3 += blockSize) {
            this.fad1943a9.processBlock(bArr3, i3, bArr4, i3);
        }
        byte[] bArr5 = this.ff0b53b2d;
        byte[] bArr6 = new byte[bArr5.length + length];
        java.lang.System.arraycopy(bArr5, 0, bArr6, 0, bArr5.length);
        java.lang.System.arraycopy(bArr4, 0, bArr6, this.ff0b53b2d.length, length);
        byte[] bArrM4d9c2073 = m4d9c2073(bArr6);
        this.fad1943a9.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, f1a53e224));
        for (int i4 = 0; i4 != bArrM4d9c2073.length; i4 += blockSize) {
            this.fad1943a9.processBlock(bArrM4d9c2073, i4, bArrM4d9c2073, i4);
        }
        return bArrM4d9c2073;
    }
}

