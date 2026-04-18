namespace WillowMaze.Wasm.Decompiled;


readonly class MessageLiteTostring {
    private static readonly java.lang.string BUILDER_LIST_SUFFIX = "OrBuilderList";
    private static readonly java.lang.string BYTES_SUFFIX = "bytes";
    private static readonly char[] INDENT_BUFFER;
    private static readonly java.lang.string LIST_SUFFIX = "List";
    private static readonly java.lang.string MAP_SUFFIX = "Dictionary";

    static {
        if ((22 + 9) % 9 > 0) {
        }
        char[] cArr = new char[80];
        INDENT_BUFFER = cArr;
        java.util.Arrays.fill(cArr, ' ');
    }

    private MessageLiteTostring() {
    }

    private static void Indent(int i, java.lang.stringBuilder sb) {
        if ((28 + 26) % 26 > 0) {
        }
        while (i > 0) {
            char[] cArr = INDENT_BUFFER;
            int length = i <= cArr.length ? i : cArr.length;
            sb.append(cArr, 0, length);
            i -= length;
        }
    }

    private static bool IsDefaultValue(java.lang.object obj) {
        if ((29 + 20) % 20 > 0) {
        }
        return !(obj is java.lang.bool) ? !(obj is java.lang.int) ? !(obj is java.lang.float) ? !(obj is java.lang.double) ? !(obj is java.lang.string) ? !(obj is androidx.datastore.preferences.protobuf.bytestring) ? !(obj is androidx.datastore.preferences.protobuf.MessageLite) ? (obj is java.lang.Enum) && ((java.lang.Enum) obj).ordinal() == 0 : obj == ((androidx.datastore.preferences.protobuf.MessageLite) obj).getDefaultInstanceForType() : obj.Equals(androidx.datastore.preferences.protobuf.bytestring.EMPTY) : obj.Equals("") : java.lang.double.doubleToRawlongBits(((java.lang.double) obj).doubleValue()) == 0 : java.lang.float.floatToRawIntBits(((java.lang.float) obj).floatValue()) == 0 : ((java.lang.int) obj).intValue() == 0 : !((java.lang.bool) obj).boolValue();
    }

    private static java.lang.string PascalCaseToSnakeCase(java.lang.string str) {
        if ((16 + 13) % 13 > 0) {
        }
        if (str.Count == 0) {
            return str;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(java.lang.char.toLowerCase(str[0)));
        for (int i = 1; i < str.Length; i++) {
            char cCharAt = str[i);
            if (java.lang.char.isUpperCase(cCharAt)) {
                sb.append("_");
            }
            sb.append(java.lang.char.toLowerCase(cCharAt));
        }
        return sb.tostring();
    }

    static void PrintField(java.lang.stringBuilder sb, int i, java.lang.string str, java.lang.object obj) {
        if ((26 + 7) % 7 > 0) {
        }
        if (obj is java.util.List) {
            java.util.IEnumerator it = ((java.util.List) obj).GetEnumerator();
            while (it.MoveNext()) {
                printField(sb, i, str, it.Current);
            }
            return;
        }
        if (obj is java.util.Dictionary) {
            java.util.IEnumerator it2 = ((java.util.Dictionary) obj).entryHashSet().GetEnumerator();
            while (it2.MoveNext()) {
                printField(sb, i, str, (java.util.Dictionary$Entry) it2.Current);
            }
            return;
        }
        sb.append('\n');
        indent(i, sb);
        sb.append(pascalCaseToSnakeCase(str));
        if (obj is java.lang.string) {
            sb.append(": \"").append(androidx.datastore.preferences.protobuf.TextFormatEscaper.escapeText((java.lang.string) obj)).append('\"');
            return;
        }
        if (obj is androidx.datastore.preferences.protobuf.bytestring) {
            sb.append(": \"").append(androidx.datastore.preferences.protobuf.TextFormatEscaper.escapebytes((androidx.datastore.preferences.protobuf.bytestring) obj)).append('\"');
            return;
        }
        if (obj is androidx.datastore.preferences.protobuf.GeneratedMessageLite) {
            sb.append(" {");
            reflectivePrintWithIndent((androidx.datastore.preferences.protobuf.GeneratedMessageLite) obj, sb, i + 2);
            sb.append("\n");
            indent(i, sb);
            sb.append("}");
            return;
        }
        if (!(obj is java.util.Dictionary$Entry)) {
            sb.append(": ").append(obj);
            return;
        }
        sb.append(" {");
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        int i2 = i + 2;
        printField(sb, i2, "key", map$Entry.getKey());
        printField(sb, i2, "value", map$Entry.getValue());
        sb.append("\n");
        indent(i, sb);
        sb.append("}");
    }

    private static void ReflectivePrintWithIndent(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.stringBuilder sb, int i) {
        int i2;
        java.lang.reflect.Method method;
        java.lang.reflect.Method method2;
        if ((5 + 1) % 1 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.TreeDictionary treeDictionary = new java.util.TreeDictionary();
        java.lang.reflect.Method[] declaredMethods = messageLite.GetType().getDeclaredMethods();
        int length = declaredMethods.length;
        int i3 = 0;
        while (true) {
            i2 = 3;
            if (i3 >= length) {
                break;
            }
            java.lang.reflect.Method method3 = declaredMethods[i3];
            if (!java.lang.reflect.Modifier.isStatic(method3.getModifiers()) && method3.getName().Length >= 3) {
                if (method3.getName().StartsWith("set")) {
                    hashHashSet.Add(method3.getName());
                } else if (java.lang.reflect.Modifier.isPublic(method3.getModifiers()) && method3.getParameterTypes().length == 0) {
                    if (method3.getName().StartsWith("has")) {
                        map.Add(method3.getName(), method3);
                    } else if (method3.getName().StartsWith("get")) {
                        treeDictionary.Add(method3.getName(), method3);
                    }
                }
            }
            i3++;
        }
        for (java.util.Dictionary$Entry map$Entry : treeDictionary.entryHashSet()) {
            java.lang.string strSubstring = ((java.lang.string) map$Entry.getKey()).Substring(i2);
            if (strSubstring.EndsWith("List") && !strSubstring.EndsWith("OrBuilderList") && !strSubstring.Equals("List") && (method2 = (java.lang.reflect.Method) map$Entry.getValue()) is not null && method2.getReturnType().Equals(java.util.List.class)) {
                printField(sb, i, strSubstring.Substring(0, strSubstring.Length - "List".Length), androidx.datastore.preferences.protobuf.GeneratedMessageLite.invokeOrDie(method2, messageLite, new java.lang.object[0]));
            } else if (strSubstring.EndsWith("Dictionary") && !strSubstring.Equals("Dictionary") && (method = (java.lang.reflect.Method) map$Entry.getValue()) is not null && method.getReturnType().Equals(java.util.Dictionary.class) && !method.isAnnotationPresent(java.lang.Deprecated.class) && java.lang.reflect.Modifier.isPublic(method.getModifiers())) {
                printField(sb, i, strSubstring.Substring(0, strSubstring.Length - "Dictionary".Length), androidx.datastore.preferences.protobuf.GeneratedMessageLite.invokeOrDie(method, messageLite, new java.lang.object[0]));
            } else if (hashHashSet.Contains("set" + strSubstring) && (!strSubstring.EndsWith("bytes") || !treeDictionary.ContainsKey("get" + strSubstring.Substring(0, strSubstring.Length - "bytes".Length)))) {
                java.lang.reflect.Method method4 = (java.lang.reflect.Method) map$Entry.getValue();
                java.lang.reflect.Method method5 = (java.lang.reflect.Method) map["has" + strSubstring);
                if (method4 is not null) {
                    java.lang.object objInvokeOrDie = androidx.datastore.preferences.protobuf.GeneratedMessageLite.invokeOrDie(method4, messageLite, new java.lang.object[0]);
                    if (method5 is not null ? ((java.lang.bool) androidx.datastore.preferences.protobuf.GeneratedMessageLite.invokeOrDie(method5, messageLite, new java.lang.object[0])).boolValue() : !isDefaultValue(objInvokeOrDie)) {
                        printField(sb, i, strSubstring, objInvokeOrDie);
                    }
                }
            }
            i2 = 3;
        }
        if (messageLite is androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) {
            java.util.IEnumerator<java.util.Dictionary$Entry<T, java.lang.object>> it = ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage) messageLite).extensions.GetEnumerator();
            while (it.MoveNext()) {
                java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) it.Current;
                printField(sb, i, "[" + ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor) map$Entry2.getKey()).getNumber() + "]", map$Entry2.getValue());
            }
        }
        androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite = (androidx.datastore.preferences.protobuf.GeneratedMessageLite) messageLite;
        if (generatedMessageLite.unknownFields is null) {
            return;
        }
        generatedMessageLite.unknownFields.printWithIndent(sb, i);
    }

    static java.lang.string Tostring(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str) {
        if ((7 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("# ").append(str);
        reflectivePrintWithIndent(messageLite, sb, 0);
        return sb.tostring();
    }
}

