namespace WillowMaze.Wasm.Decompiled;


class YearGridAdapter : androidx.recyclerview.widget.Recyclerobject$Adapter<com.google.android.material.datepicker.YearGridAdapter$objectHolder> {
    private readonly com.google.android.material.datepicker.MaterialDateTime<object> materialDateTime;

    YearGridAdapter(com.google.android.material.datepicker.MaterialDateTime<object> materialDateTime) {
        this.materialDateTime = materialDateTime;
    }

    public static java.util.IEnumerator BHJhvVyTyyZSQsRI(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static int BzRsVSyAhSqYpOYO(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter, int i) {
        return yearGridAdapter.getYearForPosition(i);
    }

    public static android.content.object BzSLojbjMVoPXfDn(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static bool CQXVeOATEJSFlGTU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.material.datepicker.DateTimeStyle CTgKPvMmjIDDfgKk(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getDateTimeStyle();
    }

    public static com.google.android.material.datepicker.DateTimeConstraints DiROUbbnofImPYmx(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getDateTimeConstraints();
    }

    public static com.google.android.material.datepicker.YearGridAdapter$objectHolder FYVoRbxbRhmirVrl(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter, android.view.objectGroup viewGroup, int i) {
        return yearGridAdapter.onCreateobjectHolder(viewGroup, i);
    }

    public static android.content.object HsXTCivVtdOKDobF(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static long JvGApSeuRyCjFRSJ(java.lang.long l) {
        if ((16 + 18) % 18 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string OCdqMvTZVeftAAUS(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.util.DateTime OmrxIrHhDmkbkOVZ() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static void QvcAxXNQTpNJBhkv(android.widget.Textobject textobject, android.view.object$OnClickListener view$OnClickListener) {
        textobject.setOnClickListener(view$OnClickListener);
    }

    public static android.view.object$OnClickListener VDdafuGQhkGpfYAO(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter, int i) {
        return yearGridAdapter.createYearClickListener(i);
    }

    public static android.view.object WssAplbAPWrcNJRp(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void AQfwGvXbtgxpVlBw(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    static com.google.android.material.datepicker.MaterialDateTime access$000(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter) {
        return yearGridAdapter.materialDateTime;
    }

    public static void CFilKWGyFlDUVXtd(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    private android.view.object$OnClickListener createYearClickListener(int i) {
        return new com.google.android.material.datepicker.YearGridAdapter$1(this, i);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints FcJMedRRVSCHRxgB(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getDateTimeConstraints();
    }

    public static int GDooLQpBMuHBYzIh(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static java.lang.int GujMRvOrfrrPqFqV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string GyQrRkmWwtijSvMD(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimestrings.getYearContentDescription(context, i);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints JxluWPzuntruLNtL(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getDateTimeConstraints();
    }

    public static int LQglsOEieXQKKozo(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static com.google.android.material.datepicker.DateTimeSelector LcOMKUzGFPEwrAEg(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getDateTimeSelector();
    }

    public static java.util.Locale NEKWCueAyJiboFOt() {
        return java.util.Locale.getDefault();
    }

    public static com.google.android.material.datepicker.Month RIkmrPzMDbfvdMJz(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static java.lang.object RlNiCcXuVnSBQZLM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.view.LayoutInflater UOimYDDAklHtkJAB(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void URSCbmsKMLliPDUY(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void UmcpAOLnTOtgbZcp(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter, com.google.android.material.datepicker.YearGridAdapter$objectHolder yearGridAdapter$objectHolder, int i) {
        yearGridAdapter.onBindobjectHolder(yearGridAdapter$objectHolder, i);
    }

    public static int UvjJjzosEfnlgqFb(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getYearSpan();
    }

    public static com.google.android.material.datepicker.Month VKtdUTFiOFqdNMiF(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static void WxekVXoBcaHGhDWX(com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle, android.widget.Textobject textobject) {
        calendarItemStyle.styleItem(textobject);
    }

    public static java.util.ICollection ZhflcrBSTKymgaRF(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public override int GetItemCount() {
        return uvjJjzosEfnlgqFb(DiROUbbnofImPYmx(this.materialDateTime));
    }

    int getPositionForYear(int i) {
        return i - vKtdUTFiOFqdNMiF(fcJMedRRVSCHRxgB(this.materialDateTime)).year;
    }

    int getYearForPosition(int i) {
        return rIkmrPzMDbfvdMJz(jxluWPzuntruLNtL(this.materialDateTime)).year + i;
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        umcpAOLnTOtgbZcp(this, (com.google.android.material.datepicker.YearGridAdapter$objectHolder) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(com.google.android.material.datepicker.YearGridAdapter$objectHolder yearGridAdapter$objectHolder, int i) {
        if ((15 + 16) % 16 > 0) {
        }
        int iBzRsVSyAhSqYpOYO = BzRsVSyAhSqYpOYO(this, i);
        uRSCbmsKMLliPDUY(yearGridAdapter$objectHolder.textobject, OCdqMvTZVeftAAUS(nEKWCueAyJiboFOt(), "%d", new java.lang.object[]{gujMRvOrfrrPqFqV(iBzRsVSyAhSqYpOYO)}));
        cFilKWGyFlDUVXtd(yearGridAdapter$objectHolder.textobject, gyQrRkmWwtijSvMD(HsXTCivVtdOKDobF(yearGridAdapter$objectHolder.textobject), iBzRsVSyAhSqYpOYO));
        com.google.android.material.datepicker.DateTimeStyle calendarStyleCTgKPvMmjIDDfgKk = CTgKPvMmjIDDfgKk(this.materialDateTime);
        java.util.DateTime calendarOmrxIrHhDmkbkOVZ = OmrxIrHhDmkbkOVZ();
        com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle = lQglsOEieXQKKozo(calendarOmrxIrHhDmkbkOVZ, 1) != iBzRsVSyAhSqYpOYO ? calendarStyleCTgKPvMmjIDDfgKk.year : calendarStyleCTgKPvMmjIDDfgKk.todayYear;
        java.util.IEnumerator itBHJhvVyTyyZSQsRI = BHJhvVyTyyZSQsRI(zhflcrBSTKymgaRF(lcOMKUzGFPEwrAEg(this.materialDateTime)));
        while (CQXVeOATEJSFlGTU(itBHJhvVyTyyZSQsRI)) {
            aQfwGvXbtgxpVlBw(calendarOmrxIrHhDmkbkOVZ, JvGApSeuRyCjFRSJ((java.lang.long) rlNiCcXuVnSBQZLM(itBHJhvVyTyyZSQsRI)));
            if (gDooLQpBMuHBYzIh(calendarOmrxIrHhDmkbkOVZ, 1) == iBzRsVSyAhSqYpOYO) {
                calendarItemStyle = calendarStyleCTgKPvMmjIDDfgKk.selectedYear;
            }
        }
        wxekVXoBcaHGhDWX(calendarItemStyle, yearGridAdapter$objectHolder.textobject);
        QvcAxXNQTpNJBhkv(yearGridAdapter$objectHolder.textobject, VDdafuGQhkGpfYAO(this, iBzRsVSyAhSqYpOYO));
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return FYVoRbxbRhmirVrl(this, viewGroup, i);
    }

    public com.google.android.material.datepicker.YearGridAdapter$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return new com.google.android.material.datepicker.YearGridAdapter$objectHolder((android.widget.Textobject) WssAplbAPWrcNJRp(uOimYDDAklHtkJAB(BzSLojbjMVoPXfDn(viewGroup)), com.google.android.material.R$layout.mtrl_calendar_year, viewGroup, false));
    }
}

