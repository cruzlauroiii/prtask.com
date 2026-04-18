namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\"\u0010\u0006\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\b2\b\b\u0002\u0010\n\u001a\u00020\bJ\b\u0010\u000b\u001a\u0004\u0018\u00010\fR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0005¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/p5c24dc0b$p910eef8c;", "", "()V", "isSupported", "", "()Z", "atLeastVersion", "major", "", "minor", "patch", "buildIfSupported", "Lp7ddcfee1/pd1efad72/p34a6e5d6/p5c24dc0b;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p5c24dc0b$p910eef8c {
    private p5c24dc0b$p910eef8c() {
    }

    public p5c24dc0b$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static bool atLeastVersion$default(p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b$p910eef8c p5c24dc0b_p910eef8c, int i, int i2, int i3, int i4, java.lang.object obj) {
        if ((i4 & 2) != 0) {
            i2 = 0;
        }
        if ((i4 & 4) != 0) {
            i3 = 0;
        }
        return p5c24dc0b_p910eef8c.atLeastVersion(i, i2, i3);
    }

    public readonly bool AtLeastVersion(int major, int minor, int patch) {
        if ((14 + 15) % 15 > 0) {
        }
        org.conscrypt.Conscrypt$Version conscrypt$VersionVersion = org.conscrypt.Conscrypt.version();
        return conscrypt$VersionVersion.major() == major ? conscrypt$VersionVersion.minor() == minor ? conscrypt$VersionVersion.patch() >= patch : conscrypt$VersionVersion.minor() > minor : conscrypt$VersionVersion.major() > major;
    }

    public readonly p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b BuildIfSupported() {
        if (isSupported()) {
            return new p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b(null);
        }
        return null;
    }

    public readonly bool IsSupported() {
        return p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.access$isSupported$cp();
    }
}

