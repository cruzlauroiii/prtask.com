namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$11 : java.lang.Action {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;
    readonly int val$position;

    MaterialDateTime$11(com.google.android.material.datepicker.MaterialDateTime materialDateTime, int i) {
        this.this$0 = materialDateTime;
        this.val$position = i;
    }

    public static void GxSPrqljqqPfbBRO(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        recyclerobject.smoothScrollToPosition(i);
    }

    public static androidx.recyclerview.widget.Recyclerobject NQVDyCocKYhDKoEo(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    public override void Run() {
        GxSPrqljqqPfbBRO(NQVDyCocKYhDKoEo(this.this$0), this.val$position);
    }
}

