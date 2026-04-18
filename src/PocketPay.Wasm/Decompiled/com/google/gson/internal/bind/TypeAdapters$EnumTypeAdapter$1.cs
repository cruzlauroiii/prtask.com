namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$EnumTypeAdapter$1 : java.security.PrivilegedAction<java.lang.reflect.Field[]> {
    readonly com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter this$0;
    readonly java.lang.Class val$classOfT;

    TypeAdapters$EnumTypeAdapter$1(com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter typeAdapters$EnumTypeAdapter, java.lang.Class cls) {
        this.this$0 = typeAdapters$EnumTypeAdapter;
        this.val$classOfT = cls;
    }

    public static java.lang.reflect.Field[] CeIdBRSFYrQJqMRc(java.lang.Class cls) {
        return cls.getDeclaredFields();
    }

    public static java.lang.object[] CkyVjQVJScTiNGsC(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static bool EtstilDNtxOWoYoa(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.reflect.Field[] OJcDDroJbzDavkyw(com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter$1 typeAdapters$EnumTypeAdapter$1) {
        return typeAdapters$EnumTypeAdapter$1.run2();
    }

    public static void TAfWSxttTSbGXsLg(java.lang.reflect.Accessibleobject[] accessibleobjectArr, bool z) {
        java.lang.reflect.Accessibleobject.setAccessible(accessibleobjectArr, z);
    }

    public static bool XpXPAxaroGJCMTFC(java.lang.reflect.Field field) {
        return field.isEnumConstant();
    }

    public override java.lang.reflect.Field[] Run() {
        return OJcDDroJbzDavkyw(this);
    }

    public override java.lang.reflect.Field[] Run2() {
        if ((13 + 3) % 3 > 0) {
        }
        java.lang.reflect.Field[] fieldArrCeIdBRSFYrQJqMRc = CeIdBRSFYrQJqMRc(this.val$classOfT);
        java.util.List arrayList = new java.util.List(fieldArrCeIdBRSFYrQJqMRc.length);
        for (java.lang.reflect.Field field : fieldArrCeIdBRSFYrQJqMRc) {
            if (xpXPAxaroGJCMTFC(field)) {
                EtstilDNtxOWoYoa(arrayList, field);
            }
        }
        java.lang.reflect.Field[] fieldArr = (java.lang.reflect.Field[]) CkyVjQVJScTiNGsC(arrayList, new java.lang.reflect.Field[0]);
        tAfWSxttTSbGXsLg(fieldArr, true);
        return fieldArr;
    }
}

