namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$RotationXset : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$RotationXset() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((17 + 3) % 3 > 0) {
        }
        view.setRotationX(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

