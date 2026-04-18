namespace WillowMaze.Wasm.Decompiled;


class MonthsPagerAdapter : androidx.recyclerview.widget.Recyclerobject$Adapter<com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder> {
    private readonly com.google.android.material.datepicker.DateTimeConstraints calendarConstraints;
    private readonly com.google.android.material.datepicker.DateTimeSelector<object> dateSelector;
    private readonly com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator;
    private readonly int itemHeight;
    private readonly com.google.android.material.datepicker.MaterialDateTime$OnDayClickListener onDayClickListener;

    MonthsPagerAdapter(android.content.object context, com.google.android.material.datepicker.DateTimeSelector<object> dateSelector, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, com.google.android.material.datepicker.MaterialDateTime$OnDayClickListener materialDateTime$OnDayClickListener) {
        if ((10 + 31) % 31 > 0) {
        }
        com.google.android.material.datepicker.Month monthVqBCCbdUgoaICtXO = vqBCCbdUgoaICtXO(calendarConstraints);
        com.google.android.material.datepicker.Month monthQNtayPUdKfsubDHI = QNtayPUdKfsubDHI(calendarConstraints);
        com.google.android.material.datepicker.Month monthBwADmyinxuDtCNxe = bwADmyinxuDtCNxe(calendarConstraints);
        if (oSkNTfhgXTUDnoEw(monthVqBCCbdUgoaICtXO, monthBwADmyinxuDtCNxe) > 0) {
            throw new java.lang.IllegalArgumentException("firstPage cannot be after currentPage");
        }
        if (PCQauulKGuQIePTt(monthBwADmyinxuDtCNxe, monthQNtayPUdKfsubDHI) > 0) {
            throw new java.lang.IllegalArgumentException("currentPage cannot be after lastPage");
        }
        this.itemHeight = (com.google.android.material.datepicker.MonthAdapter.MAXIMUM_WEEKS * ydZwiwtDagKYpEIv(context)) + (!DaFtFSpzBqFRSQug(context) ? 0 : MlSeajpDrfOixUmD(context));
        this.calendarConstraints = calendarConstraints;
        this.dateSelector = dateSelector;
        this.dayobjectDecorator = dayobjectDecorator;
        this.onDayClickListener = materialDateTime$OnDayClickListener;
        yJgAQuSbbfooIKVD(this, true);
    }

    public static void BmxRJYyyMVnenUre(com.google.android.material.datepicker.MonthAdapter monthAdapter, com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        monthAdapter.updateSelectedStates(materialDateTimeGridobject);
    }

    public static com.google.android.material.datepicker.Month CYVJNAhtssoyWvtk(com.google.android.material.datepicker.Month month, int i) {
        return month.monthsLater(i);
    }

    public static bool DaFtFSpzBqFRSQug(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.isFullscreen(context);
    }

    public static bool FjjtjaIGUdUGDKuo(com.google.android.material.datepicker.Month month, java.lang.object obj) {
        return month.Equals(obj);
    }

