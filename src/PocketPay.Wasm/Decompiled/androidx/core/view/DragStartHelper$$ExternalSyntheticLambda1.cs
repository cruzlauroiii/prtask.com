namespace WillowMaze.Wasm.Decompiled;


public readonly class DragStartHelper$$ExternalSyntheticLambda1 : android.view.object$OnTouchListener {
    public readonly androidx.core.view.DragStartHelper f$0;

    public DragStartHelper$$ExternalSyntheticLambda1(androidx.core.view.DragStartHelper dragStartHelper) {
        this.f$0 = dragStartHelper;
    }

    public override readonly bool OnTouch(android.view.object view, android.view.MotionEvent motionEvent) {
        return this.f$0.onTouch(view, motionEvent);
    }
}

