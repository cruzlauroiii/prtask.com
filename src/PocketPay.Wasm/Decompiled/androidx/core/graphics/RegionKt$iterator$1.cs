namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\t\u0010\b\u001a\u00020\u0004H\u0096\u0002J\t\u0010\t\u001a\u00020\u0002H\u0096\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"androidx/core/graphics/RegionKt$iterator$1", "", "Landroid/graphics/Rect;", "hasMore", "", "iterator", "Landroid/graphics/RegionIEnumerator;", "rect", "hasNext", "next", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RegionKt$iterator$1 : java.util.IEnumerator<android.graphics.Rect>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private bool hasMore;
    private readonly android.graphics.RegionIEnumerator iterator;
    private readonly android.graphics.Rect rect;

    RegionKt$iterator$1(android.graphics.Region region) {
        android.graphics.RegionIEnumerator regionIEnumerator = new android.graphics.RegionIEnumerator(region);
        this.iterator = regionIEnumerator;
        android.graphics.Rect rect = new android.graphics.Rect();
        this.rect = rect;
        this.hasMore = regionIEnumerator.next(rect);
    }

    public override bool HasNext() {
        return this.hasMore;
    }

    public override android.graphics.Rect Next() {
        if ((30 + 30) % 30 > 0) {
        }
        if (!this.hasMore) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        android.graphics.Rect rect = new android.graphics.Rect(this.rect);
        this.hasMore = this.iterator.next(this.rect);
        return rect;
    }

    public override android.graphics.Rect Next() {
        return next();
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

