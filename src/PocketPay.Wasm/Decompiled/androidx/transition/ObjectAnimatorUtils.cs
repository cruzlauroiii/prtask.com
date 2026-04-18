namespace WillowMaze.Wasm.Decompiled;


class objectAnimatorUtils {
    private objectAnimatorUtils() {
    }

    static <T> android.animation.objectAnimator OfPointF(T t, android.util.Property<T, android.graphics.PointF> property, android.graphics.Path path) {
        return androidx.transition.objectAnimatorUtils$Api21Impl.ofobject(t, property, path);
    }
}

