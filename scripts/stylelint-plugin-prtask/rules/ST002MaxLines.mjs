import stylelint from "stylelint";

const RuleName = "prtask/max-lines";

const Meta = {
  url: "",
};

const MaxLines = 300;

const RuleFunction = (PrimaryOption) => {
  return (Root, Result) => {
    const ValidOptions = stylelint.utils.validateOptions(Result, RuleName, {
      actual: PrimaryOption,
    });

    if (!ValidOptions) {
      return;
    }

    const Source = Root.source.input.css;
    const LineCount = Source.split("\n").length;

    if (LineCount > MaxLines) {
      stylelint.utils.report({
        message: `File has ${LineCount} lines, maximum allowed is ${MaxLines}`,
        node: Root,
        result: Result,
        ruleName: RuleName,
      });
    }
  };
};

RuleFunction.ruleName = RuleName;
RuleFunction.meta = Meta;

export const ST002 = stylelint.createPlugin(RuleName, RuleFunction);
