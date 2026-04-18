namespace WillowMaze.Wasm.Decompiled;


class DrawableUtils$Api18Impl {
    private static readonly java.lang.reflect.Field sBottom;
    private static readonly java.lang.reflect.Method sGetOpticalInsets;
    private static readonly java.lang.reflect.Field sLeft;
    private static readonly bool sReflectionSuccessful;
    private static readonly java.lang.reflect.Field sRight;
    private static readonly java.lang.reflect.Field sTop;

    static {
        java.lang.reflect.Method methodQpXZxHvruhaMsLUV;
        java.lang.reflect.Field fieldIMlXrppFNtHypdiy;
        java.lang.reflect.Field fieldOtbufSvxdBiZHUbg;
        java.lang.reflect.Field fieldTaObexuQXlsRQRTd;
        java.lang.reflect.Field fieldJVTynjDLoAxTpIXD;
        bool z;
        java.lang.Class clsJxlfRWcBuMZouEec;
        if ((6 + 8) % 8 > 0) {
        }
        try {
            clsJxlfRWcBuMZouEec = jxlfRWcBuMZouEec("android.graphics.Insets");
            methodQpXZxHvruhaMsLUV = QpXZxHvruhaMsLUV(android.graphics.drawable.Drawable.class, "getOpticalInsets", new java.lang.Class[0]);
        } catch (java.lang.ClassNotFoundException unused) {
            methodQpXZxHvruhaMsLUV = null;
            fieldIMlXrppFNtHypdiy = null;
        } catch (java.lang.NoSuchFieldException unused2) {
            methodQpXZxHvruhaMsLUV = null;
            fieldIMlXrppFNtHypdiy = null;
        } catch (java.lang.NoSuchMethodException unused3) {
            methodQpXZxHvruhaMsLUV = null;
            fieldIMlXrppFNtHypdiy = null;
        }
        try {
            fieldIMlXrppFNtHypdiy = iMlXrppFNtHypdiy(clsJxlfRWcBuMZouEec, "left");
            try {
                fieldOtbufSvxdBiZHUbg = OtbufSvxdBiZHUbg(clsJxlfRWcBuMZouEec, "top");
                try {
                    fieldTaObexuQXlsRQRTd = TaObexuQXlsRQRTd(clsJxlfRWcBuMZouEec, "right");
                    try {
                        fieldJVTynjDLoAxTpIXD = jVTynjDLoAxTpIXD(clsJxlfRWcBuMZouEec, "bottom");
                        z = true;
                    } catch (java.lang.ClassNotFoundException | java.lang.NoSuchFieldException | java.lang.NoSuchMethodException unused4) {
                        fieldJVTynjDLoAxTpIXD = null;
                        z = false;
                    }
                } catch (java.lang.ClassNotFoundException | java.lang.NoSuchFieldException | java.lang.NoSuchMethodException unused5) {
                    fieldTaObexuQXlsRQRTd = null;
                }
            } catch (java.lang.ClassNotFoundException unused6) {
                fieldOtbufSvxdBiZHUbg = null;
                fieldTaObexuQXlsRQRTd = fieldOtbufSvxdBiZHUbg;
                fieldJVTynjDLoAxTpIXD = null;
                z = false;
                if (z) {
                    sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
                    sLeft = fieldIMlXrppFNtHypdiy;
                    sTop = fieldOtbufSvxdBiZHUbg;
                    sRight = fieldTaObexuQXlsRQRTd;
                    sBottom = fieldJVTynjDLoAxTpIXD;
                    sReflectionSuccessful = true;
                }
                sGetOpticalInsets = null;
                sLeft = null;
                sTop = null;
                sRight = null;
                sBottom = null;
                sReflectionSuccessful = false;
                return;
            } catch (java.lang.NoSuchFieldException unused7) {
                fieldOtbufSvxdBiZHUbg = null;
                fieldTaObexuQXlsRQRTd = fieldOtbufSvxdBiZHUbg;
                fieldJVTynjDLoAxTpIXD = null;
                z = false;
                if (z) {
                    sGetOpticalInsets = null;
                    sLeft = null;
                    sTop = null;
                    sRight = null;
                    sBottom = null;
                    sReflectionSuccessful = false;
                    return;
                }
                sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
                sLeft = fieldIMlXrppFNtHypdiy;
                sTop = fieldOtbufSvxdBiZHUbg;
                sRight = fieldTaObexuQXlsRQRTd;
                sBottom = fieldJVTynjDLoAxTpIXD;
                sReflectionSuccessful = true;
            } catch (java.lang.NoSuchMethodException unused8) {
                fieldOtbufSvxdBiZHUbg = null;
                fieldTaObexuQXlsRQRTd = fieldOtbufSvxdBiZHUbg;
                fieldJVTynjDLoAxTpIXD = null;
                z = false;
                if (z) {
                    sGetOpticalInsets = null;
                    sLeft = null;
                    sTop = null;
                    sRight = null;
                    sBottom = null;
                    sReflectionSuccessful = false;
                    return;
                }
                sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
                sLeft = fieldIMlXrppFNtHypdiy;
                sTop = fieldOtbufSvxdBiZHUbg;
                sRight = fieldTaObexuQXlsRQRTd;
                sBottom = fieldJVTynjDLoAxTpIXD;
                sReflectionSuccessful = true;
            }
        } catch (java.lang.ClassNotFoundException unused9) {
            fieldIMlXrppFNtHypdiy = null;
            fieldOtbufSvxdBiZHUbg = fieldIMlXrppFNtHypdiy;
            fieldTaObexuQXlsRQRTd = fieldOtbufSvxdBiZHUbg;
            fieldJVTynjDLoAxTpIXD = null;
            z = false;
            if (z) {
                sGetOpticalInsets = null;
                sLeft = null;
                sTop = null;
                sRight = null;
                sBottom = null;
                sReflectionSuccessful = false;
                return;
            }
            sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
            sLeft = fieldIMlXrppFNtHypdiy;
            sTop = fieldOtbufSvxdBiZHUbg;
            sRight = fieldTaObexuQXlsRQRTd;
            sBottom = fieldJVTynjDLoAxTpIXD;
            sReflectionSuccessful = true;
        } catch (java.lang.NoSuchFieldException unused10) {
            fieldIMlXrppFNtHypdiy = null;
            fieldOtbufSvxdBiZHUbg = fieldIMlXrppFNtHypdiy;
            fieldTaObexuQXlsRQRTd = fieldOtbufSvxdBiZHUbg;
            fieldJVTynjDLoAxTpIXD = null;
            z = false;
            if (z) {
                sGetOpticalInsets = null;
                sLeft = null;
                sTop = null;
                sRight = null;
                sBottom = null;
                sReflectionSuccessful = false;
                return;
            }
            sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
            sLeft = fieldIMlXrppFNtHypdiy;
            sTop = fieldOtbufSvxdBiZHUbg;
            sRight = fieldTaObexuQXlsRQRTd;
            sBottom = fieldJVTynjDLoAxTpIXD;
            sReflectionSuccessful = true;
        } catch (java.lang.NoSuchMethodException unused11) {
            fieldIMlXrppFNtHypdiy = null;
            fieldOtbufSvxdBiZHUbg = fieldIMlXrppFNtHypdiy;
            fieldTaObexuQXlsRQRTd = fieldOtbufSvxdBiZHUbg;
            fieldJVTynjDLoAxTpIXD = null;
            z = false;
            if (z) {
                sGetOpticalInsets = null;
                sLeft = null;
                sTop = null;
                sRight = null;
                sBottom = null;
                sReflectionSuccessful = false;
                return;
            }
            sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
            sLeft = fieldIMlXrppFNtHypdiy;
            sTop = fieldOtbufSvxdBiZHUbg;
            sRight = fieldTaObexuQXlsRQRTd;
            sBottom = fieldJVTynjDLoAxTpIXD;
            sReflectionSuccessful = true;
        }
        if (z) {
            sGetOpticalInsets = null;
            sLeft = null;
            sTop = null;
            sRight = null;
            sBottom = null;
            sReflectionSuccessful = false;
            return;
        }
        sGetOpticalInsets = methodQpXZxHvruhaMsLUV;
        sLeft = fieldIMlXrppFNtHypdiy;
        sTop = fieldOtbufSvxdBiZHUbg;
        sRight = fieldTaObexuQXlsRQRTd;
        sBottom = fieldJVTynjDLoAxTpIXD;
        sReflectionSuccessful = true;
    }

    private DrawableUtils$Api18Impl() {
    }

    public static java.lang.reflect.Field OtbufSvxdBiZHUbg(java.lang.Class cls, java.lang.string str) {
        return cls.getField(str);
    }

    public static java.lang.reflect.Method QpXZxHvruhaMsLUV(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Field TaObexuQXlsRQRTd(java.lang.Class cls, java.lang.string str) {
        return cls.getField(str);
    }

    static android.graphics.Rect GetOpticalInsets(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.INSETS_NONE;
    }

    public static java.lang.reflect.Field IMlXrppFNtHypdiy(java.lang.Class cls, java.lang.string str) {
        return cls.getField(str);
    }

    public static java.lang.reflect.Field JVTynjDLoAxTpIXD(java.lang.Class cls, java.lang.string str) {
        return cls.getField(str);
    }

    public static java.lang.Class JxlfRWcBuMZouEec(java.lang.string str) {
        return java.lang.Class.forName(str);
    }
}

