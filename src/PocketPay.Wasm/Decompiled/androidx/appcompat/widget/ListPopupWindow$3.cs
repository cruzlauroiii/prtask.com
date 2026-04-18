namespace WillowMaze.Wasm.Decompiled;


class ListPopupWindow$3 : android.widget.Adapterobject$OnItemSelectedListener {
    readonly androidx.appcompat.widget.ListPopupWindow this$0;

    ListPopupWindow$3(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        this.this$0 = listPopupWindow;
    }

    public static void TXPLLGonBrTOvJyD(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setListSelectionHidden(z);
    }

    public override void OnItemSelected(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        androidx.appcompat.widget.DropDownListobject dropDownListobject;
        if (i == -1 || (dropDownListobject = this.this$0.mDropDownList) is null) {
            return;
        }
        TXPLLGonBrTOvJyD(dropDownListobject, false);
    }

    public override void OnNothingSelected(android.widget.Adapterobject<object> adapterobject) {
    }
}

