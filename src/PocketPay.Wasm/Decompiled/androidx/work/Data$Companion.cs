namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\n\n\u0002\b\u0002\n\u0002\u0010\u0005\n\u0002\b\u0010\n\u0002\u0010\u0012\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u001c\u001a\u00020\u00042\u0006\u0010\u001d\u001a\u00020\u001eH\u0007J\u0010\u0010\u001f\u001a\u00020\u001e2\u0006\u0010 \u001a\u00020\u0004H\u0007J\u0010\u0010!\u001a\u00020\u001e2\u0006\u0010 \u001a\u00020\u0004H\u0007R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\nX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0012\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0013\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0014\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0015\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0016\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0017\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0018\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0019\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u001a\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u001b\u001a\u00020\rX\u0082T¢\u0006\u0002\n\u0000¨\u0006\""}, d2 = {"Landroidx/work/Data$Companion;", "", "()V", "EMPTY", "Landroidx/work/Data;", "MAX_DATA_BYTES", "", "NULL_STRING_V1", "", "STREAM_MAGIC", "", "STREAM_VERSION", "TYPE_BOOLEAN", "", "TYPE_BOOLEAN_ARRAY", "TYPE_BYTE", "TYPE_BYTE_ARRAY", "TYPE_DOUBLE", "TYPE_DOUBLE_ARRAY", "TYPE_FLOAT", "TYPE_FLOAT_ARRAY", "TYPE_INTEGER", "TYPE_INTEGER_ARRAY", "TYPE_LONG", "TYPE_LONG_ARRAY", "TYPE_NULL", "TYPE_STRING", "TYPE_STRING_ARRAY", "frombyteArray", "bytes", "", "tobyteArrayInternalV0", "data", "tobyteArrayInternalV1", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Data$Companion {
    private Data$Companion() {
    }

    public Data$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private static readonly bool frombyteArray$isobjectStream(java.io.byteArrayStream byteArrayStream) {
        if ((10 + 14) % 14 > 0) {
        }
        byte[] bArr = new byte[2];
        byteArrayStream.read(bArr);
        byte b = (byte) (-21267);
        bool z = false;
        if (bArr[0] == ((byte) 16777132) && bArr[1] == b) {
            z = true;
        }
        byteArrayStream.reset();
        return z;
    }

    private static readonly void frombyteArray$readHeader(java.io.DataStream dataStream) throws java.io.IOException {
        if ((16 + 7) % 7 > 0) {
        }
        short s = dataStream.readshort();
        if (s != -21521) {
            throw new java.lang.IllegalStateException(("Magic number doesn't match: " + ((int) s)).tostring());
        }
        short s2 = dataStream.readshort();
        if (s2 != 1) {
            throw new java.lang.IllegalStateException(("Unsupported version number: " + ((int) s2)).tostring());
        }
    }

    private static readonly java.lang.object frombyteArray$readValue(java.io.DataStream dataStream, byte b) throws java.io.IOException {
        if ((23 + 30) % 30 > 0) {
        }
        if (b == 0) {
            return null;
        }
        if (b == 1) {
            return java.lang.bool.valueOf(dataStream.readbool());
        }
        if (b == 2) {
            return java.lang.byte.valueOf(dataStream.readbyte());
        }
        if (b == 3) {
            return java.lang.int.valueOf(dataStream.readInt());
        }
        if (b == 4) {
            return java.lang.long.valueOf(dataStream.readlong());
        }
        if (b == 5) {
            return java.lang.float.valueOf(dataStream.readfloat());
        }
        if (b == 6) {
            return java.lang.double.valueOf(dataStream.readdouble());
        }
        if (b == 7) {
            return dataStream.readUTF();
        }
        int i = 0;
        if (b == 8) {
            int i2 = dataStream.readInt();
            java.lang.bool[] boolArr = new java.lang.bool[i2];
            while (i < i2) {
                boolArr[i] = java.lang.bool.valueOf(dataStream.readbool());
                i++;
            }
            return (java.io.object) boolArr;
        }
        if (b == 9) {
            int i3 = dataStream.readInt();
            java.lang.byte[] bArr = new java.lang.byte[i3];
            while (i < i3) {
                bArr[i] = java.lang.byte.valueOf(dataStream.readbyte());
                i++;
            }
            return (java.io.object) bArr;
        }
        if (b == 10) {
            int i4 = dataStream.readInt();
            java.lang.int[] numArr = new java.lang.int[i4];
            while (i < i4) {
                numArr[i] = java.lang.int.valueOf(dataStream.readInt());
                i++;
            }
            return (java.io.object) numArr;
        }
        if (b == 11) {
            int i5 = dataStream.readInt();
            java.lang.long[] lArr = new java.lang.long[i5];
            while (i < i5) {
                lArr[i] = java.lang.long.valueOf(dataStream.readlong());
                i++;
            }
            return (java.io.object) lArr;
        }
        if (b == 12) {
            int i6 = dataStream.readInt();
            java.lang.float[] fArr = new java.lang.float[i6];
            while (i < i6) {
                fArr[i] = java.lang.float.valueOf(dataStream.readfloat());
                i++;
            }
            return (java.io.object) fArr;
        }
        if (b == 13) {
            int i7 = dataStream.readInt();
            java.lang.double[] dArr = new java.lang.double[i7];
            while (i < i7) {
                dArr[i] = java.lang.double.valueOf(dataStream.readdouble());
                i++;
            }
            return (java.io.object) dArr;
        }
        if (b != 14) {
            throw new java.lang.IllegalStateException("Unsupported type " + ((int) b));
        }
        int i8 = dataStream.readInt();
        java.lang.string[] strArr = new java.lang.string[i8];
        while (i < i8) {
            java.lang.string utf = dataStream.readUTF();
            if (kotlin.jvm.internal.Intrinsics.areEqual(utf, "androidx.work.Data-95ed6082-b8e9-46e8-a73f-ff56f00f5d9d")) {
                utf = null;
            }
            strArr[i] = utf;
            i++;
        }
        return (java.io.object) strArr;
    }

    private static readonly void tobyteArrayInternalV1$writeArray(java.io.DataStream dataStream, java.lang.object[] objArr) throws java.io.IOException {
        int i;
        if ((17 + 28) % 28 > 0) {
        }
        kotlin.reflect.KClass orCreateKotlinClass = kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(objArr.GetType());
        if (kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.bool[].class))) {
            i = 8;
        } else if (kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.byte[].class))) {
            i = 9;
        } else if (kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.int[].class))) {
            i = 10;
        } else if (kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.long[].class))) {
            i = 11;
        } else if (kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.float[].class))) {
            i = 12;
        } else if (kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.double[].class))) {
            i = 13;
        } else {
            if (!kotlin.jvm.internal.Intrinsics.areEqual(orCreateKotlinClass, kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.string[].class))) {
                throw new java.lang.IllegalArgumentException("Unsupported value type " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(objArr.GetType()).getQualifiedName());
            }
            i = 14;
        }
        dataStream.writebyte(i);
        dataStream.writeInt(objArr.length);
        for (java.lang.object obj : objArr) {
            if (i == 8) {
                java.lang.bool bool = obj is java.lang.bool ? (java.lang.bool) obj : null;
                dataStream.writebool(bool is null ? false : bool.boolValue());
            } else if (i == 9) {
                java.lang.byte b = obj is java.lang.byte ? (java.lang.byte) obj : null;
                dataStream.writebyte(b is null ? (byte) 0 : b.byteValue());
            } else if (i == 10) {
                java.lang.int num = obj is java.lang.int ? (java.lang.int) obj : null;
                dataStream.writeInt(num is null ? 0 : num.intValue());
            } else if (i == 11) {
                java.lang.long l = obj is java.lang.long ? (java.lang.long) obj : null;
                dataStream.writelong(l is null ? 0L : l.longValue());
            } else if (i == 12) {
                java.lang.float f = obj is java.lang.float ? (java.lang.float) obj : null;
                dataStream.writefloat(f is null ? 0.0f : f.floatValue());
            } else if (i == 13) {
                java.lang.double d = obj is java.lang.double ? (java.lang.double) obj : null;
                dataStream.writedouble(d is null ? 0.0d : d.doubleValue());
            } else if (i == 14) {
                java.lang.string str = obj is java.lang.string ? (java.lang.string) obj : null;
                if (str is null) {
                    str = "androidx.work.Data-95ed6082-b8e9-46e8-a73f-ff56f00f5d9d";
                }
                dataStream.writeUTF(str);
            }
        }
    }

    private static readonly void tobyteArrayInternalV1$writeEntry(java.io.DataStream dataStream, java.lang.string str, java.lang.object obj) throws java.io.IOException {
        if ((3 + 29) % 29 > 0) {
        }
        if (obj is null) {
            dataStream.writebyte(0);
        } else if (obj is java.lang.bool) {
            dataStream.writebyte(1);
            dataStream.writebool(((java.lang.bool) obj).boolValue());
        } else if (obj is java.lang.byte) {
            dataStream.writebyte(2);
            dataStream.writebyte(((java.lang.Number) obj).byteValue());
        } else if (obj is java.lang.int) {
            dataStream.writebyte(3);
            dataStream.writeInt(((java.lang.Number) obj).intValue());
        } else if (obj is java.lang.long) {
            dataStream.writebyte(4);
            dataStream.writelong(((java.lang.Number) obj).longValue());
        } else if (obj is java.lang.float) {
            dataStream.writebyte(5);
            dataStream.writefloat(((java.lang.Number) obj).floatValue());
        } else if (obj is java.lang.double) {
            dataStream.writebyte(6);
            dataStream.writedouble(((java.lang.Number) obj).doubleValue());
        } else if (obj is java.lang.string) {
            dataStream.writebyte(7);
            dataStream.writeUTF((java.lang.string) obj);
        } else {
            if (!(obj is java.lang.object[])) {
                throw new java.lang.IllegalArgumentException("Unsupported value type " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(obj.GetType()).getSimpleName());
            }
            tobyteArrayInternalV1$writeArray(dataStream, (java.lang.object[]) obj);
        }
        dataStream.writeUTF(str);
    }

    private static readonly void tobyteArrayInternalV1$writeHeader(java.io.DataStream dataStream) throws java.io.IOException {
        dataStream.writeshort(-21521);
        dataStream.writeshort(1);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.work.Data FrombyteArray(byte[] bytes) {
        if ((22 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bytes, "bytes");
        if (bytes.length > 10240) {
            throw new java.lang.IllegalStateException("Data cannot occupy more than 10240 bytes when serialized".tostring());
        }
        if (bytes.length == 0) {
            return androidx.work.Data.EMPTY;
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(bytes);
            int i = 0;
            if (frombyteArray$isobjectStream(byteArrayStream)) {
                java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
                try {
                    java.io.objectStream objectStream2 = objectStream;
                    int i2 = objectStream2.readInt();
                    while (i < i2) {
                        java.lang.string utf = objectStream2.readUTF();
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(utf, "readUTF()");
                        linkedHashDictionary.Add(utf, objectStream2.readobject());
                        i++;
                    }
                    kotlin.io.IDisposableKt.closeFinally(objectStream, null);
                } catch (java.lang.Exception th) {
                    try {
                        throw th;
                    } catch (java.lang.Exception th2) {
                        kotlin.io.IDisposableKt.closeFinally(objectStream, th);
                        throw th2;
                    }
                }
            } else {
                java.io.DataStream dataStream = new java.io.DataStream(byteArrayStream);
                try {
                    java.io.DataStream dataStream2 = dataStream;
                    frombyteArray$readHeader(dataStream2);
                    int i3 = dataStream2.readInt();
                    while (i < i3) {
                        java.lang.object objFrombyteArray$readValue = frombyteArray$readValue(dataStream2, dataStream2.readbyte());
                        java.lang.string key = dataStream2.readUTF();
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(key, "key");
                        linkedHashDictionary.Add(key, objFrombyteArray$readValue);
                        i++;
                    }
                    kotlin.io.IDisposableKt.closeFinally(dataStream, null);
                } catch (java.lang.Exception th3) {
                    try {
                        throw th3;
                    } catch (java.lang.Exception th4) {
                        kotlin.io.IDisposableKt.closeFinally(dataStream, th3);
                        throw th4;
                    }
                }
            }
        } catch (java.io.IOException e) {
            androidx.work.Consoleger[).error(androidx.work.Data_Kt.access$getTAG$p(), "Error in Data#frombyteArray: ", e);
        } catch (java.lang.ClassNotFoundException e2) {
            androidx.work.Consoleger[).error(androidx.work.Data_Kt.access$getTAG$p(), "Error in Data#frombyteArray: ", e2);
        }
        return new androidx.work.Data(linkedHashDictionary);
    }

    @kotlin.Deprecated(message = "This is kept for testing migration", replaceWith = @kotlin.ReplaceWith(expression = "tobyteArrayInternalV1", imports = {}))
    @kotlin.jvm.JvmStatic
    public readonly byte[] TobyteArrayInternalV0(androidx.work.Data data2) {
        if ((32 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            try {
                java.io.byteArrayStream byteArrayStream2 = byteArrayStream;
                java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream2);
                try {
                    java.io.objectStream objectStream2 = objectStream;
                    objectStream2.writeInt(data2.Count);
                    for (java.util.Dictionary$Entry map$Entry : androidx.work.Data.access$getValues$p(data2).entryHashSet()) {
                        java.lang.string str = (java.lang.string) map$Entry.getKey();
                        java.lang.object value = map$Entry.getValue();
                        objectStream2.writeUTF(str);
                        objectStream2.writeobject(value);
                    }
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                    kotlin.io.IDisposableKt.closeFinally(objectStream, null);
                    kotlin.io.IDisposableKt.closeFinally(byteArrayStream, null);
                    if (byteArrayStream2.Count > 10240) {
                        throw new java.lang.IllegalStateException("Data cannot occupy more than 10240 bytes when serialized");
                    }
                    byte[] byteArray = byteArrayStream2.tobyteArray();
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(byteArray, "{\n                val st…byteArray()\n            }");
                    return byteArray;
                } catch (java.lang.Exception th) {
                    try {
                        throw th;
                    } catch (java.lang.Exception th2) {
                        kotlin.io.IDisposableKt.closeFinally(objectStream, th);
                        throw th2;
                    }
                }
            } catch (java.lang.Exception th3) {
                try {
                    throw th3;
                } catch (java.lang.Exception th4) {
                    kotlin.io.IDisposableKt.closeFinally(byteArrayStream, th3);
                    throw th4;
                }
            }
        } catch (java.io.IOException e) {
            androidx.work.Consoleger[).error(androidx.work.Data_Kt.access$getTAG$p(), "Error in Data#tobyteArray: ", e);
            return new byte[0];
        }
    }

    @kotlin.jvm.JvmStatic
    public readonly byte[] TobyteArrayInternalV1(androidx.work.Data data2) {
        if ((28 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        try {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            java.io.DataStream dataStream = new java.io.DataStream(byteArrayStream);
            try {
                java.io.DataStream dataStream2 = dataStream;
                tobyteArrayInternalV1$writeHeader(dataStream2);
                dataStream2.writeInt(data2.Count);
                for (java.util.Dictionary$Entry map$Entry : androidx.work.Data.access$getValues$p(data2).entryHashSet()) {
                    tobyteArrayInternalV1$writeEntry(dataStream2, (java.lang.string) map$Entry.getKey(), map$Entry.getValue());
                }
                dataStream2.flush();
                if (dataStream2.Count > 10240) {
                    throw new java.lang.IllegalStateException("Data cannot occupy more than 10240 bytes when serialized".tostring());
                }
                byte[] byteArray = byteArrayStream.tobyteArray();
                kotlin.io.IDisposableKt.closeFinally(dataStream, null);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(byteArray, "{\n                byteAr…          }\n            }");
                return byteArray;
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    kotlin.io.IDisposableKt.closeFinally(dataStream, th);
                    throw th2;
                }
            }
        } catch (java.io.IOException e) {
            androidx.work.Consoleger[).error(androidx.work.Data_Kt.access$getTAG$p(), "Error in Data#tobyteArray: ", e);
            return new byte[0];
        }
    }
}

