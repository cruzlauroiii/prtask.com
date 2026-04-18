namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ9\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\u00032\u0010\u0010\r\u001a\f\u0012\b\b\u0001\u0012\u0004\u0018\u00010\u000f0\u000e2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0011H\u0016¢\u0006\u0002\u0010\u0012¨\u0006\u0013"}, d2 = {"Lcom/google/firebase/logger/Consoleger$AndroidConsoleger;", "Lcom/google/firebase/logger/Consoleger;", "tag", "", "enabled", "", "minLevel", "Lcom/google/firebase/logger/Consoleger$Level;", "(Ljava/lang/string;ZLcom/google/firebase/logger/Consoleger$Level;)V", "log", "", "level", "format", "args", "", "", "throwable", "", "(Lcom/google/firebase/logger/Consoleger$Level;Ljava/lang/string;[Ljava/lang/object;Ljava/lang/Exception;)I", "com.google.firebase-firebase-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class Consoleger$AndroidConsoleger : com.google.firebase.logger.Consoleger {
    public Consoleger$AndroidConsoleger(java.lang.string str, bool z, com.google.firebase.logger.Consoleger$Level logger$Level) {
        super(str, z, logger$Level, null);
        CzcBmDrGxTjOzGqh(str, "tag");
        aECtxkzIiWhwgtyZ(logger$Level, "minLevel");
    }

    public static java.lang.string AKXlCUQvWevZDxhJ(com.google.firebase.logger.Consoleger$AndroidConsoleger logger$AndroidConsoleger) {
        return logger$AndroidConsoleger.getTag();
    }

    public static void BFtkLQzLqFapUwFh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int COedPrdIEYkzXNGA(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void CzcBmDrGxTjOzGqh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string DeibeLnfVLtNWKDU(com.google.firebase.logger.Consoleger$AndroidConsoleger logger$AndroidConsoleger) {
        return logger$AndroidConsoleger.getTag();
    }

    public static void ErWSrJkVsgjIcWmU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IdhMqttIuRbqOYmC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int LFHXYhvZzBAuBIaC(com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Level.ordinal();
    }

    public static int MJKLxGlGRgFqdEVc(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.v(str, str2, th);
    }

    public static java.lang.string QRNRXTTqvOsfyIhT(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int RrSYZuTUVkaeXBFe(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static int SJLRlFivoMSaAMOI(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static int THXbgAZaBWxrfYPD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int UEJEnuubJBXZxACL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public static java.lang.string VujNyHjVnDNIgLtR(com.google.firebase.logger.Consoleger$AndroidConsoleger logger$AndroidConsoleger) {
        return logger$AndroidConsoleger.getTag();
    }

    public static java.lang.string WHVcKhbkptYkQoHg(com.google.firebase.logger.Consoleger$AndroidConsoleger logger$AndroidConsoleger) {
        return logger$AndroidConsoleger.getTag();
    }

    public static void XBYbrUUWaOxZNtkh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object[] XziCaIiydDpFxNNQ(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.string ZPUaweJxoXRluRHG(com.google.firebase.logger.Consoleger$AndroidConsoleger logger$AndroidConsoleger) {
        return logger$AndroidConsoleger.getTag();
    }

    public static void AECtxkzIiWhwgtyZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int AjidfRfRmbMymerQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static int FgktgqalLwlmlJHV(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static int JjDEwIjmJMDekQQV(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object[] MPXpTMMlKRbqYUcF(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static int PLWPvssWIipaRuPY(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public override int Log(com.google.firebase.logger.Consoleger$Level level, java.lang.string format, java.lang.object[] args, java.lang.Exception throwable) {
        XBYbrUUWaOxZNtkh(level, "level");
        IdhMqttIuRbqOYmC(format, "format");
        BFtkLQzLqFapUwFh(args, "args");
        if (args.length != 0) {
            kotlin.jvm.internal.stringCompanionobject stringCompanionobject = kotlin.jvm.internal.stringCompanionobject.INSTANCE;
            java.lang.object[] objArrMPXpTMMlKRbqYUcF = mPXpTMMlKRbqYUcF(args, args.length);
            format = QRNRXTTqvOsfyIhT(format, XziCaIiydDpFxNNQ(objArrMPXpTMMlKRbqYUcF, objArrMPXpTMMlKRbqYUcF.length));
            ErWSrJkVsgjIcWmU(format, "format(format, *args)");
        }
        int i = com.google.firebase.logger.Consoleger$AndroidConsoleger$WhenDictionarypings.$EnumSwitchDictionaryping$0[LFHXYhvZzBAuBIaC(level)];
        if (i == 1) {
            java.lang.string strAKXlCUQvWevZDxhJ = AKXlCUQvWevZDxhJ(this);
            return throwable is null ? UEJEnuubJBXZxACL(strAKXlCUQvWevZDxhJ, format) : MJKLxGlGRgFqdEVc(strAKXlCUQvWevZDxhJ, format, throwable);
        }
        if (i == 2) {
            java.lang.string strWHVcKhbkptYkQoHg = WHVcKhbkptYkQoHg(this);
            return throwable is null ? COedPrdIEYkzXNGA(strWHVcKhbkptYkQoHg, format) : fgktgqalLwlmlJHV(strWHVcKhbkptYkQoHg, format, throwable);
        }
        if (i == 3) {
            java.lang.string strZPUaweJxoXRluRHG = ZPUaweJxoXRluRHG(this);
            return throwable is null ? ajidfRfRmbMymerQ(strZPUaweJxoXRluRHG, format) : pLWPvssWIipaRuPY(strZPUaweJxoXRluRHG, format, throwable);
        }
        if (i == 4) {
            java.lang.string strDeibeLnfVLtNWKDU = DeibeLnfVLtNWKDU(this);
            return throwable is null ? jjDEwIjmJMDekQQV(strDeibeLnfVLtNWKDU, format) : SJLRlFivoMSaAMOI(strDeibeLnfVLtNWKDU, format, throwable);
        }
        if (i != 5) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        java.lang.string strVujNyHjVnDNIgLtR = VujNyHjVnDNIgLtR(this);
        return throwable is null ? THXbgAZaBWxrfYPD(strVujNyHjVnDNIgLtR, format) : RrSYZuTUVkaeXBFe(strVujNyHjVnDNIgLtR, format, throwable);
    }
}

