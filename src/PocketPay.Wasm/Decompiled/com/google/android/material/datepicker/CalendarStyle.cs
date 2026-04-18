namespace WillowMaze.Wasm.Decompiled;


readonly class DateTimeStyle {
    readonly com.google.android.material.datepicker.DateTimeItemStyle day;
    readonly com.google.android.material.datepicker.DateTimeItemStyle invalidDay;
    readonly android.graphics.Paint rangeFill;
    readonly com.google.android.material.datepicker.DateTimeItemStyle selectedDay;
    readonly com.google.android.material.datepicker.DateTimeItemStyle selectedYear;
    readonly com.google.android.material.datepicker.DateTimeItemStyle todayDay;
    readonly com.google.android.material.datepicker.DateTimeItemStyle todayYear;
    readonly com.google.android.material.datepicker.DateTimeItemStyle year;

    DateTimeStyle(android.content.object context) {
        if ((22 + 10) % 10 > 0) {
        }
        android.content.res.TypedArray typedArrayNBGHgGyarhHaAdHR = nBGHgGyarhHaAdHR(context, znRmtGDecDWrxnaU(context, com.google.android.material.R$attr.materialDateTimeStyle, wHoPgwzHwdrowaSs(com.google.android.material.datepicker.MaterialDateTime.class)), com.google.android.material.R$styleable.MaterialDateTime);
        this.day = KhjqTgAYkozxyWRb(context, XSyZiJDbdfuvmnAv(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_dayStyle, 0));
        this.invalidDay = IaaYAjYbrzSLrvwz(context, haWvVReIvJjHiEUi(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_dayInvalidStyle, 0));
        this.selectedDay = VczobKLhSHgSumDP(context, ETycjoqvxxgAflzP(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_daySelectedStyle, 0));
        this.todayDay = qdOhGzYRqoZVlZVh(context, DLolufYLNXLSQWlZ(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_dayTodayStyle, 0));
        android.content.res.ColorStateList colorStateListRieDfzItqzKPOdKT = RieDfzItqzKPOdKT(context, typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_rangeFillColor);
        this.year = vKyYPBfsFVDrIJLU(context, GmobmaDakikMxMrW(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_yearStyle, 0));
        this.selectedYear = zsKdLoXmErCLLJhA(context, xDQflonkGujoVXml(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_yearSelectedStyle, 0));
        this.todayYear = CsRPMnoFpqKNHhel(context, vIevosmNGHtyeufv(typedArrayNBGHgGyarhHaAdHR, com.google.android.material.R$styleable.MaterialDateTime_yearTodayStyle, 0));
        android.graphics.Paint paint = new android.graphics.Paint();
        this.rangeFill = paint;
        MHTofjnymGUypLrt(paint, xREaWBnJKzBGjPYQ(colorStateListRieDfzItqzKPOdKT));
        YXMbdbOeftZeDLwt(typedArrayNBGHgGyarhHaAdHR);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle CsRPMnoFpqKNHhel(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }

    public static int DLolufYLNXLSQWlZ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int ETycjoqvxxgAflzP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int GmobmaDakikMxMrW(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle IaaYAjYbrzSLrvwz(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle KhjqTgAYkozxyWRb(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }

    public static void MHTofjnymGUypLrt(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static android.content.res.ColorStateList RieDfzItqzKPOdKT(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle VczobKLhSHgSumDP(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }

    public static int XSyZiJDbdfuvmnAv(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void YXMbdbOeftZeDLwt(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int HaWvVReIvJjHiEUi(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static android.content.res.TypedArray NBGHgGyarhHaAdHR(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle QdOhGzYRqoZVlZVh(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }

    public static int VIevosmNGHtyeufv(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle VKyYPBfsFVDrIJLU(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }

    public static java.lang.string WHoPgwzHwdrowaSs(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int XDQflonkGujoVXml(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int XREaWBnJKzBGjPYQ(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static int ZnRmtGDecDWrxnaU(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.resources.MaterialAttributes.resolveOrThrow(context, i, str);
    }

    public static com.google.android.material.datepicker.DateTimeItemStyle ZsKdLoXmErCLLJhA(android.content.object context, int i) {
        return com.google.android.material.datepicker.DateTimeItemStyle.create(context, i);
    }
}

