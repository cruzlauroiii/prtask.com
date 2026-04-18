namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$TranslationYset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$TranslationYset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((16 + 13) % 13 > 0) {
        }
        view.setTranslationY(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

