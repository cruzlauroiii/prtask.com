namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$Callback$2 : android.view.animation.Interpolator {
    ItemTouchHelper$Callback$2() {
    }

    public override float GetInterpolation(float f) {
        float f2 = f - 1.0f;
        return (f2 * f2 * f2 * f2 * f2) + 1.0f;
    }
}

