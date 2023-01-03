﻿using Task_4;

Person person1 = new Person("Artyom", "Kozlov", new Adress(15, 69, "Lenkova", "Bobruisk"));
Person person2 = new Person("Valeria", "Romanovskaya", new Adress(78, 121, "Minskaya", "Minsk"));
Person person3 = new Person("Anastasia", "Skubo", new Adress(11, 4, "Bogdanovicha", "Vitebsk"));
Person person4 = new Person("Ivan", "Ivanov", new Adress(119, 35, "Centralnaya", "Minsk"));
Person person5 = new Person("Maksim", "Petrov", new Adress(73, 29, "Lesnaya", "Vitebsk"));

Candidate candidate1 = new Candidate(person1, new SubjectScore[] { new SubjectScore(87, "Math"),
                                                                   new SubjectScore(76, "Physics"),
                                                                   new SubjectScore(98, "Language")});

Candidate candidate2 = new Candidate(person2, new SubjectScore[] {new SubjectScore(65, "Math"),
                                                                  new SubjectScore(98, "Physics"),
                                                                  new SubjectScore(54, "Language")});


Candidate candidate3 = new Candidate(person3, new SubjectScore[] {new SubjectScore(77, "Math"),
                                                                  new SubjectScore(100, "Physics"),
                                                                  new SubjectScore(85, "Language")});

Candidate candidate4 = new Candidate(person4, new SubjectScore[] {new SubjectScore(99, "Math"),
                                                                  new SubjectScore(76, "Physics"),
                                                                  new SubjectScore(88, "Language")});

Candidate candidate5 = new Candidate(person5, new SubjectScore[] {new SubjectScore(65, "Math"),
                                                                  new SubjectScore(98, "Physics"),
                                                                  new SubjectScore(54, "Language")});

Candidate[] candidates = {candidate1,candidate2,candidate3,candidate4,candidate5};

foreach(Candidate candidate in candidates)
{
  ShownAdress(candidate.Person.Adress);
}

static void ShownAdress(Adress shownAdress)
{
    Console.WriteLine(" Street: " +shownAdress.Street );
}
int maxScore = GetMaxScore(candidates);
Console.WriteLine(maxScore);

static int GetMaxScore(Candidate[] scoreCandidates)
{
    int maxScore = 0;
    foreach (Candidate candidate in scoreCandidates)
    {
        foreach (SubjectScore score in candidate.SubjectScores)
        {
            if (score.SubjectName == "Language")
            {
                if(score.Score> maxScore)
                {
                    maxScore = score.Score;
                }
            }  
        }
    }
    return maxScore;
}
