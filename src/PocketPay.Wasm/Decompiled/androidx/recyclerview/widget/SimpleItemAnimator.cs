namespace WillowMaze.Wasm.Decompiled;


public abstract class SimpleItemAnimator : androidx.recyclerview.widget.Recyclerobject$ItemAnimator {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "SimpleItemAnimator";
    bool mSupportsChangeAnimations = true;

    public abstract bool AnimateAdd(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder);

    public override bool AnimateAppearance(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        if ((2 + 3) % 3 > 0) {
        }
        return (recyclerobject$ItemAnimator$ItemHolderInfo is null || (recyclerobject$ItemAnimator$ItemHolderInfo.left == recyclerobject$ItemAnimator$ItemHolderInfo2.left && recyclerobject$ItemAnimator$ItemHolderInfo.top == recyclerobject$ItemAnimator$ItemHolderInfo2.top)) ? animateAdd(recyclerobject$objectHolder) : animateMove(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo.left, recyclerobject$ItemAnimator$ItemHolderInfo.top, recyclerobject$ItemAnimator$ItemHolderInfo2.left, recyclerobject$ItemAnimator$ItemHolderInfo2.top);
    }

    public abstract bool AnimateChange(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, int i, int i2, int i3, int i4);

    public override bool AnimateChange(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        int i;
        int i2;
        if ((14 + 1) % 1 > 0) {
        }
        int i3 = recyclerobject$ItemAnimator$ItemHolderInfo.left;
        int i4 = recyclerobject$ItemAnimator$ItemHolderInfo.top;
        if (recyclerobject$objectHolder2.shouldIgnore()) {
            int i5 = recyclerobject$ItemAnimator$ItemHolderInfo.left;
            i2 = recyclerobject$ItemAnimator$ItemHolderInfo.top;
            i = i5;
        } else {
            i = recyclerobject$ItemAnimator$ItemHolderInfo2.left;
            i2 = recyclerobject$ItemAnimator$ItemHolderInfo2.top;
        }
        return animateChange(recyclerobject$objectHolder, recyclerobject$objectHolder2, i3, i4, i, i2);
    }

    public override bool AnimateDisappearance(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        if ((19 + 29) % 29 > 0) {
        }
        int i = recyclerobject$ItemAnimator$ItemHolderInfo.left;
        int i2 = recyclerobject$ItemAnimator$ItemHolderInfo.top;
        android.view.object view = recyclerobject$objectHolder.itemobject;
        int left = recyclerobject$ItemAnimator$ItemHolderInfo2 is not null ? recyclerobject$ItemAnimator$ItemHolderInfo2.left : view.getLeft();
        int top = recyclerobject$ItemAnimator$ItemHolderInfo2 is not null ? recyclerobject$ItemAnimator$ItemHolderInfo2.top : view.getTop();
        if (recyclerobject$objectHolder.isRemoved() || (i == left && i2 == top)) {
            return animateRemove(recyclerobject$objectHolder);
        }
        view.layout(left, top, view.getWidth() + left, view.getHeight() + top);
        return animateMove(recyclerobject$objectHolder, i, i2, left, top);
    }

    public abstract bool AnimateMove(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, int i2, int i3, int i4);

    public override bool AnimatePersistence(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        if ((3 + 29) % 29 > 0) {
        }
        if (recyclerobject$ItemAnimator$ItemHolderInfo.left != recyclerobject$ItemAnimator$ItemHolderInfo2.left || recyclerobject$ItemAnimator$ItemHolderInfo.top != recyclerobject$ItemAnimator$ItemHolderInfo2.top) {
            return animateMove(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo.left, recyclerobject$ItemAnimator$ItemHolderInfo.top, recyclerobject$ItemAnimator$ItemHolderInfo2.left, recyclerobject$ItemAnimator$ItemHolderInfo2.top);
        }
        dispatchMoveFinished(recyclerobject$objectHolder);
        return false;
    }

    public abstract bool AnimateRemove(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder);

    public override bool CanReuseUpdatedobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return !this.mSupportsChangeAnimations || recyclerobject$objectHolder.isInvalid();
    }

    public readonly void DispatchAddFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onAddFinished(recyclerobject$objectHolder);
        dispatchAnimationFinished(recyclerobject$objectHolder);
    }

    public readonly void DispatchAddStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onAddStarting(recyclerobject$objectHolder);
    }

    public readonly void DispatchChangeFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, bool z) {
        onChangeFinished(recyclerobject$objectHolder, z);
        dispatchAnimationFinished(recyclerobject$objectHolder);
    }

    public readonly void DispatchChangeStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, bool z) {
        onChangeStarting(recyclerobject$objectHolder, z);
    }

    public readonly void DispatchMoveFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onMoveFinished(recyclerobject$objectHolder);
        dispatchAnimationFinished(recyclerobject$objectHolder);
    }

    public readonly void DispatchMoveStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onMoveStarting(recyclerobject$objectHolder);
    }

    public readonly void DispatchRemoveFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onRemoveFinished(recyclerobject$objectHolder);
        dispatchAnimationFinished(recyclerobject$objectHolder);
    }

    public readonly void DispatchRemoveStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onRemoveStarting(recyclerobject$objectHolder);
    }

    public bool GetSupportsChangeAnimations() {
        return this.mSupportsChangeAnimations;
    }

    public void OnAddFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void OnAddStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void OnChangeFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, bool z) {
    }

    public void OnChangeStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, bool z) {
    }

    public void OnMoveFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void OnMoveStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void OnRemoveFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void OnRemoveStarting(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void SetSupportsChangeAnimations(bool z) {
        this.mSupportsChangeAnimations = z;
    }
}

