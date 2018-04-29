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
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));        // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));     // +4

            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));                  // +3
            rule.AddAntecedent(new LessClause("What is your competencies?", "5"));              // +4
            rule.AddAntecedent(new LessClause("What is your capacities?", "4"));                // +5
            rule.AddAntecedent(new LessClause("What is your intrinsic motivation?", "4"));      // +5
            rule.AddAntecedent(new LessClause("What is your extrinsic motivation?", "5"));      // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "yes"));                  // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "yes"));  // +1

            rule.AddAntecedent(new GreaterClause("Number of restrictions?", "2"));              // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "no"));      // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "yes")); // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "yes"));  // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "yes"));    // +4

            rule.setConsequent(new IsClause("advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("2");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));        // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));     // +4

            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));                  // +3
            rule.AddAntecedent(new LessClause("What is your competencies?", "5"));              // +4
            rule.AddAntecedent(new LessClause("What is your capacities?", "4"));                // +5
            rule.AddAntecedent(new LessClause("What is your intrinsic motivation?", "4"));      // +5
            rule.AddAntecedent(new LessClause("What is your extrinsic motivation?", "5"));      // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "yes"));                  // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "no"));   // +1

            rule.AddAntecedent(new GreaterClause("Number of restrictions?", "2"));              // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "no"));      // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "yes")); // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "yes"));  // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "yes"));    // +4

            rule.setConsequent(new IsClause("advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("3");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));        // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));     // +4

            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));                  // +3
            rule.AddAntecedent(new LessClause("What is your competencies?", "5"));              // +4
            rule.AddAntecedent(new LessClause("What is your capacities?", "4"));                // +5
            rule.AddAntecedent(new LessClause("What is your intrinsic motivation?", "4"));      // +5
            rule.AddAntecedent(new LessClause("What is your extrinsic motivation?", "5"));      // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "no"));                   // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "no"));   // +1

            rule.AddAntecedent(new GreaterClause("Number of restrictions?", "2"));              // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "no"));      // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "yes")); // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "yes"));  // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "yes"));    // +4

            rule.setConsequent(new IsClause("advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("4");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));        // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));     // +4

            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));                  // +3
            rule.AddAntecedent(new LessClause("What is your competencies?", "5"));              // +4
            rule.AddAntecedent(new LessClause("What is your capacities?", "4"));                // +5
            rule.AddAntecedent(new LessClause("What is your intrinsic motivation?", "4"));      // +5
            rule.AddAntecedent(new LessClause("What is your extrinsic motivation?", "5"));      // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "no"));                   // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "no"));   // +1

            rule.AddAntecedent(new GreaterClause("Number of restrictions?", "2"));              // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "no"));      // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "no"));  // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "no"));   // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "yes"));    // +4

            rule.setConsequent(new IsClause("advice", "negative"));
            rie.AddRule(rule);

            rule = new Rule("5");
            rule.AddAntecedent(new IsClause("What was your prior education?", "false"));        // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));    // +4

            rule.AddAntecedent(new GreaterClause("Number of refusals?", "1"));                  // +3
            rule.AddAntecedent(new LessClause("What is your competencies?", "5"));              // +4
            rule.AddAntecedent(new LessClause("What is your capacities?", "4"));                // +5
            rule.AddAntecedent(new LessClause("What is your intrinsic motivation?", "4"));      // +5
            rule.AddAntecedent(new LessClause("What is your extrinsic motivation?", "5"));      // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "no"));                   // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "no"));   // +1

            rule.AddAntecedent(new GreaterClause("Number of restrictions?", "2"));              // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "no"));      // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "yes")); // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "yes"));  // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "no"));     // +4

            rule.setConsequent(new IsClause("advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("6");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));         // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "no"));     // +4

            rule.AddAntecedent(new LessClause("Number of refusals?", "2"));                     // +3
            rule.AddAntecedent(new GreaterClause("What is your competencies?", "4"));           // +4
            rule.AddAntecedent(new GreaterClause("What is your capacities?", "5"));             // +5
            rule.AddAntecedent(new GreaterClause("What is your intrinsic motivation?", "5"));   // +5
            rule.AddAntecedent(new GreaterClause("What is your extrinsic motivation?", "4"));   // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "yes"));                  // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "yes"));  // +1

            rule.AddAntecedent(new LessClause("Number of restrictions?", "3"));                 // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "yes"));     // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "no"));  // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "no"));   // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "yes"));    // +4

            rule.setConsequent(new IsClause("advice", "doubt"));
            rie.AddRule(rule);

            rule = new Rule("7");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));         // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));    // +4

            rule.AddAntecedent(new LessClause("Number of refusals?", "2"));                     // +3
            rule.AddAntecedent(new GreaterClause("What is your competencies?", "4"));           // +4
            rule.AddAntecedent(new GreaterClause("What is your capacities?", "5"));             // +5
            rule.AddAntecedent(new GreaterClause("What is your intrinsic motivation?", "5"));   // +5
            rule.AddAntecedent(new GreaterClause("What is your extrinsic motivation?", "4"));   // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "no"));                   // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "yes"));  // +1

            rule.AddAntecedent(new LessClause("Number of restrictions?", "3"));                 // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "yes"));     // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "no"));  // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "yes"));  // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "no"));     // +4

            rule.setConsequent(new IsClause("advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("8");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));         // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));    // +4

            rule.AddAntecedent(new LessClause("Number of refusals?", "1"));                     // +3
            rule.AddAntecedent(new GreaterClause("What is your competencies?", "4"));           // +4
            rule.AddAntecedent(new GreaterClause("What is your capacities?", "5"));             // +5
            rule.AddAntecedent(new GreaterClause("What is your intrinsic motivation?", "5"));   // +5
            rule.AddAntecedent(new GreaterClause("What is your extrinsic motivation?", "4"));   // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "yes"));                  // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "yes"));  // +1

            rule.AddAntecedent(new LessClause("Number of restrictions?", "3"));                 // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "yes"));     // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "no"));  // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "no"));   // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "no"));     // +4

            rule.setConsequent(new IsClause("advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("9");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));         // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));    // +4

            rule.AddAntecedent(new LessClause("Number of refusals?", "1"));                     // +3
            rule.AddAntecedent(new GreaterClause("What is your competencies?", "4"));           // +4
            rule.AddAntecedent(new GreaterClause("What is your capacities?", "5"));             // +5
            rule.AddAntecedent(new GreaterClause("What is your intrinsic motivation?", "5"));   // +5
            rule.AddAntecedent(new GreaterClause("What is your extrinsic motivation?", "4"));   // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "no"));                   // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "yes"));  // +1

            rule.AddAntecedent(new LessClause("Number of restrictions?", "3"));                 // +1

            rule.AddAntecedent(new IsClause("Have you received any study choice?", "yes"));     // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "no"));  // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "no"));   // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "no"));     // +4

            rule.setConsequent(new IsClause("advice", "positive"));
            rie.AddRule(rule);

            rule = new Rule("10");
            rule.AddAntecedent(new IsClause("What was your prior education?", "true"));         // +5
            rule.AddAntecedent(new IsClause("Where you present during the intake?", "yes"));    // +4

            rule.AddAntecedent(new LessClause("Number of refusals?", "1"));                     // +3
            rule.AddAntecedent(new GreaterClause("What is your competencies?", "4"));           // +4
            rule.AddAntecedent(new GreaterClause("What is your capacities?", "5"));             // +5
            rule.AddAntecedent(new GreaterClause("What is your intrinsic motivation?", "5"));   // +5
            rule.AddAntecedent(new GreaterClause("What is your extrinsic motivation?", "4"));   // +4

            rule.AddAntecedent(new IsClause("Are you MBO deficient?", "no"));                   // +2
            rule.AddAntecedent(new IsClause("Have you received any personal advice?", "no"));   // +1

            rule.AddAntecedent(new LessClause("Number of restrictions?", "3"));                 // +1

            rule.AddAntecedent(new IsClause("Have you received  any study choice?", "yes"));    // +5
            rule.AddAntecedent(new IsClause("Have you received a extra conversation?", "no"));  // +2
            rule.AddAntecedent(new IsClause("Do you need extra training on English?", "no"));   // +3
            rule.AddAntecedent(new IsClause("Do you need extra training on Dutch?", "no"));     // +4

            rule.setConsequent(new IsClause("advice", "positive"));
            rie.AddRule(rule);

            return rie;
        }
    }
}
