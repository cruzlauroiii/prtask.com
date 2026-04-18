namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp83f5c3ad/p684019bc/pe129a3e5;", "Lp83f5c3ad/p684019bc/p93d31ced;", "tophChooseRegionRepository", "Lp83f5c3ad/pb3f20355/p35df8398;", "<init>", "(Lp83f5c3ad/pb3f20355/p35df8398;)V", "getRegions", "", "Lpad5f82e8/p07214c67/p83f5c3ad/pf447ac85;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe129a3e5 : p83f5c3ad.p684019bc.p93d31ced {
    private readonly p83f5c3ad.pb3f20355.p35df8398 f3529bd68;
    private readonly p83f5c3ad.pb3f20355.p35df8398 f8f3bbdd5;
    private readonly p83f5c3ad.pb3f20355.p35df8398 fe9c8d792;
    private readonly p83f5c3ad.pb3f20355.p35df8398 ff9ac664a;

    public pe129a3e5(p83f5c3ad.pb3f20355.p35df8398 tophChooseRegionRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophChooseRegionRepository, "tophChooseRegionRepository");
        this.fe9c8d792 = tophChooseRegionRepository;
    }

    public override java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> GetRegions() {
        return this.fe9c8d792.getRegions();
    }
}

