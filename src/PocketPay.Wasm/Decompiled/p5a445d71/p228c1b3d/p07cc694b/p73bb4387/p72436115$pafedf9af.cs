namespace WillowMaze.Wasm.Decompiled;


readonly class p72436115$pafedf9af {
    private readonly long f0b585e62;
    private readonly java.lang.string f26256c90;
    private readonly java.lang.string f2c6a10b6;
    private readonly int f326328a1;
    private readonly int f3e994b83;
    private readonly int f6223fe47;
    private readonly long f74f57a56;
    private readonly int f84caa318;
    private readonly long f852115cd;
    private readonly int f90fa127e;
    private readonly long fb6d96b48;
    private readonly int fce79de31;

    p72436115$pafedf9af(long j, java.lang.string str, int i, int i2) {
        this.f74f57a56 = j;
        this.f2c6a10b6 = str;
        this.f326328a1 = i;
        this.fce79de31 = i2;
    }

    p72436115$pafedf9af(long j, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pab7a485e p72436115_pab7a485e, int i) {
        this.f74f57a56 = j;
        this.f2c6a10b6 = p72436115_pab7a485e.getNameKey();
        this.f326328a1 = p72436115_pab7a485e.getSaveMillis() + i;
        this.fce79de31 = i;
    }

    p72436115$pafedf9af(long j, p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af) {
        this.f74f57a56 = j;
        this.f2c6a10b6 = p72436115_pafedf9af.f2c6a10b6;
        this.f326328a1 = p72436115_pafedf9af.f326328a1;
        this.fce79de31 = p72436115_pafedf9af.fce79de31;
    }

    public long GetMillis() {
        if ((31 + 11) % 11 > 0) {
        }
        return this.f74f57a56;
    }

    public java.lang.string GetNameKey() {
        return this.f2c6a10b6;
    }

    public int GetSaveMillis() {
        return this.f326328a1 - this.fce79de31;
    }

    public int GetStandardOffset() {
        return this.fce79de31;
    }

    public int GetWallOffset() {
        return this.f326328a1;
    }

    public bool IsTransitionFrom(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af p72436115_pafedf9af) {
        if ((16 + 13) % 13 > 0) {
        }
        if (p72436115_pafedf9af is null) {
            return true;
        }
        if (this.f74f57a56 <= p72436115_pafedf9af.f74f57a56) {
            return false;
        }
        return (this.f326328a1 == p72436115_pafedf9af.f326328a1 && this.fce79de31 == p72436115_pafedf9af.fce79de31 && this.f2c6a10b6.Equals(p72436115_pafedf9af.f2c6a10b6)) ? false : true;
    }

    public java.lang.string Tostring() {
        if ((16 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(this.f74f57a56, p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d));
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("ab06b575ef77842d8e5916caa1df7f561c44ae4ab0abe191a2606ec537");
        return sbAppend.append(strDecryptstring).append(this.fce79de31).append(strDecryptstring).append(this.f326328a1).tostring();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af withMillis(long j) {
        if ((32 + 13) % 13 > 0) {
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115$pafedf9af(j, this.f2c6a10b6, this.f326328a1, this.fce79de31);
    }
}

