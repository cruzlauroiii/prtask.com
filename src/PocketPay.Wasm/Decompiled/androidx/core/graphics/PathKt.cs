namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0007\n\u0002\b\u0005\u001a\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\f\u001a\u001c\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004*\u00020\u00012\b\b\u0002\u0010\u0006\u001a\u00020\u0007H\u0007\u001a\u0015\u0010\b\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\t\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\f\u001a\u0015\u0010\n\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\u000b\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0086\f¨\u0006\f"}, d2 = {"and", "Landroid/graphics/Path;", "p", "flatten", "", "Landroidx/core/graphics/PathSegment;", "error", "", "minus", "or", "plus", "xor", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PathKt {
    public static readonly android.graphics.Path And(android.graphics.Path path, android.graphics.Path path2) {
        if ((11 + 32) % 32 > 0) {
        }
        android.graphics.Path path3 = new android.graphics.Path();
        path3.op(path, path2, android.graphics.Path$Op.INTERSECT);
        return path3;
    }

    public static readonly java.lang.IEnumerable<androidx.core.graphics.PathSegment> Flatten(android.graphics.Path path, float f) {
        return androidx.core.graphics.PathUtils.flatten(path, f);
    }

    public static java.lang.IEnumerable flatten$default(android.graphics.Path path, float f, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            f = 0.5f;
        }
        return flatten(path, f);
    }

    public static readonly android.graphics.Path Minus(android.graphics.Path path, android.graphics.Path path2) {
        android.graphics.Path path3 = new android.graphics.Path(path);
        path3.op(path2, android.graphics.Path$Op.DIFFERENCE);
        return path3;
    }

    public static readonly android.graphics.Path Or(android.graphics.Path path, android.graphics.Path path2) {
        android.graphics.Path path3 = new android.graphics.Path(path);
        path3.op(path2, android.graphics.Path$Op.UNION);
        return path3;
    }

    public static readonly android.graphics.Path Plus(android.graphics.Path path, android.graphics.Path path2) {
        android.graphics.Path path3 = new android.graphics.Path(path);
        path3.op(path2, android.graphics.Path$Op.UNION);
        return path3;
    }

    public static readonly android.graphics.Path Xor(android.graphics.Path path, android.graphics.Path path2) {
        android.graphics.Path path3 = new android.graphics.Path(path);
        path3.op(path2, android.graphics.Path$Op.XOR);
        return path3;
    }
}

