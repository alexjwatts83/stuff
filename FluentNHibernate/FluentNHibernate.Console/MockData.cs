using System.Collections.Generic;
using FluentNHibernate.Domain.Models;
using NHibernate.Mapping;

namespace FluentNHibernate.Console
{
    public static class MockData
    {
        public static Question q1 = CreateQuestion("Is the Animal Big?");
        public static Question q2 = CreateQuestion("Does the animal have a Tail?");
        public static Question q3 = CreateQuestion("Does the animal have a Trunk?");
        public static Question q4 = CreateQuestion("Does the animal have a Long Neck?");
        public static Question q5 = CreateQuestion("Can the animal Roar?");

        public static Characteristic c1 = CreateCharacteristic("Is Big.");
        public static Characteristic c2 = CreateCharacteristic("Has Tail.");
        public static Characteristic c3 = CreateCharacteristic("Has Trunk.");
        public static Characteristic c4 = CreateCharacteristic("Has Long Neck.");
        public static Characteristic c5 = CreateCharacteristic("Can Roar.");

        public static QuestionCharacteristicLink qc1 = CreateQuestionCharacteristicLink(q1, c1);
        public static QuestionCharacteristicLink qc2 = CreateQuestionCharacteristicLink(q2, c2);
        public static QuestionCharacteristicLink qc3 = CreateQuestionCharacteristicLink(q3, c3);
        public static QuestionCharacteristicLink qc4 = CreateQuestionCharacteristicLink(q4, c4);
        public static QuestionCharacteristicLink qc5 = CreateQuestionCharacteristicLink(q5, c5);

        public static Animal a1 = CreateAnimal("Elephant", new List<Characteristic> {c1, c2, c3});
        public static Animal a2 = CreateAnimal("Giraffe", new List<Characteristic> {c1, c2, c4});
        public static Animal a3 = CreateAnimal("Lion", new List<Characteristic> {c1, c2, c5});

        public static Question CreateQuestion(string text)
        {
            return new Question()
            {
                Text = text
            };
        }

        public static Characteristic CreateCharacteristic(string description)
        {
            return new Characteristic()
            {
                Description = description
            };
        }

        public static QuestionCharacteristicLink CreateQuestionCharacteristicLink(Question question,
            Characteristic characteristic)
        {
            return new QuestionCharacteristicLink()
            {
                Question = question,
                Characteristic = characteristic
            };
        }

        public static Animal CreateAnimal(string type, List<Characteristic> characteristics)
        {
            return new Animal()
            {
                Type = type,
                Characteristics = characteristics
            };
        }
    }
}