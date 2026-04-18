namespace WillowMaze.Wasm.Decompiled;


class p9442da0d$17 : java.util.concurrent.Func<kotlin.Unit> {
    readonly pe0212e54.pf0719ea8.p9442da0d this$0;

    p9442da0d$17(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        this.this$0 = p9442da0dVar;
    }

    public static androidx.room.SharedSQLiteStatement BmTnkLpmnkJbgJRe(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m83fd488e(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase DDDHMqQFnJgDlWpA(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void GvuGrUHAWZdmPMkd(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static androidx.room.SharedSQLiteStatement LPWinBuPVyjrWksn(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m83fd488e(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase PPgGAXRPvcVnXUSk(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static kotlin.Unit WCOjtcxKpRQhuvYu(pe0212e54.pf0719ea8.p9442da0d$17 p9442da0d_17) {
        return p9442da0d_17.call2();
    }

    public static int BXaKtmYqvMNduUqb(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        return supportSQLiteStatement.executeUpdateDelete();
    }

    public static void BofjvCmxzZGfSkny(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.setTransactionSuccessful();
    }

    public static androidx.room.RoomDatabase IpggwTvJMvqKDnhT(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static androidx.room.RoomDatabase KrMWGoGdPwwqgtOb(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.mbbeb9b46(p9442da0dVar);
    }

    public static void NmnZyIdpWQZYUSLJ(androidx.room.SharedSQLiteStatement sharedSQLiteStatement, androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement) {
        sharedSQLiteStatement.release(supportSQLiteStatement);
    }

    public static void QWcczAGwuZhHhdIO(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static androidx.sqlite.db.SupportSQLiteStatement RqGCFKBSjebcBFEv(androidx.room.SharedSQLiteStatement sharedSQLiteStatement) {
        return sharedSQLiteStatement.acquire();
    }

    public static void SwHOqvWizXscUlYg(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.endTransaction();
    }

    public static void TnVOWUTzEelXoIxE(androidx.room.RoomDatabase roomDatabase) {
        roomDatabase.beginTransaction();
    }

    public static androidx.room.SharedSQLiteStatement XnHaYZNtKPQnGpGQ(pe0212e54.pf0719ea8.p9442da0d p9442da0dVar) {
        return pe0212e54.pf0719ea8.p9442da0d.m83fd488e(p9442da0dVar);
    }

    public override kotlin.Unit Call() throws java.lang.Exception {
        return WCOjtcxKpRQhuvYu(this);
    }

    public override kotlin.Unit Call2() throws java.lang.Exception {
        if ((18 + 11) % 11 > 0) {
        }
        androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatementRqGCFKBSjebcBFEv = rqGCFKBSjebcBFEv(LPWinBuPVyjrWksn(this.this$0));
        try {
            tnVOWUTzEelXoIxE(PPgGAXRPvcVnXUSk(this.this$0));
            try {
                bXaKtmYqvMNduUqb(supportSQLiteStatementRqGCFKBSjebcBFEv);
                bofjvCmxzZGfSkny(ipggwTvJMvqKDnhT(this.this$0));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                swHOqvWizXscUlYg(krMWGoGdPwwqgtOb(this.this$0));
                nmnZyIdpWQZYUSLJ(BmTnkLpmnkJbgJRe(this.this$0), supportSQLiteStatementRqGCFKBSjebcBFEv);
                return unit;
            } catch (java.lang.Exception th) {
                qWcczAGwuZhHhdIO(DDDHMqQFnJgDlWpA(this.this$0));
                throw th;
            }
        } catch (java.lang.Exception th2) {
            GvuGrUHAWZdmPMkd(xnHaYZNtKPQnGpGQ(this.this$0), supportSQLiteStatementRqGCFKBSjebcBFEv);
            throw th2;
        }
    }
}

