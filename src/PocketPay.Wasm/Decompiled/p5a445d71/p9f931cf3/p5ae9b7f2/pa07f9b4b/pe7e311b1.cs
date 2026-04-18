namespace WillowMaze.Wasm.Decompiled;


public class pe7e311b1 : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private static readonly byte[] f030f7c07 = null;
    private static readonly byte[] f1a53e224 = {74, -35, -94, 44, 121, -24, 33, 5};
    private static readonly byte[] f8bdfe9c3 = null;
    private static readonly byte[] ff7c15d48 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f018eb9d3;
    private bool f04a9fe9f;
    private byte[] f1e17fbad;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f23de76ff;
    byte[] f2a97a874;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 f2f42ea04;
    private java.security.SecureRandom f3876accb;
    private java.security.SecureRandom f3aa851b8;
    byte[] f3d252b0c;
    private byte[] f479a5a2d;
    private java.security.SecureRandom f5c57d27e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f87f98737;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e f89c5b6fa;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e fa595955f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64 fad1943a9;
    private java.security.SecureRandom fae48b02d;
    private byte[] fb88e2955;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e fbd39beaa;
    private java.security.SecureRandom fe22428cc;
    private bool fe468b4bf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 feca07335;
    private byte[] ff0b53b2d;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 ff70833fb;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 ffe5ee75f;
    p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f74a89174 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416();
    byte[] fc10f7796 = new byte[20];

    private byte[] M1ca5bbe5(byte[] bArr) {
        if ((8 + 16) % 16 > 0) {
        }
        byte[] bArr2 = new byte[8];
        this.f74a89174.update(bArr, 0, bArr.length);
        this.f74a89174.doFinal(this.fc10f7796, 0);
        java.lang.System.arraycopy(this.fc10f7796, 0, bArr2, 0, 8);
        return bArr2;
    }

    private bool M6176f29d(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(m1ca5bbe5(bArr), bArr2);
    }

    public override java.lang.string GetAlgorithmName() {
        return "RC2";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.fe468b4bf = z;
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p766d1ff5());
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.fe22428cc = p4715f007Var.getRandom();
            pc9ef6b45Var = p4715f007Var.getParameters();
        } else {
            this.fe22428cc = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            this.feca07335 = pc9ef6b45Var;
            if (this.fe468b4bf) {
                byte[] bArr = new byte[8];
                this.ff0b53b2d = bArr;
                this.fe22428cc.nextbytes(bArr);
                this.f89c5b6fa = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, this.ff0b53b2d);
                return;
            }
            return;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        this.f89c5b6fa = pdd5da44eVar;
        this.ff0b53b2d = pdd5da44eVar.getIV();
        this.feca07335 = this.f89c5b6fa.getParameters();
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalArgumentException("You should not supply an IV for unwrapping");
        }
        byte[] bArr2 = this.ff0b53b2d;
        if (bArr2 is null || bArr2.length != 8) {
            throw new java.lang.IllegalArgumentException("IV is not 8 octets");
        }
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((8 + 32) % 32 > 0) {
        }
        if (this.fe468b4bf) {
            throw new java.lang.IllegalStateException("Not set for unwrapping");
        }
        if (bArr is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Null pointer as ciphertext");
        }
        if (i2 % this.fad1943a9.getBlockSize() != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Ciphertext not multiple of " + this.fad1943a9.getBlockSize());
        }
        this.fad1943a9.init(false, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, f1a53e224));
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        for (int i3 = 0; i3 < i2 / this.fad1943a9.getBlockSize(); i3++) {
            int blockSize = this.fad1943a9.getBlockSize() * i3;
            this.fad1943a9.processBlock(bArr2, blockSize, bArr2, blockSize);
        }
        byte[] bArr3 = new byte[i2];
        int i4 = 0;
        while (i4 < i2) {
            int i5 = i4 + 1;
            bArr3[i4] = bArr2[i2 - i5];
            i4 = i5;
        }
        byte[] bArr4 = new byte[8];
        this.ff0b53b2d = bArr4;
        int i6 = i2 - 8;
        byte[] bArr5 = new byte[i6];
        java.lang.System.arraycopy(bArr3, 0, bArr4, 0, 8);
        java.lang.System.arraycopy(bArr3, 8, bArr5, 0, i6);
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, this.ff0b53b2d);
        this.f89c5b6fa = pdd5da44eVar;
        this.fad1943a9.init(false, pdd5da44eVar);
        byte[] bArr6 = new byte[i6];
        java.lang.System.arraycopy(bArr5, 0, bArr6, 0, i6);
        for (int i7 = 0; i7 < i6 / this.fad1943a9.getBlockSize(); i7++) {
            int blockSize2 = this.fad1943a9.getBlockSize() * i7;
            this.fad1943a9.processBlock(bArr6, blockSize2, bArr6, blockSize2);
        }
        int i8 = i2 - 16;
        byte[] bArr7 = new byte[i8];
        byte[] bArr8 = new byte[8];
        java.lang.System.arraycopy(bArr6, 0, bArr7, 0, i8);
        java.lang.System.arraycopy(bArr6, i8, bArr8, 0, 8);
        if (!m6176f29d(bArr7, bArr8)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("Checksum inside ciphertext is corrupted");
        }
        int i9 = bArr7[0];
        if (i8 - ((i9 & 255) + 1) > 7) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("too many pad bytes (" + (i8 - ((bArr7[0] & 255) + 1)) + ")");
        }
        byte[] bArr9 = new byte[i9];
        java.lang.System.arraycopy(bArr7, 1, bArr9, 0, i9);
        return bArr9;
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((16 + 17) % 17 > 0) {
        }
        if (!this.fe468b4bf) {
            throw new java.lang.IllegalStateException("Not initialized for wrapping");
        }
        int i3 = i2 + 1;
        int i4 = i3 % 8;
        int i5 = i4 == 0 ? i3 : (8 - i4) + i3;
        byte[] bArr2 = new byte[i5];
        bArr2[0] = (byte) i2;
        java.lang.System.arraycopy(bArr, i, bArr2, 1, i2);
        int i6 = (i5 - i2) - 1;
        byte[] bArr3 = new byte[i6];
        if (i6 > 0) {
            this.fe22428cc.nextbytes(bArr3);
            java.lang.System.arraycopy(bArr3, 0, bArr2, i3, i6);
        }
        byte[] bArrM1ca5bbe5 = m1ca5bbe5(bArr2);
        int length = bArrM1ca5bbe5.length + i5;
        byte[] bArr4 = new byte[length];
        java.lang.System.arraycopy(bArr2, 0, bArr4, 0, i5);
        java.lang.System.arraycopy(bArrM1ca5bbe5, 0, bArr4, i5, bArrM1ca5bbe5.length);
        byte[] bArr5 = new byte[length];
        java.lang.System.arraycopy(bArr4, 0, bArr5, 0, length);
        int blockSize = length / this.fad1943a9.getBlockSize();
        if (length % this.fad1943a9.getBlockSize() != 0) {
            throw new java.lang.IllegalStateException("Not multiple of block length");
        }
        this.fad1943a9.init(true, this.f89c5b6fa);
        for (int i7 = 0; i7 < blockSize; i7++) {
            int blockSize2 = this.fad1943a9.getBlockSize() * i7;
            this.fad1943a9.processBlock(bArr5, blockSize2, bArr5, blockSize2);
        }
        byte[] bArr6 = this.ff0b53b2d;
        int length2 = bArr6.length + length;
        byte[] bArr7 = new byte[length2];
        java.lang.System.arraycopy(bArr6, 0, bArr7, 0, bArr6.length);
        java.lang.System.arraycopy(bArr5, 0, bArr7, this.ff0b53b2d.length, length);
        byte[] bArr8 = new byte[length2];
        int i8 = 0;
        while (i8 < length2) {
            int i9 = i8 + 1;
            bArr8[i8] = bArr7[length2 - i9];
            i8 = i9;
        }
        this.fad1943a9.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.feca07335, f1a53e224));
        for (int i10 = 0; i10 < blockSize + 1; i10++) {
            int blockSize3 = this.fad1943a9.getBlockSize() * i10;
            this.fad1943a9.processBlock(bArr8, blockSize3, bArr8, blockSize3);
        }
        return bArr8;
    }
}

