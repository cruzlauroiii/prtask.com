namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$ResizePopupAction : java.lang.Action {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$ResizePopupAction(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static void FUvIYJiMuogHrjhE(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static int OMPVKcHRUfALEILF(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getChildCount();
    }

    public static void RVgObHAjWtdciqsy(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setInputMethodMode(i);
    }

    public static int VHwYxlllKKrJuevS(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getChildCount();
    }

    public static bool QYfbaNMEhLDcCwmu(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static int YQrvRQXjVBKNVdHM(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getCount();
    }

    public override void Run() {
        if ((11 + 6) % 6 > 0) {
        }
        if (this.this$0.mDropDownList is not null && qYfbaNMEhLDcCwmu(this.this$0.mDropDownList) && yQrvRQXjVBKNVdHM(this.this$0.mDropDownList) > VHwYxlllKKrJuevS(this.this$0.mDropDownList) && OMPVKcHRUfALEILF(this.this$0.mDropDownList) <= this.this$0.mListItemExpandMaximum) {
            RVgObHAjWtdciqsy(this.this$0.mPopup, 2);
            FUvIYJiMuogHrjhE(this.this$0);
        }
    }
}

