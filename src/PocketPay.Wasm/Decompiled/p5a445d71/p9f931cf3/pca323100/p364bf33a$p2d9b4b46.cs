namespace WillowMaze.Wasm.Decompiled;


class p364bf33a$p2d9b4b46 {
    private readonly int f1d5d6d86;
    private readonly int f21fa853e;
    private readonly int f3c6e0b8a;
    private readonly byte[] f445df937;
    private readonly int f940bc5c3;
    private readonly byte[] f98bf7d8c;
    private readonly byte[] fc0b4f5f1;
    private readonly int fdb4ce7b2;

    p364bf33a$p2d9b4b46(byte[] bArr) {
        this.f3c6e0b8a = NxCOsaYdbxXXeRQp(bArr);
        this.f98bf7d8c = bArr;
    }

    public static int NxCOsaYdbxXXeRQp(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static bool SzFrOQUxcOZTouAe(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p364bf33a$p2d9b4b46) {
            return SzFrOQUxcOZTouAe(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p364bf33a$p2d9b4b46) obj).f98bf7d8c);
        }
        return false;
    }

    public int HashCode() {
        return this.f3c6e0b8a;
    }
}

