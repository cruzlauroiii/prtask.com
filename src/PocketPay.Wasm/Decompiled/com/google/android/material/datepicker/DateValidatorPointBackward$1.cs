namespace WillowMaze.Wasm.Decompiled;


class DateTimeValidatorPointBackward$1 : android.os.Parcelable$Creator<com.google.android.material.datepicker.DateTimeValidatorPointBackward> {
    DateTimeValidatorPointBackward$1() {
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointBackward BdqtiYwXSwDSoztm(com.google.android.material.datepicker.DateTimeValidatorPointBackward$1 dateValidatorPointBackward$1, android.os.Parcel parcel) {
        return dateValidatorPointBackward$1.createFromParcel(parcel);
    }

    public static long KXJxsXVcaivaZEVz(android.os.Parcel parcel) {
        if ((8 + 28) % 28 > 0) {
        }
        return parcel.readlong();
    }

    public static com.google.android.material.datepicker.DateTimeValidatorPointBackward[] ZkjPdcDqHtZgnakC(com.google.android.material.datepicker.DateTimeValidatorPointBackward$1 dateValidatorPointBackward$1, int i) {
        return dateValidatorPointBackward$1.newArray(i);
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointBackward CreateFromParcel(android.os.Parcel parcel) {
        if ((12 + 16) % 16 > 0) {
        }
        return new com.google.android.material.datepicker.DateTimeValidatorPointBackward(KXJxsXVcaivaZEVz(parcel), null);
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointBackward CreateFromParcel(android.os.Parcel parcel) {
        return BdqtiYwXSwDSoztm(this, parcel);
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointBackward[] NewArray(int i) {
        return new com.google.android.material.datepicker.DateTimeValidatorPointBackward[i];
    }

    public override com.google.android.material.datepicker.DateTimeValidatorPointBackward[] NewArray(int i) {
        return zkjPdcDqHtZgnakC(this, i);
    }
}

