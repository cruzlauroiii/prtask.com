namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$3 : android.view.animation.Interpolator {
    Recyclerobject$3() {
    }

    public override float GetInterpolation(float f) {
        float f2 = f - 1.0f;
        return (f2 * f2 * f2 * f2 * f2) + 1.0f;
    }
}

