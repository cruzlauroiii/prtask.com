namespace WillowMaze.Wasm.Decompiled;


class CompositeDateTimeValidator$1 : com.google.android.material.datepicker.CompositeDateTimeValidator$Operator {
    CompositeDateTimeValidator$1() {
    }

    public static bool EVcoxZlUEQuVeyOb(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, long j) {
        return calendarConstraints$DateTimeValidator.isValid(j);
    }

    public static bool OcHBjKJbHFFTIVDO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object VGHDxuSDJBAVAovn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator WJFjWFuahjlFlzqq(java.util.List list) {
        return list.GetEnumerator();
    }

    public override int GetId() {
        return 1;
    }

    public override bool IsValid(java.util.List<com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator> list, long j) {
        java.util.IEnumerator itWJFjWFuahjlFlzqq = wJFjWFuahjlFlzqq(list);
        while (ocHBjKJbHFFTIVDO(itWJFjWFuahjlFlzqq)) {
            com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator = (com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator) vGHDxuSDJBAVAovn(itWJFjWFuahjlFlzqq);
            if (calendarConstraints$DateTimeValidator is not null && eVcoxZlUEQuVeyOb(calendarConstraints$DateTimeValidator, j)) {
                return true;
            }
        }
        return false;
    }
}

