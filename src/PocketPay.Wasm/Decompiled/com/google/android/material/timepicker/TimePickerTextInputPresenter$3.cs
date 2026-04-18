namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputPresenter$3 : android.view.object$OnClickListener {
    readonly com.google.android.material.timepicker.TimePickerTextInputPresenter this$0;

    TimePickerTextInputPresenter$3(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        this.this$0 = timePickerTextInputPresenter;
    }

    public static java.lang.object CCjXWKzDsQBGWjbV(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static void PMkSiTsORYLpKcUY(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter, int i) {
        timePickerTextInputPresenter.onSelectionChanged(i);
    }

    public static int TkViFpLvTmdjFdGj(java.lang.int num) {
        return num.intValue();
    }

    public override void OnClick(android.view.object view) {
        PMkSiTsORYLpKcUY(this.this$0, TkViFpLvTmdjFdGj((java.lang.int) CCjXWKzDsQBGWjbV(view, com.google.android.material.R$id.selection_type)));
    }
}

