namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$ElevationHashSet : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$ElevationHashSet() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((23 + 15) % 15 > 0) {
        }
        view.setElevation(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

