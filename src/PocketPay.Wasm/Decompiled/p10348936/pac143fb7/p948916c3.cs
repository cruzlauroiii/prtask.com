namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp10348936/pac143fb7/p948916c3;", "Lp10348936/pac143fb7/p72a4cee5;", "inventorizationDetailsFilterRepository", "Lp10348936/pb3f20355/p8f525d50;", "<init>", "(Lp10348936/pb3f20355/p8f525d50;)V", "getFilter", "Lp10348936/pf5e638cc/p0729f18f;", "updateFilter", "", "filter", "feature-inventorization-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p948916c3 : p10348936.pac143fb7.p72a4cee5 {
    private readonly p10348936.pb3f20355.p8f525d50 fc18aa2da;
    private readonly p10348936.pb3f20355.p8f525d50 fe4430504;

    public p948916c3(p10348936.pb3f20355.p8f525d50 p8f525d50Var) {
        hFxdfZjtdTYrUzkU(p8f525d50Var, "inventorizationDetailsFilterRepository");
        this.fe4430504 = p8f525d50Var;
    }

    public static p10348936.pf5e638cc.p0729f18f CrVjyxXbKIYAzAil(p10348936.pb3f20355.p8f525d50 p8f525d50Var) {
        return p8f525d50Var.getFilter();
    }

    public static void DshBeMatHUylXAhl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HFxdfZjtdTYrUzkU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PoOfGxiLRJYGNxTa(p10348936.pb3f20355.p8f525d50 p8f525d50Var, p10348936.pf5e638cc.p0729f18f p0729f18fVar) {
        p8f525d50Var.updateFilter(p0729f18fVar);
    }

    public override p10348936.pf5e638cc.p0729f18f GetFilter() {
        return CrVjyxXbKIYAzAil(this.fe4430504);
    }

    public override void UpdateFilter(p10348936.pf5e638cc.p0729f18f filter) {
        DshBeMatHUylXAhl(filter, "filter");
        poOfGxiLRJYGNxTa(this.fe4430504, filter);
    }
}

