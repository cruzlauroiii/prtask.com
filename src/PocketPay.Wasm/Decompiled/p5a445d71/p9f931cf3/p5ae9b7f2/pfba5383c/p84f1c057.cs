namespace WillowMaze.Wasm.Decompiled;


public class p84f1c057 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private static readonly byte f09b5f508 = 54;
    private static readonly byte f13110c36 = 54;
    private static readonly byte f15374a1c = 54;
    private static readonly byte f5b377a1e = 92;
    private static readonly byte fa23f5bd7 = 92;
    private static readonly byte fb1bfe26c = 54;
    private static readonly int fe3a0a6b0 = 64;
    private static readonly int fe76739cb = 64;
    private int f08501003;
    private byte[] f246c6bb3;
    private byte[] f2862ab37;
    private byte[] f477c684e;
    private int f4c64bc33;
    private byte[] f58860f06;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7f160557;
    private int f9255f8d1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f9dde1bea;
    private byte[] f9fd97ad1;
    private byte[] fb4f33c31;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fd027420f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fed5a2f7c;

    public p84f1c057(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((31 + 21) % 21 > 0) {
        }
        this.f246c6bb3 = new byte[64];
        this.f477c684e = new byte[64];
        this.fc10f7796 = pe5cfc515Var;
        this.f9255f8d1 = pe5cfc515Var.getDigestSize();
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((13 + 21) % 21 > 0) {
        }
        int i2 = this.f9255f8d1;
        byte[] bArr2 = new byte[i2];
        this.fc10f7796.doFinal(bArr2, 0);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        byte[] bArr3 = this.f477c684e;
        pe5cfc515Var.update(bArr3, 0, bArr3.length);
        this.fc10f7796.update(bArr2, 0, i2);
        int iDoFinal = this.fc10f7796.doFinal(bArr, i);
        reset();
        return iDoFinal;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fc10f7796.getAlgorithmName() + "/HMAC";
    }

    public override int GetMacSize() {
        return this.f9255f8d1;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetUnderlyingDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((29 + 32) % 32 > 0) {
        }
        this.fc10f7796.reset();
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        if (key.length <= 64) {
            java.lang.System.arraycopy(key, 0, this.f246c6bb3, 0, key.length);
            int length = key.length;
            while (true) {
                byte[] bArr = this.f246c6bb3;
                if (length >= bArr.length) {
                    break;
                }
                bArr[length] = 0;
                length++;
            }
        } else {
            this.fc10f7796.update(key, 0, key.length);
            this.fc10f7796.doFinal(this.f246c6bb3, 0);
            int i = this.f9255f8d1;
            while (true) {
                byte[] bArr2 = this.f246c6bb3;
                if (i >= bArr2.length) {
                    break;
                }
                bArr2[i] = 0;
                i++;
            }
        }
        byte[] bArr3 = this.f246c6bb3;
        byte[] bArr4 = new byte[bArr3.length];
        this.f477c684e = bArr4;
        java.lang.System.arraycopy(bArr3, 0, bArr4, 0, bArr3.length);
        int i2 = 0;
        while (true) {
            byte[] bArr5 = this.f246c6bb3;
            if (i2 >= bArr5.length) {
                break;
            }
            bArr5[i2] = (byte) (bArr5[i2] ^ 54);
            i2++;
        }
        int i3 = 0;
        while (true) {
            byte[] bArr6 = this.f477c684e;
            if (i3 >= bArr6.length) {
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
                byte[] bArr7 = this.f246c6bb3;
                pe5cfc515Var.update(bArr7, 0, bArr7.length);
                return;
            }
            bArr6[i3] = (byte) (bArr6[i3] ^ 92);
            i3++;
        }
    }

    public override void Reset() {
        if ((24 + 20) % 20 > 0) {
        }
        this.fc10f7796.reset();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        byte[] bArr = this.f246c6bb3;
        pe5cfc515Var.update(bArr, 0, bArr.length);
    }

    public override void Update(byte b) {
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }
}

