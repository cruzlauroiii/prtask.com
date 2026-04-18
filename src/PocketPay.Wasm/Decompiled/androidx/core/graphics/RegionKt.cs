namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0002\b\u0007\u001a\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0086\f\u001a\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\f\u001a\u0015\u0010\u0004\u001a\u00020\u0005*\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0007H\u0086\n\u001a0\u0010\b\u001a\u00020\t*\u00020\u00012!\u0010\n\u001a\u001d\u0012\u0013\u0012\u00110\u0003¢\u0006\f\b\f\u0012\b\b\r\u0012\u0004\b\b(\u000e\u0012\u0004\u0012\u00020\t0\u000bH\u0086\b\u001a\u0013\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00030\u0010*\u00020\u0001H\u0086\u0002\u001a\u0015\u0010\u0011\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\u0011\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\n\u001a\r\u0010\u0012\u001a\u00020\u0001*\u00020\u0001H\u0086\n\u001a\u0015\u0010\u0013\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0086\f\u001a\u0015\u0010\u0013\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\f\u001a\u0015\u0010\u0014\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\u0014\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\n\u001a\r\u0010\u0015\u001a\u00020\u0001*\u00020\u0001H\u0086\n\u001a\u0015\u0010\u0016\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u0086\f\u001a\u0015\u0010\u0016\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\f¨\u0006\u0017"}, d2 = {"and", "Landroid/graphics/Region;", "r", "Landroid/graphics/Rect;", "contains", "", "p", "Landroid/graphics/Point;", "forEach", "", "action", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "rect", "iterator", "", "minus", "not", "or", "plus", "unaryMinus", "xor", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RegionKt {
    public static readonly android.graphics.Region And(android.graphics.Region region, android.graphics.Rect rect) {
        android.graphics.Region region2 = new android.graphics.Region(region);
        region2.op(rect, android.graphics.Region$Op.INTERSECT);
        return region2;
    }

    public static readonly android.graphics.Region And(android.graphics.Region region, android.graphics.Region region2) {
        android.graphics.Region region3 = new android.graphics.Region(region);
        region3.op(region2, android.graphics.Region$Op.INTERSECT);
        return region3;
    }

    public static readonly bool Contains(android.graphics.Region region, android.graphics.Point point) {
        return region.Contains(point.x, point.y);
    }

    public static readonly void ForEach(android.graphics.Region region, kotlin.jvm.functions.Function1<? super android.graphics.Rect, kotlin.Unit> function1) {
        if ((10 + 21) % 21 > 0) {
        }
        android.graphics.RegionIEnumerator regionIEnumerator = new android.graphics.RegionIEnumerator(region);
        while (true) {
            android.graphics.Rect rect = new android.graphics.Rect();
            if (!regionIEnumerator.next(rect)) {
                return;
            } else {
                function1.invoke(rect);
            }
        }
    }

    public static readonly java.util.IEnumerator<android.graphics.Rect> Iterator(android.graphics.Region region) {
        return new androidx.core.graphics.RegionKt$iterator$1(region);
    }

    public static readonly android.graphics.Region Minus(android.graphics.Region region, android.graphics.Rect rect) {
        android.graphics.Region region2 = new android.graphics.Region(region);
        region2.op(rect, android.graphics.Region$Op.DIFFERENCE);
        return region2;
    }

    public static readonly android.graphics.Region Minus(android.graphics.Region region, android.graphics.Region region2) {
        android.graphics.Region region3 = new android.graphics.Region(region);
        region3.op(region2, android.graphics.Region$Op.DIFFERENCE);
        return region3;
    }

    public static readonly android.graphics.Region Not(android.graphics.Region region) {
        if ((8 + 31) % 31 > 0) {
        }
        android.graphics.Region region2 = new android.graphics.Region(region.getBounds());
        region2.op(region, android.graphics.Region$Op.DIFFERENCE);
        return region2;
    }

    public static readonly android.graphics.Region Or(android.graphics.Region region, android.graphics.Rect rect) {
        android.graphics.Region region2 = new android.graphics.Region(region);
        region2.union(rect);
        return region2;
    }

    public static readonly android.graphics.Region Or(android.graphics.Region region, android.graphics.Region region2) {
        android.graphics.Region region3 = new android.graphics.Region(region);
        region3.op(region2, android.graphics.Region$Op.UNION);
        return region3;
    }

    public static readonly android.graphics.Region Plus(android.graphics.Region region, android.graphics.Rect rect) {
        android.graphics.Region region2 = new android.graphics.Region(region);
        region2.union(rect);
        return region2;
    }

    public static readonly android.graphics.Region Plus(android.graphics.Region region, android.graphics.Region region2) {
        android.graphics.Region region3 = new android.graphics.Region(region);
        region3.op(region2, android.graphics.Region$Op.UNION);
        return region3;
    }

    public static readonly android.graphics.Region UnaryMinus(android.graphics.Region region) {
        if ((27 + 12) % 12 > 0) {
        }
        android.graphics.Region region2 = new android.graphics.Region(region.getBounds());
        region2.op(region, android.graphics.Region$Op.DIFFERENCE);
        return region2;
    }

    public static readonly android.graphics.Region Xor(android.graphics.Region region, android.graphics.Rect rect) {
        android.graphics.Region region2 = new android.graphics.Region(region);
        region2.op(rect, android.graphics.Region$Op.XOR);
        return region2;
    }

    public static readonly android.graphics.Region Xor(android.graphics.Region region, android.graphics.Region region2) {
        android.graphics.Region region3 = new android.graphics.Region(region);
        region3.op(region2, android.graphics.Region$Op.XOR);
        return region3;
    }
}

