import stylelint from "stylelint";

const RuleName = "prtask/no-magic-numbers";

const Meta = {
  url: "",
};

const AllowedNumbers = new Set(["0", "1", "2"]);
const UnitlessProperties = new Set([
  "flex",
  "flex-grow",
  "flex-shrink",
  "opacity",
  "z-index",
  "order",
  "font-weight",
  "line-height",
  "orphans",
  "widows",
  "columns",
  "column-count",
  "fill-opacity",
  "stroke-opacity",
]);

const NumberPattern = /(?<!\$[\w-]*)(?<![a-zA-Z_-])(\d+\.?\d*)/g;

function ExtractNumbers(Value) {
  const Matches = [];
  let Match;
  while ((Match = NumberPattern.exec(Value)) !== null) {
    Matches.push(Match[1]);
  }
  NumberPattern.lastIndex = 0;
  return Matches;
}

const RuleFunction = (PrimaryOption) => {
  return (Root, Result) => {
    const ValidOptions = stylelint.utils.validateOptions(Result, RuleName, {
      actual: PrimaryOption,
    });

    if (!ValidOptions) {
      return;
    }

    Root.walkDecls((Decl) => {
      if (Decl.prop.startsWith("$")) {
        return;
      }

      if (Decl.prop.startsWith("--")) {
        return;
      }

      const Value = Decl.value;

      if (Value.includes("$")) {
        return;
      }

      if (UnitlessProperties.has(Decl.prop)) {
        return;
      }

      const Numbers = ExtractNumbers(Value);

      for (const Num of Numbers) {
        if (AllowedNumbers.has(Num)) {
          continue;
        }

        const NumIndex = Value.indexOf(Num);
        const AfterNum = Value.slice(NumIndex + Num.length);
        if (AfterNum.startsWith("%") && (Num === "100" || Num === "50")) {
          continue;
        }

        stylelint.utils.report({
          message: `Unexpected magic number "${Num}" in value "${Value}"`,
          node: Decl,
          result: Result,
          ruleName: RuleName,
        });
      }
    });
  };
};

RuleFunction.ruleName = RuleName;
RuleFunction.meta = Meta;

export const ST004 = stylelint.createPlugin(RuleName, RuleFunction);
