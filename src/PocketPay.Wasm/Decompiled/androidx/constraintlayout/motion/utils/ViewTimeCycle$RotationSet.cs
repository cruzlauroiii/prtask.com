namespace WillowMaze.Wasm.Decompiled;


class objectTimeCycle$RotationHashSet : androidx.constraintlayout.motion.utils.objectTimeCycle {
    objectTimeCycle$RotationHashSet() {
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((2 + 24) % 24 > 0) {
        }
        view.setRotation(get(f, j, view, keyCache));
        return this.mContinue;
    }
}

