namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce selector max specificity one four four and max class four")]
    public void StylelintConfigMustEnforceSelectorMaxSpecificityOneFourFourAndMaxClassFour()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"selector-max-specificity\": \"1,4,4\"", StringComparison.Ordinal), "Stylelint must limit specificity to 1,4,4");
        Assert.IsTrue(Config.Contains("\"selector-max-class\": 4", StringComparison.Ordinal), "Stylelint must limit classes to 4");
        Assert.IsTrue(Config.Contains("\"selector-max-combinators\": 4", StringComparison.Ordinal), "Stylelint must limit combinators to 4");
        Assert.IsTrue(Config.Contains("\"selector-max-compound-selectors\": 4", StringComparison.Ordinal), "Stylelint must limit compound selectors to 4");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must limit selector max id one max type three and max universal one")]
    public void StylelintConfigMustLimitSelectorMaxIdOneMaxTypeThreeAndMaxUniversalOne()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"selector-max-id\": 1", StringComparison.Ordinal), "Stylelint must limit ID selectors to 1");
        Assert.IsTrue(Config.Contains("\"selector-max-type\": 3", StringComparison.Ordinal), "Stylelint must limit type selectors to 3");
        Assert.IsTrue(Config.Contains("\"selector-max-universal\": 1", StringComparison.Ordinal), "Stylelint must limit universal selectors to 1");
        Assert.IsTrue(Config.Contains("\"selector-max-pseudo-class\": 3", StringComparison.Ordinal), "Stylelint must limit pseudo-classes to 3");
        Assert.IsTrue(Config.Contains("\"selector-max-attribute\": 2", StringComparison.Ordinal), "Stylelint must limit attribute selectors to 2");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce alpha value percentage hue degree angle and modern color function")]
    public void StylelintConfigMustEnforceAlphaValuePercentageHueDegreeAngleAndModernColorFunction()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"alpha-value-notation\": \"percentage\"", StringComparison.Ordinal), "Stylelint must use percentage alpha values");
        Assert.IsTrue(Config.Contains("\"hue-degree-notation\": \"angle\"", StringComparison.Ordinal), "Stylelint must use angle hue notation");
        Assert.IsTrue(Config.Contains("\"color-function-notation\": \"modern\"", StringComparison.Ordinal), "Stylelint must use modern color function notation");
        Assert.IsTrue(Config.Contains("\"number-max-precision\": 4", StringComparison.Ordinal), "Stylelint must limit number precision to 4");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce length zero no unit and shorthand property no redundant values")]
    public void StylelintConfigMustEnforceLengthZeroNoUnitAndShorthandPropertyNoRedundantValues()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"length-zero-no-unit\": true", StringComparison.Ordinal), "Stylelint must remove units from zero values");
        Assert.IsTrue(Config.Contains("\"shorthand-property-no-redundant-values\": true", StringComparison.Ordinal), "Stylelint must disallow redundant shorthand values");
        Assert.IsTrue(Config.Contains("\"value-no-vendor-prefix\": true", StringComparison.Ordinal), "Stylelint must forbid vendor prefixes in values");
        Assert.IsTrue(Config.Contains("\"property-no-vendor-prefix\": true", StringComparison.Ordinal), "Stylelint must forbid vendor prefixes in properties");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must forbid vendor prefixes in selectors media features and at rules")]
    public void StylelintConfigMustForbidVendorPrefixesInSelectorsMediaFeaturesAndAtRules()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"selector-no-vendor-prefix\": true", StringComparison.Ordinal), "Stylelint must forbid vendor prefixes in selectors");
        Assert.IsTrue(Config.Contains("\"media-feature-name-no-vendor-prefix\": true", StringComparison.Ordinal), "Stylelint must forbid vendor prefixes in media features");
        Assert.IsTrue(Config.Contains("\"at-rule-no-vendor-prefix\": true", StringComparison.Ordinal), "Stylelint must forbid vendor prefixes in at-rules");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must allow deep and global pseudo classes and blazor type selectors")]
    public void StylelintConfigMustAllowDeepAndGlobalPseudoClassesAndBlazorTypeSelectors()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"ignorePseudoClasses\": [\"deep\", \"global\"]", StringComparison.Ordinal), "Stylelint must ignore deep and global pseudo classes");
        Assert.IsTrue(Config.Contains("\"ignoreTypes\": [\"app\", \"/^blazor-/\"]", StringComparison.Ordinal), "Stylelint must ignore app and blazor- type selectors");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce no duplicate properties with consecutive different syntaxes exception")]
    public void StylelintConfigMustEnforceNoDuplicatePropertiesWithConsecutiveDifferentSyntaxesException()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"declaration-block-no-duplicate-properties\":", StringComparison.Ordinal), "Stylelint must check for duplicate properties");
        Assert.IsTrue(Config.Contains("\"consecutive-duplicates-with-different-syntaxes\"", StringComparison.Ordinal), "Stylelint must allow consecutive duplicates with different syntaxes");
        Assert.IsTrue(Config.Contains("\"declaration-block-no-duplicate-custom-properties\": true", StringComparison.Ordinal), "Stylelint must forbid duplicate custom properties");
        Assert.IsTrue(Config.Contains("\"declaration-block-no-shorthand-property-overrides\": true", StringComparison.Ordinal), "Stylelint must forbid shorthand overrides");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce no descending specificity no duplicate selectors and no empty source")]
    public void StylelintConfigMustEnforceNoDescendingSpecificityNoDuplicateSelectorsAndNoEmptySource()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-descending-specificity\": true", StringComparison.Ordinal), "Stylelint must forbid descending specificity");
        Assert.IsTrue(Config.Contains("\"no-duplicate-selectors\": true", StringComparison.Ordinal), "Stylelint must forbid duplicate selectors");
        Assert.IsTrue(Config.Contains("\"no-empty-source\": true", StringComparison.Ordinal), "Stylelint must forbid empty sources");
        Assert.IsTrue(Config.Contains("\"no-duplicate-at-import-rules\": true", StringComparison.Ordinal), "Stylelint must forbid duplicate imports");
        Assert.IsTrue(Config.Contains("\"no-unknown-animations\": true", StringComparison.Ordinal), "Stylelint must forbid unknown animation names");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce lower case for value keywords function names and selector types")]
    public void StylelintConfigMustEnforceLowerCaseForValueKeywordsFunctionNamesAndSelectorTypes()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"value-keyword-case\": \"lower\"", StringComparison.Ordinal), "Stylelint must enforce lowercase value keywords");
        Assert.IsTrue(Config.Contains("\"function-name-case\": \"lower\"", StringComparison.Ordinal), "Stylelint must enforce lowercase function names");
        Assert.IsTrue(Config.Contains("\"selector-type-case\": \"lower\"", StringComparison.Ordinal), "Stylelint must enforce lowercase type selectors");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must ignore css files node modules wwwroot bin and obj from processing")]
    public void StylelintConfigMustIgnoreCssFilesNodeModulesWwwrootBinAndObjFromProcessing()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"**/*.css\"", StringComparison.Ordinal), "Stylelint must ignore compiled CSS files");
        Assert.IsTrue(Config.Contains("\"**/node_modules/**\"", StringComparison.Ordinal), "Stylelint must ignore node_modules");
        Assert.IsTrue(Config.Contains("\"**/wwwroot/**\"", StringComparison.Ordinal), "Stylelint must ignore wwwroot output");
        Assert.IsTrue(Config.Contains("\"**/bin/**\"", StringComparison.Ordinal), "Stylelint must ignore bin directories");
        Assert.IsTrue(Config.Contains("\"**/obj/**\"", StringComparison.Ordinal), "Stylelint must ignore obj directories");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must have overrides section for razor scss files with empty rules object")]
    public void StylelintConfigMustHaveOverridesSectionForRazorScssFilesWithEmptyRulesObject()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"**/*.razor.scss\"", StringComparison.Ordinal), "Stylelint must have override for razor.scss files");
        Assert.IsTrue(Config.Contains("overrides:", StringComparison.Ordinal), "Stylelint must define overrides section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce scss specific rules for no duplicate mixins and no global functions")]
    public void StylelintConfigMustEnforceScssSpecificRulesForNoDuplicateMixinsAndNoGlobalFunctions()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"scss/no-duplicate-mixins\": true", StringComparison.Ordinal), "Stylelint must forbid duplicate SCSS mixins");
        Assert.IsTrue(Config.Contains("\"scss/no-global-function-names\": true", StringComparison.Ordinal), "Stylelint must forbid global SCSS function names");
        Assert.IsTrue(Config.Contains("\"scss/at-rule-no-unknown\": true", StringComparison.Ordinal), "Stylelint must check unknown SCSS at-rules");
        Assert.IsTrue(Config.Contains("\"scss/comment-no-empty\": true", StringComparison.Ordinal), "Stylelint must forbid empty SCSS comments");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce scss dollar variable spacing and empty line conventions")]
    public void StylelintConfigMustEnforceScssDollarVariableSpacingAndEmptyLineConventions()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"scss/dollar-variable-colon-space-after\": \"always-single-line\"", StringComparison.Ordinal), "Stylelint must enforce space after dollar variable colon");
        Assert.IsTrue(Config.Contains("\"scss/dollar-variable-colon-space-before\": \"never\"", StringComparison.Ordinal), "Stylelint must forbid space before dollar variable colon");
        Assert.IsTrue(Config.Contains("\"scss/dollar-variable-no-missing-interpolation\": true", StringComparison.Ordinal), "Stylelint must check missing interpolation");
        Assert.IsTrue(Config.Contains("\"scss/operator-no-unspaced\": true", StringComparison.Ordinal), "Stylelint must require spaces around operators");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce scss selector no redundant nesting and at extend no missing placeholder")]
    public void StylelintConfigMustEnforceScssSelectoNoRedundantNestingAndAtExtendNoMissingPlaceholder()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"scss/selector-no-redundant-nesting-selector\": true", StringComparison.Ordinal), "Stylelint must forbid redundant nesting");
        Assert.IsTrue(Config.Contains("\"scss/at-extend-no-missing-placeholder\": true", StringComparison.Ordinal), "Stylelint must require placeholder in @extend");
        Assert.IsTrue(Config.Contains("\"scss/at-if-no-null\": true", StringComparison.Ordinal), "Stylelint must forbid null comparison in @if");
        Assert.IsTrue(Config.Contains("\"scss/at-mixin-argumentless-call-parentheses\": \"always\"", StringComparison.Ordinal), "Stylelint must require parentheses on mixin calls");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce scss double slash comment whitespace and empty line before rules")]
    public void StylelintConfigMustEnforceScssDoubleSlashCommentWhitespaceAndEmptyLineBeforeRules()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"scss/double-slash-comment-whitespace-inside\": \"always\"", StringComparison.Ordinal), "Stylelint must require whitespace in // comments");
        Assert.IsTrue(Config.Contains("\"scss/operator-no-newline-after\": true", StringComparison.Ordinal), "Stylelint must forbid newline after operator");
        Assert.IsTrue(Config.Contains("\"scss/operator-no-newline-before\": true", StringComparison.Ordinal), "Stylelint must forbid newline before operator");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce function url no scheme relative and block no empty rules")]
    public void StylelintConfigMustEnforceFunctionUrlNoSchemeRelativeAndBlockNoEmptyRules()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"function-url-no-scheme-relative\": true", StringComparison.Ordinal), "Stylelint must forbid scheme-relative URLs");
        Assert.IsTrue(Config.Contains("\"block-no-empty\": true", StringComparison.Ordinal), "Stylelint must forbid empty blocks");
        Assert.IsTrue(Config.Contains("\"keyframe-declaration-no-important\": true", StringComparison.Ordinal), "Stylelint must forbid !important in keyframes");
        Assert.IsTrue(Config.Contains("\"declaration-block-single-line-max-declarations\": 1", StringComparison.Ordinal), "Stylelint must limit single-line declarations to 1");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce color no invalid hex font family rules and calc no unspaced operator")]
    public void StylelintConfigMustEnforceColorNoInvalidHexFontFamilyRulesAndCalcNoUnspacedOperator()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"color-no-invalid-hex\": true", StringComparison.Ordinal), "Stylelint must check for invalid hex colors");
        Assert.IsTrue(Config.Contains("\"font-family-no-duplicate-names\": true", StringComparison.Ordinal), "Stylelint must forbid duplicate font family names");
        Assert.IsTrue(Config.Contains("\"font-family-no-missing-generic-family-keyword\": true", StringComparison.Ordinal), "Stylelint must require generic font family");
        Assert.IsTrue(Config.Contains("\"function-calc-no-unspaced-operator\": true", StringComparison.Ordinal), "Stylelint must require spaces in calc()");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must set at rule no unknown to null to allow scss at rules instead")]
    public void StylelintConfigMustSetAtRuleNoUnknownToNullToAllowScssAtRulesInstead()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"at-rule-no-unknown\": null", StringComparison.Ordinal), "Stylelint must disable CSS at-rule-no-unknown in favor of SCSS version");
        Assert.IsTrue(Config.Contains("\"no-invalid-double-slash-comments\": true", StringComparison.Ordinal), "Stylelint must check invalid double-slash comments");
        Assert.IsTrue(Config.Contains("\"no-invalid-position-at-import-rule\": true", StringComparison.Ordinal), "Stylelint must check import position");
        Assert.IsTrue(Config.Contains("\"color-no-hex\": null", StringComparison.Ordinal), "Stylelint must allow hex colors by disabling color-no-hex");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Stylelint config must enforce selector qualifying type ignore attribute and class options")]
    public void StylelintConfigMustEnforceSelectorQualifyingTypeIgnoreAttributeAndClassOptions()
    {
        var Config = ReadRootFile("stylelint.config.mjs");
        Assert.IsTrue(Config.Contains("\"selector-no-qualifying-type\":", StringComparison.Ordinal), "Stylelint must enforce selector-no-qualifying-type");
        Assert.IsTrue(Config.Contains("\"ignore\": [\"attribute\", \"class\"]", StringComparison.Ordinal), "Stylelint must ignore attribute and class qualifiers");
        Assert.IsTrue(Config.Contains("\"string-no-newline\": true", StringComparison.Ordinal), "Stylelint must forbid newlines in strings");
        Assert.IsTrue(Config.Contains("\"unit-no-unknown\": true", StringComparison.Ordinal), "Stylelint must forbid unknown units");
        Assert.IsTrue(Config.Contains("\"property-no-unknown\": true", StringComparison.Ordinal), "Stylelint must forbid unknown properties");
    }
}
