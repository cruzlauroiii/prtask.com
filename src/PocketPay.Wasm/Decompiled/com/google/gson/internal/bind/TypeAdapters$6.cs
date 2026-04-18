namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$6 : com.google.gson.TypeAdapter<java.lang.Number> {
    TypeAdapters$6() {
    }

    public static java.lang.stringBuilder GtGQtMsZOaPwBoDR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void IqrzEtbGzGctgHMJ(com.google.gson.internal.bind.TypeAdapters$6 typeAdapters$6, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        typeAdapters$6.write2(jsonWriter, number);
    }

    public static short JhlXmsvwaqcJXstt(java.lang.Number number) {
        return number.shortValue();
    }

    public static com.google.gson.stream.JsonToken MnkXHXNXVMscvEXm(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static int PNAAOjOfLtZrArSk(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextInt();
    }

    public static java.lang.string SNyJyjHSolwINcsV(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static com.google.gson.stream.JsonWriter UMIfWuXBFNfMFvaw(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static com.google.gson.stream.JsonWriter VByGsmTtDchpteKS(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.Number VjtFnLScVXFaXgOB(com.google.gson.internal.bind.TypeAdapters$6 typeAdapters$6, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$6.read(jsonReader);
    }

    public static java.lang.stringBuilder FiUCNvPsZENChCfl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FzIHpxIpbSssgOPQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IvnSoMrYzroNCGlF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TpfbeWgQhEmbfZZJ(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.short UrFaepiSBhELRfZm(short s) {
        return java.lang.short.valueOf(s);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((30 + 11) % 11 > 0) {
        }
        if (MnkXHXNXVMscvEXm(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            tpfbeWgQhEmbfZZJ(jsonReader);
            return null;
        }
        try {
            int iPNAAOjOfLtZrArSk = PNAAOjOfLtZrArSk(jsonReader);
            if (iPNAAOjOfLtZrArSk <= 65535 && iPNAAOjOfLtZrArSk >= -32768) {
                return urFaepiSBhELRfZm((short) iPNAAOjOfLtZrArSk);
            }
            throw new com.google.gson.JsonSyntaxException(ivnSoMrYzroNCGlF(fiUCNvPsZENChCfl(fzIHpxIpbSssgOPQ(GtGQtMsZOaPwBoDR(new java.lang.stringBuilder("Lossy conversion from "), iPNAAOjOfLtZrArSk), " to short; at path "), SNyJyjHSolwINcsV(jsonReader))));
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        }
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return VjtFnLScVXFaXgOB(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((6 + 1) % 1 > 0) {
        }
        if (number is not null) {
            UMIfWuXBFNfMFvaw(jsonWriter, JhlXmsvwaqcJXstt(number));
        } else {
            VByGsmTtDchpteKS(jsonWriter);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        IqrzEtbGzGctgHMJ(this, jsonWriter, number);
    }
}

