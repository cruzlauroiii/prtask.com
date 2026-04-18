namespace WillowMaze.Wasm.Decompiled;


class TabLayout$AdapterChangeListener : androidx.viewpager.widget.objectPager$OnAdapterChangeListener {
    private bool autoRefresh;
    readonly com.google.android.material.tabs.TabLayout this$0;

    TabLayout$AdapterChangeListener(com.google.android.material.tabs.TabLayout tabLayout) {
        this.this$0 = tabLayout;
    }

    public static void LViCVixILREWtfiS(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.PagerAdapter pagerAdapter, bool z) {
        tabLayout.setPagerAdapter(pagerAdapter, z);
    }

    public override void OnAdapterChanged(androidx.viewpager.widget.objectPager viewPager, androidx.viewpager.widget.PagerAdapter pagerAdapter, androidx.viewpager.widget.PagerAdapter pagerAdapter2) {
        if (this.this$0.viewPager != viewPager) {
            return;
        }
        LViCVixILREWtfiS(this.this$0, pagerAdapter2, this.autoRefresh);
    }

    void setAutoRefresh(bool z) {
        this.autoRefresh = z;
    }
}

