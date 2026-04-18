namespace WillowMaze.Wasm.Decompiled;


public readonly class CompositeDateTimeValidator : com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator {
    private static readonly int COMPARATOR_ALL_ID = 2;
    private static readonly int COMPARATOR_ANY_ID = 1;
    private readonly com.google.android.material.datepicker.CompositeDateTimeValidator$Operator operator;
    private readonly java.util.List<com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator> validators;
    private static readonly com.google.android.material.datepicker.CompositeDateTimeValidator$Operator ANY_OPERATOR = new com.google.android.material.datepicker.CompositeDateTimeValidator$1();
    private static readonly com.google.android.material.datepicker.CompositeDateTimeValidator$Operator ALL_OPERATOR = new com.google.android.material.datepicker.CompositeDateTimeValidator$2();
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.CompositeDateTimeValidator> CREATOR = new com.google.android.material.datepicker.CompositeDateTimeValidator$3();

    private CompositeDateTimeValidator(java.util.List<com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator> list, com.google.android.material.datepicker.CompositeDateTimeValidator$Operator compositeDateTimeValidator$Operator) {
        this.validators = list;
        this.operator = compositeDateTimeValidator$Operator;
    }

    CompositeDateTimeValidator(java.util.List list, com.google.android.material.datepicker.CompositeDateTimeValidator$Operator compositeDateTimeValidator$Operator, com.google.android.material.datepicker.CompositeDateTimeValidator$1 compositeDateTimeValidator$1) {
        this(list, compositeDateTimeValidator$Operator);
    }

    public static int CRbkbULxqLpakSsR(com.google.android.material.datepicker.CompositeDateTimeValidator$Operator compositeDateTimeValidator$Operator) {
        return compositeDateTimeValidator$Operator.getId();
    }

    public static int IhhxjJTQNhKYVBIR(com.google.android.material.datepicker.CompositeDateTimeValidator$Operator compositeDateTimeValidator$Operator) {
        return compositeDateTimeValidator$Operator.getId();
    }

    public static bool VjxGCUTVVAMhzIfN(com.google.android.material.datepicker.CompositeDateTimeValidator$Operator compositeDateTimeValidator$Operator, java.util.List list, long j) {
        return compositeDateTimeValidator$Operator.isValid(list, j);
    }

    static com.google.android.material.datepicker.CompositeDateTimeValidator$Operator access$000() {
        return ALL_OPERATOR;
    }

    static com.google.android.material.datepicker.CompositeDateTimeValidator$Operator access$100() {
        return ANY_OPERATOR;
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator allOf(java.util.List<com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator> list) {
        if ((10 + 13) % 13 > 0) {
        }
        return new com.google.android.material.datepicker.CompositeDateTimeValidator(list, ALL_OPERATOR);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator anyOf(java.util.List<com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator> list) {
        if ((14 + 18) % 18 > 0) {
        }
        return new com.google.android.material.datepicker.CompositeDateTimeValidator(list, ANY_OPERATOR);
    }

    public static int FfolqDxfPkqCiusS(com.google.android.material.datepicker.CompositeDateTimeValidator$Operator compositeDateTimeValidator$Operator) {
        return compositeDateTimeValidator$Operator.getId();
    }

    public static int GBSvjKNHUkWeiEsg(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool HPscgWZJrPYNTaYD(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void QGZuZSptmsLBvdOq(android.os.Parcel parcel, java.util.List list) {
        parcel.writeList(list);
    }

    public static void TtCzhUwPyWRgvTmL(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((31 + 10) % 10 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.material.datepicker.CompositeDateTimeValidator)) {
            return false;
        }
        com.google.android.material.datepicker.CompositeDateTimeValidator compositeDateTimeValidator = (com.google.android.material.datepicker.CompositeDateTimeValidator) obj;
        return hPscgWZJrPYNTaYD(this.validators, compositeDateTimeValidator.validators) && ffolqDxfPkqCiusS(this.operator) == IhhxjJTQNhKYVBIR(compositeDateTimeValidator.operator);
    }

    public int HashCode() {
        return gBSvjKNHUkWeiEsg(this.validators);
    }

    public override bool IsValid(long j) {
        return VjxGCUTVVAMhzIfN(this.operator, this.validators, j);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        qGZuZSptmsLBvdOq(parcel, this.validators);
        ttCzhUwPyWRgvTmL(parcel, CRbkbULxqLpakSsR(this.operator));
    }
}

