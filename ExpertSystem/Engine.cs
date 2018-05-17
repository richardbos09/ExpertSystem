using System;
using System.Collections.Generic;
using System.Text;
using chen0040.ExpertSystem;

namespace ExpertSystem
{
    public class Engine
    {
        public String[] prior_educations = {
            "applicatieontwikkelaar",
            "mediaontwikkelaar",
            "mediavormgever",
            "gamedesigner",
            "ict-beheerder",
            "systeembeheerder",
            "netwerkbeheerder",
        };

        public RuleInferenceEngine GetInferenceEngine()
        {
            RuleInferenceEngine rie = new RuleInferenceEngine();

            Rule rule = new Rule("1");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("2");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("3");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("4");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("5");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("6");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("7");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("8");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("9");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("9");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("10");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("11");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("12");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("13");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("14");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new LEClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("15");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));
            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("16");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));
            rule.AddAntecedent(new LEClause("Number of refusals?", "1"));
            rule.AddAntecedent(new GreaterClause("What is your average score?", "16"));
            rule.setConsequent(new IsClause("Advice", "negative"));
            rie.AddRule(rule);

            return rie;
        }
    }
}
