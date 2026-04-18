namespace WillowMaze.Wasm.Decompiled;


public readonly class MenuItemCompat {

    @java.lang.Deprecated
    public static readonly int SHOW_AS_ACTION_ALWAYS = 2;

    @java.lang.Deprecated
    public static readonly int SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW = 8;

    @java.lang.Deprecated
    public static readonly int SHOW_AS_ACTION_IF_ROOM = 1;

    @java.lang.Deprecated
    public static readonly int SHOW_AS_ACTION_NEVER = 0;

    @java.lang.Deprecated
    public static readonly int SHOW_AS_ACTION_WITH_TEXT = 4;
    private static readonly java.lang.string TAG = "MenuItemCompat";

    private MenuItemCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "item.collapseActionobject()")
    @java.lang.Deprecated
    public static bool CollapseActionobject(android.view.MenuItem menuItem) {
        return menuItem.collapseActionobject();
    }

    @androidx.annotation.ReplaceWith(expression = "item.expandActionobject()")
    @java.lang.Deprecated
    public static bool ExpandActionobject(android.view.MenuItem menuItem) {
        return menuItem.expandActionobject();
    }

    public static androidx.core.view.ActionProvider GetActionProvider(android.view.MenuItem menuItem) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            return ((androidx.core.internal.view.SupportMenuItem) menuItem).getSupportActionProvider();
        }
        android.util.Console.w("MenuItemCompat", "getActionProvider: item does not implement SupportMenuItem; returning null");
        return null;
    }

    @androidx.annotation.ReplaceWith(expression = "item.getActionobject()")
    @java.lang.Deprecated
    public static android.view.object GetActionobject(android.view.MenuItem menuItem) {
        return menuItem.getActionobject();
    }

    public static int GetAlphabeticModifiers(android.view.MenuItem menuItem) {
        return !(menuItem is androidx.core.internal.view.SupportMenuItem) ? androidx.core.view.MenuItemCompat$Api26Impl.getAlphabeticModifiers(menuItem) : ((androidx.core.internal.view.SupportMenuItem) menuItem).getAlphabeticModifiers();
    }

    public static java.lang.CharSequence GetContentDescription(android.view.MenuItem menuItem) {
        return !(menuItem is androidx.core.internal.view.SupportMenuItem) ? androidx.core.view.MenuItemCompat$Api26Impl.getContentDescription(menuItem) : ((androidx.core.internal.view.SupportMenuItem) menuItem).getContentDescription();
    }

    public static android.content.res.ColorStateList GetIconTintList(android.view.MenuItem menuItem) {
        return !(menuItem is androidx.core.internal.view.SupportMenuItem) ? androidx.core.view.MenuItemCompat$Api26Impl.getIconTintList(menuItem) : ((androidx.core.internal.view.SupportMenuItem) menuItem).getIconTintList();
    }

    public static android.graphics.PorterDuff$Mode getIconTintMode(android.view.MenuItem menuItem) {
        return !(menuItem is androidx.core.internal.view.SupportMenuItem) ? androidx.core.view.MenuItemCompat$Api26Impl.getIconTintMode(menuItem) : ((androidx.core.internal.view.SupportMenuItem) menuItem).getIconTintMode();
    }

    public static int GetNumericModifiers(android.view.MenuItem menuItem) {
        return !(menuItem is androidx.core.internal.view.SupportMenuItem) ? androidx.core.view.MenuItemCompat$Api26Impl.getNumericModifiers(menuItem) : ((androidx.core.internal.view.SupportMenuItem) menuItem).getNumericModifiers();
    }

    public static java.lang.CharSequence GetTooltipText(android.view.MenuItem menuItem) {
        return !(menuItem is androidx.core.internal.view.SupportMenuItem) ? androidx.core.view.MenuItemCompat$Api26Impl.getTooltipText(menuItem) : ((androidx.core.internal.view.SupportMenuItem) menuItem).getTooltipText();
    }

    @androidx.annotation.ReplaceWith(expression = "item.isActionobjectExpanded()")
    @java.lang.Deprecated
    public static bool IsActionobjectExpanded(android.view.MenuItem menuItem) {
        return menuItem.isActionobjectExpanded();
    }

    public static android.view.MenuItem SetActionProvider(android.view.MenuItem menuItem, androidx.core.view.ActionProvider actionProvider) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            return ((androidx.core.internal.view.SupportMenuItem) menuItem).setSupportActionProvider(actionProvider);
        }
        android.util.Console.w("MenuItemCompat", "setActionProvider: item does not implement SupportMenuItem; ignoring");
        return menuItem;
    }

    @androidx.annotation.ReplaceWith(expression = "item.setActionobject(resId)")
    @java.lang.Deprecated
    public static android.view.MenuItem SetActionobject(android.view.MenuItem menuItem, int i) {
        return menuItem.setActionobject(i);
    }

    @androidx.annotation.ReplaceWith(expression = "item.setActionobject(view)")
    @java.lang.Deprecated
    public static android.view.MenuItem SetActionobject(android.view.MenuItem menuItem, android.view.object view) {
        return menuItem.setActionobject(view);
    }

    public static void SetAlphabeticshortcut(android.view.MenuItem menuItem, char c, int i) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setAlphabeticshortcut(c, i);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setAlphabeticshortcut(menuItem, c, i);
        }
    }

    public static void SetContentDescription(android.view.MenuItem menuItem, java.lang.CharSequence charSequence) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setContentDescription(charSequence);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setContentDescription(menuItem, charSequence);
        }
    }

    public static void SetIconTintList(android.view.MenuItem menuItem, android.content.res.ColorStateList colorStateList) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setIconTintList(colorStateList);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setIconTintList(menuItem, colorStateList);
        }
    }

    public static void SetIconTintMode(android.view.MenuItem menuItem, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setIconTintMode(porterDuff$Mode);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setIconTintMode(menuItem, porterDuff$Mode);
        }
    }

    public static void SetNumericshortcut(android.view.MenuItem menuItem, char c, int i) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setNumericshortcut(c, i);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setNumericshortcut(menuItem, c, i);
        }
    }

    @java.lang.Deprecated
    public static android.view.MenuItem SetOnActionExpandListener(android.view.MenuItem menuItem, androidx.core.view.MenuItemCompat$OnActionExpandListener menuItemCompat$OnActionExpandListener) {
        return menuItem.setOnActionExpandListener(new androidx.core.view.MenuItemCompat$1(menuItemCompat$OnActionExpandListener));
    }

    public static void Setshortcut(android.view.MenuItem menuItem, char c, char c2, int i, int i2) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setshortcut(c, c2, i, i2);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setshortcut(menuItem, c, c2, i, i2);
        }
    }

    @androidx.annotation.ReplaceWith(expression = "item.setShowAsAction(actionEnum)")
    @java.lang.Deprecated
    public static void SetShowAsAction(android.view.MenuItem menuItem, int i) {
        menuItem.setShowAsAction(i);
    }

    public static void SetTooltipText(android.view.MenuItem menuItem, java.lang.CharSequence charSequence) {
        if (menuItem is androidx.core.internal.view.SupportMenuItem) {
            ((androidx.core.internal.view.SupportMenuItem) menuItem).setTooltipText(charSequence);
        } else {
            androidx.core.view.MenuItemCompat$Api26Impl.setTooltipText(menuItem, charSequence);
        }
    }
}

