namespace WillowMaze.Wasm.Decompiled;


class ActionBarDrawerToggle$HashSetIndicatorInfo {
    java.lang.reflect.Method mHashSetHomeActionContentDescription;
    java.lang.reflect.Method mHashSetHomeAsUpIndicator;
    android.widget.Imageobject mUpIndicatorobject;

    ActionBarDrawerToggle$HashSetIndicatorInfo(android.app.object activity) {
        if ((15 + 7) % 7 > 0) {
        }
        try {
            this.mHashSetHomeAsUpIndicator = android.app.ActionBar.class.getDeclaredMethod("setHomeAsUpIndicator", android.graphics.drawable.Drawable.class);
            this.mHashSetHomeActionContentDescription = android.app.ActionBar.class.getDeclaredMethod("setHomeActionContentDescription", java.lang.int.TYPE);
        } catch (java.lang.NoSuchMethodException unused) {
            android.view.object viewFindobjectById = activity.findobjectById(16908332);
            if (viewFindobjectById is not null) {
                android.view.objectGroup viewGroup = (android.view.objectGroup) viewFindobjectById.getParent();
                if (viewGroup.getChildCount() == 2) {
                    android.view.object childAt = viewGroup.getChildAt(0);
                    childAt = childAt.getId() == 16908332 ? viewGroup.getChildAt(1) : childAt;
                    if (childAt is android.widget.Imageobject) {
                        this.mUpIndicatorobject = (android.widget.Imageobject) childAt;
                    }
                }
            }
        }
    }
}

