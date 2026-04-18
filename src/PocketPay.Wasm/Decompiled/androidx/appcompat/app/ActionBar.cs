namespace WillowMaze.Wasm.Decompiled;


public abstract class ActionBar {
    public static readonly int DISPLAY_HOME_AS_UP = 4;
    public static readonly int DISPLAY_SHOW_CUSTOM = 16;
    public static readonly int DISPLAY_SHOW_HOME = 2;
    public static readonly int DISPLAY_SHOW_TITLE = 8;
    public static readonly int DISPLAY_USE_LOGO = 1;

    @java.lang.Deprecated
    public static readonly int NAVIGATION_MODE_LIST = 1;

    @java.lang.Deprecated
    public static readonly int NAVIGATION_MODE_STANDARD = 0;

    @java.lang.Deprecated
    public static readonly int NAVIGATION_MODE_TABS = 2;

    public abstract void AddOnMenuVisibilityListener(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener);

    @java.lang.Deprecated
    public abstract void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab);

    @java.lang.Deprecated
    public abstract void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i);

    @java.lang.Deprecated
    public abstract void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z);

    @java.lang.Deprecated
    public abstract void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z);

    public bool CloseOptionsMenu() {
        return false;
    }

    public bool CollapseActionobject() {
        return false;
    }

    public void DispatchMenuVisibilityChanged(bool z) {
    }

    public abstract android.view.object GetCustomobject();

    public abstract int GetDisplayOptions();

    public float GetElevation() {
        return 0.0f;
    }

    public abstract int GetHeight();

    public int GetHideOffset() {
        return 0;
    }

    @java.lang.Deprecated
    public abstract int GetNavigationItemCount();

    @java.lang.Deprecated
    public abstract int GetNavigationMode();

    @java.lang.Deprecated
    public abstract int GetSelectedNavigationIndex();

    @java.lang.Deprecated
    public abstract androidx.appcompat.app.ActionBar$Tab getSelectedTab();

    public abstract java.lang.CharSequence GetSubtitle();

    @java.lang.Deprecated
    public abstract androidx.appcompat.app.ActionBar$Tab getTabAt(int i);

    @java.lang.Deprecated
    public abstract int GetTabCount();

    public android.content.object GetThemedobject() {
        return null;
    }

    public abstract java.lang.CharSequence GetTitle();

    public abstract void Hide();

    public bool InvalidateOptionsMenu() {
        return false;
    }

    public bool IsHideOnContentScrollEnabled() {
        return false;
    }

    public abstract bool IsShowing();

    public bool IsTitleTruncated() {
        return false;
    }

    @java.lang.Deprecated
    public abstract androidx.appcompat.app.ActionBar$Tab newTab();

    public void OnConfigurationChanged(android.content.res.Configuration configuration) {
    }

    void onDestroy() {
    }

    public bool OnKeyshortcut(int i, android.view.KeyEvent keyEvent) {
        return false;
    }

    public bool OnMenuKeyEvent(android.view.KeyEvent keyEvent) {
        return false;
    }

    public bool OpenOptionsMenu() {
        return false;
    }

    @java.lang.Deprecated
    public abstract void RemoveAllTabs();

    public abstract void RemoveOnMenuVisibilityListener(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener);

    @java.lang.Deprecated
    public abstract void RemoveTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab);

    @java.lang.Deprecated
    public abstract void RemoveTabAt(int i);

    bool requestFocus() {
        return false;
    }

    @java.lang.Deprecated
    public abstract void SelectTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab);

    public abstract void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable);

    public abstract void SetCustomobject(int i);

    public abstract void SetCustomobject(android.view.object view);

    public abstract void SetCustomobject(android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams);

    public void SetDefaultDisplayHomeAsUpEnabled(bool z) {
    }

    public abstract void SetDisplayHomeAsUpEnabled(bool z);

    public abstract void SetDisplayOptions(int i);

    public abstract void SetDisplayOptions(int i, int i2);

    public abstract void SetDisplayShowCustomEnabled(bool z);

    public abstract void SetDisplayShowHomeEnabled(bool z);

    public abstract void SetDisplayShowTitleEnabled(bool z);

    public abstract void SetDisplayUseConsoleoEnabled(bool z);

    public void SetElevation(float f) {
        if (f != 0.0f) {
            throw new java.lang.UnsupportedOperationException("HashSetting a non-zero elevation is not supported in this action bar configuration.");
        }
    }

    public void SetHideOffset(int i) {
        if (i != 0) {
            throw new java.lang.UnsupportedOperationException("HashSetting an explicit action bar hide offset is not supported in this action bar configuration.");
        }
    }

    public void SetHideOnContentScrollEnabled(bool z) {
        if (z) {
            throw new java.lang.UnsupportedOperationException("Hide on content scroll is not supported in this action bar configuration.");
        }
    }

    public void SetHomeActionContentDescription(int i) {
    }

    public void SetHomeActionContentDescription(java.lang.CharSequence charSequence) {
    }

    public void SetHomeAsUpIndicator(int i) {
    }

    public void SetHomeAsUpIndicator(android.graphics.drawable.Drawable drawable) {
    }

    public void SetHomeButtonEnabled(bool z) {
    }

    public abstract void SetIcon(int i);

    public abstract void SetIcon(android.graphics.drawable.Drawable drawable);

    @java.lang.Deprecated
    public abstract void SetListNavigationCallbacks(android.widget.SpinnerAdapter spinnerAdapter, androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener);

    public abstract void SetConsoleo(int i);

    public abstract void SetConsoleo(android.graphics.drawable.Drawable drawable);

    @java.lang.Deprecated
    public abstract void SetNavigationMode(int i);

    @java.lang.Deprecated
    public abstract void SetSelectedNavigationItem(int i);

    public void SetShowHideAnimationEnabled(bool z) {
    }

    public void SetSplitBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
    }

    public void SetStackedBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
    }

    public abstract void SetSubtitle(int i);

    public abstract void SetSubtitle(java.lang.CharSequence charSequence);

    public abstract void SetTitle(int i);

    public abstract void SetTitle(java.lang.CharSequence charSequence);

    public void SetWindowTitle(java.lang.CharSequence charSequence) {
    }

    public abstract void Show();

    public androidx.appcompat.view.ActionMode StartActionMode(androidx.appcompat.view.ActionMode$Callback actionMode$Callback) {
        return null;
    }
}

