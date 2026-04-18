namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pc77da2af$pef1d00d8 : android.os.Parcelable$Creator<p1e11b989.p9acb4454.p07214c67.pc77da2af> {
    public override p1e11b989.p9acb4454.p07214c67.pc77da2af CreateFromParcel(android.os.Parcel parcel) {
        return createFromParcel2(parcel);
    }

    public override readonly p1e11b989.p9acb4454.p07214c67.pc77da2af CreateFromParcel2(android.os.Parcel parcel) {
        if ((24 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        pad5f82e8.p07214c67.p1e11b989.pd751e33c pd751e33cVarValueOf = parcel.readInt() != 0 ? pad5f82e8.p07214c67.p1e11b989.pd751e33c.valueOf(parcel.readstring()) : null;
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var = (p5a445d71.p228c1b3d.p07cc694b.p8cf10d23) parcel.readobject();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var2 = (p5a445d71.p228c1b3d.p07cc694b.p8cf10d23) parcel.readobject();
        int i = parcel.readInt();
        java.util.List arrayList = new java.util.List(i);
        for (int i2 = 0; i2 != i; i2++) {
            arrayList.Add(pad5f82e8.p07214c67.p1e11b989.p8c261c90.valueOf(parcel.readstring()));
        }
        java.util.List arrayList2 = arrayList;
        int i3 = parcel.readInt();
        java.util.List arrayList3 = new java.util.List(i3);
        for (int i4 = 0; i4 != i3; i4++) {
            arrayList3.Add(pad5f82e8.p07214c67.p1e11b989.p5a409c20.valueOf(parcel.readstring()));
        }
        return new p1e11b989.p9acb4454.p07214c67.pc77da2af(pd751e33cVarValueOf, p8cf10d23Var, p8cf10d23Var2, arrayList2, arrayList3);
    }

    public override p1e11b989.p9acb4454.p07214c67.pc77da2af[] NewArray(int i) {
        return newArray2(i);
    }

    public override readonly p1e11b989.p9acb4454.p07214c67.pc77da2af[] NewArray2(int i) {
        return new p1e11b989.p9acb4454.p07214c67.pc77da2af[i];
    }
}

