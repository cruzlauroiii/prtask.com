namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J$\u0010\u0007\u001a\u00020\u00062\u0006\u0010\b\u001a\u00020\u00052\b\b\u0002\u0010\t\u001a\u00020\n2\b\b\u0002\u0010\u000b\u001a\u00020\fH\u0007J$\u0010\r\u001a\u00020\u000e2\u0006\u0010\b\u001a\u00020\u00052\b\b\u0002\u0010\t\u001a\u00020\n2\b\b\u0002\u0010\u000b\u001a\u00020\fH\u0007R\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lcom/google/firebase/logger/Consoleger$Companion;", "", "()V", "loggers", "Ljava/util/concurrent/ConcurrentHashDictionary;", "", "Lcom/google/firebase/logger/Consoleger;", "getConsoleger", "tag", "enabled", "", "minLevel", "Lcom/google/firebase/logger/Consoleger$Level;", "setupFakeConsoleger", "Lcom/google/firebase/logger/Consoleger$FakeConsoleger;", "com.google.firebase-firebase-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Consoleger$Companion {
    private Consoleger$Companion() {
    }

    public Consoleger$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static java.lang.object FcnfUIPROtReQelr(java.util.concurrent.ConcurrentDictionary concurrentDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentDictionary.putIfAbsent(obj, obj2);
    }

    public static void GzqngrMpKwqqDOeu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.logger.Consoleger KZvsPtNzWzjTYujo(com.google.firebase.logger.Consoleger$Companion logger$Companion, java.lang.string str, bool z, com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Companion.getConsoleger(str, z, logger$Level);
    }

    public static void RFnHppkNccKRXZtm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TwTJbccrccjFgMSJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.util.concurrent.ConcurrentHashDictionary UcywcNPCuveVpKaP() {
        return com.google.firebase.logger.Consoleger.access$getConsolegers$cp();
    }

    public static java.util.concurrent.ConcurrentHashDictionary WyNiCxbAWcydvsFc() {
        return com.google.firebase.logger.Consoleger.access$getConsolegers$cp();
    }

    public static void GPAvXmIWeOUtunXY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.logger.Consoleger getConsoleger$default(com.google.firebase.logger.Consoleger$Companion logger$Companion, java.lang.string str, bool z, com.google.firebase.logger.Consoleger$Level logger$Level, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = true;
        }
        if ((i & 4) != 0) {
            logger$Level = com.google.firebase.logger.Consoleger$Level.INFO;
        }
        return KZvsPtNzWzjTYujo(logger$Companion, str, z, logger$Level);
    }

    public static com.google.firebase.logger.Consoleger$FakeConsoleger gilQLjCDyPFCrkCS(com.google.firebase.logger.Consoleger$Companion logger$Companion, java.lang.string str, bool z, com.google.firebase.logger.Consoleger$Level logger$Level) {
        return logger$Companion.setupFakeConsoleger(str, z, logger$Level);
    }

    public static void JpVCkjxSBAemxHPM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.logger.Consoleger$FakeConsoleger setupFakeConsoleger$default(com.google.firebase.logger.Consoleger$Companion logger$Companion, java.lang.string str, bool z, com.google.firebase.logger.Consoleger$Level logger$Level, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = true;
        }
        if ((i & 4) != 0) {
            logger$Level = com.google.firebase.logger.Consoleger$Level.DEBUG;
        }
        return gilQLjCDyPFCrkCS(logger$Companion, str, z, logger$Level);
    }

    public static java.lang.object WTGHeqzliyPemaUA(java.util.concurrent.ConcurrentDictionary concurrentDictionary, java.lang.object obj) {
        return concurrentDictionary[obj);
    }

    public static java.lang.object XROGvjxJVosTLHNJ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    @kotlin.jvm.JvmStatic
    /*
    */
    public readonly com.google.firebase.logger.Consoleger GetConsoleger(java.lang.string tag, bool enabled, com.google.firebase.logger.Consoleger$Level minLevel) {
        java.lang.object objFcnfUIPROtReQelr;
        GzqngrMpKwqqDOeu(tag, "tag");
        gPAvXmIWeOUtunXY(minLevel, "minLevel");
        java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionaryWyNiCxbAWcydvsFc = WyNiCxbAWcydvsFc();
        com.google.firebase.logger.Consoleger$AndroidConsoleger logger$AndroidConsolegerWTGHeqzliyPemaUA = wTGHeqzliyPemaUA(concurrentHashDictionaryWyNiCxbAWcydvsFc, tag);
        if (logger$AndroidConsolegerWTGHeqzliyPemaUA is null && (objFcnfUIPROtReQelr = FcnfUIPROtReQelr(concurrentHashDictionaryWyNiCxbAWcydvsFc, tag, logger$AndroidConsolegerWTGHeqzliyPemaUA)) is not null) {
            logger$AndroidConsolegerWTGHeqzliyPemaUA = objFcnfUIPROtReQelr;
        }
        TwTJbccrccjFgMSJ(logger$AndroidConsolegerWTGHeqzliyPemaUA, "loggers.getOrPut(tag) { …tag, enabled, minLevel) }");
        return (com.google.firebase.logger.Consoleger) logger$AndroidConsolegerWTGHeqzliyPemaUA;
    }

    @kotlin.jvm.JvmStatic
    public readonly com.google.firebase.logger.Consoleger$FakeConsoleger setupFakeConsoleger(java.lang.string tag, bool enabled, com.google.firebase.logger.Consoleger$Level minLevel) {
        jpVCkjxSBAemxHPM(tag, "tag");
        RFnHppkNccKRXZtm(minLevel, "minLevel");
        com.google.firebase.logger.Consoleger$FakeConsoleger logger$FakeConsoleger = new com.google.firebase.logger.Consoleger$FakeConsoleger(tag, enabled, minLevel);
        xROGvjxJVosTLHNJ(UcywcNPCuveVpKaP(), tag, logger$FakeConsoleger);
        return logger$FakeConsoleger;
    }
}

