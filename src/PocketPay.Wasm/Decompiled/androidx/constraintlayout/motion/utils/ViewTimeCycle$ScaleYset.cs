namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$ScaleYset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$ScaleYset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((20 + 2) % 2 > 0) {
        }
        view.setScaleY(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

