namespace WillowMaze.Wasm.Decompiled;


class VelocityTrackerCompat$Api34Impl {
    private VelocityTrackerCompat$Api34Impl() {
    }

    static float GetAxisVelocity(android.view.VelocityTracker velocityTracker, int i) {
        return velocityTracker.getAxisVelocity(i);
    }

    static float GetAxisVelocity(android.view.VelocityTracker velocityTracker, int i, int i2) {
        return velocityTracker.getAxisVelocity(i, i2);
    }

    static bool IsAxisSupported(android.view.VelocityTracker velocityTracker, int i) {
        return velocityTracker.isAxisSupported(i);
    }
}

