namespace WillowMaze.Wasm.Decompiled;


class p364bf33a$p2d9b4b46 {
    private readonly int f3c6e0b8a;
    private readonly byte[] f3fab73de;
    private readonly byte[] f3fe5c18e;
    private readonly byte[] f41bb118a;
    private readonly byte[] f6d40f2f3;
    private readonly int f7e4acc11;

    p364bf33a$p2d9b4b46(byte[] bArr) {
        this.f3c6e0b8a = RtdHnALXylfqukNq(bArr);
        this.f41bb118a = bArr;
    }

    public static bool MshMlEAWpMiRXYKr(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static int RtdHnALXylfqukNq(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p364bf33a$p2d9b4b46) {
            return MshMlEAWpMiRXYKr(this.f41bb118a, ((p5a445d71.p7c922baa.pca323100.p364bf33a$p2d9b4b46) obj).f41bb118a);
        }
        return false;
    }

    public int HashCode() {
        return this.f3c6e0b8a;
    }
}

