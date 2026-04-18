namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$TranslationZset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$TranslationZset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((16 + 7) % 7 > 0) {
        }
        view.setTranslationZ(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

