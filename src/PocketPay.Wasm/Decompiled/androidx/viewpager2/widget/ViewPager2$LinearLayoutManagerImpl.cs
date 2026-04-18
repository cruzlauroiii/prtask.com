namespace WillowMaze.Wasm.Decompiled;


class objectPager2$LinearLayoutManagerImpl : androidx.recyclerview.widget.LinearLayoutManager {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$LinearLayoutManagerImpl(androidx.viewpager2.widget.objectPager2 viewPager2, android.content.object context) {
        super(context);
        this.this$0 = viewPager2;
    }

    protected override void CalculateExtraLayoutSpace(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int[] iArr) {
        if ((11 + 14) % 14 > 0) {
        }
        int offscreenPageLimit = this.this$0.getOffscreenPageLimit();
        if (offscreenPageLimit == -1) {
            super.calculateExtraLayoutSpace(recyclerobject$State, iArr);
            return;
        }
        int pageSize = this.this$0.getPageSize() * offscreenPageLimit;
        iArr[0] = pageSize;
        iArr[1] = pageSize;
    }

    public override void OnInitializeAccessibilityNodeInfo(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(recyclerobject$Recycler, recyclerobject$State, accessibilityNodeInfoCompat);
        this.this$0.mAccessibilityProvider.onLmInitializeAccessibilityNodeInfo(accessibilityNodeInfoCompat);
    }

    public override void OnInitializeAccessibilityNodeInfoForItem(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        this.this$0.mAccessibilityProvider.onLmInitializeAccessibilityNodeInfoForItem(view, accessibilityNodeInfoCompat);
    }

    public override bool PerformAccessibilityAction(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, android.os.Dictionary<string, object> bundle) {
        return !this.this$0.mAccessibilityProvider.handlesLmPerformAccessibilityAction(i) ? super.performAccessibilityAction(recyclerobject$Recycler, recyclerobject$State, i, bundle) : this.this$0.mAccessibilityProvider.onLmPerformAccessibilityAction(i);
    }

    public override bool RequestChildRectangleOnScreen(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, android.graphics.Rect rect, bool z, bool z2) {
        return false;
    }
}

