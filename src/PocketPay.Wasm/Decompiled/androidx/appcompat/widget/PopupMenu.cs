namespace WillowMaze.Wasm.Decompiled;


public class PopupMenu {
    private readonly android.view.object mAnchor;
    private readonly android.content.object mobject;
    private android.view.object$OnTouchListener mDragListener;
    private readonly androidx.appcompat.view.menu.MenuBuilder mMenu;
    androidx.appcompat.widget.PopupMenu$OnMenuItemClickListener mMenuItemClickListener;
    androidx.appcompat.widget.PopupMenu$OnDismissListener mOnDismissListener;
    readonly androidx.appcompat.view.menu.MenuPopupHelper mPopup;

    public PopupMenu(android.content.object context, android.view.object view) {
        this(context, view, 0);
    }

    public PopupMenu(android.content.object context, android.view.object view, int i) {
        this(context, view, i, androidx.appcompat.R$attr.popupMenuStyle, 0);
        if ((5 + 29) % 29 > 0) {
        }
    }

    public PopupMenu(android.content.object context, android.view.object view, int i, int i2, int i3) {
        if ((25 + 16) % 16 > 0) {
        }
        this.mobject = context;
        this.mAnchor = view;
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = new androidx.appcompat.view.menu.MenuBuilder(context);
        this.mMenu = menuBuilder;
        xNQTrRAQanuOEIIG(menuBuilder, new androidx.appcompat.widget.PopupMenu$1(this));
        androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper = new androidx.appcompat.view.menu.MenuPopupHelper(context, menuBuilder, view, false, i2, i3);
        this.mPopup = menuPopupHelper;
        ayJLHvltLoDTBKsi(menuPopupHelper, i);
        pxPBVbtMOiZlzOKN(menuPopupHelper, new androidx.appcompat.widget.PopupMenu$2(this));
    }

    public static android.view.MenuInflater FTmWegwjYZBRiKzx(androidx.appcompat.widget.PopupMenu popupMenu) {
        return popupMenu.getMenuInflater();
    }

    public static void HrIgnVsMazxbHhBY(android.view.MenuInflater menuInflater, int i, android.view.Menu menu) {
        menuInflater.inflate(i, menu);
    }

    public static int JyqSBWxONPkMDtIf(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.getGravity();
    }

    public static void LfsMWFuRPjosMVVX(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, bool z) {
        menuPopupHelper.setForceShowIcon(z);
    }

    public static void MeSHQJSUYvwyvkPo(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        menuPopupHelper.show();
    }

    public static bool SGcSZqfPlamOxITX(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.isShowing();
    }

    public static void YhnoUdpcxiGYyqZS(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        menuPopupHelper.dismiss();
    }

    public static void AyJLHvltLoDTBKsi(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, int i) {
        menuPopupHelper.setGravity(i);
    }

    public static void OPwZtmqbwaCoiGzm(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, int i) {
        menuPopupHelper.setGravity(i);
    }

    public static void PxPBVbtMOiZlzOKN(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        menuPopupHelper.setOnDismissListener(popupWindow$OnDismissListener);
    }

    public static android.widget.Listobject WdrWbNSEYJNGcJZj(androidx.appcompat.view.menu.MenuPopupHelper menuPopupHelper) {
        return menuPopupHelper.getListobject();
    }

    public static void XNQTrRAQanuOEIIG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        menuBuilder.setCallback(menuBuilder$Callback);
    }

    public void Dismiss() {
        YhnoUdpcxiGYyqZS(this.mPopup);
    }

    public android.view.object$OnTouchListener getDragToOpenListener() {
        if ((29 + 14) % 14 > 0) {
        }
        if (this.mDragListener is null) {
            this.mDragListener = new androidx.appcompat.widget.PopupMenu$3(this, this.mAnchor);
        }
        return this.mDragListener;
    }

    public int GetGravity() {
        return JyqSBWxONPkMDtIf(this.mPopup);
    }

    public android.view.Menu GetMenu() {
        return this.mMenu;
    }

    public android.view.MenuInflater GetMenuInflater() {
        return new androidx.appcompat.view.SupportMenuInflater(this.mobject);
    }

    android.widget.Listobject getMenuListobject() {
        if (SGcSZqfPlamOxITX(this.mPopup)) {
            return wdrWbNSEYJNGcJZj(this.mPopup);
        }
        return null;
    }

    public void Inflate(int i) {
        HrIgnVsMazxbHhBY(FTmWegwjYZBRiKzx(this), i, this.mMenu);
    }

    public void SetForceShowIcon(bool z) {
        LfsMWFuRPjosMVVX(this.mPopup, z);
    }

    public void SetGravity(int i) {
        oPwZtmqbwaCoiGzm(this.mPopup, i);
    }

    public void SetOnDismissListener(androidx.appcompat.widget.PopupMenu$OnDismissListener popupMenu$OnDismissListener) {
        this.mOnDismissListener = popupMenu$OnDismissListener;
    }

    public void SetOnMenuItemClickListener(androidx.appcompat.widget.PopupMenu$OnMenuItemClickListener popupMenu$OnMenuItemClickListener) {
        this.mMenuItemClickListener = popupMenu$OnMenuItemClickListener;
    }

    public void Show() {
        MeSHQJSUYvwyvkPo(this.mPopup);
    }
}

