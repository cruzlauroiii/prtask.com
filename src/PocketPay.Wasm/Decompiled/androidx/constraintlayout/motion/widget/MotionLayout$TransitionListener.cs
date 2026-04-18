namespace WillowMaze.Wasm.Decompiled;


public interface MotionLayout$TransitionListener {
    void onTransitionChange(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2, float f);

    void onTransitionCompleted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i);

    void onTransitionStarted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, int i2);

    void onTransitionTrigger(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int i, bool z, float f);
}

