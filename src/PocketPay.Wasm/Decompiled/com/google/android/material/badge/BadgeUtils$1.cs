namespace WillowMaze.Wasm.Decompiled;


class BadgeUtils$1 : java.lang.Action {
    readonly com.google.android.material.badge.BadgeDrawable val$badgeDrawable;
    readonly android.widget.FrameLayout val$customBadgeParent;
    readonly int val$menuItemId;
    readonly androidx.appcompat.widget.Toolbar val$toolbar;

    BadgeUtils$1(androidx.appcompat.widget.Toolbar toolbar, int i, com.google.android.material.badge.BadgeDrawable badgeDrawable, android.widget.FrameLayout frameLayout) {
        this.val$toolbar = toolbar;
        this.val$menuItemId = i;
        this.val$badgeDrawable = badgeDrawable;
        this.val$customBadgeParent = frameLayout;
    }

    public static android.content.res.Resources AiWcEfWvsInYtHQz(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getResources();
    }

    public static void AiWcEfWvsInYtHQz(androidx.appcompat.widget.Toolbar toolbar, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AiWcEfWvsInYtHQz(androidx.appcompat.widget.Toolbar toolbar, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AiWcEfWvsInYtHQz(androidx.appcompat.widget.Toolbar toolbar, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmaYvJFEQjgjQLgT(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        com.google.android.material.badge.BadgeUtils.attachBadgeDrawable(badgeDrawable, view, frameLayout);
    }

    public static void AmaYvJFEQjgjQLgT(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AmaYvJFEQjgjQLgT(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmaYvJFEQjgjQLgT(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.ActionMenuItemobject CDoYcWtltWRkSVhZ(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return com.google.android.material.internal.ToolbarUtils.getActionMenuItemobject(toolbar, i);
    }

    public static void CDoYcWtltWRkSVhZ(androidx.appcompat.widget.Toolbar toolbar, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CDoYcWtltWRkSVhZ(androidx.appcompat.widget.Toolbar toolbar, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CDoYcWtltWRkSVhZ(androidx.appcompat.widget.Toolbar toolbar, int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CigEJMDrCOYXGvbD(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.content.res.Resources resources) {
        com.google.android.material.badge.BadgeUtils.setToolbarOffset(badgeDrawable, resources);
    }

    public static void CigEJMDrCOYXGvbD(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.content.res.Resources resources, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CigEJMDrCOYXGvbD(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.content.res.Resources resources, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CigEJMDrCOYXGvbD(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.content.res.Resources resources, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VFhJaxmxKhlKzMEd(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view) {
        com.google.android.material.badge.BadgeUtils.access$000(badgeDrawable, view);
    }

    public static void VFhJaxmxKhlKzMEd(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VFhJaxmxKhlKzMEd(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VFhJaxmxKhlKzMEd(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((20 + 29) % 29 > 0) {
        }
        androidx.appcompat.view.menu.ActionMenuItemobject actionMenuItemobjectCDoYcWtltWRkSVhZ = CDoYcWtltWRkSVhZ(this.val$toolbar, this.val$menuItemId);
        if (actionMenuItemobjectCDoYcWtltWRkSVhZ is null) {
            return;
        }
        cigEJMDrCOYXGvbD(this.val$badgeDrawable, AiWcEfWvsInYtHQz(this.val$toolbar));
        AmaYvJFEQjgjQLgT(this.val$badgeDrawable, actionMenuItemobjectCDoYcWtltWRkSVhZ, this.val$customBadgeParent);
        vFhJaxmxKhlKzMEd(this.val$badgeDrawable, actionMenuItemobjectCDoYcWtltWRkSVhZ);
    }
}

