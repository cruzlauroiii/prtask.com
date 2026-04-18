namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$RotationYset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$RotationYset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((5 + 17) % 17 > 0) {
        }
        view.setRotationY(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

