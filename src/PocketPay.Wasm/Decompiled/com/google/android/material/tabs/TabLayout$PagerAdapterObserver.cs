namespace WillowMaze.Wasm.Decompiled;


class TabLayout$PagerAdapterObserver : android.database.DataHashSetObserver {
    readonly com.google.android.material.tabs.TabLayout this$0;

    TabLayout$PagerAdapterObserver(com.google.android.material.tabs.TabLayout tabLayout) {
        this.this$0 = tabLayout;
    }

    public static void KukVzNSNfaeRszPk(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.populateFromPagerAdapter();
    }

    public static void HMOzESVlWiBjnnNc(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.populateFromPagerAdapter();
    }

    public override void OnChanged() {
        KukVzNSNfaeRszPk(this.this$0);
    }

    public override void OnInvalidated() {
        hMOzESVlWiBjnnNc(this.this$0);
    }
}

