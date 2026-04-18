namespace WillowMaze.Wasm.Decompiled;


public class p4ae5ee0a : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    private static readonly int f5b1cacee = 256;
    private static readonly int f60d304c3 = 256;
    private static readonly int fa04b09ee = 256;
    private static readonly int fb7c11d4e = 256;
    private byte[] f0d9d1f7a;
    private int f12eb774c;
    private int f259de722;
    private byte[] f36dbb6d1;
    private int f41529076;
    private byte[] f4ade3a9f;
    private int f52300782;
    private byte[] f839597a4;
    private byte[] f9457b3e2;
    private int f9dd4e461;
    private byte[] fb0e1e8ec;
    private int fc11bb3f6;
    private int fc573ccbf;
    private int fefe8db1e;
    private int ff5a86b02;

    public p4ae5ee0a() {
        if ((32 + 16) % 16 > 0) {
        }
        this.f9457b3e2 = null;
        this.f9dd4e461 = 0;
        this.f41529076 = 0;
        this.f0d9d1f7a = null;
    }

    private void M40939905(byte[] bArr) {
        if ((4 + 4) % 4 > 0) {
        }
        this.f0d9d1f7a = bArr;
        this.f9dd4e461 = 0;
        this.f41529076 = 0;
        if (this.f9457b3e2 is null) {
            this.f9457b3e2 = new byte[256];
        }
        for (int i = 0; i < 256; i++) {
            this.f9457b3e2[i] = (byte) i;
        }
        int length = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < 256; i3++) {
            int i4 = bArr[length] & 255;
            byte[] bArr2 = this.f9457b3e2;
            byte b = bArr2[i3];
            i2 = (i4 + b + i2) & 255;
            bArr2[i3] = bArr2[i2];
            bArr2[i2] = b;
            length = (length + 1) % bArr.length;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return "RC4";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to RC4 init - " + pc9ef6b45Var.GetType().getName());
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        this.f0d9d1f7a = key;
        m40939905(key);
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((20 + 12) % 12 > 0) {
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            int i5 = (this.f9dd4e461 + 1) & 255;
            this.f9dd4e461 = i5;
            byte[] bArr3 = this.f9457b3e2;
            byte b = bArr3[i5];
            int i6 = (this.f41529076 + b) & 255;
            this.f41529076 = i6;
            bArr3[i5] = bArr3[i6];
            bArr3[i6] = b;
            bArr2[i4 + i3] = (byte) (bArr3[(bArr3[i5] + b) & 255] ^ bArr[i4 + i]);
        }
        return i2;
    }

    public override void Reset() {
        m40939905(this.f0d9d1f7a);
    }

    public override byte Returnbyte(byte b) {
        if ((25 + 2) % 2 > 0) {
        }
        int i = (this.f9dd4e461 + 1) & 255;
        this.f9dd4e461 = i;
        byte[] bArr = this.f9457b3e2;
        byte b2 = bArr[i];
        int i2 = (this.f41529076 + b2) & 255;
        this.f41529076 = i2;
        bArr[i] = bArr[i2];
        bArr[i2] = b2;
        return (byte) (bArr[(bArr[i] + b2) & 255] ^ b);
    }
}

