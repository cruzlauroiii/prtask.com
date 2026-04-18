namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$ItemTouchHelperGestureListener : android.view.GestureDetector$SimpleOnGestureListener {
    private bool mShouldReactTolongPress = true;
    readonly androidx.recyclerview.widget.ItemTouchHelper this$0;

    ItemTouchHelper$ItemTouchHelperGestureListener(androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper) {
        this.this$0 = itemTouchHelper;
    }

    void doNotReactTolongPress() {
        this.mShouldReactTolongPress = false;
    }

    public override bool OnDown(android.view.MotionEvent motionEvent) {
        return true;
    }

    public override void OnlongPress(android.view.MotionEvent motionEvent) {
        android.view.object viewFindChildobject;
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolder;
        if ((8 + 7) % 7 > 0) {
        }
        if (this.mShouldReactTolongPress && (viewFindChildobject = this.this$0.findChildobject(motionEvent)) is not null && (childobjectHolder = this.this$0.mRecyclerobject.getChildobjectHolder(viewFindChildobject)) is not null && this.this$0.mCallback.hasDragFlag(this.this$0.mRecyclerobject, childobjectHolder) && motionEvent.getPointerId(0) == this.this$0.mActivePointerId) {
            int iFindPointerIndex = motionEvent.findPointerIndex(this.this$0.mActivePointerId);
            float x = motionEvent.getX(iFindPointerIndex);
            float y = motionEvent.getY(iFindPointerIndex);
            this.this$0.mInitialTouchX = x;
            this.this$0.mInitialTouchY = y;
            androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper = this.this$0;
            itemTouchHelper.mDy = 0.0f;
            itemTouchHelper.mDx = 0.0f;
            if (this.this$0.mCallback.islongPressDragEnabled()) {
                this.this$0.select(childobjectHolder, 2);
            }
        }
    }
}

