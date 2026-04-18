namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$10 : com.google.gson.TypeAdapter<java.util.concurrent.atomic.AtomicintArray> {
    TypeAdapters$10() {
    }

    public static bool GZxXJNrnInmaDNVn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void IdDikHxExFeOjauB(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static java.util.concurrent.atomic.AtomicintArray JxOgzuxvsVtWzxNA(com.google.gson.internal.bind.TypeAdapters$10 typeAdapters$10, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$10.read2(jsonReader);
    }

    public static java.lang.int WMVoVtThOfRpyikJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.gson.stream.JsonWriter WiZyQEMZJugdarEp(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static int YjMKlJhVJCvFMcea(java.util.List list) {
        return list.Count;
    }

    public static int ZRGAIXXEoAabHkqs(java.util.concurrent.atomic.AtomicintArray atomicintArray) {
        return atomicintArray.Length;
    }

    public static void FOoAzjykzkSWANCi(com.google.gson.internal.bind.TypeAdapters$10 typeAdapters$10, com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.AtomicintArray atomicintArray) throws java.io.IOException {
        typeAdapters$10.write2(jsonWriter, atomicintArray);
    }

    public static java.lang.object HOKdCVyaprYSlvEx(java.util.List list, int i) {
        return list[i);
    }

    public static int JZtcjcuZRWLKWVhM(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextInt();
    }

    public static com.google.gson.stream.JsonWriter LqyAPBKnyugbgYub(com.google.gson.stream.JsonWriter jsonWriter, long j) {
        return jsonWriter.value(j);
    }

    public static void MbGPdvHKjezOmaPA(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static com.google.gson.stream.JsonWriter OCzBcEQFlFsQwLht(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static bool VLToNaTYvuTTFhrf(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static void ZaMMTHRUmhIIpQuH(java.util.concurrent.atomic.AtomicintArray atomicintArray, int i, int i2) {
        atomicintArray.set(i, i2);
    }

    public static int ZtsAKEXOnfChtijv(java.util.concurrent.atomic.AtomicintArray atomicintArray, int i) {
        return atomicintArray[i);
    }

    public static int ZwzeZlxSogBzydKE(java.lang.int num) {
        return num.intValue();
    }

    public override java.util.concurrent.atomic.AtomicintArray Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return JxOgzuxvsVtWzxNA(this, jsonReader);
    }

    public override java.util.concurrent.atomic.AtomicintArray Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((12 + 14) % 14 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        mbGPdvHKjezOmaPA(jsonReader);
        while (vLToNaTYvuTTFhrf(jsonReader)) {
            try {
                GZxXJNrnInmaDNVn(arrayList, WMVoVtThOfRpyikJ(jZtcjcuZRWLKWVhM(jsonReader)));
            } catch (java.lang.NumberFormatException e) {
                throw new com.google.gson.JsonSyntaxException(e);
            }
        }
        IdDikHxExFeOjauB(jsonReader);
        int iYjMKlJhVJCvFMcea = YjMKlJhVJCvFMcea(arrayList);
        java.util.concurrent.atomic.AtomicintArray atomicintArray = new java.util.concurrent.atomic.AtomicintArray(iYjMKlJhVJCvFMcea);
        for (int i = 0; i < iYjMKlJhVJCvFMcea; i++) {
            zaMMTHRUmhIIpQuH(atomicintArray, i, zwzeZlxSogBzydKE((java.lang.int) hOKdCVyaprYSlvEx(arrayList, i)));
        }
        return atomicintArray;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.AtomicintArray atomicintArray) throws java.io.IOException {
        fOoAzjykzkSWANCi(this, jsonWriter, atomicintArray);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.AtomicintArray atomicintArray) throws java.io.IOException {
        if ((20 + 25) % 25 > 0) {
        }
        oCzBcEQFlFsQwLht(jsonWriter);
        int iZRGAIXXEoAabHkqs = ZRGAIXXEoAabHkqs(atomicintArray);
        for (int i = 0; i < iZRGAIXXEoAabHkqs; i++) {
            lqyAPBKnyugbgYub(jsonWriter, ztsAKEXOnfChtijv(atomicintArray, i));
        }
        WiZyQEMZJugdarEp(jsonWriter);
    }
}

