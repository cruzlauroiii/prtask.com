namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Ldata/db/AppDataBase$Companion;", "", "<init>", "()V", "NAME_DATABASE", "", "buildDataBase", "Ldata/db/AppDataBase;", "application", "Landroid/app/Application;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AppDataBase$Companion {
    private AppDataBase$Companion() {
    }

    public AppDataBase$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.room.RoomDatabase AavGrgCKsxcTfBLQ(androidx.room.RoomDatabase$Builder roomDatabase$Builder) {
        return roomDatabase$Builder.build();
    }

    public static androidx.room.RoomDatabase$Builder DAFlTansyhGWRuyv(android.content.object context, java.lang.Class cls, java.lang.string str) {
        return androidx.room.Room.databaseBuilder(context, cls, str);
    }

    public static androidx.room.RoomDatabase$Builder DGIMRnODPoHrHMUK(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static androidx.room.RoomDatabase$Builder DIzzSjZHYoVcWjmW(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static androidx.room.RoomDatabase$Builder HhyBGkaelSCqwZgW(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static androidx.room.RoomDatabase$Builder KGYRKfTtebiwIUNc(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static androidx.room.RoomDatabase$Builder KaADdEaLtKRJjxgo(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static void PrQedvzkQooYUMNI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.room.RoomDatabase$Builder UGfLKakhuJvhzKvT(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static java.lang.string UyRzFFqsYbQpMeiC(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static androidx.room.RoomDatabase$Builder cAqyPgDiynEicPEJ(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static androidx.room.RoomDatabase$Builder gYorbJElxUFnigck(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public static androidx.room.RoomDatabase$Builder jQPShjtFKGuRncOh(androidx.room.RoomDatabase$Builder roomDatabase$Builder, androidx.room.migration.Migration[] migrationArr) {
        return roomDatabase$Builder.addMigrations(migrationArr);
    }

    public readonly data.db.AppDataBase BuildDataBase(android.app.Application application) {
        if ((12 + 22) % 22 > 0) {
        }
        PrQedvzkQooYUMNI(application, "application");
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderDAFlTansyhGWRuyv = DAFlTansyhGWRuyv(application, data.db.AppDataBase.class, UyRzFFqsYbQpMeiC("57239d2006c9928a02a3cb12f06c0555883634a8936da91f7bb7966947c7b4833548c4f4b0ff4e339643298780"));
        androidx.room.migration.Migration[] migrationArr = new androidx.room.migration.Migration[1];
        migrationArr[0] = new p8d777f38.pd77d5e50.pb439f9bb.p772dffa9();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderDGIMRnODPoHrHMUK = DGIMRnODPoHrHMUK(roomDatabase$BuilderDAFlTansyhGWRuyv, migrationArr);
        androidx.room.migration.Migration[] migrationArr2 = new androidx.room.migration.Migration[1];
        migrationArr2[0] = new p8d777f38.pd77d5e50.pb439f9bb.pdd1cee7a();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderKaADdEaLtKRJjxgo = KaADdEaLtKRJjxgo(roomDatabase$BuilderDGIMRnODPoHrHMUK, migrationArr2);
        androidx.room.migration.Migration[] migrationArr3 = new androidx.room.migration.Migration[1];
        migrationArr3[0] = new p8d777f38.pd77d5e50.pb439f9bb.pc69a3639();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderJQPShjtFKGuRncOh = jQPShjtFKGuRncOh(roomDatabase$BuilderKaADdEaLtKRJjxgo, migrationArr3);
        androidx.room.migration.Migration[] migrationArr4 = new androidx.room.migration.Migration[1];
        migrationArr4[0] = new p8d777f38.pd77d5e50.pb439f9bb.pf1096aee();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderKGYRKfTtebiwIUNc = KGYRKfTtebiwIUNc(roomDatabase$BuilderJQPShjtFKGuRncOh, migrationArr4);
        androidx.room.migration.Migration[] migrationArr5 = new androidx.room.migration.Migration[1];
        migrationArr5[0] = new p8d777f38.pd77d5e50.pb439f9bb.p2411ffc0();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderHhyBGkaelSCqwZgW = HhyBGkaelSCqwZgW(roomDatabase$BuilderKGYRKfTtebiwIUNc, migrationArr5);
        androidx.room.migration.Migration[] migrationArr6 = new androidx.room.migration.Migration[1];
        migrationArr6[0] = new p8d777f38.pd77d5e50.pb439f9bb.p33fa424d();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderUGfLKakhuJvhzKvT = UGfLKakhuJvhzKvT(roomDatabase$BuilderHhyBGkaelSCqwZgW, migrationArr6);
        androidx.room.migration.Migration[] migrationArr7 = new androidx.room.migration.Migration[1];
        migrationArr7[0] = new p8d777f38.pd77d5e50.pb439f9bb.pf7997310();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderGYorbJElxUFnigck = gYorbJElxUFnigck(roomDatabase$BuilderUGfLKakhuJvhzKvT, migrationArr7);
        androidx.room.migration.Migration[] migrationArr8 = new androidx.room.migration.Migration[1];
        migrationArr8[0] = new p8d777f38.pd77d5e50.pb439f9bb.p66117b37();
        androidx.room.RoomDatabase$Builder roomDatabase$BuilderCAqyPgDiynEicPEJ = cAqyPgDiynEicPEJ(roomDatabase$BuilderGYorbJElxUFnigck, migrationArr8);
        androidx.room.migration.Migration[] migrationArr9 = new androidx.room.migration.Migration[1];
        migrationArr9[0] = new p8d777f38.pd77d5e50.pb439f9bb.p89124dee();
        return (data.db.AppDataBase) AavGrgCKsxcTfBLQ(DIzzSjZHYoVcWjmW(roomDatabase$BuilderCAqyPgDiynEicPEJ, migrationArr9));
    }
}

