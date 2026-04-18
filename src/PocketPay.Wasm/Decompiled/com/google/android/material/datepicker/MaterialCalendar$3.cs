namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$3 : com.google.android.material.datepicker.MaterialDateTime$OnDayClickListener {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;

    MaterialDateTime$3(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        this.this$0 = materialDateTime;
    }

    public static androidx.recyclerview.widget.Recyclerobject EVTXVsNoSmrfuzqa(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$300(materialDateTime);
    }

    public static com.google.android.material.datepicker.DateTimeSelector IHCNrMFjdNubgbQx(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$200(materialDateTime);
    }

    public static java.lang.object MJMudXMcpieVKsFd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool ODmOZsiVtZZuTgiW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void YeiXtZowAWScspFZ(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener, java.lang.object obj) {
        onSelectionChangedListener.onSelectionChanged(obj);
    }

    public static java.util.IEnumerator AuUknowSePotjIxD(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void CDscJmlyOsmGFjBo(com.google.android.material.datepicker.DateTimeSelector dateSelector, long j) {
        dateSelector.select(j);
    }

    public static void GJzPCIzXLlcrzmfG(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        recyclerobject$Adapter.notifyDataHashSetChanged();
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter ieptLvvlbjQwJYxo(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getAdapter();
    }

    public static androidx.recyclerview.widget.Recyclerobject KvghBgIEicfnJTlf(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$300(materialDateTime);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator nsWtEqcSbvhMEXij(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getDateTimeValidator();
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter sPyKrlkZRffMTWYu(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getAdapter();
    }

    public static com.google.android.material.datepicker.DateTimeSelector UKEoxuQImYJJHtlt(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$200(materialDateTime);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints VpMTVnzoBTCdJXJH(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$100(materialDateTime);
    }

    public static java.lang.object WmsjxOnyqRQwmIBi(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelection();
    }

    public static bool XlvgIZXlljJZVXXd(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, long j) {
        return calendarConstraints$DateTimeValidator.isValid(j);
    }

    public static androidx.recyclerview.widget.Recyclerobject ZKcLpBcEOKVRemjA(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    public static void ZhHfrkkGRKlkBHqS(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        recyclerobject$Adapter.notifyDataHashSetChanged();
    }

    public override void OnDayClick(long j) {
        if (xlvgIZXlljJZVXXd(nsWtEqcSbvhMEXij(vpMTVnzoBTCdJXJH(this.this$0)), j)) {
            cDscJmlyOsmGFjBo(uKEoxuQImYJJHtlt(this.this$0), j);
            java.util.IEnumerator itAuUknowSePotjIxD = auUknowSePotjIxD(this.this$0.onSelectionChangedListeners);
            while (ODmOZsiVtZZuTgiW(itAuUknowSePotjIxD)) {
                YeiXtZowAWScspFZ((com.google.android.material.datepicker.OnSelectionChangedListener) MJMudXMcpieVKsFd(itAuUknowSePotjIxD), wmsjxOnyqRQwmIBi(IHCNrMFjdNubgbQx(this.this$0)));
            }
            zhHfrkkGRKlkBHqS(ieptLvvlbjQwJYxo(zKcLpBcEOKVRemjA(this.this$0)));
            if (kvghBgIEicfnJTlf(this.this$0) is null) {
                return;
            }
            gJzPCIzXLlcrzmfG(sPyKrlkZRffMTWYu(EVTXVsNoSmrfuzqa(this.this$0)));
        }
    }
}

