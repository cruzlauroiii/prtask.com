namespace WillowMaze.Wasm.Decompiled;


public class TabLayout$objectPagerOnTabSelectedListener : com.google.android.material.tabs.TabLayout$OnTabSelectedListener {
    private readonly androidx.viewpager.widget.objectPager viewPager;

    public TabLayout$objectPagerOnTabSelectedListener(androidx.viewpager.widget.objectPager viewPager) {
        this.viewPager = viewPager;
    }

    public static void AlwfZTmCEeEYckFa(androidx.viewpager.widget.objectPager viewPager, int i) {
        viewPager.setCurrentItem(i);
    }

    public static int UVRPuXDMhzcINKyR(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public override void OnTabReselected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
    }

    public override void OnTabSelected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        AlwfZTmCEeEYckFa(this.viewPager, UVRPuXDMhzcINKyR(tabLayout$Tab));
    }

    public override void OnTabUnselected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
    }
}

