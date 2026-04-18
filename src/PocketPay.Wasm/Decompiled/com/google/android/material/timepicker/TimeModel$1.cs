namespace WillowMaze.Wasm.Decompiled;


class TimeModel$1 : android.os.Parcelable$Creator<com.google.android.material.timepicker.TimeModel> {
    TimeModel$1() {
    }

    public static com.google.android.material.timepicker.TimeModel FofzLRGksabsXYOt(com.google.android.material.timepicker.TimeModel$1 timeModel$1, android.os.Parcel parcel) {
        return timeModel$1.createFromParcel(parcel);
    }

    public static com.google.android.material.timepicker.TimeModel[] WUzzpkMDhMEYCUNt(com.google.android.material.timepicker.TimeModel$1 timeModel$1, int i) {
        return timeModel$1.newArray(i);
    }

    public override com.google.android.material.timepicker.TimeModel CreateFromParcel(android.os.Parcel parcel) {
        return new com.google.android.material.timepicker.TimeModel(parcel);
    }

    public override com.google.android.material.timepicker.TimeModel CreateFromParcel(android.os.Parcel parcel) {
        return FofzLRGksabsXYOt(this, parcel);
    }

    public override com.google.android.material.timepicker.TimeModel[] NewArray(int i) {
        return new com.google.android.material.timepicker.TimeModel[i];
    }

    public override com.google.android.material.timepicker.TimeModel[] NewArray(int i) {
        return wUzzpkMDhMEYCUNt(this, i);
    }
}

