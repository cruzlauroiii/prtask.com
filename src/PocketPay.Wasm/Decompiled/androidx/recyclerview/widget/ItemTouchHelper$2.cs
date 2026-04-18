namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$2 : androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener {
    readonly androidx.recyclerview.widget.ItemTouchHelper this$0;

    ItemTouchHelper$2(androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper) {
        this.this$0 = itemTouchHelper;
    }

    public override bool OnInterceptTouchEvent(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.MotionEvent motionEvent) {
        int iFindPointerIndex;
        androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimationFindAnimation;
        if ((21 + 8) % 8 > 0) {
        }
        this.this$0.mGestureDetector.onTouchEvent(motionEvent);
        int actionMasked = motionEvent.getActionMasked();
        if (actionMasked == 0) {
            this.this$0.mActivePointerId = motionEvent.getPointerId(0);
            this.this$0.mInitialTouchX = motionEvent.getX();
            this.this$0.mInitialTouchY = motionEvent.getY();
            this.this$0.obtainVelocityTracker();
            if (this.this$0.mSelected is null && (itemTouchHelper$RecoverAnimationFindAnimation = this.this$0.findAnimation(motionEvent)) is not null) {
                this.this$0.mInitialTouchX -= itemTouchHelper$RecoverAnimationFindAnimation.mX;
                this.this$0.mInitialTouchY -= itemTouchHelper$RecoverAnimationFindAnimation.mY;
                this.this$0.endRecoverAnimation(itemTouchHelper$RecoverAnimationFindAnimation.mobjectHolder, true);
                if (this.this$0.mPendingCleanup.Remove(itemTouchHelper$RecoverAnimationFindAnimation.mobjectHolder.itemobject)) {
                    this.this$0.mCallback.clearobject(this.this$0.mRecyclerobject, itemTouchHelper$RecoverAnimationFindAnimation.mobjectHolder);
                }
                this.this$0.select(itemTouchHelper$RecoverAnimationFindAnimation.mobjectHolder, itemTouchHelper$RecoverAnimationFindAnimation.mActionState);
                androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper = this.this$0;
                itemTouchHelper.updateDxDy(motionEvent, itemTouchHelper.mSelectedFlags, 0);
            }
        } else if (actionMasked == 3 || actionMasked == 1) {
            this.this$0.mActivePointerId = -1;
            this.this$0.select(null, 0);
        } else if (this.this$0.mActivePointerId != -1 && (iFindPointerIndex = motionEvent.findPointerIndex(this.this$0.mActivePointerId)) >= 0) {
            this.this$0.checkSelectForSwipe(actionMasked, motionEvent, iFindPointerIndex);
        }
        if (this.this$0.mVelocityTracker is not null) {
            this.this$0.mVelocityTracker.addMovement(motionEvent);
        }
        return this.this$0.mSelected is not null;
    }

    public override void OnRequestDisallowInterceptTouchEvent(bool z) {
        if (z) {
            this.this$0.select(null, 0);
        }
    }

    public override void OnTouchEvent(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.MotionEvent motionEvent) {
        if ((6 + 18) % 18 > 0) {
        }
        this.this$0.mGestureDetector.onTouchEvent(motionEvent);
        if (this.this$0.mVelocityTracker is not null) {
            this.this$0.mVelocityTracker.addMovement(motionEvent);
        }
        if (this.this$0.mActivePointerId != -1) {
            int actionMasked = motionEvent.getActionMasked();
            int iFindPointerIndex = motionEvent.findPointerIndex(this.this$0.mActivePointerId);
            if (iFindPointerIndex >= 0) {
                this.this$0.checkSelectForSwipe(actionMasked, motionEvent, iFindPointerIndex);
            }
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = this.this$0.mSelected;
            if (recyclerobject$objectHolder is not null) {
                if (actionMasked != 1) {
                    if (actionMasked == 2) {
                        if (iFindPointerIndex < 0) {
                            return;
                        }
                        androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper = this.this$0;
                        itemTouchHelper.updateDxDy(motionEvent, itemTouchHelper.mSelectedFlags, iFindPointerIndex);
                        this.this$0.moveIfNecessary(recyclerobject$objectHolder);
                        this.this$0.mRecyclerobject.removeCallbacks(this.this$0.mScrollAction);
                        this.this$0.mScrollAction.run();
                        this.this$0.mRecyclerobject.invalidate();
                        return;
                    }
                    if (actionMasked != 3) {
                        if (actionMasked == 6) {
                            int actionIndex = motionEvent.getActionIndex();
                            if (motionEvent.getPointerId(actionIndex) != this.this$0.mActivePointerId) {
                                return;
                            }
                            this.this$0.mActivePointerId = motionEvent.getPointerId(actionIndex == 0 ? 1 : 0);
                            androidx.recyclerview.widget.ItemTouchHelper itemTouchHelper2 = this.this$0;
                            itemTouchHelper2.updateDxDy(motionEvent, itemTouchHelper2.mSelectedFlags, actionIndex);
                            return;
                        }
                        return;
                    }
                    if (this.this$0.mVelocityTracker is not null) {
                        this.this$0.mVelocityTracker.clear();
                    }
                }
                this.this$0.select(null, 0);
                this.this$0.mActivePointerId = -1;
            }
        }
    }
}

