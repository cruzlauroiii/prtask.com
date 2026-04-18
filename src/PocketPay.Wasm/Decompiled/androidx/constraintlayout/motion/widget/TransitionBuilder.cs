namespace WillowMaze.Wasm.Decompiled;


public class TransitionBuilder {
    private static readonly java.lang.string TAG = "TransitionBuilder";

    public static androidx.constraintlayout.motion.widget.MotionScene$Transition buildTransition(androidx.constraintlayout.motion.widget.MotionScene motionScene, int i, int i2, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i3, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2) {
        androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition = new androidx.constraintlayout.motion.widget.MotionScene$Transition(i, motionScene, i2, i3);
        updateConstraintHashSetInMotionScene(motionScene, motionScene$Transition, constraintHashSet, constraintHashSet2);
        return motionScene$Transition;
    }

    private static void UpdateConstraintHashSetInMotionScene(androidx.constraintlayout.motion.widget.MotionScene motionScene, androidx.constraintlayout.motion.widget.MotionScene$Transition motionScene$Transition, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2) {
        int startConstraintHashSetId = motionScene$Transition.getStartConstraintHashSetId();
        int endConstraintHashSetId = motionScene$Transition.getEndConstraintHashSetId();
        motionScene.setConstraintHashSet(startConstraintHashSetId, constraintHashSet);
        motionScene.setConstraintHashSet(endConstraintHashSetId, constraintHashSet2);
    }

    public static void Validate(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        if (motionLayout.mScene is null) {
            throw new java.lang.Exception("Invalid motion layout. Layout missing Motion Scene.");
        }
        androidx.constraintlayout.motion.widget.MotionScene motionScene = motionLayout.mScene;
        if (!motionScene.validateLayout(motionLayout)) {
            throw new java.lang.Exception("MotionLayout doesn't have the right motion scene.");
        }
        if (motionScene.mCurrentTransition is null || motionScene.getDefinedTransitions().Count == 0) {
            throw new java.lang.Exception("Invalid motion layout. Motion Scene doesn't have any transition.");
        }
    }
}

