namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pbc0ca418$pef1d00d8 : android.os.Parcelable$Creator<p83f5c3ad.p07214c67.pbc0ca418> {
    public override p83f5c3ad.p07214c67.pbc0ca418 CreateFromParcel(android.os.Parcel parcel) {
        return createFromParcel2(parcel);
    }

    public override readonly p83f5c3ad.p07214c67.pbc0ca418 CreateFromParcel2(android.os.Parcel parcel) {
        if ((22 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        return new p83f5c3ad.p07214c67.pbc0ca418(parcel.readlong(), parcel.readstring(), parcel.readstring());
    }

    public override p83f5c3ad.p07214c67.pbc0ca418[] NewArray(int i) {
        return newArray2(i);
    }

    public override readonly p83f5c3ad.p07214c67.pbc0ca418[] NewArray2(int i) {
        return new p83f5c3ad.p07214c67.pbc0ca418[i];
    }
}

