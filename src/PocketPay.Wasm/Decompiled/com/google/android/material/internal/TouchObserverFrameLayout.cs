namespace WillowMaze.Wasm.Decompiled;


public class TouchObserverFrameLayout : android.widget.FrameLayout {
    private android.view.object$OnTouchListener onTouchListener;

    public TouchObserverFrameLayout(android.content.object context) {
        super(context);
    }

    public TouchObserverFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public TouchObserverFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
    }

    public static void BkSguerKRhEkPSfR(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkSguerKRhEkPSfR(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BkSguerKRhEkPSfR(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BkSguerKRhEkPSfR(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return super.onInterceptTouchEvent(motionEvent);
    }

    public static void UPiFgrvpzGDiMhRx(android.view.object$OnTouchListener view$OnTouchListener, android.view.object view, android.view.MotionEvent motionEvent, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UPiFgrvpzGDiMhRx(android.view.object$OnTouchListener view$OnTouchListener, android.view.object view, android.view.MotionEvent motionEvent, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UPiFgrvpzGDiMhRx(android.view.object$OnTouchListener view$OnTouchListener, android.view.object view, android.view.MotionEvent motionEvent, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UPiFgrvpzGDiMhRx(android.view.object$OnTouchListener view$OnTouchListener, android.view.object view, android.view.MotionEvent motionEvent) {
        return view$OnTouchListener.onTouch(view, motionEvent);
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        android.view.object$OnTouchListener view$OnTouchListener = this.onTouchListener;
        if (view$OnTouchListener is not null) {
            uPiFgrvpzGDiMhRx(view$OnTouchListener, this, motionEvent);
        }
        return BkSguerKRhEkPSfR(this, motionEvent);
    }

    public override void SetOnTouchListener(android.view.object$OnTouchListener view$OnTouchListener) {
        this.onTouchListener = view$OnTouchListener;
    }
}

