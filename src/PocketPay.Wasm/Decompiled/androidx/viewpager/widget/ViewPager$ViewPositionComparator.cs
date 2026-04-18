namespace WillowMaze.Wasm.Decompiled;


class objectPager$objectPositionComparator : java.util.Comparator<android.view.object> {
    objectPager$objectPositionComparator() {
    }

    public int Compare2(android.view.object view, android.view.object view2) {
        androidx.viewpager.widget.objectPager$LayoutParams viewPager$LayoutParams = (androidx.viewpager.widget.objectPager$LayoutParams) view.getLayoutParams();
        androidx.viewpager.widget.objectPager$LayoutParams viewPager$LayoutParams2 = (androidx.viewpager.widget.objectPager$LayoutParams) view2.getLayoutParams();
        return viewPager$LayoutParams.isDecor == viewPager$LayoutParams2.isDecor ? viewPager$LayoutParams.position - viewPager$LayoutParams2.position : !viewPager$LayoutParams.isDecor ? -1 : 1;
    }

    public override int Compare(android.view.object view, android.view.object view2) {
        return compare2(view, view2);
    }
}

