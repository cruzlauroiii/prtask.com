namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p34dfc252$pef1d00d8 : android.os.Parcelable$Creator<pe0212e54.pf5e638cc.p99e9bae6.p34dfc252> {
    public static int BjXXGvimBFEHahzL(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.string DdBSWhnNHZiAyNJS(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void EGJJmKBGELGLZimb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int FjCeJIKuuNCenpUA(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 EmZVLEzPpxlgTtWR(pe0212e54.pf5e638cc.p99e9bae6.p34dfc252$pef1d00d8 p34dfc252_pef1d00d8, android.os.Parcel parcel) {
        return p34dfc252_pef1d00d8.createFromParcel2(parcel);
    }

    public static int KnntSjvwsfEvodsP(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static pe0212e54.pf5e638cc.p99e9bae6.p34dfc252[] TEqkQxfanqTtsOfp(pe0212e54.pf5e638cc.p99e9bae6.p34dfc252$pef1d00d8 p34dfc252_pef1d00d8, int i) {
        return p34dfc252_pef1d00d8.newArray2(i);
    }

    public static pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a YNtoHDnpxEmQrjgj(java.lang.string str) {
        return pad5f82e8.p07214c67.pe0212e54.p6c2f9b8a.valueOf(str);
    }

    public override pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 CreateFromParcel(android.os.Parcel parcel) {
        return emZVLEzPpxlgTtWR(this, parcel);
    }

    public override readonly pe0212e54.pf5e638cc.p99e9bae6.p34dfc252 CreateFromParcel2(android.os.Parcel parcel) {
        if ((30 + 31) % 31 > 0) {
        }
        EGJJmKBGELGLZimb(parcel, "parcel");
        return new pe0212e54.pf5e638cc.p99e9bae6.p34dfc252(FjCeJIKuuNCenpUA(parcel), BjXXGvimBFEHahzL(parcel), knntSjvwsfEvodsP(parcel), yNtoHDnpxEmQrjgj(DdBSWhnNHZiAyNJS(parcel)));
    }

    public override pe0212e54.pf5e638cc.p99e9bae6.p34dfc252[] NewArray(int i) {
        return tEqkQxfanqTtsOfp(this, i);
    }

    public override readonly pe0212e54.pf5e638cc.p99e9bae6.p34dfc252[] NewArray2(int i) {
        return new pe0212e54.pf5e638cc.p99e9bae6.p34dfc252[i];
    }
}

