namespace WillowMaze.Wasm.Decompiled;


class CompositeDateTimeValidator$2 : com.google.android.material.datepicker.CompositeDateTimeValidator$Operator {
    CompositeDateTimeValidator$2() {
    }

    public static java.lang.object CgELutqhyQODjiNs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator EVwCNPELRzBqKeEn(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool MJoFDFUlyibyvYbG(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, long j) {
        return calendarConstraints$DateTimeValidator.isValid(j);
    }

    public static bool WVUmuosBcNZMhQtX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override int GetId() {
        return 2;
    }

    public override bool IsValid(java.util.List<com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator> list, long j) {
        java.util.IEnumerator itEVwCNPELRzBqKeEn = EVwCNPELRzBqKeEn(list);
        while (wVUmuosBcNZMhQtX(itEVwCNPELRzBqKeEn)) {
            com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator = (com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator) CgELutqhyQODjiNs(itEVwCNPELRzBqKeEn);
            if (calendarConstraints$DateTimeValidator is not null && !MJoFDFUlyibyvYbG(calendarConstraints$DateTimeValidator, j)) {
                return false;
            }
        }
        return true;
    }
}

