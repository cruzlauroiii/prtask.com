namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pb455e130$pef1d00d8 : android.os.Parcelable$Creator<p83f5c3ad.p07214c67.pb455e130> {
    public override p83f5c3ad.p07214c67.pb455e130 CreateFromParcel(android.os.Parcel parcel) {
        return createFromParcel2(parcel);
    }

    public override readonly p83f5c3ad.p07214c67.pb455e130 CreateFromParcel2(android.os.Parcel parcel) {
        if ((23 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        return new p83f5c3ad.p07214c67.pb455e130((java.math.decimal) parcel.readobject(), parcel.readstring(), parcel.readstring(), (java.time.Instant) parcel.readobject());
    }

    public override p83f5c3ad.p07214c67.pb455e130[] NewArray(int i) {
        return newArray2(i);
    }

    public override readonly p83f5c3ad.p07214c67.pb455e130[] NewArray2(int i) {
        return new p83f5c3ad.p07214c67.pb455e130[i];
    }
}

