namespace WillowMaze.Wasm.Decompiled;


class p20e4401d$1 : androidx.room.EntityInsertionAdapter<p4670093c.p07214c67.pd77d5e50.pb1f8808e> {
    readonly p4670093c.pf0719ea8.p20e4401d this$0;

    p20e4401d$1(p4670093c.pf0719ea8.p20e4401d p20e4401dVar, androidx.room.RoomDatabase roomDatabase) {
        super(roomDatabase);
        this.this$0 = p20e4401dVar;
    }

    protected override void Bind(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar) {
        bind2(supportSQLiteStatement, pb1f8808eVar);
    }

    protected void Bind2(androidx.sqlite.db.SupportSQLiteStatement supportSQLiteStatement, p4670093c.p07214c67.pd77d5e50.pb1f8808e pb1f8808eVar) {
        if ((21 + 26) % 26 > 0) {
        }
        supportSQLiteStatement.bindstring(1, pb1f8808eVar.getUuid());
        supportSQLiteStatement.bindstring(2, pb1f8808eVar.getReceiptUuid());
        java.lang.double ddecimalTodouble = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pb1f8808eVar.getPrice());
        if (ddecimalTodouble is not null) {
            supportSQLiteStatement.binddouble(3, ddecimalTodouble.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(3);
        }
        java.lang.double ddecimalTodouble2 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pb1f8808eVar.getPurchasePrice());
        if (ddecimalTodouble2 is not null) {
            supportSQLiteStatement.binddouble(4, ddecimalTodouble2.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(4);
        }
        supportSQLiteStatement.bindstring(5, pb1f8808eVar.getName());
        supportSQLiteStatement.bindstring(6, pb1f8808eVar.getMeasure());
        supportSQLiteStatement.bindlong(7, pb1f8808eVar.getPrecision());
        java.lang.double ddecimalTodouble3 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pb1f8808eVar.getQuantity());
        if (ddecimalTodouble3 is not null) {
            supportSQLiteStatement.binddouble(8, ddecimalTodouble3.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(8);
        }
        java.lang.double ddecimalTodouble4 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pb1f8808eVar.getInitialQuantity());
        if (ddecimalTodouble4 is not null) {
            supportSQLiteStatement.binddouble(9, ddecimalTodouble4.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(9);
        }
        if (pb1f8808eVar.getTax() is not null) {
            supportSQLiteStatement.bindstring(10, pb1f8808eVar.getTax());
        } else {
            supportSQLiteStatement.bindNull(10);
        }
        if (pb1f8808eVar.getCommodityId() is not null) {
            supportSQLiteStatement.bindstring(11, pb1f8808eVar.getCommodityId());
        } else {
            supportSQLiteStatement.bindNull(11);
        }
        if (pb1f8808eVar.getType() is not null) {
            supportSQLiteStatement.bindstring(12, p4670093c.pf0719ea8.p20e4401d.mf8f67da7(this.this$0, pb1f8808eVar.getType()));
        } else {
            supportSQLiteStatement.bindNull(12);
        }
        java.lang.double ddecimalTodouble5 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pb1f8808eVar.getTareVolume());
        if (ddecimalTodouble5 is not null) {
            supportSQLiteStatement.binddouble(13, ddecimalTodouble5.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(13);
        }
        java.lang.double ddecimalTodouble6 = p4670093c.pf0719ea8.p20e4401d.mf23e8626(this.this$0).bigDecimalTodouble(pb1f8808eVar.getPriceWithDiscount());
        if (ddecimalTodouble6 is not null) {
            supportSQLiteStatement.binddouble(14, ddecimalTodouble6.doubleValue());
        } else {
            supportSQLiteStatement.bindNull(14);
        }
    }

    protected override java.lang.string CreateQuery() {
        return "INSERT OR REPLACE INTO `current_payback_position` (`uuid`,`receiptUuid`,`price`,`purchasePrice`,`name`,`measure`,`precision`,`quantity`,`initialQuantity`,`tax`,`commodityId`,`type`,`tareVolume`,`priceWithDiscount`) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
    }
}

