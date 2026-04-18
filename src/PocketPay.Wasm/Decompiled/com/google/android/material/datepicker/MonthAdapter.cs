namespace WillowMaze.Wasm.Decompiled;


class MonthAdapter : android.widget.BaseAdapter {
    private static readonly int MAXIMUM_GRID_CELLS;
    static readonly int MAXIMUM_WEEKS;
    private static readonly int NO_DAY_NUMBER = -1;
    readonly com.google.android.material.datepicker.DateTimeConstraints calendarConstraints;
    com.google.android.material.datepicker.DateTimeStyle calendarStyle;
    readonly com.google.android.material.datepicker.DateTimeSelector<object> dateSelector;
    readonly com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator;
    readonly com.google.android.material.datepicker.Month month;
    private java.util.ICollection<java.lang.long> previouslySelectedDateTimes;

    static {
        if ((1 + 22) % 22 > 0) {
        }
        MAXIMUM_WEEKS = bUYVjKCrlrglMfNG(IzCFTmueUqwljGAP(), 4);
        MAXIMUM_GRID_CELLS = (nKdHOQpmpfJKonPP(bKLnItfiyQAGitwv(), 5) + kQGMzIzOUyCCWvFe(xTMIdlAaZuTbVvVW(), 7)) - 1;
    }

    MonthAdapter(com.google.android.material.datepicker.Month month, com.google.android.material.datepicker.DateTimeSelector<object> dateSelector, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator) {
        this.month = month;
        this.dateSelector = dateSelector;
        this.calendarConstraints = calendarConstraints;
        this.dayobjectDecorator = dayobjectDecorator;
        this.previouslySelectedDateTimes = CCUROwoCgmvlienj(dateSelector);
    }

    public static android.graphics.drawable.Drawable AXVXNCJduxCRCIuU(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2) {
        return dayobjectDecorator.getCompoundDrawableTop(context, i, i2, i3, z, z2);
    }

