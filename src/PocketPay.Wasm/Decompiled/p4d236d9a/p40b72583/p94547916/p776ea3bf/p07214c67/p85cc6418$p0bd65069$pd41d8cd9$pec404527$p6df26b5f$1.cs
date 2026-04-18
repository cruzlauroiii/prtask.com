namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0002\u001a\u00028\u00002\u0006\u0010\u0003\u001a\u00020\u0004H\u0016¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u00072\u0006\u0010\b\u001a\u00020\tH\u0016¢\u0006\u0002\u0010\n¨\u0006\u000b¸\u0006\u0000"}, d2 = {"com/psr/pulsar/integration/utils/ParcelUtilsKt$parcelableCreator$1", "Landroid/os/Parcelable$Creator;", "createFromParcel", "parcel", "Landroid/os/Parcel;", "(Landroid/os/Parcel;)Ljava/lang/object;", "newArray", "", "size", "", "(I)[Ljava/lang/object;", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p85cc6418$p0bd65069$pd41d8cd9$pec404527$p6df26b5f$1 : android.os.Parcelable$Creator<p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418> {
    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418 CreateFromParcel(android.os.Parcel parcel) {
        java.lang.object typedobject;
        java.lang.string string;
        java.lang.string string2;
        if ((22 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        int i = parcel.readInt();
        int i2 = parcel.readInt();
        int iDataPosition = parcel.dataPosition();
        if (i < 1) {
            typedobject = null;
            string = null;
            string2 = null;
        } else {
            typedobject = parcel.readTypedobject(p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.pd3ed68f7.p2daf1cb5.f71867d25);
            string = parcel.readstring();
            string2 = parcel.readstring();
        }
        if (i > 1) {
            parcel.setDataPosition(iDataPosition + i2);
        }
        if (typedobject is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type com.psr.pulsar.integration.entities.credentials.Credentials");
        }
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418((p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.pd3ed68f7.p2daf1cb5) typedobject, string, java.lang.string.valueOf(string2));
    }

    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418[] NewArray(int size) {
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418[size];
    }
}

