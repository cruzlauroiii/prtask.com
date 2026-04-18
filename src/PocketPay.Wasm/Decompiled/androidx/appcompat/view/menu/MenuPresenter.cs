namespace WillowMaze.Wasm.Decompiled;


public interface MenuPresenter {
    bool collapseItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl);

    bool expandItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl);

    bool flagActionItems();

    int getId();

    androidx.appcompat.view.menu.Menuobject getMenuobject(android.view.objectGroup viewGroup);

    void initForMenu(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder);

    void onCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z);

    void onRestoreInstanceState(android.os.Parcelable parcelable);

    android.os.Parcelable onSaveInstanceState();

    bool onSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder);

    void setCallback(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback);

    void updateMenuobject(bool z);
}

