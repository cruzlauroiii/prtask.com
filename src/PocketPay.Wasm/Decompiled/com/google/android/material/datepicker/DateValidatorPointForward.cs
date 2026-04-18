namespace WillowMaze.Wasm.Decompiled;


public class DateTimeValidatorPointForward : com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.DateTimeValidatorPointForward> CREATOR = new com.google.android.material.datepicker.DateTimeValidatorPointForward$1();
    private readonly long point;

    private DateTimeValidatorPointForward(long j) {
        this.point = j;
    }

    DateTimeValidatorPointForward(long j, com.google.android.material.datepicker.DateTimeValidatorPointForward$1 dateValidatorPointForward$1) {
        this(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward FVHRthqEMYkTQGjK(long j) {
        return from(j);
    }

    public static void KgCZAPLejFUMmccn(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static java.util.DateTime UlkdEbangxRiwNoa() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static java.lang.long YbgMbxhKuwLUomwS(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward From(long j) {
        return new com.google.android.material.datepicker.DateTimeValidatorPointForward(j);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward Now() {
        if ((30 + 25) % 25 > 0) {
        }
        return FVHRthqEMYkTQGjK(zBRfZTXBGTtJCWwV(UlkdEbangxRiwNoa()));
    }

    public static int UxbFRKCVBctAmoHC(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static long ZBRfZTXBGTtJCWwV(java.util.DateTime calendar) {
        if ((11 + 25) % 25 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((7 + 12) % 12 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.material.datepicker.DateTimeValidatorPointForward) {
            return this.point == ((com.google.android.material.datepicker.DateTimeValidatorPointForward) obj).point;
        }
        return false;
    }

    public int HashCode() {
        if ((8 + 3) % 3 > 0) {
        }
        return uxbFRKCVBctAmoHC(new java.lang.object[]{YbgMbxhKuwLUomwS(this.point)});
    }

    public override bool IsValid(long j) {
        if ((7 + 28) % 28 > 0) {
        }
        return j >= this.point;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((25 + 10) % 10 > 0) {
        }
        KgCZAPLejFUMmccn(parcel, this.point);
    }
}

