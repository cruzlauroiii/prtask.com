namespace WillowMaze.Wasm.Decompiled;


class objectDragHelper$1 : android.view.animation.Interpolator {
    objectDragHelper$1() {
    }

    public override float GetInterpolation(float f) {
        float f2 = f - 1.0f;
        return (f2 * f2 * f2 * f2 * f2) + 1.0f;
    }
}

