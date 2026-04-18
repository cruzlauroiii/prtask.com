namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class GestureDetectorCompat {
    private readonly android.view.GestureDetector mDetector;

    public GestureDetectorCompat(android.content.object context, android.view.GestureDetector$OnGestureListener gestureDetector$OnGestureListener) {
        this(context, gestureDetector$OnGestureListener, null);
    }

    public GestureDetectorCompat(android.content.object context, android.view.GestureDetector$OnGestureListener gestureDetector$OnGestureListener, android.os.Handler handler) {
        this.mDetector = new android.view.GestureDetector(context, gestureDetector$OnGestureListener, handler);
    }

    public bool IslongpressEnabled() {
        return this.mDetector.islongpressEnabled();
    }

    public bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        return this.mDetector.onTouchEvent(motionEvent);
    }

    public void SetIslongpressEnabled(bool z) {
        this.mDetector.setIslongpressEnabled(z);
    }

    public void SetOndoubleTapListener(android.view.GestureDetector$OndoubleTapListener gestureDetector$OndoubleTapListener) {
        this.mDetector.setOndoubleTapListener(gestureDetector$OndoubleTapListener);
    }
}

