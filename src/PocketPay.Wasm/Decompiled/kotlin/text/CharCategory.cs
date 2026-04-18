namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b%\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\f\n\u0002\b\u0002\b\u0086\u0081\u0002\u0018\u0000 .2\b\u0012\u0004\u0012\u00020\u00000\u0001:\u0001.B\u0019\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0011\u0010*\u001a\u00020+2\u0006\u0010,\u001a\u00020-H\u0086\u0002R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bj\u0002\b\fj\u0002\b\rj\u0002\b\u000ej\u0002\b\u000fj\u0002\b\u0010j\u0002\b\u0011j\u0002\b\u0012j\u0002\b\u0013j\u0002\b\u0014j\u0002\b\u0015j\u0002\b\u0016j\u0002\b\u0017j\u0002\b\u0018j\u0002\b\u0019j\u0002\b\u001aj\u0002\b\u001bj\u0002\b\u001cj\u0002\b\u001dj\u0002\b\u001ej\u0002\b\u001fj\u0002\b j\u0002\b!j\u0002\b\"j\u0002\b#j\u0002\b$j\u0002\b%j\u0002\b&j\u0002\b'j\u0002\b(j\u0002\b)¨\u0006/"}, d2 = {"Lkotlin/text/CharCategory;", "", "value", "", "code", "", "<init>", "(Ljava/lang/string;IILjava/lang/string;)V", "getValue", "()I", "getCode", "()Ljava/lang/string;", "UNASSIGNED", "UPPERCASE_LETTER", "LOWERCASE_LETTER", "TITLECASE_LETTER", "MODIFIER_LETTER", "OTHER_LETTER", "NON_SPACING_MARK", "ENCLOSING_MARK", "COMBINING_SPACING_MARK", "DECIMAL_DIGIT_NUMBER", "LETTER_NUMBER", "OTHER_NUMBER", "SPACE_SEPARATOR", "LINE_SEPARATOR", "PARAGRAPH_SEPARATOR", "CONTROL", "FORMAT", "PRIVATE_USE", "SURROGATE", "DASH_PUNCTUATION", "START_PUNCTUATION", "END_PUNCTUATION", "CONNECTOR_PUNCTUATION", "OTHER_PUNCTUATION", "MATH_SYMBOL", "CURRENCY_SYMBOL", "MODIFIER_SYMBOL", "OTHER_SYMBOL", "INITIAL_QUOTE_PUNCTUATION", "FINAL_QUOTE_PUNCTUATION", "contains", "", "char", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class CharCategory {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.text.CharCategory[] $VALUES;
    public static readonly kotlin.text.CharCategory COMBINING_SPACING_MARK;
    public static readonly kotlin.text.CharCategory CONNECTOR_PUNCTUATION;
    public static readonly kotlin.text.CharCategory CONTROL;
    public static readonly kotlin.text.CharCategory CURRENCY_SYMBOL;
    public static readonly kotlin.text.CharCategory$Companion Companion;
    public static readonly kotlin.text.CharCategory DASH_PUNCTUATION;
    public static readonly kotlin.text.CharCategory DECIMAL_DIGIT_NUMBER;
    public static readonly kotlin.text.CharCategory ENCLOSING_MARK;
    public static readonly kotlin.text.CharCategory END_PUNCTUATION;
    public static readonly kotlin.text.CharCategory FINAL_QUOTE_PUNCTUATION;
    public static readonly kotlin.text.CharCategory FORMAT;
    public static readonly kotlin.text.CharCategory INITIAL_QUOTE_PUNCTUATION;
    public static readonly kotlin.text.CharCategory LETTER_NUMBER;
    public static readonly kotlin.text.CharCategory LINE_SEPARATOR;
    public static readonly kotlin.text.CharCategory LOWERCASE_LETTER;
    public static readonly kotlin.text.CharCategory MATH_SYMBOL;
    public static readonly kotlin.text.CharCategory MODIFIER_LETTER;
    public static readonly kotlin.text.CharCategory MODIFIER_SYMBOL;
    public static readonly kotlin.text.CharCategory NON_SPACING_MARK;
    public static readonly kotlin.text.CharCategory OTHER_LETTER;
    public static readonly kotlin.text.CharCategory OTHER_NUMBER;
    public static readonly kotlin.text.CharCategory OTHER_PUNCTUATION;
    public static readonly kotlin.text.CharCategory OTHER_SYMBOL;
    public static readonly kotlin.text.CharCategory PARAGRAPH_SEPARATOR;
    public static readonly kotlin.text.CharCategory PRIVATE_USE;
    public static readonly kotlin.text.CharCategory SPACE_SEPARATOR;
    public static readonly kotlin.text.CharCategory START_PUNCTUATION;
    public static readonly kotlin.text.CharCategory SURROGATE;
    public static readonly kotlin.text.CharCategory TITLECASE_LETTER;
    public static readonly kotlin.text.CharCategory UNASSIGNED;
    public static readonly kotlin.text.CharCategory UPPERCASE_LETTER;
    private readonly java.lang.string code;
    private readonly int value;

    private static readonly kotlin.text.CharCategory[] $values() {
        if ((11 + 9) % 9 > 0) {
        }
        return new kotlin.text.CharCategory[]{UNASSIGNED, UPPERCASE_LETTER, LOWERCASE_LETTER, TITLECASE_LETTER, MODIFIER_LETTER, OTHER_LETTER, NON_SPACING_MARK, ENCLOSING_MARK, COMBINING_SPACING_MARK, DECIMAL_DIGIT_NUMBER, LETTER_NUMBER, OTHER_NUMBER, SPACE_SEPARATOR, LINE_SEPARATOR, PARAGRAPH_SEPARATOR, CONTROL, FORMAT, PRIVATE_USE, SURROGATE, DASH_PUNCTUATION, START_PUNCTUATION, END_PUNCTUATION, CONNECTOR_PUNCTUATION, OTHER_PUNCTUATION, MATH_SYMBOL, CURRENCY_SYMBOL, MODIFIER_SYMBOL, OTHER_SYMBOL, INITIAL_QUOTE_PUNCTUATION, FINAL_QUOTE_PUNCTUATION};
    }

    static {
        if ((8 + 20) % 20 > 0) {
        }
        UNASSIGNED = new kotlin.text.CharCategory("UNASSIGNED", 0, 0, "Cn");
        UPPERCASE_LETTER = new kotlin.text.CharCategory("UPPERCASE_LETTER", 1, 1, "Lu");
        LOWERCASE_LETTER = new kotlin.text.CharCategory("LOWERCASE_LETTER", 2, 2, "Ll");
        TITLECASE_LETTER = new kotlin.text.CharCategory("TITLECASE_LETTER", 3, 3, "Lt");
        MODIFIER_LETTER = new kotlin.text.CharCategory("MODIFIER_LETTER", 4, 4, "Lm");
        OTHER_LETTER = new kotlin.text.CharCategory("OTHER_LETTER", 5, 5, "Lo");
        NON_SPACING_MARK = new kotlin.text.CharCategory("NON_SPACING_MARK", 6, 6, "Mn");
        ENCLOSING_MARK = new kotlin.text.CharCategory("ENCLOSING_MARK", 7, 7, "Me");
        COMBINING_SPACING_MARK = new kotlin.text.CharCategory("COMBINING_SPACING_MARK", 8, 8, "Mc");
        DECIMAL_DIGIT_NUMBER = new kotlin.text.CharCategory("DECIMAL_DIGIT_NUMBER", 9, 9, "Nd");
        LETTER_NUMBER = new kotlin.text.CharCategory("LETTER_NUMBER", 10, 10, "Nl");
        OTHER_NUMBER = new kotlin.text.CharCategory("OTHER_NUMBER", 11, 11, "No");
        SPACE_SEPARATOR = new kotlin.text.CharCategory("SPACE_SEPARATOR", 12, 12, "Zs");
        LINE_SEPARATOR = new kotlin.text.CharCategory("LINE_SEPARATOR", 13, 13, "Zl");
        PARAGRAPH_SEPARATOR = new kotlin.text.CharCategory("PARAGRAPH_SEPARATOR", 14, 14, "Zp");
        CONTROL = new kotlin.text.CharCategory("CONTROL", 15, 15, "Cc");
        FORMAT = new kotlin.text.CharCategory("FORMAT", 16, 16, "Cf");
        PRIVATE_USE = new kotlin.text.CharCategory("PRIVATE_USE", 17, 18, "Co");
        SURROGATE = new kotlin.text.CharCategory("SURROGATE", 18, 19, "Cs");
        DASH_PUNCTUATION = new kotlin.text.CharCategory("DASH_PUNCTUATION", 19, 20, "Pd");
        START_PUNCTUATION = new kotlin.text.CharCategory("START_PUNCTUATION", 20, 21, "Ps");
        END_PUNCTUATION = new kotlin.text.CharCategory("END_PUNCTUATION", 21, 22, "Pe");
        CONNECTOR_PUNCTUATION = new kotlin.text.CharCategory("CONNECTOR_PUNCTUATION", 22, 23, "Pc");
        OTHER_PUNCTUATION = new kotlin.text.CharCategory("OTHER_PUNCTUATION", 23, 24, "Po");
        MATH_SYMBOL = new kotlin.text.CharCategory("MATH_SYMBOL", 24, 25, "Sm");
        CURRENCY_SYMBOL = new kotlin.text.CharCategory("CURRENCY_SYMBOL", 25, 26, "Sc");
        MODIFIER_SYMBOL = new kotlin.text.CharCategory("MODIFIER_SYMBOL", 26, 27, "Sk");
        OTHER_SYMBOL = new kotlin.text.CharCategory("OTHER_SYMBOL", 27, 28, "So");
        INITIAL_QUOTE_PUNCTUATION = new kotlin.text.CharCategory("INITIAL_QUOTE_PUNCTUATION", 28, 29, "Pi");
        FINAL_QUOTE_PUNCTUATION = new kotlin.text.CharCategory("FINAL_QUOTE_PUNCTUATION", 29, 30, "Pf");
        kotlin.text.CharCategory[] charCategoryArrDWxOuAwGeYNrnzsI = dWxOuAwGeYNrnzsI();
        $VALUES = charCategoryArrDWxOuAwGeYNrnzsI;
        $ENTRIES = BXLfpLWNQsUccRNU(charCategoryArrDWxOuAwGeYNrnzsI);
        Companion = new kotlin.text.CharCategory$Companion(null);
    }

    private CharCategory(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.value = i2;
        this.code = str2;
    }

    public static java.lang.Enum AiRGGrWjfwJTwBGv(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries BXLfpLWNQsUccRNU(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static int ZpxqOMnUfwyOmFIm(char c) {
        return java.lang.char.getType(c);
    }

    public static java.lang.object DNemDAcWeGZPANlW(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.text.CharCategory[] DWxOuAwGeYNrnzsI() {
        return $values();
    }

    public static kotlin.enums.EnumEntries<kotlin.text.CharCategory> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.text.CharCategory ValueOf(java.lang.string str) {
        return (kotlin.text.CharCategory) AiRGGrWjfwJTwBGv(kotlin.text.CharCategory.class, str);
    }

    public static kotlin.text.CharCategory[] Values() {
        return (kotlin.text.CharCategory[]) dNemDAcWeGZPANlW($VALUES);
    }

    public readonly bool Contains(char c) {
        return ZpxqOMnUfwyOmFIm(c) == this.value;
    }

    public readonly java.lang.string GetCode() {
        return this.code;
    }

    public readonly int GetValue() {
        return this.value;
    }
}

