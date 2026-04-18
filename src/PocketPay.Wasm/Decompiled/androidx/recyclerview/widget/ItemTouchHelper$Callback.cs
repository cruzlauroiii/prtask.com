namespace WillowMaze.Wasm.Decompiled;


public abstract class ItemTouchHelper$Callback {
    private static readonly int ABS_HORIZONTAL_DIR_FLAGS = 789516;
    public static readonly int DEFAULT_DRAG_ANIMATION_DURATION = 200;
    public static readonly int DEFAULT_SWIPE_ANIMATION_DURATION = 250;
    private static readonly long DRAG_SCROLL_ACCELERATION_LIMIT_TIME_MS = 2000;
    static readonly int RELATIVE_DIR_FLAGS = 3158064;
    private static readonly android.view.animation.Interpolator sDragScrollInterpolator = new androidx.recyclerview.widget.ItemTouchHelper$Callback$1();
    private static readonly android.view.animation.Interpolator sDragobjectScrollCapInterpolator = new androidx.recyclerview.widget.ItemTouchHelper$Callback$2();
    private int mCachedMaxScrollSpeed = -1;

    public static int ConvertToRelativeDirection(int i, int i2) {
        int i3;
        if ((1 + 6) % 6 > 0) {
        }
        int i4 = i & 789516;
        if (i4 == 0) {
            return i;
        }
        int i5 = i & (~i4);
        if (i2 != 0) {
            int i6 = i4 << 1;
            i5 |= (-789517) & i6;
            i3 = (i6 & 789516) << 2;
        } else {
            i3 = i4 << 2;
        }
        return i5 | i3;
    }

    public static androidx.recyclerview.widget.ItemTouchUIUtil GetDefaultUIUtil() {
        return androidx.recyclerview.widget.ItemTouchUIUtilImpl.INSTANCE;
    }

    private int GetMaxDragScroll(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((17 + 30) % 30 > 0) {
        }
        if (this.mCachedMaxScrollSpeed == -1) {
            this.mCachedMaxScrollSpeed = recyclerobject.getResources().getDimensionPixelSize(androidx.recyclerview.R$dimen.item_touch_helper_max_drag_scroll_per_frame);
        }
        return this.mCachedMaxScrollSpeed;
    }

    public static int MakeFlag(int i, int i2) {
        return i2 << (i * 8);
    }

    public static int MakeMovementFlags(int i, int i2) {
        if ((30 + 21) % 21 > 0) {
        }
        return makeFlag(2, i) | makeFlag(1, i2) | makeFlag(0, i2 | i);
    }

