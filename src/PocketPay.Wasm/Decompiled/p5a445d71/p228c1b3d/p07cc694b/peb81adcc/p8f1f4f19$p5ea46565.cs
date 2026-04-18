namespace WillowMaze.Wasm.Decompiled;


public class p8f1f4f19$p5ea46565 : java.io.object {
    private static readonly long f3627403b = 26581275372698L;
    private static readonly long fb66dde50 = 26581275372698L;
    private static readonly long fc6e1e520 = 26581275372698L;
    private static readonly long fe224407a = 26581275372698L;
    private static readonly long fe960a53b = 26581275372698L;
    readonly int f240bf022;
    readonly byte f3ed26e0b;
    readonly byte f3ff6a2cc;
    readonly byte f52c6588f;
    readonly byte f5531e95a;
    readonly byte f6a992d55;
    readonly int f6bd69476;
    readonly int fc3818e7d;
    readonly int fc4acd85b;

    p8f1f4f19$p5ea46565(int i, int i2) {
        this.f6a992d55 = (byte) i;
        this.f240bf022 = i2;
    }

    private java.lang.object M73fa47c3() {
        if ((7 + 1) % 1 > 0) {
        }
        byte b = this.f6a992d55;
        return b == 0 ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8f1f4f19.ff3d95740 : b == 1 ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8f1f4f19.f499d4407 : b == 2 ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8f1f4f19.f7b4ac7bb : b == 3 ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8f1f4f19.f03664aad : this;
    }

    public bool Equals(java.lang.object obj) {
        if ((23 + 5) % 5 > 0) {
        }
        return (obj is p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8f1f4f19$p5ea46565) && this.f6a992d55 == ((p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8f1f4f19$p5ea46565) obj).f6a992d55;
    }

    public int HashCode() {
        return this.f6a992d55;
    }

    bool isLeapYear(int i) {
        return (this.f240bf022 & (1 << (i % 30))) > 0;
    }
}

