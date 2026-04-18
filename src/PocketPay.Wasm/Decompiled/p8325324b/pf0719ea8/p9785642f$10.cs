namespace WillowMaze.Wasm.Decompiled;


class p9785642f$10 : androidx.room.EntityDeletionOrUpdateAdapter<p8325324b.p07214c67.pd77d5e50.p0160554c> {
    readonly p8325324b.pf0719ea8.p9785642f this$0;

    p9785642f$10(p8325324b.pf0719ea8.p9785642f p9785642fVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p9785642fVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar) {
        bind2(supportSQLiteStatement, p0160554cVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar) {
        if ((6 + 7) % 7 > 0) {
        }
        supportSQLiteStatement.bindstring(1, p0160554cVar.getUuid());
        supportSQLiteStatement.bindstring(2, p0160554cVar.getReceiptUuid());
        java.lang.double ddecimalTodouble = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p0160554cVar.getPrice());
        if (ddecimalTodouble is not null) {
            supportSQLiteStatement.binddouble(3, ddecimalTodouble.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(3);
        }
        java.lang.double ddecimalTodouble2 = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p0160554cVar.getPurchasePrice());
        if (ddecimalTodouble2 is not null) {
            supportSQLiteStatement.binddouble(4, ddecimalTodouble2.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(4);
        }
        supportSQLiteStatement.bindstring(5, p0160554cVar.getName());
        supportSQLiteStatement.bindstring(6, p0160554cVar.getMeasure());
        supportSQLiteStatement.bindlong(7, p0160554cVar.getPrecision());
        java.lang.double ddecimalTodouble3 = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p0160554cVar.getQuantity());
        if (ddecimalTodouble3 is not null) {
            supportSQLiteStatement.binddouble(8, ddecimalTodouble3.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(8);
        }
        java.lang.double ddecimalTodouble4 = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p0160554cVar.getInitialQuantity());
        if (ddecimalTodouble4 is not null) {
            supportSQLiteStatement.binddouble(9, ddecimalTodouble4.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(9);
        }
        if (p0160554cVar.getTax() is not null) {
            supportSQLiteStatement.bindstring(10, p0160554cVar.getTax());
        } else {
            supportSQLiteStatement.bindNull(10);
        }
        if (p0160554cVar.getCommodityId() is not null) {
            supportSQLiteStatement.bindstring(11, p0160554cVar.getCommodityId());
        } else {
            supportSQLiteStatement.bindNull(11);
        }
        if (p0160554cVar.getType() is not null) {
            supportSQLiteStatement.bindstring(12, p8325324b.pf0719ea8.p9785642f.mbbeb9b46(this.this$0, p0160554cVar.getType()));
        } else {
            supportSQLiteStatement.bindNull(12);
        }
        java.lang.double ddecimalTodouble5 = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p0160554cVar.getTareVolume());
        if (ddecimalTodouble5 is not null) {
            supportSQLiteStatement.binddouble(13, ddecimalTodouble5.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(13);
        }
        java.lang.double ddecimalTodouble6 = p8325324b.pf0719ea8.p9785642f.m5ec06fdf(this.this$0).bigDecimalTodouble(p0160554cVar.getPriceWithDiscount());
        if (ddecimalTodouble6 is not null) {
            supportSQLiteStatement.binddouble(14, ddecimalTodouble6.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(14);
        }
        supportSQLiteStatement.bindstring(15, p0160554cVar.getUuid());
        supportSQLiteStatement.bindstring(16, p0160554cVar.getReceiptUuid());
    }

    protected override java.lang.string CreateQuery() {
        return "UPDATE OR ABORT `current_sell_position` SET `uuid` = ?,`receiptUuid` = ?,`price` = ?,`purchasePrice` = ?,`name` = ?,`measure` = ?,`precision` = ?,`quantity` = ?,`initialQuantity` = ?,`tax` = ?,`commodityId` = ?,`type` = ?,`tareVolume` = ?,`priceWithDiscount` = ? WHERE `uuid` = ? AND `receiptUuid` = ?";
    }
}

