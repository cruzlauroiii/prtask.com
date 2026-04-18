namespace WillowMaze.Wasm.Decompiled;


class MenuItemWrapperICS$ActionProviderWrapperJB : androidx.appcompat.view.menu.MenuItemWrapperICS$ActionProviderWrapper : android.view.ActionProvider$VisibilityListener {
    private androidx.core.view.ActionProvider$VisibilityListener mListener;
    readonly androidx.appcompat.view.menu.MenuItemWrapperICS this$0;

    MenuItemWrapperICS$ActionProviderWrapperJB(androidx.appcompat.view.menu.MenuItemWrapperICS menuItemWrapperICS, android.content.object context, android.view.ActionProvider actionProvider) {
        super(menuItemWrapperICS, context, actionProvider);
        this.this$0 = menuItemWrapperICS;
    }

    public static void GHoLxaiXrNejaknj(android.view.ActionProvider actionProvider) {
        actionProvider.refreshVisibility();
    }

    public static void GHoLxaiXrNejaknj(android.view.ActionProvider actionProvider, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHoLxaiXrNejaknj(android.view.ActionProvider actionProvider, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GHoLxaiXrNejaknj(android.view.ActionProvider actionProvider, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CAIXLCzkAKJZtXcd(android.view.ActionProvider actionProvider, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CAIXLCzkAKJZtXcd(android.view.ActionProvider actionProvider, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CAIXLCzkAKJZtXcd(android.view.ActionProvider actionProvider, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool CAIXLCzkAKJZtXcd(android.view.ActionProvider actionProvider) {
        return actionProvider.overridesItemVisibility();
    }

    public static void DuDuWWzgbIzGRSBh(androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, bool z) {
        actionProvider$VisibilityListener.onActionProviderVisibilityChanged(z);
    }

    public static void DuDuWWzgbIzGRSBh(androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, bool z, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DuDuWWzgbIzGRSBh(androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, bool z, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DuDuWWzgbIzGRSBh(androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, bool z, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SmBkQHMFwDqYLcqa(android.view.ActionProvider actionProvider, android.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener) {
        actionProvider.setVisibilityListener(actionProvider$VisibilityListener);
    }

    public static void SmBkQHMFwDqYLcqa(android.view.ActionProvider actionProvider, android.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SmBkQHMFwDqYLcqa(android.view.ActionProvider actionProvider, android.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SmBkQHMFwDqYLcqa(android.view.ActionProvider actionProvider, android.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TozoXWlfmKEOQxhH(android.view.ActionProvider actionProvider, android.view.MenuItem menuItem) {
        return actionProvider.onCreateActionobject(menuItem);
    }

    public static void TozoXWlfmKEOQxhH(android.view.ActionProvider actionProvider, android.view.MenuItem menuItem, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TozoXWlfmKEOQxhH(android.view.ActionProvider actionProvider, android.view.MenuItem menuItem, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TozoXWlfmKEOQxhH(android.view.ActionProvider actionProvider, android.view.MenuItem menuItem, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwQkrBmvJeLZqOck(android.view.ActionProvider actionProvider, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XwQkrBmvJeLZqOck(android.view.ActionProvider actionProvider, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwQkrBmvJeLZqOck(android.view.ActionProvider actionProvider, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XwQkrBmvJeLZqOck(android.view.ActionProvider actionProvider) {
        return actionProvider.isVisible();
    }

    public override bool IsVisible() {
        return xwQkrBmvJeLZqOck(this.mInner);
    }

    public override void OnActionProviderVisibilityChanged(bool z) {
        androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener = this.mListener;
        if (actionProvider$VisibilityListener is null) {
            return;
        }
        duDuWWzgbIzGRSBh(actionProvider$VisibilityListener, z);
    }

    public override android.view.object OnCreateActionobject(android.view.MenuItem menuItem) {
        return tozoXWlfmKEOQxhH(this.mInner, menuItem);
    }

    public override bool OverridesItemVisibility() {
        return cAIXLCzkAKJZtXcd(this.mInner);
    }

    public override void RefreshVisibility() {
        GHoLxaiXrNejaknj(this.mInner);
    }

    public override void SetVisibilityListener(androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener) {
        this.mListener = actionProvider$VisibilityListener;
        android.view.ActionProvider actionProvider = this.mInner;
        if (actionProvider$VisibilityListener is null) {
            this = null;
        }
        smBkQHMFwDqYLcqa(actionProvider, this);
    }
}

