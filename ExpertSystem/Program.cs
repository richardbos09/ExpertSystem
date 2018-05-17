using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using chen0040.ExpertSystem;

namespace ExpertSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine e = new Engine();

            RuleInferenceEngine rie = e.GetInferenceEngine();

            rie.ClearFacts();

            List<Clause> unproved_conditions = new List<Clause>();

            Clause conclusion = null;

            while (conclusion == null)
            {
                conclusion = rie.Infer("Advice", unproved_conditions);

                if (conclusion == null)
                {
                    if (unproved_conditions.Count == 0)
                    {
                        break;
                    }

                    Clause question = unproved_conditions[0];

                    unproved_conditions.Clear();

                    String value;

                    if (question.Variable == "What was your prior education?")
                    {
                        Console.WriteLine(question.Variable);

                        value = Console.ReadLine().ToLower();
                        value = e.prior_educations.Any(pe => pe.Contains(value)).ToString().ToLower();
                    }
                    else
                    {
                        Console.WriteLine(question.Variable);

                        value = Console.ReadLine();
                    }

                    rie.AddFact(new IsClause(question.Variable, value));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Conclusion: " + conclusion);
            Console.ReadKey();
        }
    }
}