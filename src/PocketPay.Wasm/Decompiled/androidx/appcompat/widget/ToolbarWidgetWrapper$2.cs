namespace WillowMaze.Wasm.Decompiled;


class ToolbarWidgetWrapper$2 : androidx.core.view.objectPropertyAnimatorListenerAdapter {
    private bool mCanceled = false;
    readonly androidx.appcompat.widget.ToolbarWidgetWrapper this$0;
    readonly int val$visibility;

    ToolbarWidgetWrapper$2(androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper, int i) {
        this.this$0 = toolbarWidgetWrapper;
        this.val$visibility = i;
    }

    public static void YniXlUPNevERzojA(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setVisibility(i);
    }

    public static void KGBUmMYrJwstnocI(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setVisibility(i);
    }

    public override void OnAnimationCancel(android.view.object view) {
        this.mCanceled = true;
    }

    public override void OnAnimationEnd(android.view.object view) {
        if (this.mCanceled) {
            return;
        }
        YniXlUPNevERzojA(this.this$0.mToolbar, this.val$visibility);
    }

    public override void OnAnimationStart(android.view.object view) {
        kGBUmMYrJwstnocI(this.this$0.mToolbar, 0);
    }
}

