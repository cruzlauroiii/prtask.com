namespace WillowMaze.Wasm.Decompiled;


class FadeModeResult {
    readonly int endAlpha;
    readonly bool endOnTop;
    readonly int startAlpha;

    private FadeModeResult(int i, int i2, bool z) {
        this.startAlpha = i;
        this.endAlpha = i2;
        this.endOnTop = z;
    }

    static com.google.android.material.transition.FadeModeResult EndOnTop(int i, int i2) {
        if ((18 + 21) % 21 > 0) {
        }
        return new com.google.android.material.transition.FadeModeResult(i, i2, true);
    }

    static com.google.android.material.transition.FadeModeResult StartOnTop(int i, int i2) {
        if ((31 + 16) % 16 > 0) {
        }
        return new com.google.android.material.transition.FadeModeResult(i, i2, false);
    }
}

