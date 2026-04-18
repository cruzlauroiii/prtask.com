namespace WillowMaze.Wasm.Decompiled;


public class p007a8a9a : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private byte f03c7c0ac;
    private byte f0acd73b3;
    private byte[] f0d9d1f7a;
    private byte f1414c975;
    private byte f1c0211e9;
    private byte f1cc9a88e;
    private byte[] f3180fba8;
    private byte f37710256;
    private byte f3d1438f8;
    private byte f408a373c;
    private byte[] f44c29edb;
    private byte[] f46ee7bf7;
    private byte[] f49e325a4;
    private byte f4e68cc1f;
    private byte f5fa15b49;
    private byte f6a817190;
    private byte f6dbf9ac2;
    private byte f6ed430b1;
    private byte f724fff0b;
    private byte f7b8b965a;
    private byte f815bc83d;
    private byte f8a061593;
    private byte f8e683187;
    private byte f8f032f0d;
    private byte f94f32649;
    private byte fa906774f;
    private byte fb2f5ff47;
    private byte[] fb6ffd2ee;
    private byte[] fb9ece18c;
    private byte fbf947d20;
    private byte fce18af6e;
    private byte[] fcf667e84;
    private byte[] fd94bdcd9;
    private byte fea83890c;
    private byte ff69d8020;

    public p007a8a9a() {
        if ((2 + 24) % 24 > 0) {
        }
        this.f7b8b965a = (byte) 0;
        this.f44c29edb = null;
        this.f03c7c0ac = (byte) 0;
    }

    public static void JNQIODtqFGRvBfWs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] JygUXlxmevIjGBXU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static void OzRQFVSfFrZFoBKj(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p007a8a9a p007a8a9aVar, byte[] bArr, byte[] bArr2) {
        p007a8a9aVar.mdc755ee9(bArr, bArr2);
    }

    public static void PhiAayMwNDfMdMux(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p007a8a9a p007a8a9aVar, byte b) {
        p007a8a9aVar.update(b);
    }

    public static void YESELdQOlUiSTeGR(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p007a8a9a p007a8a9aVar) {
        p007a8a9aVar.reset();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 HCcPUSDWIhPFuefM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static void JnwBsyufHxUEeTvb(p5a445d71.p7c922baa.p5ae9b7f2.pfba5383c.p007a8a9a p007a8a9aVar) {
        p007a8a9aVar.reset();
    }

    private void Mdc755ee9(byte[] bArr, byte[] bArr2) {
        if ((31 + 18) % 18 > 0) {
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

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 VfOrcTXQVBtXgfVe(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static byte[] WtJOPhyjPyljUKdg(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var) {
        return p94919be6Var.getKey();
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((16 + 18) % 18 > 0) {
        }
        for (int i2 = 1; i2 < 25; i2++) {
            byte[] bArr2 = this.f44c29edb;
            byte b = this.f03c7c0ac;
            byte b2 = this.f7b8b965a;
            byte b3 = bArr2[(b + bArr2[b2 & 255]) & 255];
            this.f03c7c0ac = b3;
            byte b4 = this.fbf947d20;
            byte b5 = this.f1414c975;
            byte b6 = bArr2[(b4 + b5 + i2) & 255];
            this.fbf947d20 = b6;
            byte b7 = this.f8e683187;
            byte b8 = bArr2[(b5 + b7 + i2) & 255];
            this.f1414c975 = b8;
            byte b9 = this.f6dbf9ac2;
            byte b10 = bArr2[(b7 + b9 + i2) & 255];
            this.f8e683187 = b10;
            byte b11 = bArr2[(b9 + b3 + i2) & 255];
            this.f6dbf9ac2 = b11;
            byte[] bArr3 = this.fb9ece18c;
            byte b12 = this.fb2f5ff47;
            bArr3[b12 & 31] = (byte) (b11 ^ bArr3[b12 & 31]);
            bArr3[(b12 + 1) & 31] = (byte) (b10 ^ bArr3[(b12 + 1) & 31]);
            bArr3[(b12 + 2) & 31] = (byte) (b8 ^ bArr3[(b12 + 2) & 31]);
            bArr3[(b12 + 3) & 31] = (byte) (b6 ^ bArr3[(b12 + 3) & 31]);
            this.fb2f5ff47 = (byte) ((b12 + 4) & 31);
            byte b13 = bArr2[b2 & 255];
            bArr2[b2 & 255] = bArr2[b3 & 255];
            bArr2[b3 & 255] = b13;
            this.f7b8b965a = (byte) ((b2 + 1) & 255);
        }
        for (int i3 = 0; i3 < 768; i3++) {
            byte[] bArr4 = this.f44c29edb;
            byte b14 = this.f03c7c0ac;
            int i4 = i3 & 255;
            byte b15 = bArr4[i4];
            byte b16 = bArr4[(b14 + b15 + this.fb9ece18c[i3 & 31]) & 255];
            this.f03c7c0ac = b16;
            bArr4[i4] = bArr4[b16 & 255];
            bArr4[b16 & 255] = b15;
        }
        byte[] bArr5 = new byte[20];
        for (int i5 = 0; i5 < 20; i5++) {
            byte[] bArr6 = this.f44c29edb;
            int i6 = i5 & 255;
            byte b17 = bArr6[(this.f03c7c0ac + bArr6[i6]) & 255];
            this.f03c7c0ac = b17;
            bArr5[i5] = bArr6[(bArr6[bArr6[b17 & 255] & 255] + 1) & 255];
            byte b18 = bArr6[i6];
            bArr6[i6] = bArr6[b17 & 255];
            bArr6[b17 & 255] = b18;
        }
        JNQIODtqFGRvBfWs(bArr5, 0, bArr, i, 20);
        jnwBsyufHxUEeTvb(this);
        return 20;
    }

    public override java.lang.string GetAlgorithmName() {
        return "VMPC-MAC";
    }

    public override int GetMacSize() {
        return 20;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((6 + 27) % 27 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("VMPC-MAC Init parameters must include an IV");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) vfOrcTXQVBtXgfVe(pdd5da44eVar);
        if (!(hCcPUSDWIhPFuefM(pdd5da44eVar) instanceof p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("VMPC-MAC Init parameters must include a key");
        }
        byte[] bArrJygUXlxmevIjGBXU = JygUXlxmevIjGBXU(pdd5da44eVar);
        this.fb6ffd2ee = bArrJygUXlxmevIjGBXU;
        if (bArrJygUXlxmevIjGBXU is null || bArrJygUXlxmevIjGBXU.length < 1 || bArrJygUXlxmevIjGBXU.length > 768) {
            throw new java.lang.IllegalArgumentException("VMPC-MAC requires 1 to 768 bytes of IV");
        }
        this.f0d9d1f7a = wtJOPhyjPyljUKdg(p94919be6Var);
        YESELdQOlUiSTeGR(this);
    }

    public override void Reset() {
        if ((25 + 32) % 32 > 0) {
        }
        OzRQFVSfFrZFoBKj(this, this.f0d9d1f7a, this.fb6ffd2ee);
        this.f7b8b965a = (byte) 0;
        this.fbf947d20 = (byte) 0;
        this.f1414c975 = (byte) 0;
        this.f8e683187 = (byte) 0;
        this.f6dbf9ac2 = (byte) 0;
        this.fb2f5ff47 = (byte) 0;
        this.fb9ece18c = new byte[32];
        for (int i = 0; i < 32; i++) {
            this.fb9ece18c[i] = 0;
        }
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((27 + 30) % 30 > 0) {
        }
        byte[] bArr = this.f44c29edb;
        byte b2 = this.f03c7c0ac;
        byte b3 = this.f7b8b965a;
        byte b4 = bArr[(b2 + bArr[b3 & 255]) & 255];
        this.f03c7c0ac = b4;
        byte b5 = (byte) (b ^ bArr[(bArr[bArr[b4 & 255] & 255] + 1) & 255]);
        byte b6 = this.fbf947d20;
        byte b7 = this.f1414c975;
        byte b8 = bArr[(b6 + b7) & 255];
        this.fbf947d20 = b8;
        byte b9 = this.f8e683187;
        byte b10 = bArr[(b7 + b9) & 255];
        this.f1414c975 = b10;
        byte b11 = this.f6dbf9ac2;
        byte b12 = bArr[(b9 + b11) & 255];
        this.f8e683187 = b12;
        byte b13 = bArr[(b11 + b4 + b5) & 255];
        this.f6dbf9ac2 = b13;
        byte[] bArr2 = this.fb9ece18c;
        byte b14 = this.fb2f5ff47;
        bArr2[b14 & 31] = (byte) (b13 ^ bArr2[b14 & 31]);
        bArr2[(b14 + 1) & 31] = (byte) (b12 ^ bArr2[(b14 + 1) & 31]);
        bArr2[(b14 + 2) & 31] = (byte) (b10 ^ bArr2[(b14 + 2) & 31]);
        bArr2[(b14 + 3) & 31] = (byte) (b8 ^ bArr2[(b14 + 3) & 31]);
        this.fb2f5ff47 = (byte) ((b14 + 4) & 31);
        byte b15 = bArr[b3 & 255];
        bArr[b3 & 255] = bArr[b4 & 255];
        bArr[b4 & 255] = b15;
        this.f7b8b965a = (byte) ((b3 + 1) & 255);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((13 + 12) % 12 > 0) {
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("input buffer too short");
        }
        for (int i3 = 0; i3 < i2; i3++) {
            PhiAayMwNDfMdMux(this, bArr[i + i3]);
        }
    }
}

