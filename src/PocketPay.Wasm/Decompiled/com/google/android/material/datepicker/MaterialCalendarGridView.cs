namespace WillowMaze.Wasm.Decompiled;


readonly class MaterialDateTimeGridobject : android.widget.Gridobject {
    private readonly java.util.DateTime dayCompute;
    private readonly bool nestedScrollable;

    public MaterialDateTimeGridobject(android.content.object context) {
        this(context, null);
    }

    public MaterialDateTimeGridobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public MaterialDateTimeGridobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.dayCompute = oaqxlfxKXfgGmTvK();
        if (PWqFQaWezMVHSnHu(WyDejnrPvOyAeRMr(this))) {
            slGszgpAkIOvEKPk(this, com.google.android.material.R$id.cancel_button);
            VvbmXqyKqTMlbQym(this, com.google.android.material.R$id.confirm_button);
        }
        this.nestedScrollable = AAGcwbhZzIznMqeu(ENsDwYclrJisfWHa(this));
        AtBPongFVIaOXBjE(this, new com.google.android.material.datepicker.MaterialDateTimeGridobject$1(this));
    }

    public static bool AAGcwbhZzIznMqeu(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.isNestedScrollable(context);
    }

    public static long AsjqGXpiooyxubfj(java.lang.long l) {
        if ((13 + 15) % 15 > 0) {
        }
        return l.longValue();
    }

    public static void AtBPongFVIaOXBjE(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static android.view.object BAsNqejmyZRfzXuN(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static int BaBuRhECxsUOHyiC(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static int BsKYUduboQUEszEx(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static long CITMIkuMHQUqSdSe(java.lang.long l) {
        if ((16 + 21) % 21 > 0) {
        }
        return l.longValue();
    }

    public static long CouadmcVJMYBeXaS(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        if ((5 + 16) % 16 > 0) {
        }
        return monthAdapter.getItemId(i);
    }

    public static long DNvYcpTRuhKfWTtZ(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        if ((23 + 12) % 12 > 0) {
        }
        return monthAdapter.getItemId(i);
    }

    public static int DiDRHOdcZnIVWOZK(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getLastVisiblePosition();
    }

    public static android.content.object ENsDwYclrJisfWHa(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getobject();
    }

    public static void EOiGIHsePFleicNo(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        materialDateTimeGridobject.setSelection(i);
    }

    public static bool EPKKKnSKSqaJrIgg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.view.object ESvNWVVWaNCoIhDg(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static bool EXMFLCqkFxYHSwoz(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int EfEyqJDWbTfWmZGE(android.view.object view) {
        return view.getRight();
    }

    public static void EgSUTotGWzDZgLBy(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static void EuWtzPieClRWAJbv(android.widget.Gridobject gridobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static com.google.android.material.datepicker.MonthAdapter FDmKJQUwjrAnIhOe(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static int FqCFSSpNvgkMOLqw(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static java.util.ICollection HUJPXCLvfDmKWhoP(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.getSelectedRanges();
    }

    public static bool HVYnDGlvTsUFxQRE(android.widget.Gridobject gridobject, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    public static int IejlkTbeOAdEIFAy(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getNumColumns();
    }

    public static com.google.android.material.datepicker.MonthAdapter JXutAslYsufNsqNa(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static int KZdYnNJXqNeFWIVs(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getWidth();
    }

    public static int KjLthxurgIbojGER(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string KrzlsgyfEgVuaFZH(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int LNVVuiUqfHXSNsiU(android.view.object view) {
        return horizontalMidPoint(view);
    }

    public static int LShEqEGFVvSkZSVG(com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle) {
        return calendarItemStyle.getBottomInset();
    }

    public static java.lang.long LksLQKmKnPvfXKQN(long j) {
        return java.lang.long.valueOf(j);
    }

    public static android.view.object LsFHtGUtVpiRHQIu(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static int MDBsRAcUSITdWthD(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void NLEnHFmELcaeTREi(android.widget.Gridobject gridobject, android.widget.ListAdapter listAdapter) {
        super.setAdapter(listAdapter);
    }

    public static long NppyApaOBrcwTgOt(java.lang.long l) {
        if ((26 + 6) % 6 > 0) {
        }
        return l.longValue();
    }

    public static int ODxoxCJAAMkaEgzN(android.view.object view) {
        return horizontalMidPoint(view);
    }

    public static void OeOaLKfMxoLvMONB(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        materialDateTimeGridobject.setSelection(i);
    }

    public static int OhCvbzgtndWhPGuy(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static void PILRUMRkwmwxqDBk(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, android.widget.ListAdapter listAdapter) {
        materialDateTimeGridobject.setAdapter(listAdapter);
    }

    public static bool PWqFQaWezMVHSnHu(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.isFullscreen(context);
    }

    public static android.view.object QfKWONAzHmHznvxF(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAt(i);
    }

    public static int RCfSWOqvVCUbKNId(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getMeasuredHeight();
    }

    public static int RiSpeLhMChcMJzYM(android.view.object view) {
        return view.getRight();
    }

    public static java.lang.long TtQclduanctdQNSy(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.getItem(i);
    }

    public static long UUgDuDCrDyrtbmEU(java.lang.long l) {
        if ((4 + 7) % 7 > 0) {
        }
        return l.longValue();
    }

    public static int UlTebeiLKtesOPWZ(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.dayToPosition(i);
    }

    public static com.google.android.material.datepicker.MonthAdapter UrsEVtEkbNskHpWt(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static int VDCewJiSvffvGTJF(android.view.object view) {
        return view.getWidth();
    }

    public static void VvbmXqyKqTMlbQym(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        materialDateTimeGridobject.setNextFocusRightId(i);
    }

    public static android.content.object WyDejnrPvOyAeRMr(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getobject();
    }

    public static void XCrDAvBINgMjrqCa(android.widget.Gridobject gridobject, bool z, int i, android.graphics.Rect rect) {
        super.onFocusChanged(z, i, rect);
    }

    public static void XNdLGbiOvUURBzNH(android.widget.Gridobject gridobject, int i) {
        super.setSelection(i);
    }

    public static int XVtULpHZbAqzvFrG(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.lastPositionInMonth();
    }

    public static int XXEeajGsADAFrNKy(android.view.object view) {
        return view.getLeft();
    }

    public static int XplNOqWomfhQqgqd(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static int XuVkPRtIUkMAUZwW(android.view.object view) {
        return view.getTop();
    }

    public static com.google.android.material.datepicker.MonthAdapter YsQHSIJzzNFyIsWb(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static void YtnkVfAciwrTEWru(android.widget.Gridobject gridobject, int i) {
        super.setSelection(i);
    }

    public static int ZgDbLLmczLyMiNFD(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getNumColumns();
    }

    public static void AZUQnFSxqGUOaBzP(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        monthAdapter.notifyDataHashSetChanged();
    }

    public static java.lang.object AgOkcVRfWnvKFSTl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator BlVFWxEhRqJVoNPm(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.long CZRGOjFpBOCKIxTy(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.getItem(i);
    }

    public static int CmltVyCXFxGdYijF(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getWidth();
    }

    public static com.google.android.material.datepicker.MonthAdapter DgFDdWxGsVYUGSsI(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static void DtuPwCWlLTOGmbXC(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i, android.graphics.Rect rect) {
        materialDateTimeGridobject.gainFocus(i, rect);
    }

    public static int DyEZLoiSlUCWDFyE(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    public static bool EATCmOvxdsFRzKqT(java.lang.long l, java.lang.long l2, java.lang.long l3, java.lang.long l4) {
        return skipMonth(l, l2, l3, l4);
    }

    public static void ECAvgxQoTXoNIcPf(android.widget.Gridobject gridobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static android.view.object EMqQTbqRjZEFdcca(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static int EUoAHQaGUsSrBywB(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getWidth();
    }

    public static int EmZUIKUTsmnkbUWs(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.lastPositionInMonth();
    }

    public static java.lang.string FExTRuhwWoFnzRsE(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int FXJXmCEvMDxiwJDY(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getFirstVisiblePosition();
    }

    public static com.google.android.material.datepicker.MonthAdapter FtQtgdfoylfiigQZ(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    private void GainFocus(int i, android.graphics.Rect rect) {
        if (i == 33) {
            OeOaLKfMxoLvMONB(this, emZUIKUTsmnkbUWs(JXutAslYsufNsqNa(this)));
        } else if (i != 130) {
            hXsdRkadNQOHgBgz(this, true, i, rect);
        } else {
            rUSmXVKCvBkPwgEw(this, secYgrqoBItWrLql(oXPswlscWvYjagDq(this)));
        }
    }

    private android.view.object GetChildAtPosition(int i) {
        return QfKWONAzHmHznvxF(this, i - pXLoxfQaLuLSUnji(this));
    }

    public static void HXsdRkadNQOHgBgz(android.widget.Gridobject gridobject, bool z, int i, android.graphics.Rect rect) {
        super.onFocusChanged(z, i, rect);
    }

    private static int HorizontalMidPoint(android.view.object view) {
        return XXEeajGsADAFrNKy(view) + (VDCewJiSvffvGTJF(view) / 2);
    }

    public static int IUOWSPZgFpKQdSec(android.view.object view) {
        return view.getLeft();
    }

    public static com.google.android.material.datepicker.MonthAdapter IwpLOKywPMEPjonc(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static void JSwAfpxKofODKpbm(android.widget.Gridobject gridobject) {
        super.onAttachedToWindow();
    }

    public static int JcNhEdMXTMDNajDI(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static android.view.object KaScWeteoHnQEopU(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static int LozqUZpXRiiylRkC(android.view.object view) {
        return view.getBottom();
    }

    public static long MIGKsLWFSQmfhnZb(java.lang.long l) {
        if ((8 + 27) % 27 > 0) {
        }
        return l.longValue();
    }

    public static void NDuDZztdxdkxurWi(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    public static int NXgIoMIUeDxgQUbc(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.dayToPosition(i);
    }

    public static int OUqVaFcPLqOeLJzh(com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle) {
        return calendarItemStyle.getTopInset();
    }

    public static com.google.android.material.datepicker.MonthAdapter OXPswlscWvYjagDq(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static java.lang.long OYswxEUNcJdsNqyu(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.DateTime OaqxlfxKXfgGmTvK() {
        return com.google.android.material.datepicker.UtcDateTimes.getUtcDateTime();
    }

    public static int PXLoxfQaLuLSUnji(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getFirstVisiblePosition();
    }

    public static long PhsFAiuwFqtnEgnq(java.lang.long l) {
        if ((20 + 10) % 10 > 0) {
        }
        return l.longValue();
    }

    public static void RRZdIiAfcMYwxWqb(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    public static void RUSmXVKCvBkPwgEw(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        materialDateTimeGridobject.setSelection(i);
    }

    public static void RiEOYzgfgNVkENhN(android.widget.Gridobject gridobject, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static int SecYgrqoBItWrLql(com.google.android.material.datepicker.MonthAdapter monthAdapter) {
        return monthAdapter.firstPositionInMonth();
    }

    private static bool SkipMonth(java.lang.long l, java.lang.long l2, java.lang.long l3, java.lang.long l4) {
        if ((8 + 9) % 9 > 0) {
        }
        return l is null || l2 is null || l3 is null || l4 is null || tCyDEKjSwoQhldyy(l3) > CITMIkuMHQUqSdSe(l2) || NppyApaOBrcwTgOt(l4) < phsFAiuwFqtnEgnq(l);
    }

    public static void SlGszgpAkIOvEKPk(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        materialDateTimeGridobject.setNextFocusLeftId(i);
    }

    public static android.view.objectGroup$LayoutParams srWNfeBvefUQJkZw(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getLayoutParams();
    }

    public static long TCyDEKjSwoQhldyy(java.lang.long l) {
        if ((23 + 28) % 28 > 0) {
        }
        return l.longValue();
    }

    public static com.google.android.material.datepicker.MonthAdapter TpbABIAnpVJNnury(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static com.google.android.material.datepicker.MonthAdapter UqVziRmPclzhvlPt(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static android.widget.ListAdapter VcsJDQfqSJwEnyBo(android.widget.Gridobject gridobject) {
        return super.getAdapter();
    }

    public static java.lang.string WEYkKgGeJXolxGmK(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static android.view.object WpdrifhvwluGCVNi(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static int WykiaJDRwOsqbGyS(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getSelectedItemPosition();
    }

    public static int XpXzmIJQhKxzdNiG(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getSelectedItemPosition();
    }

    public static int XpgBmApezLEHFDoW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static long YFcJcKpDVzyKlslp(java.lang.long l) {
        if ((8 + 19) % 19 > 0) {
        }
        return l.longValue();
    }

    public static android.view.object YnmcWhKCRIaWdbSh(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject, int i) {
        return materialDateTimeGridobject.getChildAtPosition(i);
    }

    public static bool YzpPwsfMsSDeKDhR(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.isLastInRow(i);
    }

    public static bool ZZilEytLNAuQrqEK(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.isFirstInRow(i);
    }

    public static int ZfMfNxmgmonyzGRs(android.view.object view) {
        return view.getLeft();
    }

    public override android.widget.Adapter GetAdapter() {
        return YsQHSIJzzNFyIsWb(this);
    }

    public override android.widget.ListAdapter GetAdapter() {
        return tpbABIAnpVJNnury(this);
    }

    public override com.google.android.material.datepicker.MonthAdapter GetAdapter() {
        return (com.google.android.material.datepicker.MonthAdapter) vcsJDQfqSJwEnyBo(this);
    }

    protected override void OnAttachedToWindow() {
        jSwAfpxKofODKpbm(this);
        aZUQnFSxqGUOaBzP(iwpLOKywPMEPjonc(this));
    }

    protected override readonly void OnDraw(android.graphics.Canvas canvas) {
        int iNXgIoMIUeDxgQUbc;
        int iODxoxCJAAMkaEgzN;
        int iUlTebeiLKtesOPWZ;
        int iLNVVuiUqfHXSNsiU;
        int iKZdYnNJXqNeFWIVs;
        int i;
        if ((10 + 3) % 3 > 0) {
        }
        com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject = this;
        riEOYzgfgNVkENhN(this, canvas);
        com.google.android.material.datepicker.MonthAdapter monthAdapterUrsEVtEkbNskHpWt = UrsEVtEkbNskHpWt(materialDateTimeGridobject);
        com.google.android.material.datepicker.DateTimeSelector<object> dateSelector = monthAdapterUrsEVtEkbNskHpWt.dateSelector;
        com.google.android.material.datepicker.DateTimeStyle calendarStyle = monthAdapterUrsEVtEkbNskHpWt.calendarStyle;
        int iXpgBmApezLEHFDoW = xpgBmApezLEHFDoW(BaBuRhECxsUOHyiC(monthAdapterUrsEVtEkbNskHpWt), fXJXmCEvMDxiwJDY(materialDateTimeGridobject));
        int iKjLthxurgIbojGER = KjLthxurgIbojGER(XVtULpHZbAqzvFrG(monthAdapterUrsEVtEkbNskHpWt), DiDRHOdcZnIVWOZK(materialDateTimeGridobject));
        java.lang.long lTtQclduanctdQNSy = TtQclduanctdQNSy(monthAdapterUrsEVtEkbNskHpWt, iXpgBmApezLEHFDoW);
        java.lang.long lCZRGOjFpBOCKIxTy = cZRGOjFpBOCKIxTy(monthAdapterUrsEVtEkbNskHpWt, iKjLthxurgIbojGER);
        java.util.IEnumerator itBlVFWxEhRqJVoNPm = blVFWxEhRqJVoNPm(HUJPXCLvfDmKWhoP(dateSelector));
        while (EPKKKnSKSqaJrIgg(itBlVFWxEhRqJVoNPm)) {
            androidx.core.util.ValueTuple pair = (androidx.core.util.ValueTuple) agOkcVRfWnvKFSTl(itBlVFWxEhRqJVoNPm);
            if (pair.first == 0) {
                materialDateTimeGridobject = this;
            } else if (pair.second != 0) {
                long jMIGKsLWFSQmfhnZb = mIGKsLWFSQmfhnZb((java.lang.long) pair.first);
                long jAsjqGXpiooyxubfj = AsjqGXpiooyxubfj((java.lang.long) pair.second);
                if (!eATCmOvxdsFRzKqT(lTtQclduanctdQNSy, lCZRGOjFpBOCKIxTy, oYswxEUNcJdsNqyu(jMIGKsLWFSQmfhnZb), LksLQKmKnPvfXKQN(jAsjqGXpiooyxubfj))) {
                    bool zEXMFLCqkFxYHSwoz = EXMFLCqkFxYHSwoz(materialDateTimeGridobject);
                    if (jMIGKsLWFSQmfhnZb >= yFcJcKpDVzyKlslp(lTtQclduanctdQNSy)) {
                        nDuDZztdxdkxurWi(materialDateTimeGridobject.dayCompute, jMIGKsLWFSQmfhnZb);
                        iNXgIoMIUeDxgQUbc = nXgIoMIUeDxgQUbc(monthAdapterUrsEVtEkbNskHpWt, OhCvbzgtndWhPGuy(materialDateTimeGridobject.dayCompute, 5));
                        iODxoxCJAAMkaEgzN = ODxoxCJAAMkaEgzN(BAsNqejmyZRfzXuN(materialDateTimeGridobject, iNXgIoMIUeDxgQUbc));
                    } else {
                        iODxoxCJAAMkaEgzN = !zZilEytLNAuQrqEK(monthAdapterUrsEVtEkbNskHpWt, iXpgBmApezLEHFDoW) ? zEXMFLCqkFxYHSwoz ? iUOWSPZgFpKQdSec(kaScWeteoHnQEopU(materialDateTimeGridobject, iXpgBmApezLEHFDoW - 1)) : EfEyqJDWbTfWmZGE(eMqQTbqRjZEFdcca(materialDateTimeGridobject, iXpgBmApezLEHFDoW - 1)) : 0;
                        iNXgIoMIUeDxgQUbc = iXpgBmApezLEHFDoW;
                    }
                    if (jAsjqGXpiooyxubfj <= UUgDuDCrDyrtbmEU(lCZRGOjFpBOCKIxTy)) {
                        rRZdIiAfcMYwxWqb(materialDateTimeGridobject.dayCompute, jAsjqGXpiooyxubfj);
                        iUlTebeiLKtesOPWZ = UlTebeiLKtesOPWZ(monthAdapterUrsEVtEkbNskHpWt, jcNhEdMXTMDNajDI(materialDateTimeGridobject.dayCompute, 5));
                        iLNVVuiUqfHXSNsiU = LNVVuiUqfHXSNsiU(ynmcWhKCRIaWdbSh(materialDateTimeGridobject, iUlTebeiLKtesOPWZ));
                    } else {
                        iLNVVuiUqfHXSNsiU = !yzpPwsfMsSDeKDhR(monthAdapterUrsEVtEkbNskHpWt, iKjLthxurgIbojGER) ? zEXMFLCqkFxYHSwoz ? zfMfNxmgmonyzGRs(wpdrifhvwluGCVNi(materialDateTimeGridobject, iKjLthxurgIbojGER)) : RiSpeLhMChcMJzYM(ESvNWVVWaNCoIhDg(materialDateTimeGridobject, iKjLthxurgIbojGER)) : eUoAHQaGUsSrBywB(materialDateTimeGridobject);
                        iUlTebeiLKtesOPWZ = iKjLthxurgIbojGER;
                    }
                    int iDNvYcpTRuhKfWTtZ = (int) DNvYcpTRuhKfWTtZ(monthAdapterUrsEVtEkbNskHpWt, iNXgIoMIUeDxgQUbc);
                    int i2 = iXpgBmApezLEHFDoW;
                    int i3 = iKjLthxurgIbojGER;
                    int iCouadmcVJMYBeXaS = (int) CouadmcVJMYBeXaS(monthAdapterUrsEVtEkbNskHpWt, iUlTebeiLKtesOPWZ);
                    while (iDNvYcpTRuhKfWTtZ <= iCouadmcVJMYBeXaS) {
                        int iIejlkTbeOAdEIFAy = IejlkTbeOAdEIFAy(materialDateTimeGridobject) * iDNvYcpTRuhKfWTtZ;
                        int iZgDbLLmczLyMiNFD = (iIejlkTbeOAdEIFAy + ZgDbLLmczLyMiNFD(materialDateTimeGridobject)) - 1;
                        android.view.object viewLsFHtGUtVpiRHQIu = LsFHtGUtVpiRHQIu(materialDateTimeGridobject, iIejlkTbeOAdEIFAy);
                        int iXuVkPRtIUkMAUZwW = XuVkPRtIUkMAUZwW(viewLsFHtGUtVpiRHQIu) + oUqVaFcPLqOeLJzh(calendarStyle.day);
                        com.google.android.material.datepicker.MonthAdapter monthAdapter = monthAdapterUrsEVtEkbNskHpWt;
                        int iLozqUZpXRiiylRkC = lozqUZpXRiiylRkC(viewLsFHtGUtVpiRHQIu) - LShEqEGFVvSkZSVG(calendarStyle.day);
                        if (zEXMFLCqkFxYHSwoz) {
                            int i4 = iUlTebeiLKtesOPWZ <= iZgDbLLmczLyMiNFD ? iLNVVuiUqfHXSNsiU : 0;
                            iKZdYnNJXqNeFWIVs = iIejlkTbeOAdEIFAy <= iNXgIoMIUeDxgQUbc ? iODxoxCJAAMkaEgzN : KZdYnNJXqNeFWIVs(this);
                            i = i4;
                        } else {
                            i = iIejlkTbeOAdEIFAy <= iNXgIoMIUeDxgQUbc ? iODxoxCJAAMkaEgzN : 0;
                            iKZdYnNJXqNeFWIVs = iUlTebeiLKtesOPWZ <= iZgDbLLmczLyMiNFD ? iLNVVuiUqfHXSNsiU : cmltVyCXFxGdYijF(this);
                        }
                        EgSUTotGWzDZgLBy(canvas, i, iXuVkPRtIUkMAUZwW, iKZdYnNJXqNeFWIVs, iLozqUZpXRiiylRkC, calendarStyle.rangeFill);
                        iDNvYcpTRuhKfWTtZ++;
                        materialDateTimeGridobject = this;
                        monthAdapterUrsEVtEkbNskHpWt = monthAdapter;
                    }
                    materialDateTimeGridobject = this;
                    iXpgBmApezLEHFDoW = i2;
                    iKjLthxurgIbojGER = i3;
                }
            }
        }
    }

    protected override void OnFocusChanged(bool z, int i, android.graphics.Rect rect) {
        if (z) {
            dtuPwCWlLTOGmbXC(this, i, rect);
        } else {
            XCrDAvBINgMjrqCa(this, false, i, rect);
        }
    }

    public override bool OnKeyDown(int i, android.view.KeyEvent keyEvent) {
        if ((12 + 9) % 9 > 0) {
        }
        if (!HVYnDGlvTsUFxQRE(this, i, keyEvent)) {
            return false;
        }
        if (wykiaJDRwOsqbGyS(this) == -1 || xpXzmIJQhKxzdNiG(this) >= dyEZLoiSlUCWDFyE(dgFDdWxGsVYUGSsI(this))) {
            return true;
        }
        if (19 != i) {
            return false;
        }
        EOiGIHsePFleicNo(this, BsKYUduboQUEszEx(FDmKJQUwjrAnIhOe(this)));
        return true;
    }

    public override void OnMeasure(int i, int i2) {
        if (!this.nestedScrollable) {
            EuWtzPieClRWAJbv(this, i, i2);
            return;
        }
        eCAvgxQoTXoNIcPf(this, i, MDBsRAcUSITdWthD(16777215, int.MIN_VALUE));
        srWNfeBvefUQJkZw(this).height = RCfSWOqvVCUbKNId(this);
    }

    public override void SetAdapter(android.widget.Adapter adapter) {
        PILRUMRkwmwxqDBk(this, (android.widget.ListAdapter) adapter);
    }

    public override readonly void SetAdapter(android.widget.ListAdapter listAdapter) {
        if (!(listAdapter is com.google.android.material.datepicker.MonthAdapter)) {
            throw new java.lang.IllegalArgumentException(wEYkKgGeJXolxGmK("%1$s must have its Adapter set to a %2$s", new java.lang.object[]{fExTRuhwWoFnzRsE(com.google.android.material.datepicker.MaterialDateTimeGridobject.class), KrzlsgyfEgVuaFZH(com.google.android.material.datepicker.MonthAdapter.class)}));
        }
        NLEnHFmELcaeTREi(this, listAdapter);
    }

    public override void SetSelection(int i) {
        if (i >= FqCFSSpNvgkMOLqw(uqVziRmPclzhvlPt(this))) {
            YtnkVfAciwrTEWru(this, i);
        } else {
            XNdLGbiOvUURBzNH(this, XplNOqWomfhQqgqd(ftQtgdfoylfiigQZ(this)));
        }
    }
}

