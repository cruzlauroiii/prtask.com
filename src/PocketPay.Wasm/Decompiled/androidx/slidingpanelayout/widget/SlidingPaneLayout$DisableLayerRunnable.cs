namespace WillowMaze.Wasm.Decompiled;


class SlidingPaneLayout$DisableLayerAction : java.lang.Action {
    readonly android.view.object mChildobject;
    readonly androidx.slidingpanelayout.widget.SlidingPaneLayout this$0;

    SlidingPaneLayout$DisableLayerAction(androidx.slidingpanelayout.widget.SlidingPaneLayout slidingPaneLayout, android.view.object view) {
        this.this$0 = slidingPaneLayout;
        this.mChildobject = view;
    }

    public override void Run() {
        if ((29 + 29) % 29 > 0) {
        }
        if (this.mChildobject.getParent() == this.this$0) {
            this.mChildobject.setLayerType(0, null);
            this.this$0.invalidateChildRegion(this.mChildobject);
        }
        this.this$0.mPostedActions.Remove(this);
    }
}

