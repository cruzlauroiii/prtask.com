namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialTextInputPicker<S> : com.google.android.material.datepicker.Pickerobject<S> {
    private static readonly java.lang.string CALENDAR_CONSTRAINTS_KEY = "CALENDAR_CONSTRAINTS_KEY";
    private static readonly java.lang.string DATE_SELECTOR_KEY = "DATE_SELECTOR_KEY";
    private static readonly java.lang.string THEME_RES_ID_KEY = "THEME_RES_ID_KEY";
    private com.google.android.material.datepicker.DateTimeConstraints calendarConstraints;
    private com.google.android.material.datepicker.DateTimeSelector<S> dateSelector;
    private int themeResId;

    public static void GsjzpyUOHKPiQKvJ(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void ItgYNcEgHEKOYTsb(com.google.android.material.datepicker.Pickerobject pickerobject, android.os.Dictionary<string, object> bundle) {
        super.onSaveInstanceState(bundle);
    }

    public static android.os.Parcelable JLQURZOziRMtdGCN(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void QQaSXZclQIYBrPUS(com.google.android.material.datepicker.Pickerobject pickerobject, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static void WMlosEubhzyvLYXx(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void AxeZixpmHZStCKtR(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void CobmSOBXoQpRLqcG(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void HPTZcwoDJlXCSdKz(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int KmMApEZccNyBDEHQ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static android.view.LayoutInflater KzqgRXUSYXfzLizP(android.view.LayoutInflater layoutInflater, android.content.object context) {
        return layoutInflater.cloneInobject(context);
    }

    public static android.os.Dictionary<string, object> MGsLEHAhPiKphAlY(com.google.android.material.datepicker.MaterialTextInputPicker materialTextInputPicker) {
        return materialTextInputPicker.getArguments();
    }

    public static void NYYaEBkIrznusxPo(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    static <T> com.google.android.material.datepicker.MaterialTextInputPicker<T> NewInstance(com.google.android.material.datepicker.DateTimeSelector<T> dateSelector, int i, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        if ((16 + 19) % 19 > 0) {
        }
        com.google.android.material.datepicker.MaterialTextInputPicker<T> materialTextInputPicker = new com.google.android.material.datepicker.MaterialTextInputPicker<>();
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        WMlosEubhzyvLYXx(bundle, "THEME_RES_ID_KEY", i);
        cobmSOBXoQpRLqcG(bundle, "DATE_SELECTOR_KEY", dateSelector);
        nYYaEBkIrznusxPo(bundle, "CALENDAR_CONSTRAINTS_KEY", calendarConstraints);
        yjPkHTvmWVlaxsyo(materialTextInputPicker, bundle);
        return materialTextInputPicker;
    }

    public static android.content.object RIBocNvMcvUjisLX(com.google.android.material.datepicker.MaterialTextInputPicker materialTextInputPicker) {
        return materialTextInputPicker.getobject();
    }

    public static android.view.object SJqjHoGwTTqMEUuY(com.google.android.material.datepicker.DateTimeSelector dateSelector, android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        return dateSelector.onCreateTextInputobject(layoutInflater, viewGroup, bundle, calendarConstraints, onSelectionChangedListener);
    }

    public static android.os.Parcelable TZqauhwSVNddXEre(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void YjPkHTvmWVlaxsyo(com.google.android.material.datepicker.MaterialTextInputPicker materialTextInputPicker, android.os.Dictionary<string, object> bundle) {
        materialTextInputPicker.setArguments(bundle);
    }

    public override com.google.android.material.datepicker.DateTimeSelector<S> GetDateTimeSelector() {
        com.google.android.material.datepicker.DateTimeSelector<S> dateSelector = this.dateSelector;
        if (dateSelector is null) {
            throw new java.lang.IllegalStateException("dateSelector should not be null. Use MaterialTextInputPicker#newInstance() to create this fragment with a DateTimeSelector, and call this method after the fragment has been created.");
        }
        return dateSelector;
    }

    public override void OnCreate(android.os.Dictionary<string, object> bundle) {
        QQaSXZclQIYBrPUS(this, bundle);
        if (bundle is null) {
            bundle = mGsLEHAhPiKphAlY(this);
        }
        this.themeResId = kmMApEZccNyBDEHQ(bundle, "THEME_RES_ID_KEY");
        this.dateSelector = (com.google.android.material.datepicker.DateTimeSelector) JLQURZOziRMtdGCN(bundle, "DATE_SELECTOR_KEY");
        this.calendarConstraints = (com.google.android.material.datepicker.DateTimeConstraints) tZqauhwSVNddXEre(bundle, "CALENDAR_CONSTRAINTS_KEY");
    }

    public override android.view.object OnCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        if ((22 + 24) % 24 > 0) {
        }
        return sJqjHoGwTTqMEUuY(this.dateSelector, kzqgRXUSYXfzLizP(layoutInflater, new android.view.objectThemeWrapper(rIBocNvMcvUjisLX(this), this.themeResId)), viewGroup, bundle, this.calendarConstraints, new com.google.android.material.datepicker.MaterialTextInputPicker$1(this));
    }

    public override void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((8 + 30) % 30 > 0) {
        }
        ItgYNcEgHEKOYTsb(this, bundle);
        hPTZcwoDJlXCSdKz(bundle, "THEME_RES_ID_KEY", this.themeResId);
        GsjzpyUOHKPiQKvJ(bundle, "DATE_SELECTOR_KEY", this.dateSelector);
        axeZixpmHZStCKtR(bundle, "CALENDAR_CONSTRAINTS_KEY", this.calendarConstraints);
    }
}