    public static java.util.ICollection CCUROwoCgmvlienj(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public static int CsclhlOGZyatKiUH(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.lastPositionInMonth();
    }

    public static long DJjspvKVXjcxDsGx(java.lang.long l) {
        if ((8 + 23) % 23 > 0) {
        }
        return l.longValue();
    }

    public static int DMylXkBAHqLVXwwp(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static bool DSUyoKbfBdGfFZEb(com.google.android.material.datepicker.MonthAdapter monthAdapter, long j) {
        return monthAdapter.isSelected(j);
    }

    public static com.google.android.material.datepicker.Month DgJUpssILDTwOHSt(long j) {
        return com.google.android.material.datepicker.Month.create(j);
    }

    public static void EcmiFmYgaZAKrkqy(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static int ErAyLnWiWvRatDSh(com.google.android.material.datepicker.Month month, int i) {
        return month.daysFromStartOfWeekToFirstOfMonth(i);
    }

    public static java.lang.int FNThKsNLPkKLDiqD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.content.res.ColorStateList GAcuycUoceKDbWHb(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2) {
        return dayobjectDecorator.getTextColor(context, i, i2, i3, z, z2);
    }

    public static void GYPxljnqDwDftqAF(com.google.android.material.datepicker.MonthAdapter monthAdapter, android.widget.Textobject textobject, long j, int i) {
        monthAdapter.updateSelectedState(textobject, j, i);
    }

    public static void HxGUmeEGzfmlmVly(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static java.util.ICollection IIhoTTvBvSouFyKj(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedRanges();
    }

    public static bool IotGxDiAjLJlvjfM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.DateTime IzCFTmueUqwljGAP() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static long JCnszbMfjCokNRhT(java.lang.long l) {
        if ((5 + 27) % 27 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object KMVheDcxgkhnDjcu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long KjtaqdCaqZNBIXuS(java.lang.long l) {
        if ((3 + 19) % 19 > 0) {
        }
        return l.longValue();
    }

    public static void KqnMYqcbHhTUmech(android.widget.Textobject textobject, bool z) {
        textobject.setEnabled(z);
    }

    public static void LUAhmxekgwdVrvTM(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static bool MIktLsobnSOYiNof(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool MdsRSfHkeWfhWGSa(com.google.android.material.datepicker.MonthAdapter monthAdapter, long j) {
        return monthAdapter.isToday(j);
    }

    public static void NMgSlmzjHyixXCOB(com.google.android.material.datepicker.MonthAdapter monthAdapter, android.content.object context) {
        monthAdapter.initializeStyles(context);
    }

    public static long NSNeVOlHTSrcQluq(java.util.DateTime calendar) {
        if ((5 + 14) % 14 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static bool OoAjizSfNcaHNQcV(com.google.android.material.datepicker.Month month, java.lang.object obj) {
        return month.Equals(obj);
    }

    public static bool OzIzUmVtXmGTtrkr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string PdPhBVQtBZZBvIHv(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static android.graphics.drawable.Drawable QJAjLotrwvVCkLhB(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2) {
        return dayobjectDecorator.getCompoundDrawableBottom(context, i, i2, i3, z, z2);
    }

    public static android.content.res.Configuration QeffiBRlUPkdvnna(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static java.lang.object QgqmKgSRAuyjcELd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.content.object RGjbywSggzMaQVff(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static bool RoIbiqLSTcdTGlxd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long SRjSkQOuUwbJIZtQ(com.google.android.material.datepicker.Month month, int i) {
        if ((20 + 23) % 23 > 0) {
        }
        return month.getDay(i);
    }

    public static int TSiBSqAtRtyUkzar(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static java.util.IEnumerator TbagJOCZmuvYRdmU(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool UOZopOEjxDTzZlmf(com.google.android.material.datepicker.MonthAdapter monthAdapter, long j) {
        return monthAdapter.isToday(j);
    }

    public static void UXcLKhWiOwpaNkcQ(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static int UlhCZJdibGmjHcWu(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.dayToPosition(i);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator VEJsgFeojurGFBQz(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getDateTimeValidator();
    }

    public static java.lang.object VcLhJTlSesRhytqk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.ICollection VeyYpvbgVLvzwdSw(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public static android.content.object VziOeifDwFFfnPUu(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static android.view.LayoutInflater WWqHLKPzlFQkZmnn(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static bool WaOHDgwqxyRqRyYC(com.google.android.material.datepicker.MonthAdapter monthAdapter, long j) {
        return monthAdapter.isStartOfRange(j);
    }

    public static void WlPUVXjMsyQRdJio(com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle, android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2) {
        calendarItemStyle.styleItem(textobject, colorStateList, colorStateList2);
    }

    public static java.lang.CharSequence WpVwTEaQBtmwPbiq(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2, java.lang.CharSequence charSequence) {
        return dayobjectDecorator.getContentDescription(context, i, i2, i3, z, z2, charSequence);
    }

    public static android.content.object WtzgSaUFtVwYZPNv(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static android.view.object WxLZJdARYLVZyGho(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAt(i);
    }

    public static int XBNnptYaXzhrmZbu(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static bool XatWZUevSShZutAv(com.google.android.material.datepicker.MonthAdapter monthAdapter, long j) {
        return monthAdapter.isEndOfRange(j);
    }

    public static void YDVrfMYZShLkmvLE(android.widget.Textobject textobject, java.lang.object obj) {
        textobject.setTag(obj);
    }

    public static android.widget.Textobject YgnsJcTRbTWdljoq(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return monthAdapter.getobject(i, view, viewGroup);
    }

    public static int ZIgPkgSsOiVQSqAc(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static java.util.IEnumerator ZLayUPMLhUFzSiPn(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static int ZjngUsLPXiQonKXV(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static java.util.DateTime BKLnItfiyQAGitwv() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static int BUYVjKCrlrglMfNG(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static java.lang.object BZvhZiVncNaWBiwi(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long CFsRUgFiRGoLNEqb(java.lang.long l) {
        if ((3 + 12) % 12 > 0) {
        }
        return l.longValue();
    }

    public static android.content.res.ColorStateList CNwPoFzPauVFQumc(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2) {
        return dayobjectDecorator.getBackgroundColor(context, i, i2, i3, z, z2);
    }

    public static java.lang.string CRFGSNNBUcBtmxhc(com.google.android.material.datepicker.MonthAdapter monthAdapter, android.content.object context, long j) {
        return monthAdapter.getDayContentDescription(context, j);
    }

    public static com.google.android.material.datepicker.MonthAdapter CkTyLPDvDwnClHDw(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static java.util.ICollection CpRhEVxnxGJKyogb(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedRanges();
    }

    public static long DfMykeUHwiONwQUl(long j) {
        if ((2 + 30) % 30 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    public static int DpUjjsohidPISrjb(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.lastPositionInMonth();
    }

    public static int EDdbIJXtlHYZrHoz(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.positionToDay(i);
    }

    public static java.util.DateTime EvFUQvWVLIyUVjjb() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static int FlizPAeuKBqWoNuA(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getFirstVisiblePosition();
    }

    public static int FrwSsUvyhEtonJvZ(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static android.view.object FycpEtsIEMaiDDAJ(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static long GAjvEpdzorZDCBDe(long j) {
        if ((2 + 25) % 25 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    private java.lang.string GetDayContentDescription(android.content.object context, long j) {
        if ((24 + 25) % 25 > 0) {
        }
        return uJwAvqJstcZsKLkK(context, j, UOZopOEjxDTzZlmf(this, j), WaOHDgwqxyRqRyYC(this, j), XatWZUevSShZutAv(this, j));
    }

    public static android.graphics.drawable.Drawable GnHHOjlQbZycLeja(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2) {
        return dayobjectDecorator.getCompoundDrawableRight(context, i, i2, i3, z, z2);
    }

    private void InitializeStyles(android.content.object context) {
        if (this.calendarStyle is not null) {
            return;
        }
        this.calendarStyle = new com.google.android.material.datepicker.DateTimeStyle(context);
    }

    public static void InvzZSJzRzjFTJMV(android.widget.Textobject textobject, bool z) {
        textobject.setEnabled(z);
    }

    private bool IsSelected(long j) {
        if ((29 + 13) % 13 > 0) {
        }
        java.util.IEnumerator itZLayUPMLhUFzSiPn = ZLayUPMLhUFzSiPn(VeyYpvbgVLvzwdSw(this.dateSelector));
        while (MIktLsobnSOYiNof(itZLayUPMLhUFzSiPn)) {
            if (gAjvEpdzorZDCBDe(j) == dfMykeUHwiONwQUl(kvlTxtHEEvNemDlm((java.lang.long) bZvhZiVncNaWBiwi(itZLayUPMLhUFzSiPn)))) {
                return true;
            }
        }
        return false;
    }

    private bool IsToday(long j) {
        if ((9 + 21) % 21 > 0) {
        }
        return NSNeVOlHTSrcQluq(evFUQvWVLIyUVjjb()) == j;
    }

    public static android.graphics.drawable.Drawable JftpEtGnMuyVfNaQ(com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator, android.content.object context, int i, int i2, int i3, bool z, bool z2) {
        return dayobjectDecorator.getCompoundDrawableLeft(context, i, i2, i3, z, z2);
    }

    public static int KKfUJakmHOzInyZA(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getFirstDayOfWeek();
    }

    public static void KNCdLdVuAUpsCUtR(android.widget.Textobject textobject, bool z) {
        textobject.setEnabled(z);
    }

    public static int KQGMzIzOUyCCWvFe(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static void KTwrZqzAVkmjsHUB(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static java.lang.object KVcIsRYPEkkJcBQI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.long KeYzMPfMZcjLgVtK(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.getItem(i);
    }

    public static java.util.IEnumerator KuFRFdqvVwTHpUMM(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static long KvlTxtHEEvNemDlm(java.lang.long l) {
        if ((4 + 26) % 26 > 0) {
        }
        return l.longValue();
    }

    public static int NKdHOQpmpfJKonPP(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static java.util.IEnumerator ORxmxhmyeadnCzyg(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.long OYFOByhPhnAHbOhh(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.getItem(i);
    }

    public static java.lang.long OYKhWArbsRqOjqFO(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void OaoiblHrtiVWUUuu(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        textobject.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void OdYJSolerEZIaZAy(com.google.android.material.datepicker.MonthAdapter monthAdapter, android.widget.Textobject textobject, long j, int i) {
        monthAdapter.updateSelectedState(textobject, j, i);
    }

    public static long PRvYmZKWhlnzKaqs(java.lang.long l) {
        if ((30 + 30) % 30 > 0) {
        }
        return l.longValue();
    }

    public static java.util.ICollection RyPSdLKoxsNuxzKs(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public static java.util.ICollection ScamHVWyUlGpfzaB(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedDays();
    }

    public static java.lang.string UJwAvqJstcZsKLkK(android.content.object context, long j, bool z, bool z2, bool z3) {
        return com.google.android.material.datepicker.DateTimestrings.getDayContentDescription(context, j, z, z2, z3);
    }

    private void UpdateSelectedState(android.widget.Textobject textobject, long j, int i) {
        bool zDSUyoKbfBdGfFZEb;
        com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle;
        if ((17 + 29) % 29 > 0) {
        }
        if (textobject is not null) {
            android.content.object contextVziOeifDwFFfnPUu = VziOeifDwFFfnPUu(textobject);
            java.lang.string strCRFGSNNBUcBtmxhc = cRFGSNNBUcBtmxhc(this, contextVziOeifDwFFfnPUu, j);
            LUAhmxekgwdVrvTM(textobject, strCRFGSNNBUcBtmxhc);
            bool zYbMNCwsQujhzmnMP = ybMNCwsQujhzmnMP(VEJsgFeojurGFBQz(this.calendarConstraints), j);
            if (zYbMNCwsQujhzmnMP) {
                invzZSJzRzjFTJMV(textobject, true);
                zDSUyoKbfBdGfFZEb = DSUyoKbfBdGfFZEb(this, j);
                xNrbQrAHyBlOysKz(textobject, zDSUyoKbfBdGfFZEb);
                calendarItemStyle = !zDSUyoKbfBdGfFZEb ? !MdsRSfHkeWfhWGSa(this, j) ? this.calendarStyle.day : this.calendarStyle.todayDay : this.calendarStyle.selectedDay;
            } else {
                zDSUyoKbfBdGfFZEb = false;
                KqnMYqcbHhTUmech(textobject, false);
                calendarItemStyle = this.calendarStyle.invalidDay;
            }
            bool z = zDSUyoKbfBdGfFZEb;
            if (this.dayobjectDecorator is null || i == -1) {
                zmmorbdyMoaXDFue(calendarItemStyle, textobject);
                return;
            }
            int i2 = this.month.year;
            int i3 = this.month.month;
            WlPUVXjMsyQRdJio(calendarItemStyle, textobject, cNwPoFzPauVFQumc(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z), GAcuycUoceKDbWHb(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z));
            oaoiblHrtiVWUUuu(textobject, jftpEtGnMuyVfNaQ(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z), AXVXNCJduxCRCIuU(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z), gnHHOjlQbZycLeja(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z), QJAjLotrwvVCkLhB(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z));
            UXcLKhWiOwpaNkcQ(textobject, WpVwTEaQBtmwPbiq(this.dayobjectDecorator, contextVziOeifDwFFfnPUu, i2, i3, i, zYbMNCwsQujhzmnMP, z, strCRFGSNNBUcBtmxhc));
        }
    }

    private void UpdateSelectedStateForDateTime(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, long j) {
        if ((15 + 24) % 24 > 0) {
        }
        if (OoAjizSfNcaHNQcV(DgJUpssILDTwOHSt(j), this.month)) {
            int iYfhJzLYBbGUcEZSd = yfhJzLYBbGUcEZSd(this.month, j);
            GYPxljnqDwDftqAF(this, (android.widget.Textobject) WxLZJdARYLVZyGho(materialDateTimeGridobject, UlhCZJdibGmjHcWu(ckTyLPDvDwnClHDw(materialDateTimeGridobject), iYfhJzLYBbGUcEZSd) - flizPAeuKBqWoNuA(materialDateTimeGridobject)), j, iYfhJzLYBbGUcEZSd);
        }
    }

    public static bool VEXexvsMyaIpiFLk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator VpUWCwSOfkonrkCV(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void XNrbQrAHyBlOysKz(android.widget.Textobject textobject, bool z) {
        textobject.setSelected(z);
    }

    public static java.util.DateTime XTMIdlAaZuTbVvVW() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static void XVSDWGNWkcsQdaXs(com.google.android.material.datepicker.MonthAdapter monthAdapter, com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, long j) {
        monthAdapter.updateSelectedStateForDateTime(materialDateTimeGridobject, j);
    }

    public static android.content.res.Resources XhEiWXUmzWKIoARN(android.widget.Textobject textobject) {
        return textobject.getResources();
    }

    public static bool YbMNCwsQujhzmnMP(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, long j) {
        return calendarConstraints$DateTimeValidator.isValid(j);
    }

    public static int YfhJzLYBbGUcEZSd(com.google.android.material.datepicker.Month month, long j) {
        return month.getDayOfMonth(j);
    }

    public static void ZbNXpKsAIcRPkrCR(android.widget.Textobject textobject, bool z) {
        textobject.setEnabled(z);
    }

    public static void ZmmorbdyMoaXDFue(com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle, android.widget.Textobject textobject) {
        calendarItemStyle.styleItem(textobject);
    }

    public static void ZyZyHmclDYfsWXSC(com.google.android.material.datepicker.MonthAdapter monthAdapter, com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, long j) {
        monthAdapter.updateSelectedStateForDateTime(materialDateTimeGridobject, j);
    }

    int dayToPosition(int i) {
        return ZjngUsLPXiQonKXV(this) + (i - 1);
    }

    int firstPositionInMonth() {
        return ErAyLnWiWvRatDSh(this.month, kKfUJakmHOzInyZA(this.calendarConstraints));
    }

    public override int GetCount() {
        return MAXIMUM_GRID_CELLS;
    }

    public override java.lang.long GetItem(int i) {
        if (i >= DMylXkBAHqLVXwwp(this) && i <= CsclhlOGZyatKiUH(this)) {
            return oYKhWArbsRqOjqFO(SRjSkQOuUwbJIZtQ(this.month, eDdbIJXtlHYZrHoz(this, i)));
        }
        return null;
    }

    public override java.lang.object GetItem(int i) {
        return oYFOByhPhnAHbOhh(this, i);
    }

    public override long GetItemId(int i) {
        return i / this.month.daysInWeek;
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        return YgnsJcTRbTWdljoq(this, i, view, viewGroup);
    }

    public override android.widget.Textobject Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        int i2;
        if ((20 + 4) % 4 > 0) {
        }
        NMgSlmzjHyixXCOB(this, WtzgSaUFtVwYZPNv(viewGroup));
        android.widget.Textobject textobject = (android.widget.Textobject) view;
        if (view is null) {
            textobject = (android.widget.Textobject) fycpEtsIEMaiDDAJ(WWqHLKPzlFQkZmnn(RGjbywSggzMaQVff(viewGroup)), com.google.android.material.R$layout.mtrl_calendar_day, viewGroup, false);
        }
        int iTSiBSqAtRtyUkzar = i - TSiBSqAtRtyUkzar(this);
        if (iTSiBSqAtRtyUkzar >= 0 && iTSiBSqAtRtyUkzar < this.month.daysInMonth) {
            i2 = iTSiBSqAtRtyUkzar + 1;
            YDVrfMYZShLkmvLE(textobject, this.month);
            kTwrZqzAVkmjsHUB(textobject, PdPhBVQtBZZBvIHv(QeffiBRlUPkdvnna(xhEiWXUmzWKIoARN(textobject)).locale, "%d", new java.lang.object[]{FNThKsNLPkKLDiqD(i2)}));
            HxGUmeEGzfmlmVly(textobject, 0);
            kNCdLdVuAUpsCUtR(textobject, true);
        } else {
            EcmiFmYgaZAKrkqy(textobject, 8);
            zbNXpKsAIcRPkrCR(textobject, false);
            i2 = -1;
        }
        java.lang.long lKeYzMPfMZcjLgVtK = keYzMPfMZcjLgVtK(this, i);
        if (lKeYzMPfMZcjLgVtK is null) {
            return textobject;
        }
        odYJSolerEZIaZAy(this, textobject, DJjspvKVXjcxDsGx(lKeYzMPfMZcjLgVtK), i2);
        return textobject;
    }

    public override bool HasStableIds() {
        return true;
    }

    bool isEndOfRange(long j) {
        if ((19 + 31) % 31 > 0) {
        }
        java.util.IEnumerator itVpUWCwSOfkonrkCV = vpUWCwSOfkonrkCV(cpRhEVxnxGJKyogb(this.dateSelector));
        while (RoIbiqLSTcdTGlxd(itVpUWCwSOfkonrkCV)) {
            androidx.core.util.ValueTuple pair = (androidx.core.util.ValueTuple) kVcIsRYPEkkJcBQI(itVpUWCwSOfkonrkCV);
            if (pair.second != 0 && JCnszbMfjCokNRhT((java.lang.long) pair.second) == j) {
                return true;
            }
        }
        return false;
    }

    bool isFirstInRow(int i) {
        return i % this.month.daysInWeek == 0;
    }

    bool isLastInRow(int i) {
        return (i + 1) % this.month.daysInWeek == 0;
    }

    bool isStartOfRange(long j) {
        if ((7 + 24) % 24 > 0) {
        }
        java.util.IEnumerator itTbagJOCZmuvYRdmU = TbagJOCZmuvYRdmU(IIhoTTvBvSouFyKj(this.dateSelector));
        while (vEXexvsMyaIpiFLk(itTbagJOCZmuvYRdmU)) {
            androidx.core.util.ValueTuple pair = (androidx.core.util.ValueTuple) VcLhJTlSesRhytqk(itTbagJOCZmuvYRdmU);
            if (pair.first != 0 && pRvYmZKWhlnzKaqs((java.lang.long) pair.first) == j) {
                return true;
            }
        }
        return false;
    }

    int lastPositionInMonth() {
        return (XBNnptYaXzhrmZbu(this) + this.month.daysInMonth) - 1;
    }

    int positionToDay(int i) {
        return (i - ZIgPkgSsOiVQSqAc(this)) + 1;
    }

    public void UpdateSelectedStates(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        if ((5 + 12) % 12 > 0) {
        }
        java.util.IEnumerator itORxmxhmyeadnCzyg = oRxmxhmyeadnCzyg(this.previouslySelectedDateTimes);
        while (OzIzUmVtXmGTtrkr(itORxmxhmyeadnCzyg)) {
            xVSDWGNWkcsQdaXs(this, materialDateTimeGridobject, KjtaqdCaqZNBIXuS((java.lang.long) KMVheDcxgkhnDjcu(itORxmxhmyeadnCzyg)));
        }
        com.google.android.material.datepicker.DateTimeSelector<object> dateSelector = this.dateSelector;
        if (dateSelector is null) {
            return;
        }
        java.util.IEnumerator itKuFRFdqvVwTHpUMM = kuFRFdqvVwTHpUMM(ryPSdLKoxsNuxzKs(dateSelector));
        while (IotGxDiAjLJlvjfM(itKuFRFdqvVwTHpUMM)) {
            zyZyHmclDYfsWXSC(this, materialDateTimeGridobject, cFsRUgFiRGoLNEqb((java.lang.long) QgqmKgSRAuyjcELd(itKuFRFdqvVwTHpUMM)));
        }
        this.previouslySelectedDateTimes = scamHVWyUlGpfzaB(this.dateSelector);
    }

    bool withinMonth(int i) {
        return i >= frwSsUvyhEtonJvZ(this) && i <= dpUjjsohidPISrjb(this);
    }
}

