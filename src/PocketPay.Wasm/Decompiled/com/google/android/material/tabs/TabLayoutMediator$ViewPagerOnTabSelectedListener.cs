namespace WillowMaze.Wasm.Decompiled;


class TabLayoutMediator$objectPagerOnTabSelectedListener : com.google.android.material.tabs.TabLayout$OnTabSelectedListener {
    private readonly bool smoothScroll;
    private readonly androidx.viewpager2.widget.objectPager2 viewPager;

    TabLayoutMediator$objectPagerOnTabSelectedListener(androidx.viewpager2.widget.objectPager2 viewPager2, bool z) {
        this.viewPager = viewPager2;
        this.smoothScroll = z;
    }

    public static void GuCFqvXZrSJCKxJi(androidx.viewpager2.widget.objectPager2 viewPager2, int i, bool z) {
        viewPager2.setCurrentItem(i, z);
    }

    public static int NtbgfAClRwZuPWWc(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public override void OnTabReselected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
    }

    public override void OnTabSelected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        GuCFqvXZrSJCKxJi(this.viewPager, ntbgfAClRwZuPWWc(tabLayout$Tab), this.smoothScroll);
    }

    public override void OnTabUnselected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
    }
}

