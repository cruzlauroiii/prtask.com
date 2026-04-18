namespace WillowMaze.Wasm.Decompiled;


class objectPager$2 : android.view.animation.Interpolator {
    objectPager$2() {
    }

    public override float GetInterpolation(float f) {
        float f2 = f - 1.0f;
        return (f2 * f2 * f2 * f2 * f2) + 1.0f;
    }
}

