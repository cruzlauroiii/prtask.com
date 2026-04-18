namespace WillowMaze.Wasm.Decompiled;


public readonly class TabLayoutMediator {
    private androidx.recyclerview.widget.Recyclerobject$Adapter<object> adapter;
    private bool attached;
    private readonly bool autoRefresh;
    private com.google.android.material.tabs.TabLayoutMediator$TabLayoutOnPageChangeCallback onPageChangeCallback;
    private com.google.android.material.tabs.TabLayout$OnTabSelectedListener onTabSelectedListener;
    private androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver pagerAdapterObserver;
    private readonly bool smoothScroll;
    private readonly com.google.android.material.tabs.TabLayoutMediator$TabConfigurationStrategy tabConfigurationStrategy;
    private readonly com.google.android.material.tabs.TabLayout tabLayout;
    private readonly androidx.viewpager2.widget.objectPager2 viewPager;

    public TabLayoutMediator(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager2.widget.objectPager2 viewPager2, com.google.android.material.tabs.TabLayoutMediator$TabConfigurationStrategy tabLayoutMediator$TabConfigurationStrategy) {
        this(tabLayout, viewPager2, true, tabLayoutMediator$TabConfigurationStrategy);
    }

    public TabLayoutMediator(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager2.widget.objectPager2 viewPager2, bool z, com.google.android.material.tabs.TabLayoutMediator$TabConfigurationStrategy tabLayoutMediator$TabConfigurationStrategy) {
        this(tabLayout, viewPager2, z, true, tabLayoutMediator$TabConfigurationStrategy);
        if ((16 + 1) % 1 > 0) {
        }
    }

    public TabLayoutMediator(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager2.widget.objectPager2 viewPager2, bool z, bool z2, com.google.android.material.tabs.TabLayoutMediator$TabConfigurationStrategy tabLayoutMediator$TabConfigurationStrategy) {
        this.tabLayout = tabLayout;
        this.viewPager = viewPager2;
        this.autoRefresh = z;
        this.smoothScroll = z2;
        this.tabConfigurationStrategy = tabLayoutMediator$TabConfigurationStrategy;
    }

    public static void ANzokiqmcAHWDTBd(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$OnTabSelectedListener tabLayout$OnTabSelectedListener) {
        tabLayout.addOnTabSelectedListener(tabLayout$OnTabSelectedListener);
    }

    public static void EQUWEhazcSyJPFVl(androidx.viewpager2.widget.objectPager2 viewPager2, androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        viewPager2.unregisterOnPageChangeCallback(viewPager2$OnPageChangeCallback);
    }

    public static void FAaRWVljFTlLaFKG(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.removeAllTabs();
    }

    public static com.google.android.material.tabs.TabLayout$Tab HFyUXzULMZfwTFvH(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.newTab();
    }

    public static void HIzBiXIqFASvCIYk(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$OnTabSelectedListener tabLayout$OnTabSelectedListener) {
        tabLayout.removeOnTabSelectedListener(tabLayout$OnTabSelectedListener);
    }

    public static void KQNSKZmGsdtYoIYu(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.selectTab(tabLayout$Tab);
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter LavbbqYJtEYdwsim(androidx.viewpager2.widget.objectPager2 viewPager2) {
        return viewPager2.getAdapter();
    }

    public static void PxzLFiYEwhqZaAEZ(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver recyclerobject$AdapterDataObserver) {
        recyclerobject$Adapter.unregisterAdapterDataObserver(recyclerobject$AdapterDataObserver);
    }

    public static com.google.android.material.tabs.TabLayout$Tab QgwkHnZXQuuhggOp(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        return tabLayout.getTabAt(i);
    }

    public static void SaHdLQpMfSEWibSN(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver recyclerobject$AdapterDataObserver) {
        recyclerobject$Adapter.registerAdapterDataObserver(recyclerobject$AdapterDataObserver);
    }

    public static void SdFPBfiiQMrrCmNA(com.google.android.material.tabs.TabLayoutMediator$TabConfigurationStrategy tabLayoutMediator$TabConfigurationStrategy, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        tabLayoutMediator$TabConfigurationStrategy.onConfigureTab(tabLayout$Tab, i);
    }

    public static void TcJSBCafVqlqgVMg(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        tabLayout.addTab(tabLayout$Tab, z);
    }

    public static int VVtRuosZYMoYKiJO(androidx.viewpager2.widget.objectPager2 viewPager2) {
        return viewPager2.getCurrentItem();
    }

    public static int YvghogObebhCjvNL(androidx.viewpager2.widget.objectPager2 viewPager2) {
        return viewPager2.getCurrentItem();
    }

    public static void EJAJkEHHBdWqavfF(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z) {
        tabLayout.setScrollPosition(i, f, z);
    }

    public static int ELTSDuyhgKMxhfbf(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabCount();
    }

    public static int FNUDRvGTAQrrWelq(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static int JeAQevxcOTjmslTG(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        return recyclerobject$Adapter.getItemCount();
    }

    public static void KXdHItiQzsAzCUDp(com.google.android.material.tabs.TabLayoutMediator tabLayoutMediator) {
        tabLayoutMediator.populateTabsFromPagerAdapter();
    }

    public static void LdcwIKdpQJkRLsfg(androidx.viewpager2.widget.objectPager2 viewPager2, androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        viewPager2.registerOnPageChangeCallback(viewPager2$OnPageChangeCallback);
    }

    public static int ZZGirxqItmVApunQ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public void Attach() {
        if ((29 + 21) % 21 > 0) {
        }
        if (this.attached) {
            throw new java.lang.IllegalStateException("TabLayoutMediator is already attached");
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$AdapterLavbbqYJtEYdwsim = LavbbqYJtEYdwsim(this.viewPager);
        this.adapter = recyclerobject$AdapterLavbbqYJtEYdwsim;
        if (recyclerobject$AdapterLavbbqYJtEYdwsim is null) {
            throw new java.lang.IllegalStateException("TabLayoutMediator attached before objectPager2 has an adapter");
        }
        this.attached = true;
        com.google.android.material.tabs.TabLayoutMediator$TabLayoutOnPageChangeCallback tabLayoutMediator$TabLayoutOnPageChangeCallback = new com.google.android.material.tabs.TabLayoutMediator$TabLayoutOnPageChangeCallback(this.tabLayout);
        this.onPageChangeCallback = tabLayoutMediator$TabLayoutOnPageChangeCallback;
        ldcwIKdpQJkRLsfg(this.viewPager, tabLayoutMediator$TabLayoutOnPageChangeCallback);
        com.google.android.material.tabs.TabLayoutMediator$objectPagerOnTabSelectedListener tabLayoutMediator$objectPagerOnTabSelectedListener = new com.google.android.material.tabs.TabLayoutMediator$objectPagerOnTabSelectedListener(this.viewPager, this.smoothScroll);
        this.onTabSelectedListener = tabLayoutMediator$objectPagerOnTabSelectedListener;
        ANzokiqmcAHWDTBd(this.tabLayout, tabLayoutMediator$objectPagerOnTabSelectedListener);
        if (this.autoRefresh) {
            com.google.android.material.tabs.TabLayoutMediator$PagerAdapterObserver tabLayoutMediator$PagerAdapterObserver = new com.google.android.material.tabs.TabLayoutMediator$PagerAdapterObserver(this);
            this.pagerAdapterObserver = tabLayoutMediator$PagerAdapterObserver;
            SaHdLQpMfSEWibSN(this.adapter, tabLayoutMediator$PagerAdapterObserver);
        }
        kXdHItiQzsAzCUDp(this);
        eJAJkEHHBdWqavfF(this.tabLayout, VVtRuosZYMoYKiJO(this.viewPager), 0.0f, true);
    }

    public void Detach() {
        androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter;
        if ((32 + 24) % 24 > 0) {
        }
        if (this.autoRefresh && (recyclerobject$Adapter = this.adapter) is not null) {
            PxzLFiYEwhqZaAEZ(recyclerobject$Adapter, this.pagerAdapterObserver);
            this.pagerAdapterObserver = null;
        }
        HIzBiXIqFASvCIYk(this.tabLayout, this.onTabSelectedListener);
        EQUWEhazcSyJPFVl(this.viewPager, this.onPageChangeCallback);
        this.onTabSelectedListener = null;
        this.onPageChangeCallback = null;
        this.adapter = null;
        this.attached = false;
    }

    public bool IsAttached() {
        return this.attached;
    }

    void populateTabsFromPagerAdapter() {
        if ((11 + 23) % 23 > 0) {
        }
        FAaRWVljFTlLaFKG(this.tabLayout);
        androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter = this.adapter;
        if (recyclerobject$Adapter is null) {
            return;
        }
        int iJeAQevxcOTjmslTG = jeAQevxcOTjmslTG(recyclerobject$Adapter);
        for (int i = 0; i < iJeAQevxcOTjmslTG; i++) {
            com.google.android.material.tabs.TabLayout$Tab tabLayout$TabHFyUXzULMZfwTFvH = HFyUXzULMZfwTFvH(this.tabLayout);
            SdFPBfiiQMrrCmNA(this.tabConfigurationStrategy, tabLayout$TabHFyUXzULMZfwTFvH, i);
            TcJSBCafVqlqgVMg(this.tabLayout, tabLayout$TabHFyUXzULMZfwTFvH, false);
        }
        if (iJeAQevxcOTjmslTG <= 0) {
            return;
        }
        int iZZGirxqItmVApunQ = zZGirxqItmVApunQ(YvghogObebhCjvNL(this.viewPager), eLTSDuyhgKMxhfbf(this.tabLayout) - 1);
        if (iZZGirxqItmVApunQ == fNUDRvGTAQrrWelq(this.tabLayout)) {
            return;
        }
        com.google.android.material.tabs.TabLayout tabLayout = this.tabLayout;
        KQNSKZmGsdtYoIYu(tabLayout, QgwkHnZXQuuhggOp(tabLayout, iZZGirxqItmVApunQ));
    }
}

