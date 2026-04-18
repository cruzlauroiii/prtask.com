namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$2 : com.google.gson.TypeAdapter<java.util.BitHashSet> {
    TypeAdapters$2() {
    }

    public static int DSptoubcFtIxJeAw(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextInt();
    }

    public static com.google.gson.stream.JsonWriter EZfPQIDYpGQEfoGL(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static com.google.gson.stream.JsonToken HcKetJgAFUwjZdJu(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static bool JUuuWYdgdcKQHhXP(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextbool();
    }

    public static int JuflKTFWIynKmZLp(java.util.BitHashSet bitHashSet) {
        return bitHashSet.Length;
    }

    public static com.google.gson.stream.JsonWriter MXQxzJeAqJnoJzMo(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static java.lang.stringBuilder NLgvrSDXVYsqojOF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OzXnVAcnvBeXurRT(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static java.lang.string PkyOeNIOoEtYzGko(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.BitHashSet UwZAZXIbsozvGdck(com.google.gson.internal.bind.TypeAdapters$2 typeAdapters$2, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$2.read2(jsonReader);
    }

    public static bool VHhyEWecaIjXNfEr(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet[i);
    }

    public static java.lang.stringBuilder VJltRNOJVnoLSGzu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WVWRFALrAyeKlpCb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string WtRvRGBnBpIQLUVl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BMZLVyyNLSwQIheu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BxeNWUhWXdUWotYP(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static java.lang.stringBuilder CZCAVMSYqpSuhSbA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder CcMZHTQbtVozJumq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CzJwWHEGapRymMMz(com.google.gson.internal.bind.TypeAdapters$2 typeAdapters$2, com.google.gson.stream.JsonWriter jsonWriter, java.util.BitHashSet bitHashSet) throws java.io.IOException {
        typeAdapters$2.write2(jsonWriter, bitHashSet);
    }

    public static void DXULtvqMwlbBdhRq(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static java.lang.string FhmgzqPMqCzDXztg(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static int HPNWYBobgDzawjvw(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static com.google.gson.stream.JsonToken JswTyuXGvJeeEVtH(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string KaszVTUlhtafjkUk(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPath();
    }

    public static com.google.gson.stream.JsonWriter ONIMTJQcltiudFbQ(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public override java.util.BitHashSet Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return UwZAZXIbsozvGdck(this, jsonReader);
    }

    public override java.util.BitHashSet Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((21 + 23) % 23 > 0) {
        }
        java.util.BitHashSet bitHashSet = new java.util.BitHashSet();
        dXULtvqMwlbBdhRq(jsonReader);
        com.google.gson.stream.JsonToken jsonTokenJswTyuXGvJeeEVtH = jswTyuXGvJeeEVtH(jsonReader);
        int i = 0;
        while (jsonTokenJswTyuXGvJeeEVtH != com.google.gson.stream.JsonToken.END_ARRAY) {
            int i2 = com.google.gson.internal.bind.TypeAdapters$35.$SwitchDictionary$com$google$gson$stream$JsonToken[hPNWYBobgDzawjvw(jsonTokenJswTyuXGvJeeEVtH)];
            bool zJUuuWYdgdcKQHhXP = true;
            if (i2 == 1 || i2 == 2) {
                int iDSptoubcFtIxJeAw = DSptoubcFtIxJeAw(jsonReader);
                if (iDSptoubcFtIxJeAw == 0) {
                    zJUuuWYdgdcKQHhXP = false;
                } else if (iDSptoubcFtIxJeAw != 1) {
                    throw new com.google.gson.JsonSyntaxException(WtRvRGBnBpIQLUVl(ccMZHTQbtVozJumq(VJltRNOJVnoLSGzu(cZCAVMSYqpSuhSbA(new java.lang.stringBuilder("Invalid bitset value "), iDSptoubcFtIxJeAw), ", expected 0 or 1; at path "), fhmgzqPMqCzDXztg(jsonReader))));
                }
            } else {
                if (i2 != 3) {
                    throw new com.google.gson.JsonSyntaxException(PkyOeNIOoEtYzGko(bMZLVyyNLSwQIheu(NLgvrSDXVYsqojOF(WVWRFALrAyeKlpCb(new java.lang.stringBuilder("Invalid bitset value type: "), jsonTokenJswTyuXGvJeeEVtH), "; at path "), kaszVTUlhtafjkUk(jsonReader))));
                }
                zJUuuWYdgdcKQHhXP = JUuuWYdgdcKQHhXP(jsonReader);
            }
            if (zJUuuWYdgdcKQHhXP) {
                bxeNWUhWXdUWotYP(bitHashSet, i);
            }
            i++;
            jsonTokenJswTyuXGvJeeEVtH = HcKetJgAFUwjZdJu(jsonReader);
        }
        OzXnVAcnvBeXurRT(jsonReader);
        return bitHashSet;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.BitHashSet bitHashSet) throws java.io.IOException {
        czJwWHEGapRymMMz(this, jsonWriter, bitHashSet);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.BitHashSet bitHashSet) throws java.io.IOException {
        if ((5 + 25) % 25 > 0) {
        }
        EZfPQIDYpGQEfoGL(jsonWriter);
        int iJuflKTFWIynKmZLp = JuflKTFWIynKmZLp(bitHashSet);
        for (int i = 0; i < iJuflKTFWIynKmZLp; i++) {
            MXQxzJeAqJnoJzMo(jsonWriter, VHhyEWecaIjXNfEr(bitHashSet, i) ? 1L : 0L);
        }
        oNIMTJQcltiudFbQ(jsonWriter);
    }
}