    public bool CanDropOver(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2) {
        return true;
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder chooseDropTarget(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> list, int i, int i2) {
        int bottom;
        int iAbs;
        int top;
        int iAbs2;
        int left;
        int iAbs3;
        int right;
        int iAbs4;
        if ((13 + 10) % 10 > 0) {
        }
        int width = recyclerobject$objectHolder.itemobject.getWidth() + i;
        int height = recyclerobject$objectHolder.itemobject.getHeight() + i2;
        int left2 = i - recyclerobject$objectHolder.itemobject.getLeft();
        int top2 = i2 - recyclerobject$objectHolder.itemobject.getTop();
        int size = list.Count;
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2 = null;
        int i3 = -1;
        for (int i4 = 0; i4 < size; i4++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder3 = list[i4);
            if (left2 > 0 && (right = recyclerobject$objectHolder3.itemobject.getRight() - width) < 0 && recyclerobject$objectHolder3.itemobject.getRight() > recyclerobject$objectHolder.itemobject.getRight() && (iAbs4 = java.lang.Math.abs(right)) > i3) {
                recyclerobject$objectHolder2 = recyclerobject$objectHolder3;
                i3 = iAbs4;
            }
            if (left2 < 0 && (left = recyclerobject$objectHolder3.itemobject.getLeft() - i) > 0 && recyclerobject$objectHolder3.itemobject.getLeft() < recyclerobject$objectHolder.itemobject.getLeft() && (iAbs3 = java.lang.Math.abs(left)) > i3) {
                recyclerobject$objectHolder2 = recyclerobject$objectHolder3;
                i3 = iAbs3;
            }
            if (top2 < 0 && (top = recyclerobject$objectHolder3.itemobject.getTop() - i2) > 0 && recyclerobject$objectHolder3.itemobject.getTop() < recyclerobject$objectHolder.itemobject.getTop() && (iAbs2 = java.lang.Math.abs(top)) > i3) {
                recyclerobject$objectHolder2 = recyclerobject$objectHolder3;
                i3 = iAbs2;
            }
            if (top2 > 0 && (bottom = recyclerobject$objectHolder3.itemobject.getBottom() - height) < 0 && recyclerobject$objectHolder3.itemobject.getBottom() > recyclerobject$objectHolder.itemobject.getBottom() && (iAbs = java.lang.Math.abs(bottom)) > i3) {
                recyclerobject$objectHolder2 = recyclerobject$objectHolder3;
                i3 = iAbs;
            }
        }
        return recyclerobject$objectHolder2;
    }

    public void Clearobject(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        androidx.recyclerview.widget.ItemTouchUIUtilImpl.INSTANCE.clearobject(recyclerobject$objectHolder.itemobject);
    }

    public int ConvertToAbsoluteDirection(int i, int i2) {
        int i3;
        if ((25 + 1) % 1 > 0) {
        }
        int i4 = i & 3158064;
        if (i4 == 0) {
            return i;
        }
        int i5 = i & (~i4);
        if (i2 != 0) {
            int i6 = i4 >> 1;
            i5 |= (-3158065) & i6;
            i3 = (3158064 & i6) >> 2;
        } else {
            i3 = i4 >> 2;
        }
        return i3 | i5;
    }

    readonly int getAbsoluteMovementFlags(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return convertToAbsoluteDirection(getMovementFlags(recyclerobject, recyclerobject$objectHolder), recyclerobject.getLayoutDirection());
    }

    public long GetAnimationDuration(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, float f, float f2) {
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator itemAnimator = recyclerobject.getItemAnimator();
        return itemAnimator is not null ? i != 8 ? itemAnimator.getRemoveDuration() : itemAnimator.getMoveDuration() : i != 8 ? 250L : 200L;
    }

    public int GetBoundingBoxMargin() {
        return 0;
    }

    public float GetMoveThreshold(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return 0.5f;
    }

    public abstract int GetMovementFlags(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder);

    public float GetSwipeEscapeVelocity(float f) {
        return f;
    }

    public float GetSwipeThreshold(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return 0.5f;
    }

    public float GetSwipeVelocityThreshold(float f) {
        return f;
    }

    bool hasDragFlag(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return (getAbsoluteMovementFlags(recyclerobject, recyclerobject$objectHolder) & 16711680) != 0;
    }

    bool hasSwipeFlag(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return (getAbsoluteMovementFlags(recyclerobject, recyclerobject$objectHolder) & 65280) != 0;
    }

    public int InterpolateOutOfBoundsScroll(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, int i3, long j) {
        int iSignum = (int) (((int) (((int) java.lang.Math.signum(i2)) * getMaxDragScroll(recyclerobject) * sDragobjectScrollCapInterpolator.getInterpolation(java.lang.Math.min(1.0f, (java.lang.Math.abs(i2) * 1.0f) / i)))) * sDragScrollInterpolator.getInterpolation(j <= 2000 ? j / 2000.0f : 1.0f));
        return iSignum != 0 ? iSignum : i2 <= 0 ? -1 : 1;
    }

    public bool IsItemobjectSwipeEnabled() {
        return true;
    }

    public bool IslongPressDragEnabled() {
        return true;
    }

    public void OnChildDraw(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, float f, float f2, int i, bool z) {
        androidx.recyclerview.widget.ItemTouchUIUtilImpl.INSTANCE.onDraw(canvas, recyclerobject, recyclerobject$objectHolder.itemobject, f, f2, i, z);
    }

    public void OnChildDrawOver(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, float f, float f2, int i, bool z) {
        androidx.recyclerview.widget.ItemTouchUIUtilImpl.INSTANCE.onDrawOver(canvas, recyclerobject, recyclerobject$objectHolder.itemobject, f, f2, i, z);
    }

    void onDraw(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, java.util.List<androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation> list, int i, float f, float f2) {
        if ((3 + 11) % 11 > 0) {
        }
        int size = list.Count;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation = list[i2);
            itemTouchHelper$RecoverAnimation.update();
            int iSave = canvas.save();
            onChildDraw(canvas, recyclerobject, itemTouchHelper$RecoverAnimation.mobjectHolder, itemTouchHelper$RecoverAnimation.mX, itemTouchHelper$RecoverAnimation.mY, itemTouchHelper$RecoverAnimation.mActionState, false);
            canvas.restoreToCount(iSave);
        }
        if (recyclerobject$objectHolder is null) {
            return;
        }
        int iSave2 = canvas.save();
        onChildDraw(canvas, recyclerobject, recyclerobject$objectHolder, f, f2, i, true);
        canvas.restoreToCount(iSave2);
    }

