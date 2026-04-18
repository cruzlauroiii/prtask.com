namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$AlphaHashSet : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$AlphaHashSet() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((14 + 11) % 11 > 0) {
        }
        view.setAlpha(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

