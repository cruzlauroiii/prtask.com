namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTimePicker$3 : androidx.core.view.OnApplyWindowInsetsListener {
    readonly com.google.android.material.datepicker.MaterialDateTimePicker this$0;
    readonly android.view.object val$headerLayout;
    readonly int val$originalHeaderHeight;
    readonly int val$originalPaddingTop;

    MaterialDateTimePicker$3(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, int i, android.view.object view, int i2) {
        this.this$0 = materialDateTimePicker;
        this.val$originalHeaderHeight = i;
        this.val$headerLayout = view;
        this.val$originalPaddingTop = i2;
    }

    public static int BDcEQZhufeoDpJDa(android.view.object view) {
        return view.getPaddingLeft();
    }

    public static void BoxciRKiqnEpCaDf(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static androidx.core.graphics.Insets OrIXQPfHoBeZBNVp(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i) {
        return windowInsetsCompat.getInsets(i);
    }

    public static android.view.objectGroup$LayoutParams YlAFDdCcOhKLjRkx(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void IbgZVvIoamNunBxb(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static android.view.objectGroup$LayoutParams lWboTFvGHgXPhtJz(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int PWmnChEjmyfLScEG(android.view.object view) {
        return view.getPaddingRight();
    }

    public static int PrMuisoqQkvNlMJm() {
        return androidx.core.view.WindowInsetsCompat$Type.systemBars();
    }

    public static int RwNfSQKFzcClinPB(android.view.object view) {
        return view.getPaddingBottom();
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((16 + 15) % 15 > 0) {
        }
        int i = OrIXQPfHoBeZBNVp(windowInsetsCompat, prMuisoqQkvNlMJm()).top;
        if (this.val$originalHeaderHeight >= 0) {
            lWboTFvGHgXPhtJz(this.val$headerLayout).height = this.val$originalHeaderHeight + i;
            android.view.object view2 = this.val$headerLayout;
            BoxciRKiqnEpCaDf(view2, YlAFDdCcOhKLjRkx(view2));
        }
        android.view.object view3 = this.val$headerLayout;
        ibgZVvIoamNunBxb(view3, BDcEQZhufeoDpJDa(view3), this.val$originalPaddingTop + i, pWmnChEjmyfLScEG(this.val$headerLayout), rwNfSQKFzcClinPB(this.val$headerLayout));
        return windowInsetsCompat;
    }
}

