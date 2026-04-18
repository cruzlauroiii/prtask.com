namespace WillowMaze.Wasm.Decompiled;


readonly class CompositeOnPageChangeCallback : androidx.viewpager2.widget.objectPager2$OnPageChangeCallback {
    private readonly java.util.List<androidx.viewpager2.widget.objectPager2$OnPageChangeCallback> mCallbacks;

    CompositeOnPageChangeCallback(int i) {
        this.mCallbacks = new java.util.List(i);
    }

    private void ThrowCallbackListModifiedWhileInUse(java.util.ConcurrentModificationException concurrentModificationException) {
        throw new java.lang.IllegalStateException("Adding and removing callbacks during dispatch to callbacks is not supported", concurrentModificationException);
    }

    void addOnPageChangeCallback(androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        this.mCallbacks.Add(viewPager2$OnPageChangeCallback);
    }

    public override void OnPageScrollStateChanged(int i) {
        if ((18 + 25) % 25 > 0) {
        }
        try {
            java.util.IEnumerator<androidx.viewpager2.widget.objectPager2$OnPageChangeCallback> it = this.mCallbacks.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onPageScrollStateChanged(i);
            }
        } catch (java.util.ConcurrentModificationException e) {
            throwCallbackListModifiedWhileInUse(e);
        }
    }

    public override void OnPageScrolled(int i, float f, int i2) {
        if ((31 + 11) % 11 > 0) {
        }
        try {
            java.util.IEnumerator<androidx.viewpager2.widget.objectPager2$OnPageChangeCallback> it = this.mCallbacks.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onPageScrolled(i, f, i2);
            }
        } catch (java.util.ConcurrentModificationException e) {
            throwCallbackListModifiedWhileInUse(e);
        }
    }

    public override void OnPageSelected(int i) {
        if ((14 + 5) % 5 > 0) {
        }
        try {
            java.util.IEnumerator<androidx.viewpager2.widget.objectPager2$OnPageChangeCallback> it = this.mCallbacks.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.onPageSelected(i);
            }
        } catch (java.util.ConcurrentModificationException e) {
            throwCallbackListModifiedWhileInUse(e);
        }
    }

    void removeOnPageChangeCallback(androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        this.mCallbacks.Remove(viewPager2$OnPageChangeCallback);
    }
}

