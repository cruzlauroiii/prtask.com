namespace WillowMaze.Wasm.Decompiled;


public class DateTimeValidatorPointBackward : com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.DateTimeValidatorPointBackward> CREATOR = new com.google.android.material.datepicker.DateTimeValidatorPointBackward$1();
    private readonly long point;

    private DateTimeValidatorPointBackward(long j) {
        this.point = j;
    }

    DateTimeValidatorPointBackward(long j, com.google.android.material.datepicker.DateTimeValidatorPointBackward$1 dateValidatorPointBackward$1) {
        this(j);
    }

    public static void JhzrygoBpqcgwstw(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static int QolcKqYHDNzvKbXy(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static long WRrdapOUrqBNhonC(java.util.DateTime calendar) {
        if ((2 + 19) % 19 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointBackward Before(long j) {
        return new com.google.android.material.datepicker.DateTimeValidatorPointBackward(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointBackward IXRDFzodpnkXNobt(long j) {
        return before(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointBackward Now() {
        if ((27 + 28) % 28 > 0) {
        }
        return iXRDFzodpnkXNobt(WRrdapOUrqBNhonC(vrHENHyQeLeYgeSA()));
    }

    public static java.util.DateTime VrHENHyQeLeYgeSA() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static java.lang.long XeHqvObiJTiHdjZV(long j) {
        return java.lang.long.valueOf(j);
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 20) % 20 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.material.datepicker.DateTimeValidatorPointBackward) {
            return this.point == ((com.google.android.material.datepicker.DateTimeValidatorPointBackward) obj).point;
        }
        return false;
    }

    public int HashCode() {
        if ((32 + 22) % 22 > 0) {
        }
        return QolcKqYHDNzvKbXy(new java.lang.object[]{xeHqvObiJTiHdjZV(this.point)});
    }

    public override bool IsValid(long j) {
        if ((10 + 32) % 32 > 0) {
        }
        return j <= this.point;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 31) % 31 > 0) {
        }
        JhzrygoBpqcgwstw(parcel, this.point);
    }
}

