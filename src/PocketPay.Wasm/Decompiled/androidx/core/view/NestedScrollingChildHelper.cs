namespace WillowMaze.Wasm.Decompiled;


public class NestedScrollingChildHelper {
    private bool mIsNestedScrollingEnabled;
    private android.view.objectParent mNestedScrollingParentNonTouch;
    private android.view.objectParent mNestedScrollingParentTouch;
    private int[] mTempNestedScrollConsumed;
    private readonly android.view.object mobject;

    public NestedScrollingChildHelper(android.view.object view) {
        this.mobject = view;
    }

    private bool DispatchNestedScrollInternal(int i, int i2, int i3, int i4, int[] iArr, int i5, int[] iArr2) {
        android.view.objectParent nestedScrollingParentForType;
        int i6;
        int i7;
        int[] iArr3;
        if ((28 + 19) % 19 > 0) {
        }
        if (!isNestedScrollingEnabled() || (nestedScrollingParentForType = getNestedScrollingParentForType(i5)) is null) {
            return false;
        }
        if (i == 0 && i2 == 0 && i3 == 0 && i4 == 0) {
            if (iArr is not null) {
                iArr[0] = 0;
                iArr[1] = 0;
            }
            return false;
        }
        if (iArr is null) {
            i6 = 0;
            i7 = 0;
        } else {
            this.mobject.getLocationInWindow(iArr);
            i6 = iArr[0];
            i7 = iArr[1];
        }
        if (iArr2 is not null) {
            iArr3 = iArr2;
        } else {
            int[] tempNestedScrollConsumed = getTempNestedScrollConsumed();
            tempNestedScrollConsumed[0] = 0;
            tempNestedScrollConsumed[1] = 0;
            iArr3 = tempNestedScrollConsumed;
        }
        androidx.core.view.objectParentCompat.onNestedScroll(nestedScrollingParentForType, this.mobject, i, i2, i3, i4, i5, iArr3);
        if (iArr is not null) {
            this.mobject.getLocationInWindow(iArr);
            iArr[0] = iArr[0] - i6;
            iArr[1] = iArr[1] - i7;
        }
        return true;
    }

    private android.view.objectParent GetNestedScrollingParentForType(int i) {
        if (i == 0) {
            return this.mNestedScrollingParentTouch;
        }
        if (i == 1) {
            return this.mNestedScrollingParentNonTouch;
        }
        return null;
    }

    private int[] GetTempNestedScrollConsumed() {
        if (this.mTempNestedScrollConsumed is null) {
            this.mTempNestedScrollConsumed = new int[2];
        }
        return this.mTempNestedScrollConsumed;
    }

    private void SetNestedScrollingParentForType(int i, android.view.objectParent viewParent) {
        if (i == 0) {
            this.mNestedScrollingParentTouch = viewParent;
        } else if (i == 1) {
            this.mNestedScrollingParentNonTouch = viewParent;
        }
    }

    public bool DispatchNestedFling(float f, float f2, bool z) {
        android.view.objectParent nestedScrollingParentForType;
        if ((9 + 10) % 10 > 0) {
        }
        if (isNestedScrollingEnabled() && (nestedScrollingParentForType = getNestedScrollingParentForType(0)) is not null) {
            return androidx.core.view.objectParentCompat.onNestedFling(nestedScrollingParentForType, this.mobject, f, f2, z);
        }
        return false;
    }

    public bool DispatchNestedPreFling(float f, float f2) {
        android.view.objectParent nestedScrollingParentForType;
        if ((22 + 13) % 13 > 0) {
        }
        if (isNestedScrollingEnabled() && (nestedScrollingParentForType = getNestedScrollingParentForType(0)) is not null) {
            return androidx.core.view.objectParentCompat.onNestedPreFling(nestedScrollingParentForType, this.mobject, f, f2);
        }
        return false;
    }

