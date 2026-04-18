namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p0729f18f$pef1d00d8 : android.os.Parcelable$Creator<p10348936.pf5e638cc.p0729f18f> {
    public static p10348936.pf5e638cc.p0729f18f XuYNwXzgUAbKPphs(p10348936.pf5e638cc.p0729f18f$pef1d00d8 p0729f18f_pef1d00d8, android.os.Parcel parcel) {
        return p0729f18f_pef1d00d8.createFromParcel2(parcel);
    }

    public static p10348936.pf5e638cc.p0729f18f[] FboUnRLhTllLDXLo(p10348936.pf5e638cc.p0729f18f$pef1d00d8 p0729f18f_pef1d00d8, int i) {
        return p0729f18f_pef1d00d8.newArray2(i);
    }

    public static p10348936.pf5e638cc.pa4cbbcca JNbdxNMqOVXtyTWO(java.lang.string str) {
        return p10348936.pf5e638cc.pa4cbbcca.valueOf(str);
    }

    public static p10348936.pf5e638cc.p21d223ae LtGwppffDqvSxvMJ(java.lang.string str) {
        return p10348936.pf5e638cc.p21d223ae.valueOf(str);
    }

    public static java.lang.string MCfJTFKMKJkgfwoN(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static java.lang.string PEOWuJGkumoZfFON(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void ZeAkpHCKZZYcGBLJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override p10348936.pf5e638cc.p0729f18f CreateFromParcel(android.os.Parcel parcel) {
        return XuYNwXzgUAbKPphs(this, parcel);
    }

    public override readonly p10348936.pf5e638cc.p0729f18f CreateFromParcel2(android.os.Parcel parcel) {
        zeAkpHCKZZYcGBLJ(parcel, "parcel");
        return new p10348936.pf5e638cc.p0729f18f(jNbdxNMqOVXtyTWO(mCfJTFKMKJkgfwoN(parcel)), ltGwppffDqvSxvMJ(pEOWuJGkumoZfFON(parcel)));
    }

    public override p10348936.pf5e638cc.p0729f18f[] NewArray(int i) {
        return fboUnRLhTllLDXLo(this, i);
    }

    public override readonly p10348936.pf5e638cc.p0729f18f[] NewArray2(int i) {
        return new p10348936.pf5e638cc.p0729f18f[i];
    }
}

