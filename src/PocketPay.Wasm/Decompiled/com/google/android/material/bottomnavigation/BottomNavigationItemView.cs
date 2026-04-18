namespace WillowMaze.Wasm.Decompiled;


public class BottomNavigationItemobject : com.google.android.material.navigation.NavigationBarItemobject {
    public BottomNavigationItemobject(android.content.object context) {
        super(context);
    }

    protected override int GetItemDefaultMarginResId() {
        return com.google.android.material.R$dimen.design_bottom_navigation_margin;
    }

    protected override int GetItemLayoutResId() {
        return com.google.android.material.R$layout.design_bottom_navigation_item;
    }
}

