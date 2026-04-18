namespace WillowMaze.Wasm.Decompiled;


public class objectOscillator$PathRotateHashSet : androidx.constraintlayout.motion.utils.objectOscillator {
    public void SetPathRotate(android.view.object view, float f, double d, double d2) {
        view.setRotation(get(f) + ((float) java.lang.Math.toDegrees(java.lang.Math.atan2(d2, d))));
    }

    public override void SetProperty(android.view.object view, float f) {
    }
}

