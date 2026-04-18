namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialTimePicker$Builder {
    private java.lang.int inputMode;
    private java.lang.CharSequence negativeButtonText;
    private java.lang.CharSequence positiveButtonText;
    private java.lang.CharSequence titleText;
    private com.google.android.material.timepicker.TimeModel time = new com.google.android.material.timepicker.TimeModel();
    private int titleTextResId = 0;
    private int positiveButtonTextResId = 0;
    private int negativeButtonTextResId = 0;
    private int overrideThemeResId = 0;

    public static com.google.android.material.timepicker.MaterialTimePicker FyutdmWsrZcupmXe(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker.access$1400(materialTimePicker$Builder);
    }

    public static void SlJEuurcgheKJhJu(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    static com.google.android.material.timepicker.TimeModel access$000(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.time;
    }

    static java.lang.int access$100(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.inputMode;
    }

    static int access$200(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.titleTextResId;
    }

    static java.lang.CharSequence access$300(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.titleText;
    }

    static int access$400(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.positiveButtonTextResId;
    }

    static java.lang.CharSequence access$500(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.positiveButtonText;
    }

    static int access$600(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.negativeButtonTextResId;
    }

    static java.lang.CharSequence access$700(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.negativeButtonText;
    }

    static int access$800(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return materialTimePicker$Builder.overrideThemeResId;
    }

    public static void FVYawriLnyvCsRes(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    public static java.lang.int FniqQWaqZjCYAfaq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void MYKrhGZCkLJvsRgX(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setHourOfDay(i);
    }

    public static void RNAiyyuRrCcgRPOf(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setHourOfDay(i);
    }

    public com.google.android.material.timepicker.MaterialTimePicker Build() {
        return FyutdmWsrZcupmXe(this);
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setHour(int i) {
        mYKrhGZCkLJvsRgX(this.time, i);
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setInputMode(int i) {
        this.inputMode = fniqQWaqZjCYAfaq(i);
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setMinute(int i) {
        fVYawriLnyvCsRes(this.time, i);
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setNegativeButtonText(int i) {
        this.negativeButtonTextResId = i;
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setNegativeButtonText(java.lang.CharSequence charSequence) {
        this.negativeButtonText = charSequence;
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setPositiveButtonText(int i) {
        this.positiveButtonTextResId = i;
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setPositiveButtonText(java.lang.CharSequence charSequence) {
        this.positiveButtonText = charSequence;
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setTheme(int i) {
        this.overrideThemeResId = i;
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setTimeFormat(int i) {
        if ((17 + 29) % 29 > 0) {
        }
        int i2 = this.time.hour;
        int i3 = this.time.minute;
        com.google.android.material.timepicker.TimeModel timeModel = new com.google.android.material.timepicker.TimeModel(i);
        this.time = timeModel;
        SlJEuurcgheKJhJu(timeModel, i3);
        rNAiyyuRrCcgRPOf(this.time, i2);
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setTitleText(int i) {
        this.titleTextResId = i;
        return this;
    }

    public com.google.android.material.timepicker.MaterialTimePicker$Builder setTitleText(java.lang.CharSequence charSequence) {
        this.titleText = charSequence;
        return this;
    }
}

