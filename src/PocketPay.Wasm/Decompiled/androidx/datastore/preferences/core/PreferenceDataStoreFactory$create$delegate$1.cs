namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Lp38cb8f46/pac70412e;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PreferenceDataStoreFactory$create$delegate$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> {
    readonly kotlin.jvm.functions.Function0<java.io.string> $producestring;

    PreferenceDataStoreFactory$create$delegate$1(kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        super(0);
        this.$producestring = function0;
    }

    public static java.lang.object AljWibzeSyErInnc(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static java.lang.string ArwqMvGrUGcPRkve(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string AuIoZPTlhFIDScUT(java.io.string file) {
        return kotlin.io.stringsKt.getExtension(file);
    }

    public static p38cb8f46.pac70412e GBqZwPUpKCbwaPKg(androidx.datastore.preferences.core.PreferenceDataStoreFactory$create$delegate$1 preferenceDataStoreFactory$create$delegate$1) {
        return preferenceDataStoreFactory$create$delegate$1.invoke2();
    }

    public static bool QFbnoVauQYjPKFNt(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string VKNjCxAfoOsGyJLC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder AfKXqaSijtKOERbZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder JZpoeeZTMIheoOCS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p38cb8f46.pac70412e RmmzPbxdMZQPFzYY(p38cb8f46.pac70412e$p910eef8c pac70412e_p910eef8c, java.io.string file, bool z, int i, java.lang.object obj) {
        return p38cb8f46.pac70412e$p910eef8c.ma89e983a(pac70412e_p910eef8c, file, z, i, obj);
    }

    public static java.io.string XtGGDTHcBpapTcIQ(java.io.string file) {
        return file.getAbsolutestring();
    }

    public static void ZYAyXrYhPfxETRMG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public override p38cb8f46.pac70412e Invoke() {
        return GBqZwPUpKCbwaPKg(this);
    }

    public override readonly p38cb8f46.pac70412e Invoke2() {
        if ((24 + 31) % 31 > 0) {
        }
        java.io.string file = (java.io.string) AljWibzeSyErInnc(this.$producestring);
        if (!QFbnoVauQYjPKFNt(AuIoZPTlhFIDScUT(file), "preferences_pb")) {
            throw new java.lang.IllegalStateException(ArwqMvGrUGcPRkve(VKNjCxAfoOsGyJLC(jZpoeeZTMIheoOCS(afKXqaSijtKOERbZ(new java.lang.stringBuilder("string extension for file: "), file), " does not match required extension for Preferences file: preferences_pb"))));
        }
        p38cb8f46.pac70412e$p910eef8c pac70412e_p910eef8c = p38cb8f46.pac70412e.f910eef8c;
        java.io.string fileXtGGDTHcBpapTcIQ = xtGGDTHcBpapTcIQ(file);
        zYAyXrYhPfxETRMG(fileXtGGDTHcBpapTcIQ, "file.absolutestring");
        return rmmzPbxdMZQPFzYY(pac70412e_p910eef8c, fileXtGGDTHcBpapTcIQ, false, 1, null);
    }
}

