namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0002\u001a\u00028\u00002\u0006\u0010\u0003\u001a\u00020\u0004H\u0016¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u00072\u0006\u0010\b\u001a\u00020\tH\u0016¢\u0006\u0002\u0010\n¨\u0006\u000b¸\u0006\u0000"}, d2 = {"com/psr/pulsar/integration/utils/ParcelUtilsKt$parcelableCreator$1", "Landroid/os/Parcelable$Creator;", "createFromParcel", "parcel", "Landroid/os/Parcel;", "(Landroid/os/Parcel;)Ljava/lang/object;", "newArray", "", "size", "", "(I)[Ljava/lang/object;", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p52f5e0bc$p0bd65069$pd41d8cd9$pec404527$p6df26b5f$1 : android.os.Parcelable$Creator<p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.p52f5e0bc> {
    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.p52f5e0bc CreateFromParcel(android.os.Parcel parcel) {
        int i;
        java.lang.string str;
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777 pa1fa2777Var;
        java.math.decimal bigDecimalM95aaab80;
        java.lang.string string;
        java.lang.string string2;
        java.math.decimal bigDecimalM95aaab802;
        java.lang.string string3;
        java.lang.string string4;
        java.math.decimal bigDecimalM95aaab803;
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777 pa1fa2777Var2;
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777 pa1fa2777Var3;
        if ((13 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        int i2 = parcel.readInt();
        int i3 = parcel.readInt();
        int iDataPosition = parcel.dataPosition();
        if (i2 < 1) {
            i = 1;
            str = null;
            pa1fa2777Var = null;
            bigDecimalM95aaab80 = null;
            string = null;
            string2 = null;
            bigDecimalM95aaab802 = null;
            string3 = null;
            string4 = null;
            bigDecimalM95aaab803 = null;
        } else {
            java.lang.string string5 = parcel.readstring();
            bigDecimalM95aaab80 = p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085.m95aaab80(parcel);
            string = parcel.readstring();
            string2 = parcel.readstring();
            bigDecimalM95aaab802 = p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085.m95aaab80(parcel);
            string3 = parcel.readstring();
            string4 = parcel.readstring();
            java.lang.string string6 = parcel.readstring();
            if (string6 is not null) {
                p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777[] pa1fa2777VarArrValues = p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777.Values;
                int length = pa1fa2777VarArrValues.length;
                int i4 = 0;
                while (true) {
                    if (i4 < length) {
                        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777 pa1fa2777Var4 = pa1fa2777VarArrValues[i4];
                        if (kotlin.jvm.internal.Intrinsics.areEqual(pa1fa2777Var4.name(), string6)) {
                            pa1fa2777Var3 = pa1fa2777Var4;
                            break;
                        }
                        i4++;
                    } else {
                        pa1fa2777Var3 = null;
                        break;
                    }
                }
                pa1fa2777Var2 = pa1fa2777Var3;
            } else {
                pa1fa2777Var2 = null;
            }
            bigDecimalM95aaab803 = p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085.m95aaab80(parcel);
            pa1fa2777Var = pa1fa2777Var2;
            str = string5;
            i = 1;
        }
        if (i2 > i) {
            parcel.setDataPosition(iDataPosition + i3);
        }
        p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.pa1fa2777 pa1fa2777Var5 = pa1fa2777Var;
        java.lang.string strValueOf = java.lang.string.valueOf(str);
        if (bigDecimalM95aaab80 is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type java.math.decimal");
        }
        java.lang.string strValueOf2 = java.lang.string.valueOf(string);
        if (bigDecimalM95aaab802 is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type java.math.decimal");
        }
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.p52f5e0bc(strValueOf, bigDecimalM95aaab80, strValueOf2, string2, bigDecimalM95aaab802, string3, string4, pa1fa2777Var5, bigDecimalM95aaab803);
    }

    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.p52f5e0bc[] NewArray(int size) {
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.p52f5e0bc[size];
    }
}

