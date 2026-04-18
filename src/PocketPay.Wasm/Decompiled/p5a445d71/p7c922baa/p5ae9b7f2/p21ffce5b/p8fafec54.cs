namespace WillowMaze.Wasm.Decompiled;


public readonly class p8fafec54 : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    private byte[] f00c3b176;
    private byte[] f06bcd385;
    private int f1146e4db;
    private byte[] f165f9926;
    private int f1b5aa2bc;
    private int f3d48cd0a;
    private int f4b43b0ae;
    private byte[] f69dc7ea6;
    private byte[] f6e101f1f;
    private int f74041695;
    private byte[] f847a4dbd;
    private byte[] f8df24677;
    private byte[] f988287f7;
    private byte[] f9a25bae7;
    private byte[] fb1e7daf6;
    private byte[] fb4524c93;
    private byte[] fb56be6b8;
    private byte[] fc1c3bc7a;
    private byte[] fdccc4f0e;

    public p8fafec54(byte[] bArr, byte[] bArr2, int i) {
        this(bArr, null, bArr2, i);
    }

    public p8fafec54(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("A KDF requires Ki (a seed) as input");
        }
        this.f988287f7 = GQyyLDnbhvnOdMVW(bArr);
        if (bArr2 is not null) {
            this.fb4524c93 = DzzJKMMjRvBuAKBB(bArr2);
        } else {
            this.fb4524c93 = new byte[0];
        }
        if (bArr3 is not null) {
            this.f165f9926 = nlJEJypzlPQRssDW(bArr3);
        } else {
            this.f165f9926 = new byte[0];
        }
        if (i != 8 && i != 16 && i != 24 && i != 32) {
            throw new java.lang.IllegalArgumentException("Length of counter should be 8, 16, 24 or 32");
        }
        this.f4b43b0ae = i;
    }

    public static byte[] DzzJKMMjRvBuAKBB(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] GQyyLDnbhvnOdMVW(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] GbSPWFtXOpWEvrqn(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] SfAjbnQeVtWrkPcY(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] KiHkagsbhVREaDVH(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] NlJEJypzlPQRssDW(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetFixedInputData() {
        return SfAjbnQeVtWrkPcY(this.f165f9926);
    }

    public byte[] GetFixedInputDataCounterPrefix() {
        return GbSPWFtXOpWEvrqn(this.fb4524c93);
    }

    public byte[] GetFixedInputDataCounterSuffix() {
        return kiHkagsbhVREaDVH(this.f165f9926);
    }

    public byte[] GetKI() {
        return this.f988287f7;
    }

    public int GetR() {
        return this.f4b43b0ae;
    }
}

