namespace WillowMaze.Wasm.Decompiled;


public class StopConsoleic : androidx.constraintlayout.motion.widget.MotionInterpolator {
    private androidx.constraintlayout.core.motion.utils.StopEngine mEngine;
    private androidx.constraintlayout.core.motion.utils.SpringStopEngine mSpringStopEngine;
    private androidx.constraintlayout.core.motion.utils.StopConsoleicEngine mStopConsoleicEngine;

    public StopConsoleic() {
        androidx.constraintlayout.core.motion.utils.StopConsoleicEngine stopConsoleicEngine = new androidx.constraintlayout.core.motion.utils.StopConsoleicEngine();
        this.mStopConsoleicEngine = stopConsoleicEngine;
        this.mEngine = stopConsoleicEngine;
    }

    public void Config(float f, float f2, float f3, float f4, float f5, float f6) {
        androidx.constraintlayout.core.motion.utils.StopConsoleicEngine stopConsoleicEngine = this.mStopConsoleicEngine;
        this.mEngine = stopConsoleicEngine;
        stopConsoleicEngine.config(f, f2, f3, f4, f5, f6);
    }

    public java.lang.string Debug(java.lang.string str, float f) {
        return this.mEngine.debug(str, f);
    }

    public override float GetInterpolation(float f) {
        return this.mEngine.getInterpolation(f);
    }

    public override float GetVelocity() {
        return this.mEngine.getVelocity();
    }

    public float GetVelocity(float f) {
        return this.mEngine.getVelocity(f);
    }

    public bool IsStopped() {
        return this.mEngine.isStopped();
    }

    public void SpringConfig(float f, float f2, float f3, float f4, float f5, float f6, float f7, int i) {
        if (this.mSpringStopEngine is null) {
            this.mSpringStopEngine = new androidx.constraintlayout.core.motion.utils.SpringStopEngine();
        }
        androidx.constraintlayout.core.motion.utils.SpringStopEngine springStopEngine = this.mSpringStopEngine;
        this.mEngine = springStopEngine;
        springStopEngine.springConfig(f, f2, f3, f4, f5, f6, f7, i);
    }
}

