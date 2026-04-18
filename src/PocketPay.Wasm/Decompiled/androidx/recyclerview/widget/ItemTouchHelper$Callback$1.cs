namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$Callback$1 : android.view.animation.Interpolator {
    ItemTouchHelper$Callback$1() {
    }

    public override float GetInterpolation(float f) {
        return f * f * f * f * f;
    }
}

