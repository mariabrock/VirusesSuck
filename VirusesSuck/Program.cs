using System;
using System.Collections.Generic;

namespace VirusesSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> ();

            // add items to the list one at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Measeles");
            names.Insert(0, "Shebola");

            //remove item from the list one at a time
            names.Remove("Measeles");
            // remove item at a certian index
            names.RemoveAt(3);

            // add multiple items
            var people = new List<string> { "Nathan", "Martin", "Randy's Kid" };
            //names.AddRange(new List<string> { "Nathan", "Martin", "Randy's Kid" });
            names.AddRange(people);

            // remove multiple items
            names.RemoveRange(names.Count - 3, 3); 

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //----------------------------------------------------
            //Dictionaries
            //----------------------------------------------------

            var symptoms = new Dictionary<string, string>();

            symptoms.Add("COVID-19", "Dry Cough, fever, respiratory problems, cancels everything");
            symptoms.Add("Ebola", "fever, headache, muscle pain, weakness");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");
            //you cannot add two entries with the same key. it will throw an exception stating that the entry already exists


            //get single thing
            var covidSymptoms = symptoms["COVID-19"] ;

            //remove single item
            symptoms.Remove("Ebola");

            //collection initializer
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                if(symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is uNkNoWn.");
                }
            }

            //-------------------------------------
            //Queues(FIFO)/Stacks(LILO)
            //-------------------------------------

            var diseasesToCure = new Queue<string>();

            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            var thingToCure = diseasesToCure.Dequeue();
            var nextThingToCure = diseasesToCure.Dequeue();


            //var diseasesToCure = new Stack<string>();
            //diseasesToCure.Push("SARS");
            //diseasesToCure.Push("COVID-19");

            //-------------------------------------
            //Hashset
            //-------------------------------------

            var vectors = new HashSet<string>();

            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");


            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Cancels Everything except work.");
            covid19.NumOfDeathsWorldwide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumOfDeathsWorldwide = 50000000;

            var rabies = new Virus("Rabies", 11);
            rabies.Symptoms.Add("Fever");
            rabies.Symptoms.Add("excess salivation");
            rabies.NumOfDeathsWorldwide = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and has killed {virus.NumOfDeathsWorldwide} wombats.");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms)}");

            }

            Console.ReadKey();
        }
    }
}
