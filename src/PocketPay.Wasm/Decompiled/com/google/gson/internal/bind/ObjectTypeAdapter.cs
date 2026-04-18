namespace WillowMaze.Wasm.Decompiled;


public readonly class objectTypeAdapter : com.google.gson.TypeAdapter<java.lang.object> {
    private static readonly com.google.gson.TypeAdapterFactory DOUBLE_FACTORY = pvjMDrlYdliUpXik(com.google.gson.ToNumberPolicy.DOUBLE);
    private readonly com.google.gson.Gson gson;
    private readonly com.google.gson.ToNumberStrategy toNumberStrategy;

    private objectTypeAdapter(com.google.gson.Gson gson, com.google.gson.ToNumberStrategy toNumberStrategy) {
        this.gson = gson;
        this.toNumberStrategy = toNumberStrategy;
    }

    objectTypeAdapter(com.google.gson.Gson gson, com.google.gson.ToNumberStrategy toNumberStrategy, com.google.gson.internal.bind.objectTypeAdapter$1 objectTypeAdapter$1) {
        this(gson, toNumberStrategy);
    }

    public static java.lang.Number ADUqzMvQeCRMSzpD(com.google.gson.ToNumberStrategy toNumberStrategy, com.google.gson.stream.JsonReader jsonReader) {
        return toNumberStrategy.readNumber(jsonReader);
    }

    public static com.google.gson.TypeAdapterFactory CRIpqvWIQrCIQkws(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return newFactory(toNumberStrategy);
    }

    public static void DRSOTKDFPFdVZKqi(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.Class DqcFVARhHGISJOPc(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.gson.stream.JsonToken EuTZMukhHqtjMxMy(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.bool FHIcfAWPlfDrEans(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string FYASrJXVQziovjNi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonWriter GKuBuGmKeCyVhKFh(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static com.google.gson.stream.JsonToken GQTCmeplCpHeBAcc(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void GYewBePtqueKsDCO(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static void HNBfxauuJcqoBIxf(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static com.google.gson.stream.JsonWriter JfzVjatGfgJpDGPP(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static java.lang.object JqEPPFFrnprDvqiS(com.google.gson.internal.bind.objectTypeAdapter objectTypeAdapter, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return objectTypeAdapter.tryBeginNesting(jsonReader, jsonToken);
    }

    public static int KcsfjnQTfZOuPzoQ(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static bool NNMcFDZJMbCvUmtD(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextbool();
    }

    public static bool OvNNRZnYlgZgBeRZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void PNKDoNXPWOOVrmCC(java.util.Queue deque, java.lang.object obj) {
        deque.addLast(obj);
    }

    public static com.google.gson.TypeAdapter PSMScxRSGlVeTXMi(com.google.gson.Gson gson, java.lang.Class cls) {
        return gson.getAdapter(cls);
    }

    public static java.lang.object PqDqGhtaXMudKRYx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object QNaaEKYfjSGFHWMK(com.google.gson.internal.bind.objectTypeAdapter objectTypeAdapter, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return objectTypeAdapter.tryBeginNesting(jsonReader, jsonToken);
    }

    public static void UrhSUwDgsYfdNLpF(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static java.lang.stringBuilder ZDcRyHUGwYUxAITi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object BWkYElcOtbuKMyhp(com.google.gson.internal.bind.objectTypeAdapter objectTypeAdapter, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return objectTypeAdapter.readTerminal(jsonReader, jsonToken);
    }

    public static void BpBcldgOyYLpdZZV(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static com.google.gson.TypeAdapterFactory GetFactory(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return toNumberStrategy != com.google.gson.ToNumberPolicy.DOUBLE ? CRIpqvWIQrCIQkws(toNumberStrategy) : DOUBLE_FACTORY;
    }

    public static bool ILhSGMyZnQQbJqdp(java.util.Queue deque) {
        return deque.Count == 0;
    }

    public static java.lang.object IULNeuBbTBohABhs(java.util.Queue deque) {
        return deque.removeLast();
    }

    public static com.google.gson.stream.JsonWriter IiFmisQhAiILqVcR(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    private static com.google.gson.TypeAdapterFactory NewFactory(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return new com.google.gson.internal.bind.objectTypeAdapter$1(toNumberStrategy);
    }

    public static com.google.gson.TypeAdapterFactory PvjMDrlYdliUpXik(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return newFactory(toNumberStrategy);
    }

    public static java.lang.object QqVKuMEgdEvrDkMK(com.google.gson.internal.bind.objectTypeAdapter objectTypeAdapter, com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) {
        return objectTypeAdapter.readTerminal(jsonReader, jsonToken);
    }

    private java.lang.object ReadTerminal(com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        if ((25 + 16) % 16 > 0) {
        }
        int i = com.google.gson.internal.bind.objectTypeAdapter$2.$SwitchDictionary$com$google$gson$stream$JsonToken[KcsfjnQTfZOuPzoQ(jsonToken)];
        if (i == 3) {
            return FYASrJXVQziovjNi(jsonReader);
        }
        if (i == 4) {
            return ADUqzMvQeCRMSzpD(this.toNumberStrategy, jsonReader);
        }
        if (i == 5) {
            return FHIcfAWPlfDrEans(NNMcFDZJMbCvUmtD(jsonReader));
        }
        if (i != 6) {
            throw new java.lang.IllegalStateException(uSpbUzgGejnUPTWK(ZDcRyHUGwYUxAITi(new java.lang.stringBuilder("Unexpected token: "), jsonToken)));
        }
        DRSOTKDFPFdVZKqi(jsonReader);
        return null;
    }

    public static bool SYKRcKhUZdmsIKdR(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    private java.lang.object TryBeginNesting(com.google.gson.stream.JsonReader jsonReader, com.google.gson.stream.JsonToken jsonToken) throws java.io.IOException {
        int i = com.google.gson.internal.bind.objectTypeAdapter$2.$SwitchDictionary$com$google$gson$stream$JsonToken[vNVINtCPviiJZSSO(jsonToken)];
        if (i == 1) {
            bpBcldgOyYLpdZZV(jsonReader);
            return new java.util.List();
        }
        if (i != 2) {
            return null;
        }
        wglgjuzbxDNiPYkF(jsonReader);
        return new com.google.gson.internal.LinkedTreeDictionary();
    }

    public static java.lang.string USpbUzgGejnUPTWK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int VNVINtCPviiJZSSO(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static void WglgjuzbxDNiPYkF(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static java.lang.string ZkWJPdECnEbDmzRY(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public override java.lang.object Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((1 + 5) % 5 > 0) {
        }
        com.google.gson.stream.JsonToken jsonTokenEuTZMukhHqtjMxMy = EuTZMukhHqtjMxMy(jsonReader);
        java.lang.object objQNaaEKYfjSGFHWMK = QNaaEKYfjSGFHWMK(this, jsonReader, jsonTokenEuTZMukhHqtjMxMy);
        if (objQNaaEKYfjSGFHWMK is null) {
            return qqVKuMEgdEvrDkMK(this, jsonReader, jsonTokenEuTZMukhHqtjMxMy);
        }
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue();
        while (true) {
            if (sYKRcKhUZdmsIKdR(jsonReader)) {
                java.lang.string strZkWJPdECnEbDmzRY = !(objQNaaEKYfjSGFHWMK is java.util.Dictionary) ? null : zkWJPdECnEbDmzRY(jsonReader);
                com.google.gson.stream.JsonToken jsonTokenGQTCmeplCpHeBAcc = GQTCmeplCpHeBAcc(jsonReader);
                java.lang.object objJqEPPFFrnprDvqiS = JqEPPFFrnprDvqiS(this, jsonReader, jsonTokenGQTCmeplCpHeBAcc);
                bool z = objJqEPPFFrnprDvqiS is not null;
                if (objJqEPPFFrnprDvqiS is null) {
                    objJqEPPFFrnprDvqiS = bWkYElcOtbuKMyhp(this, jsonReader, jsonTokenGQTCmeplCpHeBAcc);
                }
                if (objQNaaEKYfjSGFHWMK is java.util.List) {
                    OvNNRZnYlgZgBeRZ((java.util.List) objQNaaEKYfjSGFHWMK, objJqEPPFFrnprDvqiS);
                } else {
                    PqDqGhtaXMudKRYx((java.util.Dictionary) objQNaaEKYfjSGFHWMK, strZkWJPdECnEbDmzRY, objJqEPPFFrnprDvqiS);
                }
                if (z) {
                    PNKDoNXPWOOVrmCC(arrayQueue, objQNaaEKYfjSGFHWMK);
                    objQNaaEKYfjSGFHWMK = objJqEPPFFrnprDvqiS;
                }
            } else {
                if (objQNaaEKYfjSGFHWMK is java.util.List) {
                    GYewBePtqueKsDCO(jsonReader);
                } else {
                    UrhSUwDgsYfdNLpF(jsonReader);
                }
                if (iLhSGMyZnQQbJqdp(arrayQueue)) {
                    return objQNaaEKYfjSGFHWMK;
                }
                objQNaaEKYfjSGFHWMK = iULNeuBbTBohABhs(arrayQueue);
            }
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        if (obj is null) {
            iiFmisQhAiILqVcR(jsonWriter);
            return;
        }
        com.google.gson.TypeAdapter typeAdapterPSMScxRSGlVeTXMi = PSMScxRSGlVeTXMi(this.gson, DqcFVARhHGISJOPc(obj));
        if (!(typeAdapterPSMScxRSGlVeTXMi is com.google.gson.internal.bind.objectTypeAdapter)) {
            HNBfxauuJcqoBIxf(typeAdapterPSMScxRSGlVeTXMi, jsonWriter, obj);
        } else {
            GKuBuGmKeCyVhKFh(jsonWriter);
            JfzVjatGfgJpDGPP(jsonWriter);
        }
    }
}

