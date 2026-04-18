namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0007H\u0016J\b\u0010\u000b\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp10348936/pac143fb7/pecece68a;", "Lp10348936/pac143fb7/pdfe8a462;", "inventorizationConsoleFilterRepository", "Lp10348936/pb3f20355/p4f3ed78e;", "<init>", "(Lp10348936/pb3f20355/p4f3ed78e;)V", "getFilter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "updateFilter", "", "filter", "resetFilter", "feature-inventorization-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pecece68a : p10348936.pac143fb7.pdfe8a462 {
    private readonly p10348936.pb3f20355.p4f3ed78e f1fac2311;
    private readonly p10348936.pb3f20355.p4f3ed78e f728b96a5;
    private readonly p10348936.pb3f20355.p4f3ed78e f76ade1f6;
    private readonly p10348936.pb3f20355.p4f3ed78e f7d5c0d04;
    private readonly p10348936.pb3f20355.p4f3ed78e ff873b400;

    public pecece68a(p10348936.pb3f20355.p4f3ed78e p4f3ed78eVar) {
        EzhaamJQziBpXZaV(p4f3ed78eVar, "inventorizationConsoleFilterRepository");
        this.f728b96a5 = p4f3ed78eVar;
    }

    public static void EzhaamJQziBpXZaV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c GmgexTBcoUawhYsu(p10348936.pb3f20355.p4f3ed78e p4f3ed78eVar) {
        return p4f3ed78eVar.getFilter();
    }

    public static void UIpNdOJwekxcnENf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XTenbwwIINWuaxdm(p10348936.pb3f20355.p4f3ed78e p4f3ed78eVar) {
        p4f3ed78eVar.resetFilter();
    }

    public static void MSoWHhPRMsevoFOy(p10348936.pb3f20355.p4f3ed78e p4f3ed78eVar, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        p4f3ed78eVar.updateFilter(pd7778d0cVar);
    }

    public override pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c GetFilter() {
        return GmgexTBcoUawhYsu(this.f728b96a5);
    }

    public override void ResetFilter() {
        XTenbwwIINWuaxdm(this.f728b96a5);
    }

    public override void UpdateFilter(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c filter) {
        UIpNdOJwekxcnENf(filter, "filter");
        mSoWHhPRMsevoFOy(this.f728b96a5, filter);
    }
}

