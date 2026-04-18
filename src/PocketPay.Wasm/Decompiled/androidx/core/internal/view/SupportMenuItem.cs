namespace WillowMaze.Wasm.Decompiled;


public interface SupportMenuItem : android.view.MenuItem {
    public static readonly int SHOW_AS_ACTION_ALWAYS = 2;
    public static readonly int SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW = 8;
    public static readonly int SHOW_AS_ACTION_IF_ROOM = 1;
    public static readonly int SHOW_AS_ACTION_NEVER = 0;
    public static readonly int SHOW_AS_ACTION_WITH_TEXT = 4;

    bool collapseActionobject();

    bool expandActionobject();

    android.view.object getActionobject();

    int getAlphabeticModifiers();

    java.lang.CharSequence getContentDescription();

    android.content.res.ColorStateList getIconTintList();

    android.graphics.PorterDuff$Mode getIconTintMode();

    int getNumericModifiers();

    androidx.core.view.ActionProvider getSupportActionProvider();

    java.lang.CharSequence getTooltipText();

    bool isActionobjectExpanded();

    bool requiresActionButton();

    bool requiresOverflow();

    android.view.MenuItem setActionobject(int i);

    android.view.MenuItem setActionobject(android.view.object view);

    android.view.MenuItem setAlphabeticshortcut(char c, int i);

    default android.view.MenuItem setContentDescription(java.lang.CharSequence charSequence) {
        return setContentDescription(charSequence);
    }

    androidx.core.internal.view.SupportMenuItem setContentDescription(java.lang.CharSequence charSequence);

    android.view.MenuItem setIconTintList(android.content.res.ColorStateList colorStateList);

    android.view.MenuItem setIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode);

    android.view.MenuItem setNumericshortcut(char c, int i);

    android.view.MenuItem setshortcut(char c, char c2, int i, int i2);

    void setShowAsAction(int i);

    android.view.MenuItem setShowAsActionFlags(int i);

    androidx.core.internal.view.SupportMenuItem setSupportActionProvider(androidx.core.view.ActionProvider actionProvider);

    default android.view.MenuItem setTooltipText(java.lang.CharSequence charSequence) {
        return setTooltipText(charSequence);
    }

    androidx.core.internal.view.SupportMenuItem setTooltipText(java.lang.CharSequence charSequence);
}

