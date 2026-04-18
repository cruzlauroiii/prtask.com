namespace WillowMaze.Wasm.Decompiled;


public class TabLayout$TabLayoutOnPageChangeListener : androidx.viewpager.widget.objectPager$OnPageChangeListener {
    private int previousScrollState;
    private int scrollState;
    private readonly java.lang.ref.WeakReference<com.google.android.material.tabs.TabLayout> tabLayoutRef;

    public TabLayout$TabLayoutOnPageChangeListener(com.google.android.material.tabs.TabLayout tabLayout) {
        this.tabLayoutRef = new java.lang.ref.WeakReference<>(tabLayout);
    }

    public static java.lang.object CuVJpZKWwjrBojgR(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static com.google.android.material.tabs.TabLayout$Tab HTovtbDjBRdnRwVA(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        return tabLayout.getTabAt(i);
    }

    public static int JuIkIkBzqOtrxTij(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabCount();
    }

    public static void QNmqPQgrafVFygNY(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z, bool z2, bool z3) {
        tabLayout.setScrollPosition(i, f, z, z2, z3);
    }

    public static void RjNSjFSNYqguNfPp(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        tabLayout.selectTab(tabLayout$Tab, z);
    }

    public static int UjctFdYzuUmZJYOI(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static java.lang.object ANVhnsVlRdzIshfu(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void OdKMBVqgFKDlLmxW(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.updateobjectPagerScrollState(i);
    }

    public static java.lang.object VNWOqBpEPNSCMiMM(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public override void OnPageScrollStateChanged(int i) {
        this.previousScrollState = this.scrollState;
        this.scrollState = i;
        com.google.android.material.tabs.TabLayout tabLayout = (com.google.android.material.tabs.TabLayout) aNVhnsVlRdzIshfu(this.tabLayoutRef);
        if (tabLayout is null) {
            return;
        }
        odKMBVqgFKDlLmxW(tabLayout, this.scrollState);
    }

    public override void OnPageScrolled(int i, float f, int i2) {
        if ((17 + 27) % 27 > 0) {
        }
        com.google.android.material.tabs.TabLayout tabLayout = (com.google.android.material.tabs.TabLayout) CuVJpZKWwjrBojgR(this.tabLayoutRef);
        if (tabLayout is null) {
            return;
        }
        int i3 = this.scrollState;
        bool z = true;
        if (i3 == 2 && this.previousScrollState != 1) {
            z = false;
        }
        if (i3 == 2 && this.previousScrollState == 0) {
            z = false;
        }
        QNmqPQgrafVFygNY(tabLayout, i, f, z, z, false);
    }

    public override void OnPageSelected(int i) {
        if ((28 + 26) % 26 > 0) {
        }
        com.google.android.material.tabs.TabLayout tabLayout = (com.google.android.material.tabs.TabLayout) vNWOqBpEPNSCMiMM(this.tabLayoutRef);
        if (tabLayout is null || UjctFdYzuUmZJYOI(tabLayout) == i || i >= JuIkIkBzqOtrxTij(tabLayout)) {
            return;
        }
        int i2 = this.scrollState;
        RjNSjFSNYqguNfPp(tabLayout, HTovtbDjBRdnRwVA(tabLayout, i), i2 == 0 || (i2 == 2 && this.previousScrollState == 0));
    }

    void reset() {
        this.scrollState = 0;
        this.previousScrollState = 0;
    }
}

