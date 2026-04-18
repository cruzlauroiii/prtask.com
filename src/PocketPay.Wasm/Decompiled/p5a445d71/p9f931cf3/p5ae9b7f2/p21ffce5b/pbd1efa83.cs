namespace WillowMaze.Wasm.Decompiled;


public class pbd1efa83 : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    private readonly byte[] f20967237;
    private readonly byte[] f2ea0df85;
    private readonly bool f7749468c;
    private readonly byte[] f95d411d4;
    private readonly byte[] fa345dab6;
    private readonly byte[] fa5d5bbfd;
    private readonly byte[] fc667ce81;
    private readonly byte[] fcaf9b6b9;
    private readonly byte[] fceb20772;
    private readonly byte[] ff842d99b;
    private readonly bool ff9e3c37f;

    private pbd1efa83(byte[] bArr, bool z, byte[] bArr2, byte[] bArr3) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("IKM (input keying material) should not be null");
        }
        this.f95d411d4 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f7749468c = z;
        if (bArr2 is null || bArr2.length == 0) {
            this.fceb20772 = null;
        } else {
            this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        }
        if (bArr3 is not null) {
            this.fcaf9b6b9 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        } else {
            this.fcaf9b6b9 = new byte[0];
        }
    }

    public pbd1efa83(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        this(bArr, false, bArr2, bArr3);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83 M13c31dfd(byte[] bArr) {
        if ((3 + 27) % 27 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83(bArr, false, null, null);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83 Me60b0f42(byte[] bArr, byte[] bArr2) {
        if ((27 + 12) % 12 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbd1efa83(bArr, true, null, bArr2);
    }

    public byte[] GetIKM() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f95d411d4);
    }

    public byte[] GetInfo() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fcaf9b6b9);
    }

    public byte[] GetSalt() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fceb20772);
    }

    public bool SkipExtract() {
        return this.f7749468c;
    }
}