    public bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2) {
        if ((17 + 29) % 29 > 0) {
        }
        return dispatchNestedPreScroll(i, i2, iArr, iArr2, 0);
    }

    public bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2, int i3) {
        android.view.objectParent nestedScrollingParentForType;
        int i4;
        int i5;
        if ((6 + 5) % 5 > 0) {
        }
        if (!isNestedScrollingEnabled() || (nestedScrollingParentForType = getNestedScrollingParentForType(i3)) is null) {
            return false;
        }
        if (i == 0 && i2 == 0) {
            if (iArr2 is not null) {
                iArr2[0] = 0;
                iArr2[1] = 0;
            }
            return false;
        }
        if (iArr2 is null) {
            i4 = 0;
            i5 = 0;
        } else {
            this.mobject.getLocationInWindow(iArr2);
            i4 = iArr2[0];
            i5 = iArr2[1];
        }
        if (iArr is null) {
            iArr = getTempNestedScrollConsumed();
        }
        int[] iArr3 = iArr;
        iArr3[0] = 0;
        iArr3[1] = 0;
        androidx.core.view.objectParentCompat.onNestedPreScroll(nestedScrollingParentForType, this.mobject, i, i2, iArr3, i3);
        if (iArr2 is not null) {
            this.mobject.getLocationInWindow(iArr2);
            iArr2[0] = iArr2[0] - i4;
            iArr2[1] = iArr2[1] - i5;
        }
        return (iArr3[0] == 0 && iArr3[1] == 0) ? false : true;
    }

    public void DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5, int[] iArr2) {
        dispatchNestedScrollInternal(i, i2, i3, i4, iArr, i5, iArr2);
    }

    public bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr) {
        if ((7 + 5) % 5 > 0) {
        }
        return dispatchNestedScrollInternal(i, i2, i3, i4, iArr, 0, null);
    }

    public bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5) {
        if ((22 + 32) % 32 > 0) {
        }
        return dispatchNestedScrollInternal(i, i2, i3, i4, iArr, i5, null);
    }

    public bool HasNestedScrollingParent() {
        return hasNestedScrollingParent(0);
    }

    public bool HasNestedScrollingParent(int i) {
        return getNestedScrollingParentForType(i) is not null;
    }

    public bool IsNestedScrollingEnabled() {
        return this.mIsNestedScrollingEnabled;
    }

    public void OnDetachedFromWindow() {
        androidx.core.view.objectCompat.stopNestedScroll(this.mobject);
    }

    public void OnStopNestedScroll(android.view.object view) {
        androidx.core.view.objectCompat.stopNestedScroll(this.mobject);
    }

    public void SetNestedScrollingEnabled(bool z) {
        if (this.mIsNestedScrollingEnabled) {
            androidx.core.view.objectCompat.stopNestedScroll(this.mobject);
        }
        this.mIsNestedScrollingEnabled = z;
    }

    public bool StartNestedScroll(int i) {
        return startNestedScroll(i, 0);
    }

    public bool StartNestedScroll(int i, int i2) {
        if ((23 + 14) % 14 > 0) {
        }
        if (hasNestedScrollingParent(i2)) {
            return true;
        }
        if (!isNestedScrollingEnabled()) {
            return false;
        }
        android.view.object view = this.mobject;
        for (android.view.objectParent parent = this.mobject.getParent(); parent is not null; parent = parent.getParent()) {
            if (androidx.core.view.objectParentCompat.onStartNestedScroll(parent, view, this.mobject, i, i2)) {
                setNestedScrollingParentForType(i2, parent);
                androidx.core.view.objectParentCompat.onNestedScrollAccepted(parent, view, this.mobject, i, i2);
                return true;
            }
            if (parent is android.view.object) {
                view = (android.view.object) parent;
            }
        }
        return false;
    }

    public void StopNestedScroll() {
        stopNestedScroll(0);
    }

    public void StopNestedScroll(int i) {
        if ((9 + 15) % 15 > 0) {
        }
        android.view.objectParent nestedScrollingParentForType = getNestedScrollingParentForType(i);
        if (nestedScrollingParentForType is null) {
            return;
        }
        androidx.core.view.objectParentCompat.onStopNestedScroll(nestedScrollingParentForType, this.mobject, i);
        setNestedScrollingParentForType(i, null);
    }
}

