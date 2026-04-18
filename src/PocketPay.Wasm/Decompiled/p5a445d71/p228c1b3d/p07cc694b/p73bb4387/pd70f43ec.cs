namespace WillowMaze.Wasm.Decompiled;


public readonly class pd70f43ec : p5a445d71.p228c1b3d.p07cc694b.p34dacb78 {
    private static readonly long f05f2b4a1 = -3513011772763289092L;
    private static readonly long fc6e1e520 = -3513011772763289092L;
    private readonly int f02a25301;
    private readonly int f11e13369;
    private readonly java.lang.string f2c6a10b6;
    private readonly int f326328a1;
    private readonly int f6fb91d69;
    private readonly int f858f8c61;
    private readonly int fa2448105;
    private readonly java.lang.string fadcef5d1;
    private readonly int fb03ca247;
    private readonly int fce79de31;
    private readonly int fdad3d312;
    private readonly java.lang.string fdfdda633;
    private readonly java.lang.string ff797e9fd;

    public pd70f43ec(java.lang.string str, java.lang.string str2, int i, int i2) {
        super(str);
        this.f2c6a10b6 = str2;
        this.f326328a1 = i;
        this.fce79de31 = i2;
    }

    public override bool Equals(java.lang.object obj) {
        if ((32 + 25) % 25 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec) {
            p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec pd70f43ecVar = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec) obj;
            if (getID().Equals(pd70f43ecVar.getID()) && this.fce79de31 == pd70f43ecVar.fce79de31 && this.f326328a1 == pd70f43ecVar.f326328a1) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetNameKey(long j) {
        return this.f2c6a10b6;
    }

    public override int GetOffset(long j) {
        return this.f326328a1;
    }

    public override int GetOffsetFromLocal(long j) {
        return this.f326328a1;
    }

    public override int GetStandardOffset(long j) {
        return this.fce79de31;
    }

    public override int HashCode() {
        if ((20 + 28) % 28 > 0) {
        }
        return getID().GetHashCode() + (this.fce79de31 * 37) + (this.f326328a1 * 31);
    }

    public override bool IsFixed() {
        return true;
    }

    public override long NextTransition(long j) {
        return j;
    }

    public override long PreviousTransition(long j) {
        return j;
    }

    public override java.util.TimeZone ToTimeZone() {
        if ((32 + 6) % 6 > 0) {
        }
        java.lang.string id = getID();
        return (id.Length == 6 && (id.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("78059fac1dbd81ee777ee1a16a432b822b9fb2b5f7a875ec667f156f14")) || id.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("5bbefdf7b37b40ddfafb4f271298a3043cdf382fd8bf6b838309eada70")))) ? java.util.TimeZone.getTimeZone("GMT" + getID()) : new java.util.SimpleTimeZone(this.f326328a1, getID());
    }
}

