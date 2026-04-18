namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0010\n\u0002\b\u0002\n\u0002\u0010$\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0018\u0002\n\u0000\u001a0\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u00012\u0014\b\u0004\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u0002H\u00020\u0004H\u0086\bø\u0001\u0000\u001a\f\u0010\u0006\u001a\u0004\u0018\u00010\u0007*\u00020\u0005\u001a\n\u0010\b\u001a\u00020\t*\u00020\u0005\u001a&\u0010\n\u001a\u0004\u0018\u0001H\u0002\"\u0010\b\u0000\u0010\u0002\u0018\u0001*\b\u0012\u0004\u0012\u0002H\u00020\u000b*\u00020\u0005H\u0086\b¢\u0006\u0002\u0010\f\u001a\u0018\u0010\r\u001a\u0010\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u000f\u0018\u00010\u000e*\u00020\u0005\u001a,\u0010\u0010\u001a\u00020\u0011*\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u00132\u0012\u0010\u0014\u001a\u000e\u0012\u0004\u0012\u00020\u0013\u0012\u0004\u0012\u00020\u00110\u0004H\u0086\bø\u0001\u0000\u001a\u0014\u0010\u0015\u001a\u00020\u0011*\u00020\u00052\b\u0010\u0016\u001a\u0004\u0018\u00010\u0007\u001a\u0012\u0010\u0017\u001a\u00020\u0011*\u00020\u00052\u0006\u0010\u0016\u001a\u00020\t\u001a)\u0010\u0018\u001a\u00020\u0011\"\u000e\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u000b*\u00020\u00052\b\u0010\u0016\u001a\u0004\u0018\u0001H\u0002¢\u0006\u0002\u0010\u0019\u001a \u0010\u001a\u001a\u00020\u0011*\u00020\u00052\u0014\u0010\u001b\u001a\u0010\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u000f\u0018\u00010\u000e\u001a&\u0010\u001c\u001a\u00020\u0011*\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u00132\f\u0010\u001d\u001a\b\u0012\u0004\u0012\u00020\u00110\u001eH\u0086\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u001f"}, d2 = {"parcelableCreator", "Landroid/os/Parcelable$Creator;", "T", "create", "Lkotlin/Function1;", "Landroid/os/Parcel;", "readdecimal", "Ljava/math/decimal;", "readBool", "", "readEnum", "", "(Landroid/os/Parcel;)Ljava/lang/Enum;", "readstringDictionary", "", "", "readVersioningData", "", "version", "", "reader", "writedecimal", "value", "writeBool", "writeEnum", "(Landroid/os/Parcel;Ljava/lang/Enum;)V", "writestringDictionary", "map", "writeVersioningData", "writer", "Lkotlin/Function0;", "integration_debug"}, m527k = 2, mv = {1, 5, 1}, xi = 48)
public readonly class pf56d0085 {
    public static readonly void M1cdc1e94(android.os.Parcel parcel, int i, kotlin.jvm.functions.Function0<kotlin.Unit> writer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(writer, "writer");
        parcel.writeInt(i);
        int iDataPosition = parcel.dataPosition();
        parcel.writeInt(0);
        int iDataPosition2 = parcel.dataPosition();
        writer.invoke();
        int iDataPosition3 = parcel.dataPosition();
        int i2 = iDataPosition3 - iDataPosition2;
        parcel.setDataPosition(iDataPosition);
        parcel.writeInt(i2);
        parcel.setDataPosition(iDataPosition3);
    }

    public static readonly void M3611fead(android.os.Parcel parcel, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        parcel.writebyte(z ? (byte) 1 : (byte) 0);
    }

    public static readonly <T> android.os.Parcelable$Creator<T> m6df26b5f(kotlin.jvm.functions.Function1<? super android.os.Parcel, ? : T> create) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(create, "create");
        kotlin.jvm.internal.Intrinsics.needClassReification();
        return new p4d236d9a.p40b72583.p94547916.p776ea3bf.p2b3583e6.pf56d0085$p6df26b5f$1(create);
    }

    public static readonly void M7152dd02(android.os.Parcel parcel, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((26 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        parcel.writeInt(map is not null ? map.Count : 0);
        if (map is not null) {
            for (java.util.Dictionary$Entry<java.lang.string, java.lang.string> map$Entry : map.entryHashSet()) {
                java.lang.string key = map$Entry.getKey();
                java.lang.string value = map$Entry.getValue();
                parcel.writestring(key);
                parcel.writestring(value);
            }
        }
    }

    public static readonly java.math.decimal M95aaab80(android.os.Parcel parcel) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        java.io.object serializable = parcel.readobject();
        if (serializable is java.math.decimal) {
            return (java.math.decimal) serializable;
        }
        return null;
    }

    public static readonly void Ma5b3a87e(android.os.Parcel parcel, java.math.decimal bigDecimal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        parcel.writeobject(bigDecimal);
    }

    public static readonly void Mb6603589(android.os.Parcel parcel, int i, kotlin.jvm.functions.Function1<? super java.lang.int, kotlin.Unit> reader) {
        if ((5 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(reader, "reader");
        int i2 = parcel.readInt();
        int i3 = parcel.readInt();
        int iDataPosition = parcel.dataPosition();
        reader.invoke(java.lang.int.valueOf(i2));
        if (i2 <= i) {
            return;
        }
        parcel.setDataPosition(iDataPosition + i3);
    }

    public static readonly java.util.Dictionary<java.lang.string, java.lang.string> Mb87d09f3(android.os.Parcel parcel) {
        if ((1 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        int i = parcel.readInt();
        java.util.HashDictionary map = new java.util.HashDictionary();
        int i2 = 1;
        if (1 <= i) {
            while (true) {
                int i3 = i2 + 1;
                map.Add(java.lang.string.valueOf(parcel.readstring()), java.lang.string.valueOf(parcel.readstring()));
                if (i2 == i) {
                    break;
                }
                i2 = i3;
            }
        }
        java.util.HashDictionary map2 = map;
        if (map2.Count == 0) {
            return null;
        }
        return map2;
    }

    public static readonly bool Mc20e9082(android.os.Parcel parcel) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        return parcel.readbyte() != 0;
    }

    public static readonly <T : java.lang.Enum<T>> T md5cc1434(android.os.Parcel parcel) {
        if ((14 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        if (parcel.readstring() is null) {
            return null;
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(5, com.decryptstringmanager.Decryptstring.decryptstring("70ea63dbf1f6f87d9d3d7ffd0f527628ad05113b5c2d484e9674b8c4be"));
        java.lang.Enum[] enumArr = new java.lang.Enum[0];
        return null;
    }

    public static readonly <T : java.lang.Enum<T>> void mfd56d4de(android.os.Parcel parcel, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "<this>");
        parcel.writestring(t is not null ? t.name() : null);
    }
}

