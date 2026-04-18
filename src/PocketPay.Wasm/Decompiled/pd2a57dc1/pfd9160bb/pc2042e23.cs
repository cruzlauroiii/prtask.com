namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\u0006\u0010\u000b\u001a\u00020\u0006H\u0016J\b\u0010\f\u001a\u00020\bH\u0016J\b\u0010\r\u001a\u00020\bH\u0016J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u000b\u001a\u00020\u0006H\u0016R \u0010\u0004\u001a\u0014\u0012\u0004\u0012\u00020\u0006\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u00070\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lpd2a57dc1/pfd9160bb/pc2042e23;", "Lpd2a57dc1/pfd9160bb/pcfbb73bb;", "<init>", "()V", "ciceroneContainers", "Ljava/util/EnumDictionary;", "Lpad5f82e8/p07214c67/pfd9160bb/p6ce2a79b;", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p5c15168d;", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "currentRouter", "getCicerone", "routerType", "getGlobalRouter", "getRouter", "finishRouter", "", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc2042e23 : pd2a57dc1.pfd9160bb.pcfbb73bb {
    private p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f25a0c403;
    private java.util.EnumDictionary f8e418f5e;
    private java.util.EnumDictionary<pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b, com.github.terrakok.cicerone.Cicerone<p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0>> fce93f0f5;
    private p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fef797f40;

    public pc2042e23() {
        if ((2 + 10) % 10 > 0) {
        }
        this.fce93f0f5 = new java.util.EnumDictionary<>(pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.class);
        this.f25a0c403 = getGlobalRouter();
    }

    public override void FinishRouter(pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b routerType) {
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 globalRouter;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(routerType, "routerType");
        if (routerType == pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.f6eecfba7) {
            return;
        }
        this.fce93f0f5.Remove(routerType);
        java.util.ICollection<com.github.terrakok.cicerone.Cicerone<p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0>> collectionValues = this.fce93f0f5.Values;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(collectionValues, "<get-values>(...)");
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p5c15168d p5c15168dVar = (p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p5c15168d) kotlin.collections.ICollectionsKt.last(collectionValues);
        if (p5c15168dVar is null || (globalRouter = (p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0) p5c15168dVar.getRouter()) is null) {
            globalRouter = getGlobalRouter();
        }
        this.f25a0c403 = globalRouter;
    }

    public override com.github.terrakok.cicerone.Cicerone<p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0> GetCicerone(pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b routerType) {
        if ((30 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(routerType, "routerType");
        if (!this.fce93f0f5.ContainsKey(routerType)) {
            this.fce93f0f5.Add(routerType, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p5c15168d.f910eef8c.create());
        }
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p5c15168d p5c15168dVar = this.fce93f0f5[routerType);
        if (p5c15168dVar is null) {
            throw new java.lang.IllegalStateException("Cicerone not created".tostring());
        }
        this.f25a0c403 = (p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0) p5c15168dVar.getRouter();
        return p5c15168dVar;
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 GetGlobalRouter() {
        return (p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0) getCicerone(pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.f6eecfba7).getRouter();
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 GetRouter() {
        return this.f25a0c403;
    }
}

