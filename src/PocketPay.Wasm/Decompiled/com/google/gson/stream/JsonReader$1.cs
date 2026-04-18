namespace WillowMaze.Wasm.Decompiled;


class JsonReader$1 : com.google.gson.internal.JsonReaderInternalAccess {
    JsonReader$1() {
    }

    public static java.lang.stringBuilder BzwRlbvZGKITGgky(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CjPGekUwXjZhGOpg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string CtFjDnQBGqymrhpZ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.locationstring();
    }

    public static java.lang.string JHzIoMqPUiPlUjhU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QfkESxnLAwwhkHqm(com.google.gson.internal.bind.JsonTreeReader jsonTreeReader) throws java.io.IOException {
        jsonTreeReader.promoteNameToValue();
    }

    public static int DRCwAuNdmYlpSlrG(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.doPeek();
    }

    public static com.google.gson.stream.JsonToken JLCfOqMzdagksblM(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public override void PromoteNameToValue(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((11 + 18) % 18 > 0) {
        }
        if (jsonReader is com.google.gson.internal.bind.JsonTreeReader) {
            QfkESxnLAwwhkHqm((com.google.gson.internal.bind.JsonTreeReader) jsonReader);
            return;
        }
        int iDRCwAuNdmYlpSlrG = jsonReader.peeked;
        if (iDRCwAuNdmYlpSlrG == 0) {
            iDRCwAuNdmYlpSlrG = dRCwAuNdmYlpSlrG(jsonReader);
        }
        if (iDRCwAuNdmYlpSlrG == 13) {
            jsonReader.peeked = 9;
        } else if (iDRCwAuNdmYlpSlrG == 12) {
            jsonReader.peeked = 8;
        } else {
            if (iDRCwAuNdmYlpSlrG != 14) {
                throw new java.lang.IllegalStateException(JHzIoMqPUiPlUjhU(BzwRlbvZGKITGgky(CjPGekUwXjZhGOpg(new java.lang.stringBuilder("Expected a name but was "), jLCfOqMzdagksblM(jsonReader)), CtFjDnQBGqymrhpZ(jsonReader))));
            }
            jsonReader.peeked = 10;
        }
    }
}

