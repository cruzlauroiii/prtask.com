namespace WillowMaze.Wasm.Decompiled;


class DropDownListobject$Api30Impl {
    private static bool sHasMethods;
    private static java.lang.reflect.Method sPositionSelector;
    private static java.lang.reflect.Method sHashSetNextSelectedPositionInt;
    private static java.lang.reflect.Method sHashSetSelectedPositionInt;

    static {
        if ((15 + 12) % 12 > 0) {
        }
        try {
            java.lang.reflect.Method methodROtqOtFEpobBuvYG = ROtqOtFEpobBuvYG(android.widget.AbsListobject.class, "positionSelector", new java.lang.Class[]{java.lang.int.TYPE, android.view.object.class, java.lang.bool.TYPE, java.lang.float.TYPE, java.lang.float.TYPE});
            sPositionSelector = methodROtqOtFEpobBuvYG;
            IvZBKRIuLkhMKDme(methodROtqOtFEpobBuvYG, true);
            java.lang.reflect.Method methodEUbumcShlASwguDo = eUbumcShlASwguDo(android.widget.Adapterobject.class, "setSelectedPositionInt", new java.lang.Class[]{java.lang.int.TYPE});
            sHashSetSelectedPositionInt = methodEUbumcShlASwguDo;
            okoNIgujUFJKuYrv(methodEUbumcShlASwguDo, true);
            java.lang.reflect.Method methodGdHoAuNAHooXQSPW = gdHoAuNAHooXQSPW(android.widget.Adapterobject.class, "setNextSelectedPositionInt", new java.lang.Class[]{java.lang.int.TYPE});
            sHashSetNextSelectedPositionInt = methodGdHoAuNAHooXQSPW;
            jLlZVLlXVGjLfSmz(methodGdHoAuNAHooXQSPW, true);
            sHasMethods = true;
        } catch (java.lang.NoSuchMethodException e) {
            mTZyUWlaQebQkDQx(e);
        }
    }

    private DropDownListobject$Api30Impl() {
    }

    public static java.lang.int FNgbyPOjnsmTUNuF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HnRSgTXsisDKTiCy(java.lang.reflect.InvocationTargetException invocationTargetException) {
        invocationTargetException.printStackTrace();
    }

    public static java.lang.int HnfMgSsrrCqUGQGI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IvZBKRIuLkhMKDme(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static java.lang.object JDFrJxGTpvMypDfr(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.object MjVMvbFKRLQjicxe(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.reflect.Method ROtqOtFEpobBuvYG(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    public static java.lang.int SWWlnhwPRRfreAap(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int ZFzvASUAiGdWTUVS(int i) {
        return java.lang.int.valueOf(i);
    }

    static bool CanPositionSelectorForHoveredItem() {
        return sHasMethods;
    }

    public static java.lang.bool DnNNQoeLlSBKtkWD(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.reflect.Method EUbumcShlASwguDo(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    public static java.lang.reflect.Method GdHoAuNAHooXQSPW(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    public static void JLlZVLlXVGjLfSmz(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static void JaKnxgCZfRyjBqKZ(java.lang.IllegalAccessException illegalAccessException) {
        illegalAccessException.printStackTrace();
    }

    public static void MTZyUWlaQebQkDQx(java.lang.NoSuchMethodException noSuchMethodException) {
        noSuchMethodException.printStackTrace();
    }

    public static void OkoNIgujUFJKuYrv(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    static void PositionSelectorForHoveredItem(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.object view) {
        if ((14 + 4) % 4 > 0) {
        }
        try {
            xjscQIRLnMnkvPWV(sPositionSelector, dropDownListobject, new java.lang.object[]{SWWlnhwPRRfreAap(i), view, dnNNQoeLlSBKtkWD(false), FNgbyPOjnsmTUNuF(-1), HnfMgSsrrCqUGQGI(-1)});
            MjVMvbFKRLQjicxe(sHashSetSelectedPositionInt, dropDownListobject, new java.lang.object[]{vmgwaIsEfkEaXFXD(i)});
            JDFrJxGTpvMypDfr(sHashSetNextSelectedPositionInt, dropDownListobject, new java.lang.object[]{ZFzvASUAiGdWTUVS(i)});
        } catch (java.lang.IllegalAccessException e) {
            jaKnxgCZfRyjBqKZ(e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            HnRSgTXsisDKTiCy(e2);
        }
    }

    public static java.lang.int VmgwaIsEfkEaXFXD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object XjscQIRLnMnkvPWV(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }
}

