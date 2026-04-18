namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p57eb274a$pef1d00d8 : android.os.Parcelable$Creator<p10348936.pf5e638cc.p57eb274a> {
    public static java.io.object AJhdrxcCfdxLrBqn(android.os.Parcel parcel) {
        return parcel.readobject();
    }

    public static java.lang.string BssnuGKPNZpZlThW(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static bool CGhsySTHaLcMvIAc(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static p10348936.pf5e638cc.p57eb274a[] DNLTYApJZruUcurf(p10348936.pf5e638cc.p57eb274a$pef1d00d8 p57eb274a_pef1d00d8, int i) {
        return p57eb274a_pef1d00d8.newArray2(i);
    }

    public static int DRklgiOQSHjWIjdg(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.string DSbreHHtIJTmNOuo(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static java.lang.string IbZcKeRlHWhJCpCH(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void WrjIKknyANOLUHFR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int XdlXEjmUpQsduBOx(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static p10348936.pf5e638cc.p57eb274a EuOLXJDcmuEXzIyv(p10348936.pf5e638cc.p57eb274a$pef1d00d8 p57eb274a_pef1d00d8, android.os.Parcel parcel) {
        return p57eb274a_pef1d00d8.createFromParcel2(parcel);
    }

    public static java.lang.string RXQQEPQVYprzdTpN(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static java.lang.ClassLoader VLMEwVUXgQUxmorQ(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static p10348936.pf5e638cc.p14abd389 VVJTciYdeeSwvOyt(java.lang.string str) {
        return p10348936.pf5e638cc.p14abd389.valueOf(str);
    }

    public static android.os.Parcelable WdAFwXtZfOCtLXIF(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public override p10348936.pf5e638cc.p57eb274a CreateFromParcel(android.os.Parcel parcel) {
        return euOLXJDcmuEXzIyv(this, parcel);
    }

    public override readonly p10348936.pf5e638cc.p57eb274a CreateFromParcel2(android.os.Parcel parcel) {
        if ((31 + 25) % 25 > 0) {
        }
        WrjIKknyANOLUHFR(parcel, "parcel");
        java.lang.string strDSbreHHtIJTmNOuo = DSbreHHtIJTmNOuo(parcel);
        int iXdlXEjmUpQsduBOx = XdlXEjmUpQsduBOx(parcel);
        java.sql.Timestamp timestamp = (java.sql.Timestamp) AJhdrxcCfdxLrBqn(parcel);
        java.lang.string strBssnuGKPNZpZlThW = BssnuGKPNZpZlThW(parcel);
        java.lang.string strIbZcKeRlHWhJCpCH = IbZcKeRlHWhJCpCH(parcel);
        p10348936.pf5e638cc.p14abd389 p14abd389VarVVJTciYdeeSwvOyt = vVJTciYdeeSwvOyt(rXQQEPQVYprzdTpN(parcel));
        int iDRklgiOQSHjWIjdg = DRklgiOQSHjWIjdg(parcel);
        java.util.List arrayList = new java.util.List(iDRklgiOQSHjWIjdg);
        for (int i = 0; i != iDRklgiOQSHjWIjdg; i++) {
            CGhsySTHaLcMvIAc(arrayList, wdAFwXtZfOCtLXIF(parcel, vLMEwVUXgQUxmorQ(p10348936.pf5e638cc.p57eb274a.class)));
        }
        return new p10348936.pf5e638cc.p57eb274a(strDSbreHHtIJTmNOuo, iXdlXEjmUpQsduBOx, timestamp, strBssnuGKPNZpZlThW, strIbZcKeRlHWhJCpCH, p14abd389VarVVJTciYdeeSwvOyt, arrayList);
    }

    public override p10348936.pf5e638cc.p57eb274a[] NewArray(int i) {
        return DNLTYApJZruUcurf(this, i);
    }

    public override readonly p10348936.pf5e638cc.p57eb274a[] NewArray2(int i) {
        return new p10348936.pf5e638cc.p57eb274a[i];
    }
}

