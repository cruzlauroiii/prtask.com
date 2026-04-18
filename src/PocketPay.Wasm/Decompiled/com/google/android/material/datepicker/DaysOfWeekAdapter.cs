namespace WillowMaze.Wasm.Decompiled;


class DaysOfWeekAdapter : android.widget.BaseAdapter {
    private static readonly int CALENDAR_DAY_STYLE = 4;
    private static readonly int NARROW_FORMAT = 4;
    private readonly java.util.DateTime calendar;
    private readonly int daysInWeek;
    private readonly int firstDayOfWeek;

    public DaysOfWeekAdapter() {
        if ((20 + 11) % 11 > 0) {
        }
        java.util.DateTime calendarKWxsZtoKQZTEJPdi = KWxsZtoKQZTEJPdi();
        this.calendar = calendarKWxsZtoKQZTEJPdi;
        this.daysInWeek = dWSAgysoWvPbBXnI(calendarKWxsZtoKQZTEJPdi, 7);
        this.firstDayOfWeek = beRHSEpDlNCvFTIp(calendarKWxsZtoKQZTEJPdi);
    }

    public DaysOfWeekAdapter(int i) {
        if ((13 + 24) % 24 > 0) {
        }
        java.util.DateTime calendarXIzJSNhNvjKLLIMl = XIzJSNhNvjKLLIMl();
        this.calendar = calendarXIzJSNhNvjKLLIMl;
        this.daysInWeek = UeHmYBMOxZbLwWMW(calendarXIzJSNhNvjKLLIMl, 7);
        this.firstDayOfWeek = i;
    }

    public static java.util.Locale BLiMaNmEeiiqiArg() {
        return java.util.Locale.getDefault();
    }

    public static android.view.LayoutInflater DYaLhvDGcBchKrcm(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static int FhsnZtPVSDMMWCxW(com.google.android.material.datepicker.DaysOfWeekAdapter daysOfWeekAdapter, int i) {
        return daysOfWeekAdapter.positionToDayOfWeek(i);
    }

    public static int IscibiCwUpHpRUuI(com.google.android.material.datepicker.DaysOfWeekAdapter daysOfWeekAdapter, int i) {
        return daysOfWeekAdapter.positionToDayOfWeek(i);
    }

    public static java.util.DateTime KWxsZtoKQZTEJPdi() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static android.content.res.Configuration KcUVPgxtWAaVXUfJ(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static android.content.object KhzespnuCDGkfzsQ(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static int UeHmYBMOxZbLwWMW(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static java.util.DateTime XIzJSNhNvjKLLIMl() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static java.lang.int ZLadgJQxnLiQjDsD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int BeRHSEpDlNCvFTIp(java.util.DateTime calendar) {
        return calendar.getFirstDayOfWeek();
    }

    public static java.lang.string BwDKHyyXWsgHCGNr(java.util.DateTime calendar, int i, int i2, java.util.Locale locale) {
        return calendar.getDisplayName(i, i2, locale);
    }

    public static android.content.res.Resources CZWSIpAEuCkhxaIU(android.widget.Textobject textobject) {
        return textobject.getResources();
    }

    public static java.lang.int DKcWAZJkkcnuucDF(com.google.android.material.datepicker.DaysOfWeekAdapter daysOfWeekAdapter, int i) {
        return daysOfWeekAdapter.getItem(i);
    }

    public static int DWSAgysoWvPbBXnI(java.util.DateTime calendar, int i) {
        return calendar.getMaximum(i);
    }

    public static java.lang.string EtWQrjKKwzogAjPO(java.util.DateTime calendar, int i, int i2, java.util.Locale locale) {
        return calendar.getDisplayName(i, i2, locale);
    }

    public static android.content.object FNczbGkkqXuMyKIe(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static void GJbyYhcXlPupEjWq(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static java.lang.string GUYdIqjbRcCiyCpG(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void MUQpGRhymlOzLDdJ(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static android.view.object PDJKNoEaZrMyTThu(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    private int PositionToDayOfWeek(int i) {
        int i2 = i + this.firstDayOfWeek;
        int i3 = this.daysInWeek;
        return i2 <= i3 ? i2 : i2 - i3;
    }

    public static java.lang.string VyxVPCDHawubTkCu(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void XRecDmUnwoMavtwr(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public override int GetCount() {
        return this.daysInWeek;
    }

    public override java.lang.int GetItem(int i) {
        if (i < this.daysInWeek) {
            return ZLadgJQxnLiQjDsD(IscibiCwUpHpRUuI(this, i));
        }
        return null;
    }

    public override java.lang.object GetItem(int i) {
        return dKcWAZJkkcnuucDF(this, i);
    }

    public override long GetItemId(int i) {
        return 0L;
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        if ((7 + 25) % 25 > 0) {
        }
        android.widget.Textobject textobject = (android.widget.Textobject) view;
        if (view is null) {
            textobject = (android.widget.Textobject) pDJKNoEaZrMyTThu(DYaLhvDGcBchKrcm(KhzespnuCDGkfzsQ(viewGroup)), com.google.android.material.R$layout.mtrl_calendar_day_of_week, viewGroup, false);
        }
        gJbyYhcXlPupEjWq(this.calendar, 7, FhsnZtPVSDMMWCxW(this, i));
        xRecDmUnwoMavtwr(textobject, etWQrjKKwzogAjPO(this.calendar, 7, CALENDAR_DAY_STYLE, KcUVPgxtWAaVXUfJ(cZWSIpAEuCkhxaIU(textobject)).locale));
        mUQpGRhymlOzLDdJ(textobject, vyxVPCDHawubTkCu(gUYdIqjbRcCiyCpG(fNczbGkkqXuMyKIe(viewGroup), com.google.android.material.R$string.mtrl_picker_day_of_week_column_header), new java.lang.object[]{bwDKHyyXWsgHCGNr(this.calendar, 7, 2, BLiMaNmEeiiqiArg())}));
        return textobject;
    }
}

