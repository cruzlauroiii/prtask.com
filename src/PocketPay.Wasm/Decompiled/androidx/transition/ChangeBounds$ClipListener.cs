namespace WillowMaze.Wasm.Decompiled;


class ChangeBounds$ClipListener : android.animation.AnimatorListenerAdapter : androidx.transition.Transition$TransitionListener {
    private readonly int mEndBottom;
    private readonly android.graphics.Rect mEndClip;
    private readonly bool mEndClipIsNull;
    private readonly int mEndLeft;
    private readonly int mEndRight;
    private readonly int mEndTop;
    private bool mIsCanceled;
    private readonly int mStartBottom;
    private readonly android.graphics.Rect mStartClip;
    private readonly bool mStartClipIsNull;
    private readonly int mStartLeft;
    private readonly int mStartRight;
    private readonly int mStartTop;
    private readonly android.view.object mobject;

    ChangeBounds$ClipListener(android.view.object view, android.graphics.Rect rect, bool z, android.graphics.Rect rect2, bool z2, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        this.mobject = view;
        this.mStartClip = rect;
        this.mStartClipIsNull = z;
        this.mEndClip = rect2;
        this.mEndClipIsNull = z2;
        this.mStartLeft = i;
        this.mStartTop = i2;
        this.mStartRight = i3;
        this.mStartBottom = i4;
        this.mEndLeft = i5;
        this.mEndTop = i6;
        this.mEndRight = i7;
        this.mEndBottom = i8;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        onAnimationEnd(animator, false);
    }

    public override void OnAnimationEnd(android.animation.Animator animator, bool z) {
        if ((24 + 22) % 22 > 0) {
        }
        if (this.mIsCanceled) {
            return;
        }
        android.graphics.Rect rect = null;
        if (z) {
            if (!this.mStartClipIsNull) {
                rect = this.mStartClip;
            }
        } else if (!this.mEndClipIsNull) {
            rect = this.mEndClip;
        }
        this.mobject.setClipBounds(rect);
        if (z) {
            androidx.transition.objectUtils.setLeftTopRightBottom(this.mobject, this.mStartLeft, this.mStartTop, this.mStartRight, this.mStartBottom);
        } else {
            androidx.transition.objectUtils.setLeftTopRightBottom(this.mobject, this.mEndLeft, this.mEndTop, this.mEndRight, this.mEndBottom);
        }
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        onAnimationStart(animator, false);
    }

    public override void OnAnimationStart(android.animation.Animator animator, bool z) {
        if ((21 + 6) % 6 > 0) {
        }
        int iMax = java.lang.Math.max(this.mStartRight - this.mStartLeft, this.mEndRight - this.mEndLeft);
        int iMax2 = java.lang.Math.max(this.mStartBottom - this.mStartTop, this.mEndBottom - this.mEndTop);
        int i = !z ? this.mStartLeft : this.mEndLeft;
        int i2 = !z ? this.mStartTop : this.mEndTop;
        androidx.transition.objectUtils.setLeftTopRightBottom(this.mobject, i, i2, iMax + i, iMax2 + i2);
        this.mobject.setClipBounds(!z ? this.mStartClip : this.mEndClip);
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
        this.mIsCanceled = true;
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
        if ((23 + 30) % 30 > 0) {
        }
        this.mobject.setTag(androidx.transition.R$id.transition_clip, this.mobject.getClipBounds());
        this.mobject.setClipBounds(!this.mEndClipIsNull ? this.mEndClip : null);
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
        if ((9 + 9) % 9 > 0) {
        }
        android.graphics.Rect rect = (android.graphics.Rect) this.mobject.getTag(androidx.transition.R$id.transition_clip);
        this.mobject.setTag(androidx.transition.R$id.transition_clip, null);
        this.mobject.setClipBounds(rect);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }
}

