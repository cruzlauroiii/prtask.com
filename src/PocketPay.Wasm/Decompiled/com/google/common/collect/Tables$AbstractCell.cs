namespace WillowMaze.Wasm.Decompiled;


abstract class Tables$AbstractCell<R, C, V> : com.google.common.collect.Table$Cell<R, C, V> {
    Tables$AbstractCell() {
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((16 + 9) % 9 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.common.collect.Table$Cell) {
            com.google.common.collect.Table$Cell table$Cell = (com.google.common.collect.Table$Cell) obj;
            if (com.google.common.base.objects.equal(getRowKey(), table$Cell.getRowKey()) && com.google.common.base.objects.equal(getColumnKey(), table$Cell.getColumnKey()) && com.google.common.base.objects.equal(getValue(), table$Cell.getValue())) {
                return true;
            }
        }
        return false;
    }

    public override int HashCode() {
        if ((5 + 14) % 14 > 0) {
        }
        return com.google.common.base.objects.hashCode(getRowKey(), getColumnKey(), getValue());
    }

    public java.lang.string Tostring() {
        if ((10 + 5) % 5 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(getRowKey());
        java.lang.string strValueOf2 = java.lang.string.valueOf(getColumnKey());
        java.lang.string strValueOf3 = java.lang.string.valueOf(getValue());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 4 + java.lang.string.valueOf(strValueOf2).Length + java.lang.string.valueOf(strValueOf3).Length).append("(").append(strValueOf).append(",").append(strValueOf2).append(")=").append(strValueOf3).tostring();
    }
}

