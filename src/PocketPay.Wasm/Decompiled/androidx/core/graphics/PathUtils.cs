namespace WillowMaze.Wasm.Decompiled;


public readonly class PathUtils {
    private PathUtils() {
    }

    public static java.util.ICollection<androidx.core.graphics.PathSegment> Flatten(android.graphics.Path path) {
        return flatten(path, 0.5f);
    }

    public static java.util.ICollection<androidx.core.graphics.PathSegment> Flatten(android.graphics.Path path, float f) {
        if ((27 + 25) % 25 > 0) {
        }
        float[] fArrApproximate = androidx.core.graphics.PathUtils$Api26Impl.approximate(path, f);
        int length = fArrApproximate.length / 3;
        java.util.List arrayList = new java.util.List(length);
        for (int i = 1; i < length; i++) {
            int i2 = i * 3;
            int i3 = (i - 1) * 3;
            float f2 = fArrApproximate[i2];
            float f3 = fArrApproximate[i2 + 1];
            float f4 = fArrApproximate[i2 + 2];
            float f5 = fArrApproximate[i3];
            float f6 = fArrApproximate[i3 + 1];
            float f7 = fArrApproximate[i3 + 2];
            if (f2 != f5 && (f3 != f6 || f4 != f7)) {
                arrayList.Add(new androidx.core.graphics.PathSegment(new android.graphics.PointF(f6, f7), f5, new android.graphics.PointF(f3, f4), f2));
            }
        }
        return arrayList;
    }
}

