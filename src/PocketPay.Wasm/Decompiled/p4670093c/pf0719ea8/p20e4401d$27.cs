namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$27 : java.util.concurrent.Func<java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65>> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;
    readonly androidx.room.RoomSQLiteQuery val$_statement;

    p20e4401d$27(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomSQLiteQuery roomSQLiteQuery) {
        this.this$0 = p20e4401dVar;
        this.val$_statement = roomSQLiteQuery;
    }

    public override java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65> Call() throws java.lang.Exception {
        return call2();
    }

    public override java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65> Call2() throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.p85cc901a p85cc901aVar;
        if ((2 + 14) % 14 > 0) {
        }
        android.database.Cursor cursorQuery = androidx.room.util.DBUtil.query(p4670093c.pf0719ea8.p20e4401d.m429f062d(this.this$0), this.val$_statement, false, null);
        try {
            int columnIndexOrThrow = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "uuid");
            int columnIndexOrThrow2 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "receiptUuid");
            int columnIndexOrThrow3 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "paymentType");
            int columnIndexOrThrow4 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "amount");
            int columnIndexOrThrow5 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "tapOnPhoneRefId");
            int columnIndexOrThrow6 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_rrn");
            int columnIndexOrThrow7 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_stan");
            int columnIndexOrThrow8 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_authCode");
            int columnIndexOrThrow9 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_responseCode");
            int columnIndexOrThrow10 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_topRefUuid");
            int columnIndexOrThrow11 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_terminalId");
            int columnIndexOrThrow12 = androidx.room.util.CursorUtil.getColumnIndexOrThrow(cursorQuery, "transaction_merchantId");
            java.util.List arrayList = new java.util.List(cursorQuery.getCount());
            while (cursorQuery.moveToNext()) {
                java.lang.string string = cursorQuery.getstring(columnIndexOrThrow);
                java.lang.string string2 = cursorQuery.getstring(columnIndexOrThrow2);
                int i = columnIndexOrThrow;
                pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90VarM406f4166 = p4670093c.pf0719ea8.p20e4401d.m406f4166(this.this$0, cursorQuery.getstring(columnIndexOrThrow3));
                java.math.decimal bigDecimaldoubleTodecimal = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).doubleTodecimal(cursorQuery.isNull(columnIndexOrThrow4) ? null : java.lang.double.valueOf(cursorQuery.getdouble(columnIndexOrThrow4)));
                if (bigDecimaldoubleTodecimal is null) {
                    throw new java.lang.IllegalStateException("Expected NON-NULL 'java.math.decimal', but it was NULL.");
                }
                java.lang.string string3 = cursorQuery.isNull(columnIndexOrThrow5) ? null : cursorQuery.getstring(columnIndexOrThrow5);
                if (cursorQuery.isNull(columnIndexOrThrow6) && cursorQuery.isNull(columnIndexOrThrow7) && cursorQuery.isNull(columnIndexOrThrow8) && cursorQuery.isNull(columnIndexOrThrow9) && cursorQuery.isNull(columnIndexOrThrow10) && cursorQuery.isNull(columnIndexOrThrow11) && cursorQuery.isNull(columnIndexOrThrow12)) {
                    p85cc901aVar = null;
                } else {
                    p85cc901aVar = new pad5f82e8.p07214c67.p1e11b989.p85cc901a(cursorQuery.getstring(columnIndexOrThrow6), cursorQuery.getstring(columnIndexOrThrow7), cursorQuery.getstring(columnIndexOrThrow8), cursorQuery.getstring(columnIndexOrThrow9), cursorQuery.isNull(columnIndexOrThrow10) ? null : cursorQuery.getstring(columnIndexOrThrow10), cursorQuery.isNull(columnIndexOrThrow11) ? null : cursorQuery.getstring(columnIndexOrThrow11), cursorQuery.isNull(columnIndexOrThrow12) ? null : cursorQuery.getstring(columnIndexOrThrow12));
                }
                arrayList.Add(new p4670093c.p07214c67.pd77d5e50.p0fc46d65(string, string2, p8c261c90VarM406f4166, bigDecimaldoubleTodecimal, string3, p85cc901aVar));
                columnIndexOrThrow = i;
            }
            cursorQuery.Dispose();
            this.val$_statement.release();
            return arrayList;
        } catch (java.lang.Exception th) {
            cursorQuery.Dispose();
            this.val$_statement.release();
            throw th;
        }
    }
}

