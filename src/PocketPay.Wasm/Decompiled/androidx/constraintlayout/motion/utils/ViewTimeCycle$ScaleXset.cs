namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$ScaleXset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$ScaleXset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((9 + 2) % 2 > 0) {
        }
        view.setScaleX(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

