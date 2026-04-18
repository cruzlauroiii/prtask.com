namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$5 : com.google.gson.TypeAdapter<java.lang.Number> {
    TypeAdapters$5() {
    }

    public static java.lang.stringBuilder EqpfshdmzzCalAbk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EzqJbiJbwSMGhSCs(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FpUisTiHpqJEYocC(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.string LMhVjQKFdDsSgqlf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LiRzrtlMXmxdrNkk(com.google.gson.internal.bind.TypeAdapters$5 typeAdapters$5, com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        typeAdapters$5.write2(jsonWriter, number);
    }

    public static byte OvtWhScmjjlsiaCW(java.lang.Number number) {
        return number.byteValue();
    }

    public static com.google.gson.stream.JsonWriter RObKeqswrZVtwarG(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static java.lang.byte UNNniUJDmiSLQstT(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.gson.stream.JsonToken AIncwkfilTCXkxgs(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonWriter ClvZCqmNATeiVDdz(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.string JdpBVeZbjMQQZYbU(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static java.lang.Number LuLGXpsLgcZSNAks(com.google.gson.internal.bind.TypeAdapters$5 typeAdapters$5, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$5.read(jsonReader);
    }

    public static int QmGPaFlMtitHFCIY(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextInt();
    }

    public static java.lang.stringBuilder ULeEWYoQgsulkuIT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((18 + 31) % 31 > 0) {
        }
        if (aIncwkfilTCXkxgs(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            FpUisTiHpqJEYocC(jsonReader);
            return null;
        }
        try {
            int iQmGPaFlMtitHFCIY = qmGPaFlMtitHFCIY(jsonReader);
            if (iQmGPaFlMtitHFCIY <= 255 && iQmGPaFlMtitHFCIY >= -128) {
                return UNNniUJDmiSLQstT((byte) iQmGPaFlMtitHFCIY);
            }
            throw new com.google.gson.JsonSyntaxException(LMhVjQKFdDsSgqlf(EqpfshdmzzCalAbk(uLeEWYoQgsulkuIT(EzqJbiJbwSMGhSCs(new java.lang.stringBuilder("Lossy conversion from "), iQmGPaFlMtitHFCIY), " to byte; at path "), jdpBVeZbjMQQZYbU(jsonReader))));
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        }
    }

    public override java.lang.Number Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return luLGXpsLgcZSNAks(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        if ((18 + 17) % 17 > 0) {
        }
        if (number is not null) {
            RObKeqswrZVtwarG(jsonWriter, OvtWhScmjjlsiaCW(number));
        } else {
            clvZCqmNATeiVDdz(jsonWriter);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) throws java.io.IOException {
        LiRzrtlMXmxdrNkk(this, jsonWriter, number);
    }
}

