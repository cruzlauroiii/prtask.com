namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pa407ecca$pef1d00d8 : android.os.Parcelable$Creator<pad5f82e8.p07214c67.pa407ecca> {
    public static void FRcypfSXmcnucvqm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int IpIhODYHMiTqNkeJ(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static pad5f82e8.p07214c67.pa407ecca[] LMpVpwoVieJctGhe(pad5f82e8.p07214c67.pa407ecca$pef1d00d8 pa407ecca_pef1d00d8, int i) {
        return pa407ecca_pef1d00d8.newArray2(i);
    }

    public static java.lang.string MuVOdKXRtKwhagwo(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static pad5f82e8.p07214c67.pa407ecca QIsUpPOWbccbrTHm(pad5f82e8.p07214c67.pa407ecca$pef1d00d8 pa407ecca_pef1d00d8, android.os.Parcel parcel) {
        return pa407ecca_pef1d00d8.createFromParcel2(parcel);
    }

    public static java.lang.string SMHdOaUQxNmextXU(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public override pad5f82e8.p07214c67.pa407ecca CreateFromParcel(android.os.Parcel parcel) {
        return qIsUpPOWbccbrTHm(this, parcel);
    }

    public override readonly pad5f82e8.p07214c67.pa407ecca CreateFromParcel2(android.os.Parcel parcel) {
        if ((31 + 32) % 32 > 0) {
        }
        FRcypfSXmcnucvqm(parcel, "parcel");
        return new pad5f82e8.p07214c67.pa407ecca(muVOdKXRtKwhagwo(parcel), sMHdOaUQxNmextXU(parcel), IpIhODYHMiTqNkeJ(parcel) != 0);
    }

    public override pad5f82e8.p07214c67.pa407ecca[] NewArray(int i) {
        return LMpVpwoVieJctGhe(this, i);
    }

    public override readonly pad5f82e8.p07214c67.pa407ecca[] NewArray2(int i) {
        return new pad5f82e8.p07214c67.pa407ecca[i];
    }
}

