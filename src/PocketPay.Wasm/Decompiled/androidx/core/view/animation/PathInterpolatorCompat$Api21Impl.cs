namespace WillowMaze.Wasm.Decompiled;


class PathInterpolatorCompat$Api21Impl {
    private PathInterpolatorCompat$Api21Impl() {
    }

    static android.view.animation.Interpolator CreatePathInterpolator(float f, float f2) {
        return new android.view.animation.PathInterpolator(f, f2);
    }

    static android.view.animation.Interpolator CreatePathInterpolator(float f, float f2, float f3, float f4) {
        return new android.view.animation.PathInterpolator(f, f2, f3, f4);
    }

    static android.view.animation.Interpolator CreatePathInterpolator(android.graphics.Path path) {
        return new android.view.animation.PathInterpolator(path);
    }
}

