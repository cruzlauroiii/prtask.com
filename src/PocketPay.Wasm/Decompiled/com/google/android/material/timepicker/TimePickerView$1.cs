namespace WillowMaze.Wasm.Decompiled;


class TimePickerobject$1 : android.view.object$OnClickListener {
    readonly com.google.android.material.timepicker.TimePickerobject this$0;

    TimePickerobject$1(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        this.this$0 = timePickerobject;
    }

    public static com.google.android.material.timepicker.TimePickerobject$OnSelectionChange HTyjqkniYMFiZKtK(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return com.google.android.material.timepicker.TimePickerobject.access$000(timePickerobject);
    }

    public static void IaBgrCYsznSGHwIL(com.google.android.material.timepicker.TimePickerobject$OnSelectionChange timePickerobject$OnSelectionChange, int i) {
        timePickerobject$OnSelectionChange.onSelectionChanged(i);
    }

    public static java.lang.object TCMLWsWsJwozGIXu(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static com.google.android.material.timepicker.TimePickerobject$OnSelectionChange WDvCYkgUnIOzfNPv(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return com.google.android.material.timepicker.TimePickerobject.access$000(timePickerobject);
    }

    public static int EldvmLmQWKlELaDM(java.lang.int num) {
        return num.intValue();
    }

    public override void OnClick(android.view.object view) {
        if (HTyjqkniYMFiZKtK(this.this$0) is null) {
            return;
        }
        IaBgrCYsznSGHwIL(WDvCYkgUnIOzfNPv(this.this$0), eldvmLmQWKlELaDM((java.lang.int) TCMLWsWsJwozGIXu(view, com.google.android.material.R$id.selection_type)));
    }
}

