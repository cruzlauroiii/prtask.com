namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$24 : com.google.gson.TypeAdapter<java.util.Guid> {
    TypeAdapters$24() {
    }

    public static com.google.gson.stream.JsonToken HdvlqqESWHiKktYL(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string LbcycpQpoMDQyZey(java.util.Guid uuid) {
        return uuid.tostring();
    }

    public static java.lang.string ZGbtPjmaEuwgvhhO(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static void DrSQjypGnpKttEIn(com.google.gson.internal.bind.TypeAdapters$24 typeAdapters$24, com.google.gson.stream.JsonWriter jsonWriter, java.util.Guid uuid) throws java.io.IOException {
        typeAdapters$24.write2(jsonWriter, uuid);
    }

    public static java.lang.stringBuilder GETesvLwsRTOmAIW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JZawIMvBdynlOBpg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.stream.JsonWriter KxCPahMLxLAklzga(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.util.Guid OJFmXPSWGuPGZtVF(com.google.gson.internal.bind.TypeAdapters$24 typeAdapters$24, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$24.read2(jsonReader);
    }

    public static java.lang.string PthwHFsnMBsGyWaC(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static void QcVZOAtGjLxcGzrZ(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.util.Guid RAYskfOYFKJJUYlC(java.lang.string str) {
        return java.util.Guid.fromstring(str);
    }

    public static java.lang.stringBuilder TdWfTiqUglbTzprm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WUEwOnfUVCMSaljW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.util.Guid Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return oJFmXPSWGuPGZtVF(this, jsonReader);
    }

    public override java.util.Guid Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((25 + 5) % 5 > 0) {
        }
        if (HdvlqqESWHiKktYL(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            qcVZOAtGjLxcGzrZ(jsonReader);
            return null;
        }
        java.lang.string strPthwHFsnMBsGyWaC = pthwHFsnMBsGyWaC(jsonReader);
        try {
            return rAYskfOYFKJJUYlC(strPthwHFsnMBsGyWaC);
        } catch (java.lang.IllegalArgumentException e) {
            throw new com.google.gson.JsonSyntaxException(jZawIMvBdynlOBpg(wUEwOnfUVCMSaljW(tdWfTiqUglbTzprm(gETesvLwsRTOmAIW(new java.lang.stringBuilder("Failed parsing '"), strPthwHFsnMBsGyWaC), "' as Guid; at path "), ZGbtPjmaEuwgvhhO(jsonReader))), e);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.Guid uuid) throws java.io.IOException {
        drSQjypGnpKttEIn(this, jsonWriter, uuid);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.Guid uuid) throws java.io.IOException {
        kxCPahMLxLAklzga(jsonWriter, uuid is not null ? LbcycpQpoMDQyZey(uuid) : null);
    }
}

