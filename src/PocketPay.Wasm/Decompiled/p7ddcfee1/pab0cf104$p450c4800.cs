namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B%\u0012\n\u0010\u0002\u001a\u00060\u0003R\u00020\u0004\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\bJ\b\u0010\u0007\u001a\u00020\rH\u0016J\n\u0010\u0005\u001a\u0004\u0018\u00010\u000eH\u0016J\b\u0010\u000f\u001a\u00020\nH\u0016R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0015\u0010\u0002\u001a\u00060\u0003R\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0010"}, d2 = {"Lp7ddcfee1/pab0cf104$p450c4800;", "Lp7ddcfee1/p42c567ea;", "snapshot", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pd4e2713d;", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;", "contentType", "", "contentLength", "(Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pd4e2713d;Ljava/lang/string;Ljava/lang/string;)V", "bodySource", "Lp38cb8f46/pcc81e3f6;", "getSnapshot", "()Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pd4e2713d;", "", "Lp7ddcfee1/pba07c23c;", "source", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class pab0cf104$p450c4800 : p7ddcfee1.p42c567ea {
    private readonly java.lang.string f0282dc77;
    private readonly p38cb8f46.pcc81e3f6 f459b625a;
    private readonly p38cb8f46.pcc81e3f6 f771cb9a6;
    private readonly java.lang.string f7c4c906b;
    private readonly p38cb8f46.pcc81e3f6 fa76d3b88;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d fb1662e3e;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d fb42bcec7;
    private readonly java.lang.string fb9f1429c;
    private readonly p38cb8f46.pcc81e3f6 fc1deb7e8;
    private readonly java.lang.string fc22384f3;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d fc322d3de;
    private readonly java.lang.string fd8d57ecd;
    private readonly java.lang.string fdf5feafa;
    private readonly java.lang.string ff6c188c6;

    public pab0cf104$p450c4800(p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d snapshot, java.lang.string str, java.lang.string str2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(snapshot, "snapshot");
        this.fc322d3de = snapshot;
        this.fdf5feafa = str;
        this.fc22384f3 = str2;
        this.fc1deb7e8 = p38cb8f46.p0af9afa4.m7f2db423(new p7ddcfee1.pab0cf104$p450c4800$1(snapshot.getSource(1), this));
    }

    public override long ContentLength() {
        if ((4 + 9) % 9 > 0) {
        }
        java.lang.string str = this.fc22384f3;
        if (str is not null) {
            return p7ddcfee1.pd1efad72.p23e8a4b4.tolongOrDefault(str, -1L);
        }
        return -1L;
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        java.lang.string str = this.fdf5feafa;
        if (str is not null) {
            return p7ddcfee1.pba07c23c.f910eef8c.parse(str);
        }
        return null;
    }

    public readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d getSnapshot() {
        return this.fc322d3de;
    }

    public override p38cb8f46.pcc81e3f6 Source() {
        return this.fc1deb7e8;
    }
}

