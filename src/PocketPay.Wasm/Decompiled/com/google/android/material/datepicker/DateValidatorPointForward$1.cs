namespace WillowMaze.Wasm.Decompiled;


class DateTimeValidatorPointForward$1 : android.os.Parcelable$Creator<com.google.android.material.datepicker.DateTimeValidatorPointForward> {
    DateTimeValidatorPointForward$1() {
    }

    public static long FWEMDvTFwEBTrARq(android.os.Parcel parcel) {
        if ((27 + 18) % 18 > 0) {
        }
        return parcel.readlong();
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward OPNMrgNnrNmvSjsr(com.google.android.material.datepicker.DateTimeValidatorPointForward$1 dateValidatorPointForward$1, android.os.Parcel parcel) {
        return dateValidatorPointForward$1.createFromParcel(parcel);
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointForward[] KyqQQLUYkrpoZGvi(com.google.android.material.datepicker.DateTimeValidatorPointForward$1 dateValidatorPointForward$1, int i) {
        return dateValidatorPointForward$1.newArray(i);
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointForward CreateFromParcel(android.os.Parcel parcel) {
        if ((18 + 4) % 4 > 0) {
        }
        return new com.google.android.material.datepicker.DateTimeValidatorPointForward(FWEMDvTFwEBTrARq(parcel), null);
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointForward CreateFromParcel(android.os.Parcel parcel) {
        return OPNMrgNnrNmvSjsr(this, parcel);
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointForward[] NewArray(int i) {
        return new com.google.android.material.datepicker.DateTimeValidatorPointForward[i];
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointForward[] NewArray(int i) {
        return kyqQQLUYkrpoZGvi(this, i);
    }
}

