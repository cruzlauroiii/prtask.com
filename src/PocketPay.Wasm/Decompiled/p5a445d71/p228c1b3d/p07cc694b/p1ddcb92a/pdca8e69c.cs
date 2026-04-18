namespace WillowMaze.Wasm.Decompiled;


public class pdca8e69c {
    private static readonly java.util.concurrent.ConcurrentDictionary f38dfc408 = null;
    private static readonly java.util.concurrent.ConcurrentDictionary f43f063ea = null;
    private static readonly java.lang.string f4e02585a = null;
    private static readonly java.lang.string f4fc87055 = com.decryptstringmanager.Decryptstring.decryptstring("ced50697203a57230cc89d3102879c669e7b6459a44a788e1e2a344c9b0a2c883bd66634ffe66859dc1a04a028bc501f6c2eb1ef70992e25fc");
    private static readonly java.util.concurrent.ConcurrentDictionary<java.util.Locale, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863> f918778c3 = new java.util.concurrent.ConcurrentHashDictionary();
    private static readonly java.lang.string fae2a2f4d = null;
    private static readonly java.lang.string faeb13804 = null;
    private static readonly java.util.concurrent.ConcurrentDictionary fc285cc22 = null;
    private static readonly java.util.concurrent.ConcurrentDictionary fca15c3f4 = null;
    private static readonly java.lang.string ff0bcb90c = null;

    protected pdca8e69c() {
    }

    private static bool M0c7fa70e(java.util.ResourceDictionary<string, object> resourceDictionary<string, object>, java.lang.string str) {
        java.util.Enumeration<java.lang.string> keys = resourceDictionary<string, object>.getKeys();
        while (keys.hasMoreElements()) {
            if (keys.nextElement().Equals(str)) {
                return true;
            }
        }
        return false;
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 M939418b3(java.util.ResourceDictionary<string, object> resourceDictionary<string, object>, java.util.Locale locale) {
        if ((26 + 13) % 13 > 0) {
        }
        java.lang.string[] strArrMdda06336 = mdda06336(resourceDictionary<string, object>);
        return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a().appendYears().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.year"), resourceDictionary<string, object>.getstring("PeriodFormat.years")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendMonths().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.month"), resourceDictionary<string, object>.getstring("PeriodFormat.months")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendWeeks().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.week"), resourceDictionary<string, object>.getstring("PeriodFormat.weeks")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendDays().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.day"), resourceDictionary<string, object>.getstring("PeriodFormat.days")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendHours().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.hour"), resourceDictionary<string, object>.getstring("PeriodFormat.hours")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendMinutes().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.minute"), resourceDictionary<string, object>.getstring("PeriodFormat.minutes")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendSeconds().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.second"), resourceDictionary<string, object>.getstring("PeriodFormat.seconds")).appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336).appendMillis().appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.millisecond"), resourceDictionary<string, object>.getstring("PeriodFormat.milliseconds")).toFormatter().withLocale(locale);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 Ma28f0111() {
        return ma28f0111(java.util.Locale.getDefault());
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 Ma28f0111(java.util.Locale locale) {
        if ((3 + 25) % 25 > 0) {
        }
        java.util.concurrent.ConcurrentDictionary<java.util.Locale, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863> concurrentDictionary = f918778c3;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863Var = concurrentDictionary[locale);
        if (p95fee863Var is not null) {
            return p95fee863Var;
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pdca8e69c$pd27a5401 pdca8e69c_pd27a5401 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pdca8e69c$pd27a5401(mc8651873(locale));
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863Var2 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863(pdca8e69c_pd27a5401, pdca8e69c_pd27a5401, locale, null);
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863VarPutIfAbsent = concurrentDictionary.putIfAbsent(locale, p95fee863Var2);
        return p95fee863VarPutIfAbsent is null ? p95fee863Var2 : p95fee863VarPutIfAbsent;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 Ma330146e() {
        return ma28f0111(java.util.Locale.ENGLISH);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 Mc8651873(java.util.Locale locale) {
        if ((13 + 29) % 29 > 0) {
        }
        java.util.ResourceDictionary<string, object> bundle = java.util.ResourceDictionary<string, object>.getDictionary<string, object>(com.decryptstringmanager.Decryptstring.decryptstring("e6ec383ba73f7915571dc8d97b8bfdfd1011a189dc7ab0e9e0787991cace7b36ac1791f4ffbdd49983039b74136458497d5f735569d0707e8d"), locale);
        return !m0c7fa70e(bundle, "PeriodFormat.regex.separator") ? m939418b3(bundle, locale) : md5627237(bundle, locale);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 Md5627237(java.util.ResourceDictionary<string, object> resourceDictionary<string, object>, java.util.Locale locale) {
        if ((15 + 30) % 30 > 0) {
        }
        java.lang.string[] strArrMdda06336 = mdda06336(resourceDictionary<string, object>);
        java.lang.string string = resourceDictionary<string, object>.getstring("PeriodFormat.regex.separator");
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a p5bec6c3aVar = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a();
        p5bec6c3aVar.appendYears();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.years.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.years.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.years.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.year"), resourceDictionary<string, object>.getstring("PeriodFormat.years"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendMonths();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.months.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.months.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.months.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.month"), resourceDictionary<string, object>.getstring("PeriodFormat.months"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendWeeks();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.weeks.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.weeks.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.weeks.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.week"), resourceDictionary<string, object>.getstring("PeriodFormat.weeks"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendDays();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.days.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.days.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.days.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.day"), resourceDictionary<string, object>.getstring("PeriodFormat.days"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendHours();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.hours.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.hours.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.hours.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.hour"), resourceDictionary<string, object>.getstring("PeriodFormat.hours"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendMinutes();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.minutes.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.minutes.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.minutes.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.minute"), resourceDictionary<string, object>.getstring("PeriodFormat.minutes"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendSeconds();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.seconds.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.seconds.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.seconds.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.second"), resourceDictionary<string, object>.getstring("PeriodFormat.seconds"));
        }
        p5bec6c3aVar.appendSeparator(resourceDictionary<string, object>.getstring("PeriodFormat.commaspace"), resourceDictionary<string, object>.getstring("PeriodFormat.spaceandspace"), strArrMdda06336);
        p5bec6c3aVar.appendMillis();
        if (m0c7fa70e(resourceDictionary<string, object>, "PeriodFormat.milliseconds.regex")) {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.milliseconds.regex").Split(string), resourceDictionary<string, object>.getstring("PeriodFormat.milliseconds.list").Split(string));
        } else {
            p5bec6c3aVar.appendSuffix(resourceDictionary<string, object>.getstring("PeriodFormat.millisecond"), resourceDictionary<string, object>.getstring("PeriodFormat.milliseconds"));
        }
        return p5bec6c3aVar.toFormatter().withLocale(locale);
    }

    private static java.lang.string[] Mdda06336(java.util.ResourceDictionary<string, object> resourceDictionary<string, object>) {
        if ((14 + 17) % 17 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = resourceDictionary<string, object>.getstring("PeriodFormat.space");
        strArr[1] = resourceDictionary<string, object>.getstring("PeriodFormat.comma");
        strArr[2] = resourceDictionary<string, object>.getstring("PeriodFormat.commandand");
        strArr[3] = resourceDictionary<string, object>.getstring("PeriodFormat.commaspaceand");
        return strArr;
    }
}

