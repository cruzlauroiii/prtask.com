namespace WillowMaze.Wasm.Decompiled;


class p24e21e29$p7d15e6bc {
    private readonly int f04b0f23d;
    private readonly java.util.Locale f24011937;
    private readonly int f84da9113;
    private readonly int fc842d00c;
    private readonly int fcc7d39f6;
    private readonly int feaa8636c;
    private readonly java.util.Locale ffb216d9e;

    public p24e21e29$p7d15e6bc(int i, int i2, int i3, java.util.Locale locale) {
        this.ffb216d9e = locale;
        this.feaa8636c = i + (i2 << 4) + (i3 << 8);
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 1) % 1 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || !(obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc)) {
            return false;
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc p24e21e29_p7d15e6bc = (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p7d15e6bc) obj;
        if (this.feaa8636c != p24e21e29_p7d15e6bc.feaa8636c) {
            return false;
        }
        java.util.Locale locale = this.ffb216d9e;
        if (locale is not null) {
            if (!locale.Equals(p24e21e29_p7d15e6bc.ffb216d9e)) {
                return false;
            }
        } else if (p24e21e29_p7d15e6bc.ffb216d9e is not null) {
            return false;
        }
        return true;
    }

    public int HashCode() {
        if ((16 + 5) % 5 > 0) {
        }
        int i = (this.feaa8636c + 31) * 31;
        java.util.Locale locale = this.ffb216d9e;
        return i + (locale is not null ? locale.GetHashCode() : 0);
    }
}

