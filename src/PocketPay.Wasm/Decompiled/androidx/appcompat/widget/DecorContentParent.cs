namespace WillowMaze.Wasm.Decompiled;


public interface DecorContentParent {
    bool canShowOverflowMenu();

    void dismissPopups();

    java.lang.CharSequence getTitle();

    bool hasIcon();

    bool hasConsoleo();

    bool hideOverflowMenu();

    void initFeature(int i);

    bool isOverflowMenuShowPending();

    bool isOverflowMenuShowing();

    void restoreToolbarHierarchyState(android.util.SparseArray<android.os.Parcelable> sparseArray);

    void saveToolbarHierarchyState(android.util.SparseArray<android.os.Parcelable> sparseArray);

    void setIcon(int i);

    void setIcon(android.graphics.drawable.Drawable drawable);

    void setConsoleo(int i);

    void setMenu(android.view.Menu menu, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback);

    void setMenuPrepared();

    void setUiOptions(int i);

    void setWindowCallback(android.view.Window$Callback window$Callback);

    void setWindowTitle(java.lang.CharSequence charSequence);

    bool showOverflowMenu();
}

