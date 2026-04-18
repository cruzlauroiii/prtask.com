namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pf447ac85$pef1d00d8 : android.os.Parcelable$Creator<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> {
    public static java.lang.string RaFgerUoUENuyiWK(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static int XTrCaCgcBhsZUcwI(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 CUuTCpIBeGOTkQTY(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85$pef1d00d8 pf447ac85_pef1d00d8, android.os.Parcel parcel) {
        return pf447ac85_pef1d00d8.createFromParcel2(parcel);
    }

    public static void DZZdyTraJkkcYlRt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.p83f5c3ad.pf447ac85[] HpDBfYrLaZZmwmiZ(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85$pef1d00d8 pf447ac85_pef1d00d8, int i) {
        return pf447ac85_pef1d00d8.newArray2(i);
    }

    public override pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 CreateFromParcel(android.os.Parcel parcel) {
        return cUuTCpIBeGOTkQTY(this, parcel);
    }

    public override readonly pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 CreateFromParcel2(android.os.Parcel parcel) {
        dZZdyTraJkkcYlRt(parcel, "parcel");
        return new pad5f82e8.p07214c67.p83f5c3ad.pf447ac85(XTrCaCgcBhsZUcwI(parcel), RaFgerUoUENuyiWK(parcel));
    }

    public override pad5f82e8.p07214c67.p83f5c3ad.pf447ac85[] NewArray(int i) {
        return hpDBfYrLaZZmwmiZ(this, i);
    }

    public override readonly pad5f82e8.p07214c67.p83f5c3ad.pf447ac85[] NewArray2(int i) {
        return new pad5f82e8.p07214c67.p83f5c3ad.pf447ac85[i];
    }
}

