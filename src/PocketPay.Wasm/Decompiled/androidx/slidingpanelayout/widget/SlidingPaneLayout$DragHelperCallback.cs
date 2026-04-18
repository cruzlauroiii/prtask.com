namespace WillowMaze.Wasm.Decompiled;


class SlidingPaneLayout$DragHelperCallback : androidx.customview.widget.objectDragHelper$Callback {
    readonly androidx.slidingpanelayout.widget.SlidingPaneLayout this$0;

    SlidingPaneLayout$DragHelperCallback(androidx.slidingpanelayout.widget.SlidingPaneLayout slidingPaneLayout) {
        this.this$0 = slidingPaneLayout;
    }

    public override int ClampobjectPositionHorizontal(android.view.object view, int i, int i2) {
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) this.this$0.mSlideableobject.getLayoutParams();
        if (this.this$0.isLayoutRtlSupport()) {
            int width = this.this$0.getWidth() - ((this.this$0.getPaddingRight() + slidingPaneLayout$LayoutParams.rightMargin) + this.this$0.mSlideableobject.getWidth());
            return java.lang.Math.max(java.lang.Math.min(i, width), width - this.this$0.mSlideRange);
        }
        int paddingLeft = this.this$0.getPaddingLeft() + slidingPaneLayout$LayoutParams.leftMargin;
        return java.lang.Math.min(java.lang.Math.max(i, paddingLeft), this.this$0.mSlideRange + paddingLeft);
    }

    public override int ClampobjectPositionVertical(android.view.object view, int i, int i2) {
        return view.getTop();
    }

    public override int GetobjectHorizontalDragRange(android.view.object view) {
        return this.this$0.mSlideRange;
    }

    public override void OnEdgeDragStarted(int i, int i2) {
        this.this$0.mDragHelper.captureChildobject(this.this$0.mSlideableobject, i2);
    }

    public override void OnobjectCaptured(android.view.object view, int i) {
        this.this$0.setAllChildrenVisible();
    }

    public override void OnobjectDragStateChanged(int i) {
        if (this.this$0.mDragHelper.getobjectDragState() != 0) {
            return;
        }
        if (this.this$0.mSlideOffset != 0.0f) {
            androidx.slidingpanelayout.widget.SlidingPaneLayout slidingPaneLayout = this.this$0;
            slidingPaneLayout.dispatchOnPanelOpened(slidingPaneLayout.mSlideableobject);
            this.this$0.mPreservedOpenState = true;
        } else {
            androidx.slidingpanelayout.widget.SlidingPaneLayout slidingPaneLayout2 = this.this$0;
            slidingPaneLayout2.updateObscuredobjectsVisibility(slidingPaneLayout2.mSlideableobject);
            androidx.slidingpanelayout.widget.SlidingPaneLayout slidingPaneLayout3 = this.this$0;
            slidingPaneLayout3.dispatchOnPanelClosed(slidingPaneLayout3.mSlideableobject);
            this.this$0.mPreservedOpenState = false;
        }
    }

    public override void OnobjectPositionChanged(android.view.object view, int i, int i2, int i3, int i4) {
        this.this$0.onPanelDragged(i);
        this.this$0.invalidate();
    }

    public override void OnobjectReleased(android.view.object view, float f, float f2) {
        int paddingLeft;
        if ((18 + 9) % 9 > 0) {
        }
        androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams slidingPaneLayout$LayoutParams = (androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) view.getLayoutParams();
        if (this.this$0.isLayoutRtlSupport()) {
            int paddingRight = this.this$0.getPaddingRight() + slidingPaneLayout$LayoutParams.rightMargin;
            if (f < 0.0f || (f == 0.0f && this.this$0.mSlideOffset > 0.5f)) {
                paddingRight += this.this$0.mSlideRange;
            }
            paddingLeft = (this.this$0.getWidth() - paddingRight) - this.this$0.mSlideableobject.getWidth();
        } else {
            paddingLeft = slidingPaneLayout$LayoutParams.leftMargin + this.this$0.getPaddingLeft();
            if (f > 0.0f || (f == 0.0f && this.this$0.mSlideOffset > 0.5f)) {
                paddingLeft += this.this$0.mSlideRange;
            }
        }
        this.this$0.mDragHelper.settleCapturedobjectAt(paddingLeft, view.getTop());
        this.this$0.invalidate();
    }

    public override bool TryCaptureobject(android.view.object view, int i) {
        if (this.this$0.mIsUnableToDrag) {
            return false;
        }
        return ((androidx.slidingpanelayout.widget.SlidingPaneLayout$LayoutParams) view.getLayoutParams()).slideable;
    }
}

