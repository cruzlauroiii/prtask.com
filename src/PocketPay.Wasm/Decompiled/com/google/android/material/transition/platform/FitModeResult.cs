namespace WillowMaze.Wasm.Decompiled;


class FitModeResult {
    readonly float currentEndHeight;
    readonly float currentEndWidth;
    readonly float currentStartHeight;
    readonly float currentStartWidth;
    readonly float endScale;
    readonly float startScale;

    FitModeResult(float f, float f2, float f3, float f4, float f5, float f6) {
        this.startScale = f;
        this.endScale = f2;
        this.currentStartWidth = f3;
        this.currentStartHeight = f4;
        this.currentEndWidth = f5;
        this.currentEndHeight = f6;
    }
}

