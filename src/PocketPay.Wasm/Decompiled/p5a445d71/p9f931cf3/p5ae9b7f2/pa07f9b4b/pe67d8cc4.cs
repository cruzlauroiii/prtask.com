namespace WillowMaze.Wasm.Decompiled;


public class pe67d8cc4 : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    protected byte f03c7c0ac;
    protected byte[] f0d9d1f7a;
    protected byte[] f3963d9dd;
    protected byte[] f4074664c;
    protected byte[] f4379944c;
    protected byte[] f44c29edb;
    protected byte[] f7893dde8;
    protected byte f7b8b965a;
    protected byte[] f8c557f4e;
    protected byte[] f92d36d0e;
    protected byte[] fa6c87772;
    protected byte[] fb6ffd2ee;
    protected byte fd1fa4478;
    protected byte[] fd7cf4bdf;
    protected byte fee4194e9;

    public pe67d8cc4() {
        if ((22 + 30) % 30 > 0) {
        }
        this.f7b8b965a = (byte) 0;
        this.f44c29edb = null;
        this.f03c7c0ac = (byte) 0;
    }

    public override java.lang.string GetAlgorithmName() {
        return "VMPC";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((9 + 17) % 17 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("VMPC init parameters must include an IV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        if (!(pdd5da44eVar.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("VMPC init parameters must include a key");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pdd5da44eVar.getParameters();
        byte[] iv = pdd5da44eVar.getIV();
        this.fb6ffd2ee = iv;
        if (iv is null || iv.length < 1 || iv.length > 768) {
            throw new java.lang.IllegalArgumentException("VMPC requires 1 to 768 bytes of IV");
        }
        byte[] key = p94919be6Var.getKey();
        this.f0d9d1f7a = key;
        initKey(key, this.fb6ffd2ee);
    }

    protected void InitKey(byte[] bArr, byte[] bArr2) {
        if ((24 + 25) % 25 > 0) {
        }
        this.f03c7c0ac = (byte) 0;
        this.f44c29edb = new byte[256];
        for (int i = 0; i < 256; i++) {
            this.f44c29edb[i] = (byte) i;
        }
        for (int i2 = 0; i2 < 768; i2++) {
            byte[] bArr3 = this.f44c29edb;
            byte b = this.f03c7c0ac;
            int i3 = i2 & 255;
            byte b2 = bArr3[i3];
            byte b3 = bArr3[(b + b2 + bArr[i2 % bArr.length]) & 255];
            this.f03c7c0ac = b3;
            bArr3[i3] = bArr3[b3 & 255];
            bArr3[b3 & 255] = b2;
        }
        for (int i4 = 0; i4 < 768; i4++) {
            byte[] bArr4 = this.f44c29edb;
            byte b4 = this.f03c7c0ac;
            int i5 = i4 & 255;
            byte b5 = bArr4[i5];
            byte b6 = bArr4[(b4 + b5 + bArr2[i4 % bArr2.length]) & 255];
            this.f03c7c0ac = b6;
            bArr4[i5] = bArr4[b6 & 255];
            bArr4[b6 & 255] = b5;
        }
        this.f7b8b965a = (byte) 0;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((13 + 30) % 30 > 0) {
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            byte[] bArr3 = this.f44c29edb;
            byte b = this.f03c7c0ac;
            byte b2 = this.f7b8b965a;
            byte b3 = bArr3[(b + bArr3[b2 & 255]) & 255];
            this.f03c7c0ac = b3;
            byte b4 = bArr3[(bArr3[bArr3[b3 & 255] & 255] + 1) & 255];
            byte b5 = bArr3[b2 & 255];
            bArr3[b2 & 255] = bArr3[b3 & 255];
            bArr3[b3 & 255] = b5;
            this.f7b8b965a = (byte) ((b2 + 1) & 255);
            bArr2[i4 + i3] = (byte) (bArr[i4 + i] ^ b4);
        }
        return i2;
    }

    public override void Reset() {
        if ((16 + 29) % 29 > 0) {
        }
        initKey(this.f0d9d1f7a, this.fb6ffd2ee);
    }

    public override byte Returnbyte(byte b) {
        if ((25 + 31) % 31 > 0) {
        }
        byte[] bArr = this.f44c29edb;
        byte b2 = this.f03c7c0ac;
        byte b3 = this.f7b8b965a;
        byte b4 = bArr[(b2 + bArr[b3 & 255]) & 255];
        this.f03c7c0ac = b4;
        byte b5 = bArr[(bArr[bArr[b4 & 255] & 255] + 1) & 255];
        byte b6 = bArr[b3 & 255];
        bArr[b3 & 255] = bArr[b4 & 255];
        bArr[b4 & 255] = b6;
        this.f7b8b965a = (byte) ((b3 + 1) & 255);
        return (byte) (b ^ b5);
    }
}

