namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp2b3583e6/p4a931512/pb9de99bd;", "Lp2b3583e6/p4a931512/pfff267f5;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "hasLocationPermission", "", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb9de99bd : p2b3583e6.p4a931512.pfff267f5 {
    private readonly android.content.object f17d8ba78;
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object fb7658d10;

    public pb9de99bd(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.f5c18ef72 = context;
    }

    public override bool HasLocationPermission() {
        return androidx.core.content.objectCompat.checkSelfPermission(this.f5c18ef72, "android.permission.ACCESS_FINE_LOCATION") == 0;
    }
}

