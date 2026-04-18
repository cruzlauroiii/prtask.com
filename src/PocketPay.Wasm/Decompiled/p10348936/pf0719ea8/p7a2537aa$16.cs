namespace WillowMaze.Wasm.Decompiled;


class p7a2537aa$16 : java.util.concurrent.Func<kotlin.Unit> {
    readonly p10348936.pf0719ea8.p7a2537aa this$0;

    p7a2537aa$16(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        this.this$0 = p7a2537aaVar;
    }

    public static androidx.room.RoomDatabase EdIRoJJsNMvIJGBK(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement IeLtfHTARHdhiUZg(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m2a096755(p7a2537aaVar);
    }

    public static int JxJphOVOnZfVGjpv(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement KTukOjYIvUydEyYy(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void LIYCMwBlIriZhavw(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void LKYQFtftsHnEOmRp(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase MdYPEnoetKaTMrvb(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement PbdmapOVnESPccEI(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m2a096755(p7a2537aaVar);
    }

    public static androidx.room.SharedSQLiteStatement TUsGvXRwqdbrqdjB(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.m2a096755(p7a2537aaVar);
    }

    public static void HdMLEkwEghwtDafH(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static void IHBgHrASHLFFlGDk(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void PxJKCKlVLutLMCii(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static kotlin.Unit QFEIjHGFrECcUIkA(p10348936.pf0719ea8.p7a2537aa$16 p7a2537aa_16) {
        return p7a2537aa_16.call2();
    }

    public static androidx.room.RoomDatabase QVLgmHzhpkmSdZRw(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static androidx.room.RoomDatabase WpABmYGMJeKDPges(p10348936.pf0719ea8.p7a2537aa p7a2537aaVar) {
        return p10348936.pf0719ea8.p7a2537aa.mbbeb9b46(p7a2537aaVar);
    }

    public static void XkjiAsrCQXzNYZHa(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return qFEIjHGFrECcUIkA(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((31 + 2) % 2 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementKTukOjYIvUydEyYy = KTukOjYIvUydEyYy(TUsGvXRwqdbrqdjB(this.this$0));
        try {
            hdMLEkwEghwtDafH(wpABmYGMJeKDPges(this.this$0));
            try {
                JxJphOVOnZfVGjpv(supportSQLiteStatementKTukOjYIvUydEyYy);
                LKYQFtftsHnEOmRp(EdIRoJJsNMvIJGBK(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                pxJKCKlVLutLMCii(qVLgmHzhpkmSdZRw(this.this$0));
                LIYCMwBlIriZhavw(IeLtfHTARHdhiUZg(this.this$0), supportSQLiteStatementKTukOjYIvUydEyYy);
                return unit;
            } catch (java.lang.Exception th) {
                xkjiAsrCQXzNYZHa(MdYPEnoetKaTMrvb(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            iHBgHrASHLFFlGDk(PbdmapOVnESPccEI(this.this$0), supportSQLiteStatementKTukOjYIvUydEyYy);
            throw th2;
        }
    }
}

