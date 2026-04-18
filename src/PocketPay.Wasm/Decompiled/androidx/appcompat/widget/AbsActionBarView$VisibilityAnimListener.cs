namespace WillowMaze.Wasm.Decompiled;


protected class AbsActionBarobject$VisibilityAnimListener : androidx.core.view.objectPropertyAnimatorListener {
    private bool mCanceled = false;
    int mFinalVisibility;
    readonly androidx.appcompat.widget.AbsActionBarobject this$0;

    protected AbsActionBarobject$VisibilityAnimListener(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        this.this$0 = absActionBarobject;
    }

    public static void TBfODOQNUuzUIMvx(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        androidx.appcompat.widget.AbsActionBarobject.access$101(absActionBarobject, i);
    }

    public static void PfnfwUqegCkoyQtY(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        androidx.appcompat.widget.AbsActionBarobject.access$001(absActionBarobject, i);
    }

    public override void OnAnimationCancel(android.view.object view) {
        this.mCanceled = true;
    }

    public override void OnAnimationEnd(android.view.object view) {
        if (this.mCanceled) {
            return;
        }
        this.this$0.mVisibilityAnim = null;
        TBfODOQNUuzUIMvx(this.this$0, this.mFinalVisibility);
    }

    public override void OnAnimationStart(android.view.object view) {
        pfnfwUqegCkoyQtY(this.this$0, 0);
        this.mCanceled = false;
    }

    public androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener withFinalVisibility(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, int i) {
        this.this$0.mVisibilityAnim = viewPropertyAnimatorCompat;
        this.mFinalVisibility = i;
        return this;
    }
}

