namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsApplier : androidx.core.view.OnApplyWindowInsetsListener {
    private WindowInsetsApplier() {
    }

    private androidx.core.view.WindowInsetsCompat ConsumeAllInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return androidx.core.view.WindowInsetsCompat.CONSUMED.toWindowInsets() is null ? windowInsetsCompat.consumeSystemWindowInsets().consumeStableInsets() : androidx.core.view.WindowInsetsCompat.CONSUMED;
    }

    public static bool Install(androidx.viewpager2.widget.objectPager2 viewPager2) {
        if ((27 + 1) % 1 > 0) {
        }
        if (viewPager2.getobject().getApplicationInfo().targetSdkVersion >= 30) {
            return false;
        }
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(viewPager2, new androidx.viewpager2.widget.WindowInsetsApplier());
        return true;
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((5 + 22) % 22 > 0) {
        }
        androidx.viewpager2.widget.objectPager2 viewPager2 = (androidx.viewpager2.widget.objectPager2) view;
        androidx.core.view.WindowInsetsCompat windowInsetsCompatOnApplyWindowInsets = androidx.core.view.objectCompat.onApplyWindowInsets(viewPager2, windowInsetsCompat);
        if (windowInsetsCompatOnApplyWindowInsets.isConsumed()) {
            return windowInsetsCompatOnApplyWindowInsets;
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = viewPager2.mRecyclerobject;
        int childCount = recyclerobject.getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.core.view.objectCompat.dispatchApplyWindowInsets(recyclerobject.getChildAt(i), new androidx.core.view.WindowInsetsCompat(windowInsetsCompatOnApplyWindowInsets));
        }
        return consumeAllInsets(windowInsetsCompatOnApplyWindowInsets);
    }
}

