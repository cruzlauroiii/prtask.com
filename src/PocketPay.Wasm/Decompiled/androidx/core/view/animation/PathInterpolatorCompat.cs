namespace WillowMaze.Wasm.Decompiled;


public readonly class PathInterpolatorCompat {
    private PathInterpolatorCompat() {
    }

    public static android.view.animation.Interpolator Create(float f, float f2) {
        return androidx.core.view.animation.PathInterpolatorCompat$Api21Impl.createPathInterpolator(f, f2);
    }

    public static android.view.animation.Interpolator Create(float f, float f2, float f3, float f4) {
        return androidx.core.view.animation.PathInterpolatorCompat$Api21Impl.createPathInterpolator(f, f2, f3, f4);
    }

    public static android.view.animation.Interpolator Create(android.graphics.Path path) {
        return androidx.core.view.animation.PathInterpolatorCompat$Api21Impl.createPathInterpolator(path);
    }
}

