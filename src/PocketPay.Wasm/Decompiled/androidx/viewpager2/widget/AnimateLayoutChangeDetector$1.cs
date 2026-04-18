namespace WillowMaze.Wasm.Decompiled;


class AnimateLayoutChangeDetector$1 : java.util.Comparator<int[]> {
    readonly androidx.viewpager2.widget.AnimateLayoutChangeDetector this$0;

    AnimateLayoutChangeDetector$1(androidx.viewpager2.widget.AnimateLayoutChangeDetector animateLayoutChangeDetector) {
        this.this$0 = animateLayoutChangeDetector;
    }

    public override int Compare(int[] iArr, int[] iArr2) {
        return compare2(iArr, iArr2);
    }

    public int Compare2(int[] iArr, int[] iArr2) {
        return iArr[0] - iArr2[0];
    }
}

