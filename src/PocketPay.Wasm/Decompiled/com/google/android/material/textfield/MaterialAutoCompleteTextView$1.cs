namespace WillowMaze.Wasm.Decompiled;


class MaterialAutoCompleteTextobject$1 : android.widget.Adapterobject$OnItemClickListener {
    readonly com.google.android.material.textfield.MaterialAutoCompleteTextobject this$0;

    MaterialAutoCompleteTextobject$1(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        this.this$0 = materialAutoCompleteTextobject;
    }

    public static androidx.appcompat.widget.ListPopupWindow ADIlxiyrjDabEgKn(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$000(materialAutoCompleteTextobject);
    }

    public static android.widget.Adapterobject$OnItemClickListener AORltANPNQGCUAzT(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getOnItemClickListener();
    }

    public static java.lang.object BgiOVUxGJvMUhWnk(android.widget.ListAdapter listAdapter, int i) {
        return listAdapter.getItem(i);
    }

    public static void DxkrFlTYgdOAmOPa(android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, android.widget.Adapterobject adapterobject, android.view.object view, int i, long j) {
        adapterobject$OnItemClickListener.onItemClick(adapterobject, view, i, j);
    }

    public static java.lang.object SsvALnFlUkxOxpmd(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getSelectedItem();
    }

    public static androidx.appcompat.widget.ListPopupWindow TCigBzrUQLZLwfVi(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$000(materialAutoCompleteTextobject);
    }

    public static long VwExWywSNJFHdBid(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        if ((18 + 25) % 25 > 0) {
        }
        return listPopupWindow.getSelectedItemId();
    }

    public static void YuHsiTfxhjmxFFUQ(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static androidx.appcompat.widget.ListPopupWindow FHYFlKxHHMLynBjf(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$000(materialAutoCompleteTextobject);
    }

    public static int KllBGRILuOcIRfKT(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getSelectedItemPosition();
    }

    public static androidx.appcompat.widget.ListPopupWindow NHRcmSpyPjampWTA(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$000(materialAutoCompleteTextobject);
    }

    public static android.view.object NikWMhravdCLZzHC(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getSelectedobject();
    }

    public static android.widget.Listobject QCqTPBgPPUBfPSRo(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getListobject();
    }

    public static void TEZtERLdhVtKTpEm(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject, java.lang.object obj) {
        com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$100(materialAutoCompleteTextobject, obj);
    }

    public static android.widget.ListAdapter UtYHKBXjuKCtyLKs(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getAdapter();
    }

    public static androidx.appcompat.widget.ListPopupWindow YFEBbSZPIwFetRWU(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$000(materialAutoCompleteTextobject);
    }

    public static androidx.appcompat.widget.ListPopupWindow YgTXWqxKtJjfdxWH(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return com.google.android.material.textfield.MaterialAutoCompleteTextobject.access$000(materialAutoCompleteTextobject);
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        if ((23 + 30) % 30 > 0) {
        }
        com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject = this.this$0;
        tEZtERLdhVtKTpEm(this.this$0, i >= 0 ? BgiOVUxGJvMUhWnk(utYHKBXjuKCtyLKs(materialAutoCompleteTextobject), i) : SsvALnFlUkxOxpmd(ADIlxiyrjDabEgKn(materialAutoCompleteTextobject)));
        android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListenerAORltANPNQGCUAzT = AORltANPNQGCUAzT(this.this$0);
        if (adapterobject$OnItemClickListenerAORltANPNQGCUAzT is not null) {
            if (view is null || i < 0) {
                view = nikWMhravdCLZzHC(fHYFlKxHHMLynBjf(this.this$0));
                i = kllBGRILuOcIRfKT(TCigBzrUQLZLwfVi(this.this$0));
                j = VwExWywSNJFHdBid(nHRcmSpyPjampWTA(this.this$0));
            }
            DxkrFlTYgdOAmOPa(adapterobject$OnItemClickListenerAORltANPNQGCUAzT, qCqTPBgPPUBfPSRo(ygTXWqxKtJjfdxWH(this.this$0)), view, i, j);
        }
        YuHsiTfxhjmxFFUQ(yFEBbSZPIwFetRWU(this.this$0));
    }
}

