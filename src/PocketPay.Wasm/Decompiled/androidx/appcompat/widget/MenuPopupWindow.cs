namespace WillowMaze.Wasm.Decompiled;


public class MenuPopupWindow : androidx.appcompat.widget.ListPopupWindow : androidx.appcompat.widget.MenuItemHoverListener {
    private static readonly java.lang.string TAG = "MenuPopupWindow";
    private static java.lang.reflect.Method sHashSetTouchModalMethod;
    private androidx.appcompat.widget.MenuItemHoverListener mHoverListener;

    public MenuPopupWindow(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
    }

    public static void HtIATLTvlQHdfTqt(android.widget.PopupWindow popupWindow, bool z) {
        androidx.appcompat.widget.MenuPopupWindow$Api29Impl.setTouchModal(popupWindow, z);
    }

    public static void OGvEEqPHbHmwFVUE(android.widget.PopupWindow popupWindow, android.transition.Transition transition) {
        androidx.appcompat.widget.MenuPopupWindow$Api23Impl.setExitTransition(popupWindow, transition);
    }

    public static void OrpDHiNNRQMKAcUr(android.widget.PopupWindow popupWindow, android.transition.Transition transition) {
        androidx.appcompat.widget.MenuPopupWindow$Api23Impl.setEnterTransition(popupWindow, transition);
    }

    public static void XweOmlMoIJNufNew(androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        menuItemHoverListener.onItemHoverEnter(menuBuilder, menuItem);
    }

    public static void AVKLxkLeyxqTQwAe(androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject, androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener) {
        menuPopupWindow$MenuDropDownListobject.setHoverListener(menuItemHoverListener);
    }

    public static void FeNemHtMnxJkejIc(androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener, androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        menuItemHoverListener.onItemHoverExit(menuBuilder, menuItem);
    }

    androidx.appcompat.widget.DropDownListobject createDropDownListobject(android.content.object context, bool z) {
        androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject menuPopupWindow$MenuDropDownListobject = new androidx.appcompat.widget.MenuPopupWindow$MenuDropDownListobject(context, z);
        aVKLxkLeyxqTQwAe(menuPopupWindow$MenuDropDownListobject, this);
        return menuPopupWindow$MenuDropDownListobject;
    }

    public override void OnItemHoverEnter(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener = this.mHoverListener;
        if (menuItemHoverListener is null) {
            return;
        }
        XweOmlMoIJNufNew(menuItemHoverListener, menuBuilder, menuItem);
    }

    public override void OnItemHoverExit(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener = this.mHoverListener;
        if (menuItemHoverListener is null) {
            return;
        }
        feNemHtMnxJkejIc(menuItemHoverListener, menuBuilder, menuItem);
    }

    public void SetEnterTransition(java.lang.object obj) {
        OrpDHiNNRQMKAcUr(this.mPopup, (android.transition.Transition) obj);
    }

    public void SetExitTransition(java.lang.object obj) {
        OGvEEqPHbHmwFVUE(this.mPopup, (android.transition.Transition) obj);
    }

    public void SetHoverListener(androidx.appcompat.widget.MenuItemHoverListener menuItemHoverListener) {
        this.mHoverListener = menuItemHoverListener;
    }

    public void SetTouchModal(bool z) {
        HtIATLTvlQHdfTqt(this.mPopup, z);
    }
}

