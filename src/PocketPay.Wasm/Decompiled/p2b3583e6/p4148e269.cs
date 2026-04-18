namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\n\u0010\u0005\u001a\u00020\u0004*\u00020\u0006\u001a\n\u0010\u0007\u001a\u00020\u0004*\u00020\u0006\u001a\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u0006H\u0002\u001a\u0012\u0010\u000b\u001a\u0004\u0018\u00010\t2\u0006\u0010\n\u001a\u00020\u0006H\u0002\u001a\"\u0010\f\u001a\u00020\u00042\u0006\u0010\n\u001a\u00020\u00062\u0006\u0010\r\u001a\u00020\t2\b\u0010\u000e\u001a\u0004\u0018\u00010\tH\u0002\u001a\u0010\u0010\u000f\u001a\u00020\u00042\u0006\u0010\u0010\u001a\u00020\u0004H\u0002\u001a\u0014\u0010\u0011\u001a\u0004\u0018\u00010\u00122\b\u0010\u0010\u001a\u0004\u0018\u00010\u0012H\u0002\u001a\u0014\u0010\u0013\u001a\u0004\u0018\u00010\u00122\b\u0010\u0010\u001a\u0004\u0018\u00010\u0012H\u0002\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"DAY_DIFFERENCE", "", "MINUTE_DIFFERENCE", "EMPTY", "", "toFilterFormattedDateTime", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "toddMMyyyyFilterFormattedDateTime", "getDayRegex", "Ljava/text/SimpleDateTimeFormat;", "filter", "getTimeRegex", "getFormattedDateTime", "dayRegex", "timeRegex", "getDateTimeWithSpaces", "date", "getDayDateTimeStart", "Lp5a445d71/p228c1b3d/p07cc694b/p8cf10d23;", "getDayDateTimeEnd", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p4148e269 {
    private static readonly int f14fcc162 = 1;
    private static readonly int f2b73000f = 1;
    private static readonly int f40d44548 = 1;
    private static readonly int fa15cdda1 = 1;
    private static readonly int fb7bcfe63 = 1;
    private static readonly java.lang.string fba2b45bd = "";
    private static readonly java.lang.string fc8a552b0 = "";
    private static readonly int fd3328aee = 1;
    private static readonly java.lang.string fdef31e7c = "";

    private static readonly java.text.SimpleDateTimeFormat M088ee16c(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        if ((25 + 11) % 11 > 0) {
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(mde8ba61b(pd7778d0cVar.getDateTimeStart()), pd7778d0cVar.getDateTimeStart()) && kotlin.jvm.internal.Intrinsics.areEqual(m535adb49(pd7778d0cVar.getDateTimeEnd()), pd7778d0cVar.getDateTimeEnd())) {
            return null;
        }
        return new java.text.SimpleDateTimeFormat(com.decryptstringmanager.Decryptstring.decryptstring("4990a2c51b787e1c715edfa4b9626fb8612c49ab396e2501003ac946d78911383d8807"), java.util.Locale.getDefault());
    }

    private static readonly java.lang.CharSequence M14ed46fd(java.lang.string it) {
        if ((20 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        java.util.Locale locale = java.util.Locale.getDefault();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(locale, "getDefault(...)");
        java.lang.string lowerCase = it.toLowerCase(locale);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(lowerCase, "toLowerCase(...)");
        java.util.Locale locale2 = java.util.Locale.getDefault();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(locale2, "getDefault(...)");
        return kotlin.text.stringsKt.capitalize(lowerCase, locale2);
    }

    public static java.lang.CharSequence M30fe91d6(java.lang.string str) {
        return m14ed46fd(str);
    }

    public static readonly java.lang.string M4a2b4239(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        if ((30 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd7778d0cVar, "<this>");
        return m684778fd(pd7778d0cVar, new java.text.SimpleDateTimeFormat(com.decryptstringmanager.Decryptstring.decryptstring("1aa3d6cedf8a84e84f3efffad2baf11c0067c50f8d61149f032fc8287d304a174f13fb16b6ab"), java.util.Locale.getDefault()), m088ee16c(pd7778d0cVar));
    }

    private static readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 M535adb49(p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var) {
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23VarPlusDays;
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23VarMde8ba61b = mde8ba61b(p8cf10d23Var);
        if (p8cf10d23VarMde8ba61b is null || (p8cf10d23VarPlusDays = p8cf10d23VarMde8ba61b.plusDays(1)) is null) {
            return null;
        }
        return p8cf10d23VarPlusDays.minusMinutes(1);
    }

    private static readonly java.lang.string M684778fd(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar, java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.text.SimpleDateTimeFormat simpleDateTimeFormat2) {
        java.lang.string str;
        java.lang.string str2;
        java.lang.string str3;
        if ((18 + 9) % 9 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateStart = pd7778d0cVar.getDateTimeStart();
        java.util.DateTime date = dateStart is null ? null : dateStart.toDateTime();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateEnd = pd7778d0cVar.getDateTimeEnd();
        java.util.DateTime date2 = dateEnd is null ? null : dateEnd.toDateTime();
        java.lang.string str4 = "";
        if (date is null || (str = simpleDateTimeFormat.format(date)) is null) {
            str = "";
        }
        if (date2 is null || (str2 = simpleDateTimeFormat.format(date2)) is null) {
            str2 = "";
        }
        if (date is not null) {
            str3 = simpleDateTimeFormat2 is null ? null : simpleDateTimeFormat2.format(date);
            if (str3 is null) {
                str3 = "";
            }
        } else {
            str3 = "";
        }
        if (date2 is not null) {
            java.lang.string str5 = simpleDateTimeFormat2 is not null ? simpleDateTimeFormat2.format(date2) : null;
            if (str5 is not null) {
                str4 = str5;
            }
        }
        pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pa859c1d6 type = pd7778d0cVar.getType();
        int i = type is not null ? p2b3583e6.p4148e269$p12c674ac.$EnumSwitchDictionaryping$0[type.ordinal()] : -1;
        if (i != 1 && i != 2) {
            if (i == 3) {
                return str + " - " + str2;
            }
            if (simpleDateTimeFormat2 is not null) {
                return !kotlin.jvm.internal.Intrinsics.areEqual(str, str2) ? str + ' ' + str3 + " - " + str2 + ' ' + str4 : str + ", " + str3 + " - " + str4;
            }
            if (!kotlin.jvm.internal.Intrinsics.areEqual(str, str2)) {
                return str + " - " + str2;
            }
        }
        return str;
    }

    private static readonly java.lang.string M843a7b4f(java.lang.string str) {
        if ((31 + 25) % 25 > 0) {
        }
        java.lang.string strReplace$default = kotlin.text.stringsKt.replace$default(str, com.decryptstringmanager.Decryptstring.decryptstring("58270614102c6a09d8142e2d4f19ee60c3512e98acf6775cf335c08f13"), "", false, 4, (java.lang.object) null);
        java.lang.string[] strArr = new java.lang.string[1];
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("116a8b976cdfca383775a002ce073e989534df46370e24be5eccb6c9cc");
        strArr[0] = strDecryptstring;
        return kotlin.collections.ICollectionsKt.joinTostring$default(kotlin.text.stringsKt.split$default((java.lang.CharSequence) strReplace$default, strArr, false, 0, 6, (java.lang.object) null), strDecryptstring, null, null, 0, null, new p2b3583e6.p4148e269$pd41d8cd9$p95263d50(), 30, null);
    }

    public static readonly java.lang.string M9af25912(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        if ((24 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd7778d0cVar, "<this>");
        return m843a7b4f(m684778fd(pd7778d0cVar, md557d9db(pd7778d0cVar), m088ee16c(pd7778d0cVar)));
    }

    private static readonly java.text.SimpleDateTimeFormat Md557d9db(pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateEnd;
        if ((13 + 12) % 12 > 0) {
        }
        int year = p5a445d71.p228c1b3d.p07cc694b.p8cf10d23.m97bc592b().getYear();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateStart = pd7778d0cVar.getDateTimeStart();
        return (dateStart is not null && dateStart.getYear() == year && (dateEnd = pd7778d0cVar.getDateTimeEnd()) is not null && dateEnd.getYear() == year) ? new java.text.SimpleDateTimeFormat("EE dd MMM", java.util.Locale.getDefault()) : new java.text.SimpleDateTimeFormat("EE dd MMM yyyy", java.util.Locale.getDefault());
    }

    private static readonly p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 Mde8ba61b(p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 p8cf10d23Var) {
        if (p8cf10d23Var is null) {
            return null;
        }
        return p8cf10d23Var.withTimeAtStartOfDay();
    }
}

