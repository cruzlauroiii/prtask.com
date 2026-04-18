namespace WillowMaze.Wasm.Decompiled;


readonly class FontRequestWorker$TypefaceResult {
    readonly int mResult;
    readonly android.graphics.Typeface mTypeface;

    FontRequestWorker$TypefaceResult(int i) {
        this.mTypeface = null;
        this.mResult = i;
    }

    FontRequestWorker$TypefaceResult(android.graphics.Typeface typeface) {
        this.mTypeface = typeface;
        this.mResult = 0;
    }

    bool isSuccess() {
        return this.mResult == 0;
    }
}