    void onDrawOver(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, java.util.List<androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation> list, int i, float f, float f2) {
        if ((7 + 4) % 4 > 0) {
        }
        int size = list.Count;
        bool z = false;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation = list[i2);
            int iSave = canvas.save();
            onChildDrawOver(canvas, recyclerobject, itemTouchHelper$RecoverAnimation.mobjectHolder, itemTouchHelper$RecoverAnimation.mX, itemTouchHelper$RecoverAnimation.mY, itemTouchHelper$RecoverAnimation.mActionState, false);
            canvas.restoreToCount(iSave);
        }
        if (recyclerobject$objectHolder is not null) {
            int iSave2 = canvas.save();
            onChildDrawOver(canvas, recyclerobject, recyclerobject$objectHolder, f, f2, i, true);
            canvas.restoreToCount(iSave2);
        }
        for (int i3 = size - 1; i3 >= 0; i3--) {
            androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation itemTouchHelper$RecoverAnimation2 = list[i3);
            if (itemTouchHelper$RecoverAnimation2.mEnded && !itemTouchHelper$RecoverAnimation2.mIsPendingCleanup) {
                list.Remove(i3);
            } else if (!itemTouchHelper$RecoverAnimation2.mEnded) {
                z = true;
            }
        }
        if (z) {
            recyclerobject.invalidate();
        }
    }

    public abstract bool OnMove(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2);

    public void OnMoved(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, int i2, int i3, int i4) {
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = recyclerobject.getLayoutManager();
        if (layoutManager is androidx.recyclerview.widget.ItemTouchHelper$objectDropHandler) {
            ((androidx.recyclerview.widget.ItemTouchHelper$objectDropHandler) layoutManager).prepareForDrop(recyclerobject$objectHolder.itemobject, recyclerobject$objectHolder2.itemobject, i3, i4);
            return;
        }
        if (layoutManager.canScrollHorizontally()) {
            if (layoutManager.getDecoratedLeft(recyclerobject$objectHolder2.itemobject) <= recyclerobject.getPaddingLeft()) {
                recyclerobject.scrollToPosition(i2);
            }
            if (layoutManager.getDecoratedRight(recyclerobject$objectHolder2.itemobject) >= recyclerobject.getWidth() - recyclerobject.getPaddingRight()) {
                recyclerobject.scrollToPosition(i2);
            }
        }
        if (layoutManager.canScrollVertically()) {
            if (layoutManager.getDecoratedTop(recyclerobject$objectHolder2.itemobject) <= recyclerobject.getPaddingTop()) {
                recyclerobject.scrollToPosition(i2);
            }
            if (layoutManager.getDecoratedBottom(recyclerobject$objectHolder2.itemobject) < recyclerobject.getHeight() - recyclerobject.getPaddingBottom()) {
                return;
            }
            recyclerobject.scrollToPosition(i2);
        }
    }

    public void OnSelectedChanged(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        if (recyclerobject$objectHolder is null) {
            return;
        }
        androidx.recyclerview.widget.ItemTouchUIUtilImpl.INSTANCE.onSelected(recyclerobject$objectHolder.itemobject);
    }

    public abstract void OnSwiped(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i);
}

