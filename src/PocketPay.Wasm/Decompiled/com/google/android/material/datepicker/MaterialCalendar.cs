namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialDateTime<S> : com.google.android.material.datepicker.Pickerobject<S> {
    private static readonly java.lang.string CALENDAR_CONSTRAINTS_KEY = "CALENDAR_CONSTRAINTS_KEY";
    private static readonly java.lang.string CURRENT_MONTH_KEY = "CURRENT_MONTH_KEY";
    private static readonly java.lang.string DAY_VIEW_DECORATOR_KEY = "DAY_VIEW_DECORATOR_KEY";
    private static readonly java.lang.string GRID_SELECTOR_KEY = "GRID_SELECTOR_KEY";
    private static readonly int SMOOTH_SCROLL_MAX = 3;
    private static readonly java.lang.string THEME_RES_ID_KEY = "THEME_RES_ID_KEY";
    private com.google.android.material.datepicker.DateTimeConstraints calendarConstraints;
    private com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector calendarSelector;
    private com.google.android.material.datepicker.DateTimeStyle calendarStyle;
    private com.google.android.material.datepicker.Month current;
    private com.google.android.material.datepicker.DateTimeSelector<S> dateSelector;
    private android.view.object dayFrame;
    private com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator;
    private android.view.object monthNext;
    private android.view.object monthPrev;
    private androidx.recyclerview.widget.Recyclerobject recyclerobject;
    private int themeResId;
    private android.view.object yearFrame;
    private androidx.recyclerview.widget.Recyclerobject yearSelector;
    static readonly java.lang.object MONTHS_VIEW_GROUP_TAG = "MONTHS_VIEW_GROUP_TAG";
    static readonly java.lang.object NAVIGATION_PREV_TAG = "NAVIGATION_PREV_TAG";
    static readonly java.lang.object NAVIGATION_NEXT_TAG = "NAVIGATION_NEXT_TAG";
    static readonly java.lang.object SELECTOR_TOGGLE_TAG = "SELECTOR_TOGGLE_TAG";

    public static void AjTBYkAaAqyeqqns(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void AznwoXrvLOfsHbvk(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        recyclerobject.setAdapter(recyclerobject$Adapter);
    }

    public static void BEaFwNHTBeYrSykM(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector) {
        materialDateTime.setSelector(materialDateTime$DateTimeSelector);
    }

    public static void BjELLHXHLPgbGdgr(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void BoxjmPmSSzeSAYRd(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        recyclerobject.scrollToPosition(i);
    }

    public static void CETYTTjKmYXemlFL(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static android.content.object CGlAoUEktEfoqhjN(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getobject();
    }

    public static int DpqxwblDvWEMabQk(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static int DtjWxhVgnWiUJMLa(int i) {
        return java.lang.Math.abs(i);
    }

    public static java.lang.string FFpTGcOszNMjsaTq(com.google.android.material.datepicker.Month month) {
        return month.getlongName();
    }

    public static void FIduhugZUKtCmtnH(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void GUVmVdXmLIHcquJE(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static android.content.object GefKAlUweerlvDID(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.requireobject();
    }

    public static void GtYONfcsVRKNqIcM(android.widget.Gridobject gridobject, int i) {
        gridobject.setNumColumns(i);
    }

    public static void HEJzhqeiNEUMCobQ(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$OnScrollListener recyclerobject$OnScrollListener) {
        recyclerobject.addOnScrollListener(recyclerobject$OnScrollListener);
    }

    public static androidx.recyclerview.widget.Recyclerobject$LayoutManager HGuxngngJfaYgjUD(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getLayoutManager();
    }

    public static void HmTqGJmVPxhZzYXd(com.google.android.material.button.MaterialButton materialButton, java.lang.object obj) {
        materialButton.setTag(obj);
    }

    public static android.os.Parcelable HotdtSoWrnrtfJiJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static int IOItoOZWKALFNyYh(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, com.google.android.material.datepicker.Month month) {
        return monthsPagerAdapter.getPosition(month);
    }

    public static void IekjDTIqrsaaqGzs(androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z) {
        recyclerobject.setHasFixedSize(z);
    }

    public static void JZJaojqPyGFDUGIg(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        recyclerobject.addItemDecoration(recyclerobject$ItemDecoration);
    }

    public static androidx.recyclerview.widget.Recyclerobject$LayoutManager JsJQPqdMOnOwChkY(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getLayoutManager();
    }

    public static void KhaxftMugdLnWYkN(androidx.recyclerview.widget.Recyclerobject recyclerobject, java.lang.object obj) {
        recyclerobject.setTag(obj);
    }

    public static android.view.object KjEpBopLhktzFCIR(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.view.object KxqipGZeeuAOIVbj(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void LSiwdKfUAEBZYWwa(android.view.object view, java.lang.object obj) {
        view.setTag(obj);
    }

    public static void LVwTRfZIbqwPiKEg(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static bool LgepdjYYcZFAIRVt(androidx.recyclerview.widget.Recyclerobject recyclerobject, java.lang.Action runnable) {
        return recyclerobject.post(runnable);
    }

    public static void LsrAQfIZmNZkDhzn(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        recyclerobject.setLayoutManager(recyclerobject$LayoutManager);
    }

    public static android.os.Parcelable MiRYrhJnBCGXTPGE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter MlzErchRAfwqRSzs(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getAdapter();
    }

    public static void MpSDpkqycKGVoDgp(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void MpuUmnFXzChURoyo(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static android.view.LayoutInflater MxfMIjmwQJoRUkSi(android.view.LayoutInflater layoutInflater, android.content.object context) {
        return layoutInflater.cloneInobject(context);
    }

    public static void NPdrYUckDpYIpLUz(com.google.android.material.datepicker.MaterialDateTime materialDateTime, int i) {
        materialDateTime.postSmoothRecyclerobjectScroll(i);
    }

    public static android.os.Parcelable NdXIlDRhtkFAEtAc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void ODXkaFlHiBkcXxIi(com.google.android.material.datepicker.MaterialDateTime materialDateTime, int i) {
        materialDateTime.postSmoothRecyclerobjectScroll(i);
    }

    public static int OLJWbgbdDbPOwYdW(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static android.os.Dictionary<string, object> QEKgsjuTBuxvNQLU(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getArguments();
    }

    public static int QWGvVYVfUyBfNvRB(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool SeJYGKBTUgFKDGMB(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.isFullscreen(context);
    }

    public static com.google.android.material.datepicker.Month ThvWjdccuKLEUfOi(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getStart();
    }

    public static android.view.object TkENvmpXijiyXkTH(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void VEYULUhobyeUCneI(android.widget.Gridobject gridobject, bool z) {
        gridobject.setEnabled(z);
    }

    public static void VjgEciMSdKqrhBNM(androidx.recyclerview.widget.PagerSnapHelper pagerSnapHelper, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        pagerSnapHelper.attachToRecyclerobject(recyclerobject);
    }

    public static int WYdfHAVgLRZbXFxO(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void XDfNdnPdAiNvoWGG(com.google.android.material.button.MaterialButton materialButton, java.lang.CharSequence charSequence) {
        materialButton.setText(charSequence);
    }

    public static void XNTazPfunPLfJGTI(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static android.content.res.Resources ZMrrBAjyCEJDKENz(android.view.objectThemeWrapper contextThemeWrapper) {
        return contextThemeWrapper.getResources();
    }

    public static int ZionJEQjSJQzFkWN(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, com.google.android.material.datepicker.Month month) {
        return monthsPagerAdapter.getPosition(month);
    }

    public static int ZktOiuujVVoxpnza(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, com.google.android.material.datepicker.Month month) {
        return monthsPagerAdapter.getPosition(month);
    }

    public static com.google.android.material.datepicker.MaterialDateTime ZoYnaErUyMULYDhc(com.google.android.material.datepicker.DateTimeSelector dateSelector, int i, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator) {
        return newInstance(dateSelector, i, calendarConstraints, dayobjectDecorator);
    }

    public static void AFMEZTlSqcNGUQch(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static void AGiqzOybdJZLcuRS(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        recyclerobject.scrollToPosition(i);
    }

    public static void AJtDlDRIzsYKSOcV(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    static androidx.recyclerview.widget.Recyclerobject access$000(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.recyclerobject;
    }

    static com.google.android.material.datepicker.DateTimeConstraints access$100(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.calendarConstraints;
    }

    static com.google.android.material.datepicker.DateTimeSelector access$200(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.dateSelector;
    }

    static androidx.recyclerview.widget.Recyclerobject access$300(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.yearSelector;
    }

    static com.google.android.material.datepicker.DateTimeStyle access$400(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.calendarStyle;
    }

    static android.view.object access$500(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.dayFrame;
    }

    static com.google.android.material.datepicker.Month access$602(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.Month month) {
        materialDateTime.current = month;
        return month;
    }

    private void AddActionsToMonthNavigation(android.view.object view, com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter) {
        if ((29 + 9) % 9 > 0) {
        }
        com.google.android.material.button.MaterialButton materialButton = (com.google.android.material.button.MaterialButton) KjEpBopLhktzFCIR(view, com.google.android.material.R$id.month_navigation_fragment_toggle);
        HmTqGJmVPxhZzYXd(materialButton, SELECTOR_TOGGLE_TAG);
        zivFyyAQxtlGCHpY(materialButton, new com.google.android.material.datepicker.MaterialDateTime$6(this));
        android.view.object viewJyRTFWODzkgezSxX = jyRTFWODzkgezSxX(view, com.google.android.material.R$id.month_navigation_previous);
        this.monthPrev = viewJyRTFWODzkgezSxX;
        pXmGHUxktfwHEkSt(viewJyRTFWODzkgezSxX, NAVIGATION_PREV_TAG);
        android.view.object viewSERWrSjmVlcBtRkz = sERWrSjmVlcBtRkz(view, com.google.android.material.R$id.month_navigation_next);
        this.monthNext = viewSERWrSjmVlcBtRkz;
        LSiwdKfUAEBZYWwa(viewSERWrSjmVlcBtRkz, NAVIGATION_NEXT_TAG);
        this.yearFrame = TkENvmpXijiyXkTH(view, com.google.android.material.R$id.mtrl_calendar_year_selector_frame);
        this.dayFrame = hQwyoNLnSFdnsNiH(view, com.google.android.material.R$id.mtrl_calendar_day_selector_frame);
        BEaFwNHTBeYrSykM(this, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.DAY);
        XDfNdnPdAiNvoWGG(materialButton, FFpTGcOszNMjsaTq(this.current));
        HEJzhqeiNEUMCobQ(this.recyclerobject, new com.google.android.material.datepicker.MaterialDateTime$7(this, monthsPagerAdapter, materialButton));
        wnAljxUvcVulHAaf(materialButton, new com.google.android.material.datepicker.MaterialDateTime$8(this));
        aFMEZTlSqcNGUQch(this.monthNext, new com.google.android.material.datepicker.MaterialDateTime$9(this, monthsPagerAdapter));
        CETYTTjKmYXemlFL(this.monthPrev, new com.google.android.material.datepicker.MaterialDateTime$10(this, monthsPagerAdapter));
    }

    public static void AkuZRgrssmUSdYpT(android.view.object view, int i) {
        view.setMinimumHeight(i);
    }

    public static void AuUIOaqQlsaoGWLN(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    private androidx.recyclerview.widget.Recyclerobject$ItemDecoration createItemDecoration() {
        return new com.google.android.material.datepicker.MaterialDateTime$5(this);
    }

    public static android.content.object DCeeVGcuGHeaIKOE(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getobject();
    }

    public static void DEcYmpElfRBxsCIb(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, int i) {
        recyclerobject$LayoutManager.scrollToPosition(i);
    }

    public static int DGUZvGifiNIKRlLP(android.content.object context) {
        return getDialogPickerHeight(context);
    }

    public static int DKRqmQHJvVRTdjxy(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getFirstDayOfWeek();
    }

    public static android.content.res.Resources EsHxtJuSXOiJzfOr(android.content.object context) {
        return context.getResources();
    }

    public static androidx.recyclerview.widget.Recyclerobject$ItemDecoration etWdDzMrXHmjsaRU(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.createItemDecoration();
    }

    public static android.view.object FCrPaeBqfhIcliJn(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void FagtfPGdAHbLOQPS(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static bool FmrnxUpmdQwzJEMy(com.google.android.material.datepicker.Pickerobject pickerobject, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        return super.addOnSelectionChangedListener(onSelectionChangedListener);
    }

    public static void GYBZJmQdHwvFSjki(android.view.object view, int i) {
        view.setVisibility(i);
    }

    static int GetDayHeight(android.content.object context) {
        return ieYaxJvTuvivIsbq(pYYjyPaGgBfseKNg(context), com.google.android.material.R$dimen.mtrl_calendar_day_height);
    }

    private static int GetDialogPickerHeight(android.content.object context) {
        if ((1 + 23) % 23 > 0) {
        }
        android.content.res.Resources resourcesEsHxtJuSXOiJzfOr = esHxtJuSXOiJzfOr(context);
        return QWGvVYVfUyBfNvRB(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_navigation_height) + DpqxwblDvWEMabQk(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_navigation_top_padding) + WYdfHAVgLRZbXFxO(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_navigation_bottom_padding) + xyOZoWwZlRoLWUeN(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_days_of_week_height) + (com.google.android.material.datepicker.MonthAdapter.MAXIMUM_WEEKS * rWfjHguTakmpPown(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_day_height)) + ((com.google.android.material.datepicker.MonthAdapter.MAXIMUM_WEEKS - 1) * jLAyXqMKWyRXeNgd(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_month_vertical_padding)) + knkyAdEvuGWGmKno(resourcesEsHxtJuSXOiJzfOr, com.google.android.material.R$dimen.mtrl_calendar_bottom_padding);
    }

    public static android.view.object HQwyoNLnSFdnsNiH(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void HRACKPyPBDHRpVfD(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int HzqDfRBnifTCheyk(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter, int i) {
        return yearGridAdapter.getPositionForYear(i);
    }

    public static int IeYaxJvTuvivIsbq(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.view.object IxyJCYXcljQkxaXI(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static int JLAyXqMKWyRXeNgd(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static com.google.android.material.datepicker.Month JZvelCIydPmeaBmT(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getOpenAt();
    }

    public static void JhpNHxicSDSbtvRH(com.google.android.material.datepicker.Pickerobject pickerobject, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static android.view.object JyRTFWODzkgezSxX(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void KRSzwBLpBSwWxYGW(com.google.android.material.datepicker.MaterialDateTime materialDateTime, int i) {
        materialDateTime.postSmoothRecyclerobjectScroll(i);
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter kWVAMjReuXLZSeqc(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getAdapter();
    }

    public static void KlmkFxshNBxzohbY(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static int KnkyAdEvuGWGmKno(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void LkmChofuWOEmhDSm(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        materialDateTime.setUpForAccessibility();
    }

    public static void MEhADhCCnbRIioCf(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void MKsMjYqqswHCwPvn(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        recyclerobject.setAdapter(recyclerobject$Adapter);
    }

    public static void NccuHEmTiXFfdPXG(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector) {
        materialDateTime.setSelector(materialDateTime$DateTimeSelector);
    }

    public static <T> com.google.android.material.datepicker.MaterialDateTime<T> NewInstance(com.google.android.material.datepicker.DateTimeSelector<T> dateSelector, int i, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return ZoYnaErUyMULYDhc(dateSelector, i, calendarConstraints, null);
    }

    public static <T> com.google.android.material.datepicker.MaterialDateTime<T> NewInstance(com.google.android.material.datepicker.DateTimeSelector<T> dateSelector, int i, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.DayobjectDecorator dayobjectDecorator) {
        if ((12 + 10) % 10 > 0) {
        }
        com.google.android.material.datepicker.MaterialDateTime<T> materialDateTime = new com.google.android.material.datepicker.MaterialDateTime<>();
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        hRACKPyPBDHRpVfD(bundle, "THEME_RES_ID_KEY", i);
        XNTazPfunPLfJGTI(bundle, "GRID_SELECTOR_KEY", dateSelector);
        GUVmVdXmLIHcquJE(bundle, "CALENDAR_CONSTRAINTS_KEY", calendarConstraints);
        auUIOaqQlsaoGWLN(bundle, "DAY_VIEW_DECORATOR_KEY", dayobjectDecorator);
        mEhADhCCnbRIioCf(bundle, "CURRENT_MONTH_KEY", jZvelCIydPmeaBmT(calendarConstraints));
        oQYpZqLOEgVHMvVG(materialDateTime, bundle);
        return materialDateTime;
    }

    public static android.view.object OIbflEJKcrrXzisn(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void OMPkiJAixVgGsMGB(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void OQYpZqLOEgVHMvVG(com.google.android.material.datepicker.MaterialDateTime materialDateTime, android.os.Dictionary<string, object> bundle) {
        materialDateTime.setArguments(bundle);
    }

    public static android.os.Parcelable OpePSxtMMvThxpGZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void PXmGHUxktfwHEkSt(android.view.object view, java.lang.object obj) {
        view.setTag(obj);
    }

    public static android.content.res.Resources PYYjyPaGgBfseKNg(android.content.object context) {
        return context.getResources();
    }

    private void PostSmoothRecyclerobjectScroll(int i) {
        if ((17 + 19) % 19 > 0) {
        }
        LgepdjYYcZFAIRVt(this.recyclerobject, new com.google.android.material.datepicker.MaterialDateTime$11(this, i));
    }

    public static void QUpTpTtsQSgcYzgv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static int RWfjHguTakmpPown(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool RpARoCcdGahqlbrG(android.content.object context) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.isFullscreen(context);
    }

    public static android.view.object SERWrSjmVlcBtRkz(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void SYqoXtvPtJIpTZcR(com.google.android.material.datepicker.MaterialDateTime materialDateTime, android.view.object view, com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter) {
        materialDateTime.addActionsToMonthNavigation(view, monthsPagerAdapter);
    }

    private void SetUpForAccessibility() {
        if ((31 + 26) % 26 > 0) {
        }
        aJtDlDRIzsYKSOcV(this.recyclerobject, new com.google.android.material.datepicker.MaterialDateTime$4(this));
    }

    public static void TVJUuPlzhayFjgZb(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static android.view.object UVNdIoRdSBvauFir(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void VCchxszlkeodbkaQ(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        recyclerobject.setLayoutManager(recyclerobject$LayoutManager);
    }

    public static int VdZsIsLMCzdWyurh(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static void VeaEvQeBEUQdFadL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void VtaXRztDgpeFQFlm(com.google.android.material.datepicker.Pickerobject pickerobject, android.os.Dictionary<string, object> bundle) {
        super.onSaveInstanceState(bundle);
    }

    public static void WnAljxUvcVulHAaf(com.google.android.material.button.MaterialButton materialButton, android.view.object$OnClickListener view$OnClickListener) {
        materialButton.setOnClickListener(view$OnClickListener);
    }

    public static void WvXmEtCGTeofoZWP(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector) {
        materialDateTime.setSelector(materialDateTime$DateTimeSelector);
    }

    public static void XSAqVWUmtyTbGTfL(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.Month month) {
        materialDateTime.setCurrentMonth(month);
    }

    public static int XyOZoWwZlRoLWUeN(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void YhmpgvShbfAyPNJd(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void YymcEpEOOBKVDxrp(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        recyclerobject.scrollToPosition(i);
    }

    public static void ZanRpwMfeytZLtGc(android.widget.Gridobject gridobject, android.widget.ListAdapter listAdapter) {
        gridobject.setAdapter(listAdapter);
    }

    public static void ZivFyyAQxtlGCHpY(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public override bool AddOnSelectionChangedListener(com.google.android.material.datepicker.OnSelectionChangedListener<S> onSelectionChangedListener) {
        return fmrnxUpmdQwzJEMy(this, onSelectionChangedListener);
    }

    com.google.android.material.datepicker.DateTimeConstraints getDateTimeConstraints() {
        return this.calendarConstraints;
    }

    com.google.android.material.datepicker.DateTimeStyle getDateTimeStyle() {
        return this.calendarStyle;
    }

    com.google.android.material.datepicker.Month getCurrentMonth() {
        return this.current;
    }

    public override com.google.android.material.datepicker.DateTimeSelector<S> GetDateTimeSelector() {
        return this.dateSelector;
    }

    androidx.recyclerview.widget.LinearLayoutManager getLayoutManager() {
        return (androidx.recyclerview.widget.LinearLayoutManager) JsJQPqdMOnOwChkY(this.recyclerobject);
    }

    public override void OnCreate(android.os.Dictionary<string, object> bundle) {
        jhpNHxicSDSbtvRH(this, bundle);
        if (bundle is null) {
            bundle = QEKgsjuTBuxvNQLU(this);
        }
        this.themeResId = OLJWbgbdDbPOwYdW(bundle, "THEME_RES_ID_KEY");
        this.dateSelector = (com.google.android.material.datepicker.DateTimeSelector) opePSxtMMvThxpGZ(bundle, "GRID_SELECTOR_KEY");
        this.calendarConstraints = (com.google.android.material.datepicker.DateTimeConstraints) NdXIlDRhtkFAEtAc(bundle, "CALENDAR_CONSTRAINTS_KEY");
        this.dayobjectDecorator = (com.google.android.material.datepicker.DayobjectDecorator) MiRYrhJnBCGXTPGE(bundle, "DAY_VIEW_DECORATOR_KEY");
        this.current = (com.google.android.material.datepicker.Month) HotdtSoWrnrtfJiJ(bundle, "CURRENT_MONTH_KEY");
    }

    public override android.view.object OnCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        int i;
        int i2;
        if ((6 + 5) % 5 > 0) {
        }
        android.view.objectThemeWrapper contextThemeWrapper = new android.view.objectThemeWrapper(dCeeVGcuGHeaIKOE(this), this.themeResId);
        this.calendarStyle = new com.google.android.material.datepicker.DateTimeStyle(contextThemeWrapper);
        android.view.LayoutInflater layoutInflaterMxfMIjmwQJoRUkSi = MxfMIjmwQJoRUkSi(layoutInflater, contextThemeWrapper);
        com.google.android.material.datepicker.Month monthThvWjdccuKLEUfOi = ThvWjdccuKLEUfOi(this.calendarConstraints);
        if (rpARoCcdGahqlbrG(contextThemeWrapper)) {
            i = com.google.android.material.R$layout.mtrl_calendar_vertical;
            i2 = 1;
        } else {
            i = com.google.android.material.R$layout.mtrl_calendar_horizontal;
            i2 = 0;
        }
        android.view.object viewFCrPaeBqfhIcliJn = fCrPaeBqfhIcliJn(layoutInflaterMxfMIjmwQJoRUkSi, i, viewGroup, false);
        akuZRgrssmUSdYpT(viewFCrPaeBqfhIcliJn, dGUZvGifiNIKRlLP(GefKAlUweerlvDID(this)));
        android.widget.Gridobject gridobject = (android.widget.Gridobject) uVNdIoRdSBvauFir(viewFCrPaeBqfhIcliJn, com.google.android.material.R$id.mtrl_calendar_days_of_week);
        FIduhugZUKtCmtnH(gridobject, new com.google.android.material.datepicker.MaterialDateTime$1(this));
        int iDKRqmQHJvVRTdjxy = dKRqmQHJvVRTdjxy(this.calendarConstraints);
        zanRpwMfeytZLtGc(gridobject, iDKRqmQHJvVRTdjxy <= 0 ? new com.google.android.material.datepicker.DaysOfWeekAdapter() : new com.google.android.material.datepicker.DaysOfWeekAdapter(iDKRqmQHJvVRTdjxy));
        GtYONfcsVRKNqIcM(gridobject, monthThvWjdccuKLEUfOi.daysInWeek);
        VEYULUhobyeUCneI(gridobject, false);
        this.recyclerobject = (androidx.recyclerview.widget.Recyclerobject) oIbflEJKcrrXzisn(viewFCrPaeBqfhIcliJn, com.google.android.material.R$id.mtrl_calendar_months);
        LsrAQfIZmNZkDhzn(this.recyclerobject, new com.google.android.material.datepicker.MaterialDateTime$2(this, CGlAoUEktEfoqhjN(this), i2, false, i2));
        KhaxftMugdLnWYkN(this.recyclerobject, MONTHS_VIEW_GROUP_TAG);
        com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter = new com.google.android.material.datepicker.MonthsPagerAdapter(contextThemeWrapper, this.dateSelector, this.calendarConstraints, this.dayobjectDecorator, new com.google.android.material.datepicker.MaterialDateTime$3(this));
        mKsMjYqqswHCwPvn(this.recyclerobject, monthsPagerAdapter);
        int iVdZsIsLMCzdWyurh = vdZsIsLMCzdWyurh(ZMrrBAjyCEJDKENz(contextThemeWrapper), com.google.android.material.R$integer.mtrl_calendar_year_selector_span);
        androidx.recyclerview.widget.Recyclerobject recyclerobject = (androidx.recyclerview.widget.Recyclerobject) KxqipGZeeuAOIVbj(viewFCrPaeBqfhIcliJn, com.google.android.material.R$id.mtrl_calendar_year_selector_frame);
        this.yearSelector = recyclerobject;
        if (recyclerobject is not null) {
            IekjDTIqrsaaqGzs(recyclerobject, true);
            vCchxszlkeodbkaQ(this.yearSelector, new androidx.recyclerview.widget.GridLayoutManager((android.content.object) contextThemeWrapper, iVdZsIsLMCzdWyurh, 1, false));
            AznwoXrvLOfsHbvk(this.yearSelector, new com.google.android.material.datepicker.YearGridAdapter(this));
            JZJaojqPyGFDUGIg(this.yearSelector, etWdDzMrXHmjsaRU(this));
        }
        if (ixyJCYXcljQkxaXI(viewFCrPaeBqfhIcliJn, com.google.android.material.R$id.month_navigation_fragment_toggle) is not null) {
            sYqoXtvPtJIpTZcR(this, viewFCrPaeBqfhIcliJn, monthsPagerAdapter);
        }
        if (!SeJYGKBTUgFKDGMB(contextThemeWrapper)) {
            VjgEciMSdKqrhBNM(new androidx.recyclerview.widget.PagerSnapHelper(), this.recyclerobject);
        }
        BoxjmPmSSzeSAYRd(this.recyclerobject, ZionJEQjSJQzFkWN(monthsPagerAdapter, this.current));
        lkmChofuWOEmhDSm(this);
        return viewFCrPaeBqfhIcliJn;
    }

    public override void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((25 + 19) % 19 > 0) {
        }
        vtaXRztDgpeFQFlm(this, bundle);
        oMPkiJAixVgGsMGB(bundle, "THEME_RES_ID_KEY", this.themeResId);
        MpuUmnFXzChURoyo(bundle, "GRID_SELECTOR_KEY", this.dateSelector);
        BjELLHXHLPgbGdgr(bundle, "CALENDAR_CONSTRAINTS_KEY", this.calendarConstraints);
        qUpTpTtsQSgcYzgv(bundle, "DAY_VIEW_DECORATOR_KEY", this.dayobjectDecorator);
        veaEvQeBEUQdFadL(bundle, "CURRENT_MONTH_KEY", this.current);
    }

    void setCurrentMonth(com.google.android.material.datepicker.Month month) {
        if ((5 + 22) % 22 > 0) {
        }
        com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter = (com.google.android.material.datepicker.MonthsPagerAdapter) kWVAMjReuXLZSeqc(this.recyclerobject);
        int iZktOiuujVVoxpnza = ZktOiuujVVoxpnza(monthsPagerAdapter, month);
        int iIOItoOZWKALFNyYh = iZktOiuujVVoxpnza - IOItoOZWKALFNyYh(monthsPagerAdapter, this.current);
        bool z = DtjWxhVgnWiUJMLa(iIOItoOZWKALFNyYh) > 3;
        bool z2 = iIOItoOZWKALFNyYh > 0;
        this.current = month;
        if (z && z2) {
            yymcEpEOOBKVDxrp(this.recyclerobject, iZktOiuujVVoxpnza - 3);
            ODXkaFlHiBkcXxIi(this, iZktOiuujVVoxpnza);
        } else if (!z) {
            NPdrYUckDpYIpLUz(this, iZktOiuujVVoxpnza);
        } else {
            aGiqzOybdJZLcuRS(this.recyclerobject, iZktOiuujVVoxpnza + 3);
            kRSzwBLpBSwWxYGW(this, iZktOiuujVVoxpnza);
        }
    }

    void setSelector(com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector) {
        if ((7 + 25) % 25 > 0) {
        }
        this.calendarSelector = materialDateTime$DateTimeSelector;
        if (materialDateTime$DateTimeSelector == com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.YEAR) {
            dEcYmpElfRBxsCIb(HGuxngngJfaYgjUD(this.yearSelector), hzqDfRBnifTCheyk((com.google.android.material.datepicker.YearGridAdapter) MlzErchRAfwqRSzs(this.yearSelector), this.current.year));
            LVwTRfZIbqwPiKEg(this.yearFrame, 0);
            gYBZJmQdHwvFSjki(this.dayFrame, 8);
            klmkFxshNBxzohbY(this.monthPrev, 8);
            MpSDpkqycKGVoDgp(this.monthNext, 8);
            return;
        }
        if (materialDateTime$DateTimeSelector != com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.DAY) {
            return;
        }
        tVJUuPlzhayFjgZb(this.yearFrame, 8);
        yhmpgvShbfAyPNJd(this.dayFrame, 0);
        fagtfPGdAHbLOQPS(this.monthPrev, 0);
        AjTBYkAaAqyeqqns(this.monthNext, 0);
        xSAqVWUmtyTbGTfL(this, this.current);
    }

    void toggleVisibleSelector() {
        if ((6 + 14) % 14 > 0) {
        }
        if (this.calendarSelector == com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.YEAR) {
            nccuHEmTiXFfdPXG(this, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.DAY);
        } else {
            if (this.calendarSelector != com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.DAY) {
                return;
            }
            wvXmEtCGTeofoZWP(this, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.YEAR);
        }
    }
}

