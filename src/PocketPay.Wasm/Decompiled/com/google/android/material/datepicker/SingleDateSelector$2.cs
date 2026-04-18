namespace WillowMaze.Wasm.Decompiled;


class SingleDateTimeSelector$2 : android.os.Parcelable$Creator<com.google.android.material.datepicker.SingleDateTimeSelector> {
    SingleDateTimeSelector$2() {
    }

    public static java.lang.object XGdCETcfKoDcjknV(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readValue(classLoader);
    }

    public static java.lang.ClassLoader MSPYzYAGFcnUkOXI(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static com.google.android.material.datepicker.SingleDateTimeSelector[] MakcGubrVzbjDXqF(com.google.android.material.datepicker.SingleDateTimeSelector$2 singleDateTimeSelector$2, int i) {
        return singleDateTimeSelector$2.newArray(i);
    }

    public static com.google.android.material.datepicker.SingleDateTimeSelector NJRJCiqMWZBJkohp(com.google.android.material.datepicker.SingleDateTimeSelector$2 singleDateTimeSelector$2, android.os.Parcel parcel) {
        return singleDateTimeSelector$2.createFromParcel(parcel);
    }

    public static java.lang.long YbAWXHzyNmoGicef(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.SingleDateTimeSelector.access$202(singleDateTimeSelector, l);
    }

    public override com.google.android.material.datepicker.SingleDateTimeSelector CreateFromParcel(android.os.Parcel parcel) {
        com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector = new com.google.android.material.datepicker.SingleDateTimeSelector();
        ybAWXHzyNmoGicef(singleDateTimeSelector, (java.lang.long) XGdCETcfKoDcjknV(parcel, mSPYzYAGFcnUkOXI(java.lang.long.class)));
        return singleDateTimeSelector;
    }

    public override com.google.android.material.datepicker.SingleDateTimeSelector CreateFromParcel(android.os.Parcel parcel) {
        return nJRJCiqMWZBJkohp(this, parcel);
    }

    public override com.google.android.material.datepicker.SingleDateTimeSelector[] NewArray(int i) {
        return new com.google.android.material.datepicker.SingleDateTimeSelector[i];
    }

    public override com.google.android.material.datepicker.SingleDateTimeSelector[] NewArray(int i) {
        return makcGubrVzbjDXqF(this, i);
    }
}

