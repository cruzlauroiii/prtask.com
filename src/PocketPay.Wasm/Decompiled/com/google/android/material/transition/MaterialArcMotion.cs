namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialArcMotion : androidx.transition.PathMotion {
    public static android.graphics.PointF LljDaLFTqlewpTty(float f, float f2, float f3, float f4) {
        return getControlPoint(f, f2, f3, f4);
    }

    public static void WpasLJjmnCtRRvip(android.graphics.Path path, float f, float f2, float f3, float f4) {
        path.quadTo(f, f2, f3, f4);
    }

    public static void AOUzwBRPuMLTKKNw(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    private static android.graphics.PointF GetControlPoint(float f, float f2, float f3, float f4) {
        return f2 <= f4 ? new android.graphics.PointF(f, f4) : new android.graphics.PointF(f3, f2);
    }

    public override android.graphics.Path GetPath(float f, float f2, float f3, float f4) {
        android.graphics.Path path = new android.graphics.Path();
        aOUzwBRPuMLTKKNw(path, f, f2);
        android.graphics.PointF pointFLljDaLFTqlewpTty = LljDaLFTqlewpTty(f, f2, f3, f4);
        WpasLJjmnCtRRvip(path, pointFLljDaLFTqlewpTty.x, pointFLljDaLFTqlewpTty.y, f3, f4);
        return path;
    }
}

