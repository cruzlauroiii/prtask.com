namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must target scripts directory js files with ecma version latest and module source type")]
    public void EslintConfigMustTargetScriptsDirectoryJsFilesWithEcmaVersionLatestAndModuleSourceType()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"scripts/**/*.js\"", StringComparison.Ordinal), "ESLint must target scripts/**/*.js files");
        Assert.IsTrue(Config.Contains("ecmaVersion: \"latest\"", StringComparison.Ordinal), "ESLint must use latest ecmaVersion");
        Assert.IsTrue(Config.Contains("sourceType: \"module\"", StringComparison.Ordinal), "ESLint must use module source type");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must include node and es2024 globals for scripts environment configuration")]
    public void EslintConfigMustIncludeNodeAndEs2024GlobalsForScriptsEnvironmentConfiguration()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("...globals.node", StringComparison.Ordinal), "ESLint must spread Node.js globals");
        Assert.IsTrue(Config.Contains("...globals.es2024", StringComparison.Ordinal), "ESLint must spread ES2024 globals");
        Assert.IsTrue(Config.Contains("import globals from \"globals\"", StringComparison.Ordinal), "ESLint must import globals package");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must enforce max depth four max nested callbacks four and max params five")]
    public void EslintConfigMustEnforceMaxDepthFourMaxNestedCallbacksFourAndMaxParamsFive()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"max-depth\": [\"warn\", 4]", StringComparison.Ordinal), "ESLint must limit max-depth to 4");
        Assert.IsTrue(Config.Contains("\"max-nested-callbacks\": [\"warn\", 4]", StringComparison.Ordinal), "ESLint must limit nested callbacks to 4");
        Assert.IsTrue(Config.Contains("\"max-params\": [\"warn\", 5]", StringComparison.Ordinal), "ESLint must limit max-params to 5");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must warn on no magic numbers while ignoring zero one and negative one values")]
    public void EslintConfigMustWarnOnNoMagicNumbersWhileIgnoringZeroOneAndNegativeOneValues()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-magic-numbers\":", StringComparison.Ordinal), "ESLint must have no-magic-numbers rule");
        Assert.IsTrue(Config.Contains("\"ignore\": [0, 1, -1]", StringComparison.Ordinal), "ESLint must ignore 0, 1, -1 in magic numbers");
        Assert.IsTrue(Config.Contains("\"ignoreArrayIndexes\": true", StringComparison.Ordinal), "ESLint must ignore array indexes in magic numbers");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must forbid proto extend native alert caller and labels as errors")]
    public void EslintConfigMustForbidProtoExtendNativeAlertCallerAndLabelsAsErrors()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-proto\": \"error\"", StringComparison.Ordinal), "ESLint must forbid __proto__ usage");
        Assert.IsTrue(Config.Contains("\"no-extend-native\": \"error\"", StringComparison.Ordinal), "ESLint must forbid extending native objects");
        Assert.IsTrue(Config.Contains("\"no-alert\": \"error\"", StringComparison.Ordinal), "ESLint must forbid alert/confirm/prompt");
        Assert.IsTrue(Config.Contains("\"no-caller\": \"error\"", StringComparison.Ordinal), "ESLint must forbid arguments.caller/callee");
        Assert.IsTrue(Config.Contains("\"no-labels\": \"error\"", StringComparison.Ordinal), "ESLint must forbid labeled statements");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must forbid sequences throw literal useless call and useless concat as errors")]
    public void EslintConfigMustForbidSequencesThrowLiteralUselessCallAndUselessConcatAsErrors()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-sequences\": \"error\"", StringComparison.Ordinal), "ESLint must forbid comma operator sequences");
        Assert.IsTrue(Config.Contains("\"no-throw-literal\": \"error\"", StringComparison.Ordinal), "ESLint must require throwing Error objects");
        Assert.IsTrue(Config.Contains("\"no-useless-call\": \"error\"", StringComparison.Ordinal), "ESLint must forbid useless call/apply");
        Assert.IsTrue(Config.Contains("\"no-useless-concat\": \"error\"", StringComparison.Ordinal), "ESLint must forbid useless string concatenation");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must warn on prefer arrow callback destructuring and template literal preferences")]
    public void EslintConfigMustWarnOnPreferArrowCallbackDestructuringAndTemplateLiteralPreferences()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"prefer-arrow-callback\": \"warn\"", StringComparison.Ordinal), "ESLint must prefer arrow callbacks");
        Assert.IsTrue(Config.Contains("\"prefer-destructuring\": \"warn\"", StringComparison.Ordinal), "ESLint must prefer destructuring");
        Assert.IsTrue(Config.Contains("\"prefer-template\": \"warn\"", StringComparison.Ordinal), "ESLint must prefer template literals");
        Assert.IsTrue(Config.Contains("\"prefer-spread\": \"error\"", StringComparison.Ordinal), "ESLint must prefer spread over apply");
        Assert.IsTrue(Config.Contains("\"prefer-rest-params\": \"error\"", StringComparison.Ordinal), "ESLint must prefer rest params over arguments");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must forbid implied eval new func script url and void operator as errors")]
    public void EslintConfigMustForbidImpliedEvalNewFuncScriptUrlAndVoidOperatorAsErrors()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-implied-eval\": \"error\"", StringComparison.Ordinal), "ESLint must forbid implied eval via setTimeout string");
        Assert.IsTrue(Config.Contains("\"no-new-func\": \"error\"", StringComparison.Ordinal), "ESLint must forbid Function constructor");
        Assert.IsTrue(Config.Contains("\"no-script-url\": \"error\"", StringComparison.Ordinal), "ESLint must forbid javascript: URLs");
        Assert.IsTrue(Config.Contains("\"no-void\": \"error\"", StringComparison.Ordinal), "ESLint must forbid void operator");
        Assert.IsTrue(Config.Contains("\"no-with\": \"error\"", StringComparison.Ordinal), "ESLint must forbid with statement");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must warn on no console no unused vars no shadow and require await rules")]
    public void EslintConfigMustWarnOnNoConsoleNoUnusedVarsNoShadowAndRequireAwaitRules()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-console\": \"warn\"", StringComparison.Ordinal), "ESLint must warn on console usage");
        Assert.IsTrue(Config.Contains("\"no-unused-vars\": \"warn\"", StringComparison.Ordinal), "ESLint must warn on unused variables");
        Assert.IsTrue(Config.Contains("\"no-shadow\": \"warn\"", StringComparison.Ordinal), "ESLint must warn on variable shadowing");
        Assert.IsTrue(Config.Contains("\"require-await\": \"warn\"", StringComparison.Ordinal), "ESLint must warn on async without await");
        Assert.IsTrue(Config.Contains("\"prefer-const\": \"warn\"", StringComparison.Ordinal), "ESLint must warn on let that could be const");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must ignore node modules wwwroot bin and obj directories from linting")]
    public void EslintConfigMustIgnoreNodeModulesWwwrootBinAndObjDirectoriesFromLinting()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"node_modules/**\"", StringComparison.Ordinal), "ESLint must ignore node_modules directory");
        Assert.IsTrue(Config.Contains("\"**/wwwroot/**\"", StringComparison.Ordinal), "ESLint must ignore wwwroot directories");
        Assert.IsTrue(Config.Contains("\"**/bin/**\"", StringComparison.Ordinal), "ESLint must ignore bin directories");
        Assert.IsTrue(Config.Contains("\"**/obj/**\"", StringComparison.Ordinal), "ESLint must ignore obj directories");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must forbid return assign self compare loop func and octal escape as errors")]
    public void EslintConfigMustForbidReturnAssignSelfCompareLoopFuncAndOctalEscapeAsErrors()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-return-assign\": \"error\"", StringComparison.Ordinal), "ESLint must forbid assignment in return");
        Assert.IsTrue(Config.Contains("\"no-self-compare\": \"error\"", StringComparison.Ordinal), "ESLint must forbid self comparison");
        Assert.IsTrue(Config.Contains("\"no-loop-func\": \"error\"", StringComparison.Ordinal), "ESLint must forbid functions inside loops");
        Assert.IsTrue(Config.Contains("\"no-octal-escape\": \"error\"", StringComparison.Ordinal), "ESLint must forbid octal escape sequences");
        Assert.IsTrue(Config.Contains("\"no-multi-str\": \"error\"", StringComparison.Ordinal), "ESLint must forbid multiline strings");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must enforce radix symbol description and prefer promise reject errors rules")]
    public void EslintConfigMustEnforceRadixSymbolDescriptionAndPreferPromiseRejectErrorsRules()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"radix\": \"error\"", StringComparison.Ordinal), "ESLint must require radix in parseInt");
        Assert.IsTrue(Config.Contains("\"symbol-description\": \"error\"", StringComparison.Ordinal), "ESLint must require Symbol description");
        Assert.IsTrue(Config.Contains("\"prefer-promise-reject-errors\": \"error\"", StringComparison.Ordinal), "ESLint must require Error in Promise.reject");
        Assert.IsTrue(Config.Contains("\"no-useless-return\": \"error\"", StringComparison.Ordinal), "ESLint must forbid useless return statements");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must forbid duplicate imports useless computed key and useless rename as errors")]
    public void EslintConfigMustForbidDuplicateImportsUselessComputedKeyAndUselessRenameAsErrors()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-duplicate-imports\": \"error\"", StringComparison.Ordinal), "ESLint must forbid duplicate imports");
        Assert.IsTrue(Config.Contains("\"no-useless-computed-key\": \"error\"", StringComparison.Ordinal), "ESLint must forbid useless computed keys");
        Assert.IsTrue(Config.Contains("\"no-useless-rename\": \"error\"", StringComparison.Ordinal), "ESLint must forbid useless import/export rename");
        Assert.IsTrue(Config.Contains("\"no-use-before-define\": \"warn\"", StringComparison.Ordinal), "ESLint must warn on use before define");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must forbid new wrappers lone blocks and curly braces on all statements")]
    public void EslintConfigMustForbidNewWrappersLoneBlocksAndCurlyBracesOnAllStatements()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("\"no-new-wrappers\": \"error\"", StringComparison.Ordinal), "ESLint must forbid new String/Number/Boolean");
        Assert.IsTrue(Config.Contains("\"no-lone-blocks\": \"error\"", StringComparison.Ordinal), "ESLint must forbid unnecessary blocks");
        Assert.IsTrue(Config.Contains("\"curly\": \"error\"", StringComparison.Ordinal), "ESLint must require curly braces");
        Assert.IsTrue(Config.Contains("\"no-undef\": \"error\"", StringComparison.Ordinal), "ESLint must error on undefined variables");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Eslint config must import js from at eslint js as default esm module configuration")]
    public void EslintConfigMustImportJsFromAtEslintJsAsDefaultEsmModuleConfiguration()
    {
        var Config = ReadRootFile("eslint.config.mjs");
        Assert.IsTrue(Config.Contains("import js from \"@eslint/js\"", StringComparison.Ordinal), "ESLint must import from @eslint/js");
        Assert.IsTrue(Config.Contains("export default [", StringComparison.Ordinal), "ESLint must export default array configuration");
        Assert.IsTrue(Config.Contains("js.configs.all", StringComparison.Ordinal), "ESLint must extend js.configs.all");
    }
}
