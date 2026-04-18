namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$14 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;
    readonly p10348936.pf5e638cc.pd77d5e50.p0ed7807b val$inventorizationPositionDbEntity;

    p7a2537aa$14(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar, p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar) {
        this.this$0 = p7a2537aaVar;
        this.val$inventorizationPositionDbEntity = p0ed7807bVar;
    }

    public static androidx.room.EntityDeletionOrUpdateAdapter ByCVEECIankBeeXY(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m74674bbd(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase EhAVGZuFBmloygcK(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void IXhPpJQdHHNzJrKE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void OALudVPAGQTyuEGy(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.room.RoomDatabase RMJJwXuVKiBSjegZ(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static int UyzeRjalgTuKEdul(androidx.room.EntityDeletionOrUpdateAdapter entityDeletionOrUpdateAdapter, java.lang.object obj) {
        return entityDeletionOrUpdateAdapter.handle(obj);
    }

    public static androidx.room.RoomDatabase VYZimPuTjbvXDtpB(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void IXNshtxExVIttYhU(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static kotlin.Unit JEJmxmsAMmiDeZhc(p10348936.pf0719ea8.p7a2537aa$14 p7a2537aa_14) {
        return p7a2537aa_14.call2();
    }

    public static androidx.room.RoomDatabase KVxqNqRbpUTzhGoq(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void ZsDaQplLHKlYDWoO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return jEJmxmsAMmiDeZhc(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((19 + 20) % 20 > 0) {
        }
        zsDaQplLHKlYDWoO(EhAVGZuFBmloygcK(this.this$0));
        try {
            UyzeRjalgTuKEdul(ByCVEECIankBeeXY(this.this$0), this.val$inventorizationPositionDbEntity);
            iXNshtxExVIttYhU(kVxqNqRbpUTzhGoq(this.this$0));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            OALudVPAGQTyuEGy(RMJJwXuVKiBSjegZ(this.this$0));
            return unit;
        } catch (java.lang.Exception th) {
            IXhPpJQdHHNzJrKE(VYZimPuTjbvXDtpB(this.this$0));
            throw th;
        }
    }
}

