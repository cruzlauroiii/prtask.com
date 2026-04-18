namespace WillowMaze.Wasm.Decompiled;


class pe091a7ed$pbdfc7a32 : p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d {
    private readonly long f06bd97aa;
    private readonly long f74f57a56;

    pe091a7ed$pbdfc7a32(long j) {
        this.f74f57a56 = j;
    }

    public override long GetMillis() {
        if ((22 + 3) % 3 > 0) {
        }
        return java.lang.System.currentTimeMillis() + this.f74f57a56;
    }
}

