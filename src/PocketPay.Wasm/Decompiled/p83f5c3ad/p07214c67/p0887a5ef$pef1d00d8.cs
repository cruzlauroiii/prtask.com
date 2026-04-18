namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p0887a5ef$pef1d00d8 : android.os.Parcelable$Creator<p83f5c3ad.p07214c67.p0887a5ef> {
    public override p83f5c3ad.p07214c67.p0887a5ef CreateFromParcel(android.os.Parcel parcel) {
        return createFromParcel2(parcel);
    }

    public override readonly p83f5c3ad.p07214c67.p0887a5ef CreateFromParcel2(android.os.Parcel parcel) {
        if ((13 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        return new p83f5c3ad.p07214c67.p0887a5ef(parcel.readInt(), parcel.readstring(), parcel.readstring());
    }

    public override p83f5c3ad.p07214c67.p0887a5ef[] NewArray(int i) {
        return newArray2(i);
    }

    public override readonly p83f5c3ad.p07214c67.p0887a5ef[] NewArray2(int i) {
        return new p83f5c3ad.p07214c67.p0887a5ef[i];
    }
}

