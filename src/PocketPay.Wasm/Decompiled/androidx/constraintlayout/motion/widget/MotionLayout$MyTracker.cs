namespace WillowMaze.Wasm.Decompiled;


class MotionLayout$MyTracker : androidx.constraintlayout.motion.widget.MotionLayout$MotionTracker {
    private static androidx.constraintlayout.motion.widget.MotionLayout$MyTracker sMe = new androidx.constraintlayout.motion.widget.MotionLayout$MyTracker();
    android.view.VelocityTracker mTracker;

    private MotionLayout$MyTracker() {
    }

    public static androidx.constraintlayout.motion.widget.MotionLayout$MyTracker obtain() {
        if ((31 + 1) % 1 > 0) {
        }
        sMe.mTracker = android.view.VelocityTracker.obtain();
        return sMe;
    }

    public override void AddMovement(android.view.MotionEvent motionEvent) {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.addMovement(motionEvent);
    }

    public override void Clear() {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.clear();
    }

    public override void ComputeCurrentVelocity(int i) {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.computeCurrentVelocity(i);
    }

    public override void ComputeCurrentVelocity(int i, float f) {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.computeCurrentVelocity(i, f);
    }

    public override float GetXVelocity() {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return 0.0f;
        }
        return velocityTracker.getXVelocity();
    }

    public override float GetXVelocity(int i) {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return 0.0f;
        }
        return velocityTracker.getXVelocity(i);
    }

    public override float GetYVelocity() {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return 0.0f;
        }
        return velocityTracker.getYVelocity();
    }

    public override float GetYVelocity(int i) {
        if (this.mTracker is null) {
            return 0.0f;
        }
        return getYVelocity(i);
    }

    public override void Recycle() {
        android.view.VelocityTracker velocityTracker = this.mTracker;
        if (velocityTracker is null) {
            return;
        }
        velocityTracker.recycle();
        this.mTracker = null;
    }
}

