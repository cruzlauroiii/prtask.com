namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0002\u001a\u00028\u00002\u0006\u0010\u0003\u001a\u00020\u0004H\u0016¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u00072\u0006\u0010\b\u001a\u00020\tH\u0016¢\u0006\u0002\u0010\n¨\u0006\u000b¸\u0006\u0000"}, d2 = {"com/psr/pulsar/integration/utils/ParcelUtilsKt$parcelableCreator$1", "Landroid/os/Parcelable$Creator;", "createFromParcel", "parcel", "Landroid/os/Parcel;", "(Landroid/os/Parcel;)Ljava/lang/object;", "newArray", "", "size", "", "(I)[Ljava/lang/object;", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class pd6d7c5a3$p0bd65069$pd41d8cd9$pec404527$p6df26b5f$1 : android.os.Parcelable$Creator<p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.pd6d7c5a3> {
    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.pd6d7c5a3 CreateFromParcel(android.os.Parcel parcel) {
        java.util.List list;
        java.lang.string string;
        java.lang.bool bool;
        java.lang.object obj;
        java.lang.string str;
        java.lang.string strValueOf;
        java.math.decimal bigDecimalM95aaab80;
        java.util.Dictionary<java.lang.string, java.lang.string> mapMb87d09f3;
        java.lang.string str2;
        if ((3 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        int i = parcel.readInt();
        int i2 = parcel.readInt();
        int iDataPosition = parcel.dataPosition();
        java.lang.object obj2 = null;
        if (i < 1) {
            obj = null;
            bool = null;
            list = null;
            strValueOf = null;
            string = null;
            str = null;
            str2 = null;
            bigDecimalM95aaab80 = null;
            mapMb87d09f3 = null;
        } else {
            java.lang.string string2 = parcel.readstring();
            java.util.List arrayListCreateTypedList = parcel.createTypedList(p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p4757fe07.p52f5e0bc.f71867d25);
            list = arrayListCreateTypedList is not null ? kotlin.collections.ICollectionsKt.toList(arrayListCreateTypedList) : null;
            java.lang.string string3 = parcel.readstring();
            java.lang.string string4 = parcel.readstring();
            java.lang.string string5 = parcel.readstring();
            if (string5 is not null) {
                for (p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p8c261c90 p8c261c90Var : p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p8c261c90.Values) {
                    if (kotlin.jvm.internal.Intrinsics.areEqual(p8c261c90Var.name(), string5)) {
                        obj2 = p8c261c90Var;
                        break;
                    }
                }
                obj2 = (java.lang.Enum) obj2;
            }
            java.lang.bool boolValueOf = java.lang.bool.valueOf(p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085.mc20e9082(parcel));
            string = parcel.readstring();
            bool = boolValueOf;
            obj = obj2;
            obj2 = string2;
            str = string3;
            strValueOf = java.lang.string.valueOf(parcel.readstring());
            bigDecimalM95aaab80 = p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085.m95aaab80(parcel);
            mapMb87d09f3 = p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085.mb87d09f3(parcel);
            str2 = string4;
        }
        if (i > 1) {
            parcel.setDataPosition(iDataPosition + i2);
        }
        java.lang.string str3 = strValueOf;
        java.lang.string strValueOf2 = java.lang.string.valueOf(obj2);
        if (list is null) {
            list = kotlin.collections.ICollectionsKt.emptyList();
        }
        if (obj is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type com.psr.pulsar.integration.entities.receipt.PaymentType");
        }
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.pd6d7c5a3(strValueOf2, list, str, str2, (p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.p8c261c90) obj, bool is not null ? bool.boolValue() : false, java.lang.string.valueOf(string), java.lang.string.valueOf(str3), bigDecimalM95aaab80, mapMb87d09f3);
    }

    public override p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.pd6d7c5a3[] NewArray(int size) {
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p1e11b989.pd6d7c5a3[size];
    }
}

