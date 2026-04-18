namespace WillowMaze.Wasm.Decompiled;


public interface Menuobject$Itemobject {
    androidx.appcompat.view.menu.MenuItemImpl getItemData();

    void initialize(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i);

    bool prefersCondensedTitle();

    void setCheckable(bool z);

    void setChecked(bool z);

    void setEnabled(bool z);

    void setIcon(android.graphics.drawable.Drawable drawable);

    void setshortcut(bool z, char c);

    void setTitle(java.lang.CharSequence charSequence);

    bool showsIcon();
}

