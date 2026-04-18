namespace WillowMaze.Wasm.Decompiled;


public class pbd1efa83 : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    private readonly byte[] f11ac0f2c;
    private readonly byte[] f4fac6fc7;
    private readonly bool f5aa55cd4;
    private readonly byte[] f747e287e;
    private readonly byte[] f755e02b2;
    private readonly bool f7749468c;
    private readonly byte[] f95d411d4;
    private readonly byte[] fb97a1d1e;
    private readonly byte[] fcaf9b6b9;
    private readonly byte[] fceb20772;
    private readonly byte[] fd81f1991;
    private readonly byte[] ff6f9aae5;

    private pbd1efa83(byte[] bArr, bool z, byte[] bArr2, byte[] bArr3) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("IKM (input keying material) should not be null");
        }
        this.f95d411d4 = wlucVasMbaLCiuWc(bArr);
        this.f7749468c = z;
        if (bArr2 is null || bArr2.length == 0) {
            this.fceb20772 = null;
        } else {
            this.fceb20772 = GBbzBJthGObSltNX(bArr2);
        }
        if (bArr3 is not null) {
            this.fcaf9b6b9 = THgrwLyxXfWiCROv(bArr3);
        } else {
            this.fcaf9b6b9 = new byte[0];
        }
    }

    public pbd1efa83(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        this(bArr, false, bArr2, bArr3);
    }

    public static byte[] GBbzBJthGObSltNX(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] THgrwLyxXfWiCROv(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] UCnkaJakiSkptBiS(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] ZwfNVamCTBoaSBBc(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbd1efa83 M13c31dfd(byte[] bArr) {
        if ((28 + 26) % 26 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbd1efa83(bArr, false, null, null);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbd1efa83 Me60b0f42(byte[] bArr, byte[] bArr2) {
        if ((25 + 3) % 3 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbd1efa83(bArr, true, null, bArr2);
    }

    public static byte[] UicqEsNrlNbETHfT(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] WlucVasMbaLCiuWc(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetIKM() {
        return UCnkaJakiSkptBiS(this.f95d411d4);
    }

    public byte[] GetInfo() {
        return uicqEsNrlNbETHfT(this.fcaf9b6b9);
    }

    public byte[] GetSalt() {
        return ZwfNVamCTBoaSBBc(this.fceb20772);
    }

    public bool SkipExtract() {
        return this.f7749468c;
    }
}