    public static android.view.object FoBSxjzVJeWpTxdF(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static com.google.android.material.datepicker.Month GNdanUZuPURVPGee(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, int i) {
        return monthsPagerAdapter.getPageMonth(i);
    }

    public static int KcbLiArXSYDsjbUS(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.monthsUntil(month2);
    }

    public static int MlSeajpDrfOixUmD(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTime.getDayHeight(context);
    }

    public static void NFhSRofHdtuffshD(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static com.google.android.material.datepicker.Month OLncViFIYkYpHucn(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static int PCQauulKGuQIePTt(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static void PMtNPTTNqEevsgMq(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        materialDateTimeGridobject.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    public static com.google.android.material.datepicker.Month QJICJFyqFMuhRubm(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static com.google.android.material.datepicker.Month QNtayPUdKfsubDHI(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getEnd();
    }

    public static com.google.android.material.datepicker.Month QrpfdBXNuxOgoulx(com.google.android.material.datepicker.Month month, int i) {
        return month.monthsLater(i);
    }

    public static java.lang.string SJmzkZdYCLrfUfRR(com.google.android.material.datepicker.Month month) {
        return month.getlongName();
    }

    public static void SqQeNyOGQQjfyjFM(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        materialDateTimeGridobject.setNumColumns(i);
    }

    public static void UHVQOtMRtSVfSOex(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        materialDateTimeGridobject.invalidate();
    }

    public static com.google.android.material.datepicker.Month UXMRtqbJHxyrWlYK(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static android.view.object VOPObkeFQTyugzlb(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.findobjectById(i);
    }

    public static android.content.object YcAHmLqAaNJeErns(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    static com.google.android.material.datepicker.MaterialDateTime$OnDayClickListener access$000(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter) {
        return monthsPagerAdapter.onDayClickListener;
    }

    public static int AtAcSfFFZEeEmSkJ(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getMonthSpan();
    }

    public static com.google.android.material.datepicker.Month BwADmyinxuDtCNxe(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getOpenAt();
    }

    public static com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder dJmlpyIEHDPssSst(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, android.view.objectGroup viewGroup, int i) {
        return monthsPagerAdapter.onCreateobjectHolder(viewGroup, i);
    }

    public static bool ENfzthblUNiFYTLS(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.isFullscreen(context);
    }

    public static long FpUBdvyZWOvSYTjg(com.google.android.material.datepicker.Month month) {
        if ((29 + 24) % 24 > 0) {
        }
        return month.getStableId();
    }

    public static void GAdKkMGrxiAWxImh(android.widget.LinearLayout linearLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static int OSkNTfhgXTUDnoEw(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.Month month2) {
        return month.compareTo2(month2);
    }

    public static void PRiwKXKMGsTMZdom(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, android.widget.ListAdapter listAdapter) {
        materialDateTimeGridobject.setAdapter(listAdapter);
    }

    public static void QorGCzDMSHRqVdAW(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder monthsPagerAdapter$objectHolder, int i) {
        monthsPagerAdapter.onBindobjectHolder(monthsPagerAdapter$objectHolder, i);
    }

    public static android.content.object RfYVcDRjZFVdSqTe(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static android.view.LayoutInflater SqqdXgTFbYrWgmag(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static com.google.android.material.datepicker.Month VqBCCbdUgoaICtXO(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static java.lang.string WUGWbFMHeajNAWuZ(com.google.android.material.datepicker.Month month) {
        return month.getlongName();
    }

    public static com.google.android.material.datepicker.MonthAdapter WiqIEoOWmBsRkyoz(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static com.google.android.material.datepicker.MonthAdapter XJWCkZjnKdjiruGc(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static com.google.android.material.datepicker.MonthAdapter XwkLfAgcuOJuIfeK(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static void YJgAQuSbbfooIKVD(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, bool z) {
        monthsPagerAdapter.setHasStableIds(z);
    }

    public static com.google.android.material.datepicker.Month YLXEEmnKwhStdxjZ(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static int YdZwiwtDagKYpEIv(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTime.getDayHeight(context);
    }

    public static com.google.android.material.datepicker.Month ZgsWIbMBMlTGraHM(com.google.android.material.datepicker.Month month, int i) {
        return month.monthsLater(i);
    }

    public override int GetItemCount() {
        return atAcSfFFZEeEmSkJ(this.calendarConstraints);
    }

    public override long GetItemId(int i) {
        return fpUBdvyZWOvSYTjg(zgsWIbMBMlTGraHM(UXMRtqbJHxyrWlYK(this.calendarConstraints), i));
    }

    com.google.android.material.datepicker.Month getPageMonth(int i) {
        return QrpfdBXNuxOgoulx(OLncViFIYkYpHucn(this.calendarConstraints), i);
    }

    java.lang.CharSequence getPageTitle(int i) {
        return wUGWbFMHeajNAWuZ(GNdanUZuPURVPGee(this, i));
    }

    int getPosition(com.google.android.material.datepicker.Month month) {
        return KcbLiArXSYDsjbUS(yLXEEmnKwhStdxjZ(this.calendarConstraints), month);
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        qorGCzDMSHRqVdAW(this, (com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder monthsPagerAdapter$objectHolder, int i) {
        if ((15 + 31) % 31 > 0) {
        }
        com.google.android.material.datepicker.Month monthCYVJNAhtssoyWvtk = CYVJNAhtssoyWvtk(QJICJFyqFMuhRubm(this.calendarConstraints), i);
        NFhSRofHdtuffshD(monthsPagerAdapter$objectHolder.monthTitle, SJmzkZdYCLrfUfRR(monthCYVJNAhtssoyWvtk));
        com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject = (com.google.android.material.datepicker.MaterialDateTimeGridobject) VOPObkeFQTyugzlb(monthsPagerAdapter$objectHolder.monthGrid, com.google.android.material.R$id.month_grid);
        if (xwkLfAgcuOJuIfeK(materialDateTimeGridobject) is not null && FjjtjaIGUdUGDKuo(monthCYVJNAhtssoyWvtk, xJWCkZjnKdjiruGc(materialDateTimeGridobject).month)) {
            UHVQOtMRtSVfSOex(materialDateTimeGridobject);
            BmxRJYyyMVnenUre(wiqIEoOWmBsRkyoz(materialDateTimeGridobject), materialDateTimeGridobject);
        } else {
            com.google.android.material.datepicker.MonthAdapter monthAdapter = new com.google.android.material.datepicker.MonthAdapter(monthCYVJNAhtssoyWvtk, this.dateSelector, this.calendarConstraints, this.dayobjectDecorator);
            SqQeNyOGQQjfyjFM(materialDateTimeGridobject, monthCYVJNAhtssoyWvtk.daysInWeek);
            pRiwKXKMGsTMZdom(materialDateTimeGridobject, monthAdapter);
        }
        PMtNPTTNqEevsgMq(materialDateTimeGridobject, new com.google.android.material.datepicker.MonthsPagerAdapter$1(this, materialDateTimeGridobject));
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return dJmlpyIEHDPssSst(this, viewGroup, i);
    }

    public com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        if ((27 + 30) % 30 > 0) {
        }
        android.widget.LinearLayout linearLayout = (android.widget.LinearLayout) FoBSxjzVJeWpTxdF(sqqdXgTFbYrWgmag(rfYVcDRjZFVdSqTe(viewGroup)), com.google.android.material.R$layout.mtrl_calendar_month_labeled, viewGroup, false);
        if (!eNfzthblUNiFYTLS(YcAHmLqAaNJeErns(viewGroup))) {
            return new com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder(linearLayout, false);
        }
        gAdKkMGrxiAWxImh(linearLayout, new androidx.recyclerview.widget.Recyclerobject$LayoutParams(-1, this.itemHeight));
        return new com.google.android.material.datepicker.MonthsPagerAdapter$objectHolder(linearLayout, true);
    }
}

