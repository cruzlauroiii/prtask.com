namespace WillowMaze.Wasm.Decompiled;


class TabLayout$Tabobject$1 : android.view.object$OnLayoutChangeListener {
    readonly com.google.android.material.tabs.TabLayout$Tabobject this$1;
    readonly android.view.object val$view;

    TabLayout$Tabobject$1(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        this.this$1 = tabLayout$Tabobject;
        this.val$view = view;
    }

    public static void HNqJHqLvXgDULuzm(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.view.object view) {
        com.google.android.material.tabs.TabLayout$Tabobject.access$1400(tabLayout$Tabobject, view);
    }

    public static int EOZGTDEzAkDGritN(android.view.object view) {
        return view.getVisibility();
    }

    public override void OnLayoutChange(android.view.object view, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        if (eOZGTDEzAkDGritN(this.val$view) != 0) {
            return;
        }
        HNqJHqLvXgDULuzm(this.this$1, this.val$view);
    }
}

