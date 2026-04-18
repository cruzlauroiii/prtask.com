namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$TranslationXset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$TranslationXset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((28 + 12) % 12 > 0) {
        }
        view.setTranslationX(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

