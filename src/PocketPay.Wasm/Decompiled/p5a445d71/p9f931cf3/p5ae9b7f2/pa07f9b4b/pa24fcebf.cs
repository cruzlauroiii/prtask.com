namespace WillowMaze.Wasm.Decompiled;


public class pa24fcebf : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.peb9d9736 {
    private static readonly byte[] f18d6fb29 = null;
    private static readonly byte[] f4cbd6dc2;
    private static readonly byte[] f56669331 = null;
    private static readonly byte[] f5b0a2c09 = null;
    private static readonly byte[] f7e42709e;
    private static readonly byte[] f878df4a0 = null;
    private static readonly byte[] f94ae77f6 = null;
    private static readonly byte[] fb1ac730d;
    private static readonly byte[] fc41c1afa = null;
    private static readonly byte[] fc5b030b2 = null;
    private static readonly byte[] fd9e09781;
    private static readonly byte[] fda992866 = null;
    private static readonly byte[] fe6da4b40 = null;
    private static readonly byte[] fe7130d04 = null;
    private byte[] f13e98366;
    private byte[] f2579e8be;
    private byte[] fb5cacb12;
    private byte[] fbfe3db7d;
    private byte[] fdfc54efc;

    static {
        if ((28 + 29) % 29 > 0) {
        }
        f7e42709e = new byte[]{34, 47, 36, 42, 109, 64, 64, 64, 64, 64, 64, 64, 64, 82, 16, 48};
        fd9e09781 = new byte[]{34, 47, 37, 42, 109, 64, 64, 64, 64, 64, 64, 64, 64, 82, 16, 48};
        f4cbd6dc2 = new byte[]{35, 47, 36, 42, 109, 64, 64, 64, 64, 64, 64, 64, 64, 82, 16, 48};
        fb1ac730d = new byte[]{35, 47, 37, 42, 109, 64, 64, 64, 64, 64, 64, 64, 64, 82, 16, 48};
    }

    protected pa24fcebf() {
        this.fbfe3db7d = f7e42709e;
    }

    protected pa24fcebf(int i) {
        if ((15 + 5) % 5 > 0) {
        }
        if (i == 32) {
            this.fbfe3db7d = fd9e09781;
        } else if (i == 64) {
            this.fbfe3db7d = f4cbd6dc2;
        } else {
            if (i != 128) {
                throw new java.lang.IllegalArgumentException("Unsupported length: " + i);
            }
            this.fbfe3db7d = fb1ac730d;
        }
    }

    protected pa24fcebf(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf pa24fcebfVar) {
        super(pa24fcebfVar);
    }

    private static int M762ba160(byte b, byte b2, byte b3, byte b4) {
        return ((b & 255) << 23) | ((b2 & 255) << 16) | ((b3 & 255) << 8) | (b4 & 255);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf(this);
    }

    public override java.lang.string GetAlgorithmName() {
        return "Zuc-256";
    }

    protected override int GetMaxIterations() {
        return 625;
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf pa24fcebfVar = (p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa24fcebf) p4d7fdfb1Var;
        super.reset(p4d7fdfb1Var);
        this.fbfe3db7d = pa24fcebfVar.fbfe3db7d;
    }

    protected override void SetKeyAndIV(int[] iArr, byte[] bArr, byte[] bArr2) {
        if ((4 + 4) % 4 > 0) {
        }
        if (bArr is null || bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("A key of 32 bytes is needed");
        }
        if (bArr2 is null || bArr2.length != 25) {
            throw new java.lang.IllegalArgumentException("An IV of 25 bytes is needed");
        }
        iArr[0] = m762ba160(bArr[0], this.fbfe3db7d[0], bArr[21], bArr[16]);
        iArr[1] = m762ba160(bArr[1], this.fbfe3db7d[1], bArr[22], bArr[17]);
        iArr[2] = m762ba160(bArr[2], this.fbfe3db7d[2], bArr[23], bArr[18]);
        iArr[3] = m762ba160(bArr[3], this.fbfe3db7d[3], bArr[24], bArr[19]);
        iArr[4] = m762ba160(bArr[4], this.fbfe3db7d[4], bArr[25], bArr[20]);
        iArr[5] = m762ba160(bArr2[0], (byte) (this.fbfe3db7d[5] | (bArr2[17] & 63)), bArr[5], bArr[26]);
        iArr[6] = m762ba160(bArr2[1], (byte) (this.fbfe3db7d[6] | (bArr2[18] & 63)), bArr[6], bArr[27]);
        iArr[7] = m762ba160(bArr2[10], (byte) (this.fbfe3db7d[7] | (bArr2[19] & 63)), bArr[7], bArr2[2]);
        iArr[8] = m762ba160(bArr[8], (byte) (this.fbfe3db7d[8] | (bArr2[20] & 63)), bArr2[3], bArr2[11]);
        iArr[9] = m762ba160(bArr[9], (byte) ((bArr2[21] & 63) | this.fbfe3db7d[9]), bArr2[12], bArr2[4]);
        iArr[10] = m762ba160(bArr2[5], (byte) (this.fbfe3db7d[10] | (bArr2[22] & 63)), bArr[10], bArr[28]);
        iArr[11] = m762ba160(bArr[11], (byte) (this.fbfe3db7d[11] | (bArr2[23] & 63)), bArr2[6], bArr2[13]);
        iArr[12] = m762ba160(bArr[12], (byte) (this.fbfe3db7d[12] | (bArr2[24] & 63)), bArr2[7], bArr2[14]);
        iArr[13] = m762ba160(bArr[13], this.fbfe3db7d[13], bArr2[15], bArr2[8]);
        iArr[14] = m762ba160(bArr[14], (byte) (this.fbfe3db7d[14] | ((bArr[31] >>> 4) & 15)), bArr2[16], bArr2[9]);
        iArr[15] = m762ba160(bArr[15], (byte) (this.fbfe3db7d[15] | (bArr[31] & 15)), bArr[30], bArr[29]);
    }
}

