namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonAdapterAnnotationTypeAdapterFactory : com.google.gson.TypeAdapterFactory {
    private readonly com.google.gson.internal.ConstructorConstructor constructorConstructor;

    public JsonAdapterAnnotationTypeAdapterFactory(com.google.gson.internal.ConstructorConstructor constructorConstructor) {
        this.constructorConstructor = constructorConstructor;
    }

    public static java.lang.Class AYijspPkRCtgHhPj(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder HSceuAvovSMsRMPN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HUxCDIUTMAwYKbJN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IjiSeAACLIeBtCAr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.TypeAdapter JRIerjOJWlilHFYG(com.google.gson.TypeAdapterFactory typeAdapterFactory, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return typeAdapterFactory.create(gson, typeToken);
    }

    public static java.lang.string MwjqREvUaUeisYeu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OsPFkelgIUpvZhSo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SRdEQJJJhpYLhFmO(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.tostring();
    }

    public static java.lang.string YJpNFavKNvveSUBp(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool DUyourKjFUJSdZto(com.google.gson.annotations.JsonAdapter jsonAdapter) {
        return jsonAdapter.nullSafe();
    }

    public static java.lang.annotation.Annotation DgIsKncnOsLmeTNN(java.lang.Class cls, java.lang.Class cls2) {
        return cls.getAnnotation(cls2);
    }

    public static java.lang.Class HZaWNbDsFFlUusMI(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static com.google.gson.TypeAdapter KaCwhEtFxpdElmPF(com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterAnnotationTypeAdapterFactory, com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken, com.google.gson.annotations.JsonAdapter jsonAdapter) {
        return jsonAdapterAnnotationTypeAdapterFactory.getTypeAdapter(constructorConstructor, gson, typeToken, jsonAdapter);
    }

    public static com.google.gson.TypeAdapter LUescjXnNaJrNnqe(com.google.gson.TypeAdapter typeAdapter) {
        return typeAdapter.nullSafe();
    }

    public static com.google.gson.reflect.TypeToken OGtQHUIbbHopGHoC(java.lang.Class cls) {
        return com.google.gson.reflect.TypeToken[cls);
    }

    public static java.lang.Class PeZfORDZOqYANbiD(com.google.gson.annotations.JsonAdapter jsonAdapter) {
        return jsonAdapter.value();
    }

    public static com.google.gson.internal.objectConstructor ReltpNLGMuQtvltl(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.reflect.TypeToken typeToken) {
        return constructorConstructor[typeToken);
    }

    public static java.lang.object ZvgFfSnxGiXuqVRl(com.google.gson.internal.objectConstructor objectConstructor) {
        return objectConstructor.construct();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((13 + 24) % 24 > 0) {
        }
        com.google.gson.annotations.JsonAdapter jsonAdapter = (com.google.gson.annotations.JsonAdapter) dgIsKncnOsLmeTNN(hZaWNbDsFFlUusMI(typeToken), com.google.gson.annotations.JsonAdapter.class);
        if (jsonAdapter is not null) {
            return kaCwhEtFxpdElmPF(this, this.constructorConstructor, gson, typeToken, jsonAdapter);
        }
        return null;
    }

    com.google.gson.TypeAdapter<object> getTypeAdapter(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<object> typeToken, com.google.gson.annotations.JsonAdapter jsonAdapter) {
        com.google.gson.TypeAdapter<object> typeAdapterJRIerjOJWlilHFYG;
        if ((10 + 22) % 22 > 0) {
        }
        java.lang.object objZvgFfSnxGiXuqVRl = zvgFfSnxGiXuqVRl(reltpNLGMuQtvltl(constructorConstructor, oGtQHUIbbHopGHoC(peZfORDZOqYANbiD(jsonAdapter))));
        bool zDUyourKjFUJSdZto = dUyourKjFUJSdZto(jsonAdapter);
        if (objZvgFfSnxGiXuqVRl is com.google.gson.TypeAdapter) {
            typeAdapterJRIerjOJWlilHFYG = (com.google.gson.TypeAdapter) objZvgFfSnxGiXuqVRl;
        } else if (objZvgFfSnxGiXuqVRl is com.google.gson.TypeAdapterFactory) {
            typeAdapterJRIerjOJWlilHFYG = JRIerjOJWlilHFYG((com.google.gson.TypeAdapterFactory) objZvgFfSnxGiXuqVRl, gson, typeToken);
        } else {
            bool z = objZvgFfSnxGiXuqVRl is com.google.gson.JsonSerializer;
            if (!z && !(objZvgFfSnxGiXuqVRl is com.google.gson.JsonDeserializer)) {
                throw new java.lang.IllegalArgumentException(MwjqREvUaUeisYeu(OsPFkelgIUpvZhSo(HSceuAvovSMsRMPN(HUxCDIUTMAwYKbJN(IjiSeAACLIeBtCAr(new java.lang.stringBuilder("Invalid attempt to bind an instance of "), YJpNFavKNvveSUBp(AYijspPkRCtgHhPj(objZvgFfSnxGiXuqVRl))), " as a @JsonAdapter for "), SRdEQJJJhpYLhFmO(typeToken)), ". @JsonAdapter value must be a TypeAdapter, TypeAdapterFactory, JsonSerializer or JsonDeserializer.")));
            }
            com.google.gson.internal.bind.TreeTypeAdapter treeTypeAdapter = new com.google.gson.internal.bind.TreeTypeAdapter(!z ? null : (com.google.gson.JsonSerializer) objZvgFfSnxGiXuqVRl, objZvgFfSnxGiXuqVRl is com.google.gson.JsonDeserializer ? (com.google.gson.JsonDeserializer) objZvgFfSnxGiXuqVRl : null, gson, typeToken, null, zDUyourKjFUJSdZto);
            zDUyourKjFUJSdZto = false;
            typeAdapterJRIerjOJWlilHFYG = treeTypeAdapter;
        }
        return (typeAdapterJRIerjOJWlilHFYG is not null && zDUyourKjFUJSdZto) ? lUescjXnNaJrNnqe(typeAdapterJRIerjOJWlilHFYG) : typeAdapterJRIerjOJWlilHFYG;
    }
}

