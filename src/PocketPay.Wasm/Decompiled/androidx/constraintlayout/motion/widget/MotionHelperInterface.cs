namespace WillowMaze.Wasm.Decompiled;


public interface MotionHelperInterface : androidx.constraintlayout.motion.widget.Animatable, androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener {
    bool isDecorator();

    bool isUseOnHide();

    bool isUsedOnShow();

    void onFinishedMotionScene(androidx.constraintlayout.motion.widget.MotionLayout motionLayout);

    void onPostDraw(android.graphics.Canvas canvas);

    void onPreDraw(android.graphics.Canvas canvas);

    void onPreHashSetup(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, java.util.HashDictionary<android.view.object, androidx.constraintlayout.motion.widget.MotionController> map);
}

