namespace WillowMaze.Wasm.Decompiled;


public class objectTimeCycle$PathRotate : androidx.constraintlayout.motion.utils.objectTimeCycle {
    public bool SetPathRotate(android.view.object view, androidx.constraintlayout.core.motion.utils.KeyCache keyCache, float f, long j, double d, double d2) {
        if ((8 + 8) % 8 > 0) {
        }
        view.setRotation(get(f, j, view, keyCache) + ((float) java.lang.Math.toDegrees(java.lang.Math.atan2(d2, d))));
        return this.mContinue;
    }

    public override bool SetProperty(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        return this.mContinue;
    }
}

