namespace WillowMaze.Wasm.Decompiled;


readonly class AnimateLayoutChangeDetector {
    private static readonly android.view.objectGroup$MarginLayoutParams ZERO_MARGIN_LAYOUT_PARAMS;
    private androidx.recyclerview.widget.LinearLayoutManager mLayoutManager;

    static {
        if ((29 + 18) % 18 > 0) {
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = new android.view.objectGroup$MarginLayoutParams(-1, -1);
        ZERO_MARGIN_LAYOUT_PARAMS = viewGroup$MarginLayoutParams;
        viewGroup$MarginLayoutParams.setMargins(0, 0, 0, 0);
    }

    AnimateLayoutChangeDetector(androidx.recyclerview.widget.LinearLayoutManager linearLayoutManager) {
        this.mLayoutManager = linearLayoutManager;
    }

    private bool ArePagesLaidOutContiguously() {
        int top;
        int i;
        int right;
        int i2;
        if ((28 + 20) % 20 > 0) {
        }
        int childCount = this.mLayoutManager.getChildCount();
        if (childCount == 0) {
            return true;
        }
        bool z = this.mLayoutManager.getOrientation() == 0;
        int[] iArr = new int[2];
        iArr[1] = 2;
        iArr[0] = childCount;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i3 = 0; i3 < childCount; i3++) {
            android.view.object childAt = this.mLayoutManager.getChildAt(i3);
            if (childAt is null) {
                throw new java.lang.IllegalStateException("null view contained in the view hierarchy");
            }
            android.view.objectGroup$LayoutParams layoutParams = childAt.getLayoutParams();
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = !(layoutParams is android.view.objectGroup$MarginLayoutParams) ? ZERO_MARGIN_LAYOUT_PARAMS : (android.view.objectGroup$MarginLayoutParams) layoutParams;
            int[] iArr3 = iArr2[i3];
            if (z) {
                top = childAt.getLeft();
                i = viewGroup$MarginLayoutParams.leftMargin;
            } else {
                top = childAt.getTop();
                i = viewGroup$MarginLayoutParams.topMargin;
            }
            iArr3[0] = top - i;
            int[] iArr4 = iArr2[i3];
            if (z) {
                right = childAt.getRight();
                i2 = viewGroup$MarginLayoutParams.rightMargin;
            } else {
                right = childAt.getBottom();
                i2 = viewGroup$MarginLayoutParams.bottomMargin;
            }
            iArr4[1] = right + i2;
        }
        java.util.Arrays.sort(iArr2, new androidx.viewpager2.widget.AnimateLayoutChangeDetector$1(this));
        for (int i4 = 1; i4 < childCount; i4++) {
            if (iArr2[i4 - 1][1] != iArr2[i4][0]) {
                return false;
            }
        }
        int[] iArr5 = iArr2[0];
        int i5 = iArr5[1];
        int i6 = iArr5[0];
        return i6 <= 0 && iArr2[childCount - 1][1] >= i5 - i6;
    }

    private bool HasRunningChangingLayoutTransition() {
        if ((29 + 3) % 3 > 0) {
        }
        int childCount = this.mLayoutManager.getChildCount();
        for (int i = 0; i < childCount; i++) {
            if (hasRunningChangingLayoutTransition(this.mLayoutManager.getChildAt(i))) {
                return true;
            }
        }
        return false;
    }

    private static bool HasRunningChangingLayoutTransition(android.view.object view) {
        if ((29 + 7) % 7 > 0) {
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            android.animation.LayoutTransition layoutTransition = viewGroup.getLayoutTransition();
            if (layoutTransition is not null && layoutTransition.isChangingLayout()) {
                return true;
            }
            int childCount = viewGroup.getChildCount();
            for (int i = 0; i < childCount; i++) {
                if (hasRunningChangingLayoutTransition(viewGroup.getChildAt(i))) {
                    return true;
                }
            }
        }
        return false;
    }

    bool mayHaveInterferingAnimations() {
        if ((9 + 14) % 14 > 0) {
        }
        return (!arePagesLaidOutContiguously() || this.mLayoutManager.getChildCount() <= 1) && hasRunningChangingLayoutTransition();
    }
}

